﻿using System.IO;
using System.Threading.Tasks;
using Microsoft.Win32;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

public class OpenFileViewModel : DialogViewModel
{
    private readonly ISettingsManager _settingsManager;
    private readonly IProjectManager _projectManager;
    private readonly ILoggerService _loggerService;

    public OpenFileViewModel(
        ISettingsManager settingsManager,
        IProjectManager projectManager,
        ILoggerService loggerService)
    {
        _settingsManager = settingsManager;
        _projectManager = projectManager;
        _loggerService = loggerService;
    }
    
    public async Task<string?> OpenFile()
    {
        if (!_projectManager.IsProjectLoaded)
        {
            throw new WolvenKitException(0x4003, "No project loaded");
        }

        if (_settingsManager.ExtraModDirPath is null)
        {
            throw new WolvenKitException(0x4001, "No extra mod directory configured");
        }

        if (!Directory.Exists(_settingsManager.ExtraModDirPath))
        {
            throw new FileNotFoundException(
                $"Directory not found: {_settingsManager.ExtraModDirPath}. Please make sure the directory exists and is writable.");
        }

        var openFileDialog = new OpenFileDialog { Filter = Filter, Title = Title };

        if (openFileDialog.ShowDialog() == true)
        {
            FileName = openFileDialog.FileName;
        }

        if (openFileDialog.FileName is not string filePath)
        {
            _loggerService.Info("No file selected.");
            return null;
        }

        var fileName = Path.GetFileName(filePath);

        var wasCopied = await CopyFile(filePath, fileName);

        return wasCopied ? fileName : null;
    }

    private async Task<bool> CopyFile(string filePath, string fileName)
    {
        var modDirPath = Path.Join(_settingsManager.GetRED4GameRootDir(), "archive", "pc", "mod");

        var destPath = Path.Join(_settingsManager.ExtraModDirPath, fileName);

        if (File.Exists(destPath))
        {
            var response = await Interactions.ShowMessageBoxAsync(
                "You already have a copy of this mod in your extra mod directory. Overwrite it?",
                "File already exists!",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return false;
            }

            File.Delete(destPath);
        }
        else if (File.Exists(Path.Join(modDirPath, fileName)))
        {
            destPath = Path.Join(modDirPath, fileName);

            var response = await Interactions.ShowMessageBoxAsync(
                "A mod with this name is already installed to your game directory. Overwrite it?",
                "File already exists!",
                WMessageBoxButtons.YesNo);

            if (response == WMessageBoxResult.No)
            {
                return false;
            }

            File.Delete(destPath);
        }

        File.Copy(filePath, destPath);

        return true;
    }

    public string Title { get; set; } = "Open file";
    public string Filter { get; set; } = "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";

    public string? FileName { get; set; }
}