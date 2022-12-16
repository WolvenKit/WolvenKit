using System;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.Red3.UI.Services;

public interface IWorkspaceService
{
    event EventHandler<WorkspaceChangedEventArgs> WorkspaceChanged;

    void SetWorkspace(DirectoryInfo directoryInfo);
}

[ObservableObject]
public partial class WorkspaceService : IWorkspaceService
{

    [ObservableProperty]
    private DirectoryInfo workspace;

    public event EventHandler<WorkspaceChangedEventArgs> WorkspaceChanged;

    public void SetWorkspace(DirectoryInfo directoryInfo)
    {
        Workspace = directoryInfo;

        // fire event
        var args = new WorkspaceChangedEventArgs
        {
            Workspace = Workspace
        };
        OnWorkspaceChanged(args);
    }

    protected virtual void OnWorkspaceChanged(WorkspaceChangedEventArgs e) => WorkspaceChanged?.Invoke(this, e);
}

public class WorkspaceChangedEventArgs : EventArgs
{
    public DirectoryInfo Workspace { get; set; }
}