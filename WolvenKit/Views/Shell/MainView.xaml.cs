using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using AvalonDock.Layout.Serialization;
using Catel.Data;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Layout.MLib;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Shell
{
    public partial class MainView
    {
        #region fields

        private const string AvalonDockConfigPath = @".\Config\AvalonDock.Layout.config";

        #endregion fields

        #region Constructors

        public MainView()
        {
            InitializeComponent();

            var path = Path.GetFullPath(AvalonDockConfigPath);

            StaticReferences.MainView = this;
        }

        #endregion Constructors

        #region Methods

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            base.OnViewModelPropertyChanged(e);

            if (e is not AdvancedPropertyChangedEventArgs property)
            {
                return;
            }

            switch (property.PropertyName)
            {
                default:
                    break;
            }
        }

        #endregion Methods

        private void UserControl_IsVisibleChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible && IsLoaded)
            {
              //  DiscordHelper.SetDiscordRPCStatus("Main View");
            }
        }
    }
}
