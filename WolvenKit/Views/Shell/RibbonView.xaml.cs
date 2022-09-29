using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        private readonly ISettingsManager _settingsManager;

        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            GetLaunchProfiles();

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


                this.BindCommand(ViewModel,
                        viewModel => viewModel.LaunchOptionsCommand,
                        view => view.LaunchOptionsMenuItem)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                       viewModel => viewModel.LaunchProfileCommand,
                       view => view.LaunchProfileButton)
                   .DisposeWith(disposables);

                this.OneWayBind(ViewModel, vm => vm.LaunchProfileText,
                   view => view.LaunchProfileText.Text)
                   .DisposeWith(disposables);

                this.OneWayBind(ViewModel, vm => vm.MainViewModel.ActiveProject,
                    view => view.LaunchMenu.IsEnabled,
                    p => p is not null)
                    .DisposeWith(disposables);
            });
        }

        private void GetLaunchProfiles()
        {
            // add default profiles
            if (_settingsManager.LaunchProfiles is null || _settingsManager.LaunchProfiles.Count == 0)
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"WolvenKit.Resources.launchprofiles.json");
                var defaultprofiles = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, LaunchProfile>>(stream, new System.Text.Json.JsonSerializerOptions()
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                });

                _settingsManager.LaunchProfiles = defaultprofiles;
            }


            foreach (var (name, value) in _settingsManager.LaunchProfiles)
            {
                var item = new MenuItem
                {
                    Header = name
                };

                // Create image element to set as icon on the menu element
                //Image icon = new Image();
                //BitmapImage bmImage = new BitmapImage();
                //bmImage.BeginInit();
                //bmImage.UriSource = new Uri(imagePath, UriKind.Absolute);
                //bmImage.EndInit();
                //icon.Source = bmImage;
                //icon.MaxWidth = 25;
                //item.Icon = icon;

                item.Click += new RoutedEventHandler(LaunchMenu_MenuItem_Click);

                LaunchMenuMainItem.Items.Insert(0, item);
            }
        }

        private void LaunchMenu_MenuItem_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
