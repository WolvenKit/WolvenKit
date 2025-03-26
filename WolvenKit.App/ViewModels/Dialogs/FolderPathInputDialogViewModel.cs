using System;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.ProjectManagement.Project;


namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// Implements the viewmodel that drives the log view.
/// </summary>
public partial class FolderPathInputDialogViewModel : DialogViewModel
{
    public FolderPathInputDialogViewModel(Cp77Project activeProject, string title = "Enter folder path")
    {
        Title = title;
        ActiveProject = activeProject;
    }

    public string Title { get; init; }
    public Cp77Project ActiveProject { get; init; }
    
    [ObservableProperty] private string? _text;

    [ObservableProperty] private bool _isValid = true;

    public void RefreshValiditiy()
    {
        if (Text is null)
        {
            IsValid = false;
            return;
        }
        
        try
        {
            var fullPath = Path.GetFullPath(Path.Combine(ActiveProject.ModDirectory, Text));

            // Check if the resulting path is rooted and starts with the base directory path
            if (!(Path.IsPathRooted(fullPath) && !fullPath.StartsWith(ActiveProject.ModDirectory, StringComparison.OrdinalIgnoreCase)))
            {
                IsValid = true;
                return;
            }
        }
        catch
        {
            // An exception can be thrown if the path is not valid
        }
        IsValid = false;
    }

    
}
