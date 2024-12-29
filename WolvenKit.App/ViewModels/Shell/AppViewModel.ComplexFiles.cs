using System.Collections.Generic;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Interfaces.Extensions;
using YamlDotNet.RepresentationModel;

namespace WolvenKit.App.ViewModels.Shell;

public partial class AppViewModel : ObservableObject /*, IAppViewModel*/
{
    [RelayCommand(CanExecute = nameof(CanShowProjectActions))]
    private void NewPhotoModeFiles()
    {
        if (_projectManager.ActiveProject is not Cp77Project activeProject)
        {
            return;
        }

        if (SettingsManager.ModderName is not string modderName || modderName == string.Empty)
        {
            Interactions.ShowMessageBox(
                "Please set a name in the preferences (Home -> Settings -> General -> Your Name) before using this feature",
                "Configure your settings!");
            return;
        }

        var dialogModel = Interactions.ShowPhotoModeDialogue((activeProject, SettingsManager));

        if (dialogModel is null)
        {
            return;
        }

        var relativePhotoModeFolder = dialogModel.PhotomodeRelativeFolder.Trim();

        var relativeEntFilePath = GetRelativePath(dialogModel.EntFileName);
        var relativeAppFilePath = GetRelativePath(dialogModel.AppFileName);

        var inkatlasFileName = string.IsNullOrEmpty(dialogModel.InkatlasFileName)
            ? "photomode_preview_icon.inkatlas"
            : dialogModel.InkatlasFileName;
        var relativeInkatlasFilePath = GetRelativePath(inkatlasFileName);
        /*
         * Copy and connect .app and .ent file
         */

        ProjectExplorerViewModel.SuspendFileWatcherStatic();
        try
        {
            
            var appearanceNames = TemplateFileHelper.CreatePhotoModeAppAndEnt(
                _projectManager.ActiveProject, _loggerService,
                new PhotomodeEntAppOptions()
                {
                    AppSourceRelPath = dialogModel.SelectedApp,
                    AppDestRelPath = relativeAppFilePath,
                    EntSourceRelPath = dialogModel.SelectedEnt,
                    EntDestRelPath = relativeEntFilePath,
                    TargetDir = relativePhotoModeFolder,
                    WriteAppFile = dialogModel.IsCreateAppFile,
                    WriteEntFile = dialogModel.IsCreateEntFile,
                    BodyGender = dialogModel.SelectedBodyGender,
                    IsOverwrite = dialogModel.IsOverwrite
                }
            );


            var absolutePhotomodeFolder = Path.Join(activeProject.ModDirectory, relativePhotoModeFolder);

            /*
             * Copy inkatlas files
             */
            if (dialogModel.IsCreateInkatlasFile)
            {
                TemplateFileHelper.CopyInkatlasTemplateSingle(
                    activeProject,
                    Path.Join(activeProject.ModDirectory, relativeInkatlasFilePath),
                    dialogModel.IsOverwrite);
            }

            /*
             * Create yaml file
             */
            if (dialogModel.IsCreateYamlFile)
            {
                var yamlTargetDir =
                    ProjectResourceHelper.AppendPersonalDirectory(
                        Path.Combine(_projectManager.ActiveProject.ResourcesDirectory, "r6", "tweaks"));

                TemplateFileHelper.CreatePhotomodeYaml(new PhotomodeYamlOptions()
                {
                    NpcName = dialogModel.NpcName,
                    InkatlasPath = relativeInkatlasFilePath,
                    IconName = "custom_icon",
                    ModderName = modderName,
                    BodyGender = dialogModel.SelectedBodyGender,
                    YamlFileAbsolutePath = Path.Join(yamlTargetDir, dialogModel.YamlFileName),
                    EntFilePath = relativeEntFilePath,
                    Overwrite = dialogModel.IsOverwrite
                });
            }

            // keep outside of if loop because we need this for the .xl file generation
            var jsonFileRelativePath = @"path\to\your\file.json";
            if (!string.IsNullOrEmpty(dialogModel.JsonFileName))
            {
                jsonFileRelativePath = dialogModel.JsonFileName.StartsWith(relativePhotoModeFolder)
                    ? dialogModel.JsonFileName 
                : Path.Combine(relativePhotoModeFolder, dialogModel.JsonFileName);
            }

            if (dialogModel.IsCreateJsonFile)
            {
                var locKey =
                    $"{modderName.ToFileName()}_{dialogModel.NpcName.ToFileName()}_photomode_i18n";
                
                var jsonFileAbsolutePath = Path.Combine(activeProject.ModDirectory, jsonFileRelativePath);

                if (File.Exists(jsonFileAbsolutePath) && dialogModel.IsOverwrite)
                {
                    File.Delete(jsonFileAbsolutePath);
                }
                
                TemplateFileHelper.CreateOrAppendToJsonFile(
                    jsonFileAbsolutePath,
                    new Dictionary<string, string> { { locKey, dialogModel.NpcName } },
                    dialogModel.IsOverwrite,
                    _loggerService
                );
            }

            if (dialogModel.IsCreateXlFile && !string.IsNullOrEmpty(dialogModel.XlFileName))
            {
                var xlPath = Path.Combine(activeProject.ResourcesDirectory, $"{dialogModel.XlFileName}");
                if (File.Exists(xlPath) && dialogModel.IsOverwrite)
                {
                    File.Delete(xlPath);
                }

                var scopeName = dialogModel.SelectedBodyGender switch
                {
                    PhotomodeBodyGender.Cat => "photomode_cat.ent",
                    PhotomodeBodyGender.Massive => "photomode_mm.ent",
                    PhotomodeBodyGender.Big => "photomode_mb.ent",
                    PhotomodeBodyGender.Male => "photomode_ma.ent",
                    PhotomodeBodyGender.Female => "photomode_wa.ent",
                    _ => "photomode_wa.ent",
                };

                if (!File.Exists(xlPath))
                {
                    var i18Node = YamlHelper.CreateLocalizationNode(jsonFileRelativePath);
                    var scopeNode = YamlHelper.CreateScopeNode(scopeName, [relativeEntFilePath]);
                    var rootNode = new YamlMappingNode { { "localization", i18Node }, { "resource", scopeNode } };
                    YamlHelper.WriteYaml(xlPath, rootNode);
                }
            }

            var absoluteAppFilePath = Path.Join(absolutePhotomodeFolder, dialogModel.SelectedApp);
            if (dialogModel.IsCreateAppFile && File.Exists(absoluteAppFilePath))
            {
                var facialAnim = dialogModel.SelectedBodyGender switch
                {
                    PhotomodeBodyGender.Male => SelectAnimationPathViewModel.FacialAnimPathMale,
                    PhotomodeBodyGender.Female => SelectAnimationPathViewModel.FacialAnimPathFemale,
                    PhotomodeBodyGender.Big => SelectAnimationPathViewModel.FacialAnimPathMale,
                    PhotomodeBodyGender.Massive => SelectAnimationPathViewModel.FacialAnimPathMale,
                    PhotomodeBodyGender.Cat => SelectAnimationPathViewModel.FacialAnimPathFemale,
                    _ => SelectAnimationPathViewModel.FacialAnimPathFemale,
                };
                DocumentTools.SetFacialAnimations(absoluteAppFilePath, facialAnim,
                    null, SelectAnimationPathViewModel.PhotomodeAnimEntriesFemaleDefault);
            }

            _loggerService.Success("Done! Your photo mode NPV should now work!");
        }
        finally
        {
            ProjectExplorerViewModel.ResumeFileWatcherStatic();
        }

        return;

        string GetRelativePath(string pathOrFileName)
        {
            if (activeProject.ModFiles.Contains(pathOrFileName))
            {
                return pathOrFileName;
            }

            if (pathOrFileName.EndsWith(".yaml"))
            {
                return Path.Combine(ProjectResourceHelper.AppendPersonalDirectory("r6", "tweaks"), pathOrFileName);
            }

            return Path.Combine(relativePhotoModeFolder, pathOrFileName);
        }
    }
}