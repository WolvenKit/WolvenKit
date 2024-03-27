using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ReactiveUI;
using Splat;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Core.Interfaces;

enum LaunchGameProfile
{
    Directly,
    FromLastSave,
    FromSpecificSave,
}

namespace WolvenKit.Views.Shell
{
    public partial class RibbonView : ReactiveUserControl<RibbonViewModel>
    {
        private readonly ISettingsManager _settingsManager;
        private readonly ILoggerService _loggerService;
        private readonly ModifierViewStatesModel _modifierViewStatesModel = ModifierViewStatesModel.GetInstance();

        
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
                        view => view.ToolbarPackProjectOldButton)
                    .DisposeWith(disposables);
                this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.PackInstallModCommand,
                        view => view.ToolbarPackInstallOldButton)
                    .DisposeWith(disposables);

                // hotreload
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

                this.OneWayBind(ViewModel, vm => vm.LaunchProfileText,
                   view => view.LaunchProfileText.Text)
                   .DisposeWith(disposables);

                this.OneWayBind(ViewModel, vm => vm.MainViewModel.ActiveProject,
                    view => view.LaunchMenu.IsEnabled,
                    p => p is not null)
                    .DisposeWith(disposables);

                // game launch
                this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.LaunchGameCommand,
                    view => view.MenuItemLaunchGame)
                .DisposeWith(disposables);

                MenuItemLaunchGameFromLastSave.Click += MenuItemLaunchGameFromLastSave_Click;
            });

            _settingsManager.WhenAnyValue(x => x.LaunchProfiles).Subscribe(_ => GetLaunchProfiles());
            
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

        private void ReadGameFiles()
        {
            // get save files
            var saveDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Saved Games", "CD Projekt Red", "Cyberpunk 2077");
            if (!Directory.Exists(saveDir))
            {
                return;
            }

            // clear
            foreach (var item in MenuItemLaunchGameSave.Items)
            {
                if (item is MenuItem menuItem)
                {
                    menuItem.Click -= LaunchSaveItem_Click;
                }
            }

            MenuItemLaunchGameSave.Items.Clear();

            var directories = Directory.GetDirectories(saveDir)
                .Select(folder => new { Folder = folder, Save = Path.Combine(folder, "sav.dat") })
                .Where(x => File.Exists(x.Save))
                .Select(x => new
                {
                    DirName = new DirectoryInfo(x.Folder).Name,
                    Screenshot = Path.Combine(x.Folder, "screenshot.png"),
                    x.Save,
                    LastModified = new DirectoryInfo(x.Folder).LastWriteTime
                })
                .OrderByDescending(x => x.LastModified);


            // populate items
            foreach (var dir in directories)
            {
                var imageControl = new Image();
                var bitmapImage = new BitmapImage(new Uri(dir.Screenshot, UriKind.RelativeOrAbsolute));
                imageControl.Source = bitmapImage;

                MenuItem item = new() { Header = dir.DirName, ToolTip = imageControl };
                item.Click += LaunchSaveItem_Click;
                MenuItemLaunchGameSave.Items.Add(item);
            }
        }

        private void MenuItem_SubmenuOpened(object o, RoutedEventArgs args)
        {
            // TODO: Hacky workaround, fix with https://github.com/WolvenKit/WolvenKit/issues/1486
            if (_modifierViewStatesModel.IsShiftKeyPressed)
            {
                // launch game from last save
                MenuItemLaunchGameFromLastSave.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));

                // Close context menu again
                MenuHeaderLaunchGame.ContextMenu?.SetCurrentValue(MenuItem.IsEnabledProperty, false);
                return;
            }

            ReadGameFiles();
        }

        private void MenuItemLaunchGameFromLastSave_Click(object o, RoutedEventArgs _)
        {
            // prevent exceptions
            if (MenuItemLaunchGameSave is null)
            {
                return;
            }

            // if savegames not populated, populate savegames
            if (MenuItemLaunchGameSave.Items.Count is 0)
            {
                ReadGameFiles();
            }

            // prevent exceptions some more
            if (MenuItemLaunchGameSave.Items.Count is 0)
            {
                return;
            }

            MenuItem item = MenuItemLaunchGameSave.Items[0] as MenuItem;
            if (item != null)
            {
                item.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
            }

        }


        private void LaunchSaveItem_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is not MenuItem { Header: string header })
            {
                return;
            }

            // -save=ManualSave-168 
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = _settingsManager.GetRED4GameLaunchCommand(),
                    Arguments = $"{_settingsManager.GetRED4GameLaunchOptions()} -save={header}",
                    ErrorDialog = true,
                    UseShellExecute = true,
                });
            }
            catch (Exception ex)
            {
                _loggerService.Error("Launch: error launching game! Please check your executable path in Settings.");
                _loggerService.Info($"Launch: error debug info: {ex.Message}");
            }

        }
    }
}
