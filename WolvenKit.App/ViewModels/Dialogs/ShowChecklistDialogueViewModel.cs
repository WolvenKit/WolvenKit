using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Interfaces.Extensions;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ShowChecklistDialogViewModel : ObservableObject
{
    public ShowChecklistDialogViewModel(ChecklistDialogOptions options)
    {
        Title = options.Title;
        InputFieldText = options.InputFieldDefaultValue;
        InputFieldHeader = options.InputFieldLabel;
        Text = options.Text;
        ChecklistOptions = options.ChecklistOptions;
        SelectedOptions = options.ChecklistOptions.Where(x => x.Value).Select(x => x.Key).ToList();
        ShowInputField = options.ShowInputField;
        FilterText = options.FilterDefaultValue;
    }

    [ObservableProperty] private Dictionary<string, bool> _checklistOptions = [];

    [ObservableProperty] private List<string> _selectedOptions = [];

    [ObservableProperty] private string _inputFieldText = "";
    [ObservableProperty] private string _inputFieldHeader = "";

    [ObservableProperty] private string _title = "";

    [ObservableProperty] private string _text = "";
    [ObservableProperty] private string _filterText = "";

    [ObservableProperty] private bool _rememberValues = true;
    [ObservableProperty] private bool _showInputField = false;
}
