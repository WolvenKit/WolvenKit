using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DynamicData;
using DynamicData.Binding;
using Microsoft.Win32;
using WolvenKit.App.Extensions;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Models.ProjectManagement;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Shell;

namespace WolvenKit.App.ViewModels.HomePage.Pages;

public partial class WelcomePageViewModel : PageViewModel
{
    #region Fields

    private readonly IRecentlyUsedItemsService _recentlyUsedItemsService;
    private readonly AppViewModel _mainViewModel;
    private readonly ISettingsManager _settingsManager;


    private readonly ReadOnlyObservableCollection<RecentlyUsedItemModel> _recentlyUsedItems;

    // Default group name for projects that have no group.
    public const string UngroupedName = "Ungrouped";

    // Names of collapsed groups (kept in memory for the current session).
    private readonly HashSet<string> _collapsedGroups = new();

    private Dictionary<string, int> _sortMode = new()
    {
        {"Last opened", 0},
        {"Last opened (Desc)", 1},
        {"Created", 2},
        {"Created (Desc)", 3},
        {"Name", 4},
        {"Name (Desc)", 5},
    };

    #endregion Fields

    #region Constructors

    public WelcomePageViewModel(IRecentlyUsedItemsService recentlyUsedItemsService, AppViewModel mainViewModel, ISettingsManager settingsManager)
    {
        _recentlyUsedItemsService = recentlyUsedItemsService;
        _mainViewModel = mainViewModel;
        _settingsManager = settingsManager;

        _selectedPinnedOrder = _settingsManager.PinnedOrder;
        _selectedRecentOrder = _settingsManager.RecentOrder;

        recentlyUsedItemsService.Items
            .Connect()
            //.ObserveOn(RxApp.MainThreadScheduler)
            .Bind(out _recentlyUsedItems)
            .Subscribe(OnRecentlyUsedItemsChanged);
    }

    private void OnRecentlyUsedItemsChanged(IChangeSet<RecentlyUsedItemModel, string> obj)
    {
        ConvertRecentProjects();

        var changeSet = _recentlyUsedItems
            .ToObservableChangeSet();

        changeSet
            .WhenAnyPropertyChanged()
            .Subscribe(_ => ConvertRecentProjects());
    }

    #endregion Constructors

    #region Properties

    public string DiscordLink = "https://discord.gg/Epkq79kd96";
    public string OpenCollectiveLink = "https://opencollective.com/redmodding";
    public string PatreonLink = "https://www.patreon.com/m/RedModdingTools";
    public string TwitterLink = "https://twitter.com/ModdingRed";
    public string YoutubeLink = "https://www.youtube.com/channel/UCl3JpsP49JgYLMYAYQvoaLg";

    [ObservableProperty]
    private ObservableCollection<FancyProjectObject> _fancyPinnedProjects = new();

    [ObservableProperty]
    private ObservableCollection<FancyProjectObject> _fancyProjects = new();

    // Recent projects grouped by "Group", for display as sections.
    [ObservableProperty]
    private ObservableCollection<ProjectGroup> _groupedProjects = new();

    // Names of existing groups (for the "Move to existing group" submenu).
    [ObservableProperty]
    private ObservableCollection<string> _availableGroups = new();

    [ObservableProperty]
    private List<RecentlyUsedItemModel> _pinnedItems = new();

    [ObservableProperty]
    private bool _showPinned;

    [ObservableProperty]
    private int _selectedPinnedOrder;

    [ObservableProperty]
    private string _pinnedFilter = "";

    [ObservableProperty]
    private int _selectedRecentOrder;

    [ObservableProperty]
    private string _recentFilter = "";

    public Dictionary<string, int> SortMode => _sortMode;

    #endregion Properties

    #region commands

    [RelayCommand]
    private void OpenProject(string s)
    {
        _mainViewModel.OpenProjectCommand.Execute(s);

        // clear filters
        RecentFilter = string.Empty;
        PinnedFilter = string.Empty;
    }

    [RelayCommand]
    private void DeleteProject(string s)
    {
        _mainViewModel.DeleteProjectFromRecentCommand.Execute(s);
    }

    [RelayCommand]
    private void NewProject()
    {
        _mainViewModel.NewProjectCommand.SafeExecute();
    }

    [RelayCommand]
    private void OpenLink(string link)
    {
        var ps = new ProcessStartInfo(link)
        {
            UseShellExecute = true,
            Verb = "open"
        };
        Process.Start(ps);
    }

    [RelayCommand]
    private async Task OpenInExplorer(string parameter)
    {
        if (string.IsNullOrEmpty(parameter))
        {
            return;
        }

        if (!File.Exists(parameter))
        {
            parameter = await LocateMissingProjectAsync(parameter);
        }

        Commonfunctions.ShowFileInExplorer(parameter);
    }

    [RelayCommand]
    private void PinItem(string parameter) => _recentlyUsedItemsService.PinItem(parameter);

    [RelayCommand]
    private void CloseHomePage() => _mainViewModel.CloseModalCommand.Execute(null);

    [RelayCommand]
    private void UnpinItem(string parameter)
    {
        //Argument.IsNotNullOrWhitespace(() => parameter);
        //_recentlyUsedItemsService.UnpinItem(parameter);
    }

    // Assign (or change) a project's group via an input box.
    [RelayCommand]
    private async Task SetProjectGroup(FancyProjectObject? project)
    {
        if (project is null)
        {
            return;
        }

        var name = await Interactions.ShowInputBoxAsync("Move project to group", project.Group ?? "");

        // The user typed a name -> assign it. Empty -> remove from the group.
        // (Note: this API does not clearly distinguish "Cancel" from an emptied field;
        //  to keep the group on cancel, replace the next line with:
        //  if (string.IsNullOrWhiteSpace(name)) return;)
        project.Group = string.IsNullOrWhiteSpace(name) ? null : name.Trim();

        RefreshRecentProjects();
    }

    // Remove a project from its group (it goes back under "Ungrouped").
    [RelayCommand]
    private void RemoveProjectGroup(FancyProjectObject? project)
    {
        if (project is null)
        {
            return;
        }

        project.Group = null;
        RefreshRecentProjects();
    }

    // Assign a project to an existing group (called from the code-behind submenu).
    public void MoveProjectToGroup(FancyProjectObject? project, string group)
    {
        if (project is null)
        {
            return;
        }

        project.Group = string.IsNullOrWhiteSpace(group) ? null : group.Trim();
        RefreshRecentProjects();
    }
    // Delete a group (after confirmation). Projects are NOT deleted: they simply
    // go back under "Ungrouped".
    [RelayCommand]
    private async Task DeleteGroup(ProjectGroup? group)
    {
        if (group is null || group.Name == UngroupedName)
        {
            return;
        }

        var result = await Interactions.ShowMessageBoxAsync(
            $"Delete the group \"{group.Name}\"? Its {group.Projects.Count} project(s) will move back to \"{UngroupedName}\". No project is deleted from disk.",
            "Delete group",
            WMessageBoxButtons.YesNo);

        if (result != WMessageBoxResult.Yes)
        {
            return;
        }

        foreach (var project in group.Projects.ToList())
        {
            project.Group = null;
        }

        RefreshRecentProjects();
    }

    #endregion


    private async Task<string> LocateMissingProjectAsync(string parameter)
    {
        var result = await Interactions.ShowMessageBoxAsync("The file doesn't seem to exist. Would you like to locate it?", "Project not found");
        var delete = false;
        switch (result)
        {
            case WMessageBoxResult.OK:
            case WMessageBoxResult.Yes:
                delete = true;
                break;
            case WMessageBoxResult.None:
            case WMessageBoxResult.Cancel:
            case WMessageBoxResult.No:
            case WMessageBoxResult.Custom:
            default:
                break;
        }
        if (!delete)
        {
            var items = _recentlyUsedItemsService.Items.Items
                .Where(_ => _.Name == parameter)
                .ToList();
            if (items.Count > 0)
            {
                var f = items.FirstOrDefault();
                if (f is not null)
                {
                    _recentlyUsedItemsService.RemoveItem(f);
                }
            }
            return "";
        }
        else
        {
            var dlg = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Locate the WolvenKit project",
                Filter = "Cyberpunk 2077 Project|*.cpmodproj"
            };

            if (dlg.ShowDialog() != true)
            {
                return "";
            }

            var file = dlg.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return "";
            }

            parameter = file;

            var items = _recentlyUsedItemsService.Items.Items
                .Where(_ => Path.GetFileName(_.Name) == Path.GetFileName(parameter))
                .ToList();
            if (items.Count > 0)
            {
                var item = items.First();
                _recentlyUsedItemsService.AddItem(new RecentlyUsedItemModel(parameter, item.DateTime, item.LastOpened));
                _recentlyUsedItemsService.RemoveItem(item);
                return parameter;
            }
        }

        return "";
    }

    private void ConvertRecentProjects() // Converts Recent projects for the homepage.
    {
        RefreshPinnedProjects();
        RefreshRecentProjects();
    }

    private void RefreshPinnedProjects() =>
        DispatcherHelper.RunOnMainThread(() =>
        {
            _settingsManager.PinnedOrder = SelectedPinnedOrder;

            FancyPinnedProjects.Clear();
            FancyPinnedProjects.AddRange(GetSortedItems(true, SelectedPinnedOrder, PinnedFilter));

            ShowPinned = _recentlyUsedItems.Count(x => x.IsPinned) > 0;
        });

    private void RefreshRecentProjects() =>
        DispatcherHelper.RunOnMainThread(() =>
        {
            _settingsManager.RecentOrder = SelectedRecentOrder;

            var items = GetSortedItems(false, SelectedRecentOrder, RecentFilter);

            FancyProjects.Clear();
            FancyProjects.AddRange(items);

            // Group by "Group". Projects without a group go into "Ungrouped",
            // placed last; the other groups are sorted by name.
            var groups = items
                .GroupBy(p => string.IsNullOrWhiteSpace(p.Group) ? UngroupedName : p.Group!)
                .OrderBy(g => g.Key == UngroupedName ? 1 : 0)
                .ThenBy(g => g.Key, StringComparer.InvariantCultureIgnoreCase)
                .Select(g =>
                {
                    // Restore the collapsed/expanded state remembered for this session.
                    var group = new ProjectGroup(g.Key, g)
                    {
                        IsExpanded = !_collapsedGroups.Contains(g.Key)
                    };

                    // Remember collapse/expand changes (without persisting to disk).
                    group.PropertyChanged += (_, e) =>
                    {
                        if (e.PropertyName != nameof(ProjectGroup.IsExpanded))
                        {
                            return;
                        }

                        if (group.IsExpanded)
                        {
                            _collapsedGroups.Remove(group.Name);
                        }
                        else
                        {
                            _collapsedGroups.Add(group.Name);
                        }
                    };

                    return group;
                })
                .ToList();

            GroupedProjects.Clear();
            foreach (var g in groups)
            {
                GroupedProjects.Add(g);
            }

            // Build the list of existing groups (excluding "Ungrouped"), for the submenu.
            var names = items
                .Select(p => p.Group)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Select(n => n!.Trim())
                .Distinct(StringComparer.InvariantCultureIgnoreCase)
                .OrderBy(n => n, StringComparer.InvariantCultureIgnoreCase)
                .ToList();

            AvailableGroups.Clear();
            foreach (var n in names)
            {
                AvailableGroups.Add(n);
            }
        });

    private List<FancyProjectObject> GetSortedItems(bool isPinned, int order, string filter)
    {
        var result = new List<FancyProjectObject>();

        var pinnedItems = _recentlyUsedItems.Where(x => x.IsPinned == isPinned);

        if (!string.IsNullOrEmpty(filter))
        {
            pinnedItems = pinnedItems.Where(x => x.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase));
        }

        pinnedItems = order switch
        {
            0 => pinnedItems.OrderBy(x => x.LastOpened),
            1 => pinnedItems.OrderByDescending(x => x.LastOpened),
            2 => pinnedItems.OrderBy(x => x.DateTime),
            3 => pinnedItems.OrderByDescending(x => x.DateTime),
            4 => pinnedItems.OrderBy(x => x.Name),
            5 => pinnedItems.OrderByDescending(x => x.Name),
            _ => pinnedItems
        };

        foreach (var item in pinnedItems)
        {
            var fi = new FileInfo(item.Name);

            var cd = item.LastOpened != default ? item.LastOpened : item.DateTime;
            var path = item.Name;

            var newfo = fi.Name.Split('.');
            var image = fi.Directory + "\\" + newfo[0] + "\\" + "img.png";

            if (Path.GetExtension(item.Name).TrimStart('.') == EProjectType.cpmodproj.ToString())
            {
                if (!File.Exists(image))
                {
                    image = "pack://application:,,,/Resources/Media/Images/Application/V Male Logo Cropped.png";
                }

                var newItem = new FancyProjectObject(item, fi.Name, cd, "Cyberpunk 2077", path, image);

                result.Add(newItem);
            }
        }

        return result;
    }

    partial void OnSelectedPinnedOrderChanged(int value) => RefreshPinnedProjects();
    partial void OnSelectedRecentOrderChanged(int value) => RefreshRecentProjects();
    partial void OnPinnedFilterChanged(string value) => RefreshPinnedProjects();
    partial void OnRecentFilterChanged(string value) => RefreshRecentProjects();
}
