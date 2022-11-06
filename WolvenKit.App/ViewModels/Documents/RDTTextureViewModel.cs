using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.Other;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class RDTTextureViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;

        protected readonly RedImage _image;

        public delegate void RenderDelegate();
        public RenderDelegate Render;
        public bool IsRendered;

        public RDTTextureViewModel(RedBaseClass data, RedDocumentViewModel file)
        {
            Header = "Texture Preview";
            File = file;
            _data = data;
            _image = RedImage.FromRedClass(data);

            Render = SetupImage;
        }

        public RDTTextureViewModel(Stream stream, RedDocumentViewModel file)
        {
            Header = "Texture Preview";
            File = file;

            var buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);

            _image = RedImage.LoadFromDDSMemory(buffer);

            Render = SetupImage;
        }

        public override void OnSelected() => Render?.Invoke();

        protected void SetupImage()
        {
            if (IsRendered)
            {
                return;
            }

            if (_image.Metadata.Format == DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM)
            {
                return;
            }

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(_image.GetPreview());
            bitmapImage.EndInit();

            Image = bitmapImage;
            IsRendered = true;
        }

        public void UpdateFromImage()
        {
            if (_data is CBitmapTexture xbm)
            {
                xbm.Width = (uint)Image.Width;
                xbm.Height = (uint)Image.Height;
                if (File.GetMainFile().Value is RDTDataViewModel file)
                {
                    file.Chunks[0].Properties.Where(x => x.Name is "Width" or "Height").ToList().ForEach(x => x.RaisePropertyChanged("Data"));
                }
            }
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public bool IsDragging { get; set; }

    }
}
