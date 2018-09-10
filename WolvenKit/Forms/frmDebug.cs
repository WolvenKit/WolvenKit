using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanWassenhove.Util;
using WolvenKit.Net;

namespace WolvenKit
{
    public partial class frmDebug : Form
    {
        public static Socket GameSocket;
        public static IPEndPoint DebugProtoclAdress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 37001);

        public static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        public static ManualResetEvent SendDone = new ManualResetEvent(false);
        public static ManualResetEvent ReceiveDone = new ManualResetEvent(false);
        public static Response.Data Response;

        public event EventHandler VarlistRecieved;

        public static SortableBindingList<Variable> Variables = new SortableBindingList<Variable>();

        public frmDebug()
        {
            InitializeComponent();
            GameSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            VarlistRecieved += UpdateVarDgv;
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logbox.SelectedText ?? "");
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logbox.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sf = new SaveFileDialog {Title = "Please select where to save the log."};
            if (sf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(sf.FileName,logbox.Lines);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (GameSocket.Connected)
            {
                Commonfunctions.SendNotification("Already connected!");
            }
            else
            {
                Connect(DebugProtoclAdress, GameSocket);   
                if (GameSocket.Connected)
                {
                    statusLabel.Text = "Status: Connected";
                    Commonfunctions.SendNotification("Connected!");
                    DataRecieveWorker.RunWorkerAsync();
                }
                else
                {
                    statusLabel.Text = "Status: Error";
                    Commonfunctions.SendNotification("Failed to connect!");
                }
            }
        }

        private void startnetGameButton_Click(object sender, EventArgs e)
        {
            ExecuteGame();
        }

        private void taskkillButton_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + "taskkill -F /IM witcher3.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(processInfo);
        }

        private void startcostumGameButton_Click(object sender, EventArgs e)
        {
            var getparams = new Input("Please give the commands to launch the game with!");
            if (getparams.ShowDialog() == DialogResult.OK)
            {
                ExecuteGame(getparams.Resulttext);
            }
        }

        private void ExecuteGame(string args = "")
        {
            if (MainController.Get().Configuration == null)
                return;
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                Commonfunctions.SendNotification("Game is already running!");
                return;
            }
            var config = MainController.Get().Configuration;
            var proc = new ProcessStartInfo(config.ExecutablePath)
            {
                Arguments = args == "" ? "-net -debugscripts" : args,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            AddOutput("Executing " + proc.FileName + " " + proc.Arguments + "\n");

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var scriptlog = Path.Combine(documents, @"The Witcher 3\scriptslog.txt");
            if (File.Exists(scriptlog))
                File.Delete(scriptlog);
            Process.Start(proc);
        }

        private void AddOutput(string text)
        {
            logbox.AppendText(text + "\n");
            logbox.SelectionStart = logbox.Text.Length;
            logbox.ScrollToCaret();
        }

        private void CCommandButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.Execute(CommandTextBox.Text));
        }

        private void GetOpcodeButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.Opcode(FuncNameTextBox.Text, ClassnameTextBox.Text == "" ? null : ClassnameTextBox.Text));
        }

        private void VarListButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.Varlist(sectionTextBox.Text, nameTextBox.Text));
        }

        private void listmodsButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.Modlis());
        }

        private void GetPathButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.RootPath());
        }

        private void ScriptReloadButton_Click(object sender, EventArgs e)
        {
            Send(GameSocket, Commands.Reload());
        }

        public void UpdateVarDgv(object source,EventArgs args)
        {
            varDGV.Invoke((MethodInvoker) delegate
            {
                varDGV.DataSource = Variables;
                varDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (varDGV.ColumnCount > 0)
                {
                    for (var i = 0; i < varDGV.Columns.Count; i++)
                    {
                        varDGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        varDGV.Columns[i].ReadOnly = true;
                        varDGV.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    varDGV.Columns[varDGV.Columns.Count - 1].ReadOnly = false;
                }
            });
        }

        public void CheckResponse(Response.Data resdata)
        {
            //If we haven't recieved anything return
            if (resdata == null)
                return;

            if (resdata.Params.First().Type == Net.Response.ParamType.Int32)
            {
                if ((ulong)((Response.Int_32) (resdata.Params.First())).Value == 0xFFFFFFFFCC00CC00)
                {
                    varDGV.Invoke((MethodInvoker)delegate
                    {
                        for (int i = 2; i < resdata.Params.Count; i++)
                        {
                            if (i + 4 > resdata.Params.Count)
                                break;
                            var variable = new Net.Variable();
                            variable.byte1 = resdata.Params[i].ToString();
                            i++;
                            variable.byte2 = resdata.Params[i].ToString();
                            i++;
                            variable.Varname = resdata.Params[i].ToString();
                            i++;
                            variable.Section = resdata.Params[i].ToString();
                            i++;
                            variable.Value = resdata.Params[i].ToString();
                            Variables.Add(variable);
                        }
                    });
                }
            }
            VarlistRecieved?.Invoke(this,null);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this you need to send the game a varlist command (Utilities tab) with your desired criteria. After that's done this will be updated with the variables",
                "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void varDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (varDGV.CurrentCell.ColumnIndex == 2)
            {
                varDGV.BeginEdit(true);
            }
        }

        private void varDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Send(GameSocket, Commands.SetVar(varDGV[0, e.RowIndex].Value.ToString(),
                    varDGV[1, e.RowIndex].Value.ToString(),
                    varDGV[2, e.RowIndex].Value.ToString()));
            }
        }

        #region Network stuff
        private void DataRecieveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            logbox.Invoke((MethodInvoker)delegate {
                AddOutput("Started recieving!");
            });
            var dataIn = new byte[8192 * 32];
            while (GameSocket.Connected)
            {
                try
                {
                    var bytesRead = GameSocket.Receive(dataIn, dataIn.Length, SocketFlags.None);
                    if (bytesRead != -1)
                    {
                        Response = new Response.Data(dataIn);
                        CheckResponse(Response);
                        logbox.Invoke((MethodInvoker)delegate 
                        {
                            AddOutput("\nRecieved packet of " + Response.Params.Count + " params [" + bytesRead + " bytes]:\n" +
                                Response.Params.Aggregate("",(c,n) => c += (n.Type.ToString() + ": " + n.ToString()) + "\n"));
                        });
                    }
                    else
                    {
                        // -1 Bytes read should indicate the client shutdown on their end
                        break;
                    }
                }
                catch (SocketException)
                {
                    // You could exit this loop depending on the SocketException
                }
                catch (ThreadAbortException)
                {
                    MessageBox.Show("Fatal error with the socket!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    logbox.Invoke((MethodInvoker)delegate {
                        AddOutput("Error: " + ex.Message + "\n\n" + ex.StackTrace);
                    });
                }
            }
            GameSocket?.Close();
        }

        public void Connect(EndPoint remoteEp, Socket client)
        {
            client.BeginConnect(remoteEp,ConnectCallback, client);
            ConnectDone.WaitOne();
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                var client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                Commands.Init().ForEach(x=> Send(GameSocket,x));
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            ConnectDone.Set();
        }

        private void Send(Socket client, byte[] data)
        {
            if (!GameSocket.Connected)
                return;
            client.BeginSend(data, 0, data.Length, SocketFlags.None,
                SendCallback, client);
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                var client = (Socket)ar.AsyncState;
                var bytesSent = client.EndSend(ar);
                logbox.Invoke((MethodInvoker)delegate {
                    AddOutput("Sent " + bytesSent + " bytes.");
                });
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            SendDone.Set();
        }
        #endregion

        private void frmDebug_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataRecieveWorker.CancelAsync();
            GameSocket.Close();
        }
    }
}
