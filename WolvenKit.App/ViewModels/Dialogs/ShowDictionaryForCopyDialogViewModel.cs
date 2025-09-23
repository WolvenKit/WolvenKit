using System;
using System.Collections.Generic;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ShowDictionaryForCopyDialogViewModel : DialogViewModel
{
    [ObservableProperty] private IDictionary<string, List<string>> _references;
    [ObservableProperty] private string _title;
    [ObservableProperty] private string _text;
    [ObservableProperty] private bool _isExperimental;

    public int ReferencesCount => References.Count;


    public ShowDictionaryForCopyDialogViewModel(string title, string text, IDictionary<string, List<string>> references,
        bool isExperimental)
    {
        References = references;
        Title = title;
        Text = text;
        IsExperimental = isExperimental;
    }
}
