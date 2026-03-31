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
    [ObservableProperty] private string _wikiLink = WikiLinks.MeshMaterials;
    [ObservableProperty] private bool _isAppend = false;
    [ObservableProperty] private bool _useArchiveXlPatchMesh = false;

    private List<string>? _options;
    [ObservableProperty] private Dictionary<string, bool>? _optionsDict;

    public List<string> SelectedOptions { get; set; } = [];

    public string? SelectedOption { get; set; }

    // enable save button?
    [ObservableProperty] private bool _canSave;


    public CopyMeshAppearancesDialogViewModel(List<string> options, List<string> previousSelection)
    {
        _options = options;
        OptionsDict = options.ToDictionary(k => k, previousSelection.Contains);
        SelectedOption = previousSelection.FirstOrDefault() ?? "";
    }



    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        if (e.PropertyName != nameof(CanSave))
        {
            SetSaveButtonState();
        }
    }

    public void SetSaveButtonState()
    {
        if (SelectedOptions.Count == 0)
        {
            CanSave = false;
            return;
        }

        // If the mesh value is okay, we can save here
        CanSave = SelectedOptions.Any((sel) => !string.IsNullOrEmpty(sel) && sel.EndsWith(".mesh"));
    }
}
