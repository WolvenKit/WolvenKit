using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;

namespace WolvenKit.App.ViewModels.Shell;

public partial class AppViewModel
{
    private static readonly string s_photoModePoserPosePacksRelPath = Path.Join(
        "bin",
        "x64",
        "plugins",
        "cyber_engine_tweaks",
        "mods",
        "PhotoModePoser",
        "data",
        "pose_packs");

    private string? GetPhotoModePoserGameDir()
    {
        if (SettingsManager.GetRED4GameRootDir() is not string gameDir)
        {
            return null;
        }

        return Path.Join(gameDir, s_photoModePoserPosePacksRelPath);
    }

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

        var posePacksDirectory = GetPhotoModePoserGameDir();
        if (posePacksDirectory is not null && Directory.Exists(posePacksDirectory))
        {
            openFileDialog.InitialDirectory = posePacksDirectory;
        }

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
