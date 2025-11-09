using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.App.Services;
using WolvenKit.Core;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Asks user for a component name and a chunk mask
/// </summary>
public partial class CopyMeshAppearancesDialogViewModel : ObservableObject
{
    [ObservableProperty] private string? _selectedOption = "";
    [ObservableProperty] private string _wikiLink = WikiLinks.MeshMaterials;
    [ObservableProperty] private bool _isAppend = false;
    [ObservableProperty] private bool _useArchiveXlPatchMesh = false;
    [ObservableProperty] private List<string> _meshOptions = [];


    // enable save button?
    [ObservableProperty] private bool _canSave;


    private readonly Cp77Project _activeProject;
    private readonly ISettingsManager _settingsManager;

    public CopyMeshAppearancesDialogViewModel(Cp77Project activeProject, ISettingsManager settingsManager)
    {
        _activeProject = activeProject;
        _settingsManager = settingsManager;

        MeshOptions = [.. activeProject.ModFiles.Where(f => f.HasFileExtension(".mesh"))];
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        SetSaveButtonState();
    }

    private void SetSaveButtonState()
    {
        if (string.IsNullOrEmpty(SelectedOption))
        {
            CanSave = false;
            return;
        }

        // If the mesh value is okay, we can save here
        CanSave = !string.IsNullOrEmpty(SelectedOption) && SelectedOption.EndsWith(".mesh");
    }
}
