using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RedDocumentViewToolbarModel : ObservableObject
{
    public RedDocumentViewToolbarModel(
        ISettingsManager settingsSvc,
        IModifierViewStateService modifierSvc
    )
    {
        EditorLevel = settingsSvc.DefaultEditorDifficultyLevel;

        _modifierViewStateService = modifierSvc;
        modifierSvc.ModifierStateChanged += OnModifierChanged;
        modifierSvc.PropertyChanged += (_, args) => OnPropertyChanged(args.PropertyName);

        RefreshMenuVisibility(true);
    }

    private void OnModifierChanged() => IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;

    private readonly IModifierViewStateService? _modifierViewStateService;

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
        if (dataViewModel.SelectedChunks is IList list)
        {
            SelectedChunks.AddRange(list.OfType<ChunkViewModel>());
        }

        RefreshMeshMenuItems();

        SelectedChunk ??= RootChunk;

        _isEmptySubmeshesDeleted = false;
    }


    [NotifyCanExecuteChangedFor(nameof(AdjustSubmeshCountCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteDuplicateEntriesCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateVisualControllersCommand))]
    [NotifyCanExecuteChangedFor(nameof(GenerateMissingMaterialsCommand))]
    [ObservableProperty]
    private RedDocumentItemType _contentType;
    
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesFullCommand))]
    [NotifyCanExecuteChangedFor(nameof(ClearMaterialsCommand))]
    [ObservableProperty] private bool _isShiftKeyDown;

    [NotifyCanExecuteChangedFor(nameof(AddDependenciesCommand))]
    [NotifyCanExecuteChangedFor(nameof(AddDependenciesFullCommand))]
    [NotifyCanExecuteChangedFor(nameof(GenerateNewCruidCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateVisualControllersCommand))]
    [NotifyCanExecuteChangedFor(nameof(ClearMaterialsCommand))]
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

        ConvertPreloadMaterialsCommand.NotifyCanExecuteChanged();
    }

    public void SetCurrentTab(RedDocumentTabViewModel? value)
    {
        CurrentTab = value;
        RefreshMenuVisibility();
    }

    public void SetEditorLevel(EditorDifficultyLevel level)
    {
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
                                                     (ContentType is RedDocumentItemType.App && SelectedChunk is
                                                         { Name: "components", Data: CArray<entIComponent> });
    
    [RelayCommand(CanExecute = nameof(CanRegenerateVisualControllers))]
    private void RegenerateVisualControllers()
    {
        if (SelectedChunk is { Name: "components", Data: CArray<entIComponent> })
        {
            SelectedChunk?.RegenerateVisualControllerCommand.Execute(null);
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
                                               FilePath is string filePath &&
                                               !SelectPhotoModeAppViewModel.PhotomodeAppPaths.Contains(filePath);

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
    [RelayCommand(CanExecute = nameof(HasMeshAppearances))]
    private void GenerateMissingMaterials()
    {
        // Do nothing, we just need the command for the hook. Logic will trigger from view's OnClick
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
}