
namespace WolvenKit.Views.Wizards
{
    public partial class UserWizardView
    {
        public UserWizardView()
        {
            InitializeComponent();
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordRPCHelper.WhatAmIDoing("User Wizard");
            }
        }
    }
}
