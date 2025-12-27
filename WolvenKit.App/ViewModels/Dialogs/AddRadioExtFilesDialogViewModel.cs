using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;


namespace WolvenKit.App.ViewModels.Dialogs;

class SongItem
{
    public string Name { get; set; } = "";
    public string FilePath { get; set; } = "";
    public int index { get; set; } = 0;
}

/// <summary>
/// A simple "search and replace" dialog. Needs to register in GenericHost via AddTransient.
/// </summary>
public partial class AddRadioExtFilesDialogViewModel() : ObservableObject
{
    /// <summary>
    /// Search text
    /// </summary>
    [ObservableProperty] private string? _stationName = "";

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty] private string? _iconFilePath = "";

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty] private List<string> _musicFiles = [];

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty] private List<SongItem> _songItems = [];

    /// <summary>
    /// Replace text
    /// </summary>
    [ObservableProperty]
    private double _frequency = double.Parse($"{new Random().Next(87, 108)}.{new Random().Next(0, 9)}");

    private void AddSong(string songTitle, string filePath)
    {
        // TODO
    }

    private void RemoveSong(string songTitle, string filePath)
    {
        // TODO
    }

    private void MoveSongOrder(string filePath, int newIndex)
    {
        // TODO
    }

}
