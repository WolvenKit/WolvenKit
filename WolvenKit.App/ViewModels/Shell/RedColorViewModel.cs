using System.Reactive;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.App.ViewModels.Shell;

public partial class RedColorViewModel : ChunkPropertyViewModel
{
    public RedColorViewModel(CColor prop) : base(prop)
    {
        DisplayColor = new Color() { A = prop.Alpha, R = prop.Red, G = prop.Green, B = prop.Blue };
    }

    [ObservableProperty]
    private Color _displayColor;


    [RelayCommand]
    private void SelectedColor(object e)
    {
        dynamic d = e;
        var mediaColor = d.Brush.Color;
        DisplayColor = mediaColor;

        var c = System.Drawing.Color.FromArgb(mediaColor.A, mediaColor.R, mediaColor.G, mediaColor.B);
        
        throw new TodoException("Color conversion");
        //(Property as RED4.Types.CColor)?.SetValue(c);
    }
}
