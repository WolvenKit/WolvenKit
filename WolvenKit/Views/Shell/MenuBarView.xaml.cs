using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Shell;
using WolvenKit.Views.Dialogs;
using WolvenKit.Views.Dialogs.Windows;

namespace WolvenKit.Views.Shell;
/// <summary>
/// Interaction logic for MenuBarView.xaml
/// </summary>
public partial class MenuBarView : ReactiveUserControl<MenuBarViewModel>
{
    private AppViewModel _mainViewModel;


    public static MaterialsRepositoryDialog MaterialsRepositoryDia { get; set; }

    public MenuBarView()
    {
        ViewModel = Locator.Current.GetService<MenuBarViewModel>();
        DataContext = ViewModel;

        InitializeComponent();

        this.WhenActivated(disposables =>
        {

            _mainViewModel = Locator.Current.GetService<AppViewModel>();


            // Home
            this.BindCommand(ViewModel,
                       viewModel => viewModel.MainViewModel.ShowHomePageCommand,
                       view => view.HomeButton)
                   .DisposeWith(disposables);
            // File
            this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.NewFileCommand,
                        view => view.MenuItemNewFile)
                    .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.SaveFileCommand,
                    view => view.MenuItemSave)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.SaveAsCommand,
                    view => view.MenuItemSaveAs)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.SaveAllCommand,
                    view => view.MenuItemSaveAll)
                .DisposeWith(disposables);
            // Project
            this.BindCommand(ViewModel,
                       viewModel => viewModel.MainViewModel.NewProjectCommand,
                       view => view.MenuItemNewProject)
                   .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                       viewModel => viewModel.MainViewModel.OpenProjectCommand,
                       view => view.MenuItemOpenProject)
                   .DisposeWith(disposables);


            // Edit
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.ShowSettingsCommand,
                    view => view.ToolbarSettingsButton)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.ShowProjectSettingsCommand,
                    view => view.ToolbarProjectSettingsButton)
                .DisposeWith(disposables);

            // Build
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.PackModCommand,
                    view => view.MenuItemPackProject)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.PackInstallModCommand,
                    view => view.MenuItemPackInstallProject)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.PackInstallRunModCommand,
                    view => view.MenuItemPackInstallRunProject)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.HotInstallModCommand,
                    view => view.MenuItemHotInstallProject)
                .DisposeWith(disposables);

            // View

            // Tools
            this.BindCommand(ViewModel,
                    viewModel => viewModel.MainViewModel.ShowSoundModdingToolCommand,
                    view => view.MenuItemShowSoundModdingTool)
                .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                        viewModel => viewModel.OpenGameFolderCommand,
                        view => view.MenuItemOpenGameFolder)
                    .DisposeWith(disposables);

            // Game
            this.BindCommand(ViewModel,
                        viewModel => viewModel.MainViewModel.LaunchGameCommand,
                        view => view.ToolbarLaunchButton)
                    .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                       viewModel => viewModel.MainViewModel.LaunchGameCommand,
                       view => view.ToolbarLaunchSteamButton)
                   .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                       viewModel => viewModel.MainViewModel.LaunchGameCommand,
                       view => view.ToolbarPackInstallLaunchButton)
                   .DisposeWith(disposables);

            //this.Bind(ViewModel,
            //       viewModel => viewModel.MainViewModel.SelectedGameCommandIdx,
            //       view => view.ToolbarLaunchCombobox.SelectedIndex)
            //   .DisposeWith(disposables);
            //this.OneWayBind(ViewModel,
            //        viewModel => viewModel.MainViewModel.SelectedGameCommands,
            //        view => view.ToolbarLaunchCombobox.ItemsSource)
            //    .DisposeWith(disposables);

            // Extensions
            this.BindCommand(ViewModel,
                   viewModel => viewModel.MainViewModel.ShowPluginCommand,
                   view => view.MenuItemShowPluginTool)
               .DisposeWith(disposables);
            this.BindCommand(ViewModel,
                   viewModel => viewModel.MainViewModel.ShowModsViewCommand,
                   view => view.MenuItemShowModsView)
               .DisposeWith(disposables);



            // visibility
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.ProjectExplorer.IsVisible,
                    view => view.ProjectExplorerCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.AssetBrowserVM.IsVisible,
                    view => view.AssetBrowserCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                viewModel => viewModel.MainViewModel.PropertiesViewModel.IsVisible,
                    view => view.PropertiesCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.Log.IsVisible,
                    view => view.LogCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.ImportExportToolVM.IsVisible,
                    view => view.ImportExportCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.TweakBrowserVM.IsVisible,
                    view => view.TweakBrowserCheckbox.IsChecked)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    viewModel => viewModel.MainViewModel.LocKeyBrowserVM.IsVisible,
                    view => view.LocKeyBrowserCheckbox.IsChecked)
                .DisposeWith(disposables);
        });
    }

    private void SetLayoutToDefault(object sender, RoutedEventArgs e) => DockingAdapter.G_Dock.LoadLayoutDefault();
    private void SaveLayoutToProject(object sender, RoutedEventArgs e) => DockingAdapter.G_Dock.SaveLayoutToProject();
    private void GenerateMaterialRepoButton_Click(object sender, RoutedEventArgs e)
    {
        if (MaterialsRepositoryDia == null)
        {
            var x = new MaterialsRepositoryDialog();
            MaterialsRepositoryDia = x;
            x.Owner = Application.Current.MainWindow;
            x.ShowDialog();
        }
    }

}
