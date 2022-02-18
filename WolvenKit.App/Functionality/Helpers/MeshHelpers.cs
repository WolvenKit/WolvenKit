using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CP77.CR2W;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using SharpDX.Direct3D9;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.Commands;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.Functionality.Helpers;

namespace WolvenKit.ViewModels.Documents
{
    public partial class RDTMeshViewModel
    {
        public Dictionary<string, PBRMaterial> Materials { get; set; } = new();
        public Dictionary<string, Material> RawMaterials { get; set; } = new();
        public Dictionary<string, CR2WFile> Files { get; set; } = new();

        public List<MeshGeometryModel3D> MakeMesh(CR2WFile cr2w, ulong chunkMask = ulong.MaxValue, int appearanceIndex = 0)
        {
            if (cr2w == null || cr2w.RootChunk is not CMesh cMesh || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return null;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, true, ulong.MaxValue);

            var list = new List<MeshGeometryModel3D>();

            var index = 0;
            foreach (var mesh in expMeshes)
            {

                var positions = new Vector3Collection(mesh.positions.Length);
                for (var i = 0; i < mesh.positions.Length; i++)
                {
                    positions.Add(ToVector3(mesh.positions[i]));
                }

                var indices = new IntCollection(mesh.indices.Length);
                for (var i = 0; i < mesh.indices.Length; i++)
                {
                    indices.Add((int)mesh.indices[i]);
                }

                var normals = new Vector3Collection(mesh.normals.Length);
                for (var i = 0; i < mesh.normals.Length; i++)
                {
                    normals.Add(ToVector3(mesh.normals[i]));
                }

                var textureCoordinates = new Vector2Collection(mesh.texCoords0.Length);
                for (var i = 0; i < mesh.texCoords0.Length; i++)
                {
                    textureCoordinates.Add(ToVector2(mesh.texCoords0[i]));
                }

                var tangents = new Vector3Collection(mesh.tangents.Length);
                for (var i = 0; i < mesh.tangents.Length; i++)
                {
                    tangents.Add(ToVector3(mesh.tangents[i]));
                }

                var material = SetupPBRMaterial(mesh.materialNames[appearanceIndex]);
                
                list.Add(new MeshGeometryModel3D()
                {
                    Name = $"submesh_{index:D2}_{mesh.materialNames[appearanceIndex]}",
                    IsRendering = (chunkMask & 1UL << index) > 0,
                    //CullMode = SharpDX.Direct3D11.CullMode.Front,
                    Geometry = new MeshGeometry3D()
                    {
                        Positions = positions,
                        Indices = indices,
                        Normals = normals,
                        TextureCoordinates = textureCoordinates,
                        Tangents = tangents
                    },
                    Material = material
                });
                index++;
            }

            return list;

        }

        public PBRMaterial SetupPBRMaterial(string name, bool force = false)
        {
            if (!Materials.ContainsKey(name) || force)
            {
                PBRMaterial material;
                if (Materials.ContainsKey(name))
                {
                    material = Materials[name];
                }
                else
                {
                    material = new PBRMaterial()
                    {
                        EnableAutoTangent = true,
                        RenderShadowMap = true
                    };
                    Materials[name] = material;
                }
                var filename_b = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + ".png");
                var filename_bn = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_n.png");
                var filename_rm = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_rm.png");
                var filename_d = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_d.dds");
                var filename_n = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_n.dds");


                if (System.IO.File.Exists(filename_d))
                {
                    material.AlbedoMap = TextureModel.Create(filename_d);
                }
                else if (System.IO.File.Exists(filename_b))
                {
                    material.AlbedoMap = TextureModel.Create(filename_b);
                }
                else
                {
                    material.AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
                }

                if (System.IO.File.Exists(filename_n))
                {
                    material.NormalMap = TextureModel.Create(filename_n);
                }
                else if (System.IO.File.Exists(filename_bn))
                {
                    material.NormalMap = TextureModel.Create(filename_bn);
                }

                if (System.IO.File.Exists(filename_rm))
                {
                    material.RoughnessMetallicMap = TextureModel.Create(filename_rm);
                    //material.RenderRoughnessMetallicMap = true;
                }

                if (name == "decals")
                {
                    //material.AlbedoColor = new SharpDX.Color4(0, 0, 0, 0.1f);
                    material.DisplacementMap = material.AlbedoMap;
                }
            }
            return Materials[name];
        }

        public bool IsLoadingMaterials { get; set; }

        public ICommand LoadMaterialsCommand { get; set; }
        public void LoadMaterials()
        {
            IsLoadingMaterials = true;
            Parallel.ForEachAsync(from entry in RawMaterials orderby entry.Key ascending select entry, (material, cancellationToken) => LoadMaterial(material.Value)).ContinueWith((result) =>
            {
                Locator.Current.GetService<ILoggerService>().Info($"All materials loaded!");
                IsLoadingMaterials = false;
            });


            //IsLoadingMaterials = true;
            //var tasks = new List<Task>();

            //foreach (var (name, material) in RawMaterials)
            //{
            //    tasks.Add(LoadMaterial(material));
            //}

            //Task.WhenAll(tasks).ContinueWith((result) =>
            //{
            //    IsLoadingMaterials = false;
            //});
        }

        public async ValueTask LoadMaterial(Material material)
        {
            if (material == null)
            {
                return;
            }

            var dictionary = material.Values;

            var mat = material.Instance;
            while (mat != null && mat.BaseMaterial != null)
            {
                var baseMaterialFile = File.GetFileFromDepotPathOrCache(mat.BaseMaterial.DepotPath);

                if (baseMaterialFile != null && baseMaterialFile.RootChunk is CMaterialInstance cmi)
                {
                    foreach (var pair in cmi.Values)
                    {
                        if (!dictionary.ContainsKey(pair.Key))
                            dictionary.Add(pair.Key, pair.Value);
                    }
                    mat = cmi;
                }
                else if (baseMaterialFile != null && baseMaterialFile.RootChunk is CMaterialTemplate cmt)
                {
                    material.TemplateName = cmt.Name;
                    mat = null;
                }
                else
                {
                    mat = null;
                }
            }
            material.Values = dictionary;

            if (dictionary.ContainsKey("Metalness") && dictionary["Metalness"] is CResourceReference<ITexture> metalTexture)
            {
                if (metalTexture.DepotPath == "base\\materials\\placeholder\\black.xbm")
                    material.Metalness = 0;
                else if (metalTexture.DepotPath == "base\\materials\\placeholder\\white.xbm")
                    material.Metalness = 1;
            }

            if (dictionary.ContainsKey("MetalnessScale"))
                material.Metalness = (CFloat)dictionary["MetalnessScale"];

            if (dictionary.ContainsKey("Roughness") && dictionary["Roughness"] is CResourceReference<ITexture> roughTexture)
            {
                if (roughTexture.DepotPath == "base\\materials\\placeholder\\black.xbm")
                    material.Roughness = 0;
                else if (roughTexture.DepotPath == "base\\materials\\placeholder\\white.xbm")
                    material.Roughness = 1;
            }

            if (dictionary.ContainsKey("RoughnessScale"))
                material.Roughness = (CFloat)dictionary["RoughnessScale"];

            var filename_b = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + ".png");
            var filename_bn = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.png");
            var filename_rm = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_rm.png");
            var filename_d = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_d.dds");
            var filename_n = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.dds");

            if (dictionary.ContainsKey("MultilayerSetup") && dictionary.ContainsKey("MultilayerMask"))
            {
                var createMLDiffuse = !System.IO.File.Exists(filename_b);
                var createMLRoughnessMetallic = !System.IO.File.Exists(filename_rm);
                var createMLNormal = !System.IO.File.Exists(filename_bn);

                if (!createMLDiffuse && !createMLNormal && !createMLRoughnessMetallic)
                    goto SkipNormals;

                if (dictionary["MultilayerSetup"] is not CResourceReference<Multilayer_Setup> mlsRef)
                {
                    goto SkipNormals;
                }

                if (dictionary["MultilayerMask"] is not CResourceReference<Multilayer_Mask> mlmRef)
                {
                    goto SkipNormals;
                }

                var setupFile = File.GetFileFromDepotPathOrCache(mlsRef.DepotPath);

                if (setupFile == null || setupFile.RootChunk is not Multilayer_Setup mls)
                {
                    goto SkipNormals;
                }

                var maskFile = File.GetFileFromDepotPathOrCache(mlmRef.DepotPath);

                if (maskFile == null || maskFile.RootChunk is not Multilayer_Mask mlm)
                {
                    goto SkipNormals;
                }

                ModTools.ConvertMultilayerMaskToDdsStreams(mlm, out var streams);


                var firstStream = await ImageDecoder.RenderToBitmapSourceDds(streams[0]);

                Bitmap destBitmap = new Bitmap((int)firstStream.Width, (int)firstStream.Height);
                Bitmap rmBitmap = new Bitmap((int)firstStream.Width, (int)firstStream.Height);
                Bitmap normalBitmap = new Bitmap((int)firstStream.Width, (int)firstStream.Height);
                using (Graphics gfx_n = Graphics.FromImage(normalBitmap))
                using (SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(128, 128, 255)))
                {
                    gfx_n.FillRectangle(brush, 0, 0, (int)firstStream.Width, (int)firstStream.Height);
                }

                Graphics gfx = Graphics.FromImage(destBitmap);
                Graphics gfx_rm = Graphics.FromImage(rmBitmap);
                //Graphics gfx_n = Graphics.FromImage(destBitmap);

                var i = 0;
                foreach (var layer in mls.Layers)
                {
                    if (i >= streams.Count)
                        break;

                    if (layer.Material == null)
                    {
                        goto SkipLayer;
                    }

                    var templateFile = File.GetFileFromDepotPathOrCache(layer.Material.DepotPath);

                    if (templateFile.RootChunk is not Multilayer_LayerTemplate mllt)
                    {
                        goto SkipLayer;
                    }

                    BitmapSource mask;
                    if (i == 0)
                    {
                        mask = firstStream;
                    }
                    else
                    {
                        mask = await ImageDecoder.RenderToBitmapSourceDds(streams[i]);
                    }
                    mask = new TransformedBitmap(mask, new ScaleTransform(1, -1));

                    Bitmap maskBitmap;
                    using (var outStream = new MemoryStream())
                    {
                        BitmapEncoder enc = new PngBitmapEncoder();
                        enc.Frames.Add(BitmapFrame.Create(mask));
                        enc.Save(outStream);
                        maskBitmap = new Bitmap(outStream);
                    }

                    if (layer.ColorScale == "null_null" || layer.Opacity == 0 || layer.Material == null)
                    {
                        goto SkipColor;
                    }

                    {
                        var color = mllt.Overrides.ColorScale.Where(x => x.N == layer.ColorScale).First()?.V ?? null;

                        if (color == null)
                        {
                            goto SkipColor;
                        }

                        var colorMatrix = new ColorMatrix(new float[][]
                        {
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                        });
                        colorMatrix.Matrix03 = layer.Opacity;
                        colorMatrix.Matrix40 = color[0];
                        colorMatrix.Matrix41 = color[1];
                        colorMatrix.Matrix42 = color[2];

                        ImageAttributes attributes = new ImageAttributes();

                        attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        gfx.DrawImage(maskBitmap, new Rectangle(0, 0, maskBitmap.Width, maskBitmap.Height), 0, 0, maskBitmap.Width, maskBitmap.Height, GraphicsUnit.Pixel, attributes);
                    }

                SkipColor:

                    {
                        var roughOut = mllt.Overrides.RoughLevelsOut.Where(x => x.N == layer.RoughLevelsOut).First()?.V ?? null;

                        if (roughOut == null)
                        {
                            goto SkipRoughMetal;
                        }

                        var metalOut = mllt.Overrides.MetalLevelsOut.Where(x => x.N == layer.MetalLevelsOut).First()?.V ?? null;

                        if (metalOut == null)
                        {
                            goto SkipRoughMetal;
                        }

                        var colorMatrix = new ColorMatrix(new float[][]
                        {
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                            new float[] { 0, 0, 0, 0, 0},
                        });
                        colorMatrix.Matrix03 = 1f;
                        colorMatrix.Matrix40 = 0;
                        colorMatrix.Matrix41 = (roughOut[0] + roughOut[1]) / 2f;
                        colorMatrix.Matrix42 = (metalOut[0] + metalOut[1]) / 2f;

                        ImageAttributes attributes = new ImageAttributes();

                        attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                        gfx_rm.DrawImage(maskBitmap, new Rectangle(0, 0, maskBitmap.Width, maskBitmap.Height), 0, 0, maskBitmap.Width, maskBitmap.Height, GraphicsUnit.Pixel, attributes);
                    }

                SkipRoughMetal:

                    var normalFile = File.GetFileFromDepotPathOrCache(mllt.NormalTexture.DepotPath);

                    if (normalFile != null && normalFile.RootChunk is ITexture it)
                    {
                        var stream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(it, stream, out var format);

                        var normal = await ImageDecoder.RenderToBitmapSourceDds(stream);

                        Bitmap normalLayer;
                        using (var outStream = new MemoryStream())
                        {
                            BitmapEncoder enc = new PngBitmapEncoder();
                            enc.Frames.Add(BitmapFrame.Create(normal));
                            enc.Save(outStream);
                            normalLayer = new Bitmap(outStream);
                        }

                        var layerWidth = (int)(normalLayer.Width * layer.MatTile);
                        var layerHeight = (int)(normalLayer.Height * layer.MatTile);

                        Bitmap tempNormalBitmap = new Bitmap(maskBitmap.Width, maskBitmap.Height);

                        try
                        {
                            tempNormalBitmap = new Bitmap((layerWidth < maskBitmap.Width) ? layerWidth : maskBitmap.Width, (layerHeight < maskBitmap.Height) ? layerHeight : maskBitmap.Height);
                        }
                        catch (Exception)
                        {
                            ;
                        }

                        Graphics gfx_n = Graphics.FromImage(tempNormalBitmap);
                        gfx_n.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                        gfx_n.DrawImage(normalLayer, new Rectangle(0, 0, layerWidth, layerHeight), 0, 0, normalLayer.Width, normalLayer.Height, GraphicsUnit.Pixel, null);
                        gfx_n.Dispose();

                        foreach (var strength in mllt.Overrides.NormalStrength)
                        {
                            if (strength.N == layer.NormalStrength)
                            {
                                for (int y = 0; y < maskBitmap.Height; y++)
                                {
                                    for (int x = 0; x < maskBitmap.Width; x++)
                                    {
                                        var oc = normalBitmap.GetPixel(x, y);
                                        var n = tempNormalBitmap.GetPixel(x % tempNormalBitmap.Width, y % tempNormalBitmap.Height);
                                        var alpha = maskBitmap.GetPixel(x, y).R / 255F * (float)strength.V;
                                        var r = (int)((oc.R - 127) * (1F - alpha) + (n.R - 127) * alpha) + 127;
                                        //var g = 255 - ((int)((oc.G - 127) * (1F - alpha) + (n.G - 127) * alpha) + 127);
                                        var g = (int)((oc.G - 127) * (1F - alpha) + (n.G - 127) * alpha) + 127;
                                        var b = (int)((oc.B - 127) * (1F - alpha)) + 127;
                                        if (n.B == 0)
                                        {
                                            b += (int)((ToBlue((byte)r, (byte)g) - 127) * alpha);
                                        }
                                        else
                                        {
                                            b += (int)((n.B - 127) * alpha);
                                        }
                                        var color = System.Drawing.Color.FromArgb(Math.Clamp(r, 0, 255), Math.Clamp(g, 0, 255), Math.Clamp(b, 0, 255));
                                        normalBitmap.SetPixel(x, y, color);
                                    }
                                }
                                break;
                            }
                        }
                        stream.Dispose();
                    }

                SkipLayer:
                    i++;
                }

                gfx.Dispose();
                //gfx_n.Dispose();

                try
                {
                    destBitmap.Save(filename_b, ImageFormat.Png);
                }
                catch (Exception e)
                {
                    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                }
                finally
                {
                    destBitmap.Dispose();
                }

                try
                {
                    rmBitmap.Save(filename_rm, ImageFormat.Png);
                }
                catch (Exception e)
                {
                    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                }
                finally
                {
                    rmBitmap.Dispose();
                }

                try
                {
                    normalBitmap.Save(filename_bn, ImageFormat.Png);
                }
                catch (Exception e)
                {
                    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                }
                finally
                {
                    normalBitmap.Dispose();
                }

                goto SkipNormals;
            }

            //DiffuseMaps:
            if (System.IO.File.Exists(filename_d))
                goto NormalMaps;

            if (dictionary.ContainsKey("DiffuseTexture") && dictionary["DiffuseTexture"] is CResourceReference<ITexture> crrd)
            {
                var xbm = File.GetFileFromDepotPathOrCache(crrd.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                var stream = new FileStream(filename_d, FileMode.Create);
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                stream.Dispose();
            }

            if (dictionary.ContainsKey("ParalaxTexture") && dictionary["ParalaxTexture"] is CResourceReference<ITexture> crrp)
            {
                var xbm = File.GetFileFromDepotPathOrCache(crrp.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                var stream = new FileStream(filename_d, FileMode.Create);
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                stream.Dispose();
            }

            if (dictionary.ContainsKey("BaseColor") && dictionary["BaseColor"] is CResourceReference<ITexture> crrbc)
            {
                var xbm = File.GetFileFromDepotPathOrCache(crrbc.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                var stream = new FileStream(filename_d, FileMode.Create);
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                stream.Dispose();
            }

        NormalMaps:

            // normals

            if (System.IO.File.Exists(filename_bn))
                goto SkipNormals;

            if (dictionary.ContainsKey("NormalTexture") && dictionary["NormalTexture"] is CResourceReference<ITexture> crrn)
            {
                var xbm = File.GetFileFromDepotPathOrCache(crrn.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto SkipNormals;
                }

                //var stream = new FileStream(filename_n, FileMode.Create);
                //ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                //stream.Dispose();

                var stream = new MemoryStream();
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);

                var normal = await ImageDecoder.RenderToBitmapSourceDds(stream);

                stream.Dispose();

                Bitmap normalLayer;
                using (var outStream = new MemoryStream())
                {
                    BitmapEncoder enc = new PngBitmapEncoder();
                    enc.Frames.Add(BitmapFrame.Create(normal));
                    enc.Save(outStream);
                    normalLayer = new Bitmap(outStream);
                }

                for (int y = 0; y < normalLayer.Height; y++)
                {
                    for (int x = 0; x < normalLayer.Width; x++)
                    {
                        var oc = normalLayer.GetPixel(x, y);
                        var r = oc.R;
                        //var g = (byte)(255 - oc.G);
                        var g = oc.G;
                        var b = ToBlue(r, g);
                        normalLayer.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                    }
                }

                try
                {
                    normalLayer.Save(filename_bn, ImageFormat.Png);
                }
                catch (Exception e)
                {
                    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                }
                finally
                {
                    normalLayer.Dispose();
                }

            }
            else if (dictionary.ContainsKey("Normal") && dictionary["Normal"] is CResourceReference<ITexture> crrn2)
            {
                var xbm = File.GetFileFromDepotPathOrCache(crrn2.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto SkipNormals;
                }

                //var stream = new FileStream(filename_n, FileMode.Create);
                //ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                //stream.Dispose();

                var stream = new MemoryStream();
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);

                var normal = await ImageDecoder.RenderToBitmapSourceDds(stream);

                stream.Dispose();

                Bitmap normalLayer;
                using (var outStream = new MemoryStream())
                {
                    BitmapEncoder enc = new PngBitmapEncoder();
                    enc.Frames.Add(BitmapFrame.Create(normal));
                    enc.Save(outStream);
                    normalLayer = new Bitmap(outStream);
                }

                for (int y = 0; y < normalLayer.Height; y++)
                {
                    for (int x = 0; x < normalLayer.Width; x++)
                    {
                        var oc = normalLayer.GetPixel(x, y);
                        var r = oc.R;
                        //var g = (byte)(255 - oc.G);
                        var g = oc.G;
                        var b = ToBlue(r, g);
                        normalLayer.SetPixel(x, y, System.Drawing.Color.FromArgb(r, g, b));
                    }
                }

                try
                {
                    normalLayer.Save(filename_bn, ImageFormat.Png);
                }
                catch (Exception e)
                {
                    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                }
                finally
                {
                    normalLayer.Dispose();
                }
            }

        SkipNormals:
            Locator.Current.GetService<ILoggerService>().Info($"Loaded material: {material.Name}");
            DispatcherHelper.RunOnMainThread(() =>
            {
                SetupPBRMaterial(material.Name, true);
            });

            return;
        }

        public byte ToBlue(byte r, byte g)
        {
            return (byte)Math.Clamp(Math.Round((Math.Sqrt(1.02 - 2 * ((r / 255F) * 2 - 1) * ((g / 255F) * 2 - 1)) + 1) / 2 * 255), 0, 255);
        }

        public static SharpDX.Vector2 ToVector2(System.Numerics.Vector2 v)
        {
            return new SharpDX.Vector2(v.X, v.Y);
        }

        public static SharpDX.Vector3 ToVector3(System.Numerics.Vector3 v)
        {
            return new SharpDX.Vector3(v.X, v.Y, v.Z);
        }

        public static SharpDX.Vector3 ToVector3(System.Numerics.Vector4 v)
        {
            return new SharpDX.Vector3(v.X / v.W, v.Y / v.W, v.Z / v.W);
        }
    }
}
