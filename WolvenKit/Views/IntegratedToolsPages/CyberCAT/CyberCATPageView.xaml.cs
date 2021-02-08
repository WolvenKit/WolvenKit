
namespace WolvenKit.Views.IntegratedToolsPages.CyberCAT
{
    public partial class CyberCATPageView
    {
        public CyberCATPageView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {

            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("CyberCAT Save Editor");
            }


        }
    }
}
