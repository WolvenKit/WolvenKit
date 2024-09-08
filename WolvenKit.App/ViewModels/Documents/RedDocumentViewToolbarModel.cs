using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.ClearScript.JavaScript;
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

        RefreshMenuVisibility(true);
    }

    private void OnModifierChanged() => IsShiftKeyDown = _modifierViewStateService?.IsShiftKeyPressed ?? false;

    private readonly IModifierViewStateService? _modifierViewStateService;

    [ObservableProperty] private RedDocumentTabViewModel? _currentTab;
    [ObservableProperty] private EditorDifficultyLevel _editorLevel;

    public ChunkViewModel? RootChunk { get; set; }
    public ChunkViewModel? SelectedChunk { get; set; }
    public List<ChunkViewModel> SelectedChunks { get; } = new();

    public string? FilePath => CurrentTab?.FilePath;
    public CR2WFile? Cr2WFile => CurrentTab?.Parent.Cr2wFile;

    [ObservableProperty] private bool _showToolbar;

    [ObservableProperty] private RedDocumentItemType _contentType;

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
        if (e.PropertyName is not (nameof(RDTDataViewModel.SelectedChunk) or nameof(RDTDataViewModel.SelectedChunks)
                or nameof(RDTDataViewModel.FilePath)) ||
            sender is not RDTDataViewModel dataViewModel)
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
    }
    
    [ObservableProperty] private bool _isFileValidationMenuVisible;


    [ObservableProperty] private bool _isGenerateMaterialCommandEnabled;
    [ObservableProperty] private bool _isDeleteUnusedMaterialCommandEnabled;
    [ObservableProperty] private bool _isRegenerateMaterialCommandEnabled;
    [ObservableProperty] private bool _isScrollToMaterialCommandEnabled;

    /*
     * Cleanup
     */
    [ObservableProperty] private bool _isConvertMaterialMenuEnabled;
    
    [ObservableProperty] private bool _isGenerateNewCruidCommandEnabled;
    [ObservableProperty] private bool _isMaterialDefinition;

    [ObservableProperty] private bool _isAddDependenciesCommandEnabled;
    [ObservableProperty] private bool _isAddDependenciesCommandEnabledAndShiftKeyDown;
    
    [ObservableProperty] private bool _isShiftKeyDown;


    private void RefreshMeshMenuItems()
    {
        IsFileValidationMenuVisible = false;
        IsConvertMaterialMenuEnabled = false;
        IsGenerateMaterialCommandEnabled = false;
        IsDeleteUnusedMaterialCommandEnabled = false;
        IsRegenerateMaterialCommandEnabled = false;
        IsScrollToMaterialCommandEnabled = false;
        IsGenerateNewCruidCommandEnabled = false;
        IsMaterialDefinition = false;

        if (!ShowToolbar || CurrentTab is null)
        {
            return;
        }

        IsRegenerateMaterialCommandEnabled = SelectedChunk is { Name: "components", Data: CArray<entIComponent> };

        IsGenerateNewCruidCommandEnabled = SelectedChunk?.PropertyType == typeof(CRUID);
        IsMaterialDefinition = SelectedChunk?.IsMaterialDefinition() == true;

        _modifierViewStateService?.RefreshModifierStates();

        var enableDependencyCommand =
            CurrentTab?.GetContentType() is RedDocumentItemType.Mesh or RedDocumentItemType.Mi or RedDocumentItemType.Mlsetup;

        IsAddDependenciesCommandEnabled = enableDependencyCommand && !IsShiftKeyDown;
        IsAddDependenciesCommandEnabledAndShiftKeyDown = enableDependencyCommand && IsShiftKeyDown;

        IsFileValidationMenuVisible = true;
        
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