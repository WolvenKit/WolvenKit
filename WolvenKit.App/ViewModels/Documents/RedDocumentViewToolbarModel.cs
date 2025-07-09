using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Common.Extensions;
using WolvenKit.Core.Services;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RedDocumentViewToolbarModel : ObservableObject
{
    
    private readonly IProjectManager _projectManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IModifierViewStateService? _modifierViewStateService;

    public RedDocumentViewToolbarModel(
        ISettingsManager settingsManager,
        IModifierViewStateService modifierSvc,
        IProjectManager projectManager
    )
    {
        _modifierViewStateService = modifierSvc;
        _projectManager = projectManager;
        _settingsManager = settingsManager;

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

        RefreshMeshMenuItems();
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

        RefreshMeshMenuItems();

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

    private void RefreshMeshMenuItems()
    {

        IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;

        if (!ShowToolbar || CurrentTab is null)
        {
            return;
        }

        ClearChunkMaterialsCommand.NotifyCanExecuteChanged();
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
    private void AddDependenciesFull() => OnAddDependencies?.Invoke(this, EventArgs.Empty);

    private bool CanGenerateNewCruid() => SelectedChunk?.PropertyType == typeof(CRUID);

    [RelayCommand(CanExecute = nameof(CanGenerateNewCruid))]
    private void GenerateNewCruid() => SelectedChunk?.GenerateCRUIDCommand.Execute(null);

    #region appFile

    /*
     * Regenerate visual controllers
     */
    private bool CanRegenerateVisualControllers() => ContentType is RedDocumentItemType.Ent ||
                                                     ContentType is RedDocumentItemType.App;
    
    [RelayCommand(CanExecute = nameof(CanRegenerateVisualControllers))]
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
    private void DeleteUnusedMaterials() => RootChunk?.DeleteUnusedMaterialsCommand.Execute(false);

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

        foreach (var cvm in selectedMeshAppearances)
        {
            ((meshMeshAppearance)cvm.ResolvedData).ChunkMaterials.Clear();
            cvm.RecalculateProperties();
        }

        SelectedChunks.LastOrDefault()?.Parent?.RecalculateProperties();
        SelectedChunks.LastOrDefault()?.Tab?.Parent?.SetIsDirty(true);
    }

    [RelayCommand(CanExecute = nameof(HasMeshAppearances))]
    private void GenerateMissingMaterials()
    {
        // Do nothing, we just need the command for the hook. Logic will trigger from view's OnClick
    }

    private bool CanConvertHairToCCXL() => RootChunk?.ResolvedData is CMesh mesh;

    [RelayCommand(CanExecute = nameof(CanConvertHairToCCXL))]
    private void ConvertHairToCCXL() { 
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