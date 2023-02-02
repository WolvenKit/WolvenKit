using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using WolvenKit.Red3.UI.Services;

namespace WolvenKit.Red3.UI.ViewModels;

internal partial class ProjectExplorerViewModel : ObservableObject
{
    private readonly IDialogService _dialogService;
    private readonly IWorkspaceService _workspaceService;
    private readonly ILogger<ProjectExplorerViewModel> _logger;

    public ProjectExplorerViewModel(
        IDialogService dialogService,
        IWorkspaceService workspaceService,
        ILogger<ProjectExplorerViewModel> logger)
    {
        _dialogService = dialogService;
        _workspaceService = workspaceService;
        _logger = logger;

        _workspaceService.WorkspaceChanged += _workspaceService_WorkspaceChanged;
    }

    private void _workspaceService_WorkspaceChanged(object sender, WorkspaceChangedEventArgs e)
    {
        _logger.LogDebug("Workspace changed: {workspace}", e.Workspace.FullName);

        // load files into working tree
        DataSource = GetData(e.Workspace);
    }

    [ObservableProperty]
    private ObservableCollection<ExplorerItem> dataSource;

    private ObservableCollection<ExplorerItem> GetData(DirectoryInfo workspace)
    {
        var list = new ObservableCollection<ExplorerItem>();

        // add one root folder
        var root = new ExplorerItem(workspace.FullName, ExplorerItem.ExplorerItemType.Folder);
        AddChildrenRecursive(root);

        list.Add(root);
        return list;
    }

    private void AddChildrenRecursive(ExplorerItem infolder)
    {
        if (infolder.Type == ExplorerItem.ExplorerItemType.File)
        {
            return;
        }

        // add top level files
        var dir = new DirectoryInfo(infolder.FullName);
        foreach (var file in dir.GetFiles())
        {
            infolder.Children.Add(new(file.FullName, ExplorerItem.ExplorerItemType.File));

        }

        // add toplevel folders
        foreach (var folder in dir.GetDirectories())
        {
            infolder.Children.Add(new(folder.FullName, ExplorerItem.ExplorerItemType.Folder));
        }

        // drill down
        foreach (var childFolder in infolder.Children)
        {
            AddChildrenRecursive(childFolder);
        }
    }

    internal async Task OpenFileAsync(string fullPath)
    {
        var mainVm = App.Current.Services.GetService<MainViewModel>();
        await mainVm.OpenFileAsync(fullPath);
    }
}

public partial class ExplorerItem : ObservableObject
{
    public enum ExplorerItemType { Folder, File };

    public ExplorerItem(string fullname, ExplorerItemType type)
    {
        FullName = fullname;
        Type = type;

        Children = new();
    }



    public string FullName { get; init; }

    public string Name
    {
        get
        {
            return Type switch
            {
                ExplorerItemType.Folder => Path.GetFileName(FullName),
                ExplorerItemType.File => Path.GetFileName(FullName),
                _ => throw new ArgumentException(),
            };
        }
    }
    public ExplorerItemType Type { get; init; }

    [ObservableProperty]
    private ObservableCollection<ExplorerItem> children;

    [ObservableProperty]
    private bool isExpanded;
}

internal class ExplorerItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate FolderTemplate { get; set; }
    public DataTemplate FileTemplate { get; set; }

    protected override DataTemplate SelectTemplateCore(object item)
    {
        var explorerItem = (ExplorerItem)item;
        return explorerItem.Type == ExplorerItem.ExplorerItemType.Folder ? FolderTemplate : FileTemplate;
    }
}