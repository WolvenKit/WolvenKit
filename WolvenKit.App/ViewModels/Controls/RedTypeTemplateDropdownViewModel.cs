using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Comparers;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;

namespace WolvenKit.App.ViewModels.Controls;

public partial class RedTypeTemplateDropdownViewModel : ObservableObject
{
    private readonly RedTypeTemplateService _redTypeTemplateService;

    public RedTypeTemplateDropdownViewModel(RedTypeTemplateService redTypeTemplateService)
    {
        _redTypeTemplateService = redTypeTemplateService;

        _defaultList = new List<RedTypeTemplateSelectionOption>([
            new RedTypeTemplateSelectionOption("No Template", typeof(object), "", RedTypeTemplateSelectionOptionSource.Raw)
        ]);

        CurrentRedTypeTemplates = new CollectionViewSource
        {
            Source = _defaultList
        };
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);
        CurrentRedTypeTemplates.GroupDescriptions.Add(new PropertyGroupDescription(nameof(RedTypeTemplateSelectionOption.Source)));
        SelectedRedTypeTemplate = ((List<RedTypeTemplateSelectionOption>)CurrentRedTypeTemplates.Source).First();

        RequestedType = typeof(object);
        _ = Refresh();
    }

    public event EventHandler? PostRefresh;

    private readonly List<RedTypeTemplateSelectionOption> _defaultList;

    [ObservableProperty]
    private CollectionViewSource _currentRedTypeTemplates;

    [ObservableProperty]
    private RedTypeTemplateSelectionOption _selectedRedTypeTemplate;

    [ObservableProperty]
    private Type _requestedType;

    [ObservableProperty]
    private Dictionary<Type, List<RedTypeTemplateSelectionOption>> _templatesByType = new();

    partial void OnRequestedTypeChanged(Type value)
    {
        CurrentRedTypeTemplates.Source = TemplatesByType.TryGetValue(value, out var list) ? list : _defaultList;

        SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
        CurrentRedTypeTemplates.View.Refresh();
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);
    }

    [RelayCommand]
    private async Task Refresh()
    {
        await Task.Run(_redTypeTemplateService.LoadTemplates);
        IndexRedTypeTemplates();
        CurrentRedTypeTemplates.Source = TemplatesByType.TryGetValue(RequestedType, out var list) ? list : _defaultList;
        SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
        CurrentRedTypeTemplates?.View.Refresh();
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);

        PostRefresh?.Invoke(this, EventArgs.Empty);
    }

    private void IndexRedTypeTemplates()
    {
        TemplatesByType.Clear();

        IndexTemplates(_redTypeTemplateService.UserTemplates, RedTypeTemplateSelectionOptionSource.User);
        IndexTemplates(_redTypeTemplateService.SystemTemplates, RedTypeTemplateSelectionOptionSource.System);

        foreach (var kvp in TemplatesByType)
        {
            kvp.Value.Add(new RedTypeTemplateSelectionOption("No Template", kvp.Key, "", RedTypeTemplateSelectionOptionSource.Raw));
        }

        void IndexTemplates(IEnumerable<RedTypeTemplateDescriptor> templates, RedTypeTemplateSelectionOptionSource source)
        {
            foreach (var template in templates)
            {
                if (TemplatesByType.TryGetValue(template.Type, out var list))
                {
                    list.Add(new RedTypeTemplateSelectionOption(template, source));
                }
                else
                {
                    TemplatesByType.Add(template.Type, [new RedTypeTemplateSelectionOption(template, source)]);
                }
            }
        }

    }

    private RedTypeTemplateSelectionOption GetInitialTemplateForSelectedFile()
    {
        var templates = CurrentRedTypeTemplates.Source as List<RedTypeTemplateSelectionOption> ?? _defaultList;

        var userDefault =
            templates.FirstOrDefault(rtt => rtt is { Name: "default", Source: RedTypeTemplateSelectionOptionSource.User });
        if (userDefault is not null)
        {
            return userDefault;
        }

        var systemDefault =
            templates.FirstOrDefault(rtt =>
                rtt is { Name: "default", Source: RedTypeTemplateSelectionOptionSource.System });
        if (systemDefault is not null)
        {
            return systemDefault;
        }

        return templates.First(rtt => rtt.Source == RedTypeTemplateSelectionOptionSource.Raw);
    }

    private static void ApplyTemplateCustomSort(CollectionViewSource? source)
    {
        if (source?.View is ListCollectionView listView)
        {
            listView.CustomSort = new RedTypeTemplateSelectionOptionComparer("default");
        }
    }
}
