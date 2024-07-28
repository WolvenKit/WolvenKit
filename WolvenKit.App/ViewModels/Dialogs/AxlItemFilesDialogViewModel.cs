using System;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using WolvenKit.App.Services;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class AxlItemFilesDialogViewModel(
    IProjectManager projectManager,
    ILoggerService loggerService)
    : DialogViewModel
{
    [ObservableProperty] private string? _depotPath;

    [ObservableProperty] private string? _fileName;


    private void CreateFactoryFile()
    {
        // base\gameplay\factories\test\characters_test.csv
    }

    public bool CreateItemFiles()
    {
        if (!projectManager.IsProjectLoaded)
        {
            throw new WolvenKitException(0x4003, "No project loaded");
        }

        if (DepotPath is not string s || s == "")
        {
            throw new Exception("Depot path is empty");
        }

        var directoryPath = Path.Combine(projectManager.ActiveProject!.FileDirectory, DepotPath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // create the control files: 
        // - .csv
        // - .archive.xl
        // - .yaml
        // - .json
        // - .inkatlas
        // - .xbm

        loggerService.Info("hi");

        return true;
    }
}