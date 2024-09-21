using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ShowBrokenReferencesDialogViewModel : DialogViewModel
{
    [ObservableProperty] private Dictionary<string, List<string>> _references;
    [ObservableProperty] private string _title;
    public int ReferencesCount => References.Count;

    public ShowBrokenReferencesDialogViewModel(string title, Dictionary<string, List<string>> references)
    {
        References = references;
        Title = title;
    }
}