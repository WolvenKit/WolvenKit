using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.ViewModels.Dialogs;

public partial class DeleteOrMoveFilesListDialogViewModel : DialogViewModel
{
    [ObservableProperty] private List<string> _files;
    [ObservableProperty] private string _title;
    [ObservableProperty] private bool _hasFiles;
    public int FilesCount => Files.Count;
    
    public string? MoveToPath { get; set; }

    public DeleteOrMoveFilesListDialogViewModel(string title, List<string> files)
    {
        Files = files;
        Title = title;
        HasFiles = Files.Count > 0;
    }
}