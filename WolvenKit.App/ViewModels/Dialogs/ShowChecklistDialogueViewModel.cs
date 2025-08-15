﻿using System.Collections.Generic;
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
    public ShowChecklistDialogViewModel(Dictionary<string, bool> checklistOptions, string fileName, string title,
        string text)
    {
        Title = title;
        FileName = fileName;
        Text = text;
        ChecklistOptions = checklistOptions;
        SelectedOptions = checklistOptions.Where(x => x.Value).Select(x => x.Key).ToList();
    }

    [ObservableProperty] private Dictionary<string, bool> _checklistOptions = [];

    [ObservableProperty] private List<string> _selectedOptions = [];

    [ObservableProperty] private string _fileName = "";

    [ObservableProperty] private string _title = "";

    [ObservableProperty] private string _text = "";

    [ObservableProperty] private bool _rememberValues = true;
}