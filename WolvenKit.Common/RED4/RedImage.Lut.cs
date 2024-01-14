using DirectXTexNet;
using System.Globalization;
using System.Text;
using System;
using System.IO;

namespace WolvenKit.RED4.CR2W;

public partial class RedImage
{
    public void SaveToCube(string szFile) => File.WriteAllText(szFile, GetLutCube());
    
    public void SaveToHald(string szFile) => File.WriteAllBytes(szFile, GetHaldPreview());

    public unsafe string GetLutCube()
    {
        if (_metadata.Dimension != TEX_DIMENSION.TEXTURE3D || 
            _metadata.Depth != _metadata.Width ||
            _metadata.Depth != _metadata.Height)
        {
            throw new Exception();
        }

        nint pixels;

        ScratchImage? tmpImage = null;
        if (_metadata.Format == DXGI_FORMAT.R32G32B32A32_FLOAT)
        {
            pixels = InternalScratchImage.GetPixels();
        }
        else
        {
            tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R32G32B32A32_FLOAT, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            pixels = tmpImage.GetPixels();
        }

        var sb = new StringBuilder();
        sb.AppendLine($"LUT_3D_SIZE {_metadata.Depth}");

        var inPtr = (float*)pixels.ToPointer();

        var totalPixel = _metadata.Depth * _metadata.Width * _metadata.Height * 4;
        for (var i = 0; i < totalPixel; i += 4)
        {
            var r = inPtr[i];
            var g = inPtr[i + 1];
            var b = inPtr[i + 2];
            //var a = inPtr[i+3];

            sb.AppendLine($"{r.ToString("F6", CultureInfo.InvariantCulture)} {g.ToString("F6", CultureInfo.InvariantCulture)} {b.ToString("F6", CultureInfo.InvariantCulture)}");
        }

        tmpImage?.Dispose();

        return sb.ToString();
    }

    public static unsafe RedImage? CreateFromLutCube(string[] lines)
    {
        ScratchImage? result = null;
        float* outPtr = null;
        var index = 0;

        var dimension = 0;
        foreach (var line in lines)
        {
            var stripedLine = line.Trim();

            if (string.IsNullOrEmpty(stripedLine) || stripedLine.StartsWith("TITLE ") || stripedLine.StartsWith("#"))
            {
                continue;
            }

            if (stripedLine.StartsWith("LUT_1D_SIZE"))
            {
                throw new NotSupportedException("1D cube files are not supported");
            }

            if (stripedLine.StartsWith("LUT_3D_SIZE"))
            {
                var buf = stripedLine.Split(' ');
                dimension = int.Parse(buf[1]);

                result = TexHelper.Instance.Initialize3D(DXGI_FORMAT.R32G32B32A32_FLOAT, dimension, dimension, dimension, 1, CP_FLAGS.NONE);
                outPtr = (float*)result.GetPixels().ToPointer();

                continue;
            }

            if (result == null || outPtr == null)
            {
                throw new Exception("Invalid file format");
            }

            var buf2 = stripedLine.Split(' ');

            outPtr[index++] = float.Parse(buf2[0], CultureInfo.InvariantCulture);
            outPtr[index++] = float.Parse(buf2[1], CultureInfo.InvariantCulture);
            outPtr[index++] = float.Parse(buf2[2], CultureInfo.InvariantCulture);
            outPtr[index++] = 1F;
        }

        var tmp = new RedImage(result!);
        tmp.FlipV();

        return tmp;
    }

    // https://legacy.imagemagick.org/discourse-server/viewtopic.php?p=162163#p162163
    private unsafe byte[] CreateHaldImage(uint haldSize = 8)
    {
        if (_metadata.Dimension != TEX_DIMENSION.TEXTURE3D ||
            _metadata.Depth != _metadata.Width ||
            _metadata.Depth != _metadata.Height)
        {
            throw new Exception();
        }

        nint pixels;

        ScratchImage? tmpImage = null;
        if (_metadata.Format == DXGI_FORMAT.R32G32B32A32_FLOAT)
        {
            pixels = InternalScratchImage.GetPixels();
        }
        else
        {
            tmpImage = InternalScratchImage.Convert(DXGI_FORMAT.R32G32B32A32_FLOAT, TEX_FILTER_FLAGS.DEFAULT, 0.5F);
            pixels = tmpImage.GetPixels();
        }

        var dimension = _metadata.Depth;

        var data = new float[dimension, dimension, dimension, 3];

        var inPtr = (float*)pixels.ToPointer();

        var r = 0;
        var g = 0;
        var b = 0;

        var totalPixel = dimension * dimension * dimension * 4;
        for (var i = 0; i < totalPixel; i += 4)
        {
            data[b, g, r, 0] = inPtr[i];
            data[b, g, r, 1] = inPtr[i + 1];
            data[b, g, r, 2] = inPtr[i + 2];

            r++;
            if (r >= dimension)
            {
                r = 0;
                g++;
                if (g >= dimension)
                {
                    g = 0;
                    b++;
                }
            }
        }

        var range = haldSize * haldSize;

        var outData = new float[range, range, range, 3];

        var length = _metadata.Depth - 1;
        var factor = 1.0 / (range - 1);

        for (b = 0; b < range; b++)
        {
            for (g = 0; g < range; g++)
            {
                for (r = 0; r < range; r++)
                {
                    var rPosition = (r * factor) * length;
                    var rIndex = (int)rPosition;
                    var rFactor = rPosition % 1D;

                    var rNext = rIndex;
                    if (rNext != length)
                    {
                        rNext++;
                    }

                    var gPosition = (g * factor) * length;
                    var gIndex = (int)gPosition;
                    var gFactor = gPosition % 1D;

                    var gNext = gIndex;
                    if (gNext != length)
                    {
                        gNext++;
                    }

                    var bPosition = (b * factor) * length;
                    var bIndex = (int)bPosition;
                    var bFactor = bPosition % 1D;

                    var bNext = bIndex;
                    if (bNext != length)
                    {
                        bNext++;
                    }

                    outData[b, g, r, 0] = (float)(data[bIndex, gIndex, rIndex, 0] + (data[bIndex, gIndex, rNext, 0] - data[bIndex, gIndex, rIndex, 0]) * rFactor);
                    outData[b, g, r, 1] = (float)(data[bIndex, gIndex, rIndex, 1] + (data[bIndex, gNext, rIndex, 1] - data[bIndex, gIndex, rIndex, 1]) * gFactor);
                    outData[b, g, r, 2] = (float)(data[bIndex, gIndex, rIndex, 2] + (data[bNext, gIndex, rIndex, 2] - data[bIndex, gIndex, rIndex, 2]) * bFactor);
                }
            }
        }

        var haldDimension = (int)(haldSize * haldSize * haldSize);
        var result = TexHelper.Instance.Initialize2D(DXGI_FORMAT.R32G32B32A32_FLOAT, haldDimension, haldDimension, 1, 1, CP_FLAGS.NONE);

        var outPixels = result.GetPixels();
        var outPtr = (float*)outPixels.ToPointer();

        var index = 0;

        for (b = 0; b < range; b++)
        {
            for (g = 0; g < range; g++)
            {
                for (r = 0; r < range; r++)
                {
                    outPtr[index++] = outData[b, g, r, 0];
                    outPtr[index++] = outData[b, g, r, 1];
                    outPtr[index++] = outData[b, g, r, 2];
                    outPtr[index++] = 1F;
                }
            }
        }

        result = result.Convert(DXGI_FORMAT.B8G8R8A8_UNORM, TEX_FILTER_FLAGS.DEFAULT, 0.5F);

        tmpImage?.Dispose();

        return SaveToMemory(result.SaveToWICMemory(0, WIC_FLAGS.NONE, TexHelper.Instance.GetWICCodec(WICCodecs.PNG)));
    }

    public byte[] GetHaldPreview(uint haldSize = 8)
    {
        if (TexHelper.Instance.IsCompressed(_metadata.Format))
        {
            InternalScratchImage = InternalScratchImage.Decompress(DXGI_FORMAT.UNKNOWN);
            _metadata = InternalScratchImage.GetMetadata();
        }

        return CreateHaldImage();
    }
}