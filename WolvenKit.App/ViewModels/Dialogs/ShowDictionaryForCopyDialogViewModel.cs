using System;
using System.Collections.Generic;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction.Options;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class ShowDictionaryForCopyDialogViewModel : DialogViewModel
{
    [ObservableProperty] private IDictionary<string, List<string>> _references;
    [ObservableProperty] private string _title;
    [ObservableProperty] private string _text;
    [ObservableProperty] private bool _isExperimental;

    public int ReferencesCount => References.Count;


    public ShowDictionaryForCopyDialogViewModel(ShowDictAsCopyableListDialogOptions options)
    {
        References = options.ValueDictionary;
        Title = options.Title;
        Text = options.Text;
        IsExperimental = options.IsExperimental;
    }
}
