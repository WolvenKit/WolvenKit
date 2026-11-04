using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData.Kernel;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using Microsoft.Win32;
using WolvenKit.App.Controllers;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Common.PhysX;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using Color = System.Drawing.Color;
using IMaterial = WolvenKit.RED4.Types.IMaterial;
using Material = WolvenKit.App.Models.Material;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RDTMeshViewModel : RedDocumentTabViewModel, IDisposable
{
    private readonly ISettingsManager _settingsManager;
    private readonly IGameControllerFactory _gameController;
    private readonly ILoggerService _loggerService;
    private readonly IModTools _modTools;
    private readonly GeometryCacheService _geometryCacheService;
    private readonly IModifierViewStateService _modifierSvc;
    private readonly IArchiveManager? _archiveManager;

    // Short-lived cache for GetProjectOrDepotFile (cleared on material reload)
    private readonly System.Collections.Concurrent.ConcurrentDictionary<ResourcePath, CR2WFile?> _fileCache = new();
    private readonly System.Collections.Concurrent.ConcurrentDictionary<string, TextureModel> _textureCache = new();

    protected readonly RedBaseClass? _data;

    private readonly Dictionary<string, LoadableModel> _modelList = new();
    private readonly Dictionary<string, SlotSet> _slotSets = new();

    private const int s_distanceCameraUnits = 145;
    private const double s_cameraUpDirectionFactor = 0.7;
    private const int s_cameraAnimationTime = 400;


    #region ctor

    public RDTMeshViewModel(RedDocumentViewModel parent, string header,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        ILoggerService loggerService,
        IModTools modTools,
        GeometryCacheService geometryCacheService,
        IModifierViewStateService modifierSvc,
        IArchiveManager? archiveManager = null
    ) : base(parent, header)
    {
        _loggerService = loggerService;
        _settingsManager = settingsManager;
        _gameController = gameController;
        _modTools = modTools;
        _geometryCacheService = geometryCacheService;
        _modifierSvc = modifierSvc;
        _archiveManager = archiveManager;

        _modifierSvc.ModifierStateChanged += ModifierStateChanged;

        Parent = parent;
    }

    private void ModifierStateChanged() => IsCtrlKeyPressed = _modifierSvc.IsCtrlKeyPressed;

    // TODO refactor this into inherited viewmodels

    public RDTMeshViewModel(CMesh data, RedDocumentViewModel file,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        ILoggerService loggerService,
        IModTools modTools,
        GeometryCacheService geometryCacheService,
        IModifierViewStateService modifierSvc,
        IArchiveManager? archiveManager = null)
        : this(file, MeshViewHeaders.MeshPreview, settingsManager, gameController, loggerService, modTools,
            geometryCacheService, modifierSvc, archiveManager)
    {
        _data = data;
    }

    public RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        ILoggerService loggerService,
        IModTools modTools,
        GeometryCacheService geometryCacheService,
        IModifierViewStateService modifierSvc,
        IArchiveManager? archiveManager = null)
        : this(file, MeshViewHeaders.SectorPreview, settingsManager, gameController, loggerService, modTools,
            geometryCacheService, modifierSvc, archiveManager)
    {
        _data = data;
    }

    public RDTMeshViewModel(worldStreamingBlock data, RedDocumentViewModel file,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        ILoggerService loggerService,
        IModTools modTools,
        GeometryCacheService geometryCacheService,
        IModifierViewStateService modifierSvc,
        IArchiveManager? archiveManager = null)
        : this(file, MeshViewHeaders.AllSectorPreview, settingsManager, gameController, loggerService, modTools,
            geometryCacheService, modifierSvc, archiveManager)
    {
        _data = data;
    }

    public RDTMeshViewModel(entEntityTemplate ent, RedDocumentViewModel file,
        ISettingsManager settingsManager,
        IGameControllerFactory gameController,
        ILoggerService loggerService,
        IModTools modTools,
        GeometryCacheService geometryCacheService,
        IModifierViewStateService modifierSvc,
        IArchiveManager? archiveManager = null)
        : this(file, MeshViewHeaders.EntityPreview, settingsManager, gameController, loggerService, modTools,
            geometryCacheService, modifierSvc, archiveManager)
    {
        _data = ent;
    }

    public string? SelectedNodeIndex;



    public override void Load()
    {
        if (IsLoaded)
        {
            return;
        }

        appearanceWasAutoGenerated = false;

        materialWasAutoGenerated = false;

        try
        {
            foreach (var res in Parent.Cr2wFile.EmbeddedFiles)
            {
                if (!Parent.Files.ContainsKey(res.FileName))
                {
                    Parent.Files.Add(res.FileName, new CR2WFile()
                    {
                        RootChunk = res.Content
                    });
                }
            }

            EffectsManager = new DefaultEffectsManager();

            //EnvironmentMap = GetOrCreateTexture(Path.Combine(ISettingsManager.GetTemp_OBJPath(), "Cubemap_Grandcanyon.dds"));
            Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera()
            {
                FarPlaneDistance = 1E+8,
                LookDirection = new Vector3D(1f, -1f, -1f)
            };

            switch (_data)
            {
                case CMesh:
                    RenderMesh();
                    break;
                case worldStreamingSector:
                {
                    PanelVisibility.ShowSelectionPanel = true;
                    PanelVisibility.ShowToggleCollision = true;
                    var app = new Appearance(Path.GetFileNameWithoutExtension(Parent.ContentId).Replace("-", "_"));

                    Appearances.Add(app);
                    SelectedAppearance = app;

                    RenderSectorSolo();
                    break;
                }
                case worldStreamingBlock:
                    PanelVisibility.ShowSearchPanel = true;
                    PanelVisibility.ShowToggleCollision = true;
                    PanelVisibility.ShowAddSectors = true;

                    RenderBlockSolo();
                    break;
                case entEntityTemplate:
                    PanelVisibility.ShowExportEntity = true;

                    try
                    {
                        RenderEntitySolo();
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error(
                            $"Failed to render entity. Please ensure that all your component names are unique. If they are, open a ticket: \n${e}");
                    }

                    break;
                default:
                    break;
            }

        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService().Error(ex);
        }

        // Mark loaded even on failure so a retry does not duplicate appearances
        // and leak another EffectsManager. The error is already logged.
        IsLoaded = true;
    }

    public override void Unload()
    {
        // Subscription stays: Load() after Unload would not re-subscribe.
        RollbackGeneratedData();
    }

    private bool _disposed;

    public void Dispose()
    {
        if (_disposed)
            return;
        _disposed = true;

        _modifierSvc.ModifierStateChanged -= ModifierStateChanged;
        RollbackGeneratedData();
        _textureCache.Clear();
        _fileCache.Clear();

        var em = EffectsManager;
        EffectsManager = null;
        em?.Dispose();
    }

    private void RollbackGeneratedData()
    {
        if (_data is not CMesh data)
            return;

        if (materialWasAutoGenerated)
        {
            data.MaterialEntries.Clear();
            data.PreloadLocalMaterialInstances.Clear();
        }

        if (appearanceWasAutoGenerated)
        {
            data.Appearances.Clear();
        }
    }


    #endregion

    #region properties

    private EffectsManager? _effectsManager;
    private HelixToolkit.Wpf.SharpDX.Camera? _camera;

    public EffectsManager? EffectsManager
    {
        get => _effectsManager;
        set => SetProperty(ref _effectsManager, value);
    }

    public HelixToolkit.Wpf.SharpDX.Camera? Camera
    {
        get => _camera;
        private set => SetProperty(ref _camera, value);
    }

    public SceneNodeGroupModel3D GroupModel { get; set; } = new SceneNodeGroupModel3D();

    //public List<Element3D> ModelGroup { get; set; } = new();
    public SmartElement3DCollection ModelGroup { get; set; } = new();

    public TextureModel? EnvironmentMap { get; set; }

    public bool IsRendered;

    public PanelVisibility PanelVisibility { get; set; } = new();

    [ObservableProperty] private ImageSource? _image;

    [ObservableProperty] private object? _selectedItem;

    [ObservableProperty] private string? _loadedModelPath;

    [ObservableProperty] private List<LoadableModel> _models = new();

    [ObservableProperty] private Dictionary<string, Rig> _rigs = new();

    [ObservableProperty] private List<Appearance> _appearances = new();

    [ObservableProperty] private Appearance? _selectedAppearance;

    [ObservableProperty] private bool _isCtrlKeyPressed;

    [ObservableProperty] private bool _isLoaded;

    public bool CtrlKeyPressed { get; set; }

    public bool ShiftKeyPressed { get; set; }

    // We need to hold a copy of the property to avoid exceptions while filtering
    public List<Element3D> SelectedModelGroup
    {
        get => SelectedAppearance?.ModelGroup.ToList() ?? [];
        set
        {
            if (SelectedAppearance is null)
            {
                return;
            }

            var newElems = new SmartElement3DCollection();
            value.ForEach(v => newElems.Add(v));
            SelectedAppearance.ModelGroup = newElems;
            OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedModelGroup)));
        }
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(SelectedAppearance) && SelectedAppearance is not null)
        {
            if (SelectedAppearance.ModelGroup is not null)
            {
                SelectedModelGroup = SelectedAppearance.ModelGroup.ToList();
            }

            ApplyAppearancePreviewMaterials(SelectedAppearance);
        }

        base.OnPropertyChanged(e);
    }

    private void ApplyAppearancePreviewMaterials(Appearance app)
    {
        if (app == null || IsLoadingMaterials)
        {
            return;
        }

        var names = app.Models.SelectMany(m => m.Materials.Select(x => x.Name)).ToHashSet();
        if (names.Count == 0)
        {
            names = app.RawMaterials.Keys.ToHashSet();
        }

        foreach (var name in names)
        {
            var (albedoPng, _, _) = GetMaterialFilePathsFromCache(name);
            if (File.Exists(albedoPng))
            {
                SetupPBRMaterial(name, force: true);
            }
        }

        foreach (var model in app.Models)
        {
            foreach (var sm in model.Meshes)
            {
                if (string.IsNullOrEmpty(sm.MaterialName))
                {
                    continue;
                }

                sm.Material = SetupPBRMaterial(sm.MaterialName, force: true);
            }
        }
    }

    #endregion

    #region commands

    [RelayCommand]
    private void ExportEntity()
    {
        if (SelectedAppearance is null)
        {
            return;
        }
        if (SelectedAppearance.AppearanceName is null)
        {
            return;
        }

        var dlg = new SaveFileDialog
        {
            FileName = Path.GetFileNameWithoutExtension(Parent.RelativePath) + ".glb",
            Filter = "GLB files (*.glb)|*.glb|All files (*.*)|*.*"
        };

        if (!dlg.ShowDialog().GetValueOrDefault())
        {
            return;
        }

        var outFile = new FileInfo(dlg.FileName);
        // will only use archive files (for now)
        var appearanceName = SelectedAppearance.AppearanceName.NotNull();
        if (_modTools.ExportEntity(Parent.Cr2wFile, appearanceName, outFile))
        {
            Parent?.GetLoggerService().Success($"Entity with appearance '{appearanceName}'exported: {dlg.FileName}");
        }
        else
        {
            Parent?.GetLoggerService().Error($"Error exporting entity with appearance '{appearanceName}'");
        }
    }

    [RelayCommand]
    private void ExtractShaders()
    {
        if (_settingsManager.CP77ExecutablePath is null)
        {
            return;
        }

        ShaderCacheReader.ExtractShaders(new FileInfo(_settingsManager.CP77ExecutablePath), ISettingsManager.GetTemp_OBJPath());
    }

    private bool _isCollisionRendered = true;

    [RelayCommand]
    public void ToggleCollision()
    {
        if (SelectedAppearance is null)
        {
            return;
        }

        _isCollisionRendered = !_isCollisionRendered;

        foreach (var element in SelectedAppearance.ModelGroup)
        {
            SetRenderingState(element);
        }
    }

    private void SetRenderingState(Element3D element)
    {
        if (element is GroupModel3DExt groupModel)
        {
            if (groupModel.Text != null && groupModel.Text.StartsWith("collisionNode_"))
            {
                groupModel.IsRendering = _isCollisionRendered;
                return;
            }

            foreach (var child in groupModel.Children)
            {
                SetRenderingState(child);
            }
        }

        if (element is not SubmeshComponent submesh || submesh.Text == null || !submesh.Text.StartsWith("collisionNode_"))
        {
            return;
        }

        submesh.IsRendering = _isCollisionRendered;
    }

    #endregion

    #region methods

    private bool appearanceWasAutoGenerated = false;

    private bool materialWasAutoGenerated = false;

    public void RenderMesh()
    {
        // TODO [mana] does IsLoadingMaterials check work as expected here?
        if (IsRendered && !IsLoadingMaterials)
        {
            return;
        }
        IsRendered = true;
        if (_data is not CMesh data)
        {
            return;
        }
        var materials = new Dictionary<string, Material>();

        var localList = data.LocalMaterialBuffer.RawData?.Buffer.Data as CR2WList ?? null;

        // If there are no local materials defined that we can use to render the mesh, generate one
        if (data.MaterialEntries.Count == 0 || data.MaterialEntries.All((entry) => !entry.IsLocalInstance))
        {
            materialWasAutoGenerated = true;
            data.MaterialEntries.Add(new CMeshMaterialEntry() { Name = (CName)"default (generated)", Index = 0, IsLocalInstance = true });
            var material = new CMaterialInstance()
            {
                BaseMaterial = new CResourceReference<RED4.Types.IMaterial>(@"engine\materials\metal_base.remt")
            };
            material.Values.Add(new CKeyValuePair("BaseColor", (ResourcePath)@"base\surfaces\materials\default\debug_d.xbm"));
            data.PreloadLocalMaterialInstances.Add(material);
        }

        if (data.Appearances.Count == 0)
        {
            appearanceWasAutoGenerated = true;
            var app = new meshMeshAppearance();

            for (var i = 0; i < 21; i++)
            {
                app.ChunkMaterials.Add((CName)"default (generated)");
            }

            data.Appearances.Add(new CHandle<meshMeshAppearance>(app));
        }

        foreach (var me in data.MaterialEntries)
        {
            var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), data);
            if (!me.IsLocalInstance)
            {
                var extMaterial = new Material(name);
                FillFromExternal(extMaterial, data, me);
                materials[name] = extMaterial;
                continue;
            }
            CMaterialInstance? inst = null;

            if (localList != null && localList.Files.Count > me.Index)
            {
                inst = localList.Files[me.Index].RootChunk as CMaterialInstance;
            }
            else
            {
                // No further materials are defined (user was lazy)
                if (me.Index >= data.PreloadLocalMaterialInstances.Count)
                {
                    Parent?.GetLoggerService().Warning($"No material with index {me.Index} found. Not checking further entries…");
                    break;
                }

                inst = data.PreloadLocalMaterialInstances[me.Index]?.GetValue() as CMaterialInstance;
            }

            if (inst == null)
            {
                continue;
            }

            var material = new Material(name)
            {
                Instance = inst,
            };

            foreach (var pair in inst.Values)
            {
                var k = pair.Key.ToString().NotNull();
                material.Values[k] = pair.Value;
            }

            materials[name] = material;
        }

        var appIndex = 0;
        foreach (var handle in data.Appearances)
        {
            if (handle.GetValue() is not meshMeshAppearance mmapp)
            {
                appIndex++;
                continue;
            }

            var appMaterials = new List<Material>();

            foreach (var materialName in mmapp.ChunkMaterials)
            {
                var name = GetUniqueMaterialName(materialName.ToString().NotNull(), data);
                appMaterials.Add(materials.TryGetValue(name, out var material) ? material : new Material(name));
            }

            var appearance = new Appearance(mmapp.Name.ToString().NotNull());

            var model = new LoadableModel(Path.GetFileNameWithoutExtension(Parent?.ContentId ?? "").Replace("-", "_").Replace(".", "_"))
            {
                MeshFile = Parent?.Cr2wFile,
                AppearanceIndex = appIndex,
                AppearanceName = mmapp.Name,
                Materials = appMaterials,
                IsEnabled = true
            };
            appearance.Models.Add(model);
            appearance.BindableModels.Add(model);
            foreach (var material in materials.Values)
            {
                appearance.RawMaterials[material.Name] = material;
            }

            model.Meshes = MakeMesh(data, ulong.MaxValue, model.AppearanceIndex);

            var materialIndex = 0;
            foreach (var m in model.Meshes)
            {
                if (!appearance.LODLUT.TryGetValue(m.LOD, out var value))
                {
                    value = [];
                    appearance.LODLUT[m.LOD] = value;
                }

                // Ensure materialIndex is within the bounds of a.RawMaterials.Keys
                if (materialIndex >= appearance.RawMaterials.Keys.Count)
                {
                    materialIndex = 0; // Or handle this scenario as appropriate for your application
                }

                if (appearance.RawMaterials.Keys.Count > 0)
                {
                    var materialKey = appearance.RawMaterials.Keys.ElementAt(materialIndex);
                    m.MaterialName ??= materialKey;

                    value.Add(m);
                }
            }

            appearance.ModelGroup.AddRange(AddMeshesToRiggedGroups(appearance));

            Appearances.Add(appearance);
            appIndex++;
        }

        SelectedAppearance = Appearances.FirstOrDefault();
    }


    public GroupModel3D GroupFromRigBone(Rig rig, RigBone bone, Dictionary<string, GroupModel3D> groups)
    {
        var group = new GroupModel3DExt()
        {
            Name = bone.Name,
            Text = bone.Name,
            Transform = new MatrixTransform3D(bone.Matrix.ToMatrix3D())
        };
        foreach (var child in bone.Children)
        {
            group.Children.Add(GroupFromRigBone(rig, child, groups));
        }
        groups.Add(rig.Name + ":" + bone.Name, group);
        return group;
    }


    public GroupModel3D GroupFromModel(LoadableModel model)
    {
        var group = new MeshComponent();
        try
        {
            group.Name = !string.IsNullOrEmpty(model.Name) && char.IsDigit(model.Name[0]) ? $"_{model.Name}" : $"{model.Name}";
            group.Text = model.Name;
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

    private List<Element3D> AddMeshesToRiggedGroups(Appearance app)
    {
        var groups = new Dictionary<string, GroupModel3D>();
        var modelGroups = new List<Element3D>();
        foreach (var (name, rig) in Rigs)
        {
            if (name is "deformations" or "root")
            {
                continue;
            }
            var group = new GroupModel3DExt()
            {
                Name = $"{rig.Name}",
                Text = $"{rig.Name}",
                Transform = new MatrixTransform3D(rig.Matrix.ToMatrix3D())
            };
            group.Children.Add(GroupFromRigBone(rig, rig.Bones[0], groups));
            groups.Add(name, group);
            modelGroups.Add(group);
        }

        foreach (var model in app.BindableModels)
        {
            var group = GroupFromModel(model);

            if (model.BindName is null || model.SlotName is null or "None")
            {
                modelGroups.Add(group);
                continue;
            }

            if (_slotSets.TryGetValue(model.BindName, out var slotBind))
            {
                if (model.SlotName != null && slotBind.Slots.TryGetValue(model.SlotName, out var slot) &&
                    groups.ContainsKey(slotBind.BindName + ":" + slot))
                {
                    groups[slotBind.BindName + ":" + slot].Children.Add(group);

                }
            }
            else if (groups.TryGetValue(model.BindName, out var modelBind))
            {
                modelBind.Children.Add(group);
            }
            else
            {
                modelGroups.Add(group);
            }
        }
        return modelGroups;
    }

    private IEnumerable<LoadableModel> LoadPartsValues(appearanceAppearanceDefinition appDef)
    {
        if (appDef.PartsValues.Count is 0)
        {
            return [];
        }

        List<LoadableModel> ret = [];
        var appModels = new Dictionary<string, LoadableModel>();

        foreach (var appDefPartsValue in appDef.PartsValues)
        {
            if (appDefPartsValue is not appearanceAppearancePart partValue ||
                partValue.Resource.DepotPath.GetResolvedText() is not string path || path == "")
            {
                continue;
            }

            List<entIComponent> components = [];
            try
            {
                var meshEntityFile = GetProjectOrDepotFile(path);
                if (meshEntityFile?.RootChunk is not entEntityTemplate entityTemplate)
                {
                    continue;
                }

                components.AddRange(entityTemplate.Components);
            }
            catch

            {
                Parent?.GetLoggerService().Warning($"Failed to read partsValue from {path}");
                continue;
            }

            foreach (var entityTemplateComponent in components)
            {
                if (entityTemplateComponent is not IRedMeshComponent irm || irm.Name.GetResolvedText() is not string s || s == "")
                {
                    continue;
                }

                ProcessComponents(entityTemplateComponent, appModels);
                if (appModels.TryGetValue(s, out var model))
                {
                    ret.Add(model);
                }
            }
        }

        return ret;
    }


    private void LoadPartsOverrides(appearanceAppearanceDefinition appDef, List<LoadableModel> aModels)
    {
        if (appDef.PartsOverrides.Count == 0)
        {
            return;
        }

        foreach (var partOverride in appDef.PartsOverrides)
        {
            if (partOverride.ComponentsOverrides.Count == 0)
            {
                continue;
            }

            var hasComponentOverride = partOverride.PartResource.DepotPath.GetResolvedText() is string and not "";

            foreach (var compOverride in partOverride.ComponentsOverrides)
            {
                if (compOverride.ComponentName == CName.Empty)
                {
                    continue;
                }

                // Set ChunkMasks and appearance name from PartsOverride
                foreach (var loadableModel in aModels.Where((m) => m.ComponentName == compOverride.ComponentName).ToList())
                {
                    loadableModel.ChunkMask = compOverride.ChunkMask;
                    if (hasComponentOverride && compOverride.MeshAppearance != CName.Empty)
                    {
                        loadableModel.AppearanceName = compOverride.MeshAppearance;
                    }
                }
            }
        }
    }


    private List<LoadableModel> LoadMeshes(IList<RedBaseClass>? chunks, string? appearanceName = null)
    {
        if (chunks == null || chunks.Count == 0)
        {
            return [];
        }

        var appModels = new Dictionary<string, LoadableModel>();

        foreach (var component in chunks)
        {
            ProcessComponents(component, appModels, appearanceName);
        }

        var list = new List<LoadableModel>();

        foreach (var model in appModels.Values)
        {
            var matrix = new SeparateMatrix();
            //GetResolvedMatrix(model, ref matrix, appModels);
            model.Transform = new MatrixTransform3D(model.Matrix.ToMatrix3D());
            if (model.Name.Contains("shadow") || model.Name.Contains("AppearanceProxyMesh") || model.Name.Contains("cutout") ||
                model.Name == "")
            {
                model.IsEnabled = false;
            }

            list.Add(model);
        }

        if (list.Count != 0)
        {
            list.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.Ordinal));
        }


        return list;
    }

    private static Material CreateDefaultMaterial() => new("default")
    {
        Instance = new CMaterialInstance()
        {
            BaseMaterial = new CResourceReference<IMaterial>(@"engine\materials\metal_base.remt")
        }
    };


    /// <summary>
    /// Resolves the appearance index. Exact (case-insensitive) match, otherwise first in list.
    /// Kept separate to minimise merge conflicts with upstream appearance-selection changes.
    /// </summary>
    private int ResolveAppearanceIndex(List<string> apps, string? meshApp)
    {
        ArgumentNullException.ThrowIfNull(meshApp);

        if (meshApp == "default" || apps.Count == 0)
            return 0;

        var index = apps.FindIndex(a => a.Equals(meshApp, StringComparison.OrdinalIgnoreCase));
        return index != -1 ? index : 0;
    }

    private void ProcessComponents(RedBaseClass component, Dictionary<string, LoadableModel> appModels, string? appearanceName = null)
    {
        var scale = new Vector3() { X = 1, Y = 1, Z = 1 };
        var depotPath = ResourcePath.Empty;
        var componentName = "";
        var enabled = true;
        var meshApp = "default";
        var chunkMask = 18446744073709551615;
        var chunkList = new List<bool>(new bool[64]);

        if (component is entMeshComponent emc)
        {
            scale = emc.VisualScale;
            enabled = emc.IsEnabled;
        }

        //adds more clothing if present
        if (component is entSkinnedClothComponent cloth)
        {
            depotPath = cloth.GraphicsMesh.DepotPath;
            meshApp = cloth.MeshAppearance;
            chunkMask = cloth.ChunkMask;
            componentName = cloth.Name;
            enabled = cloth.IsEnabled;
        }
        else if (component is IRedMeshComponent mc)
        {
            depotPath = mc.Mesh.DepotPath;
            meshApp = mc.MeshAppearance;
            chunkMask = mc.ChunkMask;
            componentName = mc.Name;
        }

        var enabledChunks = new ObservableCollection<int>();

        for (var i = 0; i < 64; i++)
        {
            chunkList[i] = (chunkMask & 1UL << i) > 0;
            if (chunkList[i])
            {
                enabledChunks.Add(i);
            }
        }

        if (component is not entIPlacedComponent epc || depotPath == ResourcePath.Empty || depotPath.GetRedHash() == 0)
        {
            return;
        }

        var meshFile = GetProjectOrDepotFile(depotPath);

        if (meshFile is not { RootChunk: CMesh mesh })
        {
            Parent?.GetLoggerService().Warning($"Couldn't find mesh file: {depotPath} / {depotPath.GetRedHash()}");
            return;
        }

        var meshPath = depotPath.GetResolvedText() ?? string.Empty;

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
            var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), mesh, meshPath);
            if (!me.IsLocalInstance)
            {
                var extMaterial = new Material(name);
                FillFromExternal(extMaterial, mesh, me);
                materials[name] = extMaterial;
                continue;
            }

            CMaterialInstance? inst = null;

            if (localList != null && localList.Files.Count > me.Index)
            {
                inst = localList.Files[me.Index].RootChunk as CMaterialInstance;
            }
            else if (mesh.PreloadLocalMaterialInstances.Count > me.Index)
            {
                inst = mesh.PreloadLocalMaterialInstances[me.Index]?.GetValue() as CMaterialInstance;
            }

            //CMaterialInstance bm = null;
            //if (File.GetFileFromDepotPathOrCache(inst.BaseMaterial.DepotPath) is var file)
            //{
            //    bm = (CMaterialInstance)file.RootChunk;
            //}
            if (inst is null)
            {
                _loggerService.Error($"Failed to load material {name}! Check your mesh materials!");
                materials[name] = CreateDefaultMaterial();
                continue;
            }

            var material = new Material(name) { Instance = inst, };

            foreach (var pair in inst.Values)
            {
                var k = pair.Key.ToString().NotNull();
                material.Values[k] = pair.Value;
            }

            materials[name] = material;
        }

        if (materials.Count == 0)
        {
            materials.Add("default", CreateDefaultMaterial());
        }
        var apps = new List<string>();
        foreach (var handle in mesh.Appearances)
        {
            var app = handle.GetValue();
            if (app is meshMeshAppearance mmapp)
            {
                apps.Add(mmapp.Name.ToString().NotNull());
            }
        }

        if (apps.Count == 0)
        {
            apps.Add("default");
        }

        // Override with explicitly requested appearance if it exists
        if (appearanceName is not null && apps.Contains(appearanceName, StringComparer.OrdinalIgnoreCase))
        {
            meshApp = appearanceName;
        }

        var appIndex = ResolveAppearanceIndex(apps, meshApp);

        var appMaterials = new List<Material>();

        if (appIndex >= 0 && appIndex < mesh.Appearances.Count)
        {
            var handle = mesh.Appearances[appIndex];
            if (handle.GetValue() is meshMeshAppearance mmApp)
            {
                foreach (var m in mmApp.ChunkMaterials)
                {
                    var name = GetUniqueMaterialName(m.ToString().NotNull(), mesh, meshPath);
                    if (materials.TryGetValue(name, out var material))
                    {
                        appMaterials.Add(material);
                    }
                    else
                    {
                        appMaterials.Add(new Material(name));
                    }
                }
            }
        }

        if (appMaterials.Count == 0)
        {
            appMaterials.Add(CreateDefaultMaterial());
        }

        var modelName = (epc.Name.ToString() ?? "").Replace(".", "");
        var counter = 0;
        while (appModels.ContainsKey(modelName))
        {
            counter += 1;
            modelName = $"{(epc.Name.ToString() ?? "").Replace(".", "")}_DUPLICATE_{counter}";
        }

        var model = new LoadableModel(modelName)
        {
            ComponentName = (CName)(componentName ?? ""),
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

        appModels.Add(modelName, model);
    }

    public void GetResolvedMatrix(IBindable bindable, ref SeparateMatrix matrix, Dictionary<string, LoadableModel> models)
    {
        matrix.Append(bindable.Matrix);

        if (bindable.BindName == null)
        {
            return;
        }

        if (bindable is not LoadableModel)
        {
            if (Rigs.TryGetValue(bindable.BindName, out var value))
            {
                GetResolvedMatrix(value, ref matrix, models);
            }

            return;
        }

        if (models.TryGetValue(bindable.BindName, out var boundModel))
        {
            GetResolvedMatrix(boundModel, ref matrix, models);
        }
        else if (_slotSets.TryGetValue(bindable.BindName, out var value))
        {
            if (bindable.SlotName != null && value.Slots.TryGetValue(bindable.SlotName, out var slot))
            {
                var bindname = value.BindName;
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
            GetResolvedMatrix(value, ref matrix, models);
        }
    }



    public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;



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
        Camera?.AnimateTo(
                new System.Windows.Media.Media3D.Point3D(coord.X, coord.Z + s_distanceCameraUnits, -coord.Y + s_distanceCameraUnits),
                new Vector3D(0, -s_distanceCameraUnits, -s_distanceCameraUnits),
                new Vector3D(0, s_cameraUpDirectionFactor, -s_cameraUpDirectionFactor),
                s_cameraAnimationTime);
    }

    public void MouseDown3D(object sender, RoutedEventArgs e)
    {
        if (e is not MouseDown3DEventArgs args || args.HitTestResult == null)
        {
            return;
        }

        var mouseButtonEventArgs = (MouseButtonEventArgs)args.OriginalInputEventArgs;
        MouseDown3DSector(sender, args, mouseButtonEventArgs);
        MouseDown3DBlock(sender, args, mouseButtonEventArgs);

        CommonMouseDownEvents(args.HitTestResult.ModelHit, mouseButtonEventArgs);
    }

    public event EventHandler<string?>? OnSectorNodeSelected;


    private void CommonMouseDownEvents(object modelHit, MouseButtonEventArgs mouseButtonEventArgs)
    {
        if (mouseButtonEventArgs.LeftButton != MouseButtonState.Pressed || modelHit is not SubmeshComponent
            {
                Parent: MeshComponent { Parent: MeshComponent mesh }
            })
        {
            return;
        }

        List<string> loggerArgs = [];
        if (!string.IsNullOrEmpty(mesh.WorldNodeIndex))
        {
            loggerArgs.Add($"nodes[{mesh.WorldNodeIndex}] (Type: \"{mesh.WorldNodeType}\", nodeDataIndices: [{mesh.WorldNodeDataIndices}]");
        }

        if (mesh.CollisionActorId != null)
        {
            loggerArgs.Add($"Collision Actor: [{mesh.CollisionActorId}]");
        }

        if (modelHit is SubmeshComponent submesh)
        {
            if (submesh.CollisionActorId != null)
            {
                loggerArgs.Add($"Collision Actor: [{submesh.CollisionActorId}]");
            }

            if (CtrlKeyPressed)
            {
                //
                var v = submesh.BoundsSphereWithTransform.Center;
                // centre the view on the selected submesh2
                Camera?.LookAt(new System.Windows.Media.Media3D.Point3D(v.X, v.Y, v.Z), 100);
                loggerArgs.Add($"Mesh Bounds Centre: {v.X}, {v.Y}, {v.Z}");
            }

            if (ShiftKeyPressed)
            {
                if (Camera != null)
                {
                    // Zoom to the selected submesh
                    var v = submesh.BoundsWithTransform;

                    // Calculate the center of the bbox
                    SharpDX.Vector3 bboxCenter = new SharpDX.Vector3(v.Center.X, v.Center.Y, v.Center.Z);

                    // Calculate the extent of the bbox along each axis
                    SharpDX.Vector3 bboxExtent = v.Maximum - v.Minimum;

                    // Calculate the maximum extent of the bbox
                    float maxExtent = Math.Max(bboxExtent.X, Math.Max(bboxExtent.Y, bboxExtent.Z));

                    // Calculate the distance from the camera to ensure the entire bbox is visible
                    float distance = maxExtent / (float)Math.Tan(SharpDX.MathUtil.DegreesToRadians(45.0f) / 2); // Assuming 45 degree field of view

                    SharpDX.Vector3 CameraPos = new SharpDX.Vector3((float)Camera.Position.X, (float)Camera.Position.Y, (float)Camera.Position.Z);

                    // Calculate the new camera position and target
                    SharpDX.Vector3 newPosition = bboxCenter + SharpDX.Vector3.Normalize(CameraPos - bboxCenter) * distance;
                    SharpDX.Vector3 newDirection = SharpDX.Vector3.Normalize(bboxCenter - newPosition);


                    Camera?.AnimateTo(
                    new System.Windows.Media.Media3D.Point3D(newPosition.X, newPosition.Y, newPosition.Z),
                    new Vector3D(newDirection.X, newDirection.Y, newDirection.Z),
                    new Vector3D(0, 1, 0),
                    s_cameraAnimationTime);
                }
            }
        }

        if (loggerArgs.Count == 0)
        {
            loggerArgs.Add("Mesh Name :");
        }




        Parent?.GetLoggerService().Info(string.Join(", ", loggerArgs) + ") " + mesh.Text);

        OnSectorNodeSelected?.Invoke(this, mesh.WorldNodeIndex);
    }

    #endregion

    //TODO sort this

    #region meshhelper

    public Dictionary<string, PBRMaterial> Materials { get; set; } = new();

    public List<SubmeshComponent> MakeMesh(CMesh cMesh, ulong chunkMask = ulong.MaxValue, int appearanceIndex = 0, string? meshPath = null)
    {
        if (cMesh.RenderResourceBlob == null || cMesh.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
        {
            return [];
        }

        using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

        var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cMesh);

        var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, false, ulong.MaxValue);

        var list = new List<SubmeshComponent>();

        var index = 0;
        foreach (var mesh in expMeshes)
        {
            ArgumentNullException.ThrowIfNull(mesh.positions);
            ArgumentNullException.ThrowIfNull(mesh.indices);
            ArgumentNullException.ThrowIfNull(mesh.normals);
            ArgumentNullException.ThrowIfNull(mesh.texCoords0);
            ArgumentNullException.ThrowIfNull(mesh.tangents);
            ArgumentNullException.ThrowIfNull(mesh.materialNames);

            var positions = new Vector3Collection(mesh.positions.Length);
            for (var i = 0; i < mesh.positions.Length; i++)
            {
                positions.Add(mesh.positions[i].ToVector3());
            }

            var indices = new IntCollection(mesh.indices.Length);
            for (var i = 0; i < mesh.indices.Length; i++)
            {
                indices.Add((int)mesh.indices[i]);
            }

            Vector3Collection normals;
            if (mesh.normals.Length > 0)
            {
                normals = new Vector3Collection(mesh.normals.Length);
                for (var i = 0; i < mesh.normals.Length; i++)
                {
                    normals.Add(mesh.normals[i].ToVector3());
                }
            }
            else
            {
                normals = new Vector3Collection(mesh.positions.Length);
                for (var i = 0; i < mesh.positions.Length; i++)
                {
                    normals.Add(new SharpDX.Vector3(0f, 1f, 0f));
                }
                //ComputeNormals(positions, indices, out normals);
            }

            Vector2Collection textureCoordinates;
            if (mesh.texCoords0.Length > 0)
            {
                textureCoordinates = new Vector2Collection(mesh.texCoords0.Length);
                for (var i = 0; i < mesh.texCoords0.Length; i++)
                {
                    textureCoordinates.Add(mesh.texCoords0[i].ToVector2Flip());
                }
            }
            else
            {
                textureCoordinates = new Vector2Collection(mesh.positions.Length);

                // Mesh material preview in WolvenKit fix for vehicles/entity preview (e.g. Villefort Columbus)
                // Prevents crash on cMesh.Parameters[0] when the mesh has no Parameters (most non-terrain meshes)
                if (cMesh.Parameters.Count > 0 &&
                    cMesh.Parameters[0]?.Chunk is meshMeshParamTerrain mmpt)
                {
                    float xMax = 0, xMin = 0, yMin = 0, yMax = 0;
                    foreach (var chunk in mmpt.ChunkBoundingBoxes)
                    {
                        xMax = Math.Max(xMax, chunk.Max.X);
                        yMax = Math.Max(yMax, chunk.Max.Y);
                        xMin = Math.Min(xMin, chunk.Min.X);
                        yMin = Math.Min(yMin, chunk.Min.Y);
                    }
                    // Snap UV range to the next power-of-two tile (128..2048).
                    var ext = Math.Max(Math.Max(xMax, -xMin), Math.Max(yMax, -yMin));
                    var size = 128f;
                    while (size < ext && size < 2048f)
                        size *= 2f;
                    xMin = yMin = -size;
                    xMax = yMax = size;
                    for (var i = 0; i < mesh.positions.Length; i++)
                    {
                        textureCoordinates.Add(new SharpDX.Vector2(
                            (mesh.positions[i].X - xMin) / (xMax - xMin),
                            1f - (mesh.positions[i].Z - yMin) / (yMax - yMin)
                        ));
                    }
                }
            }

            Vector3Collection tangents;
            if (mesh.tangents.Length > 0)
            {
                tangents = new Vector3Collection(mesh.tangents.Length);
                for (var i = 0; i < mesh.tangents.Length; i++)
                {
                    tangents.Add(mesh.tangents[i].ToVector3());
                }
            }
            else
            {
                MeshBuilder.ComputeTangents(positions, normals, textureCoordinates, indices, out tangents, out var bitangents);
            }

            var sm = new SubmeshComponent()
            {
                Name = $"submesh_{index:D2}_LOD_{meshesinfo.LODLvl[index]:D2}",
                Text = $"submesh_{index:D2}_LOD_{meshesinfo.LODLvl[index]:D2}",
                LOD = meshesinfo.LODLvl[index],
                IsRendering = (chunkMask & 1UL << index) > 0 && meshesinfo.LODLvl[index] == (SelectedAppearance?.SelectedLOD ?? 1),
                EnabledWithMask = (chunkMask & 1UL << index) > 0,
                //CullMode = SharpDX.Direct3D11.CullMode.Front,
                Geometry = new HelixToolkit.SharpDX.Core.MeshGeometry3D()
                {
                    Positions = positions,
                    Indices = indices,
                    Normals = normals,
                    TextureCoordinates = textureCoordinates,
                    Tangents = tangents
                },
                DepthBias = -index * 2
                //IsTransparent = true
            };

            // Mesh material preview in WolvenKit - safe material selection
            var chosenMatName = "default";
            if (appearanceIndex >= 0 &&
                appearanceIndex < cMesh.Appearances.Count &&
                cMesh.Appearances[appearanceIndex].GetValue() is meshMeshAppearance meshApp &&
                index < meshApp.ChunkMaterials.Count)
            {
                chosenMatName = meshApp.ChunkMaterials[index].ToString().NotNull();
            }
            else if (mesh.materialNames is { Length: > 0 } matNames)
            {
                var safeIndex = appearanceIndex >= 0 && appearanceIndex < matNames.Length ? appearanceIndex : 0;
                chosenMatName = matNames[safeIndex];
            }

            sm.MaterialName = GetUniqueMaterialName(chosenMatName, cMesh, meshPath);
            sm.Material = SetupPBRMaterial(sm.MaterialName);

            // Skip invisible decals (logos_invisible etc.) — empty mesh_decal with no params.
            if (sm.MaterialName.Contains("invisible", StringComparison.OrdinalIgnoreCase))
            {
                sm.IsRendering = false;
            }

            // Try to get base path for better classification
            string? basePath = null;
            if (SelectedAppearance?.RawMaterials.TryGetValue(sm.MaterialName, out var mat) == true &&
                mat.Instance is CMaterialInstance inst &&
                inst.BaseMaterial.DepotPath != ResourcePath.Empty)
            {
                basePath = inst.BaseMaterial.DepotPath.GetResolvedText();
            }

            var kind = ClassifyMaterial(sm.MaterialName, basePath);

            if (Has(kind, MaterialKind.Makeup) || Has(kind, MaterialKind.Eyebrow))
            {
                sm.DepthBias -= 20;
                sm.IsTransparent = true;
            }
            else if (Has(kind, MaterialKind.Eye) || Has(kind, MaterialKind.Glass))
            {
                sm.IsTransparent = true;
                sm.DepthBias -= 10;
            }
            else if (Has(kind, MaterialKind.Decal))
            {
                // Render just after the base mesh. Negative bias pulls toward
                // camera; keep it tiny so the decal doesn't leap in front of
                // other entity components and leave holes.
                sm.DepthBias = -1;
                sm.IsTransparent = true;
            }
            else if (Has(kind, MaterialKind.Hair))
            {
                // Transparent so Viewport OIT can sort cards; hard alpha clip is baked into the texture.
                sm.IsTransparent = true;
                sm.DepthBias = 0;
                // Double-sided: hair cards must render from both sides (matches typical hair / EEVEE)
                sm.CullMode = SharpDX.Direct3D11.CullMode.None;
            }

            // Cutout / masked materials (chains, fences).
            // EnableMask + AlphaThreshold = alpha test in game, not blend.
            // Setting IsTransparent here causes bilinear filtering to create
            // a soft halo around edges. Leave opaque for sharp cutout look.
            if (!sm.IsTransparent &&
                SelectedAppearance?.RawMaterials.TryGetValue(sm.MaterialName, out var alphaMat) == true &&
                alphaMat?.Values != null)
            {
                bool isCutout = false;

                if (alphaMat.Instance is CMaterialInstance alphaInst && alphaInst.EnableMask)
                    isCutout = true;

                if (!isCutout && alphaMat.Values.TryGetValue("AlphaThreshold", out var atObj))
                {
                    float at = ReadFloat(atObj);
                    isCutout = at > 0.001f && at < 0.99f;
                }

                // Cutout / chain: pull toward camera so the alpha edge
                // doesn't blend into the body underneath.
                if (isCutout)
                {
                    sm.IsTransparent = true;
                    sm.DepthBias = -30;
                }
                else if (alphaMat.Values.ContainsKey("MaskTexture"))
                {
                    sm.IsTransparent = true;
                }
                else
                {
                    var (png, _, _) = GetMaterialFilePathsFromCache(sm.MaterialName);
                    if (File.Exists(png) && PngHasAlphaVariation(png))
                        sm.IsTransparent = true;
                }
            }
            list.Add(sm);
            index++;
        }

        return list;

    }

    /// <summary>
    /// Quick check: does the PNG contain meaningful alpha variation
    /// (not all opaque, not all transparent)? Samples a grid to stay fast.
    /// </summary>
    private static bool PngHasAlphaVariation(string path)
    {
        try
        {
            using var bmp = new Bitmap(path);
            if (bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppArgb &&
                bmp.PixelFormat != System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
                return false;

            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var data = bmp.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            try
            {
                unsafe
                {
                    byte* ptr = (byte*)data.Scan0;
                    int stride = data.Stride;
                    int stepX = Math.Max(1, bmp.Width / 16);
                    int stepY = Math.Max(1, bmp.Height / 16);
                    int minA = 255, maxA = 0;

                    for (int y = 0; y < bmp.Height; y += stepY)
                    {
                        for (int x = 0; x < bmp.Width; x += stepX)
                        {
                            int a = ptr[y * stride + x * 4 + 3];
                            if (a < minA)
                                minA = a;
                            if (a > maxA)
                                maxA = a;
                            if (maxA - minA > 16)
                                return true;
                        }
                    }

                    return maxA - minA > 16;
                }
            }
            finally { bmp.UnlockBits(data); }
        }
        catch
        {
            return false;
        }
    }

    public static void ComputeNormals(Vector3Collection positions, IntCollection triangleIndices, out Vector3Collection normals)
    {
        normals = new Vector3Collection(positions.Count);
        for (var i = 0; i < positions.Count; i++)
        {
            normals.Add(new SharpDX.Vector3(0f, 0f, 0f));
        }

        for (var j = 0; j < triangleIndices.Count; j += 3)
        {
            var index = triangleIndices[j + 2];
            var index2 = triangleIndices[j + 1];
            var index3 = triangleIndices[j];
            var right = positions[index];
            var left = positions[index2];
            var left2 = positions[index3];
            var first = left - right;
            var second = left2 - right;
            var value = CrossProduct(ref first, ref second);
            first.Normalize();
            second.Normalize();
            var scale = (float)Math.Acos(DotProduct(ref first, ref second));
            value.Normalize();
            normals[index] += scale * value;
            normals[index2] += scale * value;
            normals[index3] += scale * value;
        }

        for (var k = 0; k < normals.Count; k++)
        {
            var value2 = normals[k];
            value2.Normalize();
            normals[k] = value2;
        }
    }

    public static SharpDX.Vector3 CrossProduct(ref SharpDX.Vector3 first, ref SharpDX.Vector3 second) => SharpDX.Vector3.Cross(first, second);

    public static float DotProduct(ref SharpDX.Vector3 first, ref SharpDX.Vector3 second) => first.X * second.X + first.Y * second.Y + first.Z * second.Z;


    public PBRMaterial SetupPBRMaterial(string name, bool force = false)
    {

        if (Materials.ContainsKey(name) && !force)
        {
            return Materials[name];
        }

        PBRMaterial material;
        if (Materials.TryGetValue(name, out var cachedMaterial))
        {
            material = cachedMaterial;
            // Force-refresh: drop maps loaded before the bake finished
            if (force)
            {
                material.AlbedoMap = null;
                material.NormalMap = null;
                material.RoughnessMetallicMap = null;
                material.EmissiveMap = null;
                material.RenderAlbedoMap = false;
                material.RenderNormalMap = false;
                material.RenderRoughnessMetallicMap = false;
                material.RenderEmissiveMap = false;
            }
        }
        else
        {
            material = new PBRMaterial
            {
                EnableAutoTangent = true,
                RenderShadowMap = true,
                RenderEnvironmentMap = true
            };
            Materials[name] = material;
        }

        material.AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);

        var (filename_bd, filename_bn, filename_rm) = GetMaterialFilePathsFromCache(name);

        // Prefer base material path (like Blender addon registry) when available
        string? basePath = null;
        if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var mat) == true &&
            mat.Instance is CMaterialInstance inst &&
            inst.BaseMaterial.DepotPath != ResourcePath.Empty)
        {
            basePath = inst.BaseMaterial.DepotPath.GetResolvedText();
        }

        var kind = ClassifyMaterial(name, basePath);

        bool isSkin = Has(kind, MaterialKind.Skin);
        bool isHair = Has(kind, MaterialKind.Hair);
        bool isEye = Has(kind, MaterialKind.Eye);
        bool isOverlay = Has(kind, MaterialKind.Makeup) || Has(kind, MaterialKind.Eyebrow);
        bool isNail = Has(kind, MaterialKind.Nail);
        bool isDecal = Has(kind, MaterialKind.Decal);

        if (isDecal)
        {
            // Wet character decal: glossy droplets, transparent
            bool isWetDecal = basePath?.Contains("mesh_decal_wet_character") == true;
            if (isWetDecal)
            {
                material.RoughnessFactor = 0.15f;
                material.MetallicFactor = 0f;
                material.RenderEnvironmentMap = true;
                if (File.Exists(filename_bd))
                {
                    material.AlbedoMap = GetOrCreateTexture(filename_bd);
                    material.RenderAlbedoMap = true;
                    material.AlbedoColor = new SharpDX.Color4(0.9f, 0.95f, 1f, 0.6f);
                }
                if (File.Exists(filename_bn))
                {
                    material.NormalMap = GetOrCreateTexture(filename_bn);
                    material.RenderNormalMap = true;
                }
                return material;
            }

            // Emissive on a decal only when EV > 0 or the name explicitly says emissive.
            // Presence of an Emissive key alone is not enough (common on metal_base).
            bool decalHasEmissive = false;
            if (name.Contains("emissive", StringComparison.OrdinalIgnoreCase))
            {
                decalHasEmissive = true;
            }
            else if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var dMat) == true && dMat?.Values != null)
            {
                if (dMat.Values.TryGetValue("EmissiveEV", out var evObj) && ReadFloat(evObj) > 0.01f)
                    decalHasEmissive = true;
            }

            if (!decalHasEmissive)
            {
                // placeholder (0/1) * scale + bias
                var (rough, metal) = GetDecalRoughMetal(name);
                material.RoughnessFactor = rough;
                material.MetallicFactor = metal;
                material.RenderEnvironmentMap = false;

                if (File.Exists(filename_bd))
                {
                    material.AlbedoMap = GetOrCreateTexture(filename_bd);
                    material.RenderAlbedoMap = true;
                    material.AlbedoColor = new SharpDX.Color4(0.8f, 0.8f, 0.8f, 1f);
                }
                if (File.Exists(filename_bn))
                {
                    material.NormalMap = GetOrCreateTexture(filename_bn);
                    material.RenderNormalMap = true;
                }

                // Real roughness/metalness maps (cyberware etc.) override placeholder scale/bias
                if (File.Exists(filename_rm))
                {
                    material.RoughnessMetallicMap = GetOrCreateTexture(filename_rm);
                    material.RenderRoughnessMetallicMap = true;
                    material.RoughnessFactor = 1f;
                    material.MetallicFactor = 1f;
                }

                return material;
            }
        }

        if (isSkin)
        {
            material.MetallicFactor = 0f;
            material.RenderRoughnessMetallicMap = true;
            material.RenderEnvironmentMap = false;
            material.RoughnessFactor = 0.8f;

            if (File.Exists(filename_bd))
            {
                material.AlbedoMap = GetOrCreateTexture(filename_bd);
                material.RenderAlbedoMap = true;
            }

            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }
            if (File.Exists(filename_rm))
                material.RoughnessMetallicMap = GetOrCreateTexture(filename_rm);
        }

        if (isHair && File.Exists(filename_bd))
        {
            material.AlbedoMap = GetOrCreateTexture(filename_bd);
            material.MetallicFactor = 0f;
            material.RoughnessFactor = 0.75f;
            material.RenderEnvironmentMap = false;
            // User-tuned darkening for hair (in addition to baked ×0.6)
            material.AlbedoColor = new SharpDX.Color4(0.55f, 0.55f, 0.55f, 1f);
            material.EnableFlatShading = false;
            material.RenderAlbedoMap = true;
            // Hair/cap use texture alpha; geometry IsTransparent is set separately
            return material;
        }

        if (isNail && File.Exists(filename_bd))
        {
            material.AlbedoMap = GetOrCreateTexture(filename_bd);
            material.RenderAlbedoMap = true;
            material.MetallicFactor = 0.75f;
            material.RoughnessFactor = 0.55f;

            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }
            if (File.Exists(filename_rm))
            {
                material.RoughnessMetallicMap = GetOrCreateTexture(filename_rm);
                material.RenderRoughnessMetallicMap = true;
            }
            return material;
        }

        if (isEye)
        {
            material.RenderEnvironmentMap = false;
            material.MetallicFactor = 0f;
            // Lashes should be matte; eyeball / wetness stay glossy
            bool isLash = name.Contains("lash", StringComparison.OrdinalIgnoreCase);
            material.RoughnessFactor = isLash ? 0.85f : 0.3f;

            if (File.Exists(filename_bd))
            {
                material.AlbedoMap = GetOrCreateTexture(filename_bd);
                material.RenderAlbedoMap = true;
            }
            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }
            if (File.Exists(filename_rm))
            {
                material.RoughnessMetallicMap = GetOrCreateTexture(filename_rm);
                material.RenderRoughnessMetallicMap = true;
            }
            return material;
        }

        if (isOverlay && File.Exists(filename_bd))
        {
            material.AlbedoMap = GetOrCreateTexture(filename_bd);
            material.AlbedoColor = new SharpDX.Color4(0.55f, 0.55f, 0.55f, 1f);
            material.RenderAlbedoMap = true;

            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }

            return material;
        }

        // glass
        if (Has(kind, MaterialKind.Glass))
        {
            material.AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 0.1f);
            material.RenderAlbedoMap = false;
        }

        // Emissive: explicit markers or EmissiveEV > 0.
        // Do not treat mere presence of an Emissive key as emissive
        // (common on metal_base; EV <= 0 means off).
        bool isEmissive =
            ContainsAny(basePath ?? "",
                "television_ad", "billboard", "neon_tubes", "neon_parallax",
                "parallaxscreen", "simple_emissive") ||
            ContainsAny(name,
                "billboard", "neon", "television", "emissive");
        if (!isEmissive && SelectedAppearance?.RawMaterials.TryGetValue(name, out var emMat) == true &&
            emMat?.Values != null)
        {
            if (emMat.Values.TryGetValue("EmissiveEV", out var evCheck) && ReadFloat(evCheck) > 0.01f)
                isEmissive = true;
            else if (emMat.Values.ContainsKey("AdTexture") &&
                     (name.Contains("billboard", StringComparison.OrdinalIgnoreCase) ||
                      name.Contains("screen", StringComparison.OrdinalIgnoreCase)))
                isEmissive = true;
        }

        if (isEmissive)
        {
            material.RenderEnvironmentMap = false;

            // Scalar metalness / roughness from the instance (billboards store them as floats)
            float metal = 0.1f, rough = 0.2f;
            if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var emVals) == true && emVals?.Values != null)
            {
                if (emVals.Values.TryGetValue("Metalness", out var mObj))
                {
                    if (mObj is CFloat mcf)
                        metal = (float)mcf;
                    else if (mObj is float mf)
                        metal = mf;
                }
                if (emVals.Values.TryGetValue("Roughness", out var rObj))
                {
                    if (rObj is CFloat rcf)
                        rough = (float)rcf;
                    else if (rObj is float rf)
                        rough = rf;
                }
            }
            material.MetallicFactor = metal;
            material.RoughnessFactor = rough;

            if (File.Exists(filename_bd))
            {
                var tex = GetOrCreateTexture(filename_bd);
                material.AlbedoMap = tex;
                material.RenderAlbedoMap = true;
                material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 1f);
            }

            // EmissiveEV → linear intensity (addon uses 2^EV).
            // EV <= 0 means the screen/panel is off: no glow.
            float ev = 0f;
            if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var evMat) == true &&
                evMat?.Values?.TryGetValue("EmissiveEV", out var evObj) == true)
            {
                ev = ReadFloat(evObj);
            }

            // Optional EmissiveColor (Color or Vector4)
            float cr = 1f, cg = 1f, cb = 1f;
            if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var colMat) == true &&
                colMat?.Values?.TryGetValue("EmissiveColor", out var colObj) == true)
            {
                if (colObj is Vector4 evCol)
                {
                    cr = evCol.X;
                    cg = evCol.Y;
                    cb = evCol.Z;
                }
                else if (colObj is CColor ccol)
                {
                    cr = ccol.Red / 255f;
                    cg = ccol.Green / 255f;
                    cb = ccol.Blue / 255f;
                }
            }

            if (ev > 0.01f)
            {
                float intensity = Math.Clamp(MathF.Pow(2f, ev) * 0.04f, 0.2f, 4f);
                material.EmissiveColor = new SharpDX.Color4(intensity * cr, intensity * cg, intensity * cb, 1f);

                // Emissive map is baked in LoadMaterial; here we only consume it.
                var emissivePng = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_emissive.png");

                bool scaleBlack = false;
                if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var scaleMat) == true &&
                    scaleMat?.Values?.TryGetValue("BaseColorScale", out var scObj) == true &&
                    scObj is Vector4 sc && sc.X < 0.05f && sc.Y < 0.05f && sc.Z < 0.05f)
                    scaleBlack = true;

                if (File.Exists(emissivePng))
                {
                    material.EmissiveMap = GetOrCreateTexture(emissivePng);
                    material.RenderEmissiveMap = true;
                }

                if (scaleBlack)
                {
                    material.AlbedoColor = new SharpDX.Color4(0.02f, 0.02f, 0.02f, 1f);
                    material.RenderAlbedoMap = false;
                }
            }
            else
            {
                // Off: no emission and near-black screen (EmissiveColor value ≈ 0, like Blender Value near 0)
                material.EmissiveColor = new SharpDX.Color4(0f, 0f, 0f, 1f);
                material.RenderEmissiveMap = false;
                material.AlbedoColor = new SharpDX.Color4(0.02f, 0.02f, 0.02f, 1f);
                material.RenderAlbedoMap = false;
            }

            return material;
        }

        if (!isSkin && !isHair && !isNail && !isOverlay && !isEye)
        {
            material.RenderEnvironmentMap = false;

            // Albedo (baked PNG only)
            if (File.Exists(filename_bd))
            {
                material.AlbedoMap = GetOrCreateTexture(filename_bd);
                material.RenderAlbedoMap = true;

                // Apply BaseColorScale if present (e.g. nails use scale=0 for black)
                var albedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
                if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var matScale) == true &&
                    matScale?.Values?.TryGetValue("BaseColorScale", out var scaleObj) == true)
                {
                    if (scaleObj is Vector4 v4)
                    {
                        albedoColor = new SharpDX.Color4(v4.X, v4.Y, v4.Z, v4.W);
                    }
                }
                material.AlbedoColor = albedoColor;
            }
            else
            {
                material.AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
            }

            // metal_base.remt: use scale/bias like decals (placeholders)
            bool isMetalBase = name.Contains("chain", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("metal_base", StringComparison.OrdinalIgnoreCase);
            if (isMetalBase)
            {
                var (rough, metal) = GetDecalRoughMetal(name);
                material.RoughnessFactor = rough;
                material.MetallicFactor = metal;
            }
            else if (File.Exists(filename_rm))
            {
                material.RoughnessMetallicMap = GetOrCreateTexture(filename_rm);
                material.RenderRoughnessMetallicMap = true;
                // 1f so shader uses texture values at 100%
                material.RoughnessFactor = 1f;
                material.MetallicFactor = 0.8f;
            }

            // Normal (baked PNG only)
            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }
        }

        return material;
    }

    private async Task TryBakeEmissiveMap(string name, string outPath, Dictionary<string, object> values)
    {
        try
        {
            ResourcePath emPath = ResourcePath.Empty;
            if (values.TryGetValue("Emissive", out var emObj) && emObj is CResourceReference<ITexture> er)
                emPath = er.DepotPath;
            else if (values.TryGetValue("AdTexture", out var adObj) && adObj is CResourceReference<ITexture> ar)
                emPath = ar.DepotPath;

            if (emPath == ResourcePath.Empty)
                return;

            using var bmp = await LoadTextureAsBitmap(emPath);
            if (bmp == null)
                return;

            float cr = 1f, cg = 1f, cb = 1f;
            if (values.TryGetValue("EmissiveColor", out var colObj))
            {
                if (colObj is CColor ccol)
                {
                    cr = ccol.Red / 255f;
                    cg = ccol.Green / 255f;
                    cb = ccol.Blue / 255f;
                }
                else if (colObj is Vector4 v4)
                {
                    cr = v4.X;
                    cg = v4.Y;
                    cb = v4.Z;
                }
            }
            TintBitmap(bmp, cr, cg, cb);

            using var clone = new Bitmap(bmp.Width, bmp.Height);
            using (var g = Graphics.FromImage(clone))
                g.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);

            Directory.CreateDirectory(Path.GetDirectoryName(outPath)!);
            SavePngAtomic(clone, outPath);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Emissive] bake failed for {name}: {ex.Message}");
        }
    }

    private static void SavePngAtomic(Bitmap bmp, string path)
    {
        var tmp = path + ".tmp";
        try
        {
            bmp.Save(tmp, ImageFormat.Png);
            File.Move(tmp, path, overwrite: true);
        }
        catch
        {
            try
            { File.Delete(tmp); }
            catch { /* ignore */ }
            throw;
        }
    }

    private static void TintBitmap(Bitmap bmp, float r, float g, float b)
    {
        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                int stride = data.Stride;
                for (int y = 0; y < bmp.Height; y++)
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        int off = y * stride + x * 4;
                        ptr[off + 0] = (byte)(ptr[off + 0] * b);
                        ptr[off + 1] = (byte)(ptr[off + 1] * g);
                        ptr[off + 2] = (byte)(ptr[off + 2] * r);
                    }
            }
        }
        finally { bmp.UnlockBits(data); }
    }

    /// <summary>
    /// For mesh decals (stitches, zipper, etc.): multiply MaskTexture.r into the bitmap alpha.
    /// Matches Blender addon (DiffuseTexture.a × MaskTexture.r). Best-effort; ignores failures.
    /// </summary>
    private async Task ApplyMaskCoverageToAlpha(Bitmap bmp, Dictionary<string, object> dictionary)
    {
        if (!dictionary.TryGetValue("MaskTexture", out var maskObj) ||
            maskObj is not CResourceReference<ITexture> maskRef ||
            maskRef.DepotPath == ResourcePath.Empty)
            return;

        var maskXbm = GetProjectOrDepotFile(maskRef.DepotPath);
        if (maskXbm?.RootChunk is not ITexture maskIt)
            return;

        try
        {
            using var maskStream = new MemoryStream();
            ModTools.ConvertRedClassToDdsStream(maskIt, maskStream, out _, out var maskFmt, true);
            maskStream.Position = 0;

            var maskSrc = await ImageDecoder.RenderToBitmapImageDds(maskStream, maskFmt);
            if (maskSrc == null)
                return;

            if (maskSrc.CanFreeze && !maskSrc.IsFrozen)
                maskSrc.Freeze();

            using var maskBmp = BitmapSourceToBitmap(maskSrc);
            MultiplyAlphaByMaskRed(bmp, maskBmp);
        }
        catch
        {
            // best-effort
        }
    }

    private static void MultiplyAlphaByMaskRed(Bitmap dest, Bitmap mask)
    {
        var destRect = new Rectangle(0, 0, dest.Width, dest.Height);
        var maskRect = new Rectangle(0, 0, mask.Width, mask.Height);
        var destData = dest.LockBits(destRect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var maskData = mask.LockBits(maskRect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* destPtr = (byte*)destData.Scan0;
                byte* maskPtr = (byte*)maskData.Scan0;
                int destStride = destData.Stride;
                int maskStride = maskData.Stride;
                int maskW = mask.Width;
                int maskH = mask.Height;

                for (int y = 0; y < dest.Height; y++)
                {
                    int maskY = y * maskH / dest.Height;
                    for (int x = 0; x < dest.Width; x++)
                    {
                        int maskX = x * maskW / dest.Width;
                        int destOff = y * destStride + x * 4;
                        int maskOff = maskY * maskStride + maskX * 4;

                        // BGRA: red channel is at +2
                        float coverage = maskPtr[maskOff + 2] / 255f;
                        destPtr[destOff + 3] = (byte)(destPtr[destOff + 3] * coverage);
                    }
                }
            }
        }
        finally
        {
            dest.UnlockBits(destData);
            mask.UnlockBits(maskData);
        }
    }

    private static bool _logged4k;

    /// <summary>
    /// Resolve a depot path via IArchiveManager.GetCR2WFile, which prefers the
    /// open project over mods and the base archive (includeProject = true).
    /// Results are cached for the duration of a material load pass.
    /// </summary>
    private CR2WFile? GetProjectOrDepotFile(ResourcePath depotPath)
    {
        if (_fileCache.TryGetValue(depotPath, out var cached))
            return cached;

        var am = ResolveArchiveManager();
        CR2WFile? result = null;

        if (am != null)
        {
            // includeProject: true → project file if present, otherwise mods/archive
            result = am.GetCR2WFile(depotPath, includeMods: true, includeProject: true);
        }

        result ??= Parent?.GetFileFromDepotPathOrCache(depotPath) as CR2WFile;

        _fileCache[depotPath] = result;
        return result;
    }

    private TextureModel GetOrCreateTexture(string path)
    {
        // Key includes write time so a rebaked PNG is not served stale.
        long ticks = 0;
        try
        { ticks = File.GetLastWriteTimeUtc(path).Ticks; }
        catch { /* missing */ }
        var key = path + "|" + ticks;
        return _textureCache.GetOrAdd(key, _ => TextureModel.Create(path));
    }

    private void ClearFileCache()
    {
        _fileCache.Clear();
        _textureCache.Clear();
    }

    private IArchiveManager? ResolveArchiveManager()
    {
        if (_archiveManager != null)
            return _archiveManager;

        // Lazy: try to pull it from the game controller (some WK builds expose it)
        try
        {
            var ctrl = _gameController?.GetController();
            if (ctrl != null)
            {
                var prop = ctrl.GetType().GetProperty("ArchiveManager")
                           ?? ctrl.GetType().GetProperty("GameArchiveManager");
                if (prop?.GetValue(ctrl) is IArchiveManager found)
                {
                    return found;
                }
            }
        }
        catch { /* ignore */ }

        return null;
    }

    /// <summary>
    /// Generic content hash of any loaded CR2W. Used so any project-file edit
    /// (mlsetup, hair profile, gradient, template, material instance) invalidates
    /// the bake without per-type checks.
    /// Walks properties up to a limited depth so nested collections and structs
    /// contribute to the hash.
    /// </summary>
    private static string HashCr2w(CR2WFile? file)
    {
        if (file?.RootChunk == null)
            return "";
        try
        {
            using var ms = new MemoryStream();
            using var writer = new BinaryWriter(ms);
            WriteValue(writer, file.RootChunk, 0);
            using var sha = System.Security.Cryptography.SHA256.Create();
            return Convert.ToHexString(sha.ComputeHash(ms.ToArray()));
        }
        catch
        {
            return "";
        }

        static void WriteValue(BinaryWriter w, object? val, int depth)
        {
            if (val == null || depth > 4)
            {
                w.Write(0);
                return;
            }

            var t = val.GetType();
            w.Write(t.Name);

            // Collections
            if (val is System.Collections.IEnumerable enumerable && val is not string)
            {
                var count = 0;
                foreach (var item in enumerable)
                {
                    if (count++ > 64)
                        break; // safety
                    WriteValue(w, item, depth + 1);
                }
                w.Write(count);
                return;
            }

            // Simple types
            if (val is IConvertible || val is ResourcePath || val is CName)
            {
                w.Write(val.ToString() ?? "");
                return;
            }

            // Walk public properties
            foreach (var prop in t.GetProperties())
            {
                if (!prop.CanRead || prop.GetIndexParameters().Length > 0)
                    continue;
                try
                {
                    var pval = prop.GetValue(val);
                    w.Write(prop.Name);
                    WriteValue(w, pval, depth + 1);
                }
                catch { /* skip */ }
            }
        }
    }

    private string ComputeGenericDepHash(Dictionary<string, object> values)
    {
        var sb = new System.Text.StringBuilder();
        foreach (var (key, obj) in values)
        {
            ResourcePath path = ResourcePath.Empty;
            if (obj is IRedRef r)
                path = r.DepotPath;
            if (path == ResourcePath.Empty)
            {
                sb.Append(key).Append('=').Append(obj?.ToString() ?? "").Append(';');
                continue;
            }

            var text = path.GetResolvedText() ?? "";
            sb.Append(key).Append('=').Append(text).Append(';');

            // Hash the actual loaded file so any project edit is detected
            try
            {
                var file = GetProjectOrDepotFile(path);
                sb.Append(HashCr2w(file)).Append(';');
            }
            catch { /* ignore */ }
        }

        using var sha = System.Security.Cryptography.SHA256.Create();
        var bytes = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
        return Convert.ToHexString(sha.ComputeHash(bytes));
    }

    /// <summary>
    /// Hash of the mlsetup layer data that affects the bake (color scale, opacity,
    /// offsets, material refs). Used to detect project edits vs the cached bake.
    /// </summary>
    private static string ComputeMlsetupHash(Multilayer_Setup mls)
    {
        var sb = new System.Text.StringBuilder();
        if (mls.Layers != null)
        {
            foreach (var layer in mls.Layers)
            {
                sb.Append(layer.Material.DepotPath.GetResolvedText()).Append('|');
                sb.Append(layer.Opacity).Append('|');
                sb.Append(layer.OffsetU).Append('|').Append(layer.OffsetV).Append('|');
                sb.Append(layer.MatTile).Append('|');
                sb.Append(layer.MbTile).Append('|');
                sb.Append(layer.MicroblendOffsetU).Append('|').Append(layer.MicroblendOffsetV).Append('|');
                sb.Append(layer.MicroblendContrast).Append('|');
                sb.Append(layer.MicroblendNormalStrength).Append('|');
                sb.Append(layer.ColorScale.ToString()).Append('|');
                sb.Append(layer.RoughLevelsIn.ToString()).Append('|');
                sb.Append(layer.MetalLevelsIn.ToString()).Append('|');
            }
        }
        using var sha = System.Security.Cryptography.SHA256.Create();
        var bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(sb.ToString()));
        return Convert.ToHexString(bytes);
    }

    /// <summary>
    /// Gets PNG file paths from the material cache directory
    /// (_d.png / _n.png / _rm.png).
    /// </summary>
    /// <param name="name">name of material</param>
    /// <returns></returns>
    private (string filename_bd, string filename_bn, string filename_rm) GetMaterialFilePathsFromCache(
        string name, bool deleteAll = false)
    {
        var filename_bd = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_d.png");
        CheckFile(filename_bd);
        var filename_bn = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_n.png");
        CheckFile(filename_bn);
        var filename_rm = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_rm.png");
        CheckFile(filename_rm);

        return (filename_bd, filename_bn, filename_rm);

        void CheckFile(string filePath)
        {
            var fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists && (deleteAll || fileInfo.Length == 0))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch
                {
                    _loggerService.Error($"Failed to delete {filePath}. To clear the material cache, try deleting it by hand.");
                }
            }
        }
    }

    public List<Material> GetMaterialsForAppearance(CMesh mesh, CName appearance)
    {
        var materials = GetMaterialsFromMesh(mesh);

        var appMaterials = new List<Material>();

        var amaterials = mesh.Appearances.FirstOrDefault(x => x is not null && x.Chunk.NotNull().Name == appearance, mesh.Appearances[0].NotNull()).NotNull().Chunk.NotNull().ChunkMaterials;
        foreach (var materialName in amaterials)
        {
            var name = GetUniqueMaterialName(materialName.ToString().NotNull(), mesh);
            appMaterials.Add(materials.ContainsKey(name) ? materials[name] : new Material(name));
        }

        return appMaterials;
    }

    private string GetUniqueMaterialName(string name, CMesh mesh, string? meshPathOverride = null)
    {
        _ = mesh;

        var identity = !string.IsNullOrEmpty(meshPathOverride)
            ? meshPathOverride
            : Parent?.FilePath ?? Parent?.ContentId ?? string.Empty;

        var meshFile = Path.GetFileNameWithoutExtension(identity);
        if (string.IsNullOrEmpty(meshFile) ||
            meshFile.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
            return string.Concat(name.Select(c =>
                Path.GetInvalidFileNameChars().Contains(c) ? '_' : c));
        }

        var norm = identity.Replace('/', '\\').ToLowerInvariant();
        var hash = BitConverter.ToUInt32(
            System.Security.Cryptography.SHA256.HashData(
                System.Text.Encoding.UTF8.GetBytes(norm)), 0);

        // Strip chars illegal in Windows filenames (colon from splineModeling: etc.)
        var safeName = string.Concat(name.Select(c =>
            Path.GetInvalidFileNameChars().Contains(c) ? '_' : c));
        return $"{meshFile}_{hash:X8}__{safeName}";
    }

    private void FillFromExternal(Material material, CMesh mesh, CMeshMaterialEntry me)
    {
        // Check externalMaterials
        if (me.Index >= 0 && me.Index < mesh.ExternalMaterials.Count)
        {
            var extRef = mesh.ExternalMaterials[me.Index];
            var extFile = GetProjectOrDepotFile(extRef.DepotPath);
            if (extFile?.RootChunk is CMaterialInstance extInst)
            {
                material.Instance = extInst;
                foreach (var pair in extInst.Values)
                {
                    var k = pair.Key.ToString().NotNull();
                    material.Values[k] = pair.Value;
                }
                return;
            }
        }

        // Check preloadExternalMaterials
        if (mesh.PreloadExternalMaterials != null &&
            me.Index >= 0 && me.Index < mesh.PreloadExternalMaterials.Count)
        {
            var preRef = mesh.PreloadExternalMaterials[me.Index];
            var preFile = GetProjectOrDepotFile(preRef.DepotPath);
            if (preFile?.RootChunk is CMaterialInstance preInst)
            {
                material.Instance = preInst;
                foreach (var pair in preInst.Values)
                {
                    var k = pair.Key.ToString().NotNull();
                    material.Values[k] = pair.Value;
                }
                return;
            }
        }

        Parent?.GetLoggerService()?.Warning(
            $"External material '{material.Name}' index {me.Index} not found");
    }

    private Dictionary<string, Material> GetMaterialsFromMesh(CMesh mesh)
    {
        var materials = new Dictionary<string, Material>();

        var localList = mesh.LocalMaterialBuffer.RawData?.Buffer.Data as CR2WList ?? null;


        foreach (var me in mesh.MaterialEntries)
        {
            var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), mesh);
            if (!me.IsLocalInstance)
            {
                if (!materials.ContainsKey(name))
                {
                    var extMaterial = new Material(name);
                    FillFromExternal(extMaterial, mesh, me);
                    materials.Add(name, extMaterial);
                }
                continue;
            }

            var inst = localList != null && localList.Files.Count > me.Index
                ? localList.Files[me.Index].RootChunk as CMaterialInstance
                : mesh.PreloadLocalMaterialInstances.Count > me.Index
                    ? mesh.PreloadLocalMaterialInstances[me.Index]?.GetValue() as CMaterialInstance
                    : null;

            if (inst == null)
            {

                Parent?.GetLoggerService().Warning($"Couldn't find material instance for index {me.Index}");
                continue;
            }

            var material = new Material(name)
            {
                Name = name
            };

            foreach (var pair in inst.Values)
            {
                var k = pair.Key.ToString().NotNull();

                if (!material.Values.ContainsKey(k))
                {
                    material.Values.Add(k, pair.Value);
                }
            }

            if (!materials.ContainsKey(name))
            {
                materials.Add(name, material);
            }
        }

        return materials;
    }

    [RelayCommand]
    public void CopyAppearanceName()
    {
        if (SelectedAppearance?.Name is not null)
        {
            Clipboard.SetText(SelectedAppearance.Name);
        }
    }

    public bool IsAppearanceSelected => null != SelectedAppearance;

    public bool IsLoadingMaterials { get; set; }

    private void DeleteMaterialCache()
    {
        var dir = ISettingsManager.GetTemp_OBJPath();
        if (!Directory.Exists(dir))
            return;

        // Only remove preview bake artifacts. Do not wipe the whole temp folder
        // (ExtractShaders and other tools share it).
        string[] suffixes = { "_d.png", "_n.png", "_rm.png", "_emissive.png", ".deps", ".hash", ".png.tmp" };
        foreach (var file in Directory.GetFiles(dir))
        {
            var name = Path.GetFileName(file);
            if (!suffixes.Any(s => name.EndsWith(s, StringComparison.OrdinalIgnoreCase)))
                continue;
            try
            { File.Delete(file); }
            catch { /* skip locked files */ }
        }
    }

    [RelayCommand]
    public async Task LoadMaterials()
    {
        if (IsLoadingMaterials || SelectedAppearance == null)
        {
            if (SelectedAppearance == null)
                Parent?.GetLoggerService()?.Warning("No material selected!");
            return;
        }

        IsLoadingMaterials = true;
        try
        {
            RefreshMaterialsFromDisk();

            var shift = ShiftKeyPressed || Keyboard.Modifiers.HasFlag(ModifierKeys.Shift);
            var ctrl = CtrlKeyPressed || Keyboard.Modifiers.HasFlag(ModifierKeys.Control);
            var bakeMax = shift ? 4096 : 2048;
            var forceBake = shift || ctrl;

            if (ctrl)
            {
                DeleteMaterialCache();
                _textureCache.Clear();
                Parent?.GetLoggerService()?.Info("Clearing material cache...");

                foreach (var (_, material) in SelectedAppearance.RawMaterials)
                    ClearMaterial(material);
            }

            IEnumerable<KeyValuePair<string, Material>> batch = SelectedAppearance.RawMaterials;
            if (SelectedAppearance.Models is { Count: > 0 } models)
            {
                var names = models.SelectMany(m => m.Materials.Select(x => x.Name)).ToHashSet();
                if (names.Count > 0)
                    batch = batch.Where(x => names.Contains(x.Key));
            }

            var ordered = batch.OrderBy(x => x.Key).ToList();
            await Task.Run(async () =>
            {
                foreach (var (_, m) in ordered)
                    await LoadMaterial(m, bakeMax, forceBake);
            });

            Parent?.GetLoggerService()?.Info("All materials loaded!");
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Error($"Material loading had errors: {ex.Message}");
        }
        finally
        {
            IsLoadingMaterials = false;
        }

        // Drop anything loaded mid-bake so Apply picks up the fresh PNGs.
        _textureCache.Clear();

        if (SelectedAppearance != null)
            ApplyAppearancePreviewMaterials(SelectedAppearance);
    }

    private void RefreshMaterialsFromDisk()
    {
        ClearFileCache();

        if (SelectedAppearance?.Models == null)
            return;

        foreach (var model in SelectedAppearance.Models)
        {
            if (model.DepotPath == ResourcePath.Empty)
                continue;

            var meshFile = GetProjectOrDepotFile(model.DepotPath);
            if (meshFile?.RootChunk is not CMesh mesh)
                continue;

            var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
            var localList = mesh.LocalMaterialBuffer.RawData?.Buffer.Data as CR2WList;

            foreach (var me in mesh.MaterialEntries)
            {
                var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), mesh, meshPath);
                if (!SelectedAppearance.RawMaterials.TryGetValue(name, out var mat))
                    continue;

                if (me.IsLocalInstance)
                {
                    CMaterialInstance? inst = null;
                    if (localList != null && localList.Files.Count > me.Index)
                        inst = localList.Files[me.Index].RootChunk as CMaterialInstance;
                    else if (mesh.PreloadLocalMaterialInstances.Count > me.Index)
                        inst = mesh.PreloadLocalMaterialInstances[me.Index]?.GetValue() as CMaterialInstance;

                    if (inst == null)
                        continue;

                    mat.Instance = inst;
                    mat.Values.Clear();
                    foreach (var pair in inst.Values)
                    {
                        var k = pair.Key.ToString().NotNull();
                        mat.Values[k] = pair.Value;
                    }
                }
                else
                {
                    // External material — re-resolve from project/archive
                    FillFromExternal(mat, mesh, me);
                }
            }
        }
    }

    private void ClearMaterial(Material? material)
    {
        if (material == null)
        {
            return;
        }

        GetMaterialFilePathsFromCache(material.Name, true);
    }

    public async ValueTask LoadMaterial(Material? material, int bakeMax = 2048, bool forceBake = false)
    {
        if (material == null)
        {
            return;
        }

        Parent?.GetLoggerService().Info($"Loading material: {material.Name}");

        try
        {
            var dictionary = material.Values;
            var mat = material.Instance;

            // Resolve base material chain (inheritance).
            // Track visited paths so a cycle or unexpected chunk type cannot loop forever.
            var visited = new HashSet<ResourcePath>();
            while (mat != null && mat.BaseMaterial.DepotPath != ResourcePath.Empty
                   && visited.Add(mat.BaseMaterial.DepotPath))
            {
                var basePathText = mat.BaseMaterial.DepotPath.GetResolvedText() ?? "";
                if (basePathText.EndsWith("skin.mt", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                CR2WFile? baseMaterialFile = null;

                try
                {
                    baseMaterialFile = GetProjectOrDepotFile(mat.BaseMaterial.DepotPath);
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService().Warning(
                        $"[BaseMat] failed {mat.BaseMaterial.DepotPath}: {ex.Message}");
                    break;
                }

                if (baseMaterialFile == null)
                {
                    mat = null;
                    continue;
                }

                switch (baseMaterialFile.RootChunk)
                {
                    case CMaterialInstance cmi:
                        foreach (var pair in cmi.Values)
                        {
                            var k = pair.Key.ToString().NotNull();
                            if (!dictionary.ContainsKey(k))
                            {
                                dictionary.Add(k, pair.Value);
                            }
                        }

                        mat = cmi;
                        break;

                    case CMaterialTemplate cmt:
                        material.TemplateName = cmt.Name;
                        // Parameters is CArray<CArray<CHandle<CMaterialParameter>>>
                        if (cmt.Parameters != null)
                        {
                            foreach (var inner in cmt.Parameters)
                            {
                                if (inner == null)
                                    continue;
                                foreach (var handle in inner)
                                {
                                    if (handle.GetValue() is CMaterialParameterTexture texParam &&
                                        texParam.Texture.DepotPath != ResourcePath.Empty)
                                    {
                                        var key = texParam.ParameterName.ToString() ?? "";
                                        if (!string.IsNullOrEmpty(key) && !dictionary.ContainsKey(key))
                                            dictionary[key] = texParam.Texture;
                                    }
                                }
                            }
                        }
                        mat = null;
                        break;

                    default:
                        mat = null;
                        break;
                }
            }

            // Set numeric roughness / metalness values from material parameters
            adjustRoughness(dictionary, material);

            // Emissive map bake — only when EmissiveEV > 0 (EV <= 0 means off, no glow).
            // Skip entirely so we don't create unused _emissive.png files.
            if (dictionary.ContainsKey("Emissive") || dictionary.ContainsKey("AdTexture"))
            {
                float ev = 0f;
                if (dictionary.TryGetValue("EmissiveEV", out var evObj))
                    ev = ReadFloat(evObj);

                // Bake only when emission is actually on
                if (ev > 0.01f)
                {
                    var emissivePng = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_emissive.png");
                    await TryBakeEmissiveMap(material.Name, emissivePng, dictionary);
                }
            }

            var (filename_bd, filename_bn, filename_rm) =
                GetMaterialFilePathsFromCache(material.Name);

            // Invalidate cache if any referenced project file changed.
            // One generic hash covers mlsetup, profiles, gradients, templates, instances.
            if (!forceBake && File.Exists(filename_bd))
            {
                var depHash = ComputeGenericDepHash(dictionary);
                var depStamp = filename_bd + ".deps";
                var prevDep = File.Exists(depStamp) ? File.ReadAllText(depStamp) : "";
                if (prevDep != depHash)
                {
                    foreach (var f in new[] { filename_bd, filename_bn, filename_rm })
                    {
                        try
                        { if (File.Exists(f)) File.Delete(f); }
                        catch { /* ignore */ }
                    }
                }
            }

            // === MULTILAYER SETUP ===            
            if (dictionary.TryGetValue("MultilayerSetup", out var mlsetup) &&
                dictionary.TryGetValue("MultilayerMask", out var mlmask))
            {

                var albedoExists = File.Exists(filename_bd);
                var roughMetallicExists = File.Exists(filename_rm);
                var normalExists = File.Exists(filename_bn);

                if (mlsetup is not CResourceReference<Multilayer_Setup> mlsRef ||
                    mlmask is not CResourceReference<Multilayer_Mask> mlmRef)
                {
                    goto DiffuseMaps;
                }

                // Project files must override the archive. Try the project first.
                var setupFile = GetProjectOrDepotFile(mlsRef.DepotPath);
                if (setupFile is not { RootChunk: Multilayer_Setup mls })
                {
                    goto DiffuseMaps;
                }

                // Invalidate cache if mlsetup content changed (color scale, opacity, etc.).
                // Compares a hash of the layer data against a sidecar saved at bake time,
                // so project overrides are picked up even when the archive copy is older.
                bool stale = false;
                if (!forceBake && albedoExists)
                {
                    var hash = ComputeMlsetupHash(mls);
                    var stampPath = filename_bd + ".hash";
                    var prev = File.Exists(stampPath) ? File.ReadAllText(stampPath) : "";
                    if (prev != hash)
                    {
                        stale = true;
                        foreach (var f in new[] { filename_bd, filename_bn, filename_rm })
                        {
                            try
                            { if (File.Exists(f)) File.Delete(f); }
                            catch { /* ignore */ }
                        }
#if DEBUG
                        Parent?.GetLoggerService()?.Info(
                            $"[Cache] '{material.Name}' mlsetup changed — re-baking");
#endif
                    }
                }

                if (!forceBake && !stale && albedoExists && normalExists && roughMetallicExists)
                {
                    goto DiffuseMaps;
                }

                var maskFile = GetProjectOrDepotFile(mlmRef.DepotPath);
                if (maskFile is not { RootChunk: Multilayer_Mask mlm })
                {
                    goto DiffuseMaps;
                }

                ModTools.ConvertMultilayerMaskToDdsStreams(mlm, out var streams);
                if (streams == null || streams.Count == 0)
                {
                    goto DiffuseMaps;
                }

                // ----------------------------------------------------------
                // Local sampling helpers (offset-then-tile, same as CP77 mlsetup)
                //   uv' = (uv + offset) * tile
                // MB V keeps the historical minus: (v - mbOffV) * mbTile
                // ----------------------------------------------------------
                const float Inv255 = 1f / 255f;

                static int WrapIndex(int i, int n)
                {
                    if (n <= 0)
                    {
                        return 0;
                    }

                    var r = i % n;
                    return r < 0 ? r + n : r;
                }

                static int NextPow2Clamped(int value, int max)
                {
                    var v = Math.Max(1, value);
                    var p = 1;
                    while (p < v)
                    {
                        p <<= 1;
                        if (p >= max)
                        {
                            return max;
                        }
                    }

                    return Math.Min(p, max);
                }

                static unsafe float SampleChannel(byte* ptr, int stride, int tw, int th, float uu, float vv, int channel)
                {
                    const float inv = 1f / 255f;
                    var px = (uu * tw) - 0.5f;
                    var py = (vv * th) - 0.5f;
                    var fx0 = MathF.Floor(px);
                    var fy0 = MathF.Floor(py);
                    var x0 = WrapIndex((int)fx0, tw);
                    var y0 = WrapIndex((int)fy0, th);
                    var x1 = WrapIndex(x0 + 1, tw);
                    var y1 = WrapIndex(y0 + 1, th);
                    var fu = px - fx0;
                    var fv = py - fy0;

                    // BGRA: 0=B, 1=G, 2=R
                    var c00 = ptr[(y0 * stride) + (x0 * 4) + channel] * inv;
                    var c10 = ptr[(y0 * stride) + (x1 * 4) + channel] * inv;
                    var c01 = ptr[(y1 * stride) + (x0 * 4) + channel] * inv;
                    var c11 = ptr[(y1 * stride) + (x1 * 4) + channel] * inv;
                    return ((c00 * (1f - fu)) + (c10 * fu)) * (1f - fv)
                         + ((c01 * (1f - fu)) + (c11 * fu)) * fv;
                }

                static unsafe float SampleChannelR(byte* ptr, int stride, int tw, int th, float uu, float vv)
                    => SampleChannel(ptr, stride, tw, th, uu, vv, 2);

                static unsafe float SampleChannelG(byte* ptr, int stride, int tw, int th, float uu, float vv)
                    => SampleChannel(ptr, stride, tw, th, uu, vv, 1);

                static unsafe float SampleChannelB(byte* ptr, int stride, int tw, int th, float uu, float vv)
                    => SampleChannel(ptr, stride, tw, th, uu, vv, 0);

                static unsafe void SampleBgra(
                    byte* ptr, int stride, int tw, int th, float uu, float vv,
                    out float r, out float g, out float b, out float a)
                {
                    const float inv = 1f / 255f;
                    var px = (uu * tw) - 0.5f;
                    var py = (vv * th) - 0.5f;
                    var fx0 = MathF.Floor(px);
                    var fy0 = MathF.Floor(py);
                    var x0 = WrapIndex((int)fx0, tw);
                    var y0 = WrapIndex((int)fy0, th);
                    var x1 = WrapIndex(x0 + 1, tw);
                    var y1 = WrapIndex(y0 + 1, th);
                    var fu = px - fx0;
                    var fv = py - fy0;

                    byte* p00 = ptr + (y0 * stride) + (x0 * 4);
                    byte* p10 = ptr + (y0 * stride) + (x1 * 4);
                    byte* p01 = ptr + (y1 * stride) + (x0 * 4);
                    byte* p11 = ptr + (y1 * stride) + (x1 * 4);

                    b = (((p00[0] * (1f - fu)) + (p10[0] * fu)) * (1f - fv) + ((p01[0] * (1f - fu)) + (p11[0] * fu)) * fv) * inv;
                    g = (((p00[1] * (1f - fu)) + (p10[1] * fu)) * (1f - fv) + ((p01[1] * (1f - fu)) + (p11[1] * fu)) * fv) * inv;
                    r = (((p00[2] * (1f - fu)) + (p10[2] * fu)) * (1f - fv) + ((p01[2] * (1f - fu)) + (p11[2] * fu)) * fv) * inv;
                    a = (((p00[3] * (1f - fu)) + (p10[3] * fu)) * (1f - fv) + ((p01[3] * (1f - fu)) + (p11[3] * fu)) * fv) * inv;
                }

                // MB mask source (ints — static locals cannot capture consts):
                //   0 Alpha  — pattern lives in A
                //   1 Luma   — A flat, print is in RGB brightness (zebra01)
                //   2 One    — default 64x64 #7F7FFF, no pattern
                //   3 Slope  — A+luma flat, but RG deviate from 0.5
                //              (pattern_militarism_01: chroma/normal pattern, luma ≈ const)
                const int MbMaskOne = 2;

                static unsafe float SampleMicroblendWeight(
                    byte* ptr, int stride, int tw, int th, float uu, float vv, int source)
                {
                    if (ptr == null || tw < 1 || th < 1)
                    {
                        return 1f;
                    }

                    if (source == 2)
                    {
                        // default.xbm: flat normal RGB, mask lives in A (~104/255)
                        return ptr[3] * (1f / 255f);
                    }

                    const float inv = 1f / 255f;
                    const float invRgb = 1f / (3f * 255f);
                    var px = (uu * tw) - 0.5f;
                    var py = (vv * th) - 0.5f;
                    var fx0 = MathF.Floor(px);
                    var fy0 = MathF.Floor(py);
                    var x0 = WrapIndex((int)fx0, tw);
                    var y0 = WrapIndex((int)fy0, th);
                    var x1 = WrapIndex(x0 + 1, tw);
                    var y1 = WrapIndex(y0 + 1, th);
                    var fu = px - fx0;
                    var fv = py - fy0;

                    byte* p00 = ptr + (y0 * stride) + (x0 * 4);
                    byte* p10 = ptr + (y0 * stride) + (x1 * 4);
                    byte* p01 = ptr + (y1 * stride) + (x0 * 4);
                    byte* p11 = ptr + (y1 * stride) + (x1 * 4);

                    float Weight(byte* p)
                    {
                        if (source == 1)
                        {
                            return (p[2] + p[1] + p[0]) * invRgb;
                        }

                        if (source == 3)
                        {
                            var dx = (p[2] * inv) - 0.5f;
                            var dy = (p[1] * inv) - 0.5f;
                            return Math.Clamp(1f - (MathF.Sqrt((dx * dx) + (dy * dy)) * 2f), 0f, 1f);
                        }

                        return p[3] * inv;
                    }

                    var c00 = Weight(p00);
                    var c10 = Weight(p10);
                    var c01 = Weight(p01);
                    var c11 = Weight(p11);
                    return ((c00 * (1f - fu)) + (c10 * fu)) * (1f - fv)
                         + ((c01 * (1f - fu)) + (c11 * fu)) * fv;
                }

                static unsafe int DetectMicroblendMaskSource(byte* ptr, int stride, int tw, int th)
                {
                    if (ptr == null || tw < 1 || th < 1)
                    {
                        return 2;
                    }

                    var stepX = Math.Max(1, tw / 16);
                    var stepY = Math.Max(1, th / 16);
                    var minA = 255;
                    var maxA = 0;
                    var minL = 255 * 3;
                    var maxL = 0;
                    var minR = 255;
                    var maxR = 0;
                    var minG = 255;
                    var maxG = 0;
                    for (var y = 0; y < th; y += stepY)
                    {
                        var row = ptr + (y * stride);
                        for (var x = 0; x < tw; x += stepX)
                        {
                            var p = row + (x * 4);
                            var a = p[3];
                            if (a < minA)
                            {
                                minA = a;
                            }

                            if (a > maxA)
                            {
                                maxA = a;
                            }

                            var r = p[2];
                            var g = p[1];
                            if (r < minR)
                            {
                                minR = r;
                            }

                            if (r > maxR)
                            {
                                maxR = r;
                            }

                            if (g < minG)
                            {
                                minG = g;
                            }

                            if (g > maxG)
                            {
                                maxG = g;
                            }

                            var l = p[0] + r + g;
                            if (l < minL)
                            {
                                minL = l;
                            }

                            if (l > maxL)
                            {
                                maxL = l;
                            }
                        }
                    }

                    if ((maxA - minA) >= 16)
                    {
                        return 0;
                    }

                    if ((maxL - minL) >= 48)
                    {
                        return 1;
                    }

                    if ((maxR - minR) >= 16 || (maxG - minG) >= 16)
                    {
                        return 3;
                    }

                    return 2;
                }

                // Two regimes, same contrast:
                //   mid/low mask (Layer 003 grey + zebra01, c=0.1):
                //     amplify burn so the pattern thresholds into stripes
                //   high/white mask (Layer 004/005 bezel + damp_stains/spots, c=0.25):
                //     crossfade only — stains stay a tint, color stays mostly solid
                static float LinearToSrgb(float x)
                {
                    x = Math.Clamp(x, 0f, 1f);
                    return x <= 0.0031308f
                        ? 12.92f * x
                        : (1.055f * MathF.Pow(x, 1f / 2.4f)) - 0.055f;
                }

                static float SrgbToLinear(float x)
                {
                    x = Math.Clamp(x, 0f, 1f);
                    return x <= 0.04045f
                        ? x / 12.92f
                        : MathF.Pow((x + 0.055f) / 1.055f, 2.4f);
                }

                static unsafe void SampleBgraNearest(
                    byte* ptr, int stride, int tw, int th, float uu, float vv,
                    out float r, out float g, out float b, out float a)
                {
                    const float inv = 1f / 255f;
                    var x = WrapIndex((int)(uu * tw), tw);
                    var y = WrapIndex((int)(vv * th), th);
                    var px = ptr + (y * stride) + (x * 4);
                    b = px[0] * inv;
                    g = px[1] * inv;
                    r = px[2] * inv;
                    a = px[3] * inv;
                }

                static void FractOffsetTile(float u, float v, float tile, float offU, float offV, bool flipV,
                    out float uu, out float vv)
                {
                    var tu = u * tile + offU;
                    var baseV = flipV ? (1f - v) : v;
                    var tv = baseV * tile + offV;
                    uu = tu - MathF.Floor(tu);
                    vv = tv - MathF.Floor(tv);
                }

                static float ApplyLevels(float input, float scale, float offset)
                {
                    // CP77 multilayer levels: sequential multiply-add (matches Blender addon)
                    // result = input * scale + offset
                    // Extreme values (e.g. foil metalLevelsIn = [-12.74, 5.496]) create high contrast
                    return input * scale + offset;
                }

                // === 1. Native mask layers (do NOT pre-scale to microblend size) ===
                var layerBitmaps = new List<Bitmap>();
                var nativeMaskW = 1;
                var nativeMaskH = 1;

                foreach (var stream in streams)
                {
                    var img = await ImageDecoder.RenderToBitmapImageDds(
                        stream, Enums.ETextureRawFormat.TRF_Grayscale);

                    if (img == null)
                    {
                        layerBitmaps.Add(new Bitmap(1, 1));
                        continue;
                    }

                    var bmp = BitmapSourceToBitmap(img);
                    layerBitmaps.Add(bmp);
                    nativeMaskW = Math.Max(nativeMaskW, bmp.Width);
                    nativeMaskH = Math.Max(nativeMaskH, bmp.Height);
                }

                if (layerBitmaps.Count == 0)
                {
                    goto DiffuseMaps;
                }

                // === 2. Canvas size: mask detail at low tile + enough pixels per repeat at high tile ===
                const int PxPerTile = 32;
                const int SoftMin = 256;
                var hardMax = Math.Clamp(bakeMax, 256, 4096);
                var useNearestMaps = hardMax >= 4096;

                var maxMatTile = 1f;
                var maxMbTile = 1f;
                var maxSourceDetail = 0;

                foreach (var layer in mls.Layers)
                {
                    var mt = (float)layer.MatTile;
                    var mbt = (float)layer.MbTile;
                    if (mt > maxMatTile)
                    {
                        maxMatTile = mt;
                    }

                    if (mbt > maxMbTile)
                    {
                        maxMbTile = mbt;
                    }

                    if (layer.Microblend.DepotPath == ResourcePath.Empty)
                    {
                        continue;
                    }

                    try
                    {
                        var mbFile = GetProjectOrDepotFile(layer.Microblend.DepotPath);
                        if (mbFile?.RootChunk is ITexture mbTex)
                        {
                            var redImage = RedImage.FromRedClass(mbTex);
                            if (redImage != null)
                            {
                                var w = (int)redImage.Metadata.Width;
                                var h = (int)redImage.Metadata.Height;
                                if (w >= 64 && h >= 64)
                                {
                                    // At low mbTile the bake must keep source texels.
                                    // At high mbTile Nyquist is dominated by PxPerTile * tile, not source size.
                                    var keep = mbt <= 2f ? Math.Max(w, h) : (int)(Math.Max(w, h) * Math.Min(mbt, 1.5f) / Math.Max(mbt, 1f));
                                    maxSourceDetail = Math.Max(maxSourceDetail, keep);
                                }
                            }
                        }
                    }
                    catch
                    {
                        // ignore
                    }
                }

                var fromTile = (int)Math.Ceiling(PxPerTile * Math.Max(maxMatTile, maxMbTile));
                var fromMask = Math.Max(nativeMaskW, nativeMaskH);

                var fromMb = maxSourceDetail;
                foreach (var layer in mls.Layers)
                {
                    if (layer.Microblend.DepotPath == ResourcePath.Empty)
                    {
                        continue;
                    }

                    var mbt = Math.Max((float)layer.MbTile, 1f);
                    try
                    {
                        var mbFile = GetProjectOrDepotFile(layer.Microblend.DepotPath);
                        if (mbFile?.RootChunk is ITexture mbTex)
                        {
                            var redImage = RedImage.FromRedClass(mbTex);
                            if (redImage != null)
                            {
                                var src = Math.Max((int)redImage.Metadata.Width, (int)redImage.Metadata.Height);
                                if (src >= 64)
                                {
                                    fromMb = Math.Max(fromMb, (int)Math.Ceiling(src * mbt));
                                }
                            }
                        }
                    }
                    catch
                    {
                        // ignore
                    }
                }

                fromMb = Math.Min(fromMb, hardMax);

                var target = Math.Max(SoftMin, Math.Max(fromMask, Math.Max(fromTile, fromMb)));
                target = NextPow2Clamped(target, hardMax);

                var maxWidth = target;
                var maxHeight = target;

                if (hardMax >= 4096 && !_logged4k)
                {
                    _logged4k = true;
                    Parent?.GetLoggerService()?.Debug($"ML 4k material preview (Shift)");
                }


                // === 3. Working buffers ===
                var destBitmap = new Bitmap(maxWidth, maxHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                var rmBitmap = new Bitmap(maxWidth, maxHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                var normalBitmap = new Bitmap(maxWidth, maxHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                using (var g = Graphics.FromImage(normalBitmap))
                using (var brush = new SolidBrush(Color.FromArgb(255, 128, 128, 255)))
                {
                    g.FillRectangle(brush, 0, 0, maxWidth, maxHeight);
                }

                using (var g = Graphics.FromImage(rmBitmap))
                using (var brush = new SolidBrush(Color.FromArgb(255, 0, 128, 0)))
                {
                    // B=metal 0, G=rough 0.5, R=0
                    g.FillRectangle(brush, 0, 0, maxWidth, maxHeight);
                }

                var texCache = new Dictionary<string, Bitmap>(StringComparer.OrdinalIgnoreCase);

                async Task<Bitmap?> GetTex(ResourcePath path, bool flipY = false)
                {
                    if (path == ResourcePath.Empty)
                        return null;

                    var key = (path.GetResolvedText() ?? path.ToString() ?? "") + (flipY ? "|flipY" : "");
                    if (!texCache.TryGetValue(key, out var hit))
                    {
                        var bmp = await LoadTextureAsBitmap(path);
                        if (bmp == null)
                            return null;
                        if (flipY)
                        {
                            try
                            { bmp.RotateFlip(RotateFlipType.RotateNoneFlipY); }
                            catch { bmp.Dispose(); throw; }
                        }
                        texCache[key] = hit = bmp;
                    }

                    return (Bitmap)hit.Clone();
                }

                var layerIndex = 0;

                try
                {
                    foreach (var layer in mls.Layers)
                    {
                        if (layerIndex >= layerBitmaps.Count)
                        {
                            break;
                        }

                        if (layer.Material.DepotPath == ResourcePath.Empty)
                        {
                            layerIndex++;
                            continue;
                        }

                        var templateFile = GetProjectOrDepotFile(layer.Material.DepotPath);
                        if (templateFile?.RootChunk is not Multilayer_LayerTemplate mllt)
                        {
                            layerIndex++;
                            continue;
                        }

                        var isBaseLayer = layerIndex == 0;
                        var opacity = (float)layer.Opacity;
                        if (!isBaseLayer && opacity < 0.0001f)
                        {
                            layerIndex++;
                            continue;
                        }

                        var sourceMask = layerBitmaps[layerIndex];
                        if (sourceMask.Width < 1 || sourceMask.Height < 1)
                        {
                            layerIndex++;
                            continue;
                        }

                        float tilingMul = 1f;
                        try
                        {
                            tilingMul = (float)mllt.TilingMultiplier;
                            if (tilingMul < 0.0001f)
                            {
                                tilingMul = 1f;
                            }
                        }
                        catch
                        {
                            tilingMul = 1f;
                        }

                        var effectiveMatTile = (float)layer.MatTile * tilingMul;
                        if (effectiveMatTile < 0.0001f)
                        {
                            effectiveMatTile = 1f;
                        }

                        var offU = (float)layer.OffsetU;
                        var offV = (float)layer.OffsetV;
                        var mbContrast = (float)layer.MicroblendContrast;
                        var mbNormalStr = (float)layer.MicroblendNormalStrength;
                        var mbTile = (float)layer.MbTile;
                        if (mbTile < 0.0001f)
                        {
                            mbTile = 1f;
                        }

                        var mbOffU = (float)layer.MicroblendOffsetU;
                        var mbOffV = (float)layer.MicroblendOffsetV;

                        Bitmap? microblendBmp = null;
                        var useMbMask = layer.Microblend.DepotPath != ResourcePath.Empty;
                        var useMbNormal = Math.Abs(mbNormalStr) > 0.001f;
                        if (useMbMask)
                        {
                            microblendBmp = await GetTex(layer.Microblend.DepotPath, flipY: true);
                        }

                        Bitmap? colorTexBmp = null;
                        var useColorTexture = mllt.ColorTexture.DepotPath != ResourcePath.Empty && opacity > 0;
                        if (useColorTexture)
                        {
                            colorTexBmp = await GetTex(mllt.ColorTexture.DepotPath, flipY: true);
                            if (colorTexBmp == null)
                            {
                                useColorTexture = false;
                            }
                        }

                        float cr = 1f, cg = 1f, cb = 1f;
                        var colorOv = FindOverride(mllt.Overrides.ColorScale, layer.ColorScale, x => x.N);
                        var colorVec = colorOv?.V;
                        if (colorVec != null && colorVec.Count >= 3)
                        {
                            cr = colorVec[0];
                            cg = colorVec[1];
                            cb = colorVec[2];
                        }

                        var skipColor = opacity == 0
                                        || layer.Material.DepotPath == ResourcePath.Empty
                                        || (!useColorTexture && colorVec == null);

                        // Levels from template/overrides (multiply-add, identity by default)
                        TryGetLevels(mllt.Overrides.RoughLevelsIn, layer.RoughLevelsIn, x => x.N, x => x.V,
                                     out float roughInScale, out float roughInOffset);
                        TryGetLevels(mllt.Overrides.RoughLevelsOut, layer.RoughLevelsOut, x => x.N, x => x.V,
                                     out float roughOutScale, out float roughOutOffset);
                        TryGetLevels(mllt.Overrides.MetalLevelsIn, layer.MetalLevelsIn, x => x.N, x => x.V,
                                     out float metalInScale, out float metalInOffset);
                        TryGetLevels(mllt.Overrides.MetalLevelsOut, layer.MetalLevelsOut, x => x.N, x => x.V,
                                     out float metalOutScale, out float metalOutOffset);

#if DEBUG
                        // Temporary debug logging for levels (helps catch extreme foil values and wrong fallbacks)
                        System.Diagnostics.Debug.WriteLine(
                            $"[Levels] RoughIn: {roughInScale:F3},{roughInOffset:F3}  RoughOut: {roughOutScale:F3},{roughOutOffset:F3}");
                        System.Diagnostics.Debug.WriteLine(
                            $"[Levels] MetalIn: {metalInScale:F3},{metalInOffset:F3}  MetalOut: {metalOutScale:F3},{metalOutOffset:F3}");
                        if (Math.Abs(roughInScale) > 5f || Math.Abs(metalInScale) > 5f)
                        {
                            System.Diagnostics.Debug.WriteLine("[Levels] WARNING: extreme scale detected (possible foil / strong contrast)");
                        }
#endif

                        Bitmap? roughTexBmp = null;
                        Bitmap? metalTexBmp = null;
                        Bitmap? normalTexBmp = null;

                        if (mllt.RoughnessTexture.DepotPath != ResourcePath.Empty)
                        {
                            roughTexBmp = await GetTex(mllt.RoughnessTexture.DepotPath, flipY: true);
                            if (roughTexBmp == null)
                            {
#if DEBUG
                                System.Diagnostics.Debug.WriteLine($"[Tex] Failed to load roughness: {mllt.RoughnessTexture.DepotPath}");
#endif
                            }
                        }

                        if (mllt.MetalnessTexture.DepotPath != ResourcePath.Empty)
                        {
                            metalTexBmp = await GetTex(mllt.MetalnessTexture.DepotPath, flipY: true);
                            if (metalTexBmp == null)
                            {
#if DEBUG
                                System.Diagnostics.Debug.WriteLine($"[Tex] Failed to load metalness: {mllt.MetalnessTexture.DepotPath}");
#endif
                            }
                        }

                        var nsOv = FindOverride(mllt.Overrides.NormalStrength, layer.NormalStrength, x => x.N);
                        var normalStrengthVal = nsOv != null ? (float)nsOv.V : 1f;

                        if (mllt.NormalTexture.DepotPath != ResourcePath.Empty)
                        {
                            normalTexBmp = await GetTex(mllt.NormalTexture.DepotPath, flipY: true);
                        }

                        var destRect = new Rectangle(0, 0, maxWidth, maxHeight);
                        var destData = destBitmap.LockBits(destRect, ImageLockMode.ReadWrite,
                            System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        var rmData = rmBitmap.LockBits(destRect, ImageLockMode.ReadWrite,
                            System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        var nrmData = normalBitmap.LockBits(destRect, ImageLockMode.ReadWrite,
                            System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                        var srcMaskData = sourceMask.LockBits(
                            new Rectangle(0, 0, sourceMask.Width, sourceMask.Height),
                            ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                        BitmapData? mbData = null;
                        BitmapData? colorData = null;
                        BitmapData? roughData = null;
                        BitmapData? metalData = null;
                        BitmapData? ntexData = null;

                        try
                        {
                            if (microblendBmp != null)
                            {
                                mbData = microblendBmp.LockBits(
                                    new Rectangle(0, 0, microblendBmp.Width, microblendBmp.Height),
                                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            }

                            if (colorTexBmp != null)
                            {
                                colorData = colorTexBmp.LockBits(
                                    new Rectangle(0, 0, colorTexBmp.Width, colorTexBmp.Height),
                                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            }

                            if (roughTexBmp != null)
                            {
                                roughData = roughTexBmp.LockBits(
                                    new Rectangle(0, 0, roughTexBmp.Width, roughTexBmp.Height),
                                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            }

                            if (metalTexBmp != null)
                            {
                                metalData = metalTexBmp.LockBits(
                                    new Rectangle(0, 0, metalTexBmp.Width, metalTexBmp.Height),
                                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            }

                            if (normalTexBmp != null)
                            {
                                ntexData = normalTexBmp.LockBits(
                                    new Rectangle(0, 0, normalTexBmp.Width, normalTexBmp.Height),
                                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            }

                            unsafe
                            {
                                byte* destPtr = (byte*)destData.Scan0;
                                byte* rmPtr = (byte*)rmData.Scan0;
                                byte* nrmPtr = (byte*)nrmData.Scan0;
                                byte* maskPtr = (byte*)srcMaskData.Scan0;
                                var destStride = destData.Stride;
                                var rmStride = rmData.Stride;
                                var nrmStride = nrmData.Stride;
                                var maskStride = srcMaskData.Stride;
                                var smW = sourceMask.Width;
                                var smH = sourceMask.Height;

                                byte* mbPtr = mbData != null ? (byte*)mbData.Scan0 : null;
                                var mbStride = mbData?.Stride ?? 0;
                                var mbW = microblendBmp?.Width ?? 1;
                                var mbH = microblendBmp?.Height ?? 1;

                                byte* colPtr = colorData != null ? (byte*)colorData.Scan0 : null;
                                var colStride = colorData?.Stride ?? 0;
                                var colW = colorTexBmp?.Width ?? 1;
                                var colH = colorTexBmp?.Height ?? 1;

                                byte* roughPtr = roughData != null ? (byte*)roughData.Scan0 : null;
                                var roughStride = roughData?.Stride ?? 0;
                                var roughW = roughTexBmp?.Width ?? 1;
                                var roughH = roughTexBmp?.Height ?? 1;

                                byte* metalPtr = metalData != null ? (byte*)metalData.Scan0 : null;
                                var metalStride = metalData?.Stride ?? 0;
                                var metalW = metalTexBmp?.Width ?? 1;
                                var metalH = metalTexBmp?.Height ?? 1;

                                byte* ntexPtr = ntexData != null ? (byte*)ntexData.Scan0 : null;
                                var ntexStride = ntexData?.Stride ?? 0;
                                var ntexW = normalTexBmp?.Width ?? 1;
                                var ntexH = normalTexBmp?.Height ?? 1;

                                var mbMaskSource = mbPtr != null
                                    ? DetectMicroblendMaskSource(mbPtr, mbStride, mbW, mbH)
                                    : MbMaskOne;
                                var applyMbMask = mbPtr != null && useMbMask;
                                var nearestMb = useNearestMaps || mbTile >= 8f;
                                var nearestMat = useNearestMaps || effectiveMatTile >= 8f;

                                // Hoist path comparison and flags outside the pixel loop (performance)
                                bool sameRmPath = false;
                                if (roughTexBmp != null && metalTexBmp != null)
                                {
                                    sameRmPath = ReferenceEquals(roughTexBmp, metalTexBmp);
                                }
                                if (!sameRmPath &&
                                    mllt.RoughnessTexture.DepotPath != ResourcePath.Empty &&
                                    mllt.MetalnessTexture.DepotPath == mllt.RoughnessTexture.DepotPath)
                                {
                                    sameRmPath = true;
                                }

                                var hasRoughPtr = roughPtr != null;
                                var hasMetalPtr = metalPtr != null;

#if DEBUG
                                System.Diagnostics.Debug.WriteLine(
                                    $"[TexFlags] roughExists={hasRoughPtr} metalExists={hasMetalPtr} sameRmPath={sameRmPath}");
#endif

                                Parallel.For(0, maxHeight, y =>
                                {
                                    for (var x = 0; x < maxWidth; x++)
                                    {
                                        var u = (x + 0.5f) / maxWidth;
                                        var v = (y + 0.5f) / maxHeight;

                                        // Mask: native resolution, bilinear. Opacity applied AFTER mb mix.
                                        var mu = u - MathF.Floor(u);
                                        var mv = v - MathF.Floor(v);
                                        var mask = SampleChannelR(maskPtr, maskStride, smW, smH, mu, mv);

                                        {
                                            // Blender Mapping: UV * Scale + Location.
                                            // Image V is top-down; Blender UV V is bottom-up.
                                            FractOffsetTile(u, v, mbTile, mbOffU, mbOffV,
                                                flipV: true,
                                                out var mbu, out var mbv);
                                            var mbA = SampleMicroblendWeight(
                                                mbPtr, mbStride, mbW, mbH, mbu, mbv, mbMaskSource);
                                            mask = ApplyMicroblendContrast(mask, mbA, mbContrast);
                                        }

                                        // Clamp factor like Blender Mix node (Clamp Factor)
                                        var maskVal = Math.Clamp(mask * opacity, 0f, 1f);
                                        if (maskVal < 0.001f)
                                        {
                                            continue;
                                        }

                                        FractOffsetTile(u, v, effectiveMatTile, offU, offV, flipV: true,
                                            out var su, out var sv);

                                        // ---- albedo ----
                                        if (!skipColor)
                                        {
                                            float srcR;
                                            float srcG;
                                            float srcB;
                                            if (colPtr != null)
                                            {
                                                if (nearestMat)
                                                {
                                                    SampleBgraNearest(colPtr, colStride, colW, colH, su, sv,
                                                        out srcR, out srcG, out srcB, out _);
                                                }
                                                else
                                                {
                                                    SampleBgra(colPtr, colStride, colW, colH, su, sv,
                                                        out srcR, out srcG, out srcB, out _);
                                                }
                                            }
                                            else
                                            {
                                                srcR = srcG = srcB = 1f;
                                            }

                                            srcR *= cr;
                                            srcG *= cg;
                                            srcB *= cb;

                                            var dOff = (y * destStride) + (x * 4);
                                            var a = maskVal;
                                            var er = SrgbToLinear(destPtr[dOff + 2] * Inv255);
                                            var eg = SrgbToLinear(destPtr[dOff + 1] * Inv255);
                                            var eb = SrgbToLinear(destPtr[dOff + 0] * Inv255);
                                            var outR = LinearToSrgb((er * (1f - a)) + (srcR * a));
                                            var outG = LinearToSrgb((eg * (1f - a)) + (srcG * a));
                                            var outB = LinearToSrgb((eb * (1f - a)) + (srcB * a));
                                            destPtr[dOff + 0] = (byte)Math.Clamp((int)(outB * 255f), 0, 255);
                                            destPtr[dOff + 1] = (byte)Math.Clamp((int)(outG * 255f), 0, 255);
                                            destPtr[dOff + 2] = (byte)Math.Clamp((int)(outR * 255f), 0, 255);
                                            destPtr[dOff + 3] = 255;
                                        }

                                        // ---- roughness / metalness ----
                                        {
                                            // Sample roughness (default 0.5 when missing).
                                            // Placeholders (black/white/grey solid textures) are sampled as constants
                                            // and then remapped by levels — same as Blender.
                                            // Always bilinear for roughness (unified with normal, avoids square artifacts)
                                            var roughValue = 0.5f;
                                            if (hasRoughPtr)
                                            {
                                                roughValue = SampleChannelG(roughPtr, roughStride, roughW, roughH, su, sv);
                                            }

                                            // Sequential levels + clamp (matches Blender Multiply Add + Clamp Result)
                                            var roughAfterIn = ApplyLevels(roughValue, roughInScale, roughInOffset);
                                            var roughness = Math.Clamp(ApplyLevels(roughAfterIn, roughOutScale, roughOutOffset), 0f, 1f);

                                            // Metalness
                                            // - same path as roughness (foil / packed _r.xbm) → share sample
                                            // - separate _m or placeholder → sample it (black=0, grey≈0.5, white=1)
                                            // - missing → 0
                                            var metalValue = 0f;
                                            if (sameRmPath)
                                            {
                                                metalValue = roughValue;
                                            }
                                            else if (hasMetalPtr)
                                            {
                                                // Always bilinear for metalness (unified with normal)
                                                metalValue = SampleChannelB(metalPtr, metalStride, metalW, metalH, su, sv);
                                            }
                                            // else metalValue stays 0

                                            // Always apply levels (even for solid placeholders and missing textures)
                                            var metalAfterIn = ApplyLevels(metalValue, metalInScale, metalInOffset);
                                            var metallic = Math.Clamp(ApplyLevels(metalAfterIn, metalOutScale, metalOutOffset), 0f, 1f);

                                            var rOff = (y * rmStride) + (x * 4);
                                            var existingMetal = rmPtr[rOff + 0] * Inv255;
                                            var existingRough = rmPtr[rOff + 1] * Inv255;

                                            // Clamp Result like Blender Mix node
                                            var finalRough = Math.Clamp((existingRough * (1f - maskVal)) + (roughness * maskVal), 0f, 1f);
                                            var finalMetal = Math.Clamp((existingMetal * (1f - maskVal)) + (metallic * maskVal), 0f, 1f);

                                            var metalB = (byte)Math.Clamp((int)(finalMetal * 255f), 0, 255);
                                            var roughB = (byte)Math.Clamp((int)(finalRough * 255f), 0, 255);

                                            rmPtr[rOff + 0] = metalB; // B metal
                                            rmPtr[rOff + 1] = roughB; // G rough
                                            rmPtr[rOff + 2] = 0;      // R
                                            rmPtr[rOff + 3] = 255;
                                        }

                                        // ---- template normal ----
                                        if (ntexPtr != null)
                                        {
                                            if (maskVal >= 0.001f && ntexPtr != null)
                                            {
                                                float nR, nG, nB;
                                                // Always bilinear for normals to avoid visible square artifacts
                                                SampleBgra(ntexPtr, ntexStride, ntexW, ntexH, su, sv,
                                                    out nR, out nG, out nB, out _);

                                                nR = 0.5f + ((nR - 0.5f) * normalStrengthVal);
                                                nG = 0.5f + ((nG - 0.5f) * normalStrengthVal);

                                                var nOff = (y * nrmStride) + (x * 4);
                                                var ocB = nrmPtr[nOff + 0] * Inv255;
                                                var ocG = nrmPtr[nOff + 1] * Inv255;
                                                var ocR = nrmPtr[nOff + 2] * Inv255;

                                                var r = ((ocR - 0.5f) * (1f - maskVal)) + ((nR - 0.5f) * maskVal) + 0.5f;
                                                var gch = ((ocG - 0.5f) * (1f - maskVal)) + ((nG - 0.5f) * maskVal) + 0.5f;
                                                var bch = ((ocB - 0.5f) * (1f - maskVal)) + ((nB - 0.5f) * maskVal) + 0.5f;

                                                if (nB < 0.01f)
                                                {
                                                    var nx = (r * 2f) - 1f;
                                                    var ny = (gch * 2f) - 1f;
                                                    var nz = (float)Math.Sqrt(Math.Max(0f, 1f - (nx * nx) - (ny * ny)));
                                                    bch = (nz * 0.5f) + 0.5f;
                                                }

                                                nrmPtr[nOff + 0] = (byte)Math.Clamp((int)(bch * 255f), 0, 255);
                                                nrmPtr[nOff + 1] = (byte)Math.Clamp((int)(gch * 255f), 0, 255);
                                                nrmPtr[nOff + 2] = (byte)Math.Clamp((int)(r * 255f), 0, 255);
                                                nrmPtr[nOff + 3] = 255;
                                            }
                                        }

                                        // Microblend normal is sampled with mbTile (not matTile) when strength != 0.

                                        var applyMbNormalHere = Math.Abs(mbNormalStr) > 0.001f && mask < 0.999f;

                                        if (applyMbNormalHere && mbPtr != null)
                                        {
                                            // Blender Mapping: UV * Scale + Location.
                                            // Image V is top-down; Blender UV V is bottom-up.
                                            FractOffsetTile(u, v, mbTile, mbOffU, mbOffV,
                                                flipV: true,
                                                out var mbu, out var mbv);
                                            float nR, nG, nB;
                                            if (nearestMb)
                                            {
                                                SampleBgraNearest(mbPtr, mbStride, mbW, mbH, mbu, mbv,
                                                    out nR, out nG, out nB, out _);
                                            }
                                            else
                                            {
                                                SampleBgra(mbPtr, mbStride, mbW, mbH, mbu, mbv,
                                                    out nR, out nG, out nB, out _);
                                            }

                                            if (mbNormalStr < 0f)
                                            {
                                                // Negative strength inverts the microblend normal (matches Blender)
                                                nR = 1f - nR;
                                                nG = 1f - nG;
                                            }

                                            // Factor = mask * strength, clamped like Blender Mix (Clamp Factor)
                                            // Removed the arbitrary *0.5 so strength matches Blender more closely
                                            var alpha = Math.Clamp(maskVal * Math.Abs(mbNormalStr), 0f, 1f);
                                            if (alpha >= 0.001f)
                                            {
                                                var nOff = (y * nrmStride) + (x * 4);
                                                var ocB = nrmPtr[nOff + 0] * Inv255;
                                                var ocG = nrmPtr[nOff + 1] * Inv255;
                                                var ocR = nrmPtr[nOff + 2] * Inv255;

                                                // Mix (lerp) in tangent space, then re-normalize Z
                                                var r = ((ocR - 0.5f) * (1f - alpha)) + ((nR - 0.5f) * alpha) + 0.5f;
                                                var gch = ((ocG - 0.5f) * (1f - alpha)) + ((nG - 0.5f) * alpha) + 0.5f;
                                                var bch = ((ocB - 0.5f) * (1f - alpha)) + ((nB - 0.5f) * alpha) + 0.5f;

                                                if (nB < 0.01f)
                                                {
                                                    var nx = (r * 2f) - 1f;
                                                    var ny = (gch * 2f) - 1f;
                                                    var nz = (float)Math.Sqrt(Math.Max(0f, 1f - (nx * nx) - (ny * ny)));
                                                    bch = (nz * 0.5f) + 0.5f;
                                                }

                                                nrmPtr[nOff + 0] = (byte)Math.Clamp((int)(bch * 255f), 0, 255);
                                                nrmPtr[nOff + 1] = (byte)Math.Clamp((int)(gch * 255f), 0, 255);
                                                nrmPtr[nOff + 2] = (byte)Math.Clamp((int)(r * 255f), 0, 255);
                                                nrmPtr[nOff + 3] = 255;
                                            }
                                        }
                                    }
                                });
                            }
                        }
                        catch (Exception ex)
                        {
                            Parent?.GetLoggerService()?.Warning(
                                $"Failed to process layer {layerIndex} in material '{material?.Name}': {ex.Message}");
                        }
                        finally
                        {
                            destBitmap.UnlockBits(destData);
                            rmBitmap.UnlockBits(rmData);
                            normalBitmap.UnlockBits(nrmData);
                            sourceMask.UnlockBits(srcMaskData);

                            if (microblendBmp != null && mbData != null)
                            {
                                microblendBmp.UnlockBits(mbData);
                            }

                            if (colorTexBmp != null && colorData != null)
                            {
                                colorTexBmp.UnlockBits(colorData);
                            }

                            if (roughTexBmp != null && roughData != null)
                            {
                                roughTexBmp.UnlockBits(roughData);
                            }

                            if (metalTexBmp != null && metalData != null)
                            {
                                metalTexBmp.UnlockBits(metalData);
                            }

                            if (normalTexBmp != null && ntexData != null)
                            {
                                normalTexBmp.UnlockBits(ntexData);
                            }

                            microblendBmp?.Dispose();
                            colorTexBmp?.Dispose();
                            roughTexBmp?.Dispose();
                            metalTexBmp?.Dispose();
                            normalTexBmp?.Dispose();
                        }

                        layerIndex++;
                    }
                }
                finally
                {
                    foreach (var bmp in texCache.Values)
                    {
                        bmp.Dispose();
                    }

                    foreach (var bmp in layerBitmaps)
                    {
                        bmp.Dispose();
                    }
                }


                // GlobalNormal
                if (dictionary.TryGetValue("GlobalNormal", out var gNormObj) &&
                    gNormObj is CResourceReference<ITexture> gNormRef &&
                    gNormRef.DepotPath != ResourcePath.Empty)
                {
                    Bitmap? gBmp = null;
                    try
                    {
                        var loaded = await LoadTextureAsBitmap(gNormRef.DepotPath);
                        if (loaded != null)
                        {
                            gBmp = (Bitmap)loaded.Clone();
                            loaded.Dispose();
                        }

                        if (gBmp != null)
                        {
                            var nRect = new Rectangle(0, 0, normalBitmap.Width, normalBitmap.Height);
                            var gRect = new Rectangle(0, 0, gBmp.Width, gBmp.Height);
                            var nData = normalBitmap.LockBits(nRect, ImageLockMode.ReadWrite,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            var gData = gBmp.LockBits(gRect, ImageLockMode.ReadOnly,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                            try
                            {
                                unsafe
                                {
                                    byte* nPtr = (byte*)nData.Scan0;
                                    byte* gPtr = (byte*)gData.Scan0;
                                    var nStride = nData.Stride;
                                    var gStride = gData.Stride;
                                    var gw = gBmp.Width;
                                    var gh = gBmp.Height;
                                    var nw = normalBitmap.Width;
                                    var nh = normalBitmap.Height;
                                    const float inv = 1f / 255f;
                                    const float strength = 1f;

                                    for (var y = 0; y < nh; y++)
                                    {
                                        var v = (y + 0.5f) / nh;
                                        var gy = (int)MathF.Floor(v * gh);
                                        if (gy < 0)
                                            gy = 0;
                                        else if (gy >= gh)
                                            gy = gh - 1;

                                        for (var x = 0; x < nw; x++)
                                        {
                                            var u = (x + 0.5f) / nw;
                                            var gx = (int)MathF.Floor(u * gw);
                                            if (gx < 0)
                                                gx = 0;
                                            else if (gx >= gw)
                                                gx = gw - 1;

                                            var go = (gy * gStride) + (gx * 4);
                                            var no = (y * nStride) + (x * 4);

                                            var nr = nPtr[no + 2] * inv;
                                            var ng = nPtr[no + 1] * inv;
                                            var gr = gPtr[go + 2] * inv;
                                            var gg = gPtr[go + 1] * inv;

                                            var or = Math.Clamp(nr + ((gr - 0.5f) * strength), 0f, 1f);
                                            var og = Math.Clamp(ng + ((gg - 0.5f) * strength), 0f, 1f);

                                            nPtr[no + 2] = (byte)(or * 255f);
                                            nPtr[no + 1] = (byte)(og * 255f);
                                        }
                                    }
                                }
                            }
                            finally
                            {
                                normalBitmap.UnlockBits(nData);
                                gBmp.UnlockBits(gData);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService()?.Warning($"GlobalNormal blend failed: {ex.Message}");
                    }
                    finally
                    {
                        gBmp?.Dispose();
                    }
                }


                try
                {
                    SavePngAtomic(destBitmap, filename_bd);
                }
                catch (Exception e)
                {
                    Parent?.GetLoggerService()?.Error(e.Message);
                }
                finally
                {
                    destBitmap.Dispose();
                }

                try
                {
                    SavePngAtomic(rmBitmap, filename_rm);
                }
                catch (Exception e)
                {
                    Parent?.GetLoggerService()?.Error(e.Message);
                }
                finally
                {
                    rmBitmap.Dispose();
                }

                try
                {
                    SavePngAtomic(normalBitmap, filename_bn);
                }
                catch (Exception e)
                {
                    Parent?.GetLoggerService()?.Error(e.Message);
                }
                finally
                {
                    normalBitmap.Dispose();
                }

                // Stamp the mlsetup hash so the next load can detect edits
                try
                {
                    File.WriteAllText(filename_bd + ".hash", ComputeMlsetupHash(mls));
                    File.WriteAllText(filename_bd + ".deps", ComputeGenericDepHash(dictionary));
                }
                catch { /* ignore */ }

            }

    #endregion

            #region Skin Shader / Hair / Makeup

            string? basePathForClass = null;
            if (material?.Instance is CMaterialInstance classInst &&
                classInst.BaseMaterial.DepotPath != ResourcePath.Empty)
            {
                basePathForClass = classInst.BaseMaterial.DepotPath.GetResolvedText();
            }
            var kind = ClassifyMaterial(material?.Name, basePathForClass);

            // === SKIN SHADER ===
            bool isSkin = Has(kind, MaterialKind.Skin);

            if (!isSkin && material?.Instance is CMaterialInstance skinInst)
            {
                var current = skinInst;
                for (int d = 0; d < 4 && current != null; d++)
                {
                    var basePath = current.BaseMaterial.DepotPath.GetResolvedText() ?? "";
                    if (basePath.Contains("skin.mt", StringComparison.OrdinalIgnoreCase) ||
                        basePath.Contains("character_mat_instance", StringComparison.OrdinalIgnoreCase))
                    {
                        isSkin = true;
                        break;
                    }
                    if (current.BaseMaterial.DepotPath == ResourcePath.Empty)
                        break;
                    if (basePath.EndsWith("skin.mt", StringComparison.OrdinalIgnoreCase))
                        break;
                    try
                    {
                        var baseFile = GetProjectOrDepotFile(current.BaseMaterial.DepotPath);
                        current = baseFile?.RootChunk as CMaterialInstance;
                    }
                    catch { break; }
                }
            }

            if (isSkin && !Has(kind, MaterialKind.Makeup) && !Has(kind, MaterialKind.Eye))
            {


                if (!dictionary.ContainsKey("Albedo") && material?.Instance is CMaterialInstance startInst)
                {
                    CMaterialInstance? current = startInst;
                    int depth = 0;
                    while (current != null && depth < 8)
                    {
                        var baseRef = current.BaseMaterial;
                        if (baseRef.DepotPath == ResourcePath.Empty)
                            break;

                        var basePath = baseRef.DepotPath.GetResolvedText() ?? "";
                        if (basePath.Contains("metal_base.remt", StringComparison.OrdinalIgnoreCase) ||
                            basePath.Contains("skin.mt", StringComparison.OrdinalIgnoreCase))
                            break;

                        try
                        {
                            var baseFile = GetProjectOrDepotFile(baseRef.DepotPath);
                            if (baseFile?.RootChunk is not CMaterialInstance next)
                                break;

                            foreach (var pair in next.Values)
                            {
                                var k = pair.Key.ToString().NotNull();
                                if (!dictionary.ContainsKey(k))
                                    dictionary[k] = pair.Value;
                            }

                            if (dictionary.ContainsKey("Albedo"))
                                break;

                            current = next;
                        }
                        catch
                        {
                            break;
                        }
                        depth++;
                    }
                }

                // BaseColor is alias for Albedo in metal_base.remt
                if (!dictionary.ContainsKey("Albedo") && dictionary.ContainsKey("BaseColor"))
                    dictionary["Albedo"] = dictionary["BaseColor"];



                if (dictionary.ContainsKey("Albedo"))
                {
                    try
                    {
                        Bitmap? albedoBmp = null;

                        // Albedo
                        if (dictionary.TryGetValue("Albedo", out var albObj) &&
                            albObj is CResourceReference<ITexture> albRef &&
                            albRef.DepotPath != ResourcePath.Empty)
                        {
                            try
                            {
                                var xbm = GetProjectOrDepotFile(albRef.DepotPath);
                                if (xbm?.RootChunk is ITexture it)
                                {
                                    using var stream = new MemoryStream();
                                    ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                    stream.Position = 0;
                                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                    if (bmpSource != null)
                                    {
                                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                            bmpSource.Freeze();
                                        albedoBmp = BitmapSourceToBitmap(bmpSource);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Parent?.GetLoggerService()?.Warning($"[Skin] Albedo load warning: {ex.Message}");
                            }
                        }

                        if (albedoBmp == null)
                        {
                            Parent?.GetLoggerService()?.Warning($"[Skin] Failed to load albedo bitmap for {material?.Name}");
                            return;
                        }

                        // TintColor
                        if (dictionary.TryGetValue("TintColor", out var tintObj) && tintObj is CColor tintCol)
                        {
                            float tintScale = 0.3f;
                            if (dictionary.TryGetValue("TintScale", out var scaleObj))
                            {
                                if (scaleObj is CFloat cf)
                                    tintScale = Math.Clamp((float)cf, 0f, 1f);
                                else if (scaleObj is float f)
                                    tintScale = Math.Clamp(f, 0f, 1f);
                            }

                            float tr = tintCol.Red / 255f;
                            float tg = tintCol.Green / 255f;
                            float tb = tintCol.Blue / 255f;

                            var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                            var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)data.Scan0;
                                    int stride = data.Stride;
                                    for (int y = 0; y < albedoBmp.Height; y++)
                                    {
                                        for (int x = 0; x < albedoBmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            ptr[off + 0] = (byte)(ptr[off + 0] * (1f - tintScale) + ptr[off + 0] * tb * tintScale);
                                            ptr[off + 1] = (byte)(ptr[off + 1] * (1f - tintScale) + ptr[off + 1] * tg * tintScale);
                                            ptr[off + 2] = (byte)(ptr[off + 2] * (1f - tintScale) + ptr[off + 2] * tr * tintScale);
                                        }
                                    }
                                }
                            }
                            finally { albedoBmp.UnlockBits(data); }
                        }

                        // SecondaryAlbedo
                        if (dictionary.TryGetValue("SecondaryAlbedo", out var secObj) &&
                            secObj is CResourceReference<ITexture> secRef &&
                            secRef.DepotPath != ResourcePath.Empty)
                        {
                            try
                            {
                                var xbm = GetProjectOrDepotFile(secRef.DepotPath);
                                if (xbm?.RootChunk is ITexture it)
                                {
                                    using var stream = new MemoryStream();
                                    ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                    stream.Position = 0;
                                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                    if (bmpSource != null)
                                    {
                                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                            bmpSource.Freeze();
                                        using var secBmp = BitmapSourceToBitmap(bmpSource);
                                        if (secBmp.Width == albedoBmp.Width && secBmp.Height == albedoBmp.Height)
                                        {
                                            float influence = 0.4f;
                                            if (dictionary.TryGetValue("SecondaryAlbedoInfluence", out var infObj))
                                            {
                                                if (infObj is CFloat cf)
                                                    influence = Math.Clamp((float)cf, 0f, 0.5f);
                                                else if (infObj is float f)
                                                    influence = Math.Clamp(f, 0f, 0.5f);
                                            }

                                            var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                                            var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                            var secData = secBmp.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                            try
                                            {
                                                unsafe
                                                {
                                                    byte* dst = (byte*)data.Scan0;
                                                    byte* src = (byte*)secData.Scan0;
                                                    int stride = data.Stride;
                                                    for (int y = 0; y < albedoBmp.Height; y++)
                                                    {
                                                        for (int x = 0; x < albedoBmp.Width; x++)
                                                        {
                                                            int off = y * stride + x * 4;
                                                            float a = (src[off + 3] / 255f) * influence;
                                                            dst[off + 0] = (byte)(dst[off + 0] * (1 - a) + src[off + 0] * a);
                                                            dst[off + 1] = (byte)(dst[off + 1] * (1 - a) + src[off + 1] * a);
                                                            dst[off + 2] = (byte)(dst[off + 2] * (1 - a) + src[off + 2] * a);
                                                        }
                                                    }
                                                }
                                            }
                                            finally
                                            {
                                                albedoBmp.UnlockBits(data);
                                                secBmp.UnlockBits(secData);
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Parent?.GetLoggerService()?.Warning($"[Skin] SecondaryAlbedo load warning: {ex.Message}");
                            }
                        }

                        // Save albedo
                        SavePngAtomic(albedoBmp, filename_bd);


                        // No Roughness
                        if (!dictionary.ContainsKey("Roughness") && material?.Instance is CMaterialInstance startInst2)
                        {
                            CMaterialInstance? current = startInst2;
                            int depth = 0;
                            while (current != null && depth < 8)
                            {
                                var baseRef = current.BaseMaterial;
                                if (baseRef.DepotPath == ResourcePath.Empty)
                                    break;
                                try
                                {
                                    var baseFile = GetProjectOrDepotFile(baseRef.DepotPath);
                                    if (baseFile?.RootChunk is not CMaterialInstance next)
                                        break;
                                    foreach (var pair in next.Values)
                                    {
                                        var k = pair.Key.ToString().NotNull();
                                        if (!dictionary.ContainsKey(k))
                                            dictionary[k] = pair.Value;
                                    }
                                    if (dictionary.ContainsKey("Roughness"))
                                        break;
                                    current = next;
                                }
                                catch { break; }
                                depth++;
                            }
                        }

                        // RoughnessMetalness
                        Bitmap? rmSource = null;
                        if (dictionary.TryGetValue("Roughness", out var roughObj) &&
                            roughObj is CResourceReference<ITexture> roughRef &&
                            roughRef.DepotPath != ResourcePath.Empty)
                        {
                            var pathText = roughRef.DepotPath.GetResolvedText() ?? "";
                            if (!pathText.Contains("placeholder"))
                            {
                                try
                                {
                                    var xbm = GetProjectOrDepotFile(roughRef.DepotPath);
                                    if (xbm?.RootChunk is ITexture it)
                                    {
                                        using var stream = new MemoryStream();
                                        ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                        stream.Position = 0;
                                        var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                        if (bmpSource != null)
                                        {
                                            if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                                bmpSource.Freeze();
                                            rmSource = BitmapSourceToBitmap(bmpSource);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Parent?.GetLoggerService()?.Warning($"[Skin] RM load warning: {ex.Message}");
                                }
                            }
                        }

                        using var rmBmp = new Bitmap(albedoBmp.Width, albedoBmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        var rmRect = new Rectangle(0, 0, rmBmp.Width, rmBmp.Height);
                        var rmData = rmBmp.LockBits(rmRect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        try
                        {
                            unsafe
                            {
                                byte* ptr = (byte*)rmData.Scan0;
                                int stride = rmData.Stride;

                                if (rmSource != null)
                                {
                                    var srcRect = new Rectangle(0, 0, rmSource.Width, rmSource.Height);
                                    var srcData = rmSource.LockBits(srcRect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                    try
                                    {
                                        byte* src = (byte*)srcData.Scan0;
                                        int srcStride = srcData.Stride;
                                        float scaleX = (float)rmSource.Width / rmBmp.Width;
                                        float scaleY = (float)rmSource.Height / rmBmp.Height;

                                        for (int y = 0; y < rmBmp.Height; y++)
                                        {
                                            for (int x = 0; x < rmBmp.Width; x++)
                                            {
                                                int sx = Math.Min((int)(x * scaleX), rmSource.Width - 1);
                                                int sy = Math.Min((int)(y * scaleY), rmSource.Height - 1);
                                                int srcOff = sy * srcStride + sx * 4;
                                                int off = y * stride + x * 4;

                                                byte roughness = src[srcOff + 2];
                                                byte metalness = src[srcOff + 1];

                                                ptr[off + 0] = 0;
                                                ptr[off + 1] = roughness;
                                                ptr[off + 2] = metalness;
                                                ptr[off + 3] = 255;
                                            }
                                        }
                                    }
                                    finally { rmSource.UnlockBits(srcData); }
                                    rmSource.Dispose();
                                }
                                else
                                {
                                    for (int y = 0; y < rmBmp.Height; y++)
                                        for (int x = 0; x < rmBmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            ptr[off + 0] = 0;
                                            ptr[off + 1] = 170;
                                            ptr[off + 2] = 0;
                                            ptr[off + 3] = 255;
                                        }
                                }
                            }
                        }
                        finally { rmBmp.UnlockBits(rmData); }

                        //RoughnessScale
                        float roughnessScale = 1f;
                        if (dictionary.TryGetValue("RoughnessScale", out var roughScaleObj))
                        {
                            if (roughScaleObj is CFloat cf)
                                roughnessScale = Math.Clamp((float)cf, 0f, 2f);
                            else if (roughScaleObj is float f)
                                roughnessScale = Math.Clamp(f, 0f, 2f);
                        }

                        if (roughnessScale != 1f)
                        {
                            var rmRect2 = new Rectangle(0, 0, rmBmp.Width, rmBmp.Height);
                            var rmData2 = rmBmp.LockBits(rmRect2, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)rmData2.Scan0;
                                    int stride = rmData2.Stride;
                                    for (int y = 0; y < rmBmp.Height; y++)
                                        for (int x = 0; x < rmBmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            ptr[off + 1] = (byte)Math.Clamp(ptr[off + 1] * roughnessScale, 0, 255);
                                        }
                                }
                            }
                            finally { rmBmp.UnlockBits(rmData2); }
                        }
                        SavePngAtomic(rmBmp, filename_rm);

                        albedoBmp.Dispose();

                        // Normal
                        if (dictionary.TryGetValue("Normal", out var normalObj) &&
                            normalObj is CResourceReference<ITexture> normalRef &&
                            normalRef.DepotPath != ResourcePath.Empty)
                        {
                            try
                            {
                                var xbm = GetProjectOrDepotFile(normalRef.DepotPath);
                                if (xbm?.RootChunk is ITexture it)
                                {
                                    using var stream = new MemoryStream();
                                    ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                    stream.Position = 0;
                                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                    if (bmpSource != null)
                                    {
                                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                            bmpSource.Freeze();
                                        using var bmp = BitmapSourceToBitmap(bmpSource);

                                        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                        var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                        try
                                        {
                                            unsafe
                                            {
                                                byte* ptr = (byte*)data.Scan0;
                                                int stride = data.Stride;
                                                for (int y = 0; y < bmp.Height; y++)
                                                {
                                                    for (int x = 0; x < bmp.Width; x++)
                                                    {
                                                        int off = y * stride + x * 4;
                                                        float nx = (ptr[off + 2] / 255f) * 2f - 1f;
                                                        float ny = (ptr[off + 1] / 255f) * 2f - 1f;
                                                        float nz = MathF.Sqrt(Math.Max(0f, 1f - nx * nx - ny * ny));
                                                        ny = -ny;

                                                        ptr[off + 2] = (byte)((nx * 0.5f + 0.5f) * 255f);
                                                        ptr[off + 1] = (byte)((ny * 0.5f + 0.5f) * 255f);
                                                        ptr[off + 0] = (byte)((nz * 0.5f + 0.5f) * 255f);
                                                    }
                                                }
                                            }
                                        }
                                        finally { bmp.UnlockBits(data); }

                                        SavePngAtomic(bmp, filename_bn);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Parent?.GetLoggerService()?.Warning($"[Skin] Normal load warning: {ex.Message}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService()?.Warning($"Skin material failed for '{material?.Name}': {ex.Message}");
                    }
                }
            }
            // === END SKIN SHADER ===

            // === FRECKLES / MAKEUP / BROWS ===

            if (Has(kind, MaterialKind.Makeup) || Has(kind, MaterialKind.Eyebrow))
            {

                try
                {
                    Bitmap? albedoBmp = null;

                    if (dictionary.TryGetValue("DiffuseTexture", out var diffObj) &&
                        diffObj is CResourceReference<ITexture> diffRef &&
                        diffRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(diffRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;

                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                albedoBmp = BitmapSourceToBitmap(bmpSource);
                            }
                        }
                    }

                    if (albedoBmp != null)
                    {
                        float tintR = 1f, tintG = 1f, tintB = 1f;
                        if (dictionary.TryGetValue("DiffuseColor", out var colObj) && colObj is CColor ccol)
                        {
                            tintR = ccol.Red / 255f;
                            tintG = ccol.Green / 255f;
                            tintB = ccol.Blue / 255f;
                        }

                        float diffuseAlpha = 0.6f;
                        if (dictionary.TryGetValue("DiffuseAlpha", out var alphaObj))
                        {
                            if (alphaObj is CFloat cf)
                                diffuseAlpha = (float)cf;
                            else if (alphaObj is float f)
                                diffuseAlpha = f;
                        }
                        diffuseAlpha = Math.Clamp(diffuseAlpha, 0f, 1f);

                        var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                        var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        try
                        {
                            unsafe
                            {
                                byte* ptr = (byte*)data.Scan0;
                                int stride = data.Stride;
                                for (int y = 0; y < albedoBmp.Height; y++)
                                {
                                    for (int x = 0; x < albedoBmp.Width; x++)
                                    {
                                        int off = y * stride + x * 4;
                                        float srcA = (ptr[off + 3] / 255f) * diffuseAlpha;

                                        ptr[off + 0] = (byte)Math.Min(255, ptr[off + 0] * tintB);
                                        ptr[off + 1] = (byte)Math.Min(255, ptr[off + 1] * tintG);
                                        ptr[off + 2] = (byte)Math.Min(255, ptr[off + 2] * tintR);
                                        ptr[off + 3] = (byte)(srcA * 255f);
                                    }
                                }
                            }
                        }
                        finally
                        {
                            albedoBmp.UnlockBits(data);
                        }

                        SavePngAtomic(albedoBmp, filename_bd);
                        albedoBmp.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Warning($"Freckles material failed for '{material?.Name}': {ex.Message}");
                }
            }
            // === END FRECKLES / MAKEUP / BROWS ===

            // === EYES / EYELASHES / EYESHADOW ===
            if (Has(kind, MaterialKind.Eye) && material?.Name != null)
            {

                if (material.Instance == null && _data is CMesh meshData)
                {
                    var rawName = material.Name;
                    var lastSep = rawName.LastIndexOf("__", StringComparison.Ordinal);
                    if (lastSep >= 0)
                        rawName = rawName.Substring(lastSep + 2);

                    var matIndex = -1;
                    for (int i = 0; i < meshData.MaterialEntries.Count; i++)
                    {
                        var entryName = meshData.MaterialEntries[i].Name.ToString() ?? "";
                        if (entryName.Contains(rawName, StringComparison.OrdinalIgnoreCase) ||
                            rawName.Contains(entryName, StringComparison.OrdinalIgnoreCase))
                        {
                            matIndex = i;
                            break;
                        }
                    }

                    if (matIndex >= 0 && meshData.LocalMaterialBuffer?.Materials != null &&
                        matIndex < meshData.LocalMaterialBuffer.Materials.Count)
                    {
                        if (meshData.LocalMaterialBuffer.Materials[matIndex] is CMaterialInstance localMi)
                        {
                            material.Instance = localMi;
                            Parent?.GetLoggerService()?.Info($"[Eye] Found local at index {matIndex}");
                        }
                    }
                }

                if (material.Instance is CMaterialInstance eyeChain)
                {
                    var current = eyeChain;
                    for (int d = 0; d < 4 && current != null; d++)
                    {
                        foreach (var kvp in current.Values)
                        {
                            var key = kvp.Key.GetResolvedText();
                            if (!string.IsNullOrEmpty(key) && !dictionary.ContainsKey(key))
                                dictionary[key] = kvp.Value;
                        }
                        if (current.BaseMaterial.DepotPath == ResourcePath.Empty)
                            break;
                        try
                        {
                            var bf = GetProjectOrDepotFile(current.BaseMaterial.DepotPath);
                            current = bf?.RootChunk as CMaterialInstance;
                        }
                        catch { break; }
                    }
                }

                var basePath = ((material.Instance as CMaterialInstance)?.BaseMaterial.DepotPath.GetResolvedText() ?? "").ToLowerInvariant();
                var name = material.Name.ToLowerInvariant();

                // Path takes priority over name (pasted_eyeMat2 can be lashes).
                bool isRealLashes = basePath.Contains("eyelash") || basePath.Contains("\\eyes\\eyelashes");
                bool isEyeShadow = !isRealLashes && (basePath.Contains("eyeshadow") || basePath.Contains("eye_wet") ||
                                                     name.Contains("wetness"));
                bool isEyeball = !isRealLashes && !isEyeShadow &&
                                 (basePath.Contains("eye_gradient") || basePath.Contains("eye_base") ||
                                  basePath.Contains("eyeball") || basePath.Contains("eye.mt") ||
                                  name.Contains("eyeball") || name.Contains("eye_mat") ||
                                  name.Contains("eyemat"));

                if (isRealLashes || isEyeShadow || isEyeball)
                {
                    try
                    {
                        Bitmap? albedoBmp = null;

                        if (isRealLashes)
                        {
                            if (dictionary.TryGetValue("Strand_Alpha", out var texObj) &&
                                texObj is CResourceReference<ITexture> texRef &&
                                texRef.DepotPath != ResourcePath.Empty)
                            {
                                var xbm = GetProjectOrDepotFile(texRef.DepotPath);
                                if (xbm?.RootChunk is ITexture it)
                                {
                                    using var stream = new MemoryStream();
                                    ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                    stream.Position = 0;
                                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                    if (bmpSource != null)
                                    {
                                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                            bmpSource.Freeze();
                                        albedoBmp = BitmapSourceToBitmap(bmpSource);
                                    }
                                }
                            }
                            if (albedoBmp != null)
                            {
                                var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                                var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                try
                                {
                                    unsafe
                                    {
                                        byte* ptr = (byte*)data.Scan0;
                                        int stride = data.Stride;
                                        for (int y = 0; y < albedoBmp.Height; y++)
                                            for (int x = 0; x < albedoBmp.Width; x++)
                                            {
                                                int off = y * stride + x * 4;
                                                byte lum = (byte)((ptr[off] + ptr[off + 1] + ptr[off + 2]) / 3);
                                                float alpha = lum / 255f;
                                                ptr[off + 0] = (byte)(18 * alpha);
                                                ptr[off + 1] = (byte)(14 * alpha);
                                                ptr[off + 2] = (byte)(10 * alpha);
                                                ptr[off + 3] = lum;
                                            }
                                    }
                                }
                                finally { albedoBmp.UnlockBits(data); }
                            }
                        }
                        else
                        {
                            string[] textureKeys = { "Albedo", "DiffuseTexture", "Mask" };
                            foreach (var key in textureKeys)
                            {
                                if (dictionary.TryGetValue(key, out var texObj) &&
                                    texObj is CResourceReference<ITexture> texRef &&
                                    texRef.DepotPath != ResourcePath.Empty)
                                {
                                    var xbm = GetProjectOrDepotFile(texRef.DepotPath);
                                    if (xbm?.RootChunk is ITexture it)
                                    {
                                        using var stream = new MemoryStream();
                                        ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                        stream.Position = 0;
                                        var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                        if (bmpSource != null)
                                        {
                                            if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                                bmpSource.Freeze();
                                            albedoBmp = BitmapSourceToBitmap(bmpSource);
                                            break;
                                        }
                                    }
                                }
                            }

                            if (albedoBmp != null && isEyeball &&
                                dictionary.TryGetValue("IrisColorGradient", out var irisGradObj) &&
                                irisGradObj is IRedRef irisGradRef &&
                                irisGradRef.DepotPath != ResourcePath.Empty)
                            {
                                try
                                {
                                    var gradFile = GetProjectOrDepotFile(irisGradRef.DepotPath);
                                    if (gradFile?.RootChunk is CGradient gradient)
                                    {
                                        var entries = new List<GradientEntry>();
                                        foreach (var e in gradient.GradientEntries)
                                            entries.Add(new GradientEntry(e.Value, e.Color.Red, e.Color.Green, e.Color.Blue));
                                        entries.Sort((a, b) => a.Value.CompareTo(b.Value));

                                        Bitmap? irisMask = null;
                                        if (dictionary.TryGetValue("IrisMask", out var maskObj) &&
                                            maskObj is CResourceReference<ITexture> maskRef &&
                                            maskRef.DepotPath != ResourcePath.Empty)
                                        {
                                            var xbm = GetProjectOrDepotFile(maskRef.DepotPath);
                                            if (xbm?.RootChunk is ITexture it)
                                            {
                                                using var stream = new MemoryStream();
                                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                                stream.Position = 0;
                                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                                if (bmpSource != null)
                                                {
                                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                                        bmpSource.Freeze();
                                                    irisMask = BitmapSourceToBitmap(bmpSource);
                                                }
                                            }
                                        }

                                        if (irisMask != null && entries.Count > 0)
                                        {
                                            ApplyIrisGradient(albedoBmp, irisMask, entries);
                                            irisMask.Dispose();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Parent?.GetLoggerService()?.Warning($"[Eye] Iris gradient failed: {ex.Message}");
                                }
                            }

                            if (albedoBmp != null && isEyeShadow &&
                                dictionary.TryGetValue("ShadowColor", out var colObj) && colObj is CColor ccol)
                            {
                                float tintR = ccol.Red / 255f, tintG = ccol.Green / 255f, tintB = ccol.Blue / 255f;
                                var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                                var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                try
                                {
                                    unsafe
                                    {
                                        byte* ptr = (byte*)data.Scan0;
                                        int stride = data.Stride;
                                        for (int y = 0; y < albedoBmp.Height; y++)
                                            for (int x = 0; x < albedoBmp.Width; x++)
                                            {
                                                int off = y * stride + x * 4;
                                                ptr[off + 0] = (byte)Math.Min(255, ptr[off + 0] * tintB);
                                                ptr[off + 1] = (byte)Math.Min(255, ptr[off + 1] * tintG);
                                                ptr[off + 2] = (byte)Math.Min(255, ptr[off + 2] * tintR);
                                            }
                                    }
                                }
                                finally { albedoBmp.UnlockBits(data); }
                            }
                        }

                        if (albedoBmp != null)
                        {
                            SavePngAtomic(albedoBmp, filename_bd);
                            albedoBmp.Dispose();
                        }

                        // Normal from template or instance
                        if (!File.Exists(filename_bn) &&
                            dictionary.TryGetValue("Normal", out var eyeNormObj) &&
                            eyeNormObj is CResourceReference<ITexture> eyeNormRef &&
                            eyeNormRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(eyeNormRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    using var bmp = BitmapSourceToBitmap(bmpSource);

                                    // Reconstruct Z into B like nails
                                    var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                    var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                    try
                                    {
                                        unsafe
                                        {
                                            byte* ptr = (byte*)data.Scan0;
                                            int stride = data.Stride;
                                            for (int y = 0; y < bmp.Height; y++)
                                                for (int x = 0; x < bmp.Width; x++)
                                                {
                                                    int off = y * stride + x * 4;
                                                    float nx = (ptr[off + 2] / 255f) * 2f - 1f;
                                                    float ny = (ptr[off + 1] / 255f) * 2f - 1f;
                                                    float nz = MathF.Sqrt(Math.Max(0f, 1f - nx * nx - ny * ny));
                                                    ny = -ny;
                                                    ptr[off + 2] = (byte)((nx * 0.5f + 0.5f) * 255f);
                                                    ptr[off + 1] = (byte)((ny * 0.5f + 0.5f) * 255f);
                                                    ptr[off + 0] = (byte)((nz * 0.5f + 0.5f) * 255f);
                                                }
                                        }
                                    }
                                    finally { bmp.UnlockBits(data); }

                                    SavePngAtomic(bmp, filename_bn);
                                }
                            }
                        }

                        // Roughness → RM map
                        if (!File.Exists(filename_rm) &&
                            dictionary.TryGetValue("Roughness", out var eyeRoughObj) &&
                            eyeRoughObj is CResourceReference<ITexture> eyeRoughRef &&
                            eyeRoughRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(eyeRoughRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    using var bmp = BitmapSourceToBitmap(bmpSource);
                                    // Force grayscale — roughness should not be tinted
                                    var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                    var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                    try
                                    {
                                        unsafe
                                        {
                                            byte* ptr = (byte*)data.Scan0;
                                            int stride = data.Stride;
                                            for (int y = 0; y < bmp.Height; y++)
                                                for (int x = 0; x < bmp.Width; x++)
                                                {
                                                    int off = y * stride + x * 4;
                                                    byte lum = (byte)(ptr[off + 2] * 0.3f + ptr[off + 1] * 0.59f + ptr[off] * 0.11f);
                                                    ptr[off + 0] = lum;
                                                    ptr[off + 1] = lum;
                                                    ptr[off + 2] = lum;
                                                }
                                        }
                                    }
                                    finally { bmp.UnlockBits(data); }
                                    SavePngAtomic(bmp, filename_rm);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService()?.Warning(
                            $"[Eye] Failed to bake '{material?.Name}': {ex.GetType().Name}: {ex.Message}");
                    }
                }
            }
            // === END EYES ===

            // === HAIR ===
            bool isHair = Has(kind, MaterialKind.Hair);

            // External materials loading
            if (isHair && material?.Instance == null && material?.Name != null)
            {
                CMesh? meshData = _data as CMesh;
                if (meshData == null)
                {
                    var meshName = material.Name;
                    var lastSepIdx = meshName.LastIndexOf("__", StringComparison.Ordinal);
                    if (lastSepIdx > 0)
                        meshName = meshName.Substring(0, lastSepIdx);
                    var folderName = meshName.Replace("_cap", "", StringComparison.OrdinalIgnoreCase);
                    var meshPath = $"base\\characters\\common\\hair\\{folderName}\\{meshName}.mesh";
                    try
                    {
                        var meshFile = GetProjectOrDepotFile(meshPath);
                        if (meshFile?.RootChunk is CMesh loadedMesh)
                            meshData = loadedMesh;
                    }
                    catch { }
                }
                if (meshData != null)
                {
                    var rawName = material.Name;
                    var lastSep = rawName.LastIndexOf("__", StringComparison.Ordinal);
                    if (lastSep >= 0)
                        rawName = rawName.Substring(lastSep + 2);
                    bool isCap = rawName.Contains("_cap", StringComparison.OrdinalIgnoreCase);
                    bool isShort = rawName.Contains("_short", StringComparison.OrdinalIgnoreCase) || rawName.Contains("_cards", StringComparison.OrdinalIgnoreCase);
                    var baseName = rawName
                        .Replace("_cards_short", "", StringComparison.OrdinalIgnoreCase)
                        .Replace("_cards", "", StringComparison.OrdinalIgnoreCase)
                        .Replace("_cap", "", StringComparison.OrdinalIgnoreCase)
                        .Replace("_short", "", StringComparison.OrdinalIgnoreCase);

                    CMaterialInstance? bestMatch = null;
                    foreach (var extRef in meshData.ExternalMaterials)
                    {
                        if (extRef.DepotPath == ResourcePath.Empty)
                            continue;
                        var extPath = extRef.DepotPath.GetResolvedText() ?? "";
                        var extName = Path.GetFileNameWithoutExtension(extPath);
                        if (!extName.Contains(baseName, StringComparison.OrdinalIgnoreCase))
                            continue;
                        bool extIsCap = extName.Contains("_cap", StringComparison.OrdinalIgnoreCase);
                        if ((isCap && extIsCap) || (!isCap && !extIsCap))
                        {
                            try
                            {
                                var extFile = GetProjectOrDepotFile(extRef.DepotPath);
                                if (extFile?.RootChunk is CMaterialInstance extInst)
                                {
                                    bestMatch = extInst;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }
                    if (bestMatch == null && meshData.PreloadExternalMaterials != null)
                    {
                        foreach (var preRef in meshData.PreloadExternalMaterials)
                        {
                            if (preRef.DepotPath == ResourcePath.Empty)
                                continue;
                            try
                            {
                                var preFile = GetProjectOrDepotFile(preRef.DepotPath);
                                if (preFile?.RootChunk is CMaterialInstance preInst)
                                {
                                    bestMatch = preInst;
                                    break;
                                }
                            }
                            catch { }
                        }
                    }
                    if (bestMatch != null)
                    {
                        material.Instance = bestMatch;
                    }
                }
            }

            if (isHair)
            {

                Dictionary<string, object> flatDict = new();
                void CollectFromMaterial(IMaterial? mat, int depth = 0)
                {
                    if (mat == null || depth > 8)
                        return;
                    if (mat is CMaterialInstance mi)
                    {
                        foreach (var kvp in mi.Values)
                        {
                            var key = kvp.Key.GetResolvedText();
                            if (!string.IsNullOrEmpty(key) && !flatDict.ContainsKey(key))
                                flatDict[key] = kvp.Value;
                        }
                        if (mi.BaseMaterial.DepotPath != ResourcePath.Empty)
                        {
                            try
                            {
                                var baseFile = GetProjectOrDepotFile(mi.BaseMaterial.DepotPath);
                                CollectFromMaterial(baseFile?.RootChunk as IMaterial, depth + 1);
                            }
                            catch { }
                        }
                    }
                }
                if (material?.Instance != null)
                    CollectFromMaterial(material.Instance);
                foreach (var kv in flatDict)
                    if (!dictionary.ContainsKey(kv.Key))
                        dictionary[kv.Key] = kv.Value;

                try
                {
                    Bitmap? idBmp = null;
                    Bitmap? gradBmp = null;
                    Bitmap? alphaBmp = null;
                    bool isCapMat = material?.Name?.Contains("_cap", StringComparison.OrdinalIgnoreCase) == true;

                    // === Load HairProfile ===
                    List<GradientEntry> idEntries = new();
                    List<GradientEntry> rootToTipEntries = new();

                    if (dictionary.TryGetValue("HairProfile", out var profileObj) &&
                        profileObj is IRedRef profileRef &&
                        profileRef.DepotPath != ResourcePath.Empty)
                    {
                        try
                        {
                            var profileFile = GetProjectOrDepotFile(profileRef.DepotPath);
                            if (profileFile?.RootChunk is CHairProfile hp)
                            {
                                foreach (var entry in hp.GradientEntriesID)
                                    idEntries.Add(new GradientEntry(entry.Value, entry.Color.Red, entry.Color.Green, entry.Color.Blue));
                                foreach (var entry in hp.GradientEntriesRootToTip)
                                    rootToTipEntries.Add(new GradientEntry(entry.Value, entry.Color.Red, entry.Color.Green, entry.Color.Blue));
                                idEntries.Sort((a, b) => a.Value.CompareTo(b.Value));
                                rootToTipEntries.Sort((a, b) => a.Value.CompareTo(b.Value));
                            }
                        }
                        catch (Exception ex)
                        {
                            Parent?.GetLoggerService()?.Warning($"[Hair] Profile failed: {ex.Message}");
                        }
                    }

                    // === Load Strand_ID ===
                    if (dictionary.TryGetValue("Strand_ID", out var idObj) &&
                        idObj is CResourceReference<ITexture> idRef && idRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(idRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;
                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                idBmp = BitmapSourceToBitmap(bmpSource);
                            }
                        }
                    }

                    // === Load Strand_Gradient ===
                    if (dictionary.TryGetValue("Strand_Gradient", out var gradObj) &&
                        gradObj is CResourceReference<ITexture> gradRef && gradRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(gradRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;
                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                gradBmp = BitmapSourceToBitmap(bmpSource);
                            }
                        }
                    }

                    // === Load color + alpha for hair cap ===
                    // DiffuseTexture = base color (gradient mixes with it)
                    // MaskTexture = coverage / alpha only
                    // If DiffuseTexture is a tiny placeholder, fall back to MaskTexture size for the bake
                    if (isCapMat)
                    {
                        Bitmap? diffuseBmp = null;
                        Bitmap? maskBmp = null;

                        // Load DiffuseTexture (color base)
                        if (dictionary.TryGetValue("DiffuseTexture", out var diffObj) &&
                            diffObj is CResourceReference<ITexture> diffRef && diffRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(diffRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    diffuseBmp = BitmapSourceToBitmap(bmpSource);
                                }
                            }
                        }

                        // Load MaskTexture (alpha / coverage)
                        if (dictionary.TryGetValue("MaskTexture", out var maskObj) &&
                            maskObj is CResourceReference<ITexture> maskRef && maskRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(maskRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    maskBmp = BitmapSourceToBitmap(bmpSource);
                                }
                            }
                        }

                        // Decide color base: prefer real DiffuseTexture; if it's a tiny placeholder, use MaskTexture size
                        const int placeholderMax = 32; // grey.xbm / white.xbm etc. are usually 1x1 or 16x16
                        bool diffuseIsPlaceholder = diffuseBmp != null &&
                                                    (diffuseBmp.Width <= placeholderMax && diffuseBmp.Height <= placeholderMax);

                        if (diffuseBmp != null && !diffuseIsPlaceholder)
                        {
                            idBmp?.Dispose();
                            idBmp = diffuseBmp;
                            diffuseBmp = null;
                        }
                        else if (maskBmp != null)
                        {
                            // Use mask as color canvas size (will be recolored by GradientMap)
                            idBmp?.Dispose();
                            idBmp = new Bitmap(maskBmp.Width, maskBmp.Height);
                            using (var g = Graphics.FromImage(idBmp))
                                g.Clear(Color.White);
                        }

                        // Alpha always from MaskTexture when available
                        if (maskBmp != null)
                        {
                            alphaBmp?.Dispose();
                            alphaBmp = maskBmp;
                            maskBmp = null;
                        }

                        diffuseBmp?.Dispose();
                    }

                    // === Load Alpha ===
                    string[] alphaKeys = isCapMat ? new[] { "MaskTexture", "Strand_Alpha" } : new[] { "Strand_Alpha", "MaskTexture" };
                    foreach (var key in alphaKeys)
                    {
                        if (dictionary.TryGetValue(key, out var aObj) &&
                            aObj is CResourceReference<ITexture> aRef && aRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(aRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    alphaBmp = BitmapSourceToBitmap(bmpSource);
#if DEBUG
                                    Parent?.GetLoggerService()?.Info($"[Hair] Loaded alpha from {key} for {material?.Name}");
#endif
                                    break;
                                }
                            }
                        }
                    }

                    if (isCapMat && alphaBmp == null)
                    {
                        Parent?.GetLoggerService()?.Warning($"[Hair] Cap material '{material?.Name}' has no MaskTexture / Strand_Alpha — alpha will be missing");
                    }

                    // === Apply gradients (not for cap) ===
                    // Matches hair.py: R-channel factor → Color Ramp, then Overlay = Multiply×2 / invert path
                    if (!isCapMat)
                    {
                        if (idBmp != null && idEntries.Count > 0)
                            ApplyColorRamp(idBmp, idEntries, gamma: 1f);
                        if (gradBmp != null && rootToTipEntries.Count > 0)
                            ApplyColorRamp(gradBmp, rootToTipEntries, gamma: 1f);
                    }

                    // === Create colorBmp ===
                    Bitmap? colorBmp = null;
                    if (idBmp != null && gradBmp != null && !isCapMat)
                    {
                        if (gradBmp.Width != idBmp.Width || gradBmp.Height != idBmp.Height)
                        {
                            var resized = new Bitmap(idBmp.Width, idBmp.Height);
                            using (var g = Graphics.FromImage(resized))
                                g.DrawImage(gradBmp, 0, 0, idBmp.Width, idBmp.Height);
                            gradBmp.Dispose();
                            gradBmp = resized;
                        }
                        // Overlay (matches Blender hair.py: Multiply then ×2, not Mix Overlay mode)
                        OverlayBitmaps(idBmp, gradBmp);
                        colorBmp = idBmp;
                        gradBmp.Dispose();

                        // Bake Hair Global Albedo ×0.6 into the texture (addon multiplies in the graph).
                        // Doing it here so brightness does not depend on whether AlbedoColor multiplies the map.
                        {
                            var albedoRect = new Rectangle(0, 0, colorBmp.Width, colorBmp.Height);
                            var albedoData = colorBmp.LockBits(albedoRect, ImageLockMode.ReadWrite,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* p = (byte*)albedoData.Scan0;
                                    int st = albedoData.Stride;
                                    const float k = 0.6f;
                                    for (int yy = 0; yy < colorBmp.Height; yy++)
                                        for (int xx = 0; xx < colorBmp.Width; xx++)
                                        {
                                            int o = yy * st + xx * 4;
                                            p[o + 0] = (byte)(p[o + 0] * k);
                                            p[o + 1] = (byte)(p[o + 1] * k);
                                            p[o + 2] = (byte)(p[o + 2] * k);
                                        }
                                }
                            }
                            finally { colorBmp.UnlockBits(albedoData); }
                        }
                    }
                    else
                    {
                        colorBmp = idBmp ?? gradBmp;
                    }

                    // === For cap: apply GradientMap to DiffuseTexture (or white canvas at mask size) ===
                    if (isCapMat && colorBmp != null)
                    {
                        // Keep the larger resolution between color base and MaskTexture
                        int targetW = colorBmp.Width;
                        int targetH = colorBmp.Height;

                        if (alphaBmp != null && alphaBmp.Width * alphaBmp.Height > targetW * targetH)
                        {
                            targetW = alphaBmp.Width;
                            targetH = alphaBmp.Height;
                        }

                        if (colorBmp.Width != targetW || colorBmp.Height != targetH)
                        {
                            var resizedColor = new Bitmap(targetW, targetH);
                            using (var g = Graphics.FromImage(resizedColor))
                                g.DrawImage(colorBmp, 0, 0, targetW, targetH);
                            colorBmp.Dispose();
                            colorBmp = resizedColor;
#if DEBUG
                            Parent?.GetLoggerService()?.Info(
                                $"[Hair] Cap '{material?.Name}' color resized to {targetW}x{targetH}");
#endif
                        }

                        // Gradient mixes with DiffuseTexture (or white base), not with the mask
                        if (dictionary.TryGetValue("GradientMap", out var gradMapObj) &&
                            gradMapObj is CResourceReference<ITexture> gradMapRef &&
                            gradMapRef.DepotPath != ResourcePath.Empty)
                        {
                            var xbm = GetProjectOrDepotFile(gradMapRef.DepotPath);
                            if (xbm?.RootChunk is ITexture it)
                            {
                                using var stream = new MemoryStream();
                                ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                                stream.Position = 0;
                                var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                                if (bmpSource != null)
                                {
                                    if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                        bmpSource.Freeze();
                                    using var gradMapBmp = BitmapSourceToBitmap(bmpSource);
                                    if (gradMapBmp.Width > 0)
                                    {
                                        ApplyGradientMapLookup(colorBmp, gradMapBmp);
                                    }
                                }
                            }
                        }

                        // Bake global albedo ×0.6 for caps too (same as haircards)
                        {
                            var albedoRect = new Rectangle(0, 0, colorBmp.Width, colorBmp.Height);
                            var albedoData = colorBmp.LockBits(albedoRect, ImageLockMode.ReadWrite,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* p = (byte*)albedoData.Scan0;
                                    int st = albedoData.Stride;
                                    const float k = 0.6f;
                                    for (int yy = 0; yy < colorBmp.Height; yy++)
                                        for (int xx = 0; xx < colorBmp.Width; xx++)
                                        {
                                            int o = yy * st + xx * 4;
                                            p[o + 0] = (byte)(p[o + 0] * k);
                                            p[o + 1] = (byte)(p[o + 1] * k);
                                            p[o + 2] = (byte)(p[o + 2] * k);
                                        }
                                }
                            }
                            finally { colorBmp.UnlockBits(albedoData); }
                        }
                    }

                    // === Apply alpha and save ===
                    if (colorBmp != null)
                    {
                        if (alphaBmp != null && (alphaBmp.Width != colorBmp.Width || alphaBmp.Height != colorBmp.Height))
                        {
                            var resized = new Bitmap(colorBmp.Width, colorBmp.Height);
                            using (var g = Graphics.FromImage(resized))
                                g.DrawImage(alphaBmp, 0, 0, colorBmp.Width, colorBmp.Height);
                            alphaBmp.Dispose();
                            alphaBmp = resized;
                        }

                        var rect = new Rectangle(0, 0, colorBmp.Width, colorBmp.Height);
                        var data = colorBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        BitmapData? alphaData = alphaBmp?.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        try
                        {
                            unsafe
                            {
                                byte* ptr = (byte*)data.Scan0;
                                byte* aPtr = alphaData != null ? (byte*)alphaData.Scan0 : null;
                                int stride = data.Stride;
                                // 4x4 Bayer matrix for haircard dither (outside the pixel loop)
                                ReadOnlySpan<int> bayer4 = stackalloc int[]
                                {
                                    0, 8, 2, 10,
                                    12, 4, 14, 6,
                                    3, 11, 1, 9,
                                    15, 7, 13, 5
                                };
                                for (int y = 0; y < colorBmp.Height; y++)
                                {
                                    for (int x = 0; x < colorBmp.Width; x++)
                                    {
                                        int off = y * stride + x * 4;
                                        byte a;
                                        if (aPtr != null)
                                        {
                                            if (isCapMat)
                                            {
                                                // Hair caps: MaskTexture.r is the coverage (matches Blender addon)
                                                a = aPtr[off + 2]; // R channel (BGRA)
                                            }
                                            else
                                            {
                                                // Haircards: Strand_Alpha.r (matches addon). Fall back to A or average if needed.
                                                byte alphaCh = aPtr[off + 3];
                                                if (alphaCh > 0 && alphaCh < 255)
                                                    a = alphaCh;
                                                else
                                                    a = aPtr[off + 2]; // R channel
                                            }
                                        }
                                        else
                                        {
                                            a = ptr[off + 3];
                                        }

                                        if (isCapMat)
                                        {
                                            // Direct coverage from MaskTexture.r
                                            float coverage = a / 255f;
                                            ptr[off + 3] = (byte)(coverage * 255f);
                                            if (coverage < 0.02f)
                                            {
                                                ptr[off + 0] = ptr[off + 1] = ptr[off + 2] = 0;
                                            }
                                        }
                                        else
                                        {
                                            // Haircards: hard alpha clip + ordered dither near the edge
                                            // (approximates EEVEE dither: softer silhouette, still binary alpha so no blend trails).
                                            float af = a / 255f;
                                            const float cutoff = 0.33f;
                                            int bi = (x & 3) + ((y & 3) << 2);
                                            float d = (bayer4[bi] / 15f) - 0.5f;
                                            float threshold = cutoff + d * 0.12f;
                                            af = af < threshold ? 0f : 1f;
                                            ptr[off + 3] = (byte)(af * 255f);
                                        }
                                    }
                                }
                            }
                        }
                        finally
                        {
                            colorBmp.UnlockBits(data);
                            if (alphaData != null)
                                alphaBmp!.UnlockBits(alphaData);
                        }

#if DEBUG
                        // Debug: report alpha stats for hair/cap so we can see if coverage was written
                        if (isCapMat)
                        {
                            int minA = 255, maxA = 0, sumA = 0, count = 0;
                            var dbgRect = new Rectangle(0, 0, colorBmp.Width, colorBmp.Height);
                            var dbgData = colorBmp.LockBits(dbgRect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* p = (byte*)dbgData.Scan0;
                                    int st = dbgData.Stride;
                                    for (int yy = 0; yy < colorBmp.Height; yy += 4)
                                        for (int xx = 0; xx < colorBmp.Width; xx += 4)
                                        {
                                            int o = yy * st + xx * 4;
                                            int aa = p[o + 3];
                                            if (aa < minA) minA = aa;
                                            if (aa > maxA) maxA = aa;
                                            sumA += aa;
                                            count++;
                                        }
                                }
                            }
                            finally { colorBmp.UnlockBits(dbgData); }
                            Parent?.GetLoggerService()?.Info(
                                $"[Hair] Cap '{material?.Name}' alpha min={minA} max={maxA} avg={(count > 0 ? sumA / count : 0)}");
                        }
#endif

                        SavePngAtomic(colorBmp, filename_bd);
                        colorBmp.Dispose();
                        alphaBmp?.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Warning($"[Hair] Failed: {ex.Message}");
                }
            }
            // === END HAIR ===

            // === NAILS ===
            if (Has(kind, MaterialKind.Nail))
            {
                try
                {
                    Bitmap? albedoBmp = null;

                    // == BaseColor ==
                    if (dictionary.TryGetValue("BaseColor", out var baseObj) &&
                        baseObj is CResourceReference<ITexture> baseRef &&
                        baseRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(baseRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;
                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                albedoBmp = BitmapSourceToBitmap(bmpSource);
                            }
                        }
                    }

                    // Normal
                    if (dictionary.TryGetValue("Normal", out var normObj) &&
                        normObj is CResourceReference<ITexture> normRef &&
                        normRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(normRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;
                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                using var bmp = BitmapSourceToBitmap(bmpSource);

                                var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                try
                                {
                                    unsafe
                                    {
                                        byte* ptr = (byte*)data.Scan0;
                                        int stride = data.Stride;
                                        for (int y = 0; y < bmp.Height; y++)
                                        {
                                            for (int x = 0; x < bmp.Width; x++)
                                            {
                                                int off = y * stride + x * 4;
                                                float nx = (ptr[off + 2] / 255f) * 2f - 1f;
                                                float ny = (ptr[off + 1] / 255f) * 2f - 1f;
                                                float nz = MathF.Sqrt(Math.Max(0f, 1f - nx * nx - ny * ny));
                                                ny = -ny;

                                                ptr[off + 2] = (byte)((nx * 0.5f + 0.5f) * 255f);
                                                ptr[off + 1] = (byte)((ny * 0.5f + 0.5f) * 255f);
                                                ptr[off + 0] = (byte)((nz * 0.5f + 0.5f) * 255f);
                                            }
                                        }
                                    }
                                }
                                finally { bmp.UnlockBits(data); }

                                SavePngAtomic(bmp, filename_bn);
                            }
                        }
                    }

                    // Roughness
                    if (dictionary.TryGetValue("Roughness", out var roughObj) &&
                        roughObj is CResourceReference<ITexture> roughRef &&
                        roughRef.DepotPath != ResourcePath.Empty)
                    {
                        var xbm = GetProjectOrDepotFile(roughRef.DepotPath);
                        if (xbm?.RootChunk is ITexture it)
                        {
                            using var stream = new MemoryStream();
                            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
                            stream.Position = 0;
                            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
                            if (bmpSource != null)
                            {
                                if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                    bmpSource.Freeze();
                                using var rmBmp = BitmapSourceToBitmap(bmpSource);
                                SavePngAtomic(rmBmp, filename_rm);
                            }
                        }
                    }

                    // BaseColorScale
                    if (albedoBmp != null && dictionary.TryGetValue("BaseColorScale", out var scaleObj))
                    {
                        float r = 1f, g = 1f, b = 1f;

                        var scaleType = scaleObj.GetType().Name;

                        if (scaleObj is Vector4 v4)
                        {
                            r = v4.X;
                            g = v4.Y;
                            b = v4.Z;
                        }

                        if (r != 1f || g != 1f || b != 1f)
                        {
                            var rect = new Rectangle(0, 0, albedoBmp.Width, albedoBmp.Height);
                            var data = albedoBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)data.Scan0;
                                    int stride = data.Stride;
                                    for (int y = 0; y < albedoBmp.Height; y++)
                                        for (int x = 0; x < albedoBmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            ptr[off + 0] = (byte)Math.Min(255, ptr[off + 0] * b);
                                            ptr[off + 1] = (byte)Math.Min(255, ptr[off + 1] * g);
                                            ptr[off + 2] = (byte)Math.Min(255, ptr[off + 2] * r);
                                        }
                                }
                            }
                            finally { albedoBmp.UnlockBits(data); }
                        }
                    }

                    if (albedoBmp != null)
                    {
                        SavePngAtomic(albedoBmp, filename_bd);
                        albedoBmp.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Warning($"[Nail] Failed: {ex.Message}");
                }
            }
            // === END NAILS ===

            #endregion

            #region diffuseMaps

        DiffuseMaps:

            // mesh_decal_wet_character: water droplets. DiffuseTexture is both
            // color and alpha mask; UVScale tiles it into fine drops.
            if (!File.Exists(filename_bd) &&
                material?.Instance is CMaterialInstance wetInst &&
                wetInst.BaseMaterial.DepotPath.GetResolvedText()?.Contains("mesh_decal_wet_character") == true &&
                dictionary.TryGetValue("DiffuseTexture", out var wetDiff) &&
                wetDiff is CResourceReference<ITexture> wetRef &&
                wetRef.DepotPath != ResourcePath.Empty)
            {
                try
                {
                    var wetXbm = GetProjectOrDepotFile(wetRef.DepotPath);
                    if (wetXbm?.RootChunk is ITexture wetIt)
                    {
                        using var wetStream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(wetIt, wetStream, out _, out var wetFmt, true);
                        wetStream.Position = 0;
                        var wetSrc = await ImageDecoder.RenderToBitmapImageDds(wetStream, wetFmt);
                        if (wetSrc != null)
                        {
                            if (wetSrc.CanFreeze && !wetSrc.IsFrozen)
                                wetSrc.Freeze();
                            using var srcBmp = BitmapSourceToBitmap(wetSrc);

                            float uvScaleX = 1f, uvScaleY = 1f;
                            if (dictionary.TryGetValue("UVScaleX", out var sx))
                                uvScaleX = Math.Max(1f, ReadFloat(sx));
                            if (dictionary.TryGetValue("UVScaleY", out var sy))
                                uvScaleY = Math.Max(1f, ReadFloat(sy));

                            int tilesX = (int)Math.Min(uvScaleX, 8);
                            int tilesY = (int)Math.Min(uvScaleY, 8);
                            int outW = srcBmp.Width * tilesX;
                            int outH = srcBmp.Height * tilesY;

                            using var tiled = new Bitmap(outW, outH, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            using (var g = Graphics.FromImage(tiled))
                            {
                                for (int ty = 0; ty < tilesY; ty++)
                                    for (int tx = 0; tx < tilesX; tx++)
                                        g.DrawImage(srcBmp, tx * srcBmp.Width, ty * srcBmp.Height);
                            }

                            // Use luminance as alpha (droplet coverage)
                            var rect = new Rectangle(0, 0, outW, outH);
                            var data = tiled.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)data.Scan0;
                                    int stride = data.Stride;
                                    for (int y = 0; y < outH; y++)
                                        for (int x = 0; x < outW; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            float lum = (ptr[off + 2] * 0.3f + ptr[off + 1] * 0.59f + ptr[off] * 0.11f) / 255f;
                                            ptr[off + 3] = (byte)(lum * 255f);
                                        }
                                }
                            }
                            finally { tiled.UnlockBits(data); }

                            SavePngAtomic(tiled, filename_bd);
                        }
                    }
                }
                catch { /* best-effort */ }
            }

            // Hair / cap already baked filename_bd (gradient + mask). Don't overwrite with
            // a template-default DiffuseTexture placeholder (grey.xbm → solid grey).
            if (!File.Exists(filename_bd) &&
                dictionary.TryGetValue("DiffuseTexture", out var diffuse) &&
                diffuse is CResourceReference<ITexture> crrd)
            {
                var xbm = GetProjectOrDepotFile(crrd.DepotPath);
                if (xbm?.RootChunk is ITexture it)
                {
                    try
                    {
                        using var pngStream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(it, pngStream, out _, out var fmt, true);
                        pngStream.Position = 0;
                        var bmpSource = await ImageDecoder.RenderToBitmapImageDds(pngStream, fmt);
                        if (bmpSource != null)
                        {
                            if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                bmpSource.Freeze();
                            var raw = BitmapSourceToBitmap(bmpSource);
                            var bmp = ExpandPlaceholder(raw);
                            // ExpandPlaceholder disposes raw when it replaces it
                            bool expanded = !ReferenceEquals(bmp, raw);

                            // DiffuseColor tint (mesh_decal). Preserve alpha — decals use it for coverage.
                            if (dictionary.TryGetValue("DiffuseColor", out var dcObj) && dcObj is CColor dc)
                            {
                                float dr = dc.Red / 255f, dg = dc.Green / 255f, db = dc.Blue / 255f;
                                if (dr < 0.99f || dg < 0.99f || db < 0.99f)
                                {
                                    var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                    var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                    try
                                    {
                                        unsafe
                                        {
                                            byte* ptr = (byte*)data.Scan0;
                                            int stride = data.Stride;
                                            for (int y = 0; y < bmp.Height; y++)
                                                for (int x = 0; x < bmp.Width; x++)
                                                {
                                                    int off = y * stride + x * 4;
                                                    ptr[off + 0] = (byte)(ptr[off + 0] * db);
                                                    ptr[off + 1] = (byte)(ptr[off + 1] * dg);
                                                    ptr[off + 2] = (byte)(ptr[off + 2] * dr);
                                                }
                                        }
                                    }
                                    finally { bmp.UnlockBits(data); }
                                }
                            }

                            // Mesh decals (stitches, zipper, etc.): coverage is often in MaskTexture.r.
                            // Multiply it into PNG alpha so IsTransparent doesn't punch holes.
                            await ApplyMaskCoverageToAlpha(bmp, dictionary);

                            SavePngAtomic(bmp, filename_bd);
                            bmp.Dispose();
                            if (!expanded)
                                raw.Dispose();
                        }
                    }
                    catch { /* best-effort */ }
                }
            }

            if (dictionary.TryGetValue("ParalaxTexture", out var paralax) &&
                paralax is CResourceReference<ITexture> crrp)
            {
                var xbm = GetProjectOrDepotFile(crrp.DepotPath);
                if (xbm?.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                // PNG only — no DDS cache
                try
                {
                    using var pngStream = new MemoryStream();
                    ModTools.ConvertRedClassToDdsStream(it, pngStream, out _, out var fmt, true);
                    pngStream.Position = 0;
                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(pngStream, fmt);
                    if (bmpSource != null)
                    {
                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                            bmpSource.Freeze();
                        using var bmp = BitmapSourceToBitmap(bmpSource);
                        SavePngAtomic(bmp, filename_bd);
                    }
                }
                catch { /* best-effort */ }
            }

            if (dictionary.TryGetValue("BaseColor", out var baseColorTex) &&
                baseColorTex is CResourceReference<ITexture> crrbc)
            {
                var xbm = GetProjectOrDepotFile(crrbc.DepotPath);
                if (xbm?.RootChunk is not ITexture it)
                {
                    goto NormalMaps;
                }

                // PNG only for preview
                try
                {
                    using var pngStream = new MemoryStream();
                    ModTools.ConvertRedClassToDdsStream(it, pngStream, out _, out var fmt, true);
                    pngStream.Position = 0;
                    var bmpSource = await ImageDecoder.RenderToBitmapImageDds(pngStream, fmt);
                    if (bmpSource != null)
                    {
                        if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                            bmpSource.Freeze();
                        using var bmp = BitmapSourceToBitmap(bmpSource);

                        // Apply BaseColorScale (e.g. nails use 0,0,0 for black)
                        if (dictionary.TryGetValue("BaseColorScale", out var scaleObj) && scaleObj is Vector4 v4)
                        {
                            if (v4.X != 1f || v4.Y != 1f || v4.Z != 1f)
                            {
                                var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                                var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                                try
                                {
                                    unsafe
                                    {
                                        byte* ptr = (byte*)data.Scan0;
                                        int stride = data.Stride;
                                        for (int y = 0; y < bmp.Height; y++)
                                            for (int x = 0; x < bmp.Width; x++)
                                            {
                                                int off = y * stride + x * 4;
                                                ptr[off + 0] = (byte)Math.Min(255, ptr[off + 0] * v4.Z);
                                                ptr[off + 1] = (byte)Math.Min(255, ptr[off + 1] * v4.Y);
                                                ptr[off + 2] = (byte)Math.Min(255, ptr[off + 2] * v4.X);
                                            }
                                    }
                                }
                                finally { bmp.UnlockBits(data); }
                            }
                        }

                        // Cutout (chains, fences): hard alpha clip.
                        // Binary alpha so soft edges don't halo on the body.
                        bool isChain = material?.Name?.Contains("chain", StringComparison.OrdinalIgnoreCase) == true;
                        if (isChain || dictionary.ContainsKey("AlphaThreshold"))
                        {
                            byte threshByte = 128;
                            if (dictionary.TryGetValue("AlphaThreshold", out var atObj))
                            {
                                float t = ReadFloat(atObj);
                                if (t > 0.001f && t < 0.99f)
                                    threshByte = (byte)(t * 255f);
                            }

                            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                            var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)data.Scan0;
                                    int stride = data.Stride;
                                    for (int y = 0; y < bmp.Height; y++)
                                        for (int x = 0; x < bmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            ptr[off + 3] = ptr[off + 3] >= threshByte ? (byte)255 : (byte)0;
                                        }
                                }
                            }
                            finally { bmp.UnlockBits(data); }
                        }

                        SavePngAtomic(bmp, filename_bd);
                    }
                }
                catch
                {

                }
            }

            // AdTexture (billboards / screens) → albedo. Skip Emissive/EmissiveMask for
            // regular decals so we don't overwrite the DiffuseTexture bake with a placeholder.
            if (!File.Exists(filename_bd) &&
                dictionary.TryGetValue("AdTexture", out var adTex) &&
                adTex is CResourceReference<ITexture> adRef &&
                adRef.DepotPath != ResourcePath.Empty)
            {
                var xbm = GetProjectOrDepotFile(adRef.DepotPath);
                if (xbm?.RootChunk is ITexture adIt)
                {
                    try
                    {
                        using var pngStream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(adIt, pngStream, out _, out var adFmt, true);
                        pngStream.Position = 0;
                        var bmpSource = await ImageDecoder.RenderToBitmapImageDds(pngStream, adFmt);
                        if (bmpSource != null)
                        {
                            if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
                                bmpSource.Freeze();
                            var raw = BitmapSourceToBitmap(bmpSource);
                            var bmp = ExpandPlaceholder(raw);
                            SavePngAtomic(bmp, filename_bd);
                            bmp.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService()?.Warning($"[Emissive] AdTexture failed: {ex.Message}");
                    }
                }
            }
            #endregion

            // Stamp dependency hash so hair profile / gradient / texture edits are detected
            try
            {
                if (File.Exists(filename_bd))
                    File.WriteAllText(filename_bd + ".deps", ComputeGenericDepHash(dictionary));
            }
            catch { /* ignore */ }

        NormalMaps:

            if (File.Exists(filename_bn))
            {
                goto SkipNormals;
            }

            // Extract normals for decals and metal_base; multilayer bake handles the rest
            string? basePathNorm = null;
            if (material?.Instance is CMaterialInstance normInst &&
                normInst.BaseMaterial.DepotPath != ResourcePath.Empty)
            {
                basePathNorm = normInst.BaseMaterial.DepotPath.GetResolvedText();
            }
            var matKind = ClassifyMaterial(material?.Name, basePathNorm);
            bool isMetalBaseMat = material?.Name?.Contains("chain", StringComparison.OrdinalIgnoreCase) == true ||
                                  material?.Name?.Contains("metal_base", StringComparison.OrdinalIgnoreCase) == true;
            if (!Has(matKind, MaterialKind.Decal) && !isMetalBaseMat)
            {
                goto SkipNormals;
            }

            // Decals / metal_base use "Normal" or "NormalTexture"
            object? normalRaw = null;
            if (dictionary.TryGetValue("NormalTexture", out var normalTex))
                normalRaw = normalTex;
            else if (dictionary.TryGetValue("Normal", out var normalObj))
                normalRaw = normalObj;

            if (normalRaw is CResourceReference<ITexture> decalNormalRef &&
                decalNormalRef.DepotPath != ResourcePath.Empty)
            {
                var xbm = GetProjectOrDepotFile(decalNormalRef.DepotPath);
                if (xbm?.RootChunk is ITexture it)
                {
                    try
                    {
                        using var stream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var fmt, true);
                        stream.Position = 0;

                        var bmpSrc = await ImageDecoder.RenderToBitmapImageDds(stream, fmt);
                        if (bmpSrc != null)
                        {
                            if (bmpSrc.CanFreeze && !bmpSrc.IsFrozen)
                                bmpSrc.Freeze();
                            var raw = BitmapSourceToBitmap(bmpSrc);
                            var bmp = ExpandPlaceholder(raw);
                            bool expanded = !ReferenceEquals(bmp, raw);

                            // Same as nails: reconstruct Z into B, flip Y → blue normal
                            var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
                            var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* ptr = (byte*)data.Scan0;
                                    int stride = data.Stride;
                                    for (int y = 0; y < bmp.Height; y++)
                                        for (int x = 0; x < bmp.Width; x++)
                                        {
                                            int off = y * stride + x * 4;
                                            float nx = (ptr[off + 2] / 255f) * 2f - 1f;
                                            float ny = (ptr[off + 1] / 255f) * 2f - 1f;
                                            float nz = MathF.Sqrt(Math.Max(0f, 1f - nx * nx - ny * ny));
                                            ny = -ny;

                                            ptr[off + 2] = (byte)((nx * 0.5f + 0.5f) * 255f);
                                            ptr[off + 1] = (byte)((ny * 0.5f + 0.5f) * 255f);
                                            ptr[off + 0] = (byte)((nz * 0.5f + 0.5f) * 255f);
                                        }
                                }
                            }
                            finally { bmp.UnlockBits(data); }

                            SavePngAtomic(bmp, filename_bn);
                            bmp.Dispose();
                            if (!expanded)
                                raw.Dispose();
                        }
                    }
                    catch
                    {
                        // best-effort
                    }
                }
            }

            // Bake RM if decal, zipper/stitch, or explicit roughness/metalness textures exist.
            bool needsRm = Has(matKind, MaterialKind.Decal) ||
                           material?.Name?.Contains("zipper", StringComparison.OrdinalIgnoreCase) == true ||
                           material?.Name?.Contains("stitch", StringComparison.OrdinalIgnoreCase) == true ||
                           dictionary.ContainsKey("RoughnessTexture") ||
                           dictionary.ContainsKey("Roughness") ||
                           dictionary.ContainsKey("MetalnessTexture") ||
                           dictionary.ContainsKey("Metalness");
            if (needsRm && !File.Exists(filename_rm))
            {
                try
                {
                    Bitmap? roughBmp = null;
                    Bitmap? metalBmp = null;

                    async Task<Bitmap?> LoadRef(string key)
                    {
                        if (!dictionary.TryGetValue(key, out var obj) ||
                            obj is not CResourceReference<ITexture> r ||
                            r.DepotPath == ResourcePath.Empty)
                            return null;
                        var xbm = GetProjectOrDepotFile(r.DepotPath);
                        if (xbm?.RootChunk is not ITexture itx)
                            return null;
                        using var stream = new MemoryStream();
                        ModTools.ConvertRedClassToDdsStream(itx, stream, out _, out var fmt, true);
                        stream.Position = 0;
                        var src = await ImageDecoder.RenderToBitmapImageDds(stream, fmt);
                        if (src == null)
                            return null;
                        if (src.CanFreeze && !src.IsFrozen)
                            src.Freeze();
                        return ExpandPlaceholder(BitmapSourceToBitmap(src));
                    }

                    if (dictionary.TryGetValue("RoughnessTexture", out _))
                        roughBmp = await LoadRef("RoughnessTexture");
                    if (dictionary.TryGetValue("MetalnessTexture", out _))
                        metalBmp = await LoadRef("MetalnessTexture");

                    // Canvas size: prefer real MetalnessTexture, ignore tiny placeholders (≤32)
                    const int placeholderMax = 32;
                    bool metalIsReal = metalBmp != null && metalBmp.Width > placeholderMax && metalBmp.Height > placeholderMax;
                    bool roughIsReal = roughBmp != null && roughBmp.Width > placeholderMax && roughBmp.Height > placeholderMax;

                    int w, h;
                    if (metalIsReal)
                    {
                        w = metalBmp!.Width;
                        h = metalBmp.Height;
                    }
                    else if (roughIsReal)
                    {
                        w = roughBmp!.Width;
                        h = roughBmp.Height;
                    }
                    else
                    {
                        // Both placeholders or missing — try DiffuseTexture size so cyberware keeps detail
                        w = Math.Max(roughBmp?.Width ?? 1, metalBmp?.Width ?? 1);
                        h = Math.Max(roughBmp?.Height ?? 1, metalBmp?.Height ?? 1);
                        if (dictionary.TryGetValue("DiffuseTexture", out var diffObj) &&
                            diffObj is CResourceReference<ITexture> diffRef &&
                            diffRef.DepotPath != ResourcePath.Empty)
                        {
                            var diffXbm = GetProjectOrDepotFile(diffRef.DepotPath);
                            if (diffXbm?.RootChunk is ITexture diffIt)
                            {
                                var redImg = RedImage.FromRedClass(diffIt);
                                if (redImg != null && redImg.Metadata.Width > placeholderMax)
                                {
                                    w = (int)redImg.Metadata.Width;
                                    h = (int)redImg.Metadata.Height;
                                }
                            }
                        }
                    }

#if DEBUG
                    Parent?.GetLoggerService()?.Info(
                        $"[Decal] RM '{material?.Name}' metal={metalBmp?.Width}x{metalBmp?.Height} rough={roughBmp?.Width}x{roughBmp?.Height} → {w}x{h}");
#endif

                    if (roughBmp != null || metalBmp != null || w > 1)
                    {
                        // mesh_decal: result = texture * scale + bias (matches template / addon)
                        static float ReadScalar(Dictionary<string, object> dict, string key, float fallback)
                        {
                            if (!dict.TryGetValue(key, out var obj))
                                return fallback;
                            if (obj is CFloat cf)
                                return (float)cf;
                            if (obj is float f)
                                return f;
                            if (obj is double d)
                                return (float)d;
                            return fallback;
                        }
                        float roughScale = ReadScalar(dictionary, "RoughnessScale", 1f);
                        float roughBias = ReadScalar(dictionary, "RoughnessBias", 0f);
                        float metalScale = ReadScalar(dictionary, "MetalnessScale", 1f);
                        float metalBias = ReadScalar(dictionary, "MetalnessBias", 0f);

                        using var rm = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                        Bitmap? roughScaled = roughBmp;
                        Bitmap? metalScaled = metalBmp;
                        if (roughBmp != null && (roughBmp.Width != w || roughBmp.Height != h))
                        {
                            roughScaled = new Bitmap(w, h);
                            using (var g = Graphics.FromImage(roughScaled))
                                g.DrawImage(roughBmp, 0, 0, w, h);
                        }
                        if (metalBmp != null && (metalBmp.Width != w || metalBmp.Height != h))
                        {
                            metalScaled = new Bitmap(w, h);
                            using (var g = Graphics.FromImage(metalScaled))
                                g.DrawImage(metalBmp, 0, 0, w, h);
                        }

                        var rect = new Rectangle(0, 0, w, h);
                        var rmData = rm.LockBits(rect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        BitmapData? rData = roughScaled?.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        BitmapData? mData = metalScaled?.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        try
                        {
                            unsafe
                            {
                                byte* rmPtr = (byte*)rmData.Scan0;
                                byte* rPtr = rData != null ? (byte*)rData.Scan0 : null;
                                byte* mPtr = mData != null ? (byte*)mData.Scan0 : null;
                                int rmStride = rmData.Stride;
                                int rStride = rData?.Stride ?? 0;
                                int mStride = mData?.Stride ?? 0;
                                for (int y = 0; y < h; y++)
                                {
                                    for (int x = 0; x < w; x++)
                                    {
                                        int o = y * rmStride + x * 4;
                                        // Roughness: G channel * scale + bias (default 0.5)
                                        float rough = 0.5f;
                                        if (rPtr != null)
                                            rough = rPtr[y * rStride + x * 4 + 1] / 255f;
                                        rough = Math.Clamp(rough * roughScale + roughBias, 0f, 1f);
                                        // Metalness: B channel * scale + bias (default 0)
                                        float metal = 0f;
                                        if (mPtr != null)
                                            metal = mPtr[y * mStride + x * 4 + 0] / 255f;
                                        metal = Math.Clamp(metal * metalScale + metalBias, 0f, 1f);
                                        rmPtr[o + 0] = (byte)(metal * 255f); // B metal
                                        rmPtr[o + 1] = (byte)(rough * 255f); // G rough
                                        rmPtr[o + 2] = 0;
                                        rmPtr[o + 3] = 255;
                                    }
                                }
                            }
                        }
                        finally
                        {
                            rm.UnlockBits(rmData);
                            if (rData != null)
                                roughScaled!.UnlockBits(rData);
                            if (mData != null)
                                metalScaled!.UnlockBits(mData);
                        }

                        SavePngAtomic(rm, filename_rm);
                        if (roughScaled != roughBmp)
                            roughScaled?.Dispose();
                        if (metalScaled != metalBmp)
                            metalScaled?.Dispose();
                        roughBmp?.Dispose();
                        metalBmp?.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Warning($"[Decal] RM bake failed: {ex.Message}");
                }
            }

            #region skipNormals

        SkipNormals:
            // Remove zero-size files left by materials without real textures (e.g. splineModeling fallback)
            foreach (var f in new[] { filename_bd, filename_bn, filename_rm })
            {
                try
                {
                    if (File.Exists(f) && new FileInfo(f).Length == 0)
                        File.Delete(f);
                }
                catch { /* ignore */ }
            }

            #endregion
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService().Error($"Failed to load material '{material?.Name}': {ex.Message}");
        }
    }

    /** Set default roughness values for material */
    private static void adjustRoughness(Dictionary<string, object> dictionary, Material material)
    {
        material.Values = dictionary;

        if (dictionary.TryGetValue("Metalness", out var metalness) && metalness is CResourceReference<ITexture> metalTexture)
        {
            var metalPath = metalTexture.DepotPath.GetResolvedText() ?? "";
            if (metalPath.Contains("black", StringComparison.OrdinalIgnoreCase))
                material.Metalness = 0;
            else if (metalPath.Contains("white", StringComparison.OrdinalIgnoreCase))
                material.Metalness = 1;
            else if (metalPath.Contains("grey", StringComparison.OrdinalIgnoreCase) || metalPath.Contains("gray", StringComparison.OrdinalIgnoreCase))
                material.Metalness = 0.5f;
        }

        if (dictionary.TryGetValue("MetalnessScale", out var metalnessScale))
        {
            material.Metalness = ReadFloat(metalnessScale);
        }

        if (dictionary.TryGetValue("Roughness", out var roughness) && roughness is CResourceReference<ITexture> roughTexture)
        {
            var roughPath = roughTexture.DepotPath.GetResolvedText() ?? "";
            if (roughPath.Contains("black", StringComparison.OrdinalIgnoreCase))
                material.Roughness = 0;
            else if (roughPath.Contains("white", StringComparison.OrdinalIgnoreCase))
                material.Roughness = 1;
            else if (roughPath.Contains("grey", StringComparison.OrdinalIgnoreCase) || roughPath.Contains("gray", StringComparison.OrdinalIgnoreCase))
                material.Roughness = 0.5f;
        }

        if (dictionary.TryGetValue("RoughnessScale", out var roughnessScale))
        {
            material.Roughness = ReadFloat(roughnessScale);
        }
    }

    public byte ToBlue(byte r, byte g)
    {
        float x = r / 255f * 2f - 1f;
        float y = g / 255f * 2f - 1f;
        float z2 = 1f - x * x - y * y;
        float z = z2 > 0f ? MathF.Sqrt(z2) : 0f;
        return (byte)Math.Clamp(Math.Round((z + 1f) / 2f * 255f), 0, 255);
    }

    /// <summary>
    /// Blender mask_mixer: safeC = max(c,1e-5), burn = mask+mb-1,
    /// mixed = lerp(burn, mask, safeC), out = saturate(mixed / safeC).
    /// contrast=0 thresholds the microblend pattern.
    /// </summary>
    private static float ApplyMicroblendContrast(float mask, float mbAlpha, float contrast)
    {
        var safeC = Math.Max(contrast, 1e-5f);
        var burn = mask + mbAlpha - 1f;
        var mixed = burn + ((mask - burn) * safeC);
        return Math.Clamp(mixed / safeC, 0f, 1f);
    }

    static bool IsNullOverrideKey(CName n) =>
    n == CName.Empty || n == "null" || n == "None" || n == "null_null";

    static T? FindOverride<T>(IList<T>? list, CName key, Func<T, CName> nameOf) where T : class
    {
        if (list == null)
        {
            return null;
        }

        foreach (var item in list)
        {
            if (item != null && nameOf(item) == key)
            {
                return item;
            }
        }

        if (!IsNullOverrideKey(key))
        {
            return null;
        }

        foreach (var item in list)
        {
            if (item != null && IsNullOverrideKey(nameOf(item)))
            {
                return item;
            }
        }

        return null;
    }


    /// <summary>
    /// Reads levels (scale, offset) from an override list with proper null-key fallback.
    /// Returns identity (1, 0) when nothing is found.
    /// Works with CArrayFixedSize<CFloat> (or any type with Count + indexer castable to float).
    /// </summary>
    static void TryGetLevels<T>(IList<T>? list, CName key, Func<T, CName> nameOf, Func<T, object?> getVec,
                                 out float scale, out float offset) where T : class
    {
        scale = 1f;
        offset = 0f;

        var ov = FindOverride(list, key, nameOf);
        if (ov == null && list != null && list.Count > 0)
        {
            // Fallback to first null-like entry or first entry
            ov = list.FirstOrDefault(x => x != null && IsNullOverrideKey(nameOf(x))) ?? list[0];
        }

        if (ov == null)
            return;

        var vecObj = getVec(ov);
        if (vecObj is System.Collections.IList vec && vec.Count >= 2)
        {
            scale = ToFloat(vec[0]);
            offset = ToFloat(vec[1]);
        }

        static float ToFloat(object? o)
        {
            if (o == null)
                return 0f;
            if (o is CFloat cf)
                return (float)cf;
            if (o is float f)
                return f;
            if (o is double d)
                return (float)d;
            if (o is int i)
                return i;
            if (o is IConvertible ic)
                return Convert.ToSingle(ic);
            return 0f;
        }
    }

    private static float ReadFloat(object? obj)
    {
        if (obj is CFloat cf)
            return (float)cf;
        if (obj is float f)
            return f;
        if (obj is double d)
            return (float)d;
        if (obj is int i)
            return i;
        if (obj is CInt32 ci)
            return (int)ci;
        if (obj is string s && float.TryParse(s, out var parsed))
            return parsed;
        return 0f;
    }

    private static float Lerp(float a, float b, float t) => a + ((b - a) * t);

    private static Bitmap BitmapSourceToBitmap(BitmapSource src)
    {
        if (src.CanFreeze && !src.IsFrozen)
        {
            src.Freeze();
        }

        return CopyFrozenToGdi(src);
    }

    private static Bitmap CopyFrozenToGdi(BitmapSource src)
    {
        var w = src.PixelWidth;
        var h = src.PixelHeight;
        if (w <= 0 || h <= 0)
            return new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        var stride = w * 4;
        var bits = new byte[stride * h];

        if (src.Format != PixelFormats.Bgra32)
        {
            var conv = new FormatConvertedBitmap();
            conv.BeginInit();
            conv.Source = src;
            conv.DestinationFormat = PixelFormats.Bgra32;
            conv.EndInit();
            if (conv.CanFreeze)
            {
                conv.Freeze();
            }

            conv.CopyPixels(bits, stride, 0);
        }
        else
        {
            src.CopyPixels(bits, stride, 0);
        }

        var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly,
            System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
        }
        finally
        {
            bmp.UnlockBits(data);
        }

        return bmp;
    }

    private async Task<Bitmap?> LoadTextureAsBitmap(ResourcePath depotPath)
    {
        if (depotPath == ResourcePath.Empty)
        {
            return null;
        }

        try
        {
            var file = GetProjectOrDepotFile(depotPath);
            if (file?.RootChunk is not ITexture it)
            {
                return null;
            }

            using var stream = new MemoryStream();
            ModTools.ConvertRedClassToDdsStream(it, stream, out _, out var format, true);
            stream.Position = 0;

            var bmpSource = await ImageDecoder.RenderToBitmapImageDds(stream, format);
            if (bmpSource == null)
            {
                return null;
            }

            if (bmpSource.CanFreeze && !bmpSource.IsFrozen)
            {
                bmpSource.Freeze();
            }

            return ExpandPlaceholder(BitmapSourceToBitmap(bmpSource));
        }
        catch (Exception ex)
        {
            _loggerService.Warning($"Failed to load microblend/texture {depotPath}: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Tiny solid placeholders (4x4 / 16x16 / 32x32 black/white/grey/normal)
    /// get edge artifacts when upscaled. Replace them with a solid 1024x1024
    /// of the same color, matching the Blender workflow.
    /// </summary>
    private static Bitmap ExpandPlaceholder(Bitmap bmp)
    {
        const int placeholderMax = 32;
        const int target = 1024;
        if (bmp.Width > placeholderMax || bmp.Height > placeholderMax)
            return bmp;

        // Sample center and a few corners; if they differ a lot it's not a solid placeholder
        var c = bmp.GetPixel(bmp.Width / 2, bmp.Height / 2);
        var tl = bmp.GetPixel(0, 0);
        var br = bmp.GetPixel(bmp.Width - 1, bmp.Height - 1);
        int Diff(Color a, Color b) =>
            Math.Abs(a.R - b.R) + Math.Abs(a.G - b.G) + Math.Abs(a.B - b.B);
        if (Diff(c, tl) > 24 || Diff(c, br) > 24)
            return bmp;

        var solid = new Bitmap(target, target, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using (var g = Graphics.FromImage(solid))
        using (var brush = new SolidBrush(c))
            g.FillRectangle(brush, 0, 0, target, target);
        bmp.Dispose();
        return solid;
    }

    #region meshpreviewsector

    public partial class MeshComponentSelector : ObservableObject
    {
        private const string s_noSelection = "No_Selection";

        public string Name
        {
            get => _name;
            private set => SetProperty(ref _name, value);
        }

        public string WorldNodeIndex
        {
            get => _worldNodeIndex;
            private set => SetProperty(ref _worldNodeIndex, value);
        }

        public bool IsValid
        {
            get => _isValid;
            private set => SetProperty(ref _isValid, value);
        }

        private MeshComponent? _meshComponent;
        private string _name = s_noSelection;
        private string _worldNodeIndex = string.Empty;
        private bool _isValid;

        public MeshComponent? SelectedMesh
        {
            get => _meshComponent;
            set
            {
                _meshComponent = value;
                Name = value == null ? s_noSelection : value.Name.StartsWith("_") ? value.Name[1..] : value.Name;
                WorldNodeIndex = value == null ? string.Empty : "[" + value.WorldNodeIndex + "]";
                IsValid = value != null;
            }
        }

        public void Unselect() => SelectedMesh = null;
    }

    [ObservableProperty] private MeshComponentSelector _currentSelection = new();



    public void RenderSectorSolo()
    {
        RetoreSelectedMeshMaterial();
        CurrentSelection = new();
        if (IsRendered)
        {
            return;
        }
        IsRendered = true;
        if (_data is worldStreamingSector wss)
        {
            RenderSector(wss, Appearances[0]);
        }
    }

    public SectorGroup RenderSector(worldStreamingSector data, Appearance app)
    {
        if (data.NodeData.Data is not worldNodeDataBuffer buffer)
        {
            throw new ArgumentNullException();
        }

        var ssTransforms = buffer.Lookup;

        var groups = new List<Element3D>();
        foreach (var (handleIndex, transforms) in ssTransforms)
        {
            var handle = data.Nodes[(int)handleIndex].NotNull();
            var name = handle.Chunk.NotNull().DebugName.ToString().NotNull();
            name = "_" + name.Replace(" ", "_").Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "").Replace("\\", "_").Replace(".", "_").Replace("!", "").Replace("-", "_") ?? "none";

            var indexStr = string.Join(", ", transforms.Select(x => buffer.IndexOf(x)));
            var typeStr = handle.Chunk.GetType().Name;

            if (handle.Chunk is IRedMeshNode irmn)
            {
                var meshFile = GetProjectOrDepotFile(irmn.Mesh.DepotPath);

                if (meshFile == null || meshFile.RootChunk is not CMesh mesh)
                {
                    continue;
                }

                var appMaterials = GetMaterialsForAppearance(mesh, irmn.MeshAppearance);

                var group = new MeshComponent()
                {
                    Name = name,
                    Text = name,
                    WorldNodeIndex = $"{handleIndex}",
                    WorldNodeType = typeStr,
                    WorldNodeDataIndices = indexStr,
                    AppearanceName = irmn.MeshAppearance,
                    DepotPath = irmn.Mesh.DepotPath
                };

                if (group.WorldNodeIndex == SelectedNodeIndex)
                {
                    SelectedItem = group;
                }

                var model = new LoadableModel(name)
                {
                    MeshFile = Parent?.Cr2wFile,
                    AppearanceIndex = 0,
                    AppearanceName = irmn.MeshAppearance,
                    Materials = appMaterials,
                    IsEnabled = true,
                };

                foreach (var material in model.Materials)
                {
                    app.RawMaterials[material.Name] = material;
                }

                if (handle.Chunk is worldInstancedMeshNode wimn)
                {
                    if (wimn.CookedWorldTransformsBuffer.Buffer.Data is not WorldTransformsBuffer wtb)
                    {
                        continue;
                    }

                    for (var i = 0; i < wtb.Transforms.Count; i++)
                    {
                        var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                        var subgroup = new MeshComponent()
                        {
                            Name = name + $"_instance_{i:D2}",
                            Text = name + $"_instance_{i:D2}",
                            //AppearanceName = wimn.MeshAppearance,
                            DepotPath = irmn.Mesh.DepotPath
                        };

                        foreach (var submesh in meshes)
                        {
                            if (!app.LODLUT.ContainsKey(submesh.LOD))
                            {
                                app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                            }
                            app.LODLUT[submesh.LOD].Add(submesh);
                            subgroup.Children.Add(submesh);
                        }

                        var matrix = new Matrix3D();
                        matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                        matrix.Rotate(ToQuaternion(transforms[0].Transform.Orientation));
                        matrix.Translate(ToVector3D(transforms[0].Transform.Position));

                        var wtbMatrix = new Matrix3D();
                        if (wtb.Transforms[i] is { } wte)
                        {
                            wtbMatrix.Scale(ToScaleVector3D(wte.Scale));
                        }

                        var transform = wtb.Transforms[i].NotNull();
                        wtbMatrix.Rotate(ToQuaternion(transform.Transform.Orientation));
                        wtbMatrix.Translate(ToVector3D(transform.Transform.Position));

                        wtbMatrix.Append(matrix);

                        subgroup.Transform = new MatrixTransform3D(wtbMatrix);

                        group.Children.Add(subgroup);
                    }
                }
                else if (handle.Chunk is worldInstancedDestructibleMeshNode widmn)
                {
                    for (var i = 0; i < widmn.InstanceTransforms.Count; i++)
                    {
                        //for (int j = 0; j < transforms.Count; j++)
                        //{
                        var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                        var subgroup = new MeshComponent()
                        {
                            Name = name + $"_instance_{i:D2}",
                            Text = name + $"_instance_{i:D2}",
                            AppearanceName = widmn.MeshAppearance,
                            DepotPath = irmn.Mesh.DepotPath
                        };

                        foreach (var submesh in meshes)
                        {
                            if (!app.LODLUT.ContainsKey(submesh.LOD))
                            {
                                app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                            }
                            app.LODLUT[submesh.LOD].Add(submesh);
                            subgroup.Children.Add(submesh);
                        }

                        var matrix = new Matrix3D();
                        matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                        matrix.Rotate(ToQuaternion(transforms[0].Transform.Orientation));
                        matrix.Translate(ToVector3D(transforms[0].Transform.Position));

                        var citbMatrix = new Matrix3D();
                        var transform = widmn.InstanceTransforms[i].NotNull();
                        citbMatrix.Rotate(ToQuaternion(transform.Orientation));
                        citbMatrix.Translate(ToVector3D(transform.Position));

                        citbMatrix.Append(matrix);

                        subgroup.Transform = new MatrixTransform3D(citbMatrix);

                        group.Children.Add(subgroup);
                        //}
                    }
                }
                else
                {
                    var i = 0;
                    foreach (var transform in transforms)
                    {
                        var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                        var subgroup = new MeshComponent()
                        {
                            Name = name + $"_instance_{i:D2}",
                            Text = name + $"_instance_{i:D2}",
                            AppearanceName = irmn.MeshAppearance,
                            DepotPath = irmn.Mesh.DepotPath
                        };

                        foreach (var submesh in meshes)
                        {
                            if (!app.LODLUT.ContainsKey(submesh.LOD))
                            {
                                app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                            }
                            app.LODLUT[submesh.LOD].Add(submesh);
                            subgroup.Children.Add(submesh);
                        }

                        var matrix = new Matrix3D();
                        matrix.Scale(ToScaleVector3D(transform.Scale));
                        matrix.Rotate(ToQuaternion(transform.Transform.Orientation));
                        matrix.Translate(ToVector3D(transform.Transform.Position));

                        if (irmn is worldBendedMeshNode wbmn)
                        {
                            //matrix.Append(ToMatrix3D(wbmn.DeformationData[i]));
                        }

                        subgroup.Transform = new MatrixTransform3D(matrix);

                        group.Children.Add(subgroup);
                        i++;
                    }
                }

                groups.Add(group);
            }
            else if (handle.Chunk is worldCollisionNode wcn)
            {
                if (wcn.CompiledData.Data is not CollisionBuffer cb)
                {
                    continue;
                }

                var mesh = new MeshComponent()
                {
                    WorldNodeIndex = $"{handleIndex}",
                    WorldNodeType = typeStr,
                    WorldNodeDataIndices = indexStr,
                    Name = "collisionNode_" + wcn.SectorHash,
                    Text = "collisionNode_" + wcn.SectorHash
                };

                if (mesh.WorldNodeIndex == SelectedNodeIndex)
                {
                    SelectedItem = mesh;
                }

                var colliderMaterial = new PBRMaterial()
                {
                    EnableAutoTangent = true,
                    RenderShadowMap = true,
                    RenderEnvironmentMap = true,
                    //AlbedoColor = new SharpDX.Color4(0.5f * Random.Shared.NextSingle(), 0f, 0.5f * Random.Shared.NextSingle(), 1f),
                    AlbedoColor = new SharpDX.Color4(0.5f, 0f, 0.5f, 1f),
                    RoughnessFactor = 0.5,
                    MetallicFactor = 0
                };

                for (var k = 0; k < cb.Actors.Count; k++)
                {
                    var actor = cb.Actors[k];

                    var actorGroup = new MeshComponent()
                    {
                        WorldNodeIndex = $"{handleIndex}",
                        WorldNodeType = typeStr,
                        WorldNodeDataIndices = indexStr,
                        Name = "actor_" + cb.Actors.IndexOf(actor),
                        Text = "actor_" + cb.Actors.IndexOf(actor),
                        CollisionActorId = $"{k}"
                    };

                    if (mesh.WorldNodeIndex == SelectedNodeIndex)
                    {
                        SelectedItem = mesh;
                    }

                    foreach (var shape in actor.Shapes)
                    {
                        HelixToolkit.SharpDX.Core.MeshGeometry3D? geometry = null;

                        if (shape is CollisionShapeSimple simpleShape && simpleShape.ShapeType == Enums.physicsShapeType.Box)
                        {
                            var mb = new MeshBuilder
                            {
                                CreateNormals = true
                            };
                            mb.AddBox(new SharpDX.Vector3(0f, 0f, 0f), simpleShape.Size.X * 2, simpleShape.Size.Y * 2, simpleShape.Size.Z * 2);

                            mb.ComputeNormalsAndTangents(MeshFaces.Default, true);

                            geometry = mb.ToMeshGeometry3D();
                        }
                        else if (shape is CollisionShapeMesh meshShape)
                        {
                            var geo = _geometryCacheService.GetEntry(wcn.SectorHash, meshShape.Hash);

                            if (geo == null)
                            {
                                //_loggerService.Warning($"Couldn't find entry with hash {shape.Hash} in sector {wcn.SectorHash}, handle[{data.Handles.IndexOf(handle)}], actor[{cb.Actors.IndexOf(actor)}], shape[{actor.Shapes.IndexOf(shape)}]");
                                continue;
                            }

                            if (geo is ConvexMesh convexMesh)
                            {
                                var mb = new MeshBuilder
                                {
                                    CreateNormals = true
                                };

                                var positions = new Vector3Collection();
                                for (var i = 0; i < convexMesh.HullData.HullVertices.Count; i++)
                                {
                                    positions.Add(convexMesh.HullData.HullVertices[i]);
                                }

                                var faceIndex = 0;
                                for (var i = 0; i < convexMesh.HullData.Polygons.Count; i++)
                                {
                                    var count = mb.Positions.Count;
                                    var faceData = convexMesh.HullData.Polygons[i];

                                    switch (faceData.NbVerts)
                                    {
                                        case 3:
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex]]);
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex + 1]]);
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex + 2]]);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.TriangleIndices.Add(count);
                                            mb.TriangleIndices.Add(count + 1);
                                            mb.TriangleIndices.Add(count + 2);
                                            break;
                                        case 4:
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex]]);
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex + 1]]);
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex + 2]]);
                                            mb.Positions.Add(positions[convexMesh.HullData.VertexData8[faceIndex + 3]]);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.Normals.Add(faceData.Plane.N);
                                            mb.TriangleIndices.Add(count);
                                            mb.TriangleIndices.Add(count + 1);
                                            mb.TriangleIndices.Add(count + 2);
                                            mb.TriangleIndices.Add(count + 2);
                                            mb.TriangleIndices.Add(count + 3);
                                            mb.TriangleIndices.Add(count);
                                            break;
                                        default:
                                            for (var j = 0; j < faceData.NbVerts; j++)
                                            {
                                                mb.Positions.Add(positions[convexMesh.HullData.VertexData8[j]]);
                                                mb.Normals.Add(faceData.Plane.N);
                                            }
                                            for (var j = 0; j + 2 < faceData.NbVerts; j++)
                                            {
                                                mb.TriangleIndices.Add(count);
                                                mb.TriangleIndices.Add(count + j + 1);
                                                mb.TriangleIndices.Add(count + j + 2);
                                            }
                                            break;
                                    }

                                    faceIndex += faceData.NbVerts;
                                }

                                geometry = mb.ToMeshGeometry3D();
                            }

                            if (geo is BV4TriangleMesh bv4TriangleMesh)
                            {
                                var mb = new MeshBuilder
                                {
                                    CreateNormals = true
                                };

                                var positions = new Vector3Collection();
                                for (var i = 0; i < bv4TriangleMesh.Vertices.Count; i++)
                                {
                                    positions.Add(bv4TriangleMesh.Vertices[i]);
                                }

                                foreach (var face in bv4TriangleMesh.Triangles)
                                {
                                    var points = new List<SharpDX.Vector3>();
                                    foreach (var point in face)
                                    {
                                        points.Add(positions[(int)point]);
                                    }
                                    mb.AddTriangle(points[0], points[1], points[2]);
                                }

                                //mb.ComputeNormalsAndTangents(MeshFaces.Default);

                                geometry = mb.ToMeshGeometry3D();
                            }
                        }

                        if (geometry == null)
                        {
                            continue;
                        }

                        ulong hash = 0;
                        if (shape is CollisionShapeMesh meshShape2)
                        {
                            hash = meshShape2.Hash;
                        }

                        var shapeGroup = new SubmeshComponent()
                        {
                            Name = "shape_" + hash,
                            Text = "shape_" + hash,
                            IsRendering = true,
                            Geometry = geometry,
                            Material = colliderMaterial,
                            IsTransparent = true,
                            CollisionActorId = $"{k}"
                        };

                        var shapeMatrix = new Matrix3D();

                        var shapeQuat = new System.Numerics.Quaternion(shape.Rotation.I, shape.Rotation.J, shape.Rotation.K, shape.Rotation.R);
                        var conversionQuat =
                            System.Numerics.Quaternion.CreateFromAxisAngle(System.Numerics.Vector3.UnitX, -MathF.PI / 2);
                        var adjustedQuat = conversionQuat * shapeQuat;

                        shapeMatrix.Rotate(new System.Windows.Media.Media3D.Quaternion(adjustedQuat.X, adjustedQuat.Y, adjustedQuat.Z, adjustedQuat.W));
                        shapeMatrix.Translate(ToVector3D(shape.Position));

                        shapeGroup.Transform = new MatrixTransform3D(shapeMatrix);

                        actorGroup.Children.Add(shapeGroup);
                    }

                    var matrix = new Matrix3D();
                    matrix.Scale(ToScaleVector3D(actor.Scale));
                    matrix.Rotate(ToQuaternion(actor.Orientation));
                    matrix.Translate(ToVector3D(actor.Position));

                    actorGroup.Transform = new MatrixTransform3D(matrix);

                    mesh.Children.Add(actorGroup);
                }

                // not used?
                //var meshMatrix = new Matrix3D();
                //meshMatrix.Scale(ToScaleVector3D(transforms[0].Scale));
                //meshMatrix.Rotate(ToQuaternion(transforms[0].Orientation));
                //meshMatrix.Translate(ToVector3D(transforms[0].Position));

                //mesh.Transform = new MatrixTransform3D(meshMatrix);
                groups.Add(mesh);
            }
            else if (handle.Chunk is worldNavigationNode wnm)
            {
                var emb = Parent?.Cr2wFile?.EmbeddedFiles.FirstOrDefault(x => x.FileName == wnm.NavigationTileResource.DepotPath);
                if (emb == null)
                {
                    continue;
                }

                if (emb.Content is not worldNavigationTileResource wntr)
                {
                    continue;
                }

                foreach (var tile in wntr.TilesData)
                {
                    if (wntr.TileBuffers[(int)(uint)tile.BufferIndex].Data is not TilesBuffer tb)
                    {
                        continue;
                    }

                    var positions = new Vector3Collection();

                    foreach (var v in tb.Vertices)
                    {
                        positions.Add(new SharpDX.Vector3(v.X, v.Y, -v.Z));
                    }

                    var mb = new MeshBuilder();

                    foreach (var f in tb.FaceInfo)
                    {
                        if (f.NumIndices == 3)
                        {
                            mb.AddTriangle(positions[f.Indices[0]], positions[f.Indices[2]], positions[f.Indices[1]]);
                        }
                        else if (f.NumIndices == 2)
                        {
                            mb.AddPipe(positions[f.Indices[0]], positions[f.Indices[1]], 0, 0.1, 16);
                        }
                    }

                    mb.ComputeNormalsAndTangents(MeshFaces.Default);

                    var material = SetupPBRMaterial("DefaultMaterial");
                    material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.5f);
                    //material.AlbedoColor = new SharpDX.Color4(.5f, .5f, .5f, 1.0f);

                    var mesh = new MeshGeometryModel3D()
                    {
                        Geometry = mb.ToMeshGeometry3D(),
                        Material = material,
                        IsTransparent = true
                        //Transform = new TranslateTransform3D(tile.TileX * 100, 0, tile.TileY * 100)
                    };

                    var group = new MeshComponent()
                    {
                        Name = name,
                        Text = name,
                        WorldNodeIndex = string.Empty,
                        WorldNodeDataIndices = string.Empty
                    };

                    group.Children.Add(mesh);

                    groups.Add(group);
                }
            }
            else if (handle.Chunk is worldEntityNode wen)
            {
                //a little slow for what we want to do
                // <3

                try
                {

                    var entFile = GetProjectOrDepotFile(wen.EntityTemplate.DepotPath);

                    if (entFile != null && entFile.RootChunk is entEntityTemplate eet)
                    {
                        var entity = RenderEntity(eet, app);
                        if (entity != null)
                        {
                            entity.Name = "Entity";
                            entity.Text = "Entity";
                            //var f = Shell.ChunkViewModel.FixRotation;

                            var q = new System.Numerics.Quaternion()
                            {
                                W = transforms[0].Transform.Orientation.R,
                                X = transforms[0].Transform.Orientation.I,
                                Y = transforms[0].Transform.Orientation.J,
                                Z = transforms[0].Transform.Orientation.K
                            };

                            //q = Shell.ChunkViewModel.FixRotation(q);
                            var qq = new System.Windows.Media.Media3D.Quaternion(q.X, q.Y, q.Z, q.W);

                            var matrix = new Matrix3D();
                            matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                            matrix.Rotate(qq);
                            matrix.Translate(ToVector3D(transforms[0].Transform.Position));

                            entity.Transform = new MatrixTransform3D(matrix);

                            groups.Add(entity);
                        }
                    }
                }
                catch (Exception ex) { Parent?.GetLoggerService().Error(ex); }
            }
            else if (handle.Chunk is worldPopulationSpawnerNode wpsn)
            {
                //var record = _tweakDBService.GetRecord(wpsn.ObjectRecordId);

                //if (record is gamedataVehicle_Record vehicle)
                //{
                //    var entFile = File.GetFileFromDepotPathOrCache(vehicle.EntityTemplatePath.DepotPath);

                //    if (entFile != null && entFile.RootChunk is entEntityTemplate eet)
                //    {
                //        var entity = RenderEntity(eet, app);
                //        if (entity != null)
                //        {
                //            entity.Name = "Entity";

                //            var matrix = new Matrix3D();
                //            matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                //            matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                //            matrix.Translate(ToVector3D(transforms[0].Position));

                //            entity.Transform = new MatrixTransform3D(matrix);

                //            groups.Add(entity);
                //        }
                //    }
                //}
            }
            else if (handle.Chunk is worldAreaShapeNode wasn)
            {
                var shape = wasn.Outline.Chunk.NotNull();
                var mb = new MeshBuilder();

                var center = new SharpDX.Vector3();

                foreach (var point in shape.Points)
                {
                    center.X += point.X / shape.Points.Count;
                    center.Y += point.Z / shape.Points.Count;
                    center.Z += -point.Y / shape.Points.Count;
                }

                mb.AddBox(center, Math.Abs(shape.Points[0].NotNull().X) * 2, shape.Height, Math.Abs(shape.Points[0].NotNull().Y) * 2);
                mb.ComputeNormalsAndTangents(MeshFaces.Default);

                var material = SetupPBRMaterial("DefaultMaterial");
                material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.1f);

                var mesh = new MeshGeometryModel3D()
                {
                    Geometry = mb.ToMeshGeometry3D(),
                    Material = material,
                    IsTransparent = true
                };

                var matrix = new Matrix3D();
                matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                matrix.Rotate(ToQuaternion(transforms[0].Transform.Orientation));
                matrix.Translate(ToVector3D(transforms[0].Transform.Position));

                var group = new MeshComponent()
                {
                    Name = name,
                    Text = name,
                    Transform = new MatrixTransform3D(matrix)
                };

                group.Children.Add(mesh);

                groups.Add(group);

            }
        }

        var element = new SectorGroup()
        {
            Name = "",
            Text = "",
        };
        foreach (var group in groups)
        {
            element.Children.Add(group);
        }
        app.ModelGroup.Add(element);

        SelectWorldNode();
        return element;
    }

    public static SharpDX.Vector3 ToVector3(Vector3 v) => new(v.X, v.Y, v.Z);

    public void UpdateSelection(MeshComponent mesh)
    {
        RetoreSelectedMeshMaterial();

        CurrentSelection.SelectedMesh = mesh;

        UpdateMeshSelectionColor(mesh);
    }

    private void RetoreSelectedMeshMaterial() => UpdateChildrenSubmesh(CurrentSelection.SelectedMesh, (submesh) => submesh.Material = submesh.OriginalMaterial);
    private void UpdateMeshSelectionColor(MeshComponent mesh)
    {
        UpdateChildrenSubmesh(mesh, (submesh) =>
        {
            submesh.OriginalMaterial = submesh.Material;
            submesh.Material = PhongMaterials.Blue;
        });
    }

    private void UpdateChildrenSubmesh(MeshComponent? mesh, Action<SubmeshComponent>? submeshUpdater)
    {
        if (mesh == null)
        {
            return;
        }

        foreach (var child in mesh.Children)
        {
            switch (child)
            {
                case MeshComponent childMesh:
                    UpdateChildrenSubmesh(childMesh, submeshUpdater);
                    break;
                case SubmeshComponent childSubMesh:
                {
                    if (submeshUpdater != null)
                    {
                        submeshUpdater(childSubMesh);
                    }

                    break;
                }
                default:
                    Parent?.GetLoggerService().Warning("Child is a " + child.GetType());
                    break;
            }
        }
    }

    private void MouseDown3DSector(object sender, MouseDown3DEventArgs args, MouseButtonEventArgs mouseButtonEventArgs)
    {

        if (Header == MeshViewHeaders.SectorPreview && args.HitTestResult.ModelHit is SubmeshComponent { Parent: MeshComponent { Parent: MeshComponent mesh } })
        {
            if (mouseButtonEventArgs.RightButton == MouseButtonState.Pressed)
            {
                Parent?.GetLoggerService().Info("RighClick: " + mesh.Text);
            }
            else if (mouseButtonEventArgs.LeftButton == MouseButtonState.Pressed)
            {
                UpdateSelection(mesh);
            }
        }
    }


    #endregion

    #region meshpreviewblock

    public List<Sector> Sectors { get; set; } = new();

    public Vector3 SearchPoint { get; set; } = new();

    public bool SearchActive = false;

    [RelayCommand]
    private void LoadSector(Sector sector)
    {
        if (sector.IsLoaded)
        {
            return;
        }

        var sectorFile = GetProjectOrDepotFile(sector.DepotPath);

        if (sectorFile?.RootChunk is not worldStreamingSector wss)
        {
            return;
        }

        sector.Element = RenderSector(wss, Appearances[0]);
        sector.Element.Name = sector.Name.Replace("-", "n");
        sector.Element.Text = sector.Name;
        sector.IsLoaded = true;
        sector.ShowElements = true;
        sector.Text.IsRendering = false;
    }



    [RelayCommand]
    public void ClearSearch()
    {
        SearchActive = false;
        RenderBlock(_data as worldStreamingBlock);
    }

    [RelayCommand]
    public void SearchForPoint()
    {
        SearchActive = true;
        RenderBlock(_data as worldStreamingBlock);
        CenterCameraToCoord(SearchPoint);
    }

    [RelayCommand]
    public void AddSectorsToProject()
    {
        if (SelectedAppearance == null)
        {
            return;
        }

        foreach (var modelGroup in SelectedAppearance.ModelGroup)
        {
            if (!modelGroup.IsRendering || modelGroup is not SectorGroup sectorGroup)
            {
                continue;
            }

            // TODO: Could check if ep1 is found, not sure though if the same filename could be in both folders...

            var path = (ResourcePath)$@"base\worlds\03_night_city\_compiled\default\ep1\{sectorGroup.Text}.streamingsector";
            _gameController.GetController().AddToMod(path);

            path = (ResourcePath)$@"base\worlds\03_night_city\_compiled\default\{sectorGroup.Text}.streamingsector";
            _gameController.GetController().AddToMod(path);

        }
    }

    public void RenderBlockSolo()
    {
        if (IsRendered)
        {
            return;
        }
        IsRendered = true;
        RenderBlock(_data as worldStreamingBlock);
        SelectWorldNode();
    }

    public void RenderBlock(worldStreamingBlock? data)
    {
        if (data is null)
        {
            return;
        }

        Appearances = new();

        var app = new Appearance("All_Sectors");

        Appearances.Add(app);
        SelectedAppearance = app;

        var texts = new GroupModel3DExt()
        {
            Name = "SectorNames",
            Text = "SectorNames"
        };

        var sectors = new List<Sector>();

        var exterior = new GroupModel3DExt()
        {
            Name = "Exterior",
            Text = "Exterior",
        };
        var exterior_0 = new GroupModel3DExt()
        {
            Name = "Exterior_0",
            Text = "Exterior_0",
        };
        var exterior_1 = new GroupModel3DExt()
        {
            Name = "Exterior_1",
            Text = "Exterior_1",
        };
        var exterior_2 = new GroupModel3DExt()
        {
            Name = "Exterior_2",
            Text = "Exterior_2",
        };
        var exterior_3 = new GroupModel3DExt()
        {
            Name = "Exterior_3",
            Text = "Exterior_3",
        };
        var exterior_4 = new GroupModel3DExt()
        {
            Name = "Exterior_4",
            Text = "Exterior_4",
        };
        var exterior_5 = new GroupModel3DExt()
        {
            Name = "Exterior_5",
            Text = "Exterior_5",
        };
        var exterior_6 = new GroupModel3DExt()
        {
            Name = "Exterior_6",
            Text = "Exterior_6",
        };
        exterior.Children.Add(exterior_0);
        exterior.Children.Add(exterior_1);
        exterior.Children.Add(exterior_2);
        exterior.Children.Add(exterior_3);
        exterior.Children.Add(exterior_4);
        exterior.Children.Add(exterior_5);
        exterior.Children.Add(exterior_6);
        var interior = new GroupModel3DExt()
        {
            Name = "Interior",
            Text = "Interior",
        };
        var quest = new GroupModel3DExt()
        {
            Name = "Quest",
            Text = "Quest",
        };
        var navigation = new GroupModel3DExt()
        {
            Name = "Navigation",
            Text = "Navigation",
        };
        var other = new GroupModel3DExt()
        {
            Name = "Other",
            Text = "Other",
        };

        foreach (var desc in data.Descriptors)
        {
            if (SearchActive && (!(SearchPoint.X < desc.StreamingBox.Max.X) || !(SearchPoint.X > desc.StreamingBox.Min.X) ||
                                 !(SearchPoint.Y < desc.StreamingBox.Max.Y) || !(SearchPoint.Y > desc.StreamingBox.Min.Y) ||
                                 !(SearchPoint.Z < desc.StreamingBox.Max.Z) || !(SearchPoint.Z > desc.StreamingBox.Min.Z)))
            {
                continue;
            }

            var text = new BillboardText3D();
            text.TextInfo.Add(
                new TextInfo(Path.GetFileNameWithoutExtension(desc.Data.DepotPath.GetResolvedText()),
                    new SharpDX.Vector3((desc.StreamingBox.Max.X + desc.StreamingBox.Min.X) / 2, (desc.StreamingBox.Max.Z + desc.StreamingBox.Min.Z) / 2, -(desc.StreamingBox.Max.Y + desc.StreamingBox.Min.Y) / 2))
                {
                    Foreground = SharpDX.Color.Red,
                    Scale = 0.5f
                }
            );

            var bbText = new WKBillboardTextModel3D()
            {
                Geometry = text,
                Name = Path.GetFileNameWithoutExtension(desc.Data.DepotPath.GetResolvedText().NotNull()).Replace("-", "n"),
                Text = Path.GetFileNameWithoutExtension(desc.Data.DepotPath.GetResolvedText().NotNull()),
            };

            if (desc.Category == Enums.worldStreamingSectorCategory.Exterior)
            {
                //var mb = new MeshBuilder();

                //mb.AddBox(text.TextInfo[0].Origin,
                //    desc.StreamingBox.Max.X - desc.StreamingBox.Min.X,
                //    desc.StreamingBox.Max.Y - desc.StreamingBox.Min.Y,
                //    desc.StreamingBox.Max.Z - desc.StreamingBox.Min.Z);
                //mb.ComputeNormalsAndTangents(MeshFaces.Default);

                //var material = SetupPBRMaterial("DefaultMaterial");
                //material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.01f);

                //var mesh = new MeshGeometryModel3D()
                //{
                //    Geometry = mb.ToMeshGeometry3D(),
                //    Material = material,
                //    IsTransparent = true
                //};

                if (desc.Level == 0)
                {
                    exterior_0.Children.Add(bbText);
                    //exterior_0.Children.Add(mesh);
                }
                else if (desc.Level == 1)
                {
                    exterior_1.Children.Add(bbText);
                    //exterior_1.Children.Add(mesh);
                }
                else if (desc.Level == 2)
                {
                    exterior_2.Children.Add(bbText);
                    //exterior_2.Children.Add(mesh);
                }
                else if (desc.Level == 3)
                {
                    exterior_3.Children.Add(bbText);
                    //exterior_3.Children.Add(mesh);
                }
                else if (desc.Level == 4)
                {
                    exterior_4.Children.Add(bbText);
                    //exterior_4.Children.Add(mesh);
                }
                else if (desc.Level == 5)
                {
                    exterior_5.Children.Add(bbText);
                    //exterior_5.Children.Add(mesh);
                }
                else if (desc.Level == 6)
                {
                    exterior_6.Children.Add(bbText);
                    //exterior_6.Children.Add(mesh);
                }
                else
                {
                    exterior.Children.Add(bbText);
                    //exterior.Children.Add(mesh);
                }
            }
            else if (desc.Category == Enums.worldStreamingSectorCategory.Interior)
            {
                interior.Children.Add(bbText);
            }
            else if (desc.Category == Enums.worldStreamingSectorCategory.Quest)
            {
                quest.Children.Add(bbText);
            }
            else if (desc.Category == Enums.worldStreamingSectorCategory.Navigation)
            {
                navigation.Children.Add(bbText);
            }
            else
            {
                other.Children.Add(bbText);
            }

            sectors.Add(new Sector(Path.GetFileNameWithoutExtension(desc.Data.DepotPath.GetResolvedText().NotNull()), bbText)
            {
                DepotPath = desc.Data.DepotPath,
                NumberOfHandles = desc.NumNodeRanges
            });
        }
        Sectors = new List<Sector>(sectors.OrderBy(x => x.Name).ToList());
        texts.Children.Add(exterior);
        texts.Children.Add(interior);
        texts.Children.Add(quest);
        texts.Children.Add(navigation);
        texts.Children.Add(other);
        app.ModelGroup.Add(texts);

    }

    private void MouseDown3DBlock(object sender, MouseDown3DEventArgs args, MouseButtonEventArgs mouseButtonEventArgs)
    {
        if (Header != MeshViewHeaders.AllSectorPreview || mouseButtonEventArgs.LeftButton != MouseButtonState.Pressed)
        {
            return;
        }

        switch (args.HitTestResult.ModelHit)
        {
            case WKBillboardTextModel3D text:
            {
                var sector = Sectors.FirstOrDefault(x => x.Text == text);
                if (sector is not null)
                {
                    try
                    {
                        LoadSector(sector);
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService().Error(ex);
                    }
                }

                args.Handled = true;
                break;
            }
            case MeshComponent group:
                SelectedItem = group;
                args.Handled = true;
                break;
            default:
                break;
        }
    }

    #endregion

    #region meshpreviewentity



    public void RenderEntitySolo()
    {
        if (IsRendered)
        {
            return;
        }
        IsRendered = true;
        try
        {
            RenderEntity(_data as entEntityTemplate);
        }
        catch (Exception e)
        {
            _loggerService.Error(
                $"Failed to render entity. Please ensure that all your component names are unique. If they are, open a ticket:  \n${e}");
        }
    }

    public GroupModel3DExt? RenderEntity(entEntityTemplate? ent, Appearance? appearance = null, string? appearanceName = null)
    {
        if (ent?.CompiledData.Data is not RedPackage pkg)
        {
            return null;
        }

        if (ent.Appearances.Count > 0)
        {
            foreach (var component in pkg.Chunks)
            {
                switch (component)
                {
                    case entSlotComponent slotset:
                    {
                        var slots = new Dictionary<string, string>();
                        foreach (var slot in slotset.Slots)
                        {
                            var name = slot.SlotName.ToString().NotNull();

                            if (!slots.ContainsKey(name))
                            {
                                slots.Add(name, slot.BoneName.ToString().NotNull());
                            }
                        }

                        string? bindName = null, slotName = null;
                        if (slotset.ParentTransform?.GetValue() is entHardTransformBinding ehtb)
                        {
                            bindName = ehtb.BindName;
                            slotName = ehtb.SlotName;
                        }

                        var slotSetName = slotset.Name.ToString().NotNull();
                        if (!_slotSets.ContainsKey(slotSetName))
                        {
                            _slotSets.Add(slotSetName,
                                new SlotSet(slotSetName, bindName)
                                {
                                    Matrix = ToSeparateMatrix(slotset.LocalTransform),
                                    Slots = slots,
                                    SlotName = slotName
                                });
                        }

                        break;
                    }
                    case entAnimatedComponent enc:
                    {
                        var rigFile = GetProjectOrDepotFile(enc.Rig.DepotPath);

                        if (rigFile?.RootChunk is animRig rig)
                        {
                            var rigBones = new List<RigBone>();
                            for (var i = 0; i < rig.BoneNames.Count; i++)
                            {
                                var rigBone = new RigBone(rig.BoneNames[i].ToString().NotNull())
                                {
                                    Matrix = ToSeparateMatrix(rig.BoneTransforms[i].NotNull())
                                };

                                if (rig.BoneParentIndexes[i] != -1)
                                {
                                    rigBones[rig.BoneParentIndexes[i]].AddChild(rigBone);
                                }

                                rigBones.Add(rigBone);
                            }

                            string? bindName = null, slotName = null;
                            if ((enc.ParentTransform?.GetValue() ?? null) is entHardTransformBinding ehtb)
                            {
                                bindName = ehtb.BindName;
                                slotName = ehtb.SlotName;
                            }

                            Rigs[enc.Name.ToString().NotNull()] = new Rig(enc.Name.ToString().NotNull())
                            {
                                Bones = rigBones,
                                BindName = bindName,
                                SlotName = slotName
                            };
                        }

                        break;
                    }

                    default:
                        break;
                }
            }

            foreach (var rig in Rigs.Values)
            {
                if (rig.BindName is not null && Rigs.ContainsKey(rig.BindName))
                {
                    Rigs[rig.BindName].AddChild(rig);
                }
            }

            List<entTemplateAppearance> appearances;
            if (appearance != null)
            {
                appearances = ent.Appearances.Where(x => x is not null && x.Name == ent.DefaultAppearance).ToList();
            }
            else if (appearanceName == null)
            {
                appearances = ent.Appearances.ToList();
            }
            else
            {
                appearances = ent.Appearances.Where(x => x is not null && x.AppearanceName == appearanceName).ToList();
            }

            var element = new GroupModel3DExt();

            var idx = -1;
            foreach (var app in appearances)
            {
                idx++;
                if (app is null)
                {
                    _loggerService.Error($"appearance {idx} is null! Skipping...");
                    continue;
                }

                var appFile = GetProjectOrDepotFile(app.AppearanceResource.DepotPath);

                if (appFile is not { RootChunk: appearanceAppearanceResource aar })
                {
                    _loggerService.Error($"Failed to laod appearance {idx} from {app.AppearanceResource.DepotPath}");
                    continue;
                }

                // ArchiveXL dynamic variants will reuse name on empty appearance name
                if (app.AppearanceName == CName.Empty)
                {
                    app.AppearanceName = app.Name;
                }

                var appearanceDefs = aar.Appearances
                    .Select(handle => handle.GetValue())
                    .OfType<appearanceAppearanceDefinition>()
                    .GroupBy(value => (StringHelper.StringifyOrNull(value.Name) ?? string.Empty).Split("&")[0])
                    .ToDictionary(group => group.Key, group => group.First());

                var resolvedName = (StringHelper.StringifyOrNull(app.AppearanceName)
                                    ?? StringHelper.StringifyOrNull(app.Name)
                                    ?? "invalid name")
                    .Split("&")[0];
                if (!appearanceDefs.TryGetValue(resolvedName, out var appDef))
                {
                    _loggerService.Warning(
                        $"No appearance with the name {app.AppearanceName} found in {app.AppearanceResource.DepotPath}");
                    continue;
                }

                List<LoadableModel> loadableModels = new();
                if (appDef.CompiledData?.Data is RedPackage appPkg)
                {
                    loadableModels.AddRange(LoadMeshes(appPkg.Chunks));
                }

                loadableModels.AddRange(LoadPartsValues(appDef));

                if (loadableModels.Count == 0)
                {
                    _loggerService.Error(
                        $"No no components loaded for {app.AppearanceName} from {app.AppearanceResource.DepotPath}");
                    continue;
                }

                LoadPartsOverrides(appDef, loadableModels);

                var a = new Appearance(app.AppearanceName.ToString().NotNull())
                {
                    AppearanceName = app.AppearanceName,
                    Resource = app.AppearanceResource.DepotPath,
                    Models = loadableModels,
                };

                foreach (var model in a.Models)
                {
                    if (a.Models.FirstOrDefault(x => x.Name == model.BindName) is var parentModel &&
                        parentModel is not null)
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

                    if (model.MeshFile?.RootChunk is CMesh mesh)
                    {
                        var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                        model.Meshes = MakeMesh(mesh, model.ChunkMask, model.AppearanceIndex, meshPath);
                    }

                    foreach (var m in model.Meshes)
                    {
                        if (!a.LODLUT.TryGetValue(m.LOD, out var value))
                        {
                            value = new List<SubmeshComponent>();
                            a.LODLUT[m.LOD] = value;
                        }

                        value.Add(m);
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
            }


            if (appearance == null && Appearances.Count > 0)
            {
                SelectedAppearance = Appearances[0];
            }

            return element;
        }

        // ent.appearances.Count == null => it's not a root entity
        var models = LoadMeshes(pkg.Chunks);

        if (models.Count == 0)
        {
            return null;
        }

        var meshApp = appearance ?? new Appearance("Default") { Models = models };

        var cGroup = new MeshComponent() { WorldNodeIndex = string.Empty, WorldNodeDataIndices = string.Empty, };

        foreach (var model in models)
        {
            foreach (var material in model.Materials)
            {
                meshApp.RawMaterials[material.Name] = material;
            }

            if (model.MeshFile?.RootChunk is CMesh mesh)
            {
                var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                model.Meshes = MakeMesh(mesh, model.ChunkMask, model.AppearanceIndex, meshPath);
            }

            foreach (var m in model.Meshes)
            {
                cGroup.Children.Add(m);
                if (!meshApp.LODLUT.ContainsKey(m.LOD))
                {
                    meshApp.LODLUT[m.LOD] = new List<SubmeshComponent>();
                }

                meshApp.LODLUT[m.LOD].Add(m);
            }
        }

        if (appearance == null)
        {
            meshApp.ModelGroup.Add(cGroup);
            Appearances.Add(meshApp);

            // Load additional appearance variants from the referenced meshes
            var appearanceNames = models
                .SelectMany(model => model.MeshFile?.RootChunk is CMesh mesh
                    ? mesh.Appearances
                        .Select(h => h.GetValue())
                        .OfType<meshMeshAppearance>()
                        .Select(ma => ma.Name.ToString().NotNull())
                    : Array.Empty<string>())
                .Where(name => !string.IsNullOrWhiteSpace(name) &&
                               !name.Equals("default", StringComparison.OrdinalIgnoreCase) &&
                               !name.Equals(meshApp.AppearanceName?.ToString(), StringComparison.OrdinalIgnoreCase))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            foreach (var variantName in appearanceNames)
            {
                var variantModels = LoadMeshes(pkg.Chunks, variantName);
                if (variantModels.Count == 0)
                    continue;

                var variant = new Appearance(variantName)
                {
                    AppearanceName = variantName,
                    Models = variantModels
                };

                var variantGroup = new MeshComponent()
                {
                    WorldNodeIndex = string.Empty,
                    WorldNodeDataIndices = string.Empty
                };

                foreach (var model in variantModels)
                {
                    foreach (var material in model.Materials)
                        variant.RawMaterials[material.Name] = material;

                    if (model.MeshFile?.RootChunk is CMesh modelMesh)
                    {
                        var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                        model.Meshes = MakeMesh(modelMesh, model.ChunkMask, model.AppearanceIndex, meshPath);
                    }

                    foreach (var submesh in model.Meshes)
                    {
                        variantGroup.Children.Add(submesh);
                        if (!variant.LODLUT.TryGetValue(submesh.LOD, out var lodMeshes))
                        {
                            lodMeshes = [];
                            variant.LODLUT[submesh.LOD] = lodMeshes;
                        }
                        lodMeshes.Add(submesh);
                    }
                }

                variant.ModelGroup.Add(variantGroup);
                Appearances.Add(variant);
            }

            SelectedAppearance = meshApp;
        }

        var el = new GroupModel3DExt();
        foreach (var model in meshApp.ModelGroup)
        {
            el.Children.Add(model);
        }

        return el;

    }

    #endregion

    private object? findMeshChild(object o)
    {
        switch (o)
        {
            case SectorGroup group:
            {
                foreach (var groupChild in group.Children)
                {
                    if (findMeshChild(groupChild) is { } result)
                    {
                        return result;
                    }
                }

                break;
            }
            case LoadableModel loadableModel:
                return loadableModel;
            case MeshComponent comp:
                if (comp.WorldNodeIndex == SelectedNodeIndex)
                {
                    return comp;
                }

                // foreach (var compChild in comp.Children)
                // {
                //     if (findMeshChild(compChild) is { } found)
                //     {
                //         return found;
                //     }
                // }

                break;
            default:
                break;
        }

        return null;
    }
    public void SelectWorldNode()
    {
        if (SelectedNodeIndex is null)
        {
            return;
        }

        object? selectedMesh = null;
        foreach (var loadableModel in Models)
        {
            if (selectedMesh is not null)
            {
                continue;
            }

            selectedMesh = findMeshChild(loadableModel);
        }

        foreach (var appearance in Appearances)
        {
            appearance.ModelGroup.AsList().ForEach((model) =>
            {
                if (selectedMesh is not null)
                {
                    return;
                }

                selectedMesh = findMeshChild(model);
            });
        }

        SelectedItem = selectedMesh;
    }

    // Hair Gradient
    private record GradientEntry(float Value, byte R, byte G, byte B);

    private void ApplyColorRamp(Bitmap bmp, List<GradientEntry> entries, float gamma = 1f)
    {
        if (entries.Count == 0)
            return;
        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                int stride = data.Stride;
                for (int y = 0; y < bmp.Height; y++)
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        int off = y * stride + x * 4;
                        // Use R channel as factor (matches Blender addon Strand ID R / Root To Tip R)
                        float t = ptr[off + 2] / 255f;
                        if (gamma != 1f)
                            t = MathF.Pow(t, 1f / gamma);
                        var (c1, c2, blend) = InterpolateGradient(entries, t);
                        ptr[off + 0] = (byte)(c1.B * (1 - blend) + c2.B * blend);
                        ptr[off + 1] = (byte)(c1.G * (1 - blend) + c2.G * blend);
                        ptr[off + 2] = (byte)(c1.R * (1 - blend) + c2.R * blend);
                    }
            }
        }
        finally { bmp.UnlockBits(data); }
    }

    private (GradientEntry, GradientEntry, float) InterpolateGradient(List<GradientEntry> entries, float t)
    {
        if (entries.Count == 0)
            return (new(0, 128, 128, 128), new(0, 128, 128, 128), 0);
        if (t <= entries[0].Value)
            return (entries[0], entries[0], 0);
        if (t >= entries[^1].Value)
            return (entries[^1], entries[^1], 0);
        for (int i = 0; i < entries.Count - 1; i++)
            if (t >= entries[i].Value && t <= entries[i + 1].Value)
            {
                float range = entries[i + 1].Value - entries[i].Value;
                return (entries[i], entries[i + 1], range > 0 ? (t - entries[i].Value) / range : 0);
            }
        return (entries[0], entries[0], 0);
    }

    /// <summary>
    /// Haircard color mix from hair.py _overlay (node names say Overlay, contents are Multiply):
    /// Overlay Low    = ID_color * RootTip_color          (Multiply, factor 1)
    /// Overlay Low×2  = that * (2,2,2)                    (Multiply by 2)
    /// Overlay High   = 1 - (1-ID)*(1-RootTip)*2          (Invert path)
    /// Result         = mix(low, high) by RootTip luminance >= 0.5
    /// </summary>
    private void OverlayBitmaps(Bitmap baseBmp, Bitmap blendBmp)
    {
        if (baseBmp.Width != blendBmp.Width || baseBmp.Height != blendBmp.Height)
            return;

        var rect = new Rectangle(0, 0, baseBmp.Width, baseBmp.Height);
        var baseData = baseBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var blendData = blendBmp.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* b = (byte*)baseData.Scan0;
                byte* s = (byte*)blendData.Scan0;
                int stride = baseData.Stride;
                for (int y = 0; y < baseBmp.Height; y++)
                {
                    for (int x = 0; x < baseBmp.Width; x++)
                    {
                        int off = y * stride + x * 4;

                        float bb = b[off + 0] / 255f;
                        float bg = b[off + 1] / 255f;
                        float br = b[off + 2] / 255f;

                        float sb = s[off + 0] / 255f;
                        float sg = s[off + 1] / 255f;
                        float sr = s[off + 2] / 255f;

                        // Luminance of blend (Root/Tip)
                        float lum = sr * 0.3f + sg * 0.59f + sb * 0.11f;

                        // Overlay Low = base * blend * 2
                        float lowR = Math.Clamp(br * sr * 2f, 0f, 1f);
                        float lowG = Math.Clamp(bg * sg * 2f, 0f, 1f);
                        float lowB = Math.Clamp(bb * sb * 2f, 0f, 1f);

                        // Overlay High = 1 - (1-base)*(1-blend)*2
                        float highR = Math.Clamp(1f - (1f - br) * (1f - sr) * 2f, 0f, 1f);
                        float highG = Math.Clamp(1f - (1f - bg) * (1f - sg) * 2f, 0f, 1f);
                        float highB = Math.Clamp(1f - (1f - bb) * (1f - sb) * 2f, 0f, 1f);

                        float useHigh = lum >= 0.5f ? 1f : 0f;

                        b[off + 2] = (byte)((lowR * (1f - useHigh) + highR * useHigh) * 255f);
                        b[off + 1] = (byte)((lowG * (1f - useHigh) + highG * useHigh) * 255f);
                        b[off + 0] = (byte)((lowB * (1f - useHigh) + highB * useHigh) * 255f);
                    }
                }
            }
        }
        finally
        {
            baseBmp.UnlockBits(baseData);
            blendBmp.UnlockBits(blendData);
        }
    }

    private void ApplyGradientMapLookup(Bitmap target, Bitmap gradientMap)
    {
        int gradY = gradientMap.Height / 2;
        var gradColors = new Color[gradientMap.Width];
        for (int x = 0; x < gradientMap.Width; x++)
            gradColors[x] = gradientMap.GetPixel(x, gradY);

        var rect = new Rectangle(0, 0, target.Width, target.Height);
        var data = target.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                int stride = data.Stride;
                for (int y = 0; y < target.Height; y++)
                {
                    for (int x = 0; x < target.Width; x++)
                    {
                        int off = y * stride + x * 4;
                        float lum = (ptr[off + 2] * 0.3f + ptr[off + 1] * 0.59f + ptr[off] * 0.11f) / 255f;
                        int idx = Math.Clamp((int)(lum * (gradColors.Length - 1)), 0, gradColors.Length - 1);
                        var c = gradColors[idx];
                        ptr[off + 0] = c.B;
                        ptr[off + 1] = c.G;
                        ptr[off + 2] = c.R;
                    }
                }
            }
        }
        finally { target.UnlockBits(data); }
    }

    // Eyes Gradient
    private void ApplyIrisGradient(Bitmap albedo, Bitmap mask, List<GradientEntry> entries)
    {
        Bitmap? resizedMask = null;
        if (mask.Width != albedo.Width || mask.Height != albedo.Height)
        {
            resizedMask = new Bitmap(albedo.Width, albedo.Height);
            using (var g = Graphics.FromImage(resizedMask))
                g.DrawImage(mask, 0, 0, albedo.Width, albedo.Height);
            mask = resizedMask;
        }

        var rect = new Rectangle(0, 0, albedo.Width, albedo.Height);
        var albData = albedo.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var maskData = mask.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* alb = (byte*)albData.Scan0;
                byte* msk = (byte*)maskData.Scan0;
                int stride = albData.Stride;
                for (int y = 0; y < albedo.Height; y++)
                {
                    for (int x = 0; x < albedo.Width; x++)
                    {
                        int off = y * stride + x * 4;
                        // R channel of mask → Color Ramp input
                        float rampInput = msk[off + 2] / 255f;
                        // Alpha of mask → mix factor
                        float mixFactor = msk[off + 3] / 255f;
                        if (mixFactor < 0.01f)
                            continue;

                        var (c1, c2, blend) = InterpolateGradient(entries, rampInput);
                        float gr = c1.R * (1 - blend) + c2.R * blend;
                        float gg = c1.G * (1 - blend) + c2.G * blend;
                        float gb = c1.B * (1 - blend) + c2.B * blend;

                        // Mix: A = albedo, B = gradient, factor = mask alpha
                        alb[off + 0] = (byte)(alb[off + 0] * (1 - mixFactor) + gb * mixFactor);
                        alb[off + 1] = (byte)(alb[off + 1] * (1 - mixFactor) + gg * mixFactor);
                        alb[off + 2] = (byte)(alb[off + 2] * (1 - mixFactor) + gr * mixFactor);
                    }
                }
            }
        }
        finally
        {
            albedo.UnlockBits(albData);
            mask.UnlockBits(maskData);
            resizedMask?.Dispose();
        }
    }

    [Flags]
    private enum MaterialKind
    {
        None = 0,
        Skin = 1 << 0,
        Hair = 1 << 1,
        Eyebrow = 1 << 2,
        Eye = 1 << 3,
        Makeup = 1 << 4,
        Nail = 1 << 5,
        Decal = 1 << 6,
        Glass = 1 << 7,
    }

    private static bool ContainsAny(string name, params string[] keys)
    {
        foreach (var k in keys)
            if (name.Contains(k, StringComparison.OrdinalIgnoreCase))
                return true;
        return false;
    }

    /// <summary>
    /// Decal roughness/metalness: placeholder (black=0, white=1) * scale + bias.
    /// </summary>
    private (float roughness, float metalness) GetDecalRoughMetal(string name)
    {
        float rough = 0.8f, metal = 0f;

        Material? mat = null;
        if (SelectedAppearance?.RawMaterials.TryGetValue(name, out var m) == true)
            mat = m;

        if (mat?.Values == null)
            return (rough, metal);

        float ReadScaleBias(string texKey, string scaleKey, string biasKey, float fallback)
        {
            float baseVal = fallback;
            if (mat.Values.TryGetValue(texKey, out var texObj) && texObj is CResourceReference<ITexture> texRef)
            {
                var path = texRef.DepotPath.GetResolvedText() ?? "";
                if (path.Contains("black", StringComparison.OrdinalIgnoreCase))
                    baseVal = 0f;
                else if (path.Contains("white", StringComparison.OrdinalIgnoreCase))
                    baseVal = 1f;
                else if (path.Contains("grey", StringComparison.OrdinalIgnoreCase) || path.Contains("gray", StringComparison.OrdinalIgnoreCase))
                    baseVal = 0.5f;
            }

            float scale = 1f, bias = 0f;
            if (mat.Values.TryGetValue(scaleKey, out var scaleObj))
            {
                if (scaleObj is CFloat cf)
                    scale = (float)cf;
                else if (scaleObj is float f)
                    scale = f;
            }
            if (mat.Values.TryGetValue(biasKey, out var biasObj))
            {
                if (biasObj is CFloat cf)
                    bias = (float)cf;
                else if (biasObj is float f)
                    bias = f;
            }

            return Math.Clamp(baseVal * scale + bias, 0f, 1f);
        }

        rough = ReadScaleBias("Roughness", "RoughnessScale", "RoughnessBias", 0.8f);
        metal = ReadScaleBias("Metalness", "MetalnessScale", "MetalnessBias", 0f);
        return (rough, metal);
    }

    /// <summary>Swap G and B so tangent normals read as blue (Z in B).</summary>
    private static void SwapGreenBlue(Bitmap bmp)
    {
        var rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
        var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                int stride = data.Stride;
                for (int y = 0; y < bmp.Height; y++)
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        int off = y * stride + x * 4;
                        (ptr[off + 0], ptr[off + 1]) = (ptr[off + 1], ptr[off + 0]);
                    }
            }
        }
        finally { bmp.UnlockBits(data); }
    }

    private static MaterialKind ClassifyMaterial(string? name, string? basePath = null)
    {
        if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(basePath))
            return MaterialKind.None;

        var kind = MaterialKind.None;
        var path = (basePath ?? "").Replace('/', '\\').ToLowerInvariant();
        // Hair-like: hh_ / hair / dread / beard, cards/cap, or hair_profiles path
        bool isHairLikeName = !string.IsNullOrEmpty(name) &&
                              (ContainsAny(name, "hh_", "hair", "dread", "beard", "mustache", "soul_patch") ||
                               name.Contains("hair_cap", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("_hair_cap", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("hair_card", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("_cards", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("_cap", StringComparison.OrdinalIgnoreCase) ||
                               name.Contains("strand", StringComparison.OrdinalIgnoreCase));

        // 1. Base material path (primary, like Blender addon registry)
        if (!string.IsNullOrEmpty(path))
        {
            if (path.EndsWith("skin.mt") || path.EndsWith("skin_blendable.mt") || path.EndsWith("skin_morph.mt") ||
                path.Contains("blackwall_blendable_skin"))
                kind |= MaterialKind.Skin;

            if (path.EndsWith("hair.mt") || path.EndsWith("hair_blendable.mt") ||
                path.Contains("blackwall_blendable_hair") || path.Contains("beard") ||
                path.Contains("hair_profiles") || path.Contains("\\hair\\"))
                kind |= MaterialKind.Hair;

            // Decals: skip pure Decal for hair-like names that use mesh_decal_gradientmap_recolor
            // (those keep special Hair/cap processing for MaskTexture + GradientMap)
            if ((path.Contains("mesh_decal") || path.Contains("decal_forward") ||
                 path.Contains("trail_decal") || path.Contains("vehicle_mesh_decal")) &&
                !isHairLikeName)
                kind |= MaterialKind.Decal;

            // metal_base is never a Decal by name alone (matches Blender addon:
            // classification is by base template path only).
            // Pure metal_base goes through the normal PBR path.

            // Eyes: match addon templates and common .mi paths.
            // Eyeball: eye.mt / eye_gradient.mt / eyeball_base.mi
            // Lashes / wetness: eyelash*.mi / eye_shadow*.mi / eye_wet
            if (!path.Contains("makeup") &&
                (path.EndsWith("eye.mt") || path.EndsWith("eye_blendable.mt") ||
                 path.Contains("eye_gradient") || path.Contains("blackwall_blendable_eye") ||
                 path.Contains("eye_shadow") || path.Contains("eye_wet") ||
                 path.Contains("eyelash") || path.Contains("eyeshadow") ||
                 path.Contains("eyeball") || path.Contains("\\eyes\\")))
                kind |= MaterialKind.Eye;

            if (path.Contains("makeup") || path.Contains("freckle") || path.Contains("eyebrow"))
                kind |= MaterialKind.Makeup;

            if (path.Contains("glass"))
                kind |= MaterialKind.Glass;
        }

        // 2. Name keywords (fallback + Hair exception for caps)
        if (!string.IsNullOrEmpty(name))
        {
            // Hair / cap always checked (covers hair caps on mesh_decal_gradientmap_recolor.mt)
            if (isHairLikeName)
                kind |= MaterialKind.Hair;

            // Other keywords only when base path gave nothing.
            // Name-based Decal for stitches/zipper/etc. so they get normals + alpha
            // even when the base template is metal_base (not mesh_decal).
            if (kind == MaterialKind.None)
            {
                if (ContainsAny(name, "h0_", "t0_", "skin", "head", "face"))
                    kind |= MaterialKind.Skin;

                if (ContainsAny(name, "heb_", "hb_", "brow"))
                    kind |= MaterialKind.Eyebrow;

                if ((name.Contains("he_", StringComparison.OrdinalIgnoreCase) &&
                     !name.Contains("heb_", StringComparison.OrdinalIgnoreCase)) ||
                    ContainsAny(name, "eyeball", "eyelash", "lash", "eyeshadow", "eyewetness",
                                "eye_wet", "wetness", "splineModeling", "eye_shadow", "eyemat", "_eye"))
                    kind |= MaterialKind.Eye;

                if (ContainsAny(name, "hx_", "freckle", "frecle", "makeup", "lip", "tattoo"))
                    kind |= MaterialKind.Makeup;

                if (name.Contains("nail") || name.StartsWith("an0_") || name.StartsWith("an_"))
                    return MaterialKind.Nail;

                if (ContainsAny(name, "sticker", "decal", "stitch", "zipper", "bead1", "bead2", "bead3", "_scar", "cyberware", "dec1", "dec2", "dec3"))
                    kind |= MaterialKind.Decal;

                if (name.Contains("glass", StringComparison.OrdinalIgnoreCase))
                    kind |= MaterialKind.Glass;
            }
        }

        return kind;
    }
    private static bool Has(MaterialKind kind, MaterialKind flag) => (kind & flag) != 0;
}
