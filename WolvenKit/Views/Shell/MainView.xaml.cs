using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Input;
using AdonisUI.Controls;
using Catel.Data;
using Catel.IoC;
using ReactiveUI;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Layout.MLib;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.Views.Shell
{
    public partial class MainView : IViewFor<WorkSpaceViewModel>
    {
        public WorkSpaceViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (WorkSpaceViewModel)value;
        }

        public MainView(WorkSpaceViewModel vm = null)
        {
            ViewModel = vm ?? ServiceLocator.Default.ResolveType<WorkSpaceViewModel>();
            DataContext = ViewModel;

            InitializeComponent();

            StaticReferences.MainView = this;
        }

        protected override void OnClosing(CancelEventArgs e) => Application.Current.Shutdown();
    }
}
