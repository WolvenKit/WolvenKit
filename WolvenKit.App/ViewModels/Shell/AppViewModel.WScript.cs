using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.Common;
using WolvenKit.Helpers;

namespace WolvenKit.App.ViewModels.Shell;

public partial class AppViewModel : ObservableObject /*, IAppViewModel*/
{
    private readonly ScriptFileViewModel? _fileValidationScript;
    private readonly ScriptFileViewModel? _entSpawnerImportScript;

    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task RunFileValidationOnProject()
    {
        if (_fileValidationScript is null || !File.Exists(_fileValidationScript.Path))
        {
            _loggerService.Error("You need to update your Wolvenkit Scripts to use this. Please restart the application.");
            return;
        }

        if (_archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            _loggerService.Error("You need an active project to use this.");
            return;
        }

        var result = Interactions.ShowConfirmation((
            $"This will analyse {ActiveProject!.Files.Count} files. This can take up to several minutes. Do you want to proceed?",
            "Really run file validation?",
            WMessageBoxImage.Question,
            WMessageBoxButtons.YesNo));

        if (result != WMessageBoxResult.Yes)
        {
            return;
        }

        foreach (var (_, file) in projArchive.Files)
        {
            if (GetRedFile(file) is not { } fileViewModel)
            {
                continue;
            }

            _loggerService.Info($"Scanning {ActiveProject.GetRelativePath(file.FileName)}");
            ActiveDocument = fileViewModel;
            await _scriptService.ExecuteAsync(_fileValidationScript.ScriptFile);
        }

        // This should never happen, but better safe than sorry
        if (FileHelper.GetMostRecentlyChangedFile(Path.Combine(ISettingsManager.GetAppData(), "Logs"), "*.txt") is not FileInfo fI)
        {
            _loggerService.Info("Done.");
            return;
        }

        _loggerService.Info($"Done. The most recent log file is {fI.FullName}.");

        try
        {
            Process.Start(new ProcessStartInfo(fI.FullName) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            _loggerService.Error($"Failed to open log file: {ex.Message}");
        }
    }


    private readonly string EntspawnerExportRelPath =
        Path.Join("bin", "x64", "plugins", "cyber_engine_tweaks", "mods", "entSpawner", "export");

    private string? GetEntspawnerRelativePath()
    {
        if (SettingsManager.GetRED4GameRootDir() is not string gameDir)
        {
            return null;
        }

        return Path.Join(gameDir, EntspawnerExportRelPath);
    }

    private bool CanImportEntitySpawner() =>
        CanShowProjectActions() && GetEntspawnerRelativePath() is string path && Directory.Exists(path);

    [RelayCommand(CanExecute = nameof(CanImportEntitySpawner))]
    private async Task ImportFromEntitySpawner()
    {
        if (_entSpawnerImportScript is null || !File.Exists(_entSpawnerImportScript.Path))
        {
            _loggerService.Error("You need to update your Wolvenkit Scripts to use this. Please delete any scripts related");
            _loggerService.Error("to the entity spawner from your script manager's user section, and restart the application.");
            return;
        }

        if (_archiveManager.ProjectArchive is not FileSystemArchive projArchive)
        {
            _loggerService.Error("You need an active project to use this.");
            return;
        }

        // Grab a json file from the correct folder
        var openFileDialog = new OpenFileDialog
        {
            Filter = "Json files (*.json)|*.json|All files (*.*)|*.*",
            Title = "Open entSpawner export",
            InitialDirectory = GetEntspawnerRelativePath(),
        };

        openFileDialog.ShowDialog();

        if (openFileDialog.FileName is not string filePath)
        {
            return;
        }

        if (!File.Exists(filePath))
        {
            _loggerService.Error($"File {filePath} was not found.");
            return;
        }

        // Move it to the project - wscript can only deal with relative paths
        var destPath = Path.Combine(ActiveProject!.RawDirectory, Path.GetFileName(filePath));

        if (File.Exists(destPath))
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "A file with the same name already exists in the project. Do you want to overwrite it?",
                "Overwrite file",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return;
            }

            File.Delete(destPath);
        }

        File.Copy(filePath, destPath);

        ActiveDocument = await Open(destPath, EWolvenKitFile.WScript);

        await _scriptService.ExecuteAsync(_entSpawnerImportScript.ScriptFile);

        ActiveDocument = null;
        try
        {
            File.Delete(destPath);
        }
        catch
        {
            _loggerService.Error($"Failed to delete {filePath}. This file is no longer needed.");
        }
    }
}