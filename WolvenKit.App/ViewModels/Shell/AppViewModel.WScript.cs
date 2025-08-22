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
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.CSharp.RuntimeBinder;
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

    private static readonly string[] s_ignoredExtensions = [".xbm", ".mlmask"];

    private static readonly string[] s_packIgnoredExtensions = ["bin"];

    private static readonly string[] s_resourceFileExtensions = ["xl", "yaml", "yml"];

    [NotifyCanExecuteChangedFor(nameof(CancelFileValidationCommand))]
    [NotifyCanExecuteChangedFor(nameof(RunFileValidationOnProjectCommand))]
    [ObservableProperty]
    private bool _fileValidationRunning = false;

    private CancellationTokenSource? _scanCancellationTokenSource;

    private bool CanCancelFileValidation => CanShowProjectActions() && FileValidationRunning;

    [RelayCommand(CanExecute = nameof(CanCancelFileValidation))]
    private void CancelFileValidation()
    {
        _scanCancellationTokenSource?.Cancel();
        FileValidationRunning = false;
    }

    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private async Task RunFileValidationOnProject()
    {
        if (FileValidationRunning || _scanCancellationTokenSource is not null)
        {
            CancelFileValidation();
            _loggerService.Info("Cancelled current run of file validation");
        }

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

        var shiftKeyDown = ModifierViewStateService.IsShiftBeingHeld;
        var ctrlKeyDown = ModifierViewStateService.IsCtrlBeingHeld;

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

        var filesToValidate = projArchive.Files.Values
            .Where(f => !s_ignoredExtensions.Contains(f.Extension.ToLower()))
            // no *.ext.json
            .Where(f => !f.Extension.Contains("json") || string.IsNullOrEmpty(
                Path.GetExtension(f.FileName.Replace(".json", ""))))
            .ToList();

        var resourceFilesToValidate = ActiveProject.ResourceFiles
            .Where(f => s_resourceFileExtensions.Contains(f.Split(".").LastOrDefault() ?? "")).ToList();

        if (ctrlKeyDown && resourceFilesToValidate.Count > 0)
        {
            _loggerService.Info(
                $"Ctrl key down: analyzing {filesToValidate.Count} project files (ignoring resources).");
            resourceFilesToValidate.Clear();
        }

        if (shiftKeyDown && resourceFilesToValidate.Count > 0)
        {
            _loggerService.Info(
                $"Shift key down: analyzing {resourceFilesToValidate.Count} resource files (ignoring project files).");
            filesToValidate.Clear();
        }

        var totalFileCount = filesToValidate.Count + resourceFilesToValidate.Count;

        if (totalFileCount == 0)
        {
            _loggerService.Info("No files to validate - you're funny!");
            return;
        }

        if (ActiveDocument is null && resourceFilesToValidate.Count > 0)
        {
            ScriptService.SuppressLogOutput = false;
            _loggerService.Info("Resource file validation needs an active document!");
            return;
        }

        // arbitrary cutoff: warn user if more than 5 files
        if (totalFileCount > 5)
        {
            var result = Interactions.ShowConfirmation((
                $"This will analyse {totalFileCount} files. This can take up to several minutes. Do you want to proceed?",
                "Really run file validation?",
                WMessageBoxImage.Question,
                WMessageBoxButtons.YesNo));

            if (result != WMessageBoxResult.Yes)
            {
                return;
            }
        }

        var code = await File.ReadAllTextAsync(_fileValidationScript.Path);

        await ValidateFilesAsync(code);


        return;

        async Task ValidateFilesAsync(string fileCode, CancellationToken cancellationToken = default)
        {
            _scanCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            FileValidationRunning = true;

            ScriptService.SuppressLogOutput = true;
            ScriptService.AbortOnRerun = true;
            var redExtensions = Enum.GetNames<ERedExtension>().ToList();

            try
            {
                foreach (var file in filesToValidate)
                {
                    var fileExtension = file.Extension.TrimStart('.').ToLower();
                    if (!redExtensions.Contains(fileExtension) && !s_packIgnoredExtensions.Contains(fileExtension))
                    {
                        continue;
                    }

                    if (GetRedFile(file) is not { } fileViewModel)
                    {
                        continue;
                    }

                    _loggerService.Info($"Scanning {ActiveProject.GetRelativePath(file.FileName)}");

                    // Wrap it into an extra layer of async, because checking the token in the script service
                    // will lead to a "wkit is not defined" exception in the script layer
                    await Task.Run(async () => await _scriptService.ExecuteAsync(code),
                        _scanCancellationTokenSource.Token);
                }

                foreach (var file in resourceFilesToValidate)
                {
                    var fileExtension = (file.Split(".").LastOrDefault() ?? "").TrimStart('.').ToLower();
                    if (!s_resourceFileExtensions.Contains(fileExtension))
                    {
                        // _loggerService.Warning($"Skipping resource file {file}");
                        continue;
                    }

                    var originalFilePath = ActiveDocument!.FilePath;
                    ActiveDocument.FilePath = $"resources\\{file}";

                    try
                    {
                        // Wrap it into an extra layer of async, because checking the token in the script service
                        // will lead to a "wkit is not defined" exception in the script layer
                        await Task.Run(async () => await _scriptService.ExecuteAsync(code),
                            _scanCancellationTokenSource.Token);
                    }
                    finally
                    {
                        ActiveDocument.FilePath = originalFilePath;
                    }
                }

                _loggerService.Success("File validation complete.");
            }
            catch (OperationCanceledException)
            {
                _loggerService.Info("File validation was cancelled.");
            }
            catch (Exception err)
            {
                _loggerService.Error(err.Message);
            }
            finally
            {
                _scanCancellationTokenSource.Dispose();
                _scanCancellationTokenSource = null;
                ScriptService.SuppressLogOutput = false;
                ScriptService.AbortOnRerun = false;
                FileValidationRunning = false;
            }

            _loggerService.Info(
                "To open the most recent log file, shift-click on the 'open folder' button to the right.");
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
