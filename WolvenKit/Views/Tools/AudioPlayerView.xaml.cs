using System;
using System.ComponentModel;
using System.IO;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Models;
using WolvenKit.Core.Wwise;
using WolvenKit.Views.Editor.AudioTool;
using WPFSoundVisualizationLib;

namespace WolvenKit.Views.Tools;
/// <summary>
/// Interaktionslogik für AudioPlayerView.xaml
/// </summary>
public partial class AudioPlayerView
{
    public AudioPlayerView()
    {
        InitializeComponent();

        NAudioSimpleEngine.Instance.PropertyChanged += NAudioSimpleEngine_PropertyChanged;

        spectrumAnalyzer.RegisterSoundPlayer(NAudioSimpleEngine.Instance);
        waveformTimeline.RegisterSoundPlayer(NAudioSimpleEngine.Instance);
    }

    [RelayCommand(CanExecute = nameof(CanPlay))]
    private void Play() => NAudioSimpleEngine.Instance.Play();
    private bool CanPlay() => NAudioSimpleEngine.Instance.CanPlay;

    [RelayCommand(CanExecute = nameof(CanPause))]
    private void Pause() => NAudioSimpleEngine.Instance.Pause();
    private bool CanPause => NAudioSimpleEngine.Instance.CanPause;

    [RelayCommand(CanExecute = nameof(CanStop))]
    private void Stop() => NAudioSimpleEngine.Instance.Stop();
    private bool CanStop => NAudioSimpleEngine.Instance.CanStop;

    private void NAudioSimpleEngine_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case "CanPlay":
                PlayCommand.NotifyCanExecuteChanged();
                break;
            case "CanPause":
                PauseCommand.NotifyCanExecuteChanged();
                break;
            case "CanStop":
                StopCommand.NotifyCanExecuteChanged();
                break;
            case "ChannelPosition":
                clockDisplay.SetCurrentValue(DigitalClock.TimeProperty, TimeSpan.FromSeconds(NAudioSimpleEngine.Instance.ChannelPosition));
                break;
            default:
                break;
        }
    }

    public void OpenFile(string filePath)
    {
        NAudioSimpleEngine.Instance.OpenFile(filePath);
        RunnerText.SetCurrentValue(ContentProperty, Path.GetFileNameWithoutExtension(filePath));
    }

    public void OpenAudioObject(AudioObject audioObject)
    {
        var oggBuffer = Wem.Convert(audioObject.Data);

        var ms = new MemoryStream(oggBuffer);
        NAudioSimpleEngine.Instance.OpenOggStream(ms);
        RunnerText.SetCurrentValue(ContentProperty, audioObject.Title);
    }
}
