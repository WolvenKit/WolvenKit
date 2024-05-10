using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.Views.Others;

namespace WolvenKit.Views.Documents;
/// <summary>
/// Interaktionslogik für RDTLayeredTextureView.xaml
/// </summary>
public partial class RDTLayeredTextureView : UserControl
{
    public RDTLayeredTextureView()
    {
        InitializeComponent();
    }

    private void ResetZoomPan(object sender, RoutedEventArgs e) => ImageCanvasItem.ResetZoomPan();

    private void Layer_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var listBox = (ListBox)sender;
        if (listBox.SelectedItem is RDTLayeredPreviewViewModel.ImageEntry item)
        {
            ImageCanvasItem.SetCurrentValue(ImageCanvas.SourceProperty, item.Source);
        }
    }
}
