using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Exceptions;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.Helpers;

public class RadioExtStreamInfo
{
    public string StreamURL { get; set; } = "";
    public bool IsStream { get; set; } = false;
}

public class RadioExtIcon
{
    public string InkAtlasPath { get; set; } = "";
    public string InkAtlasPart { get; set; } = "";
    public bool UseCustom { get; set; } = false;
}

public class RadioExtStation
{
    public string DisplayName { get; init; } = "";
    public double Fm { get; init; } = 0.0;
    public double Volume { get; init; } = 1.0;
    public string Icon { get; set; } = "UIIcon.alcohol_absynth";
    public RadioExtIcon CustomIcon { get; set; } = new();
    public RadioExtStreamInfo StreamInfo { get; init; } = new();
    public string[] Order { get; set; } = [];
}

public partial class TemplateFileTools
{
    private static readonly string s_subfolderPath =
        Path.Combine("bin", "x64", "plugins", "cyber_engine_tweaks", "mods", "radioExt", "radios");

    private const string s_metadataFileName = "metadata.json";

    private static RadioExtStation ReadJson(string absolutePath)
    {
        if (!File.Exists(absolutePath))
        {
            throw new WolvenKitException(0, $"{s_metadataFileName} not found: {absolutePath}");
        }

        var json = File.ReadAllText(absolutePath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        try
        {
            return JsonSerializer.Deserialize<RadioExtStation>(json, options)
                   ?? throw new WolvenKitException(0, $"Failed to deserialize JSON in {absolutePath}");
        }
        catch (JsonException ex)
        {
            throw new WolvenKitException(0, $"Invalid JSON in {absolutePath}: {ex.Message}");
        }
    }

    private void CreateInkatlas(AddRadioExtFilesDialogViewModel model, string modderName)
    {
        if (string.IsNullOrEmpty(model.IconFilePath) || !File.Exists(model.IconFilePath) ||
            _projectManager.ActiveProject is not { } project)
        {
            return;
        }

        var destDir = Directory.CreateTempSubdirectory();
        File.Copy(model.IconFilePath, Path.Combine(destDir.FullName, "icon.png"));

        var relativePath = Path.Combine(modderName, "radio_stations", model.StationName!.ToFileName());
        var fileName = $"{model.StationName!.ToFileName()}_atlas";

        if (!string.IsNullOrEmpty(model.InkatlasPath) && Path.GetDirectoryName(model.InkatlasPath) is string p &&
            Path.GetFileName(model.InkatlasPath) is string f && !string.IsNullOrEmpty(p) && !string.IsNullOrEmpty(f))
        {
            relativePath = p;
            fileName = f;
        }
        else
        {
            model.InkatlasPath = Path.Combine(relativePath, $"{fileName}.inkatlas");
        }

        InkatlasImageGenerator.GenerateAtlas(
            pngFolder: destDir.FullName,
            relativeSourcePath: relativePath,
            atlasFileName: fileName,
            tileWidth: 200,
            tileHeight: 200,
            _cr2WTools,
            project
        );
    }

    private void SerializeToJson(AddRadioExtFilesDialogViewModel model, string modderName)
    {
        var station = new RadioExtStation
        {
            DisplayName = model.StationName ?? "Unnamed Station",
            Fm = model.Frequency,
            Volume = 1.0,
            Icon = "",
            StreamInfo = new RadioExtStreamInfo
            {
                IsStream = model.UseStream, StreamURL = model.UseStream ? model.StreamPath ?? "" : ""
            },
            Order = model.UseStream
                ? []
                : model.SongItems.OrderBy(s => s.Index).Select(s => s.DisplayName).ToArray()
        };

        CreateInkatlas(model, modderName);

        if (model.InkatlasPath is string inkatlasPath && !string.IsNullOrEmpty(inkatlasPath))
        {
            station.Icon = "";
            station.CustomIcon = new RadioExtIcon
            {
                UseCustom = true, InkAtlasPath = inkatlasPath ?? "", InkAtlasPart = "icon"
            };
        }


        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(station, options);

        var absolutePath = Path.Combine(model.JsonFileFolder ?? "", s_metadataFileName);
        File.WriteAllText(absolutePath, json);
    }


    private static readonly List<string> s_audioFileExtensions =
        [".mp3", ".wav", ".ogg", ".flac", ".mp2", ".wax", ".wma"];

    public AddRadioExtFilesDialogViewModel LoadRadioProperties(string absolutePath)
    {
        try
        {
            var station = ReadJson(absolutePath);

            var stationFileFolder = Path.GetDirectoryName(absolutePath) ?? absolutePath.Replace(s_metadataFileName, "");

            var model = new AddRadioExtFilesDialogViewModel
            {
                StationName = station.DisplayName,
                Frequency = Math.Round(station.Fm, 1),
                JsonFileFolder = stationFileFolder,
            };

            if (station.CustomIcon.UseCustom)
            {
                model.InkatlasPath = station.CustomIcon.InkAtlasPath;
                model.InkatlasPart = station.CustomIcon.InkAtlasPart;
            }

            if (station.StreamInfo.IsStream)
            {
                model.UseStream = true;
                model.StreamPath = station.StreamInfo.StreamURL;
                station.Order = [];
                return model;
            }

            model.UseStream = false;

            var songs = station.Order.ToList();
            List<RadioSongItem> songItems = [];

            // Add files from mod folder

            var filesInMod = Directory.GetFiles(stationFileFolder)
                .Where(f => s_audioFileExtensions.Contains(Path.GetExtension(f))).ToList();
            foreach (var file in filesInMod)
            {
                var fileName = Path.GetFileName(file);
                songs = songs.Where(f => !fileName.EndsWith(f)).ToList();
                songItems.Add(new RadioSongItem(file, 0));
            }

            if (station.Order.Length > 0)
            {
                var songIdx = 0;
                foreach (var songName in station.Order)
                {
                    if (songItems.FirstOrDefault(f => f.DisplayName == songName) is not RadioSongItem item)
                    {
                        continue;
                    }

                    item.Index = songIdx;
                    model.AddSong(item);
                    songIdx += 1;
                }
            }

            if (songs.Count > 0)
            {
                _loggerService.Error("No audio files found for the following songs:\n\t" +
                                     string.Join("\n\t", songs)
                                     + "\nThey will be removed from your radio. To include them, please add them again via dialogue.");
                _notificationService.Error("Some audio files are missing. Please check the console for details.");
            }

            model.AddSongs(songItems);
            return model;
        }
        catch
        {
            // ignore
        }

        return new AddRadioExtFilesDialogViewModel();
    }


    private void CopyFilesToModFolder(AddRadioExtFilesDialogViewModel viewModel)
    {
        if (_projectManager.ActiveProject is not { } project)
        {
            throw new WolvenKitException(0, "No active project.");
        }

        if (string.IsNullOrEmpty(viewModel.JsonFileFolder))
        {
            viewModel.JsonFileFolder = Path.Combine(project.ResourcesDirectory, s_subfolderPath,
                viewModel.StationName!.ToFileName());
        }

        var songPaths = viewModel.SongItems.Select(f => f.FilePath).ToList();

        var songsToDelete = Directory.GetFiles(project.ResourcesDirectory)
            .Where(f => s_audioFileExtensions.Contains(Path.GetExtension(f)) && !songPaths.Contains(f)).ToList();


        if (songsToDelete.Count > 0)
        {
            var question = "Delete the following song files from the project? You can't undo this!" +
                           string.Join("\n", songsToDelete);
            if (Interactions.ShowQuestionYesNo((question, "Delete Unused Songs")))
            {
                foreach (var songFilePath in songsToDelete)
                {
                    File.Delete(songFilePath);
                }
            }
        }


        var songsOutsideOfProject =
            viewModel.SongItems.Where(s => !s.FilePath.StartsWith(project.FileDirectory)).ToList();

        if (songsOutsideOfProject.Count == 0)
        {
            return;
        }


        var sourceDestPath = songsOutsideOfProject.ToDictionary(x => x,
            s => Path.Combine(viewModel.JsonFileFolder, Path.GetFileName(s.FilePath)));

        // Check for duplicates and ask if we want to overwrite them
        var existingFiles = sourceDestPath.Values.Where(File.Exists).ToList();
        var overwrite = false;
        if (existingFiles.Count > 0)
        {
            overwrite = Interactions.ShowQuestionYesNo(("Some files already exist in the destination folder:\n\t" +
                                                        string.Join("\n\t", existingFiles) +
                                                        "\n\nDo you want to overwrite them?",
                "Overwrite Existing Files"));
        }

        foreach (var kvp in sourceDestPath)
        {
            File.Copy(kvp.Key.FilePath, kvp.Value, overwrite);
            kvp.Key.FilePath = kvp.Value;
        }
    }

    public void CreateRadio(AddRadioExtFilesDialogViewModel model, string modderName, Cp77Project project)
    {
        CopyFilesToModFolder(model);
        SerializeToJson(model, modderName);

        var msg = "You can now install your mod!";
        if (project.RawFiles.Any(f => f.HasFileExtension(".png")) &&
            !project.ModFiles.Any(f => f.HasFileExtension(".xbm")))
        {
            msg = "Use the import tool to import your icon as .xbm, then install your mod!";
        }

        _notificationService.Success($"Radio station written to metadata.json. {msg}");
        _loggerService.Success($"Radio station written to metadata.json. {msg}");


    }


}
