using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace WolvenKit.App.ViewModels.Shell;

public partial class AppViewModel
{
    private bool CanImportPhotoModePoser() => CanShowProjectActions();

    [RelayCommand(CanExecute = nameof(CanImportPhotoModePoser))]
    private async Task ImportPhotoModePoser()
    {
        if (ActiveProject is null)
        {
            return;
        }

        var openFileDialog = new OpenFileDialog
        {
            Filter = "PhotoMode Poser pose packs (*.json)|*.json|All files (*.*)|*.*",
            Title = "Import PhotoMode Poser pose pack",
            RestoreDirectory = true
        };

        if (openFileDialog.ShowDialog() != true || !File.Exists(openFileDialog.FileName))
        {
            return;
        }

        try
        {
            var posePack = new FileInfo(openFileDialog.FileName);
            var outputDirectory = new DirectoryInfo(ActiveProject.ModDirectory);
            var results = await Task.Run(() => _photoModePoserImportTools.Import(posePack, outputDirectory));

            foreach (var result in results)
            {
                _loggerService.Info(
                    $"PhotoMode Poser: {result.PoseCount} pose(s) for {result.RigPath} -> {result.OutputPath}");
            }

            var poseCount = results.Sum(result => result.PoseCount);
            _notificationService.Success(
                $"Imported {poseCount} pose(s) into {results.Count} .anims file(s).");
        }
        catch (Exception exception)
        {
            _loggerService.Error(exception);
            _notificationService.Error("Could not import the PhotoMode Poser pose pack. Check the log for details.");
        }
    }
}
