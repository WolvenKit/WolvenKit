using System;

namespace WolvenKit.App.Models.ProjectManagement;

public class RecentlyUsedItemModel
{
    public RecentlyUsedItemModel(string name, DateTime dateTime, DateTime modified)
    {
        Name = name;
        DateTime = dateTime;
    }

    public string Name { get; set; }
    public DateTime DateTime { get; set; }
    public DateTime Modified { get; set; }
    public bool IsPinned { get; set; }
}
