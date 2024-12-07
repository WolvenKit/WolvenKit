using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ShowBrokenReferencesDialogViewModel : DialogViewModel
{
    [ObservableProperty] private Dictionary<string, List<string>> _references;
    [ObservableProperty] private string _title;
    public int ReferencesCount => References.Count;
    public double MaxHeight = UIHelper.GetScreenHeight() * 0.9; 

    public ShowBrokenReferencesDialogViewModel(string title, Dictionary<string, List<string>> references)
    {
        References = references;
        Title = title;
    }
}