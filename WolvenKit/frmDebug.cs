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
using WolvenKit.Net;

namespace WolvenKit
{
    public partial class frmDebug : Form
    {
        public static Socket GameSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        public static IPEndPoint DebugProtoclAdress = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 37001);

        public static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        public static ManualResetEvent SendDone = new ManualResetEvent(false);
        public static ManualResetEvent ReceiveDone = new ManualResetEvent(false);
        public static Response.Data Response;

        public frmDebug()
        {
            InitializeComponent();
            statusLabel.Text = GameSocket.Connected ? "Status: Connected" : "Status: Disconnected";
        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(logbox.SelectedText);
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
                MessageBox.Show("Already connected!");
            }
            else
            {
                Connect(DebugProtoclAdress, GameSocket);
                if (GameSocket.Connected)
                {
                    statusLabel.Text = "Status: Connected";
                    MessageBox.Show("Connected!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    statusLabel.Text = "Status: Error";
                    MessageBox.Show("Failed to connect!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(@"Game is already running!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region Network callbacks
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
                AddOutput(e.ToString());
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
                AddOutput($"Sent {bytesSent} bytes to server."); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            SendDone.Set();
        }

        public class StateObject
        {
            // Client socket.  
            public Socket WorkSocket;
            // Size of receive buffer.  
            public const int BufferSize = 8192 * 32;
            // Receive buffer.  
            public byte[] Buffer = new byte[BufferSize];
        }

        public static void Receive(Socket client)
        {
            try
            {
                var state = new StateObject {WorkSocket = client};
                client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0,
                    ReceiveCallback, state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            var state = (StateObject)ar.AsyncState;
            var client = state.WorkSocket;
            var bytesRead = client.EndReceive(ar);
            if (state.WorkSocket.Available > 0)
            {
                client.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, ReceiveCallback, state);
            }
            else
            {
                if (state.Buffer.Length > 1)
                {
                    File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\res.bin", state.Buffer);
                    Response = new Response.Data(state.Buffer);
                    Console.WriteLine($"Recieved packet [{Response.Length} bytes]:");
                    Response.Params.ForEach(x => Console.WriteLine("\t" + x.Type + ": " + x.ToString()));
                }
                ReceiveDone.Set();
            }

        }

        #endregion
    }
}
