using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class DeleteFilesListDialogViewModel : DialogViewModel
{
    [ObservableProperty] private List<string> _files;
    [ObservableProperty] private string _title;
    public int FilesCount => Files.Count;

    public DeleteFilesListDialogViewModel(string title, List<string> files)
    {
        Files = files;
        Title = title;
    }
}