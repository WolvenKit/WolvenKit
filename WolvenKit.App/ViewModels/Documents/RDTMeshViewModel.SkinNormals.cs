using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;
using Material = WolvenKit.App.Models.Material;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// The skin's normal as skin.mt builds it (Blender add-on material_types/skin.py), from the broadest to the
/// finest detail: Normal, then DetailNormal (DetailNormalInfluence), then MicroDetail - an atlas of two halves
/// tiled over the UVs (MicroDetailUVScale01 / 02), the half picked by the skin region in TintColorMask.g,
/// the tiling scaled by TintColorMask.b, its strength MicroDetailInfluence x Roughness.b (the detail mask).
/// Makeup with NormalAlpha 0 takes this normal too (lip folds and their fine lines).
/// The facial wrinkle maps (Detailmap_Stretch / Squash) follow animation and are left out.
/// </summary>
public partial class RDTMeshViewModel
{
    // MicroDetail is tiled finely: baked into a map twice the skin's size (at most this), so the tiles keep some detail.
    private const int SkinMicroDetailMaxSize = 4096;

    /// <summary>
    /// A texture's BGRA bytes, sampled bilinearly in image coordinates (0..1, V down). Its smaller levels
    /// (<see cref="WithMips"/>) are for textures tiled finer than the map they are baked into: sampled at
    /// full size they alias into coarse grain.
    /// </summary>
    private sealed class SkinSampler
    {
        private readonly byte[] _bgra;
        private List<SkinSampler>? _mips;
        public int Width { get; }
        public int Height { get; }

        private SkinSampler(byte[] bgra, int width, int height)
        {
            _bgra = bgra;
            Width = width;
            Height = height;
        }

        /// <summary>Builds the halved levels (2x2 box filter) down to 4 px; an atlas split at an even column keeps its halves apart.</summary>
        public SkinSampler WithMips()
        {
            _mips = [this];
            var level = this;
            while (level.Width >= 8 && level.Height >= 8)
            {
                int w = level.Width / 2, h = level.Height / 2;
                var bytes = new byte[w * h * 4];
                for (var y = 0; y < h; y++)
                {
                    for (var x = 0; x < w; x++)
                    {
                        for (var c = 0; c < 4; c++)
                        {
                            int a = ((2 * y) * level.Width + 2 * x) * 4 + c, b = a + 4;
                            int d = a + level.Width * 4, e = d + 4;
                            bytes[(y * w + x) * 4 + c] = (byte)((level._bgra[a] + level._bgra[b] + level._bgra[d] + level._bgra[e] + 2) / 4);
                        }
                    }
                }

                level = new SkinSampler(bytes, w, h);
                _mips.Add(level);
            }

            return this;
        }

        /// <summary>
        /// Like <see cref="Sample"/>, from the level whose texels are about <paramref name="texelsPerSample"/>
        /// texels of this one apart (trilinear between two levels).
        /// </summary>
        public (float R, float G, float B) SampleFiltered(float u, float v, float texelsPerSample, (float X0, float Width)? wrapColumns = null)
        {
            if (_mips is not { Count: > 1 } mips || texelsPerSample <= 1f)
            {
                return Sample(u, v, wrapColumns);
            }

            var lod = Math.Min(MathF.Log2(texelsPerSample), mips.Count - 1);
            var lower = (int)MathF.Floor(lod);
            var t = lod - lower;
            var a = mips[lower].Sample(u, v, wrapColumns);
            if (t <= 0f || lower + 1 >= mips.Count)
            {
                return a;
            }

            var b = mips[lower + 1].Sample(u, v, wrapColumns);
            return (a.R + (b.R - a.R) * t, a.G + (b.G - a.G) * t, a.B + (b.B - a.B) * t);
        }

        public static SkinSampler From(Bitmap bitmap)
        {
            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var data = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            try
            {
                var bytes = new byte[bitmap.Width * bitmap.Height * 4];
                for (var y = 0; y < bitmap.Height; y++)
                {
                    System.Runtime.InteropServices.Marshal.Copy(data.Scan0 + y * data.Stride, bytes, y * bitmap.Width * 4, bitmap.Width * 4);
                }

                return new SkinSampler(bytes, bitmap.Width, bitmap.Height);
            }
            finally
            {
                bitmap.UnlockBits(data);
            }
        }

        /// <summary>
        /// Channels 0..1 (r, g, b) at (u, v), clamped; or wrapped inside the columns [x0, x0 + width) of an
        /// atlas when <paramref name="wrapColumns"/> is given.
        /// </summary>
        public (float R, float G, float B) Sample(float u, float v, (float X0, float Width)? wrapColumns = null)
        {
            float fx, fy = v * Height - 0.5f;
            int columnStart = 0, columns = Width;
            if (wrapColumns is { } wrap)
            {
                columnStart = (int)(wrap.X0 * Width);
                columns = Math.Max(1, (int)(wrap.Width * Width));
                fx = u * Width - columnStart - 0.5f;
            }
            else
            {
                fx = u * Width - 0.5f;
            }

            var x0 = (int)MathF.Floor(fx);
            var y0 = (int)MathF.Floor(fy);
            var tx = fx - x0;
            var ty = fy - y0;

            float r = 0, g = 0, b = 0;
            for (var j = 0; j < 2; j++)
            {
                for (var i = 0; i < 2; i++)
                {
                    var w = (i == 0 ? 1 - tx : tx) * (j == 0 ? 1 - ty : ty);
                    var px = wrapColumns is null
                        ? Math.Clamp(x0 + i, 0, Width - 1)
                        : columnStart + Mod(x0 + i, columns);
                    var py = wrapColumns is null ? Math.Clamp(y0 + j, 0, Height - 1) : Mod(y0 + j, Height);
                    var o = (py * Width + px) * 4;
                    b += _bgra[o] * w;
                    g += _bgra[o + 1] * w;
                    r += _bgra[o + 2] * w;
                }
            }

            return (r / 255f, g / 255f, b / 255f);

            static int Mod(int a, int n) => ((a % n) + n) % n;
        }
    }

    /// <summary>Tangent normal from encoded R, G (DirectX, as stored), Z rebuilt.</summary>
    private static (float X, float Y, float Z) DecodeSkinNormal((float R, float G, float B) c)
    {
        var x = c.R * 2f - 1f;
        var y = c.G * 2f - 1f;
        return (x, y, MathF.Sqrt(MathF.Max(0f, 1f - x * x - y * y)));
    }

    /// <summary>
    /// The add-on's tangent normal blend: (ax bz + bx az, ay bz + by az, az bz), mixed with the base by
    /// <paramref name="factor"/> and normalized.
    /// </summary>
    private static (float X, float Y, float Z) BlendSkinNormal((float X, float Y, float Z) a, (float X, float Y, float Z) b, float factor)
    {
        var cx = a.X * b.Z + b.X * a.Z;
        var cy = a.Y * b.Z + b.Y * a.Z;
        var cz = a.Z * b.Z;

        var x = a.X + (cx - a.X) * factor;
        var y = a.Y + (cy - a.Y) * factor;
        var z = a.Z + (cz - a.Z) * factor;
        var length = MathF.Sqrt(x * x + y * y + z * z);
        return length > 1e-6f ? (x / length, y / length, z / length) : a;
    }

    private static float SmoothStep01(float x)
    {
        x = Math.Clamp(x, 0f, 1f);
        return x * x * (3f - 2f * x);
    }

    private async Task<SkinSampler?> LoadSkinSampler(Material? material, Dictionary<string, object> dictionary, string key)
    {
        var value = dictionary.TryGetValue(key, out var own) ? own : material != null ? FindMaterialValue(material, key) : null;
        if (value is not CResourceReference<ITexture> reference || reference.DepotPath == ResourcePath.Empty)
        {
            return null;
        }

        using var bitmap = await LoadTextureAsBitmap(reference.DepotPath);
        return bitmap == null ? null : SkinSampler.From(bitmap);
    }

    private float SkinFloat(Material? material, Dictionary<string, object> dictionary, string key, float fallback) =>
        dictionary.TryGetValue(key, out var own) ? ReadFloat(own) :
        material != null && FindMaterialFloat(material, key) is { } value ? value : fallback;

    /// <summary>
    /// Writes the skin's normal map (OpenGL encoding, as the preview draws it) to <paramref name="path"/>:
    /// <paramref name="baseNormal"/> with DetailNormal and MicroDetail blended in, as far as the material has them.
    /// </summary>
    private async Task BakeSkinNormal(Material? material, Dictionary<string, object> dictionary, Bitmap baseNormal, string path)
    {
        var detail = await LoadSkinSampler(material, dictionary, "DetailNormal");
        var detailInfluence = Math.Clamp(SkinFloat(material, dictionary, "DetailNormalInfluence", 1f), 0f, 1f);

        var microInfluence = Math.Clamp(SkinFloat(material, dictionary, "MicroDetailInfluence", 0f), 0f, 1f);
        var micro = microInfluence > 0f ? (await LoadSkinSampler(material, dictionary, "MicroDetail"))?.WithMips() : null;
        var microScale1 = MathF.Max(0f, SkinFloat(material, dictionary, "MicroDetailUVScale01", 1f));
        var microScale2 = MathF.Max(0f, SkinFloat(material, dictionary, "MicroDetailUVScale02", 1f));
        var regions = micro != null ? await LoadSkinSampler(material, dictionary, "TintColorMask") : null;
        var detailMask = micro != null ? await LoadSkinSampler(material, dictionary, "Roughness") : null;
        if (detailMask == null)
        {
            // the detail mask is Roughness.b: without it there is no microdetail
            micro = null;
        }

        var source = SkinSampler.From(baseNormal);
        var width = source.Width;
        var height = source.Height;
        if (micro != null)
        {
            var scale = Math.Min(2, SkinMicroDetailMaxSize / Math.Max(1, Math.Max(width, height)));
            if (scale > 1)
            {
                width *= scale;
                height *= scale;
            }
        }

        var output = new byte[width * height * 4];
        Parallel.For(0, height, y =>
        {
            var v = (y + 0.5f) / height;
            var vUp = 1f - v; // the add-on's UV (V up), for the tiling
            for (var x = 0; x < width; x++)
            {
                var u = (x + 0.5f) / width;
                var n = DecodeSkinNormal(source.Sample(u, v));

                if (detail != null && detailInfluence > 0f)
                {
                    n = BlendSkinNormal(n, DecodeSkinNormal(detail.Sample(u, v)), detailInfluence);
                }

                if (micro != null && detailMask != null)
                {
                    var influence = detailMask.Sample(u, v).B * microInfluence;
                    if (influence > 0f)
                    {
                        float region = 0f, regionScale = 0f;
                        if (regions != null)
                        {
                            var mask = regions.Sample(u, v);
                            region = SmoothStep01(MathF.Floor(mask.G * 6f) / 6f);
                            regionScale = SmoothStep01(MathF.Floor(mask.B * 5f) / 5f);
                        }

                        // atlas: MicroDetail 01 in the left half, 02 in the right one
                        var s1 = microScale1 * (regionScale + 1.4f);
                        var s2 = microScale2 * (regionScale + 1f);
                        // texels of a half the tiled detail moves per baked pixel: filtered to that, no grain
                        var step1 = MathF.Max(s1 * micro.Width * 0.5f / width, s1 * micro.Height / height);
                        var step2 = MathF.Max(s2 * micro.Width * 0.5f / width, s2 * micro.Height / height);
                        var m1 = DecodeSkinNormal(micro.SampleFiltered(Frac(u * s1) * 0.5f, 1f - Frac(vUp * s1), step1, (0f, 0.5f)));
                        var m2 = DecodeSkinNormal(micro.SampleFiltered(Frac(u * s2) * 0.5f + 0.5f, 1f - Frac(vUp * s2), step2, (0.5f, 0.5f)));
                        var mix = (m2.X + (m1.X - m2.X) * region, m2.Y + (m1.Y - m2.Y) * region, m2.Z + (m1.Z - m2.Z) * region);
                        n = BlendSkinNormal(n, mix, influence);
                    }
                }

                // as the preview draws normals: DirectX Y turned to OpenGL
                var o = (y * width + x) * 4;
                output[o] = ToByte(n.Z);
                output[o + 1] = ToByte(-n.Y);
                output[o + 2] = ToByte(n.X);
                output[o + 3] = 255;
            }
        });

        using var result = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        var data = result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
        try
        {
            for (var y = 0; y < height; y++)
            {
                System.Runtime.InteropServices.Marshal.Copy(output, y * width * 4, data.Scan0 + y * data.Stride, width * 4);
            }
        }
        finally
        {
            result.UnlockBits(data);
        }

        SavePngAtomic(result, path);

        static float Frac(float value) => value - MathF.Floor(value);
        static byte ToByte(float value) => (byte)Math.Clamp((value * 0.5f + 0.5f) * 255f, 0f, 255f);
    }
}
