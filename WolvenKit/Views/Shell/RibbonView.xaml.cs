using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        private readonly ISettingsManager _settingsManager;
        //private bool _profilesLoaded;

        public RibbonView()
        {
            ViewModel = Locator.Current.GetService<RibbonViewModel>();
            DataContext = ViewModel;
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            //GetLaunchProfiles();

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
                        viewModel => viewModel.MainViewModel.PackRedModCommand,
                        view => view.ToolbarPackProjectButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallRedModCommand,
                        view => view.ToolbarPackInstallRedmodButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.HotInstallModCommand,
                        view => view.ToolbarHotInstallButton)
                    .DisposeWith(disposables);


                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.LaunchOptionsCommand,
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

            _settingsManager.WhenAnyValue(x => x.LaunchProfiles).Subscribe(dict =>
            {
                //if (_profilesLoaded)
                {
                    GetLaunchProfiles();
                }

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
                _settingsManager.Save();
            }

            // unsubscribe
            foreach (var obj in LaunchMenuMainItem.Items)
            {
                if (obj is MenuItem menuitem && menuitem.Header is string menuitemHeader)
                {
                    if (menuitemHeader == "Launch Options")
                    {
                        continue;
                    }
                    menuitem.Click -= LaunchMenu_MenuItem_Click;
                }
            }
            // delete all except for last two
            var cntToRemove = LaunchMenuMainItem.Items.Count - 2;
            for (var i = 0; i < cntToRemove; i++)
            {
                LaunchMenuMainItem.Items.RemoveAt(0);
            }


            var count = 0;
            foreach ((var name, var value) in _settingsManager.LaunchProfiles)
            {
                MenuItem item = new()
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

                LaunchMenuMainItem.Items.Insert(count, item);
                count++;
            }

            if (_settingsManager.LaunchProfiles is not null || _settingsManager.LaunchProfiles.Count != 0)
            {
                ViewModel.LaunchProfileText = _settingsManager.LaunchProfiles.First().Key;
            }

            //_profilesLoaded = true;
        }

        private void LaunchMenu_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is MenuItem item)
            {
                if (item.Header is string header)
                {
                    ViewModel.LaunchProfileText = header;
                }
            }
        }
    }
}
