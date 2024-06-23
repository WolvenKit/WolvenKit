using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.RED4.Types;

// ReSharper disable once CheckNamespace
namespace WolvenKit.App.ViewModels.Shell;

public partial class ChunkViewModel
{
    // For view decoration, default values will be displayed in italic
    [ObservableProperty] private bool _isDisplayAsReadOnly;


    // For view visibility - if the noob filter is enabled, only show properties that the user wants to edit
    [ObservableProperty] private bool _isHiddenByEditorDifficultyLevel;

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
        Tab?.Parent.Reload(false);
    }

    private EditorDifficultyLevelInformation DifficultyLevelFieldInformation { get; set; }
}