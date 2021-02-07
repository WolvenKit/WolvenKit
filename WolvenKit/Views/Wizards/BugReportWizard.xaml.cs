
namespace WolvenKit.Views.Wizards
{
    public partial class BugReportWizard
    {
        public BugReportWizard()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("Bug Report Wizard");
            }
        }
    }
}

