using System;
using System.IO;
using System.Linq;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.Helpers;

namespace WolvenKit.Services;

public class NpvCreationService(IProjectManager projectManager, IAppArchiveManager archiveManager, IGameControllerFactory gameController)
    : INpvCreationService
{
    private NpvCreationDialogViewModel _viewModel;
    private string _relativePath = "";
    private string _destFolder = "";

    private const string FemFolderPath = @"base\characters\head\player_base_heads\player_female_average";
    private const string MascFolderPath = @"base\characters\head\player_base_heads\player_man_average";

    /// <summary>
    /// Blatantly assumign we're given a valid model here
    /// </summary>
    /// <param name="viewModel"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void CreateNpv(NpvCreationDialogViewModel viewModel)
    {
        if (!projectManager.IsProjectLoaded)
        {
            return;
        }

        _viewModel = viewModel;

        if (!CreateDirectoryAndAddFiles())
        {
            return;
        }

    }

    /// <summary>
    /// Create the destination directory for the player's NPV and adds the morphtarget files
    /// </summary>
    /// <returns>success or failure</returns>
    private bool CreateDirectoryAndAddFiles()
    {
        if (_viewModel is null || projectManager.ActiveProject is null)
        {
            return false;
        }

        _relativePath = projectManager.ActiveProject.GetRelativePath(_viewModel.DestFolderPath);
        _relativePath = projectManager.ActiveProject.GetAbsolutePath(_relativePath);

        _destFolder =
            $"{projectManager.ActiveProject.ModDirectory}{Path.DirectorySeparatorChar}{_relativePath.Replace('/', Path.DirectorySeparatorChar)}";

        /*
         * Create folder path, if we don't have one
         */
        if (Directory.Exists(_destFolder))
        {
            var result = Interactions.ShowConfirmation((
                $"The folder {_viewModel.DestFolderPath} exists and will be overwritten. Do you want to continue?",
                "File Modified",
                WMessageBoxImage.Question,
                WMessageBoxButtons.YesNo));

            if (result is not WMessageBoxResult.Yes)
            {
                return false;
            }
        }

        Directory.CreateDirectory(_destFolder);

        var sourcePath = _viewModel.BodyGender == NpvBodyGender.Male ? MascFolderPath : FemFolderPath;
        foreach (var gameFile in archiveManager.GetGroupedFiles()[".morphtarget"]
                     .Where(f => Path.GetDirectoryName(f.FileName) == sourcePath))
        {
            gameController.GetController().AddToMod(gameFile, ArchiveManagerScope.Basegame);
        }

        return true;
    }

}