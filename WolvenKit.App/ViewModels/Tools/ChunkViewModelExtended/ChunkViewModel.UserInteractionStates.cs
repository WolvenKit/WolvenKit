using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    /// <summary>
    /// For view decoration, default values will be displayed in italic. They're not actually read-only, though.
    /// Fields are defined in <see cref="EditorDifficultyLevelFieldFactory"/>.
    /// </summary>
    [ObservableProperty] private bool _isDisplayAsReadOnly;


    /// <summary>
    /// For view visibility - if the noob filter is enabled, only show properties that the user wants to edit.
    /// Fields are defined in <see cref="EditorDifficultyLevelFieldFactory"/>.
    /// </summary>
    [ObservableProperty] private bool _isHiddenByEditorDifficultyLevel;

    /// <summary>
    /// For view visibility - if the noob filter is enabled, only show properties that the user wants to edit.
    /// Fields are defined in <see cref="EditorDifficultyLevelFieldFactory"/>.
    /// </summary>
    [ObservableProperty] private bool _isHiddenBySearch;

    private void CalculateUserInteractionStates()
    {
        // Either a root field, or a field that isn't initialized yet
        if (ResolvedData is RedDummy || Parent?.ResolvedData.GetType() is not Type type)
        {
            return;
        }

        IsDisplayAsReadOnly = DifficultyLevelFieldInformation.IsDisplayAsReadonly(Name, type, this);
        IsReadOnly = DifficultyLevelFieldInformation.IsReadonly(Name, type, this);
        IsHiddenByEditorDifficultyLevel = DifficultyLevelFieldInformation.IsHidden(Name, type, this);
    }

    public void SetEditorLevel(EditorDifficultyLevel level)
    {
        _currentEditorDifficultyLevel = level;
        DifficultyLevelFieldInformation = EditorDifficultyLevelFieldFactory.GetInstance(level);
        RecalculateProperties();
    }

    private bool _isPropertiesInitialized;

    /// <summary>
    /// If we need a node to be fully initialized (e.g. if we run a search on it) 
    /// </summary>
    public void CalculatePropertiesRecursive()
    {
        if (_isPropertiesInitialized)
        {
            return;
        }

        _isPropertiesInitialized = true;
        CalculateProperties();
        foreach (var child in Properties)
        {
            child.CalculatePropertiesRecursive();
        }
    }


    private EditorDifficultyLevelInformation DifficultyLevelFieldInformation { get; set; }

    public void SetVisibilityStatusBySearchString(string searchBoxText)
    {
        if (ResolvedData is RedDummy || TVProperties.Count == 0)
        {
            CalculateProperties();
        }

        // some items are still RedDummies even after properties were calculated. Why?
        if (ResolvedData is RedDummy || TVProperties.Count == 0)
        {
            IsHiddenBySearch = true;
            return;
        }
        
        foreach (var chunkViewModel in TVProperties)
        {
            chunkViewModel.SetVisibilityStatusBySearchString(searchBoxText);
        }

        if (IsHiddenByEditorDifficultyLevel || Parent is null)
        {
            IsHiddenBySearch = false;
            return;
        }

        if (TVProperties.Any(c => c is { IsHiddenBySearch: false }))
        {
            IsHiddenBySearch = false;
            IsExpanded = !string.IsNullOrEmpty(searchBoxText);
            return;
        }

        if (string.IsNullOrEmpty(searchBoxText))
        {
            IsHiddenBySearch = false;
            IsExpanded = Parent is not null;
            return;
        }

        IsHiddenBySearch = !(Value?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true
                             || Descriptor?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true
                             || StringHelper.StringifyRedType(ResolvedData).Contains(searchBoxText, StringComparison.OrdinalIgnoreCase));

        if (IsHiddenBySearch)
        {
            IsExpanded = false;
        }

    }
}