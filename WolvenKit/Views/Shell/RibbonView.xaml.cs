using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;

            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                // toolbar
                // File
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewFileCommand,
                        view => view.ToolbarNewButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveFileCommand,
                        view => view.ToolbarSaveButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveAsCommand,
                        view => view.ToolbarSaveAsButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.SaveAllCommand,
                        view => view.ToolbarSaveAllButton)
                    .DisposeWith(disposables);
                // project

                // pack
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackModCommand,
                        view => view.ToolbarPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.ToolbarPackInstallButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallRunModCommand,
                        view => view.ToolbarInstallRunButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.HotInstallModCommand,
                        view => view.ToolbarHotInstallButton)
                    .DisposeWith(disposables);

            });
        }

    }
}
