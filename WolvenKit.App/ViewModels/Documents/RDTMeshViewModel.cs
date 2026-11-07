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
using WolvenKit.App.ViewModels.Documents.Multilayer;
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

            EnsureEffectsManager();

            //EnvironmentMap = GetOrCreateTexture(Path.Combine(ISettingsManager.GetTemp_OBJPath(), "Cubemap_Grandcanyon.dds"));
            // Depth precision depends on the near/far ratio. The old 1e8 far plane with the
            // default tiny near plane left ~mm..cm depth resolution at character distance,
            // so a body under clothes (or a leg under ripped pants) z-fought through them.
            // Characters and props need fine depth; sectors and blocks need range.
            var (near, far) = _data switch
            {
                worldStreamingBlock => (1.0, 1E+6),
                worldStreamingSector => (0.1, 1E+5),
                _ => (0.01, 1E+4),
            };
            Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera()
            {
                NearPlaneDistance = near,
                FarPlaneDistance = far,
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
                    PanelVisibility.ShowSearchPanel = true;
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
        ClearMultilayerShaderCache();
        _fileCache.Clear();

        var em = EffectsManager;
        EffectsManager = null;
        em?.Dispose();
    }

    private CMeshMaterialEntry? _generatedEntry;
    private CHandle<CMaterialInstance>? _generatedInstanceHandle;
    private CHandle<meshMeshAppearance>? _generatedAppearance;

    private static bool s_multilayerDiagnosticsLogged;

    public void EnsureEffectsManager()
    {
        if (EffectsManager is null || EffectsManager.IsDisposed)
        {
            // Default Helix effects + the multilayer pass. The shader is compiled once per
            // process; if that fails the pass is missing and multilayer materials are baked.
            var sw = System.Diagnostics.Stopwatch.StartNew();
            EffectsManager = new MultilayerEffectsManager();
            if (!MultilayerShader.IsAvailable)
            {
                _loggerService.Warning($"[ML shader] not available, multilayer materials will be baked: {MultilayerShader.LastError}");
            }
            else if (sw.ElapsedMilliseconds > 200)
            {
                _loggerService.Debug($"[ML shader] effects ready in {sw.ElapsedMilliseconds} ms");
            }

            // The full report (vertex output / pixel input layouts, constant buffer check) only
            // when something is off, once per session.
            if (MultilayerShader.HasWarnings && !string.IsNullOrEmpty(MultilayerShader.Diagnostics) &&
                !s_multilayerDiagnosticsLogged)
            {
                s_multilayerDiagnosticsLogged = true;
                _loggerService.Warning("[ML shader] " + MultilayerShader.Diagnostics.TrimEnd());
            }
        }
    }

    private void RollbackGeneratedData()
    {
        if (_data is not CMesh data)
            return;

        if (materialWasAutoGenerated)
        {
            materialWasAutoGenerated = false;
            if (_generatedEntry != null)
                data.MaterialEntries.Remove(_generatedEntry);
            if (_generatedInstanceHandle != null)
                data.PreloadLocalMaterialInstances.Remove(_generatedInstanceHandle);
            _generatedEntry = null;
            _generatedInstanceHandle = null;
        }

        if (appearanceWasAutoGenerated)
        {
            appearanceWasAutoGenerated = false;
            if (_generatedAppearance != null)
                data.Appearances.Remove(_generatedAppearance);
            _generatedAppearance = null;
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

            // Once materials were generated in this tab, other appearances get theirs on
            // selection: no grey models until Generate is pressed again.
            if (_materialsGenerated)
            {
                _ = AutoGenerateMaterialsAsync();
            }
        }

        base.OnPropertyChanged(e);
    }

    private bool _materialsGenerated;
    private bool _autoGenerating;

    /// <summary>
    /// Generates the materials of the selected appearance after a switch (cached materials are
    /// reused, so this is quick). If the selection changes again meanwhile, the newest one
    /// is generated next.
    /// </summary>
    private async Task AutoGenerateMaterialsAsync()
    {
        if (_autoGenerating)
        {
            return;
        }

        _autoGenerating = true;
        try
        {
            while (IsLoadingMaterials)
            {
                await Task.Delay(50);
            }

            Appearance? done = null;
            while (SelectedAppearance is { } current && !ReferenceEquals(done, current))
            {
                done = current;
                await GenerateMaterials(clearCache: false);
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] materials for the selected appearance: {ex.Message}");
        }
        finally
        {
            _autoGenerating = false;
        }
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
                // The albedo PNG may only exist now: re-decide transparency for it.
                ApplyRenderFlags(sm);
            }
        }

        RefreshMultilayerDebugMaterials();
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

        // If there are no local materials defined that we can use to render the mesh, generate one
        if (data.MaterialEntries.Count == 0 || data.MaterialEntries.All((entry) => !entry.IsLocalInstance))
        {
            materialWasAutoGenerated = true;
            _generatedEntry = new CMeshMaterialEntry() { Name = (CName)"default (generated)", Index = 0, IsLocalInstance = true };
            data.MaterialEntries.Add(_generatedEntry);
            var generatedInstance = new CMaterialInstance()
            {
                BaseMaterial = new CResourceReference<RED4.Types.IMaterial>(@"engine\materials\metal_base.remt")
            };
            generatedInstance.Values.Add(new CKeyValuePair("BaseColor", (ResourcePath)@"base\surfaces\materials\default\debug_d.xbm"));
            _generatedInstanceHandle = new CHandle<CMaterialInstance>(generatedInstance);
            data.PreloadLocalMaterialInstances.Add(_generatedInstanceHandle);
        }

        if (data.Appearances.Count == 0)
        {
            appearanceWasAutoGenerated = true;
            var app = new meshMeshAppearance();

            for (var i = 0; i < 21; i++)
            {
                app.ChunkMaterials.Add((CName)"default (generated)");
            }

            _generatedAppearance = new CHandle<meshMeshAppearance>(app);
            data.Appearances.Add(_generatedAppearance);
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
            var inst = GetLocalMaterialInstance(data, me.Index);
            if (inst == null)
            {
                Parent?.GetLoggerService().Warning($"No local material with index {me.Index} found.");
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
                _buildingAppearance = appearance;
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

            var inst = GetLocalMaterialInstance(mesh, me.Index);

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

            // Smooth per-vertex tangent frame from the preview UVs (see ComputeSmoothTangentFrame).
            // The shaders use it instead of the per-triangle screen-space frame, which showed
            // the triangles of smooth normal-mapped surfaces.
            // xyz only: ToVector3() divides by w, which is the handedness sign here (±1).
            List<SharpDX.Vector3>? sourceTangents = null;
            if (mesh.tangents.Length == positions.Count)
            {
                sourceTangents = new List<SharpDX.Vector3>(mesh.tangents.Length);
                foreach (var mt in mesh.tangents)
                {
                    sourceTangents.Add(new SharpDX.Vector3(mt.X, mt.Y, mt.Z));
                }
            }

            Vector3Collection tangents;
            Vector3Collection? bitangents;
            try
            {
                ComputeSmoothTangentFrame(positions, normals, textureCoordinates, indices, out tangents, out var smoothB, sourceTangents);
                bitangents = smoothB;
            }
            catch (Exception ex)
            {
                // Never let the tangent frame stop the preview: fall back to Helix's own.
                _loggerService.Warning($"[Tangents] submesh {index}: {ex.Message}");
                MeshBuilder.ComputeTangents(positions, normals, textureCoordinates, indices, out tangents, out var helixB);
                bitangents = helixB;
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
                    Tangents = tangents,
                    BiTangents = bitangents
                },
                // No per-submesh bias: a body submesh with a high index used to be pulled
                // in front of the clothes over it. Only coplanar overlay layers get a bias below.
                DepthBias = 0
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

            ApplyRenderFlags(sm);

            list.Add(sm);
            index++;
        }

        return list;

    }

    /// <summary>
    /// Transparency, depth bias and culling for a submesh, from its material kind, mask
    /// settings and (once baked) the albedo PNG's alpha. Called when the mesh is built and
    /// again after materials are generated, since the PNG may not exist on first build.
    /// </summary>
    private void ApplyRenderFlags(SubmeshComponent sm)
    {
        if (string.IsNullOrEmpty(sm.MaterialName))
            return;

        sm.IsTransparent = false;
        sm.DepthBias = 0;

        // Multilayer in the shader is always opaque (the shader has no alpha). Transparent
        // draws go through Helix's OIT passes, which would show it without its layers.
        if (_multilayerGpuData.ContainsKey(sm.MaterialName))
        {
            return;
        }

        var kind = ClassifyMaterialFor(sm.MaterialName);

        if (Has(kind, MaterialKind.Makeup) || Has(kind, MaterialKind.Eyebrow))
        {
            // Coplanar with the face/skin: just enough bias to win the depth test.
            sm.DepthBias = -2;
            sm.IsTransparent = true;
        }
        else if (Has(kind, MaterialKind.Eye))
        {
            TryGetRawMaterial(sm.MaterialName, out var eyeMat);
            switch (GetEyePart(eyeMat, sm.MaterialName))
            {
                case EyePart.Eyeball:
                    // Solid: sorting it as transparent let the shadow/wet shells flicker through.
                    break;
                case EyePart.Lashes:
                    sm.IsTransparent = true;
                    sm.DepthBias = -1;
                    MakeTwoSided(sm);   // strands seen from both sides, lit correctly on each
                    break;
                default:
                    // Shadow / wetness shells sit just over the eyeball.
                    sm.IsTransparent = true;
                    sm.DepthBias = -1;
                    break;
            }
        }
        else if (Has(kind, MaterialKind.Glass))
        {
            sm.IsTransparent = true;
            sm.DepthBias = -1;
        }
        else if (Has(kind, MaterialKind.Decal))
        {
            // Lies on the base mesh: tiny bias only.
            sm.DepthBias = -1;
            sm.IsTransparent = true;
        }
        else if (Has(kind, MaterialKind.Hair))
        {
            // Transparent so Viewport OIT can sort cards; hard alpha clip is baked into the texture.
            sm.IsTransparent = true;
            // Double-sided: hair cards must render from both sides (matches typical hair / EEVEE)
            MakeTwoSided(sm);
        }

        if (sm.IsTransparent || !TryGetRawMaterial(sm.MaterialName, out var alphaMat) || alphaMat.Values == null)
            return;

        // Cutout / masked materials (chains, fences). The bake makes their alpha binary,
        // so blending it shows exactly the cut-out shape. Rendered opaque, the transparent
        // parts of the strip would show as a solid band around the chain.
        var isCutout = alphaMat.Name.Contains("chain", StringComparison.OrdinalIgnoreCase);
        if (!isCutout && alphaMat.Instance is CMaterialInstance alphaInst && alphaInst.EnableMask)
            isCutout = true;
        if (!isCutout && alphaMat.Values.TryGetValue("AlphaThreshold", out var atObj))
        {
            var at = ReadFloat(atObj);
            isCutout = at > 0.001f && at < 0.99f;
        }

        if (isCutout || alphaMat.Values.ContainsKey("MaskTexture"))
        {
            sm.IsTransparent = true;
            return;
        }

        var png = Path.Combine(ISettingsManager.GetTemp_OBJPath(), sm.MaterialName + "_d.png");
        if (PngHasAlphaVariationCached(png))
            sm.IsTransparent = true;
    }

    // original geometry -> its two-sided version; and the set of two-sided results
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<HelixToolkit.SharpDX.Core.Geometry3D, TwoSidedGeometry> _twoSidedByOriginal = new();
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<HelixToolkit.SharpDX.Core.Geometry3D, TwoSidedGeometry> _twoSidedResults = new();

    // Winding convention fallback for MakeTwoSided; see the note in BuildTwoSided.
    private const bool TwoSidedInvertFront = false;

    private sealed record TwoSidedGeometry(HelixToolkit.SharpDX.Core.MeshGeometry3D Geometry, bool FrontCounterClockwise);

    /// <summary>
    /// Proper double-sided rendering for strands (hair cards, lashes).
    /// With CullMode.None the back of a card is drawn with the front's normal, so the side
    /// facing the camera was lit as if facing away and the hidden side caught the highlight.
    /// Instead the triangles are duplicated with reversed winding and flipped normals, and
    /// back faces are culled: each side is drawn by its own copy, with its own normal.
    /// Built once per geometry; clones and repeated calls reuse it.
    /// </summary>
    private void MakeTwoSided(SubmeshComponent sm)
    {
        if (sm.Geometry is not HelixToolkit.SharpDX.Core.MeshGeometry3D geometry ||
            geometry.Positions == null || geometry.Indices == null || geometry.Indices.Count < 3)
        {
            sm.CullMode = SharpDX.Direct3D11.CullMode.None;
            return;
        }

        if (!_twoSidedResults.TryGetValue(geometry, out var twoSided))
        {
            twoSided = _twoSidedByOriginal.GetValue(geometry, BuildTwoSided);
            _twoSidedResults.GetValue(twoSided.Geometry, _ => twoSided);
            sm.Geometry = twoSided.Geometry;
        }

        sm.FrontCounterClockwise = twoSided.FrontCounterClockwise;
        sm.CullMode = SharpDX.Direct3D11.CullMode.Back;
    }

    private static TwoSidedGeometry BuildTwoSided(HelixToolkit.SharpDX.Core.Geometry3D source)
    {
        var src = (HelixToolkit.SharpDX.Core.MeshGeometry3D)source;
        var positions = src.Positions!;
        var indices = src.Indices!;
        var n = positions.Count;
        var normals = src.Normals != null && src.Normals.Count == n ? src.Normals : null;
        var uvs = src.TextureCoordinates != null && src.TextureCoordinates.Count == n ? src.TextureCoordinates : null;
        var tangents = src.Tangents != null && src.Tangents.Count == n ? src.Tangents : null;
        var triCount = indices.Count / 3;

        // Emulates the game's two-sided hair shading for preview lighting.
        //
        // Hair cards have (1) triangles with mixed winding inside one flat strand and
        // (2) "shell" normals that point away from the head, nearly in the card plane.
        // Per-triangle decisions made either seams (lit/dark triangles) or facets.
        //
        // 1. Weld vertices by position and orient every connected strand consistently
        //    (like "recalculate normals"), then face each strand toward its vertex normals.
        // 2. Per vertex, average the oriented face normals: a smooth "card side" direction.
        // 3. Copy 1 = oriented winding, normals mirrored through the card onto that side;
        //    copy 2 = reversed winding, normals mirrored onto the other side.
        //    Mirroring keeps the in-plane (shell) part, so shading stays smooth along the
        //    strand and the side facing the camera always has a normal toward the camera.

        // --- 1a. weld by position
        var weld = new int[n];
        var weldIds = new Dictionary<(long, long, long), int>();
        for (var v = 0; v < n; v++)
        {
            var p = positions[v];
            var key = ((long)Math.Round(p.X * 1e5), (long)Math.Round(p.Y * 1e5), (long)Math.Round(p.Z * 1e5));
            if (!weldIds.TryGetValue(key, out var id))
            {
                id = weldIds.Count;
                weldIds[key] = id;
            }
            weld[v] = id;
        }

        var tris = new int[triCount * 3];
        for (var k = 0; k < tris.Length; k++)
            tris[k] = indices[k];

        // --- 1b. edge adjacency on welded ids
        var edges = new Dictionary<(int, int), List<int>>();
        for (var t = 0; t < triCount; t++)
        {
            for (var e = 0; e < 3; e++)
            {
                var a = weld[tris[t * 3 + e]];
                var b = weld[tris[t * 3 + (e + 1) % 3]];
                if (a == b)
                    continue;
                var key = a < b ? (a, b) : (b, a);
                if (!edges.TryGetValue(key, out var list))
                {
                    list = new List<int>(2);
                    edges[key] = list;
                }
                list.Add(t);
            }
        }

        bool HasDirectedEdge(int t, int a, int b)
        {
            for (var e = 0; e < 3; e++)
            {
                if (weld[tris[t * 3 + e]] == a && weld[tris[t * 3 + (e + 1) % 3]] == b)
                    return true;
            }
            return false;
        }

        void FlipTriangle(int t) => (tris[t * 3 + 1], tris[t * 3 + 2]) = (tris[t * 3 + 2], tris[t * 3 + 1]);

        SharpDX.Vector3 FaceNormal(int t)
        {
            var p0 = positions[tris[t * 3]];
            return SharpDX.Vector3.Cross(positions[tris[t * 3 + 1]] - p0, positions[tris[t * 3 + 2]] - p0);
        }

        // --- 1c. orient each connected strand consistently, then toward its normals
        var visited = new bool[triCount];
        var queue = new Queue<int>();
        var component = new List<int>();
        for (var start = 0; start < triCount; start++)
        {
            if (visited[start])
                continue;

            component.Clear();
            visited[start] = true;
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                var t = queue.Dequeue();
                component.Add(t);
                for (var e = 0; e < 3; e++)
                {
                    var a = weld[tris[t * 3 + e]];
                    var b = weld[tris[t * 3 + (e + 1) % 3]];
                    if (a == b || !edges.TryGetValue(a < b ? (a, b) : (b, a), out var neighbours))
                        continue;
                    foreach (var u in neighbours)
                    {
                        if (visited[u])
                            continue;
                        // consistent neighbours traverse a shared edge in opposite directions
                        if (HasDirectedEdge(u, a, b))
                            FlipTriangle(u);
                        visited[u] = true;
                        queue.Enqueue(u);
                    }
                }
            }

            if (normals == null)
                continue;

            var agreement = 0f;
            foreach (var t in component)
            {
                var vn = normals[tris[t * 3]] + normals[tris[t * 3 + 1]] + normals[tris[t * 3 + 2]];
                agreement += SharpDX.Vector3.Dot(FaceNormal(t), vn);
            }
            if (agreement < 0)
            {
                foreach (var t in component)
                    FlipTriangle(t);
            }
        }

        // --- 2. smooth card-side direction per welded vertex (area weighted)
        var side = new SharpDX.Vector3[weldIds.Count];
        for (var t = 0; t < triCount; t++)
        {
            var f = FaceNormal(t);
            side[weld[tris[t * 3]]] += f;
            side[weld[tris[t * 3 + 1]]] += f;
            side[weld[tris[t * 3 + 2]]] += f;
        }
        for (var k = 0; k < side.Length; k++)
        {
            if (side[k].LengthSquared() > 1e-20f)
                side[k].Normalize();
        }

        // --- 3. two copies
        var outPositions = new Vector3Collection(n * 2);
        var outNormals = new Vector3Collection(n * 2);
        var outUv = uvs != null ? new Vector2Collection(n * 2) : null;
        var outTangents = tangents != null ? new Vector3Collection(n * 2) : null;

        for (var pass = 0; pass < 2; pass++)
        {
            for (var v = 0; v < n; v++)
            {
                var s = pass == 0 ? side[weld[v]] : -side[weld[v]];
                var nv = normals != null ? normals[v] : s;
                if (nv == SharpDX.Vector3.Zero)
                    nv = s;
                if (s != SharpDX.Vector3.Zero)
                {
                    var d = SharpDX.Vector3.Dot(nv, s);
                    if (d < 0)
                        nv -= 2f * d * s;   // mirror through the card plane
                }
                if (nv.LengthSquared() > 1e-20f)
                    nv.Normalize();

                outPositions.Add(positions[v]);
                outNormals.Add(nv);
                outUv?.Add(uvs![v]);
                outTangents?.Add(tangents![v]);
            }
        }

        var outIndices = new IntCollection(triCount * 6);
        for (var t = 0; t < triCount; t++)
        {
            outIndices.Add(tris[t * 3]);
            outIndices.Add(tris[t * 3 + 1]);
            outIndices.Add(tris[t * 3 + 2]);
        }
        for (var t = 0; t < triCount; t++)
        {
            outIndices.Add(tris[t * 3] + n);
            outIndices.Add(tris[t * 3 + 2] + n);
            outIndices.Add(tris[t * 3 + 1] + n);
        }

        Vector3Collection? outBiTangents = null;
        if (outUv != null)
        {
            // Frame of the doubled geometry (mirrored normals), with matching bitangents.
            try
            {
                ComputeSmoothTangentFrame(outPositions, outNormals, outUv, outIndices, out var frameT, out var frameB);
                outTangents = frameT;
                outBiTangents = frameB;
            }
            catch
            {
                // keep the copied tangents; Helix falls back without bitangents
            }
        }

        var doubled = new HelixToolkit.SharpDX.Core.MeshGeometry3D()
        {
            Positions = outPositions,
            Indices = outIndices,
            Normals = outNormals,
            TextureCoordinates = outUv,
            Tangents = outTangents,
            BiTangents = outBiTangents,
        };

        // Copy 1 triangles agree with the side direction (right-hand rule): counter-clockwise
        // on screen when facing the camera in a right-handed view.
        // If both sides ever look inverted (lit from behind again), flip TwoSidedInvertFront.
        return new TwoSidedGeometry(doubled, FrontCounterClockwise: !TwoSidedInvertFront);
    }

    /// <summary>
    /// Material lookup by cache name. SelectedAppearance is not set yet while a mesh or
    /// entity is being built, so also look in the appearance under construction and in
    /// every loaded appearance.
    /// </summary>
    private bool TryGetRawMaterial(string name, [System.Diagnostics.CodeAnalysis.MaybeNullWhen(false)] out Material material)
    {
        var selected = SelectedAppearance;
        if (selected != null && selected.RawMaterials.TryGetValue(name, out material))
            return true;

        var building = _buildingAppearance;
        if (building != null && building.RawMaterials.TryGetValue(name, out material))
            return true;

        foreach (var app in Appearances)
        {
            if (app.RawMaterials.TryGetValue(name, out material))
                return true;
        }

        material = null!;
        return false;
    }

    private Appearance? _buildingAppearance;

    /// <summary>
    /// Quick check: does the PNG contain meaningful alpha variation
    /// (not all opaque, not all transparent)? Samples a grid to stay fast.
    /// </summary>
    // path|ticks -> result; decoding the PNG per submesh was a large part of sector load time
    private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, bool> s_alphaVariationCache = new();

    private static bool PngHasAlphaVariationCached(string path)
    {
        long ticks;
        try
        {
            var fi = new FileInfo(path);
            if (!fi.Exists || fi.Length == 0)
                return false;
            ticks = fi.LastWriteTimeUtc.Ticks;
        }
        catch
        {
            return false;
        }

        return s_alphaVariationCache.GetOrAdd(path + "|" + ticks, _ => PngHasAlphaVariation(path));
    }

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

        if (UseMultilayerShader && _multilayerGpuData.TryGetValue(name, out var multilayerData))
        {
            return SetupMultilayerShaderMaterial(name, multilayerData);
        }

        PBRMaterial material;
        if (Materials.TryGetValue(name, out var cachedMaterial) && cachedMaterial is MultilayerPBRMaterial shaderMaterial)
        {
            material = cachedMaterial;
            // Was shown by the multilayer shader before: back to plain PBR maps.
            shaderMaterial.MultilayerData = null;
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
            // MultilayerPBRMaterial also for plain maps: it renders them with the smooth
            // tangent frame (Helix's own PBR shows the triangles of normal-mapped surfaces).
            material = new MultilayerPBRMaterial
            {
                // Vertex tangent frame (smooth); geometry always carries tangents + bitangents.
                EnableAutoTangent = false,
                RenderShadowMap = true,
                RenderEnvironmentMap = true
            };
            Materials[name] = material;
        }

        material.AlbedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
        material.EnableAutoTangent = false; // vertex tangent frame, see ComputeSmoothTangentFrame

        var (filename_bd, filename_bn, filename_rm) = GetMaterialFilePathsFromCache(name);

        // Root template of the instance chain (like the Blender addon registry) decides the kind.
        // basePath keeps both the template and the direct base for the substring checks below.
        TryGetRawMaterial(name, out var classMat);
        var kind = ClassifyMaterialFor(name, classMat);
        var basePath = GetClassificationPath(classMat);

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
            else if (TryGetRawMaterial(name, out var dMat) && dMat?.Values != null)
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
            // Preview-only darkening (on top of the baked ×0.6): the preview has plain PBR
            // lighting, without the game's hair shading, so the base colour is toned down.
            material.AlbedoColor = new SharpDX.Color4(HairPreviewAlbedo, HairPreviewAlbedo, HairPreviewAlbedo, 1f);
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
            // Constant roughness per part: the baked eye RM is grayscale in every channel,
            // so as a map it would also drive metalness.
            material.RenderRoughnessMetallicMap = false;

            var part = GetEyePart(classMat, name);
            switch (part)
            {
                case EyePart.Lashes:
                    material.RoughnessFactor = EyeLashRoughness;     // matte strands
                    break;
                case EyePart.Shadow:
                    material.RoughnessFactor = 1f;                   // pure darkening, no highlight
                    break;
                case EyePart.Wet:
                    material.RoughnessFactor = EyeWetRoughness;      // thin glossy film
                    break;
                default:
                    material.RoughnessFactor = EyeballRoughness;     // wet, glossy eyeball
                    break;
            }

            if (File.Exists(filename_bd))
            {
                material.AlbedoMap = GetOrCreateTexture(filename_bd);
                material.RenderAlbedoMap = true;
            }
            else if (part == EyePart.Wet)
            {
                // Wetness film without its own colour: almost invisible, only the highlight shows.
                material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.15f);
            }

            if (File.Exists(filename_bn) && part != EyePart.Shadow)
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
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

        // glass (base\materials\glass.mt)
        // Baked PNG already mixes TintColor glass with MaskTexture label.
        if (Has(kind, MaterialKind.Glass))
        {
            material.RenderEnvironmentMap = true;
            material.MetallicFactor = 0.1f;
            material.RoughnessFactor = 0.05f;
            material.RenderAlbedoMap = false;

            float opacity = GlassDefaultOpacity;
            float tr = 1f, tg = 1f, tb = 1f;
            if (TryGetRawMaterial(name, out var glassMat) && glassMat?.Values != null)
            {
                if (glassMat.Values.TryGetValue("Opacity", out var opObj))
                    opacity = Math.Clamp(ReadFloat(opObj), 0f, 1f);
                if (glassMat.Values.TryGetValue("TintColor", out var tintObj))
                {
                    if (tintObj is CColor cc)
                    {
                        tr = cc.Red / 255f;
                        tg = cc.Green / 255f;
                        tb = cc.Blue / 255f;
                    }
                    else if (tintObj is Vector4 tv)
                    {
                        tr = tv.X;
                        tg = tv.Y;
                        tb = tv.Z;
                    }
                }
            }

            if (File.Exists(filename_bd))
            {
                material.AlbedoMap = GetOrCreateTexture(filename_bd);
                material.RenderAlbedoMap = true;
                // Alpha already baked (glass Opacity + label coverage).
                material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 1f);
            }
            else
            {
                material.AlbedoColor = new SharpDX.Color4(tr, tg, tb, opacity);
            }
            if (File.Exists(filename_bn))
            {
                material.NormalMap = GetOrCreateTexture(filename_bn);
                material.RenderNormalMap = true;
            }
            return material;
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
        if (!isEmissive && TryGetRawMaterial(name, out var emMat) &&
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
            if (TryGetRawMaterial(name, out var emVals) && emVals?.Values != null)
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
            if (TryGetRawMaterial(name, out var evMat) &&
                evMat?.Values?.TryGetValue("EmissiveEV", out var evObj) == true)
            {
                ev = ReadFloat(evObj);
            }

            // Optional EmissiveColor (Color or Vector4)
            float cr = 1f, cg = 1f, cb = 1f;
            if (TryGetRawMaterial(name, out var colMat) &&
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
                if (TryGetRawMaterial(name, out var scaleMat) &&
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

                // BaseColorScale: when the albedo was baked from a BaseColor texture, the
                // scale is already multiplied into the PNG (see the BaseColor bake), so do not
                // apply it a second time here. Otherwise use it as the tint.
                var albedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
                if (TryGetRawMaterial(name, out var matScale) &&
                    matScale?.Values?.TryGetValue("BaseColorScale", out var scaleObj) == true &&
                    scaleObj is Vector4 v4)
                {
                    var scaleBakedIn = matScale.Values.TryGetValue("BaseColor", out var bcObj) &&
                                       bcObj is CResourceReference<ITexture>;
                    albedoColor = scaleBakedIn
                        ? new SharpDX.Color4(1f, 1f, 1f, v4.W)
                        : new SharpDX.Color4(v4.X, v4.Y, v4.Z, v4.W);
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

    // BGRA byte offsets
    private const int ChannelR = 2;
    private const int ChannelA = 3;

    /// <summary>
    /// Picks the channel that actually carries coverage in a mask / alpha texture.
    /// Templates expect a fixed channel (decal mask = R, glass mask = A, …), but modded
    /// or unusual textures may store it elsewhere:
    ///  - the preferred channel varies → use it (normal case, matches the Blender addon);
    ///  - preferred A is flat (no alpha, e.g. BC1/BC4) but the image is grayscale and R
    ///    varies → the mask is single-channel, use R;
    ///  - preferred R is flat but A varies → the mask is in alpha, use A;
    ///  - nothing varies → keep the preferred channel (flat coverage).
    /// A colour texture without alpha is never read as R: colour is not coverage.
    /// </summary>
    private static int PickCoverageChannel(Bitmap bmp, int preferred)
    {
        var w = bmp.Width;
        var h = bmp.Height;
        if (w < 1 || h < 1)
            return preferred;

        var data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly,
            System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        int minA = 255, maxA = 0, minR = 255, maxR = 0;
        var grayscale = true;
        try
        {
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;
                var stride = data.Stride;
                var stepX = Math.Max(1, w / 64);
                var stepY = Math.Max(1, h / 64);
                for (int y = 0; y < h; y += stepY)
                {
                    for (int x = 0; x < w; x += stepX)
                    {
                        byte* p = ptr + y * stride + x * 4;
                        int b = p[0], g = p[1], r = p[2], a = p[3];
                        if (a < minA)
                            minA = a;
                        if (a > maxA)
                            maxA = a;
                        if (r < minR)
                            minR = r;
                        if (r > maxR)
                            maxR = r;
                        if (Math.Abs(r - g) > 8 || Math.Abs(r - b) > 8)
                            grayscale = false;
                    }
                }
            }
        }
        finally
        {
            bmp.UnlockBits(data);
        }

        const int minRange = 16;
        var aVaries = maxA - minA > minRange;
        var rVaries = maxR - minR > minRange;

        if (preferred == ChannelA)
            return aVaries ? ChannelA : (rVaries && grayscale ? ChannelR : ChannelA);

        return rVaries ? ChannelR : (aVaries ? ChannelA : ChannelR);
    }

    private static void MultiplyAlphaByMaskRed(Bitmap dest, Bitmap mask)
    {
        // Template convention is MaskTexture.r; fall back to A for masks stored in alpha.
        var maskChannel = PickCoverageChannel(mask, ChannelR);

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
                        float coverage = maskPtr[maskOff + maskChannel] / 255f;
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

    /// <summary>
    /// Resolve a depot path via IArchiveManager.GetCR2WFile, which prefers the
    /// open project over mods and the base archive (includeProject = true).
    /// Results are cached for the duration of a material load pass.
    /// </summary>
    private CR2WFile? GetProjectOrDepotFile(ResourcePath depotPath)
    {
        TrackDependency(depotPath);

        if (_fileCache.TryGetValue(depotPath, out var cached))
            return cached;

        CR2WFile? result = null;

        // Files embedded in the open document come first, as in the game: they override
        // the project, mods and the archive for the same path.
        if (FindEmbeddedContent(depotPath) is { } embedded)
        {
            result = new CR2WFile { RootChunk = embedded };
            _fileCache[depotPath] = result;
            return result;
        }

        var am = ResolveArchiveManager();

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
        _templateCache.Clear();
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

    #region bake dependency tracking

    // .deps format (one entry per line):
    //   v2                       format marker
    //   V|<hash>                 hash of the material instance's own values
    //   R|<size>                 multilayer bake resolution (2048 / 4096); only for multilayer
    //   O|<file>                 output that existed after the bake (must still exist)
    //   D|P|<path>|<len>|<ticks> dependency found in the project (size + write time)
    //   D|A|<path>               dependency from the game archive / mods (never changes)
    private const string DepsFormat = "v2";

    private readonly object _depLock = new();
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<Material, Dictionary<string, object>> _originalValues = new();
    private HashSet<string>? _currentDeps;

    private void BeginDependencyTracking()
    {
        lock (_depLock)
        {
            _currentDeps = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }
    }

    private void EndDependencyTracking()
    {
        lock (_depLock)
        {
            _currentDeps = null;
        }
    }

    private void TrackDependency(ResourcePath path)
    {
        if (path == ResourcePath.Empty)
            return;

        var text = path.GetResolvedText() ?? path.ToString() ?? string.Empty;
        if (text.Length == 0)
            return;

        lock (_depLock)
        {
            _currentDeps?.Add(text);
        }
    }

    /// <summary>
    /// Project files are stamped by size and write time; anything else comes from
    /// the game archive or installed mods and is identified by its path alone.
    /// A file copied into the project changes from "A|" to "P|" and invalidates the bake.
    /// </summary>
    private string DepStamp(string relPath)
    {
        // Embedded in the open document: no file to stamp; the content object identifies the
        // version (replacing the embedded file gives a new one).
        if (FindEmbeddedContent(relPath) is { } embedded)
        {
            return $"E|{relPath}|{System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(embedded)}";
        }

        try
        {
            var modDir = Parent?.GetActiveProject()?.ModDirectory;
            if (!string.IsNullOrEmpty(modDir))
            {
                var fi = new FileInfo(Path.Combine(modDir, relPath));
                if (fi.Exists)
                    return $"P|{relPath}|{fi.Length}|{fi.LastWriteTimeUtc.Ticks}";
            }
        }
        catch { /* treat as archive */ }

        return $"A|{relPath}";
    }

    private bool IsBakeUpToDate(string depsPath, string valuesStamp, int? resolution)
    {
        string[] lines;
        try
        {
            if (!File.Exists(depsPath))
                return false;
            lines = File.ReadAllLines(depsPath);
        }
        catch
        {
            return false;
        }

        // Old-format stamps (single hash line) fail here and trigger one rebake.
        if (lines.Length < 2 || lines[0] != DepsFormat || lines[1] != "V|" + valuesStamp)
            return false;

        var resolutionSeen = false;
        for (var i = 2; i < lines.Length; i++)
        {
            var line = lines[i];
            if (line.StartsWith("R|", StringComparison.Ordinal))
            {
                if (resolution == null || line != "R|" + resolution.Value)
                    return false;
                resolutionSeen = true;
            }
            else if (line.StartsWith("O|", StringComparison.Ordinal))
            {
                if (!File.Exists(line[2..]))
                    return false;
            }
            else if (line.StartsWith("D|", StringComparison.Ordinal))
            {
                var stamp = line[2..];
                var parts = stamp.Split('|');
                if (parts.Length < 2 || DepStamp(parts[1]) != stamp)
                    return false;
            }
        }

        // Multilayer bake made before the resolution was recorded: bake once more.
        return resolution == null || resolutionSeen;
    }

    private void WriteBakeDependencies(string depsPath, string valuesStamp, int? resolution, params string[] outputs)
    {
        try
        {
            List<string> deps;
            lock (_depLock)
            {
                deps = _currentDeps?.ToList() ?? new List<string>();
            }

            var lines = new List<string> { DepsFormat, "V|" + valuesStamp };
            if (resolution != null)
                lines.Add("R|" + resolution.Value);
            foreach (var output in outputs)
            {
                if (File.Exists(output))
                    lines.Add("O|" + output);
            }
            foreach (var dep in deps.OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            {
                lines.Add("D|" + DepStamp(dep));
            }

            File.WriteAllLines(depsPath, lines);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Debug($"[Cache] failed to write {depsPath}: {ex.Message}");
        }
    }

    /// <summary>
    /// Hash of the instance's own values. Covers local materials, which live in the
    /// mesh (in memory) rather than in a file of their own.
    /// </summary>
    private static string ComputeValuesStamp(Material material)
    {
        var sb = new System.Text.StringBuilder();

        if (material.Instance is CMaterialInstance inst)
        {
            sb.Append("base=").Append(inst.BaseMaterial.DepotPath.GetResolvedText()).Append(';');
            sb.Append("mask=").Append(inst.EnableMask ? '1' : '0').Append(';');
            foreach (var pair in inst.Values.OrderBy(p => p.Key.ToString(), StringComparer.Ordinal))
            {
                sb.Append(pair.Key.ToString()).Append('=').Append(FormatValue(pair.Value)).Append(';');
            }
        }
        else if (material.Values != null)
        {
            foreach (var (key, value) in material.Values.OrderBy(p => p.Key, StringComparer.Ordinal))
            {
                sb.Append(key).Append('=').Append(FormatValue(value)).Append(';');
            }
        }

        var bytes = System.Text.Encoding.UTF8.GetBytes(sb.ToString());
        return Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(bytes));
    }

    private static string FormatValue(object? value, int depth = 0)
    {
        var inv = System.Globalization.CultureInfo.InvariantCulture;
        switch (value)
        {
            case null:
                return "";
            case CColor c:
                return FormattableString.Invariant($"{c.Red / 255f},{c.Green / 255f},{c.Blue / 255f}");
            case Vector4 v:
                return FormattableString.Invariant($"{(float)v.X},{(float)v.Y},{(float)v.Z},{(float)v.W}");
            case CFloat f:
                return ((float)f).ToString("R", inv);
            case IRedRef r:
                return r.DepotPath.GetResolvedText() ?? r.DepotPath.ToString() ?? "";
            case string s:
                return s;
            case IConvertible ic:
                return Convert.ToString(ic, inv) ?? "";
            case System.Collections.IEnumerable list when depth < 4:
                var sb = new System.Text.StringBuilder("[");
                foreach (var item in list)
                {
                    sb.Append(FormatValue(item, depth + 1)).Append(',');
                }
                return sb.Append(']').ToString();
            default:
                return value.ToString() ?? "";
        }
    }

    #endregion

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

    public List<Material> GetMaterialsForAppearance(CMesh mesh, CName appearance, string? meshPath = null)
    {
        var materials = GetMaterialsFromMesh(mesh, meshPath);

        var appMaterials = new List<Material>();

        // Mesh without appearances: nothing to map (previously threw on Appearances[0]).
        var meshApp = mesh.Appearances
                          .Select(x => x?.Chunk)
                          .FirstOrDefault(x => x is not null && x.Name == appearance)
                      ?? mesh.Appearances.Select(x => x?.Chunk).FirstOrDefault(x => x is not null);
        if (meshApp == null)
        {
            return materials.Values.ToList();
        }

        foreach (var materialName in meshApp.ChunkMaterials)
        {
            var name = GetUniqueMaterialName(materialName.ToString().NotNull(), mesh, meshPath);
            appMaterials.Add(materials.TryGetValue(name, out var m) ? m : new Material(name));
        }

        return appMaterials;
    }

    private static readonly char[] InvalidFileNameChars = Path.GetInvalidFileNameChars();
    private const float GlassDefaultOpacity = 1f;

    // Haircard albedo multiplier in the preview, tuned by eye against the game.
    private const float HairPreviewAlbedo = 0.4f;

    // Eye parts (preview roughness)
    private const float EyeLashRoughness = 0.8f;
    private const float EyeballRoughness = 0.08f;
    private const float EyeWetRoughness = 0.05f;

    private enum EyePart { None, Eyeball, Shadow, Wet, Lashes }

    /// <summary>
    /// Which part of the eye a material is. Template / base path first (names are unreliable:
    /// eyeballs named "lashes" exist), the name only when the path says nothing.
    /// </summary>
    private EyePart GetEyePart(Material? material, string? name)
    {
        var path = GetClassificationPath(material) ?? string.Empty;
        var n = (name ?? string.Empty).ToLowerInvariant();

        if (path.Contains("eyelash") || path.Contains("\\eyes\\eyelashes") ||
            path.Contains("hair.mt") || path.Contains("hair_blendable"))
            return EyePart.Lashes;
        if (path.Contains("eye_wet"))
            return EyePart.Wet;
        if (path.Contains("eye_shadow") || path.Contains("eyeshadow"))
            return EyePart.Shadow;
        if (path.Contains("eye_gradient") || path.Contains("eye_base") || path.Contains("eyeball") ||
            path.Contains("eye.mt") || path.Contains("eye_blendable"))
            return EyePart.Eyeball;

        if (n.Contains("wetness") || n.Contains("eye_wet"))
            return EyePart.Wet;
        if (n.Contains("eyeshadow") || n.Contains("eye_shadow"))
            return EyePart.Shadow;
        if (n.Contains("eyeball") || n.Contains("eye_mat") || n.Contains("eyemat"))
            return EyePart.Eyeball;
        if (n.Contains("lash"))
            return EyePart.Lashes;

        return EyePart.None;
    }

    private static string SanitizeFileName(string name) =>
        string.Concat(name.Select(c => InvalidFileNameChars.Contains(c) ? '_' : c));

    private string GetUniqueMaterialName(string name, CMesh mesh, string? meshPathOverride = null)
    {
        _ = mesh;

        // Use the depot-relative path for the open document too, so a mesh opened on its
        // own gets the same cache names as when it is a component of an entity / sector
        // (those pass the component's depot path), and reuses those bakes.
        var identity = !string.IsNullOrEmpty(meshPathOverride)
            ? meshPathOverride
            : GetDocumentDepotPath();

        var meshFile = Path.GetFileNameWithoutExtension(identity);
        if (string.IsNullOrEmpty(meshFile) ||
            meshFile.Equals(name, StringComparison.OrdinalIgnoreCase))
        {
            return SanitizeFileName(name);
        }

        var prefix = s_meshNamePrefixCache.GetOrAdd(identity, id =>
        {
            var norm = id.Replace('/', '\\').ToLowerInvariant();
            var hash = BitConverter.ToUInt32(
                System.Security.Cryptography.SHA256.HashData(
                    System.Text.Encoding.UTF8.GetBytes(norm)), 0);
            return $"{Path.GetFileNameWithoutExtension(id)}_{hash:X8}__";
        });

        return prefix + SanitizeFileName(name);
    }

    // identity (mesh path) -> "meshFile_HASH__" ; hashing per call adds up in large sectors
    private static readonly System.Collections.Concurrent.ConcurrentDictionary<string, string> s_meshNamePrefixCache =
        new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Local material instance for a material entry. Prefers localMaterialBuffer.materials,
    /// which is what the editor shows and edits, so unsaved edits in the open mesh reach
    /// the preview; then the raw buffer and the preload list (older files).
    /// </summary>
    private static CMaterialInstance? GetLocalMaterialInstance(CMesh mesh, int index)
    {
        if (index < 0)
            return null;

        if (mesh.LocalMaterialBuffer?.Materials is { } edited && index < edited.Count &&
            edited[index] is CMaterialInstance fromEditor)
            return fromEditor;

        if (mesh.LocalMaterialBuffer?.RawData?.Buffer.Data is CR2WList raw && index < raw.Files.Count &&
            raw.Files[index].RootChunk is CMaterialInstance fromRaw)
            return fromRaw;

        if (index < mesh.PreloadLocalMaterialInstances.Count)
            return mesh.PreloadLocalMaterialInstances[index]?.GetValue() as CMaterialInstance;

        return null;
    }

    /// <summary>
    /// Depot-relative path of the open document (e.g. base\...\x.mesh): project files are
    /// made relative to the project's archive folder, archive files already are.
    /// Falls back to the absolute path if that is not available.
    /// </summary>
    private string GetDocumentDepotPath()
    {
        try
        {
            var relative = Parent?.RelativePath;
            if (!string.IsNullOrEmpty(relative))
                return relative;
        }
        catch
        {
            // RelativePath needs an active project for files on disk
        }

        return Parent?.FilePath ?? Parent?.ContentId ?? string.Empty;
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

        var label = SubmeshComponent.StripMeshPrefix(material.Name) ?? material.Name;
        var extPath = me.Index >= 0 && me.Index < mesh.ExternalMaterials.Count
            ? mesh.ExternalMaterials[me.Index].DepotPath
            : mesh.PreloadExternalMaterials != null && me.Index >= 0 && me.Index < mesh.PreloadExternalMaterials.Count
                ? mesh.PreloadExternalMaterials[me.Index].DepotPath
                : ResourcePath.Empty;
        if (extPath != ResourcePath.Empty)
        {
            WarnMissingFile("material", extPath, label);
        }
        else
        {
            Parent?.GetLoggerService()?.Warning(
                $"[Preview] {label}: external material index {me.Index} is outside externalMaterials ({mesh.ExternalMaterials.Count}) and preloadExternalMaterials ({mesh.PreloadExternalMaterials?.Count ?? 0})");
        }
    }

    private Dictionary<string, Material> GetMaterialsFromMesh(CMesh mesh, string? meshPath = null)
    {
        var materials = new Dictionary<string, Material>();

        WarnMixedMaterialLists(mesh, meshPath);

        foreach (var me in mesh.MaterialEntries)
        {
            var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), mesh, meshPath);
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

            var inst = GetLocalMaterialInstance(mesh, me.Index);

            if (inst == null)
            {

                Parent?.GetLoggerService().Warning(
                    $"[Preview] {me.Name}: local material index {me.Index} not found in localMaterialBuffer or preloadLocalMaterialInstances");
                continue;
            }

            var material = new Material(name)
            {
                Name = name,
                // Keep the instance so the bake can resolve its base material chain.
                Instance = inst
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

    /// <summary>Generate Materials button: Ctrl held = clear the cache first.</summary>
    [RelayCommand]
    public Task LoadMaterials() =>
        GenerateMaterials(CtrlKeyPressed || IsCtrlKeyPressed || Keyboard.Modifiers.HasFlag(ModifierKeys.Control));

    /// <summary>Menu entry "Clear Cache and Regenerate" (same as Ctrl + Generate Materials).</summary>
    [RelayCommand]
    private Task RegenerateMaterials() => GenerateMaterials(clearCache: true);

    private async Task GenerateMaterials(bool clearCache)
    {
        if (IsLoadingMaterials || SelectedAppearance == null)
        {
            if (SelectedAppearance == null)
                Parent?.GetLoggerService()?.Warning("No material selected!");
            return;
        }

        IsLoadingMaterials = true;
        lock (_missingFilesWarned)
        {
            _missingFilesWarned.Clear(); // report missing files once per Generate
        }

        try
        {
            RefreshMaterialsFromDisk();

            var ctrl = clearCache;
            // Multilayer is shown by the shader; 2048 is only the fallback bake (shader not
            // available / too many textures). Exports pick their size in Bake Multilayer.
            // Ctrl forces a full re-bake.
            const int bakeMax = 2048;
            var forceBake = ctrl;

            if (ctrl)
            {
                DeleteMaterialCache();
                _textureCache.Clear();
                ClearMultilayerShaderCache();
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
            _materialsGenerated = true;
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

        if (SelectedAppearance?.RawMaterials == null)
            return;

        // Meshes whose materials can change between passes:
        //  - the mesh open in this document (in memory, may be unsaved);
        //  - component meshes of an entity, re-read from project/archive.
        var sources = new List<(CMesh Mesh, string? MeshPath)>();
        if (_data is CMesh openMesh)
        {
            sources.Add((openMesh, null));
        }

        if (SelectedAppearance.Models != null)
        {
            foreach (var model in SelectedAppearance.Models)
            {
                if (model.DepotPath == ResourcePath.Empty)
                    continue;

                if (GetProjectOrDepotFile(model.DepotPath)?.RootChunk is CMesh mesh)
                    sources.Add((mesh, model.DepotPath.GetResolvedText() ?? string.Empty));
            }
        }

        foreach (var (mesh, meshPath) in sources)
        {

            foreach (var me in mesh.MaterialEntries)
            {
                var name = GetUniqueMaterialName(me.Name.ToString().NotNull(), mesh, meshPath);
                if (!SelectedAppearance.RawMaterials.TryGetValue(name, out var mat))
                    continue;

                if (me.IsLocalInstance)
                {
                    var inst = GetLocalMaterialInstance(mesh, me.Index);

                    if (inst == null)
                        continue;

                    mat.Instance = inst;
                    mat.Values = new Dictionary<string, object>();
                    foreach (var pair in inst.Values)
                    {
                        mat.Values[pair.Key.ToString().NotNull()] = pair.Value;
                    }
                }
                else
                {
                    // External material: re-resolve from project first, then archive.
                    // Reset first so a .mi removed from the project (and not found
                    // elsewhere) does not keep serving the old in-memory copy.
                    mat.Instance = null;
                    mat.Values = new Dictionary<string, object>();
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

        try
        {
            // Rebuild values from the instance on every pass so edits made in the open
            // document (local materials) are picked up, and keys merged from the base
            // chain on a previous pass do not linger.
            if (material.Instance is CMaterialInstance freshInst)
            {
                var fresh = new Dictionary<string, object>();
                foreach (var pair in freshInst.Values)
                {
                    fresh[pair.Key.ToString().NotNull()] = pair.Value;
                }
                material.Values = fresh;
            }
            else if (material.Values != null)
            {
                // No instance (e.g. sector materials): restore the values as first seen,
                // so keys added by a previous bake do not change the stamp.
                var original = _originalValues.GetValue(material, m => new Dictionary<string, object>(m.Values!));
                material.Values = new Dictionary<string, object>(original);
            }

            var (filename_bd, filename_bn, filename_rm) = GetMaterialFilePathsFromCache(material.Name);
            var emissivePng = Path.Combine(ISettingsManager.GetTemp_OBJPath(), material.Name + "_emissive.png");
            var depsPath = filename_bd + ".deps";
            var valuesStamp = ComputeValuesStamp(material);

            // Every file read from here on (base chain, mlsetup, templates, microblends,
            // profiles, gradients, textures) is recorded as a dependency of this bake.
            BeginDependencyTracking();

            var dictionary = material.Values ??= new Dictionary<string, object>();
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
                    WarnMissingFile("base material", mat.BaseMaterial.DepotPath,
                        SubmeshComponent.StripMeshPrefix(material.Name) ?? material.Name);
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

            // Nothing this material depends on has changed since the last bake: reuse it.
            // Resolution only affects the multilayer canvas; other material types bake
            // at their source texture size, so 2K/4K switching must not re-bake them.
            int? bakeResolution = dictionary.ContainsKey("MultilayerSetup")
                ? Math.Clamp(bakeMax, 256, 4096)
                : null;

            if (_exportBake)
            {
                // Export Materials: every material is baked (or taken from the cache) and
                // recorded for copying; multilayer is always re-baked at exactly the chosen size,
                // the other kinds keep the size of their source textures.
                lock (_exportBakedNames)
                {
                    _exportBakedNames.Add(material.Name);
                }

                if (dictionary.ContainsKey("MultilayerSetup"))
                {
                    forceBake = true;
                }
            }
            else if (dictionary.ContainsKey("MultilayerSetup"))
            {
                // Multilayer in the shader: textures and parameters go to the GPU, nothing is baked.
                // Falls through to the bake when the shader is off or cannot show this material.
                if (await TryBuildMultilayerGpuData(material, dictionary))
                {
                    return;
                }
            }
            else
            {
                _multilayerGpuData.TryRemove(material.Name, out _);
            }

            if (!forceBake && IsBakeUpToDate(depsPath, valuesStamp, bakeResolution))
            {
                Parent?.GetLoggerService()?.Debug($"[Cache] '{material.Name}' up to date");
                return;
            }

            Parent?.GetLoggerService()?.Debug($"Baking material: {material.Name}");

            // Something changed (or no cache yet): drop old outputs so every branch bakes again.
            foreach (var f in new[] { filename_bd, filename_bn, filename_rm, emissivePng })
            {
                try
                { if (File.Exists(f)) File.Delete(f); }
                catch { /* ignore */ }
            }

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
                    await TryBakeEmissiveMap(material.Name, emissivePng, dictionary);
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

                // Microblend mask source: the texture's alpha, as in the Blender addon
                // (mask_mixer uses Sample.Alpha). Source 2 below is only the "no texture" case.

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
                if (_exportBake)
                {
                    target = hardMax; // export: exactly the requested 1K/2K/4K
                }

                var maxWidth = target;
                var maxHeight = target;


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

                // Float accumulators, as in the addon's node graph:
                //  - roughness / metalness are mixed between layers unclamped (Blender Mix
                //    nodes don't clamp the result), clamped once when written;
                //  - normal XY = template normal + microblend, both mixed by the layer mask
                //    (the addon mixes them separately then adds; both use the same factor,
                //    so mixing the sum is identical). Z is rebuilt at the end.
                var pixelCount = maxWidth * maxHeight;
                var accRough = new float[pixelCount];
                var accMetal = new float[pixelCount];
                var accNormalX = new float[pixelCount];
                var accNormalY = new float[pixelCount];
                Array.Fill(accRough, 0.5f);

                var texCache = new Dictionary<string, Bitmap>(StringComparer.OrdinalIgnoreCase);

                // tile: how many times the texture repeats across the bake.
                // One repeat covers only maxWidth / tile bake pixels; a texture larger than that,
                // sampled once per bake pixel, skips texels with a different phase in every
                // repeat → each tile looks different and the surface turns into a patchwork
                // of blocks. Like GPU mipmaps, the texture is box-halved until one repeat
                // matches the footprint, so every bake pixel sees the average of its texels.
                async Task<Bitmap?> GetTex(ResourcePath path, bool flipY = false, float tile = 1f)
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

                    var footprint = Math.Max(maxWidth, maxHeight) / Math.Max(tile, 0.0001f);
                    var levels = 0;
                    for (var size = Math.Max(hit.Width, hit.Height); size / 2 >= footprint && size / 2 >= 1; size /= 2)
                    {
                        levels++;
                    }

                    if (levels > 0)
                    {
                        var mipKey = key + "|mip" + levels;
                        if (!texCache.TryGetValue(mipKey, out var mip))
                        {
                            mip = hit;
                            for (var i = 0; i < levels; i++)
                            {
                                var next = HalveBox(mip);
                                if (!ReferenceEquals(mip, hit))
                                {
                                    mip.Dispose();
                                }

                                mip = next;
                            }

                            texCache[mipKey] = mip;
                        }

                        hit = mip;
                    }

                    return (Bitmap)hit.Clone();
                }

                // One mip step: 2×2 box average (odd edges clamp). Works for colour,
                // packed roughness/metalness, normals (RG average) and the microblend alpha.
                static unsafe Bitmap HalveBox(Bitmap src)
                {
                    var sw = src.Width;
                    var sh = src.Height;
                    var dw = Math.Max(1, sw / 2);
                    var dh = Math.Max(1, sh / 2);
                    var dst = new Bitmap(dw, dh, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var sd = src.LockBits(new Rectangle(0, 0, sw, sh), ImageLockMode.ReadOnly,
                        System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var dd = dst.LockBits(new Rectangle(0, 0, dw, dh), ImageLockMode.WriteOnly,
                        System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    try
                    {
                        byte* sp = (byte*)sd.Scan0;
                        byte* dp = (byte*)dd.Scan0;
                        var ss = sd.Stride;
                        var ds = dd.Stride;
                        Parallel.For(0, dh, y =>
                        {
                            var y0 = Math.Min(y * 2, sh - 1);
                            var y1 = Math.Min(y0 + 1, sh - 1);
                            for (var x = 0; x < dw; x++)
                            {
                                var x0 = Math.Min(x * 2, sw - 1);
                                var x1 = Math.Min(x0 + 1, sw - 1);
                                byte* a = sp + (y0 * ss) + (x0 * 4);
                                byte* b = sp + (y0 * ss) + (x1 * 4);
                                byte* c = sp + (y1 * ss) + (x0 * 4);
                                byte* d = sp + (y1 * ss) + (x1 * 4);
                                byte* o = dp + (y * ds) + (x * 4);
                                for (var ch = 0; ch < 4; ch++)
                                {
                                    o[ch] = (byte)((a[ch] + b[ch] + c[ch] + d[ch] + 2) >> 2);
                                }
                            }
                        });
                    }
                    finally
                    {
                        src.UnlockBits(sd);
                        dst.UnlockBits(dd);
                    }

                    return dst;
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
                            microblendBmp = await GetTex(layer.Microblend.DepotPath, flipY: true, tile: mbTile);
                        }

                        Bitmap? colorTexBmp = null;
                        var useColorTexture = mllt.ColorTexture.DepotPath != ResourcePath.Empty && opacity > 0;
                        if (useColorTexture)
                        {
                            colorTexBmp = await GetTex(mllt.ColorTexture.DepotPath, flipY: true, tile: effectiveMatTile);
                            if (colorTexBmp == null)
                            {
                                useColorTexture = false;
                            }
                        }

                        float cr = 1f, cg = 1f, cb = 1f;
                        var colorOv = FindOverride(mllt.Overrides.ColorScale, layer.ColorScale, mllt.DefaultOverrides?.ColorScale, x => x.N);
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
                        TryGetLevels(mllt.Overrides.RoughLevelsIn, layer.RoughLevelsIn, mllt.DefaultOverrides?.RoughLevelsIn, x => x.N, x => x.V,
                                     out float roughInScale, out float roughInOffset);
                        TryGetLevels(mllt.Overrides.RoughLevelsOut, layer.RoughLevelsOut, mllt.DefaultOverrides?.RoughLevelsOut, x => x.N, x => x.V,
                                     out float roughOutScale, out float roughOutOffset);
                        TryGetLevels(mllt.Overrides.MetalLevelsIn, layer.MetalLevelsIn, mllt.DefaultOverrides?.MetalLevelsIn, x => x.N, x => x.V,
                                     out float metalInScale, out float metalInOffset);
                        TryGetLevels(mllt.Overrides.MetalLevelsOut, layer.MetalLevelsOut, mllt.DefaultOverrides?.MetalLevelsOut, x => x.N, x => x.V,
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
                            roughTexBmp = await GetTex(mllt.RoughnessTexture.DepotPath, flipY: true, tile: effectiveMatTile);
                            if (roughTexBmp == null)
                            {
#if DEBUG
                                System.Diagnostics.Debug.WriteLine($"[Tex] Failed to load roughness: {mllt.RoughnessTexture.DepotPath}");
#endif
                            }
                        }

                        if (mllt.MetalnessTexture.DepotPath != ResourcePath.Empty)
                        {
                            metalTexBmp = await GetTex(mllt.MetalnessTexture.DepotPath, flipY: true, tile: effectiveMatTile);
                            if (metalTexBmp == null)
                            {
#if DEBUG
                                System.Diagnostics.Debug.WriteLine($"[Tex] Failed to load metalness: {mllt.MetalnessTexture.DepotPath}");
#endif
                            }
                        }

                        var nsOv = FindOverride(mllt.Overrides.NormalStrength, layer.NormalStrength, mllt.DefaultOverrides?.NormalStrength, x => x.N);
                        var normalStrengthVal = nsOv != null ? (float)nsOv.V : 1f;

                        if (mllt.NormalTexture.DepotPath != ResourcePath.Empty)
                        {
                            normalTexBmp = await GetTex(mllt.NormalTexture.DepotPath, flipY: true, tile: effectiveMatTile);
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

                                var mbMaskSource = 0; // alpha (Blender addon)
                                var applyMbMask = mbPtr != null && useMbMask;

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
                                        // Layer 0 has no mask in the addon (Mask = 1) and is never blended
                                        // over anything: it always covers 100 %.
                                        var mask = isBaseLayer ? 1f : SampleChannelR(maskPtr, maskStride, smW, smH, mu, mv);

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

                                        // mask is now the remapped value (Map Range, clamped 0..1).
                                        // Layer factor = remap × opacity; the base layer always 1.
                                        var remap = mask;
                                        var maskVal = isBaseLayer ? 1f : Math.Clamp(remap * opacity, 0f, 1f);
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
                                                // Bilinear on the mip matching the tile footprint (see GetTex).
                                                SampleBgra(colPtr, colStride, colW, colH, su, sv,
                                                    out srcR, out srcG, out srcB, out _);

                                                // colorTexture is sRGB (Blender converts it to linear)
                                                srcR = SrgbToLinear(srcR);
                                                srcG = SrgbToLinear(srcG);
                                                srcB = SrgbToLinear(srcB);
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

                                            // Levels In then Out (Multiply Add), unclamped like the addon
                                            var roughAfterIn = ApplyLevels(roughValue, roughInScale, roughInOffset);
                                            var roughness = ApplyLevels(roughAfterIn, roughOutScale, roughOutOffset);

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
                                            var metallic = ApplyLevels(metalAfterIn, metalOutScale, metalOutOffset);

                                            // Mix by layer factor, result unclamped (clamped once on write)
                                            var pi = (y * maxWidth) + x;
                                            accRough[pi] += (roughness - accRough[pi]) * maskVal;
                                            accMetal[pi] += (metallic - accMetal[pi]) * maskVal;
                                        }

                                        // ---- normal: template + microblend (addon: Layer Blend + Multilayer Surface) ----
                                        {
                                            // Template normal: (xy * 2 - 1) * NormalStrength
                                            float layerX = 0f, layerY = 0f;
                                            if (ntexPtr != null)
                                            {
                                                SampleBgra(ntexPtr, ntexStride, ntexW, ntexH, su, sv,
                                                    out var nR, out var nG, out _, out _);
                                                layerX = ((nR * 2f) - 1f) * normalStrengthVal;
                                                layerY = ((nG * 2f) - 1f) * normalStrengthVal;
                                            }

                                            // Microblend: (xy * 2 - 1) * MicroblendNormalStrength, only where the
                                            // remapped mask is below 1 (addon: "Microblend Below Full Mask").
                                            if (mbPtr != null && Math.Abs(mbNormalStr) > 1e-6f && remap < 1f)
                                            {
                                                FractOffsetTile(u, v, mbTile, mbOffU, mbOffV,
                                                    flipV: true,
                                                    out var mbu, out var mbv);
                                                SampleBgra(mbPtr, mbStride, mbW, mbH, mbu, mbv,
                                                    out var mR, out var mG, out _, out _);

                                                layerX += ((mR * 2f) - 1f) * mbNormalStr;
                                                layerY += ((mG * 2f) - 1f) * mbNormalStr;
                                            }

                                            var pn = (y * maxWidth) + x;
                                            accNormalX[pn] += (layerX - accNormalX[pn]) * maskVal;
                                            accNormalY[pn] += (layerY - accNormalY[pn]) * maskVal;
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


                // GlobalNormal, as in the addon ("CP77 Multilayer Global Normal Decode"):
                //   UV' = UV * GlobalNormalUVScale + GlobalNormalUVBias (Blender UV, V up), repeat;
                //   x, y = rg * 2 - 1, z = sqrt(max(0, 1 - x² - y²));
                //   n = normalize(x * I, y * I, (z - 1) * I + 1), I = GlobalNormalIntensity;
                //   n.xy is added to the layer normal before Z is rebuilt.
                if (dictionary.TryGetValue("GlobalNormal", out var gNormObj) &&
                    gNormObj is CResourceReference<ITexture> gNormRef &&
                    gNormRef.DepotPath != ResourcePath.Empty)
                {
                    Bitmap? gBmp = null;
                    try
                    {
                        gBmp = await LoadTextureAsBitmap(gNormRef.DepotPath);
                        if (gBmp != null)
                        {
                            var gRect = new Rectangle(0, 0, gBmp.Width, gBmp.Height);
                            var gData = gBmp.LockBits(gRect, ImageLockMode.ReadOnly,
                                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            try
                            {
                                unsafe
                                {
                                    byte* gPtr = (byte*)gData.Scan0;
                                    var gStride = gData.Stride;
                                    var gw = gBmp.Width;
                                    var gh = gBmp.Height;

                                    var gIntensity = 1f;
                                    if (dictionary.TryGetValue("GlobalNormalIntensity", out var gInt) && gInt != null)
                                    {
                                        gIntensity = ReadFloat(gInt);
                                    }

                                    float gScaleU = 1f, gScaleV = 1f, gBiasU = 0f, gBiasV = 0f;
                                    if (dictionary.TryGetValue("GlobalNormalUVScale", out var gSc) && gSc is Vector4 gScV)
                                    {
                                        gScaleU = (float)gScV.X;
                                        gScaleV = (float)gScV.Y;
                                    }

                                    if (dictionary.TryGetValue("GlobalNormalUVBias", out var gBi) && gBi is Vector4 gBiV)
                                    {
                                        gBiasU = (float)gBiV.X;
                                        gBiasV = (float)gBiV.Y;
                                    }

                                    // Bilinear with repeat (Blender Image Texture default).
                                    // Nearest sampling made every texel of a lower-res GlobalNormal
                                    // a visible square in the bake.
                                    Parallel.For(0, maxHeight, y =>
                                    {
                                        // Image rows go down, Blender V goes up: transform in Blender space.
                                        var vBl = 1f - ((y + 0.5f) / maxHeight);
                                        var vImg = 1f - ((vBl * gScaleV) + gBiasV);
                                        vImg -= MathF.Floor(vImg);
                                        var py = (vImg * gh) - 0.5f;
                                        var fy = MathF.Floor(py);
                                        var ty = py - fy;
                                        var y0 = WrapIndex((int)fy, gh);
                                        var y1 = WrapIndex(y0 + 1, gh);
                                        byte* row0 = gPtr + (y0 * gStride);
                                        byte* row1 = gPtr + (y1 * gStride);

                                        for (var x = 0; x < maxWidth; x++)
                                        {
                                            var uImg = (((x + 0.5f) / maxWidth) * gScaleU) + gBiasU;
                                            uImg -= MathF.Floor(uImg);
                                            var px = (uImg * gw) - 0.5f;
                                            var fx = MathF.Floor(px);
                                            var tx = px - fx;
                                            var x0i = WrapIndex((int)fx, gw);
                                            var x0 = x0i * 4;
                                            var x1 = WrapIndex(x0i + 1, gw) * 4;

                                            var r = ((row0[x0 + 2] * (1f - tx)) + (row0[x1 + 2] * tx)) * (1f - ty)
                                                  + ((row1[x0 + 2] * (1f - tx)) + (row1[x1 + 2] * tx)) * ty;
                                            var g = ((row0[x0 + 1] * (1f - tx)) + (row0[x1 + 1] * tx)) * (1f - ty)
                                                  + ((row1[x0 + 1] * (1f - tx)) + (row1[x1 + 1] * tx)) * ty;

                                            var gx = (r * Inv255 * 2f) - 1f;
                                            var gy = (g * Inv255 * 2f) - 1f;
                                            var gz = MathF.Sqrt(MathF.Max(0f, 1f - (gx * gx) - (gy * gy)));

                                            // Intensity: scale XY, lerp Z towards flat, renormalize.
                                            var nx = gx * gIntensity;
                                            var ny = gy * gIntensity;
                                            var nz = ((gz - 1f) * gIntensity) + 1f;
                                            var len = MathF.Sqrt((nx * nx) + (ny * ny) + (nz * nz));
                                            if (len > 1e-6f)
                                            {
                                                nx /= len;
                                                ny /= len;
                                            }

                                            var pi = (y * maxWidth) + x;
                                            accNormalX[pi] += nx;
                                            accNormalY[pi] += ny;
                                        }
                                    });
                                }
                            }
                            finally
                            {
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

                // Write roughness/metalness and normal from the accumulators.
                {
                    var accWriteRect = new Rectangle(0, 0, maxWidth, maxHeight);
                    var rmOut = rmBitmap.LockBits(accWriteRect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    var nOut = normalBitmap.LockBits(accWriteRect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    try
                    {
                        unsafe
                        {
                            byte* rmP = (byte*)rmOut.Scan0;
                            byte* nP = (byte*)nOut.Scan0;
                            var rmS = rmOut.Stride;
                            var nS = nOut.Stride;
                            for (var y = 0; y < maxHeight; y++)
                            {
                                for (var x = 0; x < maxWidth; x++)
                                {
                                    var pi = (y * maxWidth) + x;

                                    var ro = (y * rmS) + (x * 4);
                                    rmP[ro + 0] = (byte)Math.Clamp((int)MathF.Round(Math.Clamp(accMetal[pi], 0f, 1f) * 255f), 0, 255); // B metal
                                    rmP[ro + 1] = (byte)Math.Clamp((int)MathF.Round(Math.Clamp(accRough[pi], 0f, 1f) * 255f), 0, 255); // G rough
                                    rmP[ro + 2] = 0;
                                    rmP[ro + 3] = 255;

                                    // Calculate Vectorized Normal Z: z = sqrt(max(0, 1 - x² - y²)),
                                    // Y flipped (DirectX → Blender/OpenGL), like the other bakes here.
                                    var nx = accNormalX[pi];
                                    var ny = accNormalY[pi];
                                    var nz = MathF.Sqrt(MathF.Max(0f, 1f - (nx * nx) - (ny * ny)));
                                    ny = -ny;

                                    var no = (y * nS) + (x * 4);
                                    nP[no + 2] = (byte)Math.Clamp((int)MathF.Round(((nx * 0.5f) + 0.5f) * 255f), 0, 255);
                                    nP[no + 1] = (byte)Math.Clamp((int)MathF.Round(((ny * 0.5f) + 0.5f) * 255f), 0, 255);
                                    nP[no + 0] = (byte)Math.Clamp((int)MathF.Round(((nz * 0.5f) + 0.5f) * 255f), 0, 255);
                                    nP[no + 3] = 255;
                                }
                            }
                        }
                    }
                    finally
                    {
                        rmBitmap.UnlockBits(rmOut);
                        normalBitmap.UnlockBits(nOut);
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
                }
                catch { /* ignore */ }

            }

    #endregion

            #region Skin Shader / Hair / Makeup

            var kind = ClassifyMaterialFor(material?.Name, material);

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

                var eyePart = GetEyePart(material, material.Name);

                // Path takes priority over name (pasted_eyeMat2 can be lashes).
                bool isRealLashes = eyePart == EyePart.Lashes;
                bool isEyeShadow = eyePart is EyePart.Shadow or EyePart.Wet;
                bool isEyeball = eyePart == EyePart.Eyeball;

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

            // === GLASS ===
            // Addon: glass lobe (TintColor) mixed with surface lobe (MaskTexture)
            // by Mask.Alpha * MaskOpacity. Missing Opacity defaults to 1 (addon scalar default).
            if (Has(kind, MaterialKind.Glass))
            {
                Bitmap? colorBmp = null;
                Bitmap? tintBmp = null;
                Bitmap? maskBmp = null;
                try
                {
                    var (gBd, gBn, _) = GetMaterialFilePathsFromCache(material?.Name ?? "glass");
                    if (forceBake || !File.Exists(gBd))
                    {
                        static bool IsPlaceholderTex(string path)
                        {
                            var file = Path.GetFileName(path.Replace('/', '\\'));
                            return file.Equals("white.xbm", StringComparison.OrdinalIgnoreCase)
                                || file.Equals("black.xbm", StringComparison.OrdinalIgnoreCase)
                                || file.Equals("grey.xbm", StringComparison.OrdinalIgnoreCase)
                                || path.Contains("editor\\", StringComparison.OrdinalIgnoreCase)
                                || path.Contains("editor/", StringComparison.OrdinalIgnoreCase)
                                || path.Contains("placeholder", StringComparison.OrdinalIgnoreCase);
                        }

                        // Unspecified Opacity. Preview fallback is also 1.
                        float op = GlassDefaultOpacity;
                        if (dictionary.TryGetValue("Opacity", out var opObj))
                            op = Math.Clamp(ReadFloat(opObj), 0f, 1f);
                        float maskOp = 0f;
                        if (dictionary.TryGetValue("MaskOpacity", out var moObj))
                            maskOp = Math.Clamp(ReadFloat(moObj), 0f, 1f);

                        float tr = 1f, tg = 1f, tb = 1f;
                        if (dictionary.TryGetValue("TintColor", out var tcObj))
                        {
                            if (tcObj is CColor cc)
                            {
                                tr = cc.Red / 255f;
                                tg = cc.Green / 255f;
                                tb = cc.Blue / 255f;
                            }
                            else if (tcObj is Vector4 tv)
                            {
                                tr = tv.X;
                                tg = tv.Y;
                                tb = tv.Z;
                            }
                            else if (tcObj is System.Numerics.Vector4 ntv)
                            {
                                tr = ntv.X;
                                tg = ntv.Y;
                                tb = ntv.Z;
                            }
                        }

                        float uvTX = 1f, uvTY = 1f, uvOX = 0f, uvOY = 0f;
                        if (dictionary.TryGetValue("UvTilingX", out var uvtx))
                            uvTX = ReadFloat(uvtx);
                        if (dictionary.TryGetValue("UvTilingY", out var uvty))
                            uvTY = ReadFloat(uvty);
                        if (dictionary.TryGetValue("UvOffsetX", out var uvox))
                            uvOX = ReadFloat(uvox);
                        if (dictionary.TryGetValue("UvOffsetY", out var uvoy))
                            uvOY = ReadFloat(uvoy);
                        if (uvTX == 0)
                            uvTX = 1f;
                        if (uvTY == 0)
                            uvTY = 1f;

                        if (dictionary.TryGetValue("GlassTint", out var gtObj) &&
                            gtObj is CResourceReference<ITexture> gtRef &&
                            gtRef.DepotPath != ResourcePath.Empty)
                        {
                            var tintPath = gtRef.DepotPath.GetResolvedText() ?? "";
                            if (!IsPlaceholderTex(tintPath))
                                tintBmp = await LoadTextureAsBitmap(gtRef.DepotPath);
                        }
                        if (dictionary.TryGetValue("MaskTexture", out var mObj) &&
                            mObj is CResourceReference<ITexture> mRef &&
                            mRef.DepotPath != ResourcePath.Empty)
                        {
                            var maskPath = mRef.DepotPath.GetResolvedText() ?? "";
                            if (!IsPlaceholderTex(maskPath))
                                maskBmp = await LoadTextureAsBitmap(mRef.DepotPath);
                        }

                        var (gtTX, gtTY, gtOX, gtOY) = ReadTileOffset(dictionary, "GlassTintTileAndOffset");
                        if (tintBmp != null)
                        {
                            var tintTiled = ApplyUvTileOffset(tintBmp, uvTX * gtTX, uvTY * gtTY, uvOX * gtTX + gtOX, uvOY * gtTY + gtOY);
                            if (!ReferenceEquals(tintTiled, tintBmp))
                            {
                                tintBmp.Dispose();
                                tintBmp = tintTiled;
                            }
                        }
                        if (maskBmp != null)
                        {
                            var maskTiled = ApplyUvTileOffset(maskBmp, uvTX, uvTY, uvOX, uvOY);
                            if (!ReferenceEquals(maskTiled, maskBmp))
                            {
                                maskBmp.Dispose();
                                maskBmp = maskTiled;
                            }
                        }

                        // Template convention is MaskTexture.a; single-channel masks carry it in R.
                        var glassMaskChannel = maskBmp != null ? PickCoverageChannel(maskBmp, ChannelA) : ChannelA;

                        int w = maskBmp?.Width ?? tintBmp?.Width ?? 1024;
                        int h = maskBmp?.Height ?? tintBmp?.Height ?? 1024;
                        colorBmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                        var rect = new Rectangle(0, 0, w, h);
                        System.Drawing.Imaging.BitmapData? dst = null, td = null, md = null;
                        try
                        {
                            dst = colorBmp.LockBits(rect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            if (tintBmp != null)
                                td = tintBmp.LockBits(new Rectangle(0, 0, tintBmp.Width, tintBmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            if (maskBmp != null)
                                md = maskBmp.LockBits(new Rectangle(0, 0, maskBmp.Width, maskBmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            unsafe
                            {
                                byte* dp = (byte*)dst!.Scan0;
                                byte* tp = td == null ? null : (byte*)td.Scan0;
                                byte* mp = md == null ? null : (byte*)md.Scan0;
                                int dStride = dst!.Stride;
                                int tStride = td?.Stride ?? 0;
                                int mStride = md?.Stride ?? 0;
                                int tw = tintBmp?.Width ?? 1, th = tintBmp?.Height ?? 1;
                                int mw = maskBmp?.Width ?? 1, mh = maskBmp?.Height ?? 1;
                                byte glassA = (byte)(Math.Clamp(op, 0f, 1f) * 255f);
                                byte br = (byte)(Math.Clamp(tr, 0f, 1f) * 255f);
                                byte bg = (byte)(Math.Clamp(tg, 0f, 1f) * 255f);
                                byte bb = (byte)(Math.Clamp(tb, 0f, 1f) * 255f);
                                for (int y = 0; y < h; y++)
                                {
                                    byte* drow = dp + y * dStride;
                                    for (int x = 0; x < w; x++)
                                    {
                                        // Glass base: TintColor * GlassTint
                                        byte gr = br, gg = bg, gb = bb, ga = glassA;
                                        if (tp != null)
                                        {
                                            int tx = x * tw / w;
                                            int ty = y * th / h;
                                            byte* tpx = tp + ty * tStride + tx * 4;
                                            gb = (byte)(tpx[0] * tb);
                                            gg = (byte)(tpx[1] * tg);
                                            gr = (byte)(tpx[2] * tr);
                                        }
                                        // Label over glass by Mask.A * MaskOpacity (addon MixShader factor)
                                        if (mp != null && maskOp > 0.001f)
                                        {
                                            int mx = x * mw / w;
                                            int my = y * mh / h;
                                            byte* mpx = mp + my * mStride + mx * 4;
                                            float f = (mpx[glassMaskChannel] / 255f) * maskOp;
                                            gb = (byte)(gb * (1f - f) + mpx[0] * f);
                                            gg = (byte)(gg * (1f - f) + mpx[1] * f);
                                            gr = (byte)(gr * (1f - f) + mpx[2] * f);
                                            ga = (byte)(ga * (1f - f) + 255f * f);
                                        }
                                        int o = x * 4;
                                        drow[o + 0] = gb;
                                        drow[o + 1] = gg;
                                        drow[o + 2] = gr;
                                        drow[o + 3] = ga;
                                    }
                                }
                            }
                        }
                        finally
                        {
                            if (dst != null)
                                colorBmp.UnlockBits(dst);
                            if (td != null && tintBmp != null)
                                tintBmp.UnlockBits(td);
                            if (md != null && maskBmp != null)
                                maskBmp.UnlockBits(md);
                        }

                        SavePngAtomic(colorBmp, gBd);
                        colorBmp.Dispose();
                        colorBmp = null;
                        tintBmp?.Dispose();
                        tintBmp = null;
                        maskBmp?.Dispose();
                        maskBmp = null;

                        if (dictionary.TryGetValue("Normal", out var nObj) &&
                            nObj is CResourceReference<ITexture> nRef &&
                            nRef.DepotPath != ResourcePath.Empty)
                        {
                            var nPath = nRef.DepotPath.GetResolvedText() ?? "";
                            if (!IsPlaceholderTex(nPath) && !nPath.Contains("flat_normal", StringComparison.OrdinalIgnoreCase))
                            {
                                var nBmp = await LoadTextureAsBitmap(nRef.DepotPath);
                                if (nBmp != null)
                                {
                                    Bitmap? nTiled = null;
                                    try
                                    {
                                        var (nTX, nTY, nOX, nOY) = ReadTileOffset(dictionary, "NormalTileAndOffset");
                                        nTiled = ApplyUvTileOffset(nBmp, uvTX * nTX, uvTY * nTY, uvOX * nTX + nOX, uvOY * nTY + nOY);
                                        SavePngAtomic(nTiled, gBn);
                                    }
                                    finally
                                    {
                                        if (nTiled != null && !ReferenceEquals(nTiled, nBmp))
                                            nTiled.Dispose();
                                        nBmp.Dispose();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Warning(
                        $"[Glass] Failed to bake '{material?.Name}': {ex.GetType().Name}: {ex.Message}");
                    colorBmp?.Dispose();
                    tintBmp?.Dispose();
                    maskBmp?.Dispose();
                }
            }
            // === END GLASS ===

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
                    // Strip the 8-char hash we append: name_HASH__mat → name
                    var hashIdx = meshName.LastIndexOf('_');
                    if (hashIdx > 0 && meshName.Length - hashIdx == 9 &&
                        meshName.Skip(hashIdx + 1).All(c => "0123456789ABCDEFabcdef".Contains(c)))
                        meshName = meshName.Substring(0, hashIdx);
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
                        // Cap materials (hat hair, beard) often bake alpha from the diffuse itself.
                        // Missing Strand_Alpha is expected, not an error.
                        Parent?.GetLoggerService()?.Debug($"[Hair] Cap material '{material?.Name}' has no MaskTexture / Strand_Alpha");
                    }

                    // === Haircard colour (not for cap) ===
                    // hair.py: Strand_ID.r → profile ID ramp, Strand_Gradient.r → Root-to-Tip ramp,
                    // Overlay (Multiply×2 / inverted path chosen by Root-to-Tip luminance),
                    // then Hair Global Albedo ×0.6. Blender does all of this in linear colour
                    // (ramp colours are converted from sRGB), so the bake does too and encodes
                    // to sRGB once at the end. Doing it on sRGB bytes flattened the contrast.
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

                        BakeHairCardColor(idBmp, gradBmp, idEntries, rootToTipEntries);
                        colorBmp = idBmp;
                        gradBmp.Dispose();
                    }
                    else
                    {
                        if (!isCapMat)
                        {
                            if (idBmp != null && idEntries.Count > 0)
                                ApplyColorRamp(idBmp, idEntries);
                            if (gradBmp != null && rootToTipEntries.Count > 0)
                                ApplyColorRamp(gradBmp, rootToTipEntries);
                        }
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
                        // Cap: MaskTexture.r by convention. Cards: Strand_Alpha may be single-channel
                        // (BC4, value in R) or a real alpha channel. Decided once per texture: the
                        // old per-pixel check switched to R inside fully opaque (A=255) areas.
                        var hairAlphaChannel = alphaBmp == null
                            ? ChannelA
                            : PickCoverageChannel(alphaBmp, isCapMat ? ChannelR : ChannelA);
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
                                            a = aPtr[off + hairAlphaChannel];
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
                            DilateColorIntoTransparent(bmp);

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

                            // Give the cut-away pixels the colour of the nearest visible ones,
                            // so texture filtering at the edge does not pull in a dark/light fringe.
                            DilateColorIntoTransparent(bmp);
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

        NormalMaps:

            if (File.Exists(filename_bn))
            {
                goto SkipNormals;
            }

            // Extract normals for decals and metal_base; multilayer bake handles the rest
            var matKind = ClassifyMaterialFor(material?.Name, material);
            bool isMetalBaseMat = GetTemplateFileName(material).StartsWith("metal_base", StringComparison.Ordinal) ||
                                  material?.Name?.Contains("chain", StringComparison.OrdinalIgnoreCase) == true ||
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

            // Record what this bake read, so the next pass can skip it if nothing changed.
            WriteBakeDependencies(depsPath, valuesStamp, bakeResolution, filename_bd, filename_bn, filename_rm, emissivePng);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService().Error($"Failed to load material '{material?.Name}': {ex.Message}");
        }
        finally
        {
            EndDependencyTracking();
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

    /// <summary>
    /// Override entry for a layer: the entry named by the layer; if the template has no
    /// entry of that name, the entry named by the template's defaultOverrides (the variant
    /// the template itself uses by default); otherwise none (caller uses white / 1 / identity).
    /// Names are matched exactly ("null", "None" and "null_null" are different names).
    /// The Blender addon stops at the first step; the defaultOverrides step follows the
    /// template's own default selection.
    /// </summary>
    static T? FindOverride<T>(IList<T>? list, CName key, CName? defaultKey, Func<T, CName> nameOf) where T : class
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

        if (defaultKey is { } fallback && fallback != CName.Empty && fallback != key)
        {
            foreach (var item in list)
            {
                if (item != null && nameOf(item) == fallback)
                {
                    return item;
                }
            }
        }

        return null;
    }


    /// <summary>
    /// Reads levels (scale, offset) from an override list with proper null-key fallback.
    /// Returns identity (1, 0) when nothing is found.
    /// Works with CArrayFixedSize<CFloat> (or any type with Count + indexer castable to float).
    /// </summary>
    static void TryGetLevels<T>(IList<T>? list, CName key, CName? defaultKey, Func<T, CName> nameOf, Func<T, object?> getVec,
                                 out float scale, out float offset) where T : class
    {
        scale = 1f;
        offset = 0f;

        // Layer's entry, then the template's default entry, otherwise identity (1, 0).
        var ov = FindOverride(list, key, defaultKey, nameOf);
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
                WarnMissingFile("texture", depotPath);
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
    /// Edge padding: fills the RGB of fully transparent pixels with the average colour of
    /// their visible neighbours, growing outward a few pixels per pass. Alpha is untouched.
    /// Bilinear filtering and mipmaps then blend the edge with the object's own colour
    /// instead of whatever the transparent area held (usually black), which showed as a
    /// fringe or "trail" around cut-out shapes.
    /// </summary>
    private static void DilateColorIntoTransparent(Bitmap bmp, int passes = 8)
    {
        int w = bmp.Width, h = bmp.Height;
        if (w < 2 || h < 2)
            return;

        var rect = new Rectangle(0, 0, w, h);
        var data = bmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            var stride = data.Stride;
            var pixels = new byte[stride * h];
            Marshal.Copy(data.Scan0, pixels, 0, pixels.Length);

            // filled[i]: pixel has a usable colour (visible, or filled in an earlier pass)
            var filled = new bool[w * h];
            var any = false;
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                {
                    var visible = pixels[y * stride + x * 4 + 3] > 0;
                    filled[y * w + x] = visible;
                    any |= !visible;
                }

            if (!any)
                return;

            var next = new List<(int Index, byte B, byte G, byte R)>();
            for (var pass = 0; pass < passes; pass++)
            {
                next.Clear();
                for (int y = 0; y < h; y++)
                {
                    for (int x = 0; x < w; x++)
                    {
                        if (filled[y * w + x])
                            continue;

                        int sb = 0, sg = 0, sr = 0, n = 0;
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            var ny = y + dy;
                            if (ny < 0 || ny >= h)
                                continue;
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                var nx = x + dx;
                                if (nx < 0 || nx >= w || !filled[ny * w + nx])
                                    continue;
                                var o = ny * stride + nx * 4;
                                sb += pixels[o];
                                sg += pixels[o + 1];
                                sr += pixels[o + 2];
                                n++;
                            }
                        }

                        if (n > 0)
                            next.Add((y * w + x, (byte)(sb / n), (byte)(sg / n), (byte)(sr / n)));
                    }
                }

                if (next.Count == 0)
                    break;

                foreach (var (index, b, g, r) in next)
                {
                    var o = (index / w) * stride + (index % w) * 4;
                    pixels[o] = b;
                    pixels[o + 1] = g;
                    pixels[o + 2] = r;
                    filled[index] = true;
                }
            }

            Marshal.Copy(pixels, 0, data.Scan0, pixels.Length);
        }
        finally
        {
            bmp.UnlockBits(data);
        }
    }

    /// <summary>
    /// Bake Blender Mapping (Point): out = uv * scale + location, with wrap.
    /// Used by glass UvTiling/UvOffset and *TileAndOffset vectors.
    /// </summary>
    private static Bitmap ApplyUvTileOffset(Bitmap src, float tileX, float tileY, float offX, float offY)
    {
        if (Math.Abs(tileX - 1f) < 0.001f && Math.Abs(tileY - 1f) < 0.001f
            && Math.Abs(offX) < 0.001f && Math.Abs(offY) < 0.001f)
            return src;

        tileX = Math.Clamp(tileX, 0.05f, 16f);
        tileY = Math.Clamp(tileY, 0.05f, 16f);
        int w = src.Width, h = src.Height;
        var dst = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        var srcRect = new Rectangle(0, 0, w, h);
        var srcData = src.LockBits(srcRect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var dstData = dst.LockBits(srcRect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* sp = (byte*)srcData.Scan0;
                byte* dp = (byte*)dstData.Scan0;
                int sStride = srcData.Stride;
                int dStride = dstData.Stride;
                for (int y = 0; y < h; y++)
                {
                    // Blender V is bottom-up; image rows are top-down.
                    float vb = 1f - (y + 0.5f) / h;
                    float tvb = vb * tileY + offY;
                    tvb -= MathF.Floor(tvb);
                    int sy = (int)((1f - tvb) * h) % h;
                    if (sy < 0)
                        sy += h;
                    byte* drow = dp + y * dStride;
                    byte* srow = sp + sy * sStride;
                    for (int x = 0; x < w; x++)
                    {
                        float u = (x + 0.5f) / w;
                        float tu = u * tileX + offX;
                        tu -= MathF.Floor(tu);
                        int sx = (int)(tu * w) % w;
                        if (sx < 0)
                            sx += w;
                        int so = sx * 4;
                        int dof = x * 4;
                        drow[dof + 0] = srow[so + 0];
                        drow[dof + 1] = srow[so + 1];
                        drow[dof + 2] = srow[so + 2];
                        drow[dof + 3] = srow[so + 3];
                    }
                }
            }
        }
        finally
        {
            src.UnlockBits(srcData);
            dst.UnlockBits(dstData);
        }
        return dst;
    }

    private static (float tileX, float tileY, float offX, float offY) ReadTileOffset(
        Dictionary<string, object> values, string key, float defTileX = 1f, float defTileY = 1f)
    {
        if (!values.TryGetValue(key, out var obj))
            return (defTileX, defTileY, 0f, 0f);
        if (obj is Vector4 v)
            return (v.X == 0 ? defTileX : v.X, v.Y == 0 ? defTileY : v.Y, v.Z, v.W);
        if (obj is System.Numerics.Vector4 nv)
            return (nv.X == 0 ? defTileX : nv.X, nv.Y == 0 ? defTileY : nv.Y, nv.Z, nv.W);
        return (defTileX, defTileY, 0f, 0f);
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

    // Built once per mesh path, then shared by every node / instance that uses the mesh.
    // Clones share Geometry and Material; only the scene-graph node is per instance.
    private readonly Dictionary<string, List<SubmeshComponent>> _sectorMeshTemplates = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, List<Material>> _sectorMaterialCache = new(StringComparer.OrdinalIgnoreCase);

    private List<Material> GetSectorMaterials(CMesh mesh, CName appearance, string meshPath)
    {
        var key = meshPath + "|" + appearance;
        if (!_sectorMaterialCache.TryGetValue(key, out var list))
        {
            list = GetMaterialsForAppearance(mesh, appearance, meshPath);
            _sectorMaterialCache[key] = list;
        }

        return list;
    }

    /// <summary>
    /// MakeMesh with reuse: the geometry for a given mesh / chunk mask / appearance is
    /// built once, then every placement gets its own scene node sharing Geometry and Material.
    /// Used for sector nodes, their instances, and entity components (sectors place the
    /// same .ent and .mesh many times).
    /// </summary>
    private List<SubmeshComponent> MakeMeshShared(CMesh mesh, ulong chunkMask, int appearanceIndex, string meshPath)
    {
        if (string.IsNullOrEmpty(meshPath))
        {
            // No stable key: build without sharing.
            return MakeMesh(mesh, chunkMask, appearanceIndex, meshPath);
        }

        var key = $"{meshPath}|{chunkMask}|{appearanceIndex}";
        if (!_sectorMeshTemplates.TryGetValue(key, out var template))
        {
            template = MakeMesh(mesh, chunkMask, appearanceIndex, meshPath);
            _sectorMeshTemplates[key] = template;
        }

        var result = new List<SubmeshComponent>(template.Count);
        foreach (var t in template)
        {
            result.Add(new SubmeshComponent()
            {
                Name = t.Name,
                Text = t.Text,
                LOD = t.LOD,
                IsRendering = t.IsRendering,
                EnabledWithMask = t.EnabledWithMask,
                Geometry = t.Geometry,
                Material = t.Material,
                MaterialName = t.MaterialName,
                DepthBias = t.DepthBias,
                IsTransparent = t.IsTransparent,
                CullMode = t.CullMode,
                FrontCounterClockwise = t.FrontCounterClockwise,
            });
        }

        return result;
    }

    #region sector prefetch

    /// <summary>
    /// Walks the sector's references in waves (meshes and entities, then their materials,
    /// appearances and component meshes, then parts) and loads each wave in parallel
    /// into _fileCache. The render pass then finds everything already loaded.
    /// Only used when an archive manager is available (its reads are independent);
    /// a file that fails here is simply loaded again by the normal sequential path.
    /// </summary>
    private void PrefetchSectorFiles(worldStreamingSector data)
    {
        var am = ResolveArchiveManager();
        if (am == null)
            return;

        var wave = new HashSet<ResourcePath>();
        foreach (var handle in data.Nodes)
        {
            switch (handle?.Chunk)
            {
                case IRedMeshNode irmn:
                    wave.Add(irmn.Mesh.DepotPath);
                    break;
                case worldEntityNode wen:
                    wave.Add(wen.EntityTemplate.DepotPath);
                    break;
            }
        }

        var wantedApps = new Dictionary<ResourcePath, HashSet<string>>();
        for (var depth = 0; depth < 6 && wave.Count > 0; depth++)
        {
            wave.RemoveWhere(p => p == ResourcePath.Empty || _fileCache.ContainsKey(p));
            PrefetchFiles(am, wave);

            var next = new HashSet<ResourcePath>();
            foreach (var path in wave)
            {
                if (_fileCache.TryGetValue(path, out var file) && file?.RootChunk is { } root)
                    CollectPrefetchRefs(root, path, next, wantedApps);
            }

            next.RemoveWhere(p => p == ResourcePath.Empty || _fileCache.ContainsKey(p));
            wave = next;
        }
    }

    private void PrefetchFiles(IArchiveManager am, ICollection<ResourcePath> paths)
    {
        if (paths.Count == 0)
            return;

        var options = new ParallelOptions { MaxDegreeOfParallelism = Math.Max(2, Environment.ProcessorCount - 1) };
        Parallel.ForEach(paths, options, path =>
        {
            try
            {
                var file = am.GetCR2WFile(path, includeMods: true, includeProject: true);
                if (file != null)
                    _fileCache.TryAdd(path, file);
            }
            catch
            {
                // left out of the cache: the sequential path loads it (and reports errors)
            }
        });
    }

    private static void CollectPrefetchRefs(RedBaseClass root, ResourcePath self,
        HashSet<ResourcePath> next, Dictionary<ResourcePath, HashSet<string>> wantedApps)
    {
        switch (root)
        {
            case CMesh mesh:
                foreach (var r in mesh.ExternalMaterials)
                    next.Add(r.DepotPath);
                if (mesh.PreloadExternalMaterials != null)
                {
                    foreach (var r in mesh.PreloadExternalMaterials)
                        next.Add(r.DepotPath);
                }
                break;

            case entEntityTemplate ent:
                // Sectors render the default appearance only (see RenderEntity).
                foreach (var a in ent.Appearances)
                {
                    if (a is null || a.Name != ent.DefaultAppearance)
                        continue;

                    var appPath = a.AppearanceResource.DepotPath;
                    next.Add(appPath);
                    if (!wantedApps.TryGetValue(appPath, out var names))
                    {
                        names = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                        wantedApps[appPath] = names;
                    }
                    var appName = StringHelper.StringifyOrNull(a.AppearanceName)
                                  ?? StringHelper.StringifyOrNull(a.Name)
                                  ?? string.Empty;
                    names.Add(appName.Split('&')[0]);
                }
                if (ent.CompiledData.Data is RedPackage pkg)
                    AddComponentRefs(pkg.Chunks, next);
                break;

            case appearanceAppearanceResource aar:
                wantedApps.TryGetValue(self, out var wanted);
                foreach (var h in aar.Appearances)
                {
                    if (h.GetValue() is not appearanceAppearanceDefinition def)
                        continue;
                    var defName = (StringHelper.StringifyOrNull(def.Name) ?? string.Empty).Split('&')[0];
                    if (wanted != null && !wanted.Contains(defName))
                        continue;
                    if (def.CompiledData?.Data is RedPackage apkg)
                        AddComponentRefs(apkg.Chunks, next);
                    foreach (var pv in def.PartsValues)
                    {
                        if (pv is appearanceAppearancePart part)
                            next.Add(part.Resource.DepotPath);
                    }
                }
                break;
        }
    }

    private static void AddComponentRefs(IEnumerable<RedBaseClass> chunks, HashSet<ResourcePath> next)
    {
        foreach (var c in chunks)
        {
            switch (c)
            {
                case entSkinnedClothComponent cloth:
                    next.Add(cloth.GraphicsMesh.DepotPath);
                    break;
                case IRedMeshComponent mc:
                    next.Add(mc.Mesh.DepotPath);
                    break;
                case entAnimatedComponent anim:
                    next.Add(anim.Rig.DepotPath);
                    break;
            }
        }
    }

    #endregion

    public SectorGroup RenderSector(worldStreamingSector data, Appearance app)
    {
        if (data.NodeData.Data is not worldNodeDataBuffer buffer)
        {
            throw new ArgumentNullException();
        }

        // Read every file the sector will need up front, in parallel.
        // Sequential archive reads were most of the sector load time.
        PrefetchSectorFiles(data);

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

                var meshPath = irmn.Mesh.DepotPath.GetResolvedText() ?? string.Empty;
                var appMaterials = GetSectorMaterials(mesh, irmn.MeshAppearance, meshPath);

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
                        var meshes = MakeMeshShared(mesh, ulong.MaxValue, 0, meshPath);

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
                        var meshes = MakeMeshShared(mesh, ulong.MaxValue, 0, meshPath);

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
                        var meshes = MakeMeshShared(mesh, ulong.MaxValue, 0, meshPath);

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

    /// <summary>
    /// Tree → viewport: selecting a row in the tree highlights the matching object.
    /// A submesh row highlights its owning component (the instance it belongs to).
    /// Sector / block previews only: other previews have no selection highlight.
    /// </summary>
    partial void OnSelectedItemChanged(object? value)
    {
        SyncMultilayerDebugMaterial(value);

        if (Header != MeshViewHeaders.SectorPreview && Header != MeshViewHeaders.AllSectorPreview)
            return;

        DependencyObject? current = value as DependencyObject;
        while (current != null && current is not MeshComponent)
            current = LogicalTreeHelper.GetParent(current);

        if (current is MeshComponent mesh && !ReferenceEquals(mesh, CurrentSelection.SelectedMesh))
            UpdateSelection(mesh);
    }

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
                // Also select it in the tree; the view expands the branch and scrolls to it.
                SelectedItem = mesh;
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
                        _buildingAppearance = a;
                        a.RawMaterials[material.Name] = material;
                    }

                    if (model.MeshFile?.RootChunk is CMesh mesh)
                    {
                        var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                        model.Meshes = MakeMeshShared(mesh, model.ChunkMask, model.AppearanceIndex, meshPath);
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
                _buildingAppearance = meshApp;
                meshApp.RawMaterials[material.Name] = material;
            }

            if (model.MeshFile?.RootChunk is CMesh mesh)
            {
                var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                model.Meshes = MakeMeshShared(mesh, model.ChunkMask, model.AppearanceIndex, meshPath);
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
                    {
                        _buildingAppearance = variant;
                        variant.RawMaterials[material.Name] = material;
                    }

                    if (model.MeshFile?.RootChunk is CMesh modelMesh)
                    {
                        var meshPath = model.DepotPath.GetResolvedText() ?? string.Empty;
                        model.Meshes = MakeMeshShared(modelMesh, model.ChunkMask, model.AppearanceIndex, meshPath);
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

    private static float SrgbToLinear01(float x)
    {
        x = Math.Clamp(x, 0f, 1f);
        return x <= 0.04045f ? x / 12.92f : MathF.Pow((x + 0.055f) / 1.055f, 2.4f);
    }

    private static float LinearToSrgb01(float x)
    {
        x = Math.Clamp(x, 0f, 1f);
        return x <= 0.0031308f ? 12.92f * x : (1.055f * MathF.Pow(x, 1f / 2.4f)) - 0.055f;
    }

    private static byte LinearToSrgbByte(float x) => (byte)Math.Clamp((int)MathF.Round(LinearToSrgb01(x) * 255f), 0, 255);

    /// <summary>
    /// Blender ColorRamp (linear interpolation, constant past the ends) sampled at the 256
    /// possible factor values. Stop colours are sRGB bytes in the profile and are converted
    /// to linear first, like populate_color_ramp in the addon. Result: linear RGB triplets.
    /// No entries → grey ramp (factor used as the value).
    /// </summary>
    private static float[] BuildLinearRampLut(List<GradientEntry> entries)
    {
        var lut = new float[256 * 3];
        if (entries.Count == 0)
        {
            for (var i = 0; i < 256; i++)
            {
                lut[i * 3] = lut[i * 3 + 1] = lut[i * 3 + 2] = i / 255f;
            }
            return lut;
        }

        var stops = entries
            .OrderBy(e => e.Value)
            .Select(e => (e.Value, R: SrgbToLinear01(e.R / 255f), G: SrgbToLinear01(e.G / 255f), B: SrgbToLinear01(e.B / 255f)))
            .ToList();

        for (var i = 0; i < 256; i++)
        {
            var t = i / 255f;
            float r, g, b;
            if (t <= stops[0].Value)
            {
                (r, g, b) = (stops[0].R, stops[0].G, stops[0].B);
            }
            else if (t >= stops[^1].Value)
            {
                (r, g, b) = (stops[^1].R, stops[^1].G, stops[^1].B);
            }
            else
            {
                var k = 0;
                while (k < stops.Count - 2 && t > stops[k + 1].Value)
                    k++;
                var a = stops[k];
                var c = stops[k + 1];
                var range = c.Value - a.Value;
                var f = range > 0 ? (t - a.Value) / range : 0f;
                r = a.R + (c.R - a.R) * f;
                g = a.G + (c.G - a.G) * f;
                b = a.B + (c.B - a.B) * f;
            }

            lut[i * 3] = r;
            lut[i * 3 + 1] = g;
            lut[i * 3 + 2] = b;
        }

        return lut;
    }

    /// <summary>
    /// Single ramp (only one of Strand_ID / Strand_Gradient present): R as factor,
    /// linear interpolation, written back as sRGB.
    /// </summary>
    private void ApplyColorRamp(Bitmap bmp, List<GradientEntry> entries, float gamma = 1f)
    {
        _ = gamma;
        if (entries.Count == 0)
            return;

        var lut = BuildLinearRampLut(entries);
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
                        int i = ptr[off + 2] * 3;
                        ptr[off + 0] = LinearToSrgbByte(lut[i + 2]);
                        ptr[off + 1] = LinearToSrgbByte(lut[i + 1]);
                        ptr[off + 2] = LinearToSrgbByte(lut[i]);
                    }
            }
        }
        finally { bmp.UnlockBits(data); }
    }

    /// <summary>
    /// Haircard albedo exactly as hair.py builds it, in linear colour:
    ///   base  = ID ramp(Strand_ID.r),  blend = RootToTip ramp(Strand_Gradient.r)
    ///   low   = base * blend * 2
    ///   high  = 1 - (1 - base) * (1 - blend) * 2
    ///   color = clamp(lum(blend) > 0.5 ? high : low)        (lum weights 0.3/0.59/0.11)
    ///   color = clamp(color * 0.6)                          (Hair Global Albedo)
    /// Written to <paramref name="idBmp"/> RGB as sRGB; alpha is left for the alpha pass.
    /// Not included: the vertex-colour hair shadow (ShadowStrength), which is per vertex.
    /// </summary>
    private static void BakeHairCardColor(Bitmap idBmp, Bitmap gradBmp,
        List<GradientEntry> idEntries, List<GradientEntry> rootToTipEntries)
    {
        var idLut = BuildLinearRampLut(idEntries);
        var rtLut = BuildLinearRampLut(rootToTipEntries);

        var rect = new Rectangle(0, 0, idBmp.Width, idBmp.Height);
        var idData = idBmp.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        var gData = gradBmp.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        try
        {
            unsafe
            {
                byte* ip = (byte*)idData.Scan0;
                byte* gp = (byte*)gData.Scan0;
                int iStride = idData.Stride;
                int gStride = gData.Stride;
                const float globalAlbedo = 0.6f;

                for (int y = 0; y < idBmp.Height; y++)
                {
                    for (int x = 0; x < idBmp.Width; x++)
                    {
                        int io = y * iStride + x * 4;
                        int go = y * gStride + x * 4;
                        int bi = ip[io + 2] * 3;   // Strand_ID.r
                        int si = gp[go + 2] * 3;   // Strand_Gradient.r

                        float br = idLut[bi], bg = idLut[bi + 1], bb = idLut[bi + 2];
                        float sr = rtLut[si], sg = rtLut[si + 1], sb = rtLut[si + 2];

                        float lum = sr * 0.3f + sg * 0.59f + sb * 0.11f;
                        float r, g, b;
                        if (lum > 0.499999f)
                        {
                            r = 1f - (1f - br) * (1f - sr) * 2f;
                            g = 1f - (1f - bg) * (1f - sg) * 2f;
                            b = 1f - (1f - bb) * (1f - sb) * 2f;
                        }
                        else
                        {
                            r = br * sr * 2f;
                            g = bg * sg * 2f;
                            b = bb * sb * 2f;
                        }

                        r = Math.Clamp(r, 0f, 1f) * globalAlbedo;
                        g = Math.Clamp(g, 0f, 1f) * globalAlbedo;
                        b = Math.Clamp(b, 0f, 1f) * globalAlbedo;

                        ip[io + 0] = LinearToSrgbByte(b);
                        ip[io + 1] = LinearToSrgbByte(g);
                        ip[io + 2] = LinearToSrgbByte(r);
                    }
                }
            }
        }
        finally
        {
            idBmp.UnlockBits(idData);
            gradBmp.UnlockBits(gData);
        }
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
        if (TryGetRawMaterial(name, out var m))
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

    // direct base path (lowercase) -> root template path (lowercase), or "" when unresolved
    private readonly System.Collections.Concurrent.ConcurrentDictionary<string, string> _templateCache =
        new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Follows BaseMaterial from the instance through any chain of .mi files to the root
    /// template (.mt / .remt). That template is what actually defines the shader, so it is
    /// a far better signal than the material name or the folder of the direct base .mi.
    /// </summary>
    private string? ResolveTemplatePath(CMaterialInstance? instance)
    {
        if (instance == null || instance.BaseMaterial.DepotPath == ResourcePath.Empty)
            return null;

        var directBase = instance.BaseMaterial.DepotPath.GetResolvedText() ?? string.Empty;
        if (directBase.Length == 0)
            return null;

        var cached = _templateCache.GetOrAdd(directBase, _ =>
        {
            var visited = new HashSet<ResourcePath>();
            CMaterialInstance? current = instance;
            while (current != null && current.BaseMaterial.DepotPath != ResourcePath.Empty &&
                   visited.Add(current.BaseMaterial.DepotPath))
            {
                var path = current.BaseMaterial.DepotPath;
                var text = (path.GetResolvedText() ?? string.Empty).Replace('/', '\\').ToLowerInvariant();
                if (text.EndsWith(".mt", StringComparison.Ordinal) || text.EndsWith(".remt", StringComparison.Ordinal))
                    return text;

                CR2WFile? file;
                try
                {
                    file = GetProjectOrDepotFile(path);
                }
                catch
                {
                    return string.Empty;
                }

                switch (file?.RootChunk)
                {
                    case CMaterialTemplate:
                        return text;
                    case CMaterialInstance next:
                        current = next;
                        break;
                    default:
                        return string.Empty;
                }
            }

            return string.Empty;
        });

        return cached.Length == 0 ? null : cached;
    }

    private string GetTemplateFileName(Material? material) =>
        Path.GetFileNameWithoutExtension(ResolveTemplatePath(material?.Instance as CMaterialInstance) ?? string.Empty);

    /// <summary>"template|direct base", lowercase, for the substring checks (emissive, wet decal, eye subtypes).</summary>
    private string? GetClassificationPath(Material? material)
    {
        if (material?.Instance is not CMaterialInstance inst)
            return null;

        var template = ResolveTemplatePath(inst) ?? string.Empty;
        var direct = (inst.BaseMaterial.DepotPath.GetResolvedText() ?? string.Empty).Replace('/', '\\').ToLowerInvariant();
        return template + "|" + direct;
    }

    /// <summary>
    /// Material kind, decided by the root template first. Name keywords are only used to
    /// split a template family the template cannot tell apart (hair cap vs other recolor
    /// decal, makeup / brows vs clothing decal, nails on metal_base), or as the old
    /// fallback when the template is unknown (e.g. a custom template from a mod).
    /// </summary>
    private MaterialKind ClassifyMaterialFor(string? name, Material? material = null)
    {
        if (material == null && !string.IsNullOrEmpty(name))
            TryGetRawMaterial(name, out material);

        var instance = material?.Instance as CMaterialInstance;
        var template = ResolveTemplatePath(instance);
        if (template != null && ClassifyByTemplate(template, name) is { } byTemplate)
            return byTemplate;

        var directBase = instance?.BaseMaterial.DepotPath.GetResolvedText();
        return ClassifyMaterial(name, directBase);
    }

    private static MaterialKind? ClassifyByTemplate(string templatePath, string? name)
    {
        var file = Path.GetFileNameWithoutExtension(templatePath);
        name ??= string.Empty;

        // Game templates: engine\materials\, base\materials\, base\fx\.
        // Anything else (custom/mod templates) falls back to the old heuristics.
        var isGameTemplate = templatePath.StartsWith("engine\\", StringComparison.Ordinal) ||
                             templatePath.StartsWith("base\\materials\\", StringComparison.Ordinal) ||
                             templatePath.StartsWith("base\\fx\\", StringComparison.Ordinal);

        if (file.Contains("skin", StringComparison.Ordinal))
            return MaterialKind.Skin;

        if (file is "hair" or "hair_blendable" or "blackwall_blendable_hair")
        {
            // Eyelashes are hair-shaded strands but get their own (dark, Strand_Alpha) bake.
            return name.Contains("lash", StringComparison.OrdinalIgnoreCase) ? MaterialKind.Eye : MaterialKind.Hair;
        }

        // eye, eye_blendable, eye_gradient*, eye_shadow*, blackwall_blendable_eye*
        if (file.StartsWith("eye", StringComparison.Ordinal) ||
            file.StartsWith("blackwall_blendable_eye", StringComparison.Ordinal))
            return MaterialKind.Eye;

        if (file.Contains("glass", StringComparison.Ordinal))
            return MaterialKind.Glass;

        if (file.Contains("decal", StringComparison.Ordinal))
        {
            // Hair caps / beards use mesh_decal_gradientmap_recolor (MaskTexture + GradientMap)
            if (file.Contains("gradientmap_recolor", StringComparison.Ordinal) && IsHairLikeName(name))
                return MaterialKind.Hair;
            // Face overlays are plain mesh_decal: only the name separates them from clothing decals.
            if (ContainsAny(name, "heb_", "hb_", "brow"))
                return MaterialKind.Eyebrow;
            if (ContainsAny(name, "hx_", "freckle", "frecle", "makeup", "lipstick", "_lips", "tattoo"))
                return MaterialKind.Makeup;
            return MaterialKind.Decal;
        }

        if (file.StartsWith("metal_base", StringComparison.Ordinal))
        {
            if (name.Contains("nail", StringComparison.OrdinalIgnoreCase))
                return MaterialKind.Nail;
            // Stitches / zippers on metal_base still need decal handling (normals + alpha).
            if (ContainsAny(name, "stitch", "zipper", "sticker"))
                return MaterialKind.Decal;
            return MaterialKind.None;
        }

        return isGameTemplate ? MaterialKind.None : null;
    }

    private static bool IsHairLikeName(string? name) =>
        !string.IsNullOrEmpty(name) &&
        (ContainsAny(name, "hh_", "hair", "dread", "beard", "mustache", "soul_patch", "_cards", "_cap", "strand"));

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
