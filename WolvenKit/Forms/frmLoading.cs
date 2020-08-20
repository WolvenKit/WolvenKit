using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.App;

namespace WolvenKit.Forms
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {            
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MainController.Get().PropertyChanged += MainControllerUpdated;
            UIController.InitForm(this);
            this.VersionLbl.Text = "Version " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            this.copyrightLbl.Text = "https://github.com/Traderain/Wolven-kit";
        }

        private void frmLoading_Shown(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Witcher3").Length != 0)
            {
                if (MessageBox.Show(
                        "The Game is running. Please note that running the program like this makes some stuff unusable. Would you still like to run the program like this?",
                        "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    Environment.Exit(0);

                }
                else
                {
                    this.Close();
                }
                    
            }
            else
            {
                Application.DoEvents();
                Task.Factory.StartNew(() => MainController.Get().Initialize()); //Start the async task to load our stuff
            }
        }

        private delegate void strDelegate(string t);

        private delegate void boolDelegate(bool b);

        private void MainControllerUpdated(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "loadStatus")
                Invoke(new strDelegate(SetStatusLabelText), ((MainController)sender).loadStatus);
            if (e.PropertyName == "Loaded")
                Invoke(new boolDelegate(Finish), ((MainController) sender).Loaded);

        }

        private void Finish(bool b)
        {
            if(b)
                this.Close();
            else
            {
                LoadLbl.Text = "Failed to initialize!";
                Application.DoEvents();
                System.Threading.Thread.Sleep(3000);
                this.Close();
            }
        }

        private void SetStatusLabelText(string text)
        {
            LoadLbl.Text = text;
        }
    }
}
