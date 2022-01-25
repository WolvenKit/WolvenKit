using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using CP77.CR2W;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{

    public interface IBindable
    {
        public Matrix3D Matrix { get; set; }
        public string BindName { get; set; }
        public string SlotName { get; set; }
    }

    public class Appearance
    {
        public string AppearanceName { get; set; }
        public string Name { get; set; }
        public List<LoadableModel> Models { get; set; }
        public CName Resource { get; set; }
    }

    public class LoadableModel : IBindable
    {
        public string FilePath { get; set; }
        public Model3D Model { get; set; }
        public Transform3D Transform { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }
        public List<Material> Materials { get; set; } = new();

        public Matrix3D Matrix { get; set; }
        public string BindName { get; set; }
        public string SlotName { get; set; }

        public UInt64 ChunkMask { get; set; }
    }

    public class Rig : IBindable
    {
        public string Name { get; set; }
        public List<RigBone> Bones { get; set; }
        public Rig Parent { get; set; }
        public List<Rig> Children { get; set; } = new();

        public Matrix3D Matrix { get; set; }
        public string BindName { get; set; }
        public string SlotName { get; set; }

        public void AddChild(Rig child)
        {
            child.Parent = this;
            Children.Add(child);
        }
    }

    public class RigBone
    {
        public string Name { get; set; }
        public RigBone Parent { get; set; }
        public List<RigBone> Children { get; set; } = new();
        public Matrix3D Matrix { get; set; }

        public void AddChild(RigBone child)
        {
            child.Parent = this;
            Children.Add(child);
        }
    }

    public class SlotSet : IBindable
    {
        public string Name { get; set; }
        public Dictionary<string, string> Slots { get; set; }

        public Matrix3D Matrix { get; set; }
        public string BindName { get; set; }
        public string SlotName { get; set; }
    }

    public class Material
    {
        public string Name { get; set; }
        public CMaterialInstance Instance { get; set; }
        public Dictionary<string, object> Values { get; set; } = new();
        public Material Base { get; set; }
        public Bitmap ColorTexture { get; set; }
        public string ColorTexturePath { get; set; }
    }

    public class RDTMeshViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public RedDocumentViewModel File;
        private Dictionary<string, LoadableModel> _modelList = new();
        private Dictionary<string, SlotSet> _slotSets = new();

        public RDTMeshViewModel(RedDocumentViewModel file)
        {
            Header = "Preview";
            File = file;

            ExtractShadersCommand = new RelayCommand(ExtractShaders);
        }

        public RDTMeshViewModel(CMesh data, RedDocumentViewModel file) : this(file)
        {
            _data = data;

            var materials = new Dictionary<string, Material>();

            var localList = (CR2WList)data.LocalMaterialBuffer.RawData?.Buffer.Data ?? null;

            foreach (var me in data.MaterialEntries)
            {
                if (!me.IsLocalInstance)
                {
                    materials.Add(me.Name, new Material()
                    {
                        Name = me.Name
                    });
                    continue;
                }
                CMaterialInstance inst = null;

                if (localList != null)
                {
                    inst = (CMaterialInstance)localList.Files[me.Index].RootChunk;
                }
                else
                {
                    //foreach (var pme in data.PreloadLocalMaterialInstances)
                    //{
                        //inst = (CMaterialInstance)pme.GetValue();
                    //}
                   inst = (CMaterialInstance)data.PreloadLocalMaterialInstances[me.Index].GetValue();
                }

                //CMaterialInstance bm = null;
                //if (File.GetFileFromDepotPath(inst.BaseMaterial.DepotPath) is var file)
                //{
                //    bm = (CMaterialInstance)file.RootChunk;
                //}
                var material = new Material()
                {
                    Instance = inst,
                    Name = me.Name
                };

                foreach (var pair in inst.Values)
                {
                    material.Values.Add(pair.Key, pair.Value);
                }

                materials.Add(me.Name, material);
            }

            var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileNameWithoutExtension(file.FilePath) + "_full.glb");
            if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(file.Cr2wFile, new FileInfo(outPath)))
            {
                foreach (var handle in data.Appearances)
                {
                    var app = handle.GetValue();
                    if (app is meshMeshAppearance mmapp)
                    {
                        var appMaterials = new List<Material>();

                        foreach (var m in mmapp.ChunkMaterials)
                        {
                            if (materials.ContainsKey(m))
                            {
                                appMaterials.Add(materials[m]);
                            }
                            else
                            {
                                appMaterials.Add(new Material()
                                {
                                    Name = m
                                });
                            }
                        }

                        var list = new List<LoadableModel>();

                        list.Add(new LoadableModel()
                        {
                            FilePath = outPath,
                            IsEnabled = true,
                            Name = file.RelativePath,
                            Materials = appMaterials
                        });

                        var a = new Appearance()
                        {
                            Name = mmapp.Name,
                            Models = list
                        };
                        Appearances.Add(a);
                    }
                }
                SelectedAppearance = Appearances[0];
            }
        }

        public RDTMeshViewModel(entEntityTemplate ent, RedDocumentViewModel file) : this(file)
        {
            _data = ent;

            if (ent.CompiledData.Data is not Package04 pkg)
                return;

            if (ent.Appearances.Count > 0)
            {

                foreach (var component in pkg.Chunks)
                {
                    if (component is entSlotComponent slotset)
                    {
                        var slots = new Dictionary<string, string>();
                        foreach (var slot in slotset.Slots)
                        {
                            if (!slots.ContainsKey(slot.SlotName))
                                slots.Add(slot.SlotName, slot.BoneName);
                        }

                        string bindName = null, slotName = null;
                        if ((slotset.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                        {
                            bindName = ehtb.BindName;
                            slotName = ehtb.SlotName;
                        }

                        _slotSets.Add(slotset.Name, new SlotSet()
                        {
                            Name = slotset.Name,
                            Matrix = ToMatrix3D(slotset.LocalTransform),
                            Slots = slots,
                            BindName = bindName,
                            SlotName = slotName
                        });
                    }

                    if (component is entAnimatedComponent enc)
                    {
                        var rigFile = File.GetFileFromDepotPath(enc.Rig.DepotPath);

                        if (rigFile.RootChunk is animRig rig)
                        {
                            var rigBones = new List<RigBone>();
                            for (int i = 0; i < rig.BoneNames.Count; i++)
                            {
                                var rigBone = new RigBone()
                                {
                                    Name = rig.BoneNames[i],
                                    Matrix = ToMatrix3D(rig.BoneTransforms[i])
                                };

                                if (rig.BoneParentIndexes[i] != -1)
                                {
                                    rigBones[rig.BoneParentIndexes[i]].AddChild(rigBone);
                                }

                                rigBones.Add(rigBone);
                            }

                            string bindName = null, slotName = null;
                            if ((enc.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                            {
                                bindName = ehtb.BindName;
                                slotName = ehtb.SlotName;
                            }

                            Rigs.Add(enc.Name, new Rig()
                            {
                                Name = enc.Name,
                                Bones = rigBones,
                                BindName = bindName,
                                SlotName = slotName
                            });
                        }
                    }
                }

                foreach (var rig in Rigs.Values)
                {
                    if (rig.BindName != null && Rigs.ContainsKey(rig.BindName))
                    {
                        Rigs[rig.BindName].AddChild(rig);
                    }
                }

                foreach (var app in ent.Appearances)
                {
                    var appFile = File.GetFileFromDepotPath(app.AppearanceResource.DepotPath);

                    if (appFile == null || appFile.RootChunk is not appearanceAppearanceResource aar)
                    {
                        continue;
                    }

                    foreach (var handle in aar.Appearances)
                    {
                        var appDef = (appearanceAppearanceDefinition)handle.GetValue();

                        if (appDef.Name != app.AppearanceName || appDef.CompiledData.Data is not Package04 appPkg)
                        {
                            continue;
                        }

                        Appearances.Add(new Appearance()
                        {
                            AppearanceName = app.AppearanceName,
                            Name = app.Name,
                            Resource = app.AppearanceResource.DepotPath,
                            Models = LoadMeshs(appPkg.Chunks)
                        });

                        break;
                    }
                }
                //var j = 0;
                //foreach (var a in Appearances)
                //{
                //    var appFile = File.GetFileFromDepotPath(a.Resource);

                //    if (appFile != null && appFile.RootChunk is appearanceAppearanceResource app && app.Appearances.Count > (j + 1) && app.Appearances[j].GetValue() is appearanceAppearanceDefinition appDef && appDef.CompiledData.Data is Package04 appPkg)
                //    {
                //    }
                //    j++;
                //}

                if (Appearances.Count > 0)
                    SelectedAppearance = Appearances[0];
            }
            else
            {
                Appearances.Add(new Appearance()
                {
                    Name = "Default",
                    Models = LoadMeshs(pkg.Chunks)
                });

                SelectedAppearance = Appearances[0];
            }
        }

        public RDTMeshViewModel(appearanceAppearanceResource app, RedDocumentViewModel file) : this(file)
        {
            _data = app;
            foreach (var a in app.Appearances)
            {
                if (a.GetValue() is appearanceAppearanceDefinition appDef && appDef.CompiledData.Data is Package04 pkg)
                {
                    Appearances.Add(new Appearance()
                    {
                        Name = appDef.Name,
                        Models = LoadMeshs(pkg.Chunks)
                    });

                }
            }

            SelectedAppearance = Appearances[0];
        }

        private List<LoadableModel> LoadMeshs(IList<RedBaseClass> chunks)
        {
            if (chunks == null)
                return null;

            var appModels = new Dictionary<string, LoadableModel>();

            foreach (var component in chunks)
            {
                Vector3 scale = new Vector3() { X = 1, Y = 1, Z = 1 };
                CName depotPath = null;
                bool enabled = true;
                string meshApp = "";
                UInt64 chunkMask = 0;

                if (component is entMeshComponent emc)
                {
                    depotPath = emc.Mesh.DepotPath;
                    scale = emc.VisualScale;
                    enabled = emc.IsEnabled;
                    meshApp = emc.MeshAppearance;
                    chunkMask = emc.ChunkMask;
                }
                else if (component is entSkinnedMeshComponent esmc)
                {
                    depotPath = esmc.Mesh.DepotPath;
                    meshApp = esmc.MeshAppearance;
                    chunkMask = esmc.ChunkMask;
                }

                if (component is entIPlacedComponent epc && depotPath != null)
                {

                    var meshFile = File.GetFileFromDepotPath(depotPath);

                    if (meshFile == null || meshFile.RootChunk is not CMesh mesh)
                    {
                        Locator.Current.GetService<ILoggerService>().Warning($"Couldn't find mesh file: {depotPath} / {depotPath.GetRedHash()}");
                        continue;
                    }

                    var matrix = ToMatrix3D(epc.LocalTransform);

                    string bindName = null, slotName = null;
                    if ((epc.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                    {
                        bindName = ehtb.BindName;
                        slotName = ehtb.SlotName;
                    }

                    matrix.Scale(ToScaleVector3D(scale));

                    var materials = new Dictionary<string, Material>();

                    var localList = (CR2WList)mesh.LocalMaterialBuffer.RawData?.Buffer.Data ?? null;

                    if (localList != null)
                    {
                        foreach (var me in mesh.MaterialEntries)
                        {
                            if (!me.IsLocalInstance)
                            {
                                materials.Add(me.Name, new Material()
                                {
                                    Name = me.Name
                                });
                                continue;
                            }

                            var inst = (CMaterialInstance)localList.Files[me.Index].RootChunk;

                            //CMaterialInstance bm = null;
                            //if (File.GetFileFromDepotPath(inst.BaseMaterial.DepotPath) is var file)
                            //{
                            //    bm = (CMaterialInstance)file.RootChunk;
                            //}

                            var material = new Material()
                            {
                                Instance = inst,
                                Name = me.Name
                            };

                            foreach (var pair in inst.Values)
                            {
                                material.Values.Add(pair.Key, pair.Value);
                            }

                            materials.Add(me.Name, material);
                        }
                    }

                    var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileNameWithoutExtension(depotPath) + "_" + depotPath.GetRedHash().ToString() + "_full.glb");
                    //var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileName(depotPath) + "_" + depotPath.GetRedHash().ToString()) + "_full.glb";
                    if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(meshFile, new FileInfo(outPath)))
                    {
                        foreach (var handle in mesh.Appearances)
                        {
                            var app = handle.GetValue();
                            if (app is meshMeshAppearance mmapp && mmapp.Name == meshApp)
                            {
                                var appMaterials = new List<Material>();

                                foreach (var m in mmapp.ChunkMaterials)
                                {
                                    if (materials.ContainsKey(m))
                                    {
                                        appMaterials.Add(materials[m]);
                                    }
                                    else
                                    {
                                        appMaterials.Add(new Material()
                                        {
                                            Name = m
                                        });
                                    }
                                }

                                appModels.Add(epc.Name, new LoadableModel()
                                {
                                    FilePath = outPath,
                                    Matrix = matrix,
                                    IsEnabled = enabled,
                                    Name = epc.Name,
                                    BindName = bindName,
                                    SlotName = slotName,
                                    Materials = appMaterials,
                                    ChunkMask = chunkMask
                                });
                                break;
                            }
                        }

                        //if (!appModels.ContainsKey(epc.Name))
                        //{
                        //    appModels.Add(epc.Name, new LoadableModel()
                        //    {
                        //        FilePath = outPath,
                        //        Matrix = matrix,
                        //        IsEnabled = enabled,
                        //        Name = epc.Name,
                        //        BindName = bindName,
                        //        SlotName = slotName,
                        //        Materials = materials
                        //    });
                        //}
                    }



                }
            }

            var list = new List<LoadableModel>();

            foreach (var model in appModels.Values)
            {
                var matrix = new Matrix3D();
                GetResolvedMatrix(model, ref matrix, appModels);
                model.Transform = new MatrixTransform3D(matrix);
                if (model.Name.Contains("shadow") || model.Name.Contains("AppearanceProxyMesh") || model.Name.Contains("sticker") || model.Name.Contains("cutout"))
                {
                    model.IsEnabled = false;
                }
                list.Add(model);
            }

            if (list.Count != 0)
            {
                list.Sort((a, b) => a.Name.CompareTo(b.Name));
                return list;
            }

            return null;
        }

        public async Task LoadMaterial(Material material)
        {
            //if (material.ColorTexturePath != null)
            //    return;


            var dictionary = material.Values;

            var mat = material.Instance;
            while (mat != null && mat.BaseMaterial != null)
            {
                var baseMaterialFile = File.GetFileFromDepotPath(mat.BaseMaterial.DepotPath);
                if (baseMaterialFile != null && baseMaterialFile.RootChunk is CMaterialInstance cmi)
                {
                    foreach (var pair in cmi.Values)
                    {
                        if (!dictionary.ContainsKey(pair.Key))
                            dictionary.Add(pair.Key, pair.Value);
                    }
                    mat = cmi;
                }
                else
                {
                    mat = null;
                }
            }

            var filename_b = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + ".png");
            var filename_bn = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.png");
            var filename_d = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_d.dds");
            var filename_n = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_n.dds");

            var createMLDiffuse = !System.IO.File.Exists(filename_b);
            var createMLNormal = !System.IO.File.Exists(filename_bn);

            if (!createMLDiffuse && !createMLNormal)
                return;

            if (dictionary.ContainsKey("MultilayerSetup") && dictionary.ContainsKey("MultilayerMask"))
            {
                if (dictionary["MultilayerSetup"] is not CResourceReference<Multilayer_Setup> mlsRef)
                {
                    return;
                }

                if (dictionary["MultilayerMask"] is not CResourceReference<Multilayer_Mask> mlmRef)
                {
                    return;
                }

                var setupFile = File.GetFileFromDepotPath(mlsRef.DepotPath);

                if (setupFile == null || setupFile.RootChunk is not Multilayer_Setup mls)
                {
                    return;
                }

                var maskFile = File.GetFileFromDepotPath(mlmRef.DepotPath);

                if (maskFile == null || maskFile.RootChunk is not Multilayer_Mask mlm)
                {
                    return;
                }

                ModTools.ConvertMultilayerMaskToDdsStreams(mlm, out var streams);


                var firstStream = await ImageDecoder.RenderToBitmapSourceDds(streams[0]);

                Bitmap destBitmap = new Bitmap((int)firstStream.Width, (int)firstStream.Height);
                Bitmap normalBitmap = new Bitmap((int)firstStream.Width, (int)firstStream.Height);
                using (Graphics gfx_n = Graphics.FromImage(normalBitmap))
                using (SolidBrush brush = new SolidBrush(System.Drawing.Color.FromArgb(128, 128, 255)))
                {
                    gfx_n.FillRectangle(brush, 0, 0, (int)firstStream.Width, (int)firstStream.Height);
                }

                Graphics gfx = Graphics.FromImage(destBitmap);
                //Graphics gfx_n = Graphics.FromImage(destBitmap);

                var i = 0;
                foreach (var layer in mls.Layers)
                {
                    if (i >= streams.Count)
                        break;

                    if (layer.ColorScale == "null_null" || layer.Opacity == 0 || layer.Material == null)
                    {
                        goto SkipLayer;
                    }

                    var templateFile = File.GetFileFromDepotPath(layer.Material.DepotPath);

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

                    foreach (var color in mllt.Overrides.ColorScale)
                    {
                        if (color.N == layer.ColorScale)
                        {
                            var colorMatrix = new ColorMatrix(new float[][]
                            {
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                                new float[] { 0, 0, 0, 0, 0},
                            });
                            colorMatrix.Matrix03 = layer.Opacity;
                            colorMatrix.Matrix40 = color.V[0];
                            colorMatrix.Matrix41 = color.V[1];
                            colorMatrix.Matrix42 = color.V[2];

                            ImageAttributes attributes = new ImageAttributes();

                            attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                            gfx.DrawImage(maskBitmap, new Rectangle(0, 0, maskBitmap.Width, maskBitmap.Height), 0, 0, maskBitmap.Width, maskBitmap.Height, GraphicsUnit.Pixel, attributes);

                            break;
                        }
                    }

                    var normalFile = File.GetFileFromDepotPath(mllt.NormalTexture.DepotPath);

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

                        foreach (var strength in mllt.Overrides.NormalStrength)
                        {
                            if (strength.N == layer.NormalStrength)
                            {
                                for (int y = 0; y < maskBitmap.Height; y++)
                                {
                                    for (int x = 0; x < maskBitmap.Width; x++)
                                    {
                                        var oc = normalBitmap.GetPixel(x, y);
                                        var n = normalLayer.GetPixel(x % normalLayer.Width, y % normalLayer.Height);
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

                return;
            }

        //DiffuseMaps:
            if (System.IO.File.Exists(filename_d))
                goto NormalMaps;

            if (dictionary.ContainsKey("DiffuseTexture") && dictionary["DiffuseTexture"] is CResourceReference<ITexture> crrd)
            {
                var xbm = File.GetFileFromDepotPath(crrd.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                //var opacity = dictionary.ContainsKey("DiffuseAlpha") ? (float)(CFloat)dictionary["DiffuseAlpha"] : 1F;

                //if (opacity == 0)
                //{
                //    return;
                //}

                //var color = dictionary.ContainsKey("DiffuseColor") ? (CColor)dictionary["DiffuseColor"] : new CColor() { Red = 255, Green = 255, Blue = 255, Alpha = 255};

                //var stream = new MemoryStream();
                //var filename = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + ".dds");
                var stream = new FileStream(filename_d, FileMode.Create);
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                stream.Dispose();


                //var bitmap = await ImageDecoder.RenderToBitmapSourceDds(stream);

                //Bitmap sourceBitmap;
                //using (var outStream = new MemoryStream())
                //{
                //    BitmapEncoder enc = new PngBitmapEncoder();
                //    enc.Frames.Add(BitmapFrame.Create(bitmap));
                //    enc.Save(outStream);
                //    sourceBitmap = new Bitmap(outStream);
                //}
                ////bitmap = new TransformedBitmap(bitmap, new ScaleTransform(1, -1));

                ////Bitmap destBitmap = new Bitmap((int)sourceBitmap.Width, (int)sourceBitmap.Height);
                ////using (Graphics gfx = Graphics.FromImage(destBitmap))
                ////{
                ////    //var colorMatrix = new ColorMatrix(new float[][]
                ////    //{
                ////    //    new float[] { 0, 0, 0, 0, 0},
                ////    //    new float[] { 0, 0, 0, 0, 0},
                ////    //    new float[] { 0, 0, 0, 0, 0},
                ////    //    new float[] { 0, 0, 0, 0, 0},
                ////    //    new float[] { 0, 0, 0, 0, 0},
                ////    //});
                ////    //colorMatrix.Matrix03 = opacity;
                ////    //colorMatrix.Matrix40 = color.Red / 256F;
                ////    //colorMatrix.Matrix41 = color.Green / 256F;
                ////    //colorMatrix.Matrix42 = color.Blue / 256F;

                ////    ImageAttributes attributes = new ImageAttributes();

                ////    //attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                ////    gfx.DrawImage(sourceBitmap, new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), 0, 0, sourceBitmap.Width, sourceBitmap.Height, GraphicsUnit.Pixel, attributes);
                ////}

                //try
                //{
                //    //sourceBitmap.MakeTransparent(System.Drawing.Color.Black);
                //    sourceBitmap.Save(Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + ".png"), ImageFormat.Png);
                //    sourceBitmap.Dispose();
                //}
                //catch (Exception e)
                //{
                //    Locator.Current.GetService<ILoggerService>().Error(e.Message);
                //}
            }

        NormalMaps:

            // normals

            if (System.IO.File.Exists(filename_bn))
                return;

            if (dictionary.ContainsKey("NormalTexture") && dictionary["NormalTexture"] is CResourceReference<ITexture> crrn)
            {
                var xbm = File.GetFileFromDepotPath(crrn.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    return;
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

            if (System.IO.File.Exists(filename_bn))
                return;

            else if (dictionary.ContainsKey("Normal") && dictionary["Normal"] is CResourceReference<ITexture> crrn2)
            {
                var xbm = File.GetFileFromDepotPath(crrn2.DepotPath);

                if (xbm.RootChunk is not ITexture it)
                {
                    return;
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

        }

        public byte ToBlue(byte r, byte g)
        {
            return (byte)Math.Clamp(Math.Round((Math.Sqrt(1.02 - 2 * ((r / 255F) * 2 - 1) * ((g / 255F) * 2 - 1)) + 1) / 2 * 255), 0, 255);
        }

        public void GetResolvedMatrix(IBindable bindable, ref Matrix3D matrix, Dictionary<string, LoadableModel> models)
        {
            matrix.Append(bindable.Matrix);

            if (bindable.BindName != null)
            {
                if (bindable is LoadableModel)
                {
                    if (models.ContainsKey(bindable.BindName))
                    {
                        GetResolvedMatrix(models[bindable.BindName], ref matrix, models);
                    }
                    else if (_slotSets.ContainsKey(bindable.BindName))
                    {
                        if (bindable.SlotName != null && _slotSets[bindable.BindName].Slots.ContainsKey(bindable.SlotName))
                        {
                            var slot = _slotSets[bindable.BindName].Slots[bindable.SlotName];

                            if (Rigs.ContainsKey(_slotSets[bindable.BindName].BindName))
                            {
                                var rigBone = Rigs[_slotSets[bindable.BindName].BindName].Bones.Where(x => x.Name == slot).FirstOrDefault(defaultValue: null);

                                while (rigBone != null)
                                {
                                    matrix.Append(rigBone.Matrix);
                                    rigBone = rigBone.Parent;
                                }
                            }
                        }

                        // not sure this does anything anywhere
                        GetResolvedMatrix(_slotSets[bindable.BindName], ref matrix, models);
                    }
                }

                if (Rigs.ContainsKey(bindable.BindName))
                {
                    GetResolvedMatrix(Rigs[bindable.BindName], ref matrix, models);
                }
            }
        }

        public ICommand ExtractShadersCommand { get; set; }
        public void ExtractShaders()
        {
            var _settingsManager = Locator.Current.GetService<ISettingsManager>();
            ShaderCacheReader.ExtractShaders(new FileInfo(_settingsManager.CP77ExecutablePath), ISettingsManager.GetTemp_OBJPath());
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public string LoadedModelPath { get; set; }

        [Reactive] public List<LoadableModel> Models { get; set; } = new();

        [Reactive] public Dictionary<string, Rig> Rigs { get; set; } = new();

        [Reactive] public List<Appearance> Appearances { get; set; } = new();

        [Reactive] public Appearance SelectedAppearance { get; set; }

        public static Matrix3D ToMatrix3D(QsTransform qs)
        {
            var matrix = new Matrix3D();
            matrix.Rotate(ToQuaternion(qs.Rotation));
            matrix.Translate(ToVector3D(qs.Translation));
            matrix.Scale(ToScaleVector3D(qs.Scale));
            return matrix;
        }

        public static Matrix3D ToMatrix3D(WorldTransform wt)
        {
            var matrix = new Matrix3D();
            matrix.Rotate(ToQuaternion(wt.Orientation));
            matrix.Translate(ToVector3D(wt.Position));
            return matrix;
        }

        //public static System.Windows.Media.Media3D.Quaternion ToQuaternion(RED4.Types.Quaternion q) => new System.Windows.Media.Media3D.Quaternion(q.I, q.J, q.K, q.R);

        public static System.Windows.Media.Media3D.Quaternion ToQuaternion(RED4.Types.Quaternion q) => new System.Windows.Media.Media3D.Quaternion(q.I, q.K, -q.J, q.R);

        //public static Vector3D ToVector3D(WorldPosition v) => new Vector3D(v.X, v.Y, v.Z);

        //public static Vector3D ToVector3D(Vector4 v) => new Vector3D(v.X, v.Y, v.Z);

        //public static Vector3D ToVector3D(Vector3 v) => new Vector3D(v.X, v.Y, v.Z);

        public static Vector3D ToVector3D(WorldPosition v) => new Vector3D(v.X, v.Z, -v.Y);

        public static Vector3D ToVector3D(Vector4 v) => new Vector3D(v.X, v.Z, -v.Y);

        public static Vector3D ToVector3D(Vector3 v) => new Vector3D(v.X, v.Z, -v.Y);

        public static Vector3D ToScaleVector3D(Vector4 v) => new Vector3D(v.X, v.Z, v.Y);

        public static Vector3D ToScaleVector3D(Vector3 v) => new Vector3D(v.X, v.Z, v.Y);
    }
}
