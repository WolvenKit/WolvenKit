using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public SeparateMatrix Matrix { get; set; }
        public string BindName { get; set; }
        public string SlotName { get; set; }
    }

    public interface Node
    {
        public string Name { get; set; }
        public SeparateMatrix Matrix { get; set; }
        public Node Parent { get; set; }
        public List<LoadableModel> Models { get; set; }

        public void AddModel(LoadableModel child);
    }

    public class Appearance
    {
        public string AppearanceName { get; set; }
        public string Name { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public CName Resource { get; set; }
        public List<Node> Nodes { get; set; } = new();
    }

    public class LoadableModel : IBindable, Node
    {
        public string FilePath { get; set; }
        public Model3D OriginalModel { get; set; }
        public Model3D Model { get; set; }
        public Transform3D Transform { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }
        public List<Material> Materials { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string BindName { get; set; }
        public string SlotName { get; set; }

        public UInt64 ChunkMask { get; set; } = 18446744073709551615;
        public List<bool> ChunkList { get; set; } = new(64);
        public ObservableCollection<int> AllChunks { get; set; } = new();
        public ObservableCollection<int> EnabledChunks { get; set; } = new();

        public Node Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class Rig : IBindable, Node
    {
        public string Name { get; set; }
        public List<RigBone> Bones { get; set; } = new();
        public List<Rig> Children { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string BindName { get; set; }
        public string SlotName { get; set; }

        public void AddChild(Rig child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public Node Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class RigBone : Node
    {
        public string Name { get; set; }
        public List<RigBone> Children { get; set; } = new();
        public SeparateMatrix Matrix { get; set; } = new();

        public void AddChild(RigBone child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public Node Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class SlotSet : IBindable
    {
        public string Name { get; set; }
        public Dictionary<string, string> Slots { get; set; }

        public SeparateMatrix Matrix { get; set; } = new();
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
        public string TemplateName { get; set; }
        public float Metalness { get; set; } = 0.0f;
        public float Roughness { get; set; } = 0.75f;
    }

    public class RDTMeshViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public RedDocumentViewModel File;
        private Dictionary<string, LoadableModel> _modelList = new();
        private Dictionary<string, SlotSet> _slotSets = new();

        public RDTMeshViewModel(RedDocumentViewModel file)
        {
            Header = "Mesh Preview";
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

                if (localList != null && localList.Files.Count > me.Index)
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
            //if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(file.Cr2wFile, new FileInfo(outPath)))
            if (MeshTools.ExportMesh(file.Cr2wFile, new FileInfo(outPath)))
            {
                foreach (var handle in data.Appearances)
                {
                    var app = handle.GetValue();
                    if (app is meshMeshAppearance mmapp)
                    {
                        var appMaterials = new List<Material>();

                        foreach (var materialName in mmapp.ChunkMaterials)
                        {
                            if (materials.ContainsKey(materialName))
                            {
                                appMaterials.Add(materials[materialName]);
                            }
                            else
                            {
                                appMaterials.Add(new Material()
                                {
                                    Name = materialName
                                });
                            }
                        }

                        var list = new List<LoadableModel>();

                        var m = new LoadableModel()
                        {
                            FilePath = outPath,
                            IsEnabled = true,
                            Name = Path.GetFileNameWithoutExtension(file.RelativePath),
                            Materials = appMaterials,
                            BindName = "Root"
                        };

                        for (var i = 0; i < 64; i++)
                        {
                            m.EnabledChunks.Add(i);
                        }
                        list.Add(m);

                        var a = new Appearance()
                        {
                            Name = mmapp.Name,
                            Models = list
                        };
                        Appearances.Add(a);
                    }
                }
                Rigs.Add("Root", new Rig());
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
                            Matrix = ToSeparateMatrix(slotset.LocalTransform),
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
                                    Matrix = ToSeparateMatrix(rig.BoneTransforms[i])
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

                Rigs.Add("Component", new Rig());
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
                UInt64 chunkMask = 18446744073709551615;
                var chunkList = new List<bool>(new bool[64]);

                if (component is entMeshComponent emc)
                {
                    scale = emc.VisualScale;
                    enabled = emc.IsEnabled;
                }
                if (component is IRedMeshComponent mc)
                {
                    depotPath = mc.Mesh.DepotPath;
                    meshApp = mc.MeshAppearance;
                    chunkMask = mc.ChunkMask;
                    //enabled = esmc.VisibilityAnimationParam != "invisible_in_fpp";
                    //enabled = esmc.CastShadows == false;
                }

                var enabledChunks = new ObservableCollection<int>();

                for (var i = 0; i < 64; i++)
                { 
                    chunkList[i] = (chunkMask & (1UL << i)) > 0;
                    if (chunkList[i])
                        enabledChunks.Add(i);
                }

                if (component is entIPlacedComponent epc && depotPath != null && depotPath.GetRedHash() != 0)
                {

                    var meshFile = File.GetFileFromDepotPath(depotPath);

                    if (meshFile == null || meshFile.RootChunk is not CMesh mesh)
                    {
                        Locator.Current.GetService<ILoggerService>().Warning($"Couldn't find mesh file: {depotPath} / {depotPath.GetRedHash()}");
                        continue;
                    }

                    var matrix = ToSeparateMatrix(epc.LocalTransform);

                    string bindName = null, slotName = null;
                    if ((epc.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                    {
                        bindName = ehtb.BindName;
                        slotName = ehtb.SlotName;
                    }

                    matrix.Scale(ToScaleVector3D(scale));

                    var materials = new Dictionary<string, Material>();

                    var localList = (CR2WList)mesh.LocalMaterialBuffer.RawData?.Buffer.Data ?? null;

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

                        CMaterialInstance inst = null;

                        if (localList != null && localList.Files.Count > me.Index)
                        {
                            inst = (CMaterialInstance)localList.Files[me.Index].RootChunk;
                        }
                        else
                        {
                            //foreach (var pme in data.PreloadLocalMaterialInstances)
                            //{
                            //inst = (CMaterialInstance)pme.GetValue();
                            //}
                            inst = (CMaterialInstance)mesh.PreloadLocalMaterialInstances[me.Index].GetValue();
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

                    var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileNameWithoutExtension(depotPath) + "_" + depotPath.GetRedHash().ToString() + "_full.glb");
                    //var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileName(depotPath) + "_" + depotPath.GetRedHash().ToString()) + "_full.glb";
                    //if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(meshFile, new FileInfo(outPath)))
                    if (MeshTools.ExportMesh(meshFile, new FileInfo(outPath)))
                    {
                        foreach (var handle in mesh.Appearances)
                        {
                            var app = handle.GetValue();
                            if (app is meshMeshAppearance mmapp && (mmapp.Name == meshApp || (meshApp == "default" && mesh.Appearances.IndexOf(handle) == 0)))
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
                                    ChunkMask = chunkMask,
                                    ChunkList = chunkList,
                                    EnabledChunks = enabledChunks
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
                var matrix = new SeparateMatrix();
                //GetResolvedMatrix(model, ref matrix, appModels);
                //model.Transform = new MatrixTransform3D(matrix.ToMatrix3D());
                if (model.Name.Contains("shadow") || model.Name.Contains("AppearanceProxyMesh") || model.Name.Contains("cutout") || model.Name == "")
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

        public void AddToRigs(Dictionary<string, LoadableModel> models)
        {
            SelectedAppearance.Nodes.Clear();
            foreach (var (name, rig) in Rigs)
            {
                SelectedAppearance.Nodes.Add(rig);
                rig.Models.Clear();
                foreach (var rigbone in rig.Bones)
                {
                    rigbone.Models.Clear();
                    SelectedAppearance.Nodes.Add(rigbone);
                }
            }

            foreach (var (name, model) in models)
            {
                SelectedAppearance.Nodes.Add(model);
                if (model.BindName == null)
                    continue;
                if (models.ContainsKey(model.BindName))
                {
                    models[model.BindName].AddModel(model);
                }
                else if (_slotSets.ContainsKey(model.BindName))
                {
                    if (model.SlotName != null && _slotSets[model.BindName].Slots.ContainsKey(model.SlotName))
                    {
                        var slot = _slotSets[model.BindName].Slots[model.SlotName];

                        if (Rigs.ContainsKey(_slotSets[model.BindName].BindName))
                        {
                            var rigBone = Rigs[_slotSets[model.BindName].BindName].Bones.Where(x => x.Name == slot).FirstOrDefault(defaultValue: null);

                            if (rigBone != null)
                            {
                                rigBone.AddModel(model);
                            }
                        }
                    }
                }
                else if (Rigs.ContainsKey(model.BindName))
                {
                    Rigs[model.BindName].AddModel(model);
                }
                else
                {
                    Rigs.First().Value.AddModel(model);
                }
            }

            // return root?
        }

        public void GetResolvedMatrix(IBindable bindable, ref SeparateMatrix matrix, Dictionary<string, LoadableModel> models)
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
                                    matrix.AppendPost(rigBone.Matrix);
                                    rigBone = (RigBone)rigBone.Parent;
                                }
                            }
                        }

                        // not sure this does anything anywhere
                        GetResolvedMatrix(_slotSets[bindable.BindName], ref matrix, models);
                    }
                }
                else if (Rigs.ContainsKey(bindable.BindName))
                {
                    GetResolvedMatrix(Rigs[bindable.BindName], ref matrix, models);
                }
            }
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

                var stream = new FileStream(filename_d, FileMode.Create);
                ModTools.ConvertRedClassToDdsStream(it, stream, out var format);
                stream.Dispose();
            }

            if (dictionary.ContainsKey("ParalaxTexture") && dictionary["ParalaxTexture"] is CResourceReference<ITexture> crrp)
            {
                var xbm = File.GetFileFromDepotPath(crrp.DepotPath);

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
                var xbm = File.GetFileFromDepotPath(crrbc.DepotPath);

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
                var xbm = File.GetFileFromDepotPath(crrn.DepotPath);

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
                var xbm = File.GetFileFromDepotPath(crrn2.DepotPath);

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
            ;

        }

        public byte ToBlue(byte r, byte g)
        {
            return (byte)Math.Clamp(Math.Round((Math.Sqrt(1.02 - 2 * ((r / 255F) * 2 - 1) * ((g / 255F) * 2 - 1)) + 1) / 2 * 255), 0, 255);
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

        public static SeparateMatrix ToSeparateMatrix(QsTransform qs)
        {
            var matrix = new SeparateMatrix();
            matrix.Rotate(ToQuaternion(qs.Rotation));
            matrix.Translate(ToVector3D(qs.Translation));
            matrix.Scale(ToScaleVector3D(qs.Scale));
            return matrix;
        }

        public static SeparateMatrix ToSeparateMatrix(WorldTransform wt)
        {
            var matrix = new SeparateMatrix();
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

    public class SeparateMatrix
    {
        public Matrix3D rotation = new();
        public Matrix3D translation = new();
        public Matrix3D scale = new();
        public Matrix3D post = new();

        public SeparateMatrix() {

        }

        public void Append(SeparateMatrix matrix)
        {
            if (matrix != null)
            {
                scale.Append(matrix.scale);
                rotation.Append(matrix.rotation);
                translation.Append(matrix.translation);
                //scale.Append(matrix.rotation);
                //scale.Append(matrix.translation);
            }
        }

        public void AppendPost(SeparateMatrix matrix)
        {
            post.Append(matrix.scale);
            post.Append(matrix.rotation);
            post.Append(matrix.translation);
        }

        public void Scale(Vector3D v)
        {
            scale.Scale(v);
        }

        public void Rotate(System.Windows.Media.Media3D.Quaternion q)
        {
            rotation.Rotate(q);
            //scale.Rotate(q);
        }

        public void Translate(Vector3D v)
        {
            translation.Translate(v);
            //scale.Translate(v);
        }

        public Matrix3D ToMatrix3D()
        {
            //return scale;
            var matrix = new Matrix3D();
            matrix.Append(scale);
            matrix.Append(rotation);
            matrix.Append(translation);
            matrix.Append(post);
            return matrix;
        }
    }
}
