using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.ViewModels.Documents;
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
    /// Cap it off arbitrarily at recursion level 8 (because why not)
    /// </summary>
    public void CalculatePropertiesRecursive(int recursionLevel = 0, int countLimit = 20)
    {
        if (_isPropertiesInitialized || recursionLevel > 8)
        {
            return;
        }

        _isPropertiesInitialized = true;
        CalculateProperties();
        if (TVProperties.Count > countLimit)
        {
            return;
        }

        foreach (var child in TVProperties)
        {
            child.CalculatePropertiesRecursive(recursionLevel + 1, countLimit);
        }
    }

    /// <summary>
    /// Check for quest and scenes types
    /// Added additional search by propertyTypeName to work inside the graph
    /// </summary>
    private bool QuestAndScenesSearchHandler(string searchBoxText)
    {
        var result = false;
        // Checking for a resolved property type for scenes and quests graphs
        if (ResolvedPropertyType is not null)
        {
            result = ResolvedPropertyType.Name.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase);
        }

        return result;
    }


    private EditorDifficultyLevelInformation DifficultyLevelFieldInformation { get; set; }

    public void SetVisibilityStatusBySearchString(string searchBoxText)
    {
        if (ResolvedData is RedDummy)
        {
            CalculateProperties();
        }

        // some items are still RedDummies even after properties were calculated. Why?
        if (!string.IsNullOrEmpty(searchBoxText) && ResolvedData is RedDummy)
        {
            IsHiddenBySearch = true;
            return;
        }
        
        foreach (var chunkViewModel in TVProperties)
        {
            chunkViewModel.SetVisibilityStatusBySearchString(searchBoxText);
        }

        if (string.IsNullOrEmpty(searchBoxText) || Parent is null)
        {
            IsHiddenBySearch = false;
            return;
        }

        var visibleChildren = TVProperties.Where(c => !c.IsHiddenBySearch).ToList();

        if (visibleChildren.Count != 0)
        {
            IsHiddenBySearch = false;
            IsExpanded = true;
            return;
        }
        

        var shouldShow = Value?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true
                         || Descriptor?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true
                         || StringHelper.StringifyRedType(ResolvedData).Contains(searchBoxText, StringComparison.OrdinalIgnoreCase);

        // if it's a ref, search in full depot path
        shouldShow = shouldShow || (ResolvedData is IRedRef data &&
                                    data.DepotPath.GetResolvedText()?.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase) == true);

        shouldShow = shouldShow || PropertyType.Name.Contains(searchBoxText, StringComparison.OrdinalIgnoreCase);

        shouldShow = shouldShow || QuestAndScenesSearchHandler(searchBoxText);

        // Hiding cnames that are part of the parent property's description
        if (shouldShow && ResolvedData is CName cname && cname.GetResolvedText() is string s &&
            (Parent.Descriptor?.Contains(s) == true || Parent.Value?.Contains(s) == true))
        {
            shouldShow = false;
        }
        
        IsHiddenBySearch = !shouldShow;

        if (IsHiddenBySearch)
        {
            IsExpanded = false;
        }
        else if (shouldShow && visibleChildren.Count < TVProperties.Count)
        {
            // For nodes that are visible because they directly match the search, unhide all their children
            UnhideRecursively();
        }
 
        
    }

    private void UnhideRecursively()
    {
        IsHiddenBySearch = false;
        foreach (var child in TVProperties.Where(cvm => cvm.IsHiddenBySearch))
        {
            child.UnhideRecursively();
        }
    }
}