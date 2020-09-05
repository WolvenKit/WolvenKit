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
using VGMToolbox.format.iso;
using WolvenKit.App;

namespace WolvenKit.Forms
{
    public partial class frmLoading : Form
    {
        private List<Bitmap> splashscreens = new List<Bitmap>() {
            WolvenKit.Properties.Resources.wkit_splash, //Jato
            WolvenKit.Properties.Resources.wkit_splash2 //Munchyfly
        }; 


        public frmLoading()
        {            
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            MainController.Get().PropertyChanged += MainControllerUpdated;
            UIController.InitForm(this);

            //Random rnd = new Random();
            //int i = rnd.Next(0, splashscreens.Count);
//            int i = 1;  // fix splashscreen to 1 in 0.6.2

//            this.BackgroundImage = splashscreens[i];
//
//           if (i == 0)
//            {
//                this.labelTitle.Visible = false;
//                this.labelVersion.Visible = false;
//                this.labelLoading.Visible = false;
//                this.labelLoadingJato.Visible = true;
//                this.labelVersionJato.Visible = true;
//            }

            this.labelVersion.Text = "Version " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            this.labelGit.Text = "https://github.com/Traderain/Wolven-kit";
//            this.labelVersionJato.Text = "Version " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

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
                labelLoading.Text = "Failed to initialize!";
                labelLoadingJato.Text = "Failed to initialize!";
                Application.DoEvents();
                System.Threading.Thread.Sleep(3000);
                this.Close();
            }
        }

        private void SetStatusLabelText(string text)
        {
            labelLoading.Text = text;
//            labelLoadingJato.Text = text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Traderain/Wolven-kit");
        }
    }
}
