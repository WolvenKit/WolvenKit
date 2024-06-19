using System;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;

        public const string LaunchOptionsString = "Launch Options";
        
        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();
            _loggerService = Locator.Current.GetService<ILoggerService>();

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
                // pack redmod
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackRedModCommand,
                        view => view.ToolbarPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallRedModCommand,
                        view => view.ToolbarPackInstallRedmodButton)
                    .DisposeWith(disposables);
                
                // pack legacy mod
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackModCommand,
                        view => view.ToolbarPackProjectLegacyButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.ToolbarPackInstallLegacyButton)
                    .DisposeWith(disposables);

                // HotReload
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.HotInstallModCommand,
                        view => view.ToolbarHotInstallButton)
                    .DisposeWith(disposables);

                // Launch profiles
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.LaunchOptionsCommand,
                        view => view.LaunchOptionsMenuItem)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                       viewModel => viewModel.LaunchProfileCommand,
                       view => view.LaunchProfileButton)
                   .DisposeWith(disposables);

                this.Bind(ViewModel, vm => vm.LaunchProfileText,
                   view => view.LaunchProfileText.Text)
                   .DisposeWith(disposables);

                // Active project: Disable/Enable buttons
                this.OneWayBind(ViewModel, vm => vm.MainViewModel.ActiveProject,
                    view => view.LaunchMenu.IsEnabled,
                    p => p is not null)
                    .DisposeWith(disposables);

            });

            if (ViewModel is not null && !string.IsNullOrEmpty(_settingsManager.LastLaunchProfile))
            {
                ViewModel.LaunchProfileText = _settingsManager.LastLaunchProfile;
            }

            _settingsManager.WhenAnyValue(x => x.LaunchProfiles).Subscribe(_ => GetLaunchProfiles());
            
        }

            
        private void GetLaunchProfiles()
        {
            // unsubscribe
            foreach (var obj in LaunchMenuMainItem.Items)
            {
                if (obj is not MenuItem { Header: string menuitemHeader } menuitem || menuitemHeader == LaunchOptionsString)
                {
                    continue;
                }

                menuitem.Click -= LaunchMenu_MenuItem_Click;
            }

            // delete all except for last two (separator and "Launch options")
            var cntToRemove = LaunchMenuMainItem.Items.Count - 2;
            for (var i = 0; i < cntToRemove; i++)
            {
                LaunchMenuMainItem.Items.RemoveAt(0);
            }

            var count = 0;
            foreach (var (name, _) in _settingsManager.LaunchProfiles)
            {
                MenuItem item = new()
                {
                    Header = name
                };

                item.Click += LaunchMenu_MenuItem_Click;

                LaunchMenuMainItem.Items.Insert(count, item);
                count++;
            }

            if (ViewModel is not null && ViewModel.LaunchProfileText is null && _settingsManager.LaunchProfiles.Count > 0)
            {
                ViewModel.LaunchProfileText = _settingsManager.LaunchProfiles.First().Key;
            }
        }

        private void LaunchMenu_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel is null || e.Source is not MenuItem { Header: string header })
            {
                return;
            }

            ViewModel.LaunchProfileText = header;
            _settingsManager.LastLaunchProfile = header;
        }
    }
}
