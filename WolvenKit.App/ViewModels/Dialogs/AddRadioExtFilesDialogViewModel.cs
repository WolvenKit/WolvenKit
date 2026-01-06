using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;


namespace WolvenKit.App.ViewModels.Dialogs;

public class RadioSongItem
{
    public string DisplayName { get; set; }
    public string FilePath { get; set; }
    public int Index { get; set; } = 0;

    public RadioSongItem(string filePath, int index = 0)
    {
        DisplayName = Path.GetFileName(filePath);
        FilePath = filePath;
        Index = index;
    }

    public override string ToString() => $"{Index:D2} - {FilePath}";

    public override bool Equals(object? obj) => obj is RadioSongItem other && FilePath == other.FilePath;

    public override int GetHashCode() => FilePath.GetHashCode();
}

/// <summary>
/// Dialog model to add/edit RadioExt station.
/// </summary>
public partial class AddRadioExtFilesDialogViewModel() : ObservableObject
{
    [ObservableProperty] private string? _stationName = "";

    [ObservableProperty] private string? _iconFilePath = "";

    [ObservableProperty] private string? _streamPath = "";
    [ObservableProperty] private string _lastRowLabel = "Songs:";

    [ObservableProperty] private bool _useStream = false;

    [ObservableProperty] private List<string> _musicFiles = [];

    [ObservableProperty] private List<RadioSongItem> _songItems = [];

    [ObservableProperty] private double _frequency = AddRadioExtFilesDialogViewModel.GetRandomFrequency();

    public string JsonFileFolder { get; set; } = "";
    public string InkatlasPath { get; set; } = "";
    public string InkatlasPart { get; set; } = "";

    public static AddRadioExtFilesDialogViewModel GetInstance(Cp77Project project, TemplateFileTools templateFileTools)
    {
        // read json file if we have one
        var jsonFiles = project.ResourceFiles.Where(f => f.EndsWith("metadata.json")).ToList() ?? [];

        if (jsonFiles.FirstOrDefault() is not string relativePath)
        {
            return new AddRadioExtFilesDialogViewModel();
        }

        return templateFileTools.LoadRadioProperties(Path.Join(project.ResourcesDirectory, relativePath));
    }


    private static double GetRandomFrequency() => new Random().Next(87, 198) + (new Random().Next(0, 1) / 10.0);

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(UseStream))
        {
            LastRowLabel = UseStream ? "Stream URL:" : "Songs:";
        }

        base.OnPropertyChanged(e);
    }

    public void AddSong(RadioSongItem songItem)
    {
        if (SongItems.Contains(songItem))
        {
            return;
        }

        var songItems = SongItems.ToList();
        if (songItems.FirstOrDefault(f => f.Index > 0) is not null)
        {
            songItem.Index = songItems.Count;
        }

        songItems.Add(songItem);
        SongItems = songItems;
    }

    public void AddSongs(List<RadioSongItem> newItems)
    {
        var filePaths = SongItems.Select(s => s.FilePath).ToList();
        newItems = newItems.Where(f => !filePaths.Contains(f.FilePath)).ToList();

        if (newItems.Count == 0)
        {
            return;
        }

        var songItems = SongItems.ToList();

        if (songItems.FirstOrDefault(s => s.Index > 0) is not null)
        {
            var offset = 0;
            foreach (var s in newItems)
            {
                s.Index = songItems.Count + offset;
                offset += 1;
            }
        }

        songItems.AddRange(songItems);
        SongItems = songItems;
    }

    public void RemoveSong(RadioSongItem songItem)
    {
        var index = SongItems.FindIndex(s => s.FilePath == songItem.FilePath);
        if (index == -1)
        {
            return;
        }

        SongItems.RemoveAt(index);
        for (var i = index; i < SongItems.Count; i++)
        {
            SongItems[i].Index = i;
        }

        SongItems = SongItems.ToList();
    }

    public void MoveSongOrder(RadioSongItem? songItem, int newIndex)
    {
        if (songItem is null || !SongItems.Contains(songItem))
        {
            return;
        }

        var songItems = SongItems.ToList();

        // Remove the item from its current position
        var currentIndex = songItems.IndexOf(songItem);
        if (currentIndex >= 0)
        {
            songItems.RemoveAt(currentIndex);
        }

        // Clamp newIndex and insert
        newIndex = Math.Min(Math.Max(newIndex, 0), songItems.Count);
        songItems.Insert(newIndex, songItem);

        // Recompute indices for all items
        for (var i = 0; i < songItems.Count; i++)
        {
            songItems[i].Index = i;
        }

        // Replace backing list so the ObservableProperty notifies
        SongItems = songItems;
    }

}
