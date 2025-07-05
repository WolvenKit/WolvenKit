using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Semver;
using Microsoft.VisualBasic.FileIO;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.HomePage;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.App.ViewModels.Scripting;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Exceptions;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Helpers;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using NativeMethods = WolvenKit.App.Helpers.NativeMethods;

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

        if (_archiveManager.ProjectArchive is not FileSystemArchive projArchive || ActiveProject is null)
        {
            _loggerService.Error("You need an active project to use this.");
            return;
        }

        var txtFilesInResources = ActiveProject.ResourceFiles.Where(f => f.EndsWith(".txt"))
            .Select(f => ActiveProject.GetRelativeResourcePath(f).GetResolvedText())
            .Where(f => !string.IsNullOrEmpty(Path.GetExtension(f?.Replace(".txt", ""))))
            .ToList();

        if (txtFilesInResources.Count > 0)
        {
            _loggerService.Warning(
                "One or more files in your resource folder have duplicate extensions and end in .txt. These won't do anything:");
            txtFilesInResources.ForEach(f => _loggerService.Warning($"\t{f}"));
        }

        var filesToValidate = projArchive.Files.Values.Where(f => f.Extension is not ".xbm" and not ".mlmask").ToList();
        
        var result = Interactions.ShowConfirmation((
            $"This will analyse {filesToValidate.Count} files. This can take up to several minutes. Do you want to proceed?",
            "Really run file validation?",
            WMessageBoxImage.Question,
            WMessageBoxButtons.YesNo));

        if (result != WMessageBoxResult.Yes)
        {
            return;
        }

        ScriptService.SuppressLogOutput = true;
        var redExtensions = Enum.GetNames<ERedExtension>().ToList();
        var code = await File.ReadAllTextAsync(_fileValidationScript.Path);

        foreach (var file in filesToValidate)
        {
            if (!redExtensions.Contains(file.Extension.TrimStart('.').ToLower()))
            {
                _loggerService.Warning($"{file.FileName} has an unsupported extension and will not be packed!");
                continue;
            }
            
            if (GetRedFile(file) is not { } fileViewModel)
            {
                continue;
            }

            _loggerService.Info($"Scanning {ActiveProject.GetRelativePath(file.FileName)}");
            ActiveDocument = fileViewModel;
            await _scriptService.ExecuteAsync(code);
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

        ScriptService.SuppressLogOutput = false;
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
            _loggerService.Error("to the object spawner from your script manager's user section, and restart the application.");
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
            Title = "Open object spawner export file",
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
        var code = await File.ReadAllTextAsync(_entSpawnerImportScript.Path);

        await _scriptService.ExecuteAsync(code);

        ActiveDocument = null;
        try
        {
            File.Delete(destPath);
        }
        catch
        {
            _loggerService.Error($"Failed to delete {filePath}. This file is no longer needed.");
        }

        // Check for and reload any modified streaming sector or related files that are currently open
        ReloadChangedFiles();
    }
}