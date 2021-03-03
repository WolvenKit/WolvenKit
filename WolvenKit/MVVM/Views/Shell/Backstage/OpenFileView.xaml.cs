// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenFileView.xaml.cs" company="WildGums">
//   Copyright (c) 2008 - 2017 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views
{
    public partial class OpenFileView
    {
        #region Constructors
        public OpenFileView()
        {
            InitializeComponent();
        }
        #endregion

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Backstage - Open File");
            }
        }
    }
}
