using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTTextureView : UserControl
    {
        public RDTTextureView()
        {
            InitializeComponent();
        }

        public void SaveImage(object sender, RoutedEventArgs e)
        {
            if (DataContext is not RDTTextureViewModel { Image: BitmapSource bitmapSource } textureViewModel)
            {
                return;
            }

            var saveFileDialog1 = new SaveFileDialog
            {
                Filter = "PNG Image|*.png",
                Title = "Save an Image As",
                FileName = Path.GetFileNameWithoutExtension(textureViewModel.FilePath)+"_embedded.png"
            };
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName == "")
            {
                return;
            }

            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapSource));

            using var fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            encoder.Save(fileStream);
        }

        public void ResetZoomPan(object sender, RoutedEventArgs e) => ImageCanvasItem.ResetZoomPan();
    }
}
