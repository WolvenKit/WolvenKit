using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using NAudio.Extras;
using NAudioWpfDemo.AudioPlaybackDemo;
using WolvenKit.App.Models;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Wwise;

namespace WolvenKit.App.ViewModels.Tools;

// https://github.com/naudio/NAudio/blob/8e162ed1b1dc13491794ace46327e35d866465cc/NAudioWpfDemo/AudioPlaybackDemo/AudioPlaybackViewModel.cs
public partial class AudioPlayerViewModel : ObservableObject
{
    private readonly AudioPlayback _audioPlayback;
    private readonly List<IVisualizationPlugin> _visualizations = new();

    //[ObservableProperty]
    public string? FileName => Path.GetFileName(SelectedFile);

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FileName))]
    private string? _selectedFile;


    public AudioPlayerViewModel()
    {
        _audioPlayback = new AudioPlayback();
        _audioPlayback.MaximumCalculated += audioGraph_MaximumCalculated;
        _audioPlayback.FftCalculated += audioGraph_FftCalculated;
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Visualization))]
    private IVisualizationPlugin? _selectedVisualization;

    public IList<IVisualizationPlugin> Visualizations => _visualizations;

    public object? Visualization => SelectedVisualization?.Content;

    private void audioGraph_FftCalculated(object? sender, FftEventArgs e) => SelectedVisualization?.OnFftCalculated(e.Result);

    private void audioGraph_MaximumCalculated(object? sender, MaxSampleEventArgs e) => SelectedVisualization?.OnMaxCalculated(e.MinSample, e.MaxSample);

    [RelayCommand]
    private void OpenFile()
    {
        var openFileDialog = new OpenFileDialog
        {
            Filter = "All Supported Files (*.wav;*.mp3)|*.wav;*.mp3|All Files (*.*)|*.*"
        };
        var result = openFileDialog.ShowDialog();
        if (result.HasValue && result.Value)
        {
            SelectedFile = openFileDialog.FileName;
            _audioPlayback.Load(SelectedFile);
        }
    }

    [RelayCommand]
    private void Play()
    {
        if (SelectedFile != null)
        {
            _audioPlayback.Play();
        }
    }

    [RelayCommand]
    private void Stop() => _audioPlayback.Stop();

    [RelayCommand]
    private void Pause() => _audioPlayback.Pause();

    public void Dispose() => _audioPlayback.Dispose();

    public void LoadOggFile(AudioObject audioObject)
    {
        SelectedFile = audioObject.Title;

        var oggBuffer = Wem.Convert(audioObject.Data);

        var ms = new MemoryStream(oggBuffer);
        _audioPlayback.LoadOgg(ms);
    }

}
