using System.IO;
using System.Windows;
using ReactiveUI;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.Views.Dialogs;

public partial class ExtractEmbeddedFileDialog : ReactiveUserControl<ExtractEmbeddedFileDialogViewModel>
{
    public ExtractEmbeddedFileDialog()
    {
        InitializeComponent();
    }

    private void CancelButton_OnClick(object sender, RoutedEventArgs e)
    {
        ViewModel.UserCanceled = true;
        ViewModel.Close();
    }

    private void ExtractButton_OnClick(object sender, RoutedEventArgs e)
    {
        ViewModel.NewFilePath.SanitizeFilePath();

        if (File.Exists(Path.Join(ViewModel.ProjectPath, ViewModel.NewFilePath)))
        {
            var result = Interactions.ShowConfirmation((
                "The file already exists in the project. Do you want to overwrite it?",
                "File Already Exists",
                WMessageBoxImage.Question,
                WMessageBoxButtons.YesNo));
            if (result != WMessageBoxResult.Yes)
            {
                return;
            }
        }

        if (ViewModel.NewFilePath == ViewModel.EmbeddedFilePath)
        {
            ViewModel.NotificationService?.Warning("The archive file path is the same as the embedded file path, this may conflict with a vanilla or mod file.");
        }

        ViewModel.Close();
    }
}

