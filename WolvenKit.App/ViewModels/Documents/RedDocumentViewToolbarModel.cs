using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public class AddDependenciesFullEventArgs : EventArgs
{
}

public partial class RedDocumentViewToolbarModel : ObservableObject
{

    private readonly IProjectManager _projectManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IModifierViewStateService? _modifierViewStateService;
    private readonly CRUIDService _cruidService;
    private readonly DocumentTools _documentTools;
    private readonly ILoggerService _loggerService;

    public RedDocumentViewToolbarModel(
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc,
        IProjectManager projectManager,
        DocumentTools documentTools,
        CRUIDService cruidService,
        ILoggerService loggerService
    )
    {
        _modifierViewStateService = modifierSvc;
        _projectManager = projectManager;
        _settingsManager = settingsManager;
        _cruidService = cruidService;
        _documentTools = documentTools;
        _loggerService = loggerService;

        modifierSvc.ModifierStateChanged += OnModifierChanged;
        modifierSvc.PropertyChanged += (_, args) => OnPropertyChanged(args.PropertyName);

        EditorLevel = settingsManager.DefaultEditorDifficultyLevel;
        _settingsManager.PropertyChanged += (_, args) =>
        {
            if (args.PropertyName == nameof(ISettingsManager.DefaultEditorDifficultyLevel))
            {
                SetEditorLevel(_settingsManager.DefaultEditorDifficultyLevel);
            }
        };

        RefreshMenuVisibility(true);
    }

    private void OnModifierChanged() => IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;


    [ObservableProperty] private RedDocumentTabViewModel? _currentTab;
    [ObservableProperty] private EditorDifficultyLevel _editorLevel;

    public ChunkViewModel? RootChunk { get; private set; }

    public string? FilePath => CurrentTab?.FilePath;
    public CR2WFile? Cr2WFile => CurrentTab?.Parent.Cr2wFile;

    [ObservableProperty] private bool _showToolbar;

    public void RefreshMenuVisibility(bool forceRefreshContentType = false)
    {
        if (forceRefreshContentType)
        {
            ContentType = RedDocumentItemType.Other;
        }

        ContentType = CurrentTab?.GetContentType() ?? RedDocumentItemType.None;
        ShowToolbar = ContentType switch
        {
            RedDocumentItemType.Mesh
                or RedDocumentItemType.App
                or RedDocumentItemType.Csv
                or RedDocumentItemType.Mi
                or RedDocumentItemType.Json
                or RedDocumentItemType.Morphtarget
                or RedDocumentItemType.Mltemplate
                or RedDocumentItemType.Anims
                or RedDocumentItemType.Workspot
                or RedDocumentItemType.Inkatlas
                or RedDocumentItemType.Questphase
                or RedDocumentItemType.Scene
                or RedDocumentItemType.Physmatlib
                or RedDocumentItemType.Ent => true,
            RedDocumentItemType.Xbm
                or RedDocumentItemType.Mlmask
                or RedDocumentItemType.Mlsetup
                or RedDocumentItemType.Sector
                or RedDocumentItemType.None
                or RedDocumentItemType.Other => false,
            _ => false,
        };

        SelectedChunk = null;
        RootChunk = null;

        if (CurrentTab is RDTDataViewModel rtdViewModel)
        {
            RootChunk = rtdViewModel.GetRootChunk();
            rtdViewModel.PropertyChanged += OnRtdModelPropertyChanged;
            if (rtdViewModel.SelectedChunk is ChunkViewModel cvm)
            {
                SelectedChunk = cvm;
            }
        }

        RefreshContextMenuItems();
    }

    private void OnRtdModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (sender is not RDTDataViewModel dataViewModel || e.PropertyName is not
                (nameof(RDTDataViewModel.SelectedChunk)
                or nameof(RDTDataViewModel.SelectedChunks)
                or nameof(RDTDataViewModel.FilePath))
           )
        {
            return;
        }

        SelectedChunk = (ChunkViewModel?)dataViewModel.SelectedChunk;
        SelectedChunks.Clear();
        var chunkViewModels = dataViewModel.SelectedChunks?.OfType<ChunkViewModel>().ToList() ?? [];
        SelectedChunks.AddRange(chunkViewModels);

        RefreshContextMenuItems();

        SelectedChunk ??= RootChunk;

        _isEmptySubmeshesDeleted = false;
    }


    public void ClearSelection()
    {
        if (CurrentTab is not RDTDataViewModel viewModel)
        {
            return;
        }

        viewModel.ClearSelection();
    }

    public void SetSelection(List<ChunkViewModel> chunks)
    {
        if (CurrentTab is not RDTDataViewModel viewModel)
        {
            return;
        }

        viewModel.ClearSelection();
        viewModel.SetSelection(chunks
            .Where(x => x.Parent is null || x.Parent.IsExpanded)
            .ToList());
    }

    [NotifyCanExecuteChangedFor(nameof(ClearChunkMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(AdjustSubmeshCountCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteDuplicateEntriesCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateVisualControllersCommand))]
    [NotifyCanExecuteChangedFor(nameof(GenerateMissingMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertHairToCCXLCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateIdsCommand))]
    [ObservableProperty]
    private RedDocumentItemType _contentType;

    [NotifyCanExecuteChangedFor(nameof(AddDependenciesCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesFullCommand))]
    [ObservableProperty] private bool _isShiftKeyDown;

    [NotifyCanExecuteChangedFor(nameof(ClearChunkMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesFullCommand))]
    [NotifyCanExecuteChangedFor(nameof(GenerateNewCruidCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateVisualControllersCommand))]
    [NotifyCanExecuteChangedFor(nameof(ToggleEnableMaskCommand))]
    [NotifyCanExecuteChangedFor(nameof(ScrollToMaterialCommand))]
    [NotifyCanExecuteChangedFor(nameof(ToggleLocalInstanceCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteDuplicateEntriesCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertPreloadMaterialsCommand))]
    [ObservableProperty]
    private ChunkViewModel? _selectedChunk;

    public List<ChunkViewModel> SelectedChunks { get; } = [];

    private void RefreshContextMenuItems()
    {

        IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;

        if (!ShowToolbar || CurrentTab is null)
        {
            return;
        }

        ClearChunkMaterialsCommand.NotifyCanExecuteChanged();
        RegenerateAllCRUIDsCommand.NotifyCanExecuteChanged();
        ConvertPreloadMaterialsCommand.NotifyCanExecuteChanged();
    }

    public void SetCurrentTab(RedDocumentTabViewModel? value)
    {
        CurrentTab = value;
        RefreshMenuVisibility();
    }

    // Editor level is required for view binding (updating colour of eye icon)
    // setting it will refresh expansion states, though
    public void SetEditorLevel(EditorDifficultyLevel level)
    {
        if (EditorLevel == level)
        {
            return;
        }

        EditorLevel = level;
        RootChunk?.SetEditorLevel(level);
    }

    private bool HasDependencies() => ContentType is RedDocumentItemType.Mesh or RedDocumentItemType.Mi or RedDocumentItemType.Mlsetup;

    public event EventHandler? OnAddDependencies;

    #region commands

    private bool CanAddDependencies() => HasDependencies() && !IsShiftKeyDown;

    [RelayCommand(CanExecute = nameof(CanAddDependencies))]
    private void AddDependencies() => OnAddDependencies?.Invoke(this, EventArgs.Empty);

    private bool CanAddDependenciesFull() => HasDependencies() && IsShiftKeyDown;

    [RelayCommand(CanExecute = nameof(CanAddDependenciesFull))]
    private void AddDependenciesFull() => OnAddDependencies?.Invoke(this, new AddDependenciesFullEventArgs() { });

    private bool CanGenerateNewCruid() => SelectedChunk?.PropertyType == typeof(CRUID);

    [RelayCommand(CanExecute = nameof(CanGenerateNewCruid))]
    private void GenerateNewCruid() => SelectedChunk?.GenerateCRUIDCommand.Execute(null);

    #region appFile

    // Disable command if "regenerate CRUID" menu item is shown
    private bool CanRegenerateAllCRUIDs() => IsInEntOrAppFile() && SelectedChunk?.ResolvedData is CArray<entIComponent>
        or entIComponent or appearanceAppearanceDefinition
        or CArray<CHandle<appearanceAppearanceDefinition>> or appearanceAppearanceResource or entEntityTemplate;

    [RelayCommand(CanExecute = nameof(CanRegenerateAllCRUIDs))]
    private void RegenerateAllCRUIDs()
    {
        var chunk = SelectedChunk ??= RootChunk;
        var componentChunks = CollectComponents();

        if (chunk is null || componentChunks.Count == 0)
        {
            return;
        }

        foreach (var cvm in componentChunks)
        {
            if (cvm.GetPropertyChild("id") is not ChunkViewModel { Data: CRUID } idChunk)
            {
                continue;
            }

            idChunk.Data = _cruidService.GenerateNewCRUID();
            idChunk.RecalculateProperties();
            cvm.RecalculateProperties();
        }

        var parent = componentChunks.First().Parent ?? SelectedChunk;
        while (parent is not null && parent != SelectedChunk && parent.Parent is not null)
        {
            parent.RecalculateProperties();
            parent = parent.Parent;
        }

        parent?.Tab?.Parent.SetIsDirty(true);

        return;

        List<ChunkViewModel> CollectComponents()
        {
            if (chunk is null)
            {
                return [];
            }

            switch (chunk.ResolvedData)
            {
                case CArray<entIComponent>:
                    return [.. chunk.Properties];
                case entIComponent:
                    return [chunk];
                case appearanceAppearanceDefinition:
                    return chunk.GetPropertyChild("components")?.Properties.ToList() ?? [];
                case CArray<CHandle<appearanceAppearanceDefinition>>:
                    var appearances = chunk.Properties
                        .Where(x => x.ResolvedData is appearanceAppearanceDefinition)
                        .Select(x => x.GetPropertyChild("components")).ToList() ?? [];

                    foreach (var chunkViewModel in appearances)
                    {
                        chunkViewModel?.CalculateProperties();
                    }

                    return appearances
                        .SelectMany(x => x?.Properties ?? [])
                        .ToList() ?? [];
                case appearanceAppearanceResource:
                    return chunk.GetPropertyChild("appearances")
                        ?.Properties.Where(x => x.ResolvedData is appearanceAppearanceDefinition)
                        .SelectMany(x => x.Properties)
                        .ToList() ?? [];
                case entEntityTemplate:
                    return chunk.GetPropertyChild("components")?.Properties.ToList() ?? [];
                default: return [];
            }
        }
    }

    /*
     * Regenerate visual controllers
     */
    private bool IsInEntOrAppFile() => ContentType is RedDocumentItemType.Ent or RedDocumentItemType.App;

    [RelayCommand(CanExecute = nameof(IsInEntOrAppFile))]
    private void RegenerateVisualControllers()
    {
        if (SelectedChunk is { Name: "components", Data: CArray<entIComponent> })
        {
            SelectedChunk?.RegenerateVisualControllerCommand.Execute(null);
            return;
        }

        // app file
        if (RootChunk?.ResolvedData is appearanceAppearanceResource appRoot &&
            RootChunk.GetPropertyChild("appearances") is ChunkViewModel appearances)
        {
            appearances.CalculateProperties();
            foreach (var app in appearances.TVProperties.Where(x => x.ResolvedData is appearanceAppearanceDefinition))
            {
                app.RegenerateVisualControllerCommand.Execute(null);
            }

            return;
        }

        // .ent file
        RootChunk?.GetPropertyChild("components")?.RegenerateVisualControllerCommand.Execute(null);
    }

    /// <summary>
    /// Sets the LOD levels of all visual components to 0.
    /// </summary>
    [RelayCommand(CanExecute = nameof(IsInEntOrAppFile))]
    private void ForceLodLevelZero()
    {
        if (RootChunk is null)
        {
            return;
        }


        List<entIVisualComponent> components = [];
        List<ChunkViewModel?> chunksToRefresh = [];
        switch (RootChunk.ResolvedData)
        {
            case entEntityTemplate template:
                components.AddRange(template.Components.OfType<entIVisualComponent>());
                chunksToRefresh.Add(RootChunk.GetPropertyChild("components"));
                break;
            case appearanceAppearanceResource app
                when RootChunk.GetPropertyChild("appearances") is ChunkViewModel appearances:
            {
                appearances.CalculateProperties();
                foreach (var appearanceCvm in appearances.Properties)
                {
                    appearanceCvm.CalculateProperties();
                    var componentChild = appearanceCvm.GetPropertyChild("components");
                    if (componentChild is null)
                    {
                        continue;
                    }

                    componentChild.CalculateProperties();
                    chunksToRefresh.AddRange(componentChild.Properties);
                    chunksToRefresh.Add(componentChild);
                    chunksToRefresh.Add(appearanceCvm);
                }

                components.AddRange(app.Appearances
                    .Select(a => a.Chunk?.Components ?? [])
                    .SelectMany(c => c.OfType<entIVisualComponent>()));

                break;
            }
        }

        var lodLevelsChanged = 0;
        foreach (var comp in components.Where(c => c.ForceLODLevel != 0))
        {
            comp.ForceLODLevel = 0;
            lodLevelsChanged += 1;
        }

        if (lodLevelsChanged == 0)
        {
            _loggerService.Info($"No LOD levels left to change.");
            return;
        }

        foreach (var cvm in chunksToRefresh.Where(c => c is not null))
        {
            cvm!.RecalculateProperties();
        }

        _loggerService.Success($"Changed LOD level for {lodLevelsChanged} components.");
        RootChunk.Tab?.Parent.SetIsDirty(true);
    }

    /// <summary>
    /// Regenerates resolved dependencies. Will only work in .ent or .app file.
    /// Logic is courtesy of psiberx.
    /// </summary>
    [RelayCommand(CanExecute = nameof(IsInEntOrAppFile))]
    private void RegenerateResolvedDependencies()
    {
        if (RootChunk?.ResolvedData is entEntityTemplate template)
        {
            var refs = template.FindType(typeof(IRedRef))
                .Select(f => f.Value).OfType<IRedRef>()
                .SelectMany(r => _documentTools.CollectDependencies(r))
                .SelectMany(rr =>
                    ArchiveXlHelper.ResolveDynamicPaths(rr.DepotPath.GetResolvedText() ?? "",
                        _projectManager.ActiveProject))
                .Distinct();

            var refCount = template.ResolvedDependencies.Count;

            template.ResolvedDependencies.Clear();
            foreach (var path in refs)
            {
                template.ResolvedDependencies.Add(new CResourceAsyncReference<CResource>(path));
            }

            RootChunk.GetPropertyChild("resolvedDependencies")?.RecalculateProperties();
            RootChunk.RecalculateProperties();
            RootChunk.Tab?.Parent?.SetIsDirty(template.ResolvedDependencies.Count > 0 || refCount > 0);
            return;
        }

        if (RootChunk?.ResolvedData is not appearanceAppearanceResource)
        {
            return;
        }

        List<ChunkViewModel> selectedChunks = [];
        var isDirty = false;

        // If a single appearance is selected, we only regenerate that one's resolved dependencies
        if (SelectedChunk?.ResolvedData is appearanceAppearanceDefinition)
        {
            selectedChunks.Add(SelectedChunk);
        }
        else if (RootChunk?.ResolvedData is appearanceAppearanceResource &&
                 RootChunk.GetPropertyChild("appearances") is ChunkViewModel appearances)
        {
            selectedChunks.AddRange(appearances.Properties);
        }

        foreach (var appChunk in selectedChunks)
        {
            if (appChunk.ResolvedData is not appearanceAppearanceDefinition appearance)
            {
                continue;
            }

            var refCount = appearance.ResolvedDependencies.Count;
            var refs = appearance.FindType(typeof(IRedRef))
                .Select(f => f.Value).OfType<IRedRef>()
                .SelectMany(r => _documentTools.CollectDependencies(r))
                .SelectMany(rr => ArchiveXlHelper.ResolveDynamicPaths(
                    rr.DepotPath.GetResolvedText() ?? "",
                    _projectManager.ActiveProject))
                .Distinct();

            appearance.ResolvedDependencies.Clear();
            foreach (var path in refs)
            {
                appearance.ResolvedDependencies.Add(new CResourceAsyncReference<CResource>(path));
            }

            if (appChunk.GetPropertyChild("resolvedDependencies") is ChunkViewModel depChild)
            {
                depChild.Data = appearance.ResolvedDependencies;
                depChild.RecalculateProperties();
            }

            appChunk.RecalculateProperties();

            isDirty |= appearance.ResolvedDependencies.Count > 0 || refCount > 0;
        }

        RootChunk?.Tab?.Parent?.SetIsDirty(isDirty);
    }
    private bool CanChangeAnimationComponent() => RootChunk?.ResolvedData is appearanceAppearanceResource;

    /*
     * Convert to photo mode app
     */
    private bool CanConvertToPhotoModeApp() => RootChunk?.ResolvedData is appearanceAppearanceResource &&
                                               !string.IsNullOrEmpty(FilePath);

    [RelayCommand(CanExecute = nameof(CanConvertToPhotoModeApp))]
    private void ConvertToPhotoModeApp()
    {
        // do nothing, we're handling this in view model's click
    }

    [RelayCommand(CanExecute = nameof(CanChangeAnimationComponent))]
    private void ChangeAnimationComponent()
    {
        // do nothing, we're handling this in view model's click
    }

    /*
     * app: delete unused animation components
     */
    private bool CanDeleteUnusedAnimationComponents() => RootChunk?.ResolvedData is appearanceAppearanceResource app &&
                                                         app.Appearances.Count > 0;

    [RelayCommand(CanExecute = nameof(CanDeleteUnusedAnimationComponents))]
    private void DeleteUnusedAnimationComponents()
    {
        // do nothing, we're handling this in view model's click
    }


    #endregion

    #region jsonFile

    /*
     * Delete duplicate entries
     */
    private bool CanDeleteDuplicateEntries() => ContentType is RedDocumentItemType.Json;

    [RelayCommand(CanExecute = nameof(CanDeleteDuplicateEntries))]
    private void DeleteDuplicateEntries() => RootChunk?.DeleteDuplicateEntriesCommand.Execute(null);

    #endregion

    #region meshFile

    /*
     * Delete empty submeshes
     */
    private bool _isEmptySubmeshesDeleted;

    private bool CanAdjustSubmeshCount() =>
        !_isEmptySubmeshesDeleted && ContentType is RedDocumentItemType.Mesh && !_isEmptySubmeshesDeleted;

    [RelayCommand(CanExecute = nameof(CanAdjustSubmeshCount))]
    private void AdjustSubmeshCount()
    {
        _isEmptySubmeshesDeleted = true;
        RootChunk?.AdjustSubmeshCountCommand.Execute(null);
    }

    /*
     * Scroll to material
     */
    private bool CanScrollToMaterial() => SelectedChunk?.ShowScrollToMaterial == true;

    [RelayCommand(CanExecute = nameof(CanScrollToMaterial))]
    private void ScrollToMaterial() => SelectedChunk?.ScrollToMaterialCommand.Execute(null);

    /*
     * mesh: convert preloadXXX to regular local materials
     */
    private bool CanConvertPreloadMaterials() => RootChunk?.ResolvedData is CMesh mesh &&
                                                 (mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0);

    [RelayCommand(CanExecute = nameof(CanConvertPreloadMaterials))]
    private void ConvertPreloadMaterials() => RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

    /*
     * mesh: clear appearances
     */
    private bool CanClearMaterials() => RootChunk?.ResolvedData is CMesh;

    private bool HasMeshAppearances() => RootChunk?.ResolvedData is CMesh { Appearances.Count: > 0 };

    [RelayCommand(CanExecute = nameof(CanClearMaterials))]
    private void ClearMaterials()
    {
        if (RootChunk?.ResolvedData is not CMesh mesh)
        {
            return;
        }

        mesh.Appearances.Clear();
        RootChunk.DeleteUnusedMaterialsCommand.Execute(false);
    }

    #region meshfile_materials

    /*
     * Toggle "Enable mask"
     */
    private bool IsMaterialDefinitionOrParent() => SelectedChunk?.ResolvedData is CMaterialInstance or CArray<IMaterial>;

    [RelayCommand(CanExecute = nameof(IsMaterialDefinitionOrParent))]
    private void ToggleEnableMask() => SelectedChunk?.ToggleEnableMaskedCommand.Execute(null);

    /*
     * Toggle "Local instance"
     */
    [RelayCommand(CanExecute = nameof(IsMaterialDefinitionOrParent))]
    private void ToggleLocalInstance()
    {
        foreach (var chunk in SelectedChunks)
        {
            chunk.ToggleMaterialDefinitionIsExternalCommand.Execute(null);
        }

        SelectedChunks.LastOrDefault()?.Parent?.RecalculateProperties();
    }

    #endregion

    private bool CanDeleteUnusedMaterials() => RootChunk?.ResolvedData is CMesh mesh && mesh.MaterialEntries.Count > 0;

    [RelayCommand(CanExecute = nameof(CanDeleteUnusedMaterials))]
    private void DeleteUnusedMaterials()
    {
        if (RootChunk?.ResolvedData is not CMesh mesh)
        {
            return;
        }

        if (FilePath?.Contains(Path.DirectorySeparatorChar + "he_") == true && mesh.Appearances
                .Select(appHandle => appHandle.Chunk)
                .OfType<meshMeshAppearance>().SelectMany(app => app.ChunkMaterials)
                .Select(s => s.GetResolvedText() ?? "")
                .FirstOrDefault(s => s is "eyeMat3" or "eyelashes_MAT") is string matName)
        {
            var materialNames = mesh.MaterialEntries.Select(s => s.Name.GetResolvedText() ?? "")
                .Where(s => s.StartsWith("eyelash")).ToList();

            // we have an eye mesh with template materials - ask user for eyelash colour
            var eyelashColor = Interactions.AskForDropdownOption((materialNames, "Select eye lash colour",
                "Pick your eye lash colour (things will break if you don't):", string.Empty, false, string.Empty));

            if (!string.IsNullOrEmpty(eyelashColor))
            {
                foreach (var app in mesh.Appearances.Select(appHandle => appHandle.Chunk)
                             .OfType<meshMeshAppearance>())
                {
                    var chunkMaterials = new CArray<CName>();
                    foreach (var chunk in app.ChunkMaterials)
                    {
                        if (chunk.GetResolvedText() == matName)
                        {
                            chunkMaterials.Add(eyelashColor);
                        }
                        else
                        {
                            chunkMaterials.Add(chunk);
                        }
                    }

                    app.ChunkMaterials = chunkMaterials;
                }
            }

            RootChunk.GetPropertyChild("appearances")?.CalculateProperties();
        }

        RootChunk?.DeleteUnusedMaterialsCommand.Execute(false);
    }

    #endregion

    #region phymatlibFile

    /*
     * Delete duplicate entries
     */
    private bool CanRegenerateIds() => ContentType is RedDocumentItemType.Physmatlib;

    [RelayCommand(CanExecute = nameof(CanRegenerateIds))]
    private void RegenerateIds() => RootChunk?.RegenerateIdsCommand.Execute(null);

    #endregion

    private bool CanClearChunkMaterials() => SelectedChunks.All(c => c.ResolvedData is meshMeshAppearance);


    [RelayCommand(CanExecute = nameof(CanClearChunkMaterials))]
    private void ClearChunkMaterials()
    {
        if (CurrentTab is not RDTDataViewModel viewModel)
        {
            return;
        }

        var selectedMeshAppearances =
            SelectedChunks.Where(chunk => chunk.ResolvedData is meshMeshAppearance).ToList();
        if (selectedMeshAppearances.Count != SelectedChunks.Count)
        {
            return;
        }

        foreach (var cvm in SelectedChunks.Select(c => c.GetPropertyChild("chunkMaterials")).Where(c => c is not null))

        {
            cvm!.ClearChildren();
            cvm.Parent?.RecalculateProperties();
        }

    }

    [RelayCommand(CanExecute = nameof(HasMeshAppearances))]
    private void GenerateMissingMaterials()
    {
        // Do nothing, we just need the command for the hook. Logic will trigger from view's OnClick
    }

    private bool CanConvertHairToCCXL() => RootChunk?.ResolvedData is CMesh mesh;

    [RelayCommand(CanExecute = nameof(CanConvertHairToCCXL))]
    private void ConvertHairToCCXL()
    {
        // This is just to hide the button from the .mi toolbar
    }

    #endregion

    public static string CurrentActiveSearch = "";

    public void OnSearchChanged(string searchBoxText)
    {
        CurrentActiveSearch = "";
        if (CurrentTab is not RDTDataViewModel rtdViewModel)
        {
            return;
        }

        rtdViewModel.OnSearchChanged(searchBoxText);
    }

    /// <summary>
    /// Gets the texture directory for dependencies from current project's active file
    /// </summary>
    /// <param name="useTextureSubfolder"></param>
    /// <returns></returns>
    public string GetTextureDirForDependencies(bool useTextureSubfolder)
    {
        var destFolder = "";
        if (_projectManager.ActiveProject?.ModDirectory is string modDir
            && FilePath?.RelativePath(new DirectoryInfo(modDir)) is string activeFilePath
            && Path.GetDirectoryName(activeFilePath) is string dirName && !string.IsNullOrEmpty(dirName))
        {
            if (!useTextureSubfolder || dirName.Contains("textures"))
            {
                destFolder = dirName;
            }
            else if (CurrentTab?.FilePath is not string filePath ||
                     Directory.GetFiles(Path.Combine(filePath, ".."), "*.mesh").Length <= 1)
            {
                destFolder = Path.Combine(dirName, "textures");
            }
            else
            {
                // if the folder contains more than one .mesh file, add a subdirectory inside "textures"
                var fileName = Path.GetFileName(CurrentTab.FilePath.Split('.').FirstOrDefault() ?? "").ToFileName();
                destFolder = Path.Combine(dirName, fileName);
            }
        }

        destFolder = Interactions.AskForTextInput(("Target folder for dependencies", destFolder));

        if (!string.IsNullOrEmpty(destFolder))
        {
            return destFolder;
        }

        var projectName = _projectManager.ActiveProject?.Name ?? "yourProject";
        var subfolder = _settingsManager.ModderName ?? "YourName";
        return Path.Join(subfolder, projectName, "dependencies");
    }

}
