using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WolvenKit.App.Models.ProjectManagement;

public partial class RecentlyUsedItemModel : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private DateTime _dateTime;

    [ObservableProperty]
    private DateTime _lastOpened;

    [ObservableProperty]
    private bool _isPinned;

    public RecentlyUsedItemModel(string name, DateTime dateTime, DateTime lastOpened)
    {
        _name = name;
        _dateTime = dateTime;
        _lastOpened = lastOpened;
    }
}
