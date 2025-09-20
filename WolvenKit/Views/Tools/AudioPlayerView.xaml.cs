using System;
using System.Linq;
using NAudioWpfDemo.AudioPlaybackDemo;
using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Tools;

namespace WolvenKit.Views.Tools;
/// <summary>
/// Interaktionslogik für AudioPlayerView.xaml
/// </summary>
public partial class AudioPlayerView : ReactiveUserControl<AudioPlayerViewModel>
{
    public AudioPlayerView()
    {
        ViewModel = Locator.Current.GetService<AudioPlayerViewModel>();

        // TODO do this properly
        ViewModel.Visualizations.Add(new SpectrumAnalyzerVisualization());
        ViewModel.Visualizations.Add(new PolygonWaveFormVisualization());
        ViewModel.Visualizations.Add(new PolylineWaveFormVisualization());
        ViewModel.SelectedVisualization = ViewModel.Visualizations.FirstOrDefault();

        DataContext = ViewModel;

        InitializeComponent();
    }


}
