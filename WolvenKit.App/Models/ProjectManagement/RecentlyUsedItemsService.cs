using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using DynamicData;
using WolvenKit.App.Services;

namespace WolvenKit.App.Models.ProjectManagement;


public class RecentlyUsedItemsService : IRecentlyUsedItemsService
{
    private static string GetConfigurationPath() => Path.Combine(ISettingsManager.GetAppData(), "recentItems.json");
    private readonly SourceCache<RecentlyUsedItemModel, string> _recentlyUsedItems = new(_ => _.Name);

    public IObservableCache<RecentlyUsedItemModel, string> Items => _recentlyUsedItems;
    public List<RecentlyUsedItemModel> PinnedItems => _recentlyUsedItems.Items.Where(_ => _.IsPinned).ToList();

    public RecentlyUsedItemsService()
    {
        // load on start
        if (File.Exists(GetConfigurationPath()))
        {
            var jsonString = File.ReadAllText(GetConfigurationPath());
            var dto = JsonSerializer.Deserialize<Dictionary<string, RecentlyUsedItemModel>>(jsonString);
            if (dto != null)
            {
                _recentlyUsedItems.Edit(innerCache => innerCache.AddOrUpdate(dto.Values));
            }
        }

        Items
            .Connect()
            .WhenAnyPropertyChanged()
            .Subscribe(_ => Save());
    }

    public void AddOrUpdateItem(RecentlyUsedItemModel itemModel)
    {
        _recentlyUsedItems.Edit(innerCache => innerCache.AddOrUpdate(itemModel));
        Save();
    }

    public void RemoveItem(RecentlyUsedItemModel itemModel)
    {
        _recentlyUsedItems.Edit(innerCache => innerCache.Remove(itemModel));
        Save();
    }

    public void PinItem(string key)
    {
        //TODO
    }

    public void UnpinItem(string key)
    {
        //TODO
    }

    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        var dto = Items.Items.ToDictionary(_ => _.Name);
        var json = JsonSerializer.Serialize(dto, options);
        File.WriteAllText(GetConfigurationPath(), json);
    }
}
