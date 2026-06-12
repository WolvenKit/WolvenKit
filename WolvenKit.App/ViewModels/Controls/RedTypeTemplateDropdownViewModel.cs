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

        defaultList = new List<RedTypeTemplateDescriptorExt>([
            new RedTypeTemplateDescriptorExt("No Template", typeof(object), "", RedTypeTemplateDescriptorExtSource.Raw)
        ]);

        CurrentRedTypeTemplates = new CollectionViewSource
        {
            Source = defaultList
        };
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);
        CurrentRedTypeTemplates.GroupDescriptions.Add(new PropertyGroupDescription(nameof(RedTypeTemplateDescriptorExt.Source)));
        SelectedRedTypeTemplate = ((List<RedTypeTemplateDescriptorExt>)CurrentRedTypeTemplates.Source).First();

        RequestedType = typeof(object);
        _ = Refresh();
    }

    private List<RedTypeTemplateDescriptorExt> defaultList;

    [ObservableProperty]
    private CollectionViewSource _currentRedTypeTemplates;

    [ObservableProperty]
    private RedTypeTemplateDescriptorExt? _selectedRedTypeTemplate;

    [ObservableProperty]
    private Type _requestedType;

    [ObservableProperty]
    private Dictionary<Type, List<RedTypeTemplateDescriptorExt>> _templatesByType = new();

    partial void OnRequestedTypeChanged(Type value)
    {
        CurrentRedTypeTemplates.Source = TemplatesByType.TryGetValue(value, out var list) ? list : defaultList;

        SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
        CurrentRedTypeTemplates.View.Refresh();
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);
    }

    [RelayCommand]
    private async Task Refresh()
    {
        await Task.Run(_redTypeTemplateService.LoadTemplates);
        IndexRedTypeTemplates();
        CurrentRedTypeTemplates.Source = TemplatesByType.TryGetValue(RequestedType, out var list) ? list : defaultList;
        SelectedRedTypeTemplate = GetInitialTemplateForSelectedFile();
        CurrentRedTypeTemplates?.View.Refresh();
        ApplyTemplateCustomSort(CurrentRedTypeTemplates);
    }

    private void IndexRedTypeTemplates()
    {
        TemplatesByType.Clear();

        IndexTemplates(_redTypeTemplateService.UserTemplates, RedTypeTemplateDescriptorExtSource.User);
        IndexTemplates(_redTypeTemplateService.SystemTemplates, RedTypeTemplateDescriptorExtSource.System);

        foreach (var kvp in TemplatesByType)
        {
            kvp.Value.Add(new RedTypeTemplateDescriptorExt("No Template", kvp.Key, "", RedTypeTemplateDescriptorExtSource.Raw));
        }

        void IndexTemplates(IEnumerable<RedTypeTemplateDescriptor> templates, RedTypeTemplateDescriptorExtSource source)
        {
            foreach (var template in templates)
            {
                if (TemplatesByType.TryGetValue(template.Type, out var list))
                {
                    list.Add(new RedTypeTemplateDescriptorExt(template, source));
                }
                else
                {
                    TemplatesByType.Add(template.Type, [new RedTypeTemplateDescriptorExt(template, source)]);
                }
            }
        }

    }

    private RedTypeTemplateDescriptorExt? GetInitialTemplateForSelectedFile()
    {
        var templates = CurrentRedTypeTemplates.Source as List<RedTypeTemplateDescriptorExt> ?? defaultList;

        if (RequestedType is null)
        {
            return null;
        }

        var userDefault =
            templates.FirstOrDefault(rtt => rtt is { Name: "default", Source: RedTypeTemplateDescriptorExtSource.User });
        if (userDefault is not null)
        {
            return userDefault;
        }

        var systemDefault =
            templates.FirstOrDefault(rtt =>
                rtt is { Name: "default", Source: RedTypeTemplateDescriptorExtSource.System });
        if (systemDefault is not null)
        {
            return systemDefault;
        }

        return templates.FirstOrDefault(rtt => rtt.Source == RedTypeTemplateDescriptorExtSource.Raw);
    }

    private static void ApplyTemplateCustomSort(CollectionViewSource? source)
    {
        if (source?.View is ListCollectionView listView)
        {
            listView.CustomSort = new RedTypeTemplateDescriptorExtComparer("default");
        }
    }
}
