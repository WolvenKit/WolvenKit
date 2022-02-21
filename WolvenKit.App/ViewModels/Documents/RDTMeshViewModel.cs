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
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
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
        public Dictionary<uint, List<SubmeshComponent>> LODLUT { get; set; } = new();

        private uint _selectedLOD = 1;
        public uint SelectedLOD {
            get => _selectedLOD;
            set
            {
                _selectedLOD = value;
                foreach (var lod in LODLUT.Keys)
                {
                    foreach (var submesh in LODLUT[lod])
                    {
                        if (lod == _selectedLOD)
                        {
                            submesh.IsRendering = submesh.EnabledWithMask;
                        }
                        else
                        {
                            submesh.IsRendering = false;
                        }
                    }
                }
            }
        }
        public string AppearanceName { get; set; }
        public string Name { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public CName Resource { get; set; }
        public List<Node> Nodes { get; set; } = new();
        public List<Element3D> ModelGroup { get; set; } = new();
        public List<LoadableModel> BindableModels { get; set; } = new();
        public Dictionary<string, Material> RawMaterials { get; set; } = new();
    }

    public class LoadableModel : IBindable, Node
    {
        public int AppearanceIndex { get; set; }
        public string AppearanceName { get; set; }
        public CR2WFile MeshFile { get; set; }
        public List<SubmeshComponent> Meshes { get; set; } = new();
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

    public partial class RDTMeshViewModel : RedDocumentTabViewModel
    {
        protected readonly RedBaseClass _data;
        public RedDocumentViewModel File;
        private Dictionary<string, LoadableModel> _modelList = new();
        private Dictionary<string, SlotSet> _slotSets = new();

        public EffectsManager EffectsManager { get; }

        public HelixToolkit.Wpf.SharpDX.Camera Camera { get; }

        public SceneNodeGroupModel3D GroupModel { get; set; } = new SceneNodeGroupModel3D();

        public List<Element3D> ModelGroup { get; set; } = new();

        public TextureModel EnvironmentMap { get; set; }

        public RDTMeshViewModel(RedDocumentViewModel file)
        {
            if (Header == null)
            {
                Header = "Mesh Preview";
            }
            File = file;

            EffectsManager = new DefaultEffectsManager();
            EnvironmentMap = TextureModel.Create(Path.Combine(ISettingsManager.GetTemp_OBJPath(), "Cubemap_Grandcanyon.dds"));
            Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera();

            ExtractShadersCommand = new RelayCommand(ExtractShaders);
            LoadMaterialsCommand = new RelayCommand(LoadMaterials);
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
                //if (File.GetFileFromDepotPathOrCache(inst.BaseMaterial.DepotPath) is var file)
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

            var appIndex = 0;
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

                    var a = new Appearance()
                    {
                        Name = mmapp.Name
                    };

                    var model = new LoadableModel()
                    {
                        MeshFile = File.Cr2wFile,
                        AppearanceIndex = appIndex,
                        AppearanceName = mmapp.Name,
                        Materials = appMaterials,
                        Name = Path.GetFileNameWithoutExtension(File.ContentId).Replace("-", "_"),
                        IsEnabled = true
                    };
                    a.Models.Add(model);
                    a.BindableModels.Add(model);
                    foreach (var material in model.Materials)
                    {
                        a.RawMaterials[material.Name] = material;
                    }

                    model.Meshes = MakeMesh(data, ulong.MaxValue, model.AppearanceIndex);

                    foreach (var m in model.Meshes)
                    {
                        if (!a.LODLUT.ContainsKey(m.LOD))
                        {
                            a.LODLUT[m.LOD] = new List<SubmeshComponent>();
                        }
                        a.LODLUT[m.LOD].Add(m);
                    }
                    AddMeshesToRiggedGroups(a);

                    Appearances.Add(a);
                }
                appIndex++;
            }
            SelectedAppearance = Appearances[0];
        }

        public RDTMeshViewModel(entEntityTemplate ent, RedDocumentViewModel file) : this(file)
        {
            Header = "Entity Preview";
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
                        var rigFile = File.GetFileFromDepotPathOrCache(enc.Rig.DepotPath);

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
                    var appFile = File.GetFileFromDepotPathOrCache(app.AppearanceResource.DepotPath);

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

                        var a = new Appearance()
                        {
                            AppearanceName = app.AppearanceName,
                            Name = app.Name,
                            Resource = app.AppearanceResource.DepotPath,
                            Models = LoadMeshs(appPkg.Chunks),
                        };

                        foreach (var model in a.Models)
                        {
                            if (a.Models.FirstOrDefault(x => x.Name == model.BindName) is var parentModel && parentModel != null)
                            {
                                parentModel.AddModel(model);
                            }
                            else
                            {
                                a.BindableModels.Add(model);
                            }
                            foreach (var material in model.Materials)
                            {
                                a.RawMaterials[material.Name] = material;
                            }
                            model.Meshes = MakeMesh((CMesh)model.MeshFile.RootChunk, model.ChunkMask, model.AppearanceIndex);

                            foreach (var m in model.Meshes)
                            {
                                if (!a.LODLUT.ContainsKey(m.LOD))
                                {
                                    a.LODLUT[m.LOD] = new List<SubmeshComponent>();
                                }
                                a.LODLUT[m.LOD].Add(m);
                            }
                        }
                        AddMeshesToRiggedGroups(a);

                        Appearances.Add(a);

                        if (Appearances.Count > 0)
                            SelectedAppearance = Appearances[0];

                        break;
                    }
                }
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

        public GroupModel3D GroupFromRigBone(Rig rig, RigBone bone, Dictionary<string, GroupModel3D> groups)
        {
            var group = new GroupModel3D()
            {
                Name = bone.Name,
                Transform = new MatrixTransform3D(bone.Matrix.ToMatrix3D())
            };
            foreach (var child in bone.Children)
            {
                group.Children.Add(GroupFromRigBone(rig, child, groups));
            }
            groups.Add(rig.Name + ":" + bone.Name, group);
            return group;
        }

        public class MeshComponent : GroupModel3D
        {
            public string AppearanceName { get; set; }
        }

        public GroupModel3D GroupFromModel(LoadableModel model)
        {
            var group = new MeshComponent()
            {
                Name = $"{model.Name}",
                AppearanceName = model.AppearanceName,
                Transform = model.Transform,
                IsRendering = model.IsEnabled
            };

            foreach (var mesh in model.Meshes)
            {
                group.Children.Add(mesh);
            }

            foreach (var child in model.Models)
            {
                group.Children.Add(GroupFromModel(child));
            }
            return group;
        }

        public void AddMeshesToRiggedGroups(Appearance app)
        {
            var groups = new Dictionary<string, GroupModel3D>();

            foreach (var (name, rig) in Rigs)
            {
                var group = new GroupModel3D()
                {
                    Name = $"{rig.Name}",
                    Transform = new MatrixTransform3D(rig.Matrix.ToMatrix3D())
                };
                group.Children.Add(GroupFromRigBone(rig, rig.Bones[0], groups));
                groups.Add(name, group);
                app.ModelGroup.Add(group);
            }

            foreach (var model in app.BindableModels)
            {
                var group = GroupFromModel(model);

                if (model.BindName == null)
                {
                    app.ModelGroup.Add(group);
                    return;
                }
                if (_slotSets.ContainsKey(model.BindName))
                {
                    if (model.SlotName != null && _slotSets[model.BindName].Slots.ContainsKey(model.SlotName))
                    {
                        var slot = _slotSets[model.BindName].Slots[model.SlotName];

                        if (groups.ContainsKey(_slotSets[model.BindName].BindName + ":" + slot))
                        {
                            groups[_slotSets[model.BindName].BindName + ":" + slot].Children.Add(group);
                        }
                    }
                }
                else if (groups.ContainsKey(model.BindName))
                {
                    groups[model.BindName].Children.Add(group);
                }
                else
                {
                    app.ModelGroup.Add(group);
                }
            }
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
                string meshApp = "default";
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
                    var meshFile = File.GetFileFromDepotPathOrCache(depotPath);

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
                        //if (File.GetFileFromDepotPathOrCache(inst.BaseMaterial.DepotPath) is var file)
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
                    var apps = new List<string>();
                    foreach (var handle in mesh.Appearances)
                    {
                        var app = handle.GetValue();
                        if (app is meshMeshAppearance mmapp)
                        {
                            apps.Add(mmapp.Name);
                        }
                    }

                    var appIndex = 0;

                    if (meshApp != "default" && apps.IndexOf(meshApp) is var index && index != -1)
                    {
                        appIndex = index;
                    }

                    var appMaterials = new List<Material>();

                    foreach (var handle in mesh.Appearances)
                    {
                        var app = handle.GetValue();
                        if (app is meshMeshAppearance mmapp && (mmapp.Name == meshApp || (meshApp == "default" && mesh.Appearances.IndexOf(handle) == 0)))
                        {
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
                            break;
                        }
                    }

                    var model = new LoadableModel()
                    {
                        MeshFile = meshFile,
                        AppearanceIndex = appIndex,
                        AppearanceName = meshApp,
                        Matrix = matrix,
                        Materials = appMaterials,
                        IsEnabled = enabled,
                        Name = epc.Name,
                        BindName = bindName,
                        SlotName = slotName,
                        ChunkMask = chunkMask,
                        ChunkList = chunkList,
                        EnabledChunks = enabledChunks
                    };
                    appModels.Add(epc.Name, model);
                }
            }

            var list = new List<LoadableModel>();

            foreach (var model in appModels.Values)
            {
                var matrix = new SeparateMatrix();
                //GetResolvedMatrix(model, ref matrix, appModels);
                model.Transform = new MatrixTransform3D(model.Matrix.ToMatrix3D());
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

        public static Vector3D ToVector3D(WorldPosition v) => new Vector3D((float)v.X, (float)v.Z, -(float)v.Y);

        public static Vector3D ToVector3D(Vector4 v) => new Vector3D(v.X, v.Z, -v.Y);

        public static Vector3D ToVector3D(Vector3 v) => new Vector3D(v.X, v.Z, -v.Y);

        public static Vector3D ToScaleVector3D(Vector4 v) => new Vector3D(v.X, v.Z, v.Y);

        public static Vector3D ToScaleVector3D(Vector3 v) => new Vector3D(v.X, v.Z, v.Y);

        public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.X.X, matrix.Y.X, matrix.Z.X, matrix.W.X,
                                                                          matrix.X.Y, matrix.Y.Y, matrix.Z.Y, matrix.W.Y,
                                                                          matrix.X.Z, matrix.Y.Z, matrix.Z.Z, matrix.W.Z,
                                                                          matrix.X.W, matrix.Y.W, matrix.Z.W, matrix.W.W);
        //public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.W.W, matrix.X.W, matrix.Y.W, matrix.Z.W,
        //                                                                  matrix.W.X, matrix.X.X, matrix.Y.X, matrix.Z.X,
        //                                                                  matrix.W.Y, matrix.X.Y, matrix.Y.Y, matrix.Z.Y,
        //                                                                  matrix.W.Z, matrix.X.Z, matrix.Y.Z, matrix.Z.Z);
        //public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.X.X, matrix.X.Y, matrix.X.Z, matrix.X.W,
        //                                                                  matrix.Y.X, matrix.Y.Y, matrix.Y.Z, matrix.Y.W,
        //                                                                  matrix.Z.X, matrix.Z.Y, matrix.Z.Z, matrix.Z.W,
        //                                                                  matrix.W.X, matrix.W.Y, matrix.W.Z, matrix.W.W);
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
