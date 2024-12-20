using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public class RDTLayeredPreviewViewModel : RedDocumentTabViewModel
{
    public ObservableCollection<ImageEntry> Images { get; } = new();

    public RDTLayeredPreviewViewModel(Multilayer_Mask multilayerMask, RedDocumentViewModel parent) : base(parent, "Texture Preview")
    {
        ModTools.ConvertMultilayerMaskToDdsStreams(multilayerMask, out var streams);

        for (var i = 0; i < streams.Count; i++)
        {
            var buffer = new byte[streams[i].Length];
            _ = streams[i].Read(buffer, 0, buffer.Length);

            if (RedImage.LoadFromDDSMemory(buffer) is not { } redImage)
            {
                throw new Exception();
            }

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(redImage.GetPreview(true));
            bitmapImage.EndInit();

            Images.Add(new ImageEntry($"Layer {i:D3}", bitmapImage));
        }
    }

    public RDTLayeredPreviewViewModel(CTextureArray textureArray, RedDocumentViewModel parent) : base(parent, "Texture Preview")
    {
        if (RedImage.FromTexArray(textureArray) is not { } redImage)
        {
            throw new Exception();
        }

        for (var i = 0; i < redImage.Metadata.ArraySize; i++)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(redImage.GetPreview(true, i));
            bitmapImage.EndInit();

            Images.Add(new ImageEntry($"Index {i:D3}", bitmapImage));
        }
    }

    public RDTLayeredPreviewViewModel(CReflectionProbeDataResource reflectionProbe, RedDocumentViewModel parent) : base(parent, "Texture Preview")
    {
        if (RedImage.FromEnvProbe(reflectionProbe) is not { } redImage)
        {
            throw new Exception();
        }

        for (var i = 0; i < redImage.Metadata.ArraySize; i++)
        {
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(redImage.GetPreview(true, i));
            bitmapImage.EndInit();

            Images.Add(new ImageEntry($"Index {i:D3}", bitmapImage));
        }
    }

    public override void Dispose()
    {
       // TODO MB
    }

    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

    public class ImageEntry
    {
        public ImageEntry(string name, BitmapSource source)
        {
            Name = name;
            Source = source;
        }

        public string Name { get; }
        public BitmapSource Source { get; }
    }
}