using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using Prism.Commands;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{

    public interface IBindable
    {
        public SeparateMatrix Matrix { get; set; }
        public string? BindName { get; set; }
        public string? SlotName { get; set; }
    }

    public interface INode
    {
        public string Name { get; set; }
        public SeparateMatrix Matrix { get; set; }
        public INode? Parent { get; set; }
        public List<LoadableModel> Models { get; set; }

        public void AddModel(LoadableModel child);
    }

    public class Appearance
    {
        public Appearance(string name) => Name = name;

        public Dictionary<uint, List<SubmeshComponent>> LODLUT { get; set; } = new();

        private uint _selectedLOD = 1;
        public uint SelectedLOD
        {
            get => _selectedLOD;
            set
            {
                _selectedLOD = value;
                foreach (var lod in LODLUT.Keys)
                {
                    foreach (var submesh in LODLUT[lod])
                    {
                        submesh.IsRendering = lod == _selectedLOD && submesh.EnabledWithMask;
                    }
                }
            }
        }
        public string? AppearanceName { get; set; }
        public string Name { get; set; }

        public List<LoadableModel> Models { get; set; } = new();
        public CName Resource { get; set; }
        public List<INode> Nodes { get; set; } = new();
        public SmartElement3DCollection ModelGroup { get; set; } = new();
        public List<LoadableModel> BindableModels { get; set; } = new();
        public Dictionary<string, Material> RawMaterials { get; set; } = new();
    }

    public class LoadableModel : IBindable, INode
    {
        public LoadableModel(string name) => Name = name;


        public int AppearanceIndex { get; set; }
        public string? AppearanceName { get; set; }
        public CR2WFile? MeshFile { get; set; }
        public CName DepotPath { get; set; }
        public List<SubmeshComponent> Meshes { get; set; } = new();
        public string? FilePath { get; set; }
        public Model3D? OriginalModel { get; set; }
        public Model3D? Model { get; set; }
        public Transform3D? Transform { get; set; }
        public bool IsEnabled { get; set; }
        public string Name { get; set; }

        public List<Material> Materials { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string? BindName { get; set; }
        public string? SlotName { get; set; }

        public ulong ChunkMask { get; set; } = ulong.MaxValue;
        public List<bool> ChunkList { get; set; } = new(64);
        public ObservableCollection<int> AllChunks { get; set; } = new();
        public ObservableCollection<int> EnabledChunks { get; set; } = new();

        public INode? Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class Rig : IBindable, INode
    {
        public Rig(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<RigBone> Bones { get; set; } = new();
        public List<Rig> Children { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string? BindName { get; set; }
        public string? SlotName { get; set; }

        public void AddChild(Rig child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public INode? Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class RigBone : INode
    {
        public RigBone(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<RigBone> Children { get; set; } = new();
        public SeparateMatrix Matrix { get; set; } = new();

        public void AddChild(RigBone child)
        {
            child.Parent = this;
            Children.Add(child);
        }

        public INode? Parent { get; set; }
        public List<LoadableModel> Models { get; set; } = new();
        public void AddModel(LoadableModel child)
        {
            child.Parent = this;
            Models.Add(child);
        }
    }

    public class SlotSet : IBindable
    {
        public SlotSet(string name, string bindname)
        {
            Name = name;
            BindName = bindname;
        }
        public string Name { get; set; }
        public Dictionary<string, string> Slots { get; set; } = new();

        public SeparateMatrix Matrix { get; set; } = new();
        public string? BindName { get; set; }
        public string? SlotName { get; set; }
    }

    public class Material
    {
        public Material(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public CMaterialInstance? Instance { get; set; }
        public Dictionary<string, object> Values { get; set; } = new();
        public Material? Base { get; set; }
        public Bitmap? ColorTexture { get; set; }
        public string? ColorTexturePath { get; set; }
        public string? TemplateName { get; set; }
        public float Metalness { get; set; } = 0.0f;
        public float Roughness { get; set; } = 0.75f;
    }
    public class PanelVisibility
    {
        public bool ShowExportEntity { get; set; }
        public bool ShowSearchPanel { get; set; }
        public bool ShowSelectionPanel { get; set; }

    }

    public static class MeshViewHeaders
    {
        public const string MeshPreview = "Mesh Preview";
        public const string AllSectorPreview = "All Sector Preview";
        public const string SectorPreview = "Sector Preview";
        public const string EntityPreview = "Entity Preview";
    }


    public partial class RDTMeshViewModel : RedDocumentTabViewModel, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();

        protected readonly RedBaseClass _data;

        private readonly Dictionary<string, LoadableModel> _modelList = new();
        private readonly Dictionary<string, SlotSet> _slotSets = new();

        public EffectsManager EffectsManager { get; }

        public HelixToolkit.Wpf.SharpDX.Camera Camera { get; }

        public SceneNodeGroupModel3D GroupModel { get; set; } = new SceneNodeGroupModel3D();

        //public List<Element3D> ModelGroup { get; set; } = new();
        public SmartElement3DCollection ModelGroup { get; set; } = new();

        public TextureModel EnvironmentMap { get; set; }

        public bool IsRendered;

        private const int s_distanceCameraUnits = 145;
        private const double s_cameraUpDirectionFactor = 0.7;
        private const int s_cameraAnimationTime = 400;

        public PanelVisibility PanelVisibility { get; set; } = new();

        public RDTMeshViewModel(RedDocumentViewModel file)
        {
            try
            {
                Header ??= MeshViewHeaders.MeshPreview;

                File = file;

                foreach (var res in File.Cr2wFile.EmbeddedFiles)
                {
                    if (!File.Files.ContainsKey(res.FileName))
                    {
                        File.Files.Add(res.FileName, new CR2WFile()
                        {
                            RootChunk = res.Content
                        });
                    }
                }

                EffectsManager = new DefaultEffectsManager();

                //EnvironmentMap = TextureModel.Create(Path.Combine(ISettingsManager.GetTemp_OBJPath(), "Cubemap_Grandcanyon.dds"));
                Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera()
                {
                    FarPlaneDistance = 1E+8,
                    LookDirection = new System.Windows.Media.Media3D.Vector3D(1f, -1f, -1f)
                };

                ExtractShadersCommand = new DelegateCommand(ExtractShaders);
                LoadMaterialsCommand = new DelegateCommand(LoadMaterials);
            }
            catch (Exception ex)
            {
                Locator.Current.GetService<ILoggerService>().NotNull().Error(ex);
            }

        }

        public RDTMeshViewModel(CMesh data, RedDocumentViewModel file) : this(file)
        {
            _data = data;
            //Render = RenderMesh;

            this.WhenActivated((CompositeDisposable disposables) => RenderMesh());
        }

        public void RenderMesh()
        {
            if (IsRendered)
            {
                return;
            }
            IsRendered = true;
            var data = (CMesh)_data;
            var materials = new Dictionary<string, Material>();

            var localList = data.LocalMaterialBuffer.RawData?.Buffer.Data as CR2WList ?? null;

            foreach (var me in data.MaterialEntries)
            {
                var name = GetUniqueMaterialName(me.Name, data);
                if (!me.IsLocalInstance)
                {
                    materials.Add(name, new Material(name));
                    continue;
                }
                CMaterialInstance? inst = null;

                if (localList != null && localList.Files.Count > me.Index)
                {
                    inst = localList.Files[me.Index].RootChunk as CMaterialInstance;
                }
                else
                {
                    //foreach (var pme in data.PreloadLocalMaterialInstances)
                    //{
                    //inst = (CMaterialInstance)pme.GetValue();
                    //}
                    inst = data.PreloadLocalMaterialInstances[me.Index].GetValue() as CMaterialInstance;
                }

                //CMaterialInstance bm = null;
                //if (File.GetFileFromDepotPathOrCache(inst.BaseMaterial.DepotPath) is var file)
                //{
                //    bm = (CMaterialInstance)file.RootChunk;
                //}
                var material = new Material(name)
                {
                    Instance = inst,
                };

                ArgumentNullException.ThrowIfNull(inst);

                foreach (var pair in inst.Values)
                {
                    material.Values[pair.Key] = pair.Value;
                }

                materials[name] = material;
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
                        var name = GetUniqueMaterialName(materialName, data);
                        if (materials.ContainsKey(name))
                        {
                            appMaterials.Add(materials[name]);
                        }
                        else
                        {
                            appMaterials.Add(new Material(name));
                        }
                    }

                    var a = new Appearance(mmapp.Name);

                    var model = new LoadableModel(Path.GetFileNameWithoutExtension(File.ContentId).Replace("-", "_").Replace(".", "_"))
                    {
                        MeshFile = File.Cr2wFile,
                        AppearanceIndex = appIndex,
                        AppearanceName = mmapp.Name,
                        Materials = appMaterials,
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
                    a.ModelGroup.AddRange(AddMeshesToRiggedGroups(a));

                    Appearances.Add(a);
                }
                appIndex++;
            }

            SelectedAppearance = Appearances.FirstOrDefault();
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
            public string? AppearanceName { get; set; }
            public string? MaterialName { get; set; }
            public string? WorldNodeIndex { get; set; }
            public CName DepotPath { get; set; }
        }

        public GroupModel3D GroupFromModel(LoadableModel model)
        {
            var group = new MeshComponent();
            try
            {
                group.Name = !string.IsNullOrEmpty(model.Name) && char.IsDigit(model.Name[0]) ? $"_{model.Name}" : $"{model.Name}";
                group.AppearanceName = model.AppearanceName;
                group.Transform = model.Transform;
                group.IsRendering = model.IsEnabled;
                group.DepotPath = model.DepotPath;
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

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

        public List<Element3D> AddMeshesToRiggedGroups(Appearance app)
        {
            var groups = new Dictionary<string, GroupModel3D>();
            var modelGroups = new List<Element3D>();
            foreach (var (name, rig) in Rigs)
            {
                var group = new GroupModel3D()
                {
                    Name = $"{rig.Name}",
                    Transform = new MatrixTransform3D(rig.Matrix.ToMatrix3D())
                };
                group.Children.Add(GroupFromRigBone(rig, rig.Bones[0], groups));
                groups.Add(name, group);
                modelGroups.Add(group);
            }

            foreach (var model in app.BindableModels)
            {
                var group = GroupFromModel(model);

                if (model.BindName == null)
                {
                    modelGroups.Add(group);
                    continue;
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
                    modelGroups.Add(group);
                }
            }
            return modelGroups;
        }

        private List<LoadableModel>? LoadMeshs(IList<RedBaseClass> chunks)
        {
            if (chunks == null)
            {
                return null;
            }

            var appModels = new Dictionary<string, LoadableModel>();

            foreach (var component in chunks)
            {
                var scale = new Vector3() { X = 1, Y = 1, Z = 1 };
                var depotPath = CName.Empty;
                var enabled = true;
                var meshApp = "default";
                var chunkMask = 18446744073709551615;
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
                    {
                        enabledChunks.Add(i);
                    }
                }

                if (component is entIPlacedComponent epc && depotPath != CName.Empty && depotPath.GetRedHash() != 0)
                {
                    var meshFile = File.GetFileFromDepotPathOrCache(depotPath);

                    if (meshFile == null || meshFile.RootChunk is not CMesh mesh)
                    {
                        Locator.Current.GetService<ILoggerService>().NotNull().Warning($"Couldn't find mesh file: {depotPath} / {depotPath.GetRedHash()}");
                        continue;
                    }

                    var matrix = ToSeparateMatrix(epc.LocalTransform);

                    string? bindName = null, slotName = null;
                    if ((epc.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                    {
                        bindName = ehtb.BindName;
                        slotName = ehtb.SlotName;
                    }

                    matrix.Scale(ToScaleVector3D(scale));

                    var materials = new Dictionary<string, Material>();

                    var localList = mesh.LocalMaterialBuffer.RawData?.Buffer.Data as CR2WList ?? null;

                    foreach (var me in mesh.MaterialEntries)
                    {
                        var name = GetUniqueMaterialName(me.Name, mesh);
                        if (!me.IsLocalInstance)
                        {
                            materials.Add(name, new Material(name));
                            continue;
                        }

                        CMaterialInstance? inst = null;

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

                        var material = new Material(name)
                        {
                            Instance = inst,
                        };

                        foreach (var pair in inst.Values)
                        {
                            material.Values[pair.Key] = pair.Value;
                        }

                        materials[name] = material;
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
                                var name = GetUniqueMaterialName(m, mesh);
                                if (materials.ContainsKey(name))
                                {
                                    appMaterials.Add(materials[name]);
                                }
                                else
                                {
                                    appMaterials.Add(new Material(name));
                                }
                            }
                            break;
                        }
                    }

                    var model = new LoadableModel(epc.Name.ToString().Replace(".", ""))
                    {
                        MeshFile = meshFile,
                        AppearanceIndex = appIndex,
                        AppearanceName = meshApp,
                        Matrix = matrix,
                        Materials = appMaterials,
                        IsEnabled = enabled,
                        BindName = bindName,
                        SlotName = slotName,
                        ChunkMask = chunkMask,
                        ChunkList = chunkList,
                        EnabledChunks = enabledChunks,
                        DepotPath = depotPath
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

        //public void AddToRigs(Dictionary<string, LoadableModel> models)
        //{
        //    SelectedAppearance.Nodes.Clear();
        //    foreach (var (name, rig) in Rigs)
        //    {
        //        SelectedAppearance.Nodes.Add(rig);
        //        rig.Models.Clear();
        //        foreach (var rigbone in rig.Bones)
        //        {
        //            rigbone.Models.Clear();
        //            SelectedAppearance.Nodes.Add(rigbone);
        //        }
        //    }

        //    foreach (var (name, model) in models)
        //    {
        //        SelectedAppearance.Nodes.Add(model);
        //        if (model.BindName == null)
        //        {
        //            continue;
        //        }

        //        if (models.ContainsKey(model.BindName))
        //        {
        //            models[model.BindName].AddModel(model);
        //        }
        //        else if (_slotSets.ContainsKey(model.BindName))
        //        {
        //            if (model.SlotName != null && _slotSets[model.BindName].Slots.ContainsKey(model.SlotName))
        //            {
        //                var slot = _slotSets[model.BindName].Slots[model.SlotName];

        //                if (Rigs.ContainsKey(_slotSets[model.BindName].BindName))
        //                {
        //                    var rigBone = Rigs[_slotSets[model.BindName].BindName].Bones.Where(x => x.Name == slot).FirstOrDefault(defaultValue: null);

        //                    rigBone?.AddModel(model);
        //                }
        //            }
        //        }
        //        else if (Rigs.ContainsKey(model.BindName))
        //        {
        //            Rigs[model.BindName].AddModel(model);
        //        }
        //        else
        //        {
        //            Rigs.First().Value.AddModel(model);
        //        }
        //    }

        //    // return root?
        //}

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

                            var bindname = _slotSets[bindable.BindName].BindName;
                            if (bindname is not null && Rigs.ContainsKey(bindname))
                            {
                                var rigBone = Rigs[bindname].Bones.Where(x => x.Name == slot).FirstOrDefault(defaultValue: null);

                                while (rigBone != null)
                                {
                                    matrix.AppendPost(rigBone.Matrix);
                                    rigBone = rigBone.Parent as RigBone;
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
        public static void ExtractShaders()
        {
            var _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();
            ShaderCacheReader.ExtractShaders(new FileInfo(_settingsManager.CP77ExecutablePath), ISettingsManager.GetTemp_OBJPath());
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        [Reactive] public ImageSource Image { get; set; }

        [Reactive] public object SelectedItem { get; set; }

        [Reactive] public string LoadedModelPath { get; set; }

        [Reactive] public List<LoadableModel> Models { get; set; } = new();

        [Reactive] public Dictionary<string, Rig> Rigs { get; set; } = new();

        [Reactive] public List<Appearance> Appearances { get; set; } = new();

        [Reactive] public Appearance? SelectedAppearance { get; set; }

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

        public static System.Windows.Media.Media3D.Quaternion ToQuaternion(RED4.Types.Quaternion q) => new(q.I, q.K, -q.J, q.R);
        public static System.Windows.Media.Media3D.Quaternion ToQuaternionOG(RED4.Types.Quaternion q) => new(q.I, q.J, q.K, q.R);

        //public static Vector3D ToVector3D(WorldPosition v) => new Vector3D(v.X, v.Y, v.Z);

        //public static Vector3D ToVector3D(Vector4 v) => new Vector3D(v.X, v.Y, v.Z);

        //public static Vector3D ToVector3D(Vector3 v) => new Vector3D(v.X, v.Y, v.Z);

        public static Vector3D ToVector3D(WorldPosition v) => new((float)v.X, (float)v.Z, -(float)v.Y);

        public static Vector3D ToVector3D(Vector4 v) => new(v.X, v.Z, -v.Y);

        public static Vector3D ToVector3D(Vector3 v) => new(v.X, v.Z, -v.Y);

        public static Vector3D ToScaleVector3D(Vector4 v) => new(v.X, v.Z, v.Y);

        public static Vector3D ToScaleVector3D(Vector3 v) => new(v.X, v.Z, v.Y);

        public static Matrix3D ToMatrix3D(CMatrix matrix) => new(matrix.X.X, matrix.Y.X, matrix.Z.X, matrix.W.X,
                                                                          matrix.X.Y, matrix.Y.Y, matrix.Z.Y, matrix.W.Y,
                                                                          matrix.X.Z, matrix.Y.Z, matrix.Z.Z, matrix.W.Z,
                                                                          matrix.X.W, matrix.Y.W, matrix.Z.W, matrix.W.W);
        //public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.X.X, matrix.Z.X, -matrix.Y.X, matrix.W.X,
        //                                                                  matrix.X.Z, matrix.Z.Z, -matrix.Y.Z, matrix.W.Z,
        //                                                                  -matrix.X.Y, -matrix.Z.Y, matrix.Y.Y, -matrix.W.Y,
        //                                                                  matrix.X.W, matrix.Z.W, -matrix.Y.W, matrix.W.W);
        //public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.W.W, matrix.X.W, matrix.Y.W, matrix.Z.W,
        //                                                                  matrix.W.X, matrix.X.X, matrix.Y.X, matrix.Z.X,
        //                                                                  matrix.W.Y, matrix.X.Y, matrix.Y.Y, matrix.Z.Y,
        //                                                                  matrix.W.Z, matrix.X.Z, matrix.Y.Z, matrix.Z.Z);
        //public static Matrix3D ToMatrix3D(CMatrix matrix) => new Matrix3D(matrix.X.X, matrix.X.Y, matrix.X.Z, matrix.X.W,
        //                                                                  matrix.Y.X, matrix.Y.Y, matrix.Y.Z, matrix.Y.W,
        //                                                                  matrix.Z.X, matrix.Z.Y, matrix.Z.Z, matrix.Z.W,
        //                                                                  matrix.W.X, matrix.W.Y, matrix.W.Z, matrix.W.W);

        public void CenterCameraToCoord(Vector3 coord)
        {
            Camera.AnimateTo(
                    new System.Windows.Media.Media3D.Point3D(coord.X, coord.Z + s_distanceCameraUnits, -coord.Y + s_distanceCameraUnits),
                    new Vector3D(0, -s_distanceCameraUnits, -s_distanceCameraUnits),
                    new Vector3D(0, s_cameraUpDirectionFactor, -s_cameraUpDirectionFactor),
                    s_cameraAnimationTime);
        }

        public void MouseDown3D(object sender, RoutedEventArgs e)
        {
            if (e is MouseDown3DEventArgs args && args.HitTestResult != null)
            {
                var mouseButtonEventArgs = (MouseButtonEventArgs)args.OriginalInputEventArgs;
                MouseDown3DSector(sender, args, mouseButtonEventArgs);
                MouseDown3DBlock(sender, args, mouseButtonEventArgs);

                CommonMouseDownEvents(args.HitTestResult.ModelHit, mouseButtonEventArgs);
            }
        }

        private void CommonMouseDownEvents(object modelHit, MouseButtonEventArgs mouseButtonEventArgs)
        {
            if (mouseButtonEventArgs.LeftButton == MouseButtonState.Pressed && modelHit is SubmeshComponent { Parent: MeshComponent { Parent: MeshComponent mesh } })
            {
                Locator.Current.GetService<ILoggerService>().NotNull().Info((mesh.WorldNodeIndex != null ? "worldNodeData[" + mesh.WorldNodeIndex + "] : " : "Mesh Name :") + mesh.Name);
            }

        }
    }

    public class SeparateMatrix
    {
        public Matrix3D rotation = new();
        public Matrix3D translation = new();
        public Matrix3D scale = new();
        public Matrix3D post = new();

        public SeparateMatrix()
        {

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

        public void Scale(Vector3D v) => scale.Scale(v);

        public void Rotate(System.Windows.Media.Media3D.Quaternion q) => rotation.Rotate(q);//scale.Rotate(q);

        public void Translate(Vector3D v) => translation.Translate(v);//scale.Translate(v);

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
