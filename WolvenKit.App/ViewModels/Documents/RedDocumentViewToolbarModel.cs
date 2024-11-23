using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Core.Services;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

public partial class RedDocumentViewToolbarModel : ObservableObject
{
    public RedDocumentViewToolbarModel()
    {
        if (Locator.Current.GetService<ISettingsManager>() is ISettingsManager settingsSvc)
        {
            EditorLevel = settingsSvc.DefaultEditorDifficultyLevel;
        }
        else
        {
            EditorLevel = EditorDifficultyLevel.Easy;
        }

        if (Locator.Current.GetService<IModifierViewStateService>() is not IModifierViewStateService svc)
        {
            return;
        }

        _modifierViewStateService = svc;
        svc.ModifierStateChanged += OnModifierChanged;
        svc.PropertyChanged += (_, args) => OnPropertyChanged(args.PropertyName); 

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

        isEmptySubmeshesDeleted = false;
    }


    [NotifyCanExecuteChangedFor(nameof(DeleteEmptySubmeshesCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteDuplicateEntriesCommand))]
    [NotifyCanExecuteChangedFor(nameof(RegenerateVisualControllersCommand))]
    [NotifyCanExecuteChangedFor(nameof(DeleteUnusedMaterialsCommand))]
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
    [NotifyCanExecuteChangedFor(nameof(DeleteUnusedMaterialsCommand))]
    [NotifyCanExecuteChangedFor(nameof(ConvertPreloadMaterialsCommand))]
    [ObservableProperty]
    private ChunkViewModel? _selectedChunk;

    private List<ChunkViewModel> SelectedChunks { get; } = [];

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

    private bool CanRegenerateVisualControllers() => SelectedChunk is { Name: "components", Data: CArray<entIComponent> };

    [RelayCommand(CanExecute = nameof(CanRegenerateVisualControllers))]
    private void RegenerateVisualControllers() => SelectedChunk?.RegenerateVisualControllerCommand.Execute(null);

    private bool CanDeleteDuplicateEntries() => ContentType is RedDocumentItemType.Json;

    [RelayCommand(CanExecute = nameof(CanDeleteDuplicateEntries))]
    private void DeleteDuplicateEntries() => RootChunk?.DeleteDuplicateEntriesCommand.Execute(null);

    private bool isEmptySubmeshesDeleted = false;
    private bool CanDeleteEmptySubmeshes() => ContentType is RedDocumentItemType.Mesh && !isEmptySubmeshesDeleted;

    [RelayCommand(CanExecute = nameof(CanDeleteEmptySubmeshes))]
    private void DeleteEmptySubmeshes()
    {
        isEmptySubmeshesDeleted = true;
        RootChunk?.DeleteEmptySubmeshesCommand.Execute(null);
    }

    private bool CanScrollToMaterial() => SelectedChunk?.ShowScrollToMaterial == true;

    [RelayCommand(CanExecute = nameof(CanScrollToMaterial))]
    private void ScrollToMaterial() => SelectedChunk?.ScrollToMaterialCommand.Execute(null);

    private bool CanToggleEnableMask() => SelectedChunk?.ResolvedData is CMaterialInstance or CArray<IMaterial>;

    [RelayCommand(CanExecute = nameof(CanToggleEnableMask))]
    private void ToggleEnableMask() => SelectedChunk?.ToggleEnableMaskedCommand.Execute(null);

    private bool CanConvertPreloadMaterials() => RootChunk?.ResolvedData is CMesh mesh &&
                                                 (mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0);

    [RelayCommand(CanExecute = nameof(CanConvertPreloadMaterials))]
    private void ConvertPreloadMaterials() => RootChunk?.ConvertPreloadMaterialsCommand.Execute(null);

    private bool CanClearAppearances() => RootChunk?.CanClearMaterials() == true;

    private bool HasMeshAppearances() => RootChunk?.ResolvedData is CMesh mesh && mesh.Appearances.Count > 0;

    [RelayCommand(CanExecute = nameof(CanClearAppearances))]
    private void ClearMaterials() => RootChunk?.ClearMaterialsCommand.Execute(null);

    public bool IsMaterialDefinition() => SelectedChunk?.IsMaterialDefinition() == true;

    [RelayCommand(CanExecute = nameof(IsMaterialDefinition))]
    private void ToggleLocalInstance()
    {
        foreach (var chunk in SelectedChunks)
        {
            chunk.ToggleMaterialDefinitionIsExternalCommand.Execute(null);
        }

        SelectedChunks.LastOrDefault()?.Parent?.RecalculateProperties();
    }

    private bool CanDeleteUnusedMaterials() => RootChunk?.ResolvedData is CMesh mesh && mesh.MaterialEntries.Count > 0;

    [RelayCommand(CanExecute = nameof(CanDeleteUnusedMaterials))]
    private void DeleteUnusedMaterials() => RootChunk?.DeleteUnusedMaterialsCommand.Execute(false);

    [RelayCommand(CanExecute = nameof(HasMeshAppearances))]
    private void GenerateMissingMaterials()
    {
        // Do nothing, we just need the command for the hook. Logic will trigger from view's OnClick
    }

    #endregion

    public void OnSearchChanged(string searchBoxText)
    {
        if (CurrentTab is not RDTDataViewModel rtdViewModel)
        {
            return;
        }

        rtdViewModel.OnSearchChanged(searchBoxText);
    }
}