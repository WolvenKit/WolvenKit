using System;
using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
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
        RefreshMenuVisibility();
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
    }


    private void OnModifierChanged() => IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;

    private readonly IModifierViewStateService? _modifierViewStateService;

    [ObservableProperty] private RedDocumentTabViewModel? _currentTab;
    [ObservableProperty] private EditorDifficultyLevel _editorLevel;

    public ChunkViewModel? RootChunk { get; set; }
    public ChunkViewModel? SelectedChunk { get; set; }

    public string? FilePath => CurrentTab?.FilePath;
    public CR2WFile? Cr2WFile => CurrentTab?.Parent.Cr2wFile;

    [ObservableProperty] private bool _showToolbar;

    public void RefreshMenuVisibility()
    {
        ShowToolbar = CurrentTab?.GetContentType() switch
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

        if (ShowToolbar)
        {
            RefreshMeshMenuItems();
        }
    }

    private void OnRtdModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(RDTDataViewModel.SelectedChunk) || sender is not RDTDataViewModel dataViewModel)
        {
            return;
        }

        SelectedChunk = (ChunkViewModel?)dataViewModel.SelectedChunk;

        IsRegenerateMaterialCommandEnabled = SelectedChunk is { Name: "components", Data: CArray<entIComponent> };
        IsGenerateNewCruidCommandEnabled = SelectedChunk?.PropertyType == typeof(CRUID);
    }

    [ObservableProperty] private bool _isMesh;
    [ObservableProperty] private bool _isFileValidationMenuVisible;

    [ObservableProperty] private bool _isMaterialMenuEnabled;
    [ObservableProperty] private bool _isConvertMaterialMenuEnabled;
    [ObservableProperty] private bool _isGenerateMaterialCommandEnabled;
    [ObservableProperty] private bool _isDeleteUnusedMaterialCommandEnabled;
    [ObservableProperty] private bool _isRegenerateMaterialCommandEnabled;
    [ObservableProperty] private bool _isScrollToMaterialCommandEnabled;
    [ObservableProperty] private bool _isGenerateNewCruidCommandEnabled;
    [ObservableProperty] private bool _isAddAppearancesCommandEnabled;

    [ObservableProperty] private bool _isAddDependenciesCommandEnabled;
    [ObservableProperty] private bool _isAddDependenciesCommandEnabledAndShiftKeyDown;

    [ObservableProperty] private bool _isShiftKeyDown;


    private void RefreshMeshMenuItems()
    {
        IsMesh = false;
        IsFileValidationMenuVisible = false;
        IsConvertMaterialMenuEnabled = false;
        IsMaterialMenuEnabled = false;
        IsGenerateMaterialCommandEnabled = false;
        IsDeleteUnusedMaterialCommandEnabled = false;
        IsRegenerateMaterialCommandEnabled = false;
        IsScrollToMaterialCommandEnabled = false;
        IsGenerateNewCruidCommandEnabled = false;

        if (CurrentTab is null)
        {
            return;
        }
        
        IsMesh = CurrentTab?.GetContentType() is RedDocumentItemType.Mesh;
        IsAddAppearancesCommandEnabled = CurrentTab?.GetContentType() is RedDocumentItemType.Mesh;

        var enableDependencyCommand = IsAddAppearancesCommandEnabled || CurrentTab?.GetContentType() is RedDocumentItemType.Mi;

        IsAddDependenciesCommandEnabled = enableDependencyCommand && !IsShiftKeyDown;
        IsAddDependenciesCommandEnabledAndShiftKeyDown = enableDependencyCommand && IsShiftKeyDown;
        
        IsFileValidationMenuVisible = IsMesh || CurrentTab?.GetContentType() is RedDocumentItemType.App or RedDocumentItemType.Ent;
        
        if (RootChunk?.ResolvedData is not CMesh mesh)
        {
            return;
        }

        IsConvertMaterialMenuEnabled = mesh.PreloadExternalMaterials.Count > 0 || mesh.PreloadLocalMaterialInstances.Count > 0;
        IsGenerateMaterialCommandEnabled = mesh.Appearances.Count > 0;
        IsDeleteUnusedMaterialCommandEnabled = mesh.Appearances.Count > 0 || mesh.MaterialEntries.Count > 0;
        IsScrollToMaterialCommandEnabled = SelectedChunk?.ShowScrollToMaterial == true;
    }

    public void SetCurrentTab(RedDocumentTabViewModel value)
    {
        CurrentTab = value;
        RefreshMenuVisibility();
    }


    public void SetEditorLevel(EditorDifficultyLevel level)
    {
        EditorLevel = level;
        RootChunk?.SetEditorLevel(level);
    }
}