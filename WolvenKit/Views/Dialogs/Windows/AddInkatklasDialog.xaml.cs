using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ReactiveUI;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;
using Window = System.Windows.Window;

namespace WolvenKit.Views.Dialogs.Windows;

public partial class AddInkatklasDialog : IViewFor<AddInkatlasDialogViewModel>
{
    private static string s_lastSourceFolder = "";
    private static string s_lastRelativePath = "";
    private static string s_lastFileName = "inkatlas";
    private static int s_lastTileWidth = 0;
    private static int s_lastTileHeight = 0;

    public AddInkatklasDialog(Cp77Project activeProject)
    {
        InitializeComponent();

        ViewModel = new AddInkatlasDialogViewModel(activeProject);
        DataContext = ViewModel;

        LoadLastSelection();

        this.WhenActivated(disposables =>
        {
            // bind to filteredDropdownMenu
            this.Bind(ViewModel,
                    x => x.ProjectFolders,
                    x => x.FilterableDropdownMenu.Options)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.RelativePath,
                    x => x.FilterableDropdownMenu.SelectedOption)
                .DisposeWith(disposables);

            // bind rest of properties
            this.Bind(ViewModel,
                    x => x.RelativePath,
                    x => x.RelativePathBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.PngSourceDir,
                    x => x.PngFolderBox.Text)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                    x => x.TileWidth,
                    x => x.TileWidthBox.Text)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.TileHeight,
                    x => x.TileHeightBox.Text)
                .DisposeWith(disposables);
            this.Bind(ViewModel,
                    x => x.RememberValues,
                    x => x.RememberValuesCheckBox.IsChecked)
                .DisposeWith(disposables);
        });
    }

    public AddInkatlasDialogViewModel ViewModel { get; set; }

    object IViewFor.ViewModel
    {
        get => ViewModel;
        set => ViewModel = (AddInkatlasDialogViewModel)value;
    }

    public bool? ShowDialog(Window owner)
    {
        Owner = owner;
        return ShowDialog();
    }

    private void LoadLastSelection()
    {
        if (ViewModel is null)
        {
            return;
        }

        if (s_lastSourceFolder != "")
        {
            ViewModel.PngSourceDir = s_lastSourceFolder;
            ViewModel.RememberValues = true;
        }

        if (s_lastRelativePath != "")
        {
            ViewModel.RelativePath = s_lastRelativePath;
            ViewModel.RememberValues = true;
        }

        if (s_lastFileName != "")
        {
            ViewModel.InkatlasFileName = s_lastFileName;
            ViewModel.RememberValues = true;
        }

        if (s_lastTileHeight > 0)
        {
            ViewModel.TileHeight = $"{s_lastTileHeight}";
            ViewModel.RememberValues = true;
        }

        if (s_lastTileWidth > 0)
        {
            ViewModel.TileWidth = $"{s_lastTileWidth}";
            ViewModel.RememberValues = true;
        }
    }

    private void SaveLastSelection()
    {
        if (ViewModel is null)
        {
            return;
        }

        if (!ViewModel.RememberValues)
        {
            s_lastSourceFolder = "";
            s_lastRelativePath = "";
            s_lastFileName = "";
            s_lastTileHeight = 0;
            s_lastTileWidth = 0;
            return;
        }

        s_lastSourceFolder = ViewModel.PngSourceDir;
        s_lastFileName = ViewModel.InkatlasFileName;
        s_lastRelativePath = ViewModel.RelativePath;
        s_lastTileHeight = int.Parse(ViewModel.TileHeight);
        s_lastTileWidth = int.Parse(ViewModel.TileWidth);
    }

    private void WizardPage_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key != Key.Enter)
        {
            return;
        }

        SaveLastSelection();
        e.Handled = true;
        DialogResult = true;
        Close();
    }

    private void WizardControl_OnFinish(object sender, RoutedEventArgs e) => SaveLastSelection();

    private void FileButton_Click(object sender, RoutedEventArgs e)
    {
        if (ViewModel is not AddInkatlasDialogViewModel vm)
        {
            return;
        }

        using var folderDialog = new FolderBrowserDialog();
        folderDialog.Description = "Select the folder with your icon .png files";
        folderDialog.ShowNewFolderButton = true;

        if (folderDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
        {
            return;
        }

        vm.PngSourceDir = folderDialog.SelectedPath;
    }
}