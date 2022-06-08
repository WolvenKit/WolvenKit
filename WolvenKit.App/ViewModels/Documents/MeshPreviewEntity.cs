using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows.Input;
using HelixToolkit.Wpf.SharpDX;
using Microsoft.Win32;
using ReactiveUI;
using Splat;
using WolvenKit.App.Commands.Base;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents
{
    public partial class RDTMeshViewModel
    {
        public ICommand ExportEntity { get; set; }

        public bool ShowExportEntity { get; set; }

        public RDTMeshViewModel(entEntityTemplate ent, RedDocumentViewModel file) : this(file)
        {
            Header = "Entity Preview";
            _data = ent;

            ShowExportEntity = true;
            ExportEntity = new DelegateCommand((e) =>
            {
                var dlg = new SaveFileDialog
                {
                    FileName = Path.GetFileNameWithoutExtension(file.RelativePath) + ".glb",
                    Filter = "GLB files (*.glb)|*.glb|All files (*.*)|*.*"
                };
                if (dlg.ShowDialog().GetValueOrDefault())
                {
                    var outFile = new FileInfo(dlg.FileName);
                    // will only use archive files (for now)
                    if (Locator.Current.GetService<ModTools>().ExportEntity(File.Cr2wFile, SelectedAppearance.AppearanceName, outFile))
                    {
                        Locator.Current.GetService<ILoggerService>().Success($"Entity with appearance '{SelectedAppearance.AppearanceName}'exported: {dlg.FileName}");
                    }
                    else
                    {
                        Locator.Current.GetService<ILoggerService>().Error($"Error exporting entity with appearance '{SelectedAppearance.AppearanceName}'");
                    }
                }
            });

            this.WhenActivated((CompositeDisposable disposables) => RenderEntitySolo());
        }

        public void RenderEntitySolo()
        {
            if (IsRendered)
            {
                return;
            }
            IsRendered = true;
            _ = RenderEntity((entEntityTemplate)_data);
        }

        public Element3D RenderEntity(entEntityTemplate ent, Appearance appearance = null, string appearanceName = null)
        {
            if (ent.CompiledData.Data is not RedPackage pkg)
            {
                return null;
            }

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
                            {
                                slots.Add(slot.SlotName, slot.BoneName);
                            }
                        }

                        string bindName = null, slotName = null;
                        if ((slotset.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                        {
                            bindName = ehtb.BindName;
                            slotName = ehtb.SlotName;
                        }
                        if (!_slotSets.ContainsKey(slotset.Name))
                        {
                            _slotSets.Add(slotset.Name, new SlotSet()
                            {
                                Name = slotset.Name,
                                Matrix = ToSeparateMatrix(slotset.LocalTransform),
                                Slots = slots,
                                BindName = bindName,
                                SlotName = slotName
                            });
                        }
                    }

                    if (component is entAnimatedComponent enc)
                    {
                        var rigFile = File.GetFileFromDepotPathOrCache(enc.Rig.DepotPath);

                        if (rigFile.RootChunk is animRig rig)
                        {
                            var rigBones = new List<RigBone>();
                            for (var i = 0; i < rig.BoneNames.Count; i++)
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

                            Rigs[enc.Name] = new Rig()
                            {
                                Name = enc.Name,
                                Bones = rigBones,
                                BindName = bindName,
                                SlotName = slotName
                            };
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

                var appearances = appearanceName == null ? ent.Appearances.ToList() : ent.Appearances.Where(x => x.AppearanceName == appearanceName).ToList();

                var element = new GroupModel3D();

                foreach (var app in appearances)
                {
                    var appFile = File.GetFileFromDepotPathOrCache(app.AppearanceResource.DepotPath);

                    if (appFile == null || appFile.RootChunk is not appearanceAppearanceResource aar)
                    {
                        continue;
                    }

                    foreach (var handle in aar.Appearances)
                    {
                        var appDef = (appearanceAppearanceDefinition)handle.GetValue();

                        if (appDef.Name != app.AppearanceName || appDef.CompiledData.Data is not RedPackage appPkg)
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

                        if (appearance == null)
                        {
                            a.ModelGroup.AddRange(AddMeshesToRiggedGroups(a));
                            Appearances.Add(a);
                        }
                        else
                        {
                            //appearance.ModelGroup.AddRange(a.ModelGroup);
                            var group = AddMeshesToRiggedGroups(a);
                            foreach (var model in group)
                            {
                                element.Children.Add(model);
                            }
                        }
                        break;
                    }
                }
                if (appearance == null)
                {
                    if (Appearances.Count > 0)
                    {
                        SelectedAppearance = Appearances[0];
                    }
                }
                return element;
            }
            else
            {
                var models = LoadMeshs(pkg.Chunks);

                if (models == null)
                {
                    return null;
                }

                var a = appearance ?? new Appearance()
                {
                    Name = "Default",
                    Models = models
                };

                var group = new MeshComponent();

                foreach (var model in models)
                {
                    //if (models.FirstOrDefault(x => x.Name == model.BindName) is var parentModel && parentModel != null)
                    //{
                    //    parentModel.AddModel(model);
                    //}
                    //else
                    //{
                    //    a.BindableModels.Add(model);
                    //}
                    foreach (var material in model.Materials)
                    {
                        a.RawMaterials[material.Name] = material;
                    }
                    model.Meshes = MakeMesh((CMesh)model.MeshFile.RootChunk, model.ChunkMask, model.AppearanceIndex);

                    foreach (var m in model.Meshes)
                    {
                        group.Children.Add(m);
                        if (!a.LODLUT.ContainsKey(m.LOD))
                        {
                            a.LODLUT[m.LOD] = new List<SubmeshComponent>();
                        }
                        a.LODLUT[m.LOD].Add(m);
                    }
                }

                if (appearance == null)
                {
                    a.ModelGroup.Add(group);
                    Appearances.Add(a);
                    SelectedAppearance = a;
                }
                else
                {
                    //appearance.ModelGroup.Add(group);
                }

                var element = new GroupModel3D();
                foreach (var model in a.ModelGroup)
                {
                    element.Children.Add(model);
                }
                return element;
            }
        }
    }
}
