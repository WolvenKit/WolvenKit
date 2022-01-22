using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using CP77.CR2W;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
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
        }

        public RDTMeshViewModel(CMesh data, RedDocumentViewModel file) : this(file)
        {
            _data = data;

            var list = new List<LoadableModel>();

            var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileNameWithoutExtension(file.FilePath) + "_full.glb");
            if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(file.Cr2wFile, new FileInfo(outPath)))
            {
                list.Add(new LoadableModel()
                {
                    FilePath = outPath,
                    IsEnabled = true,
                    Name = file.RelativePath
                });
            }

            Appearances.Add(new Appearance()
            {
                Name = "Default",
                Models = list
            });

            SelectedAppearance = Appearances[0];
        }

        public RDTMeshViewModel(entEntityTemplate ent, RedDocumentViewModel file) : this(file)
        {
            _data = ent;

            if (ent.CompiledData.Data is not Package04 pkg)
                return;

            if (ent.Appearances.Count > 0)
            {
                var appPaths = new List<CName>();
                foreach (var app in ent.Appearances)
                {
                    var a = new Appearance()
                    {
                        AppearanceName = app.AppearanceName,
                        Name = app.Name,
                        Resource = app.AppearanceResource.DepotPath
                    };
                    Appearances.Add(a);
                }

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

                foreach (var a in Appearances)
                {
                    var appFile = File.GetFileFromDepotPath(a.Resource);

                    if (appFile != null && appFile.RootChunk is appearanceAppearanceResource app && app.Appearances.Count > 0 && app.Appearances[0].GetValue() is appearanceAppearanceDefinition appDef && appDef.CompiledData.Data is Package04 appPkg)
                    {
                        a.Models = LoadMeshs(appPkg.Chunks);
                    }
                }

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
                if (component is entMeshComponent emc)
                {
                    depotPath = emc.Mesh.DepotPath;
                    scale = emc.VisualScale;
                    enabled = emc.IsEnabled;
                }
                else if (component is entSkinnedMeshComponent esmc)
                {
                    depotPath = esmc.Mesh.DepotPath;
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

                    var materials = new List<Material>();

                    var localList = (CR2WList)mesh.LocalMaterialBuffer.RawData?.Buffer.Data ?? null;

                    if (localList != null)
                    {
                        foreach (var me in mesh.MaterialEntries)
                        {
                            if (!me.IsLocalInstance)
                            {
                                materials.Add(new Material()
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

                            materials.Add(new Material()
                            {
                                Instance = inst,
                                Name = me.Name
                            });

                            foreach (var value in inst.Values)
                            {
                                materials[me.Index].Values.Add(value.Key, value.Value);
                            }

                        }
                    }

                    var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileNameWithoutExtension(depotPath) + "_" + depotPath.GetRedHash().ToString() + "_full.glb");
                    //var outPath = Path.Combine(ISettingsManager.GetTemp_OBJPath(), Path.GetFileName(depotPath) + "_" + depotPath.GetRedHash().ToString()) + "_full.glb";
                    if (System.IO.File.Exists(outPath) || MeshTools.ExportMesh(meshFile, new FileInfo(outPath)))
                    {
                        if (!appModels.ContainsKey(epc.Name))
                        {
                            appModels.Add(epc.Name, new LoadableModel()
                            {
                                FilePath = outPath,
                                Matrix = matrix,
                                IsEnabled = enabled,
                                Name = epc.Name,
                                BindName = bindName,
                                SlotName = slotName,
                                Materials = materials
                            });
                        }
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
