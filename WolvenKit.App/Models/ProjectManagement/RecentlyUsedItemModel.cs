using System;
using System.Text.Json.Serialization;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.ProjectManagement.Project;

namespace WolvenKit.App.Models.ProjectManagement;

public partial class RecentlyUsedItemModel : ObservableObject
{
    [ObservableProperty] private string _name;

    [ObservableProperty] private DateTime _dateTime;

    [ObservableProperty] private DateTime _lastOpened;

    [ObservableProperty] private bool _isPinned;

    [ObservableProperty] private Color _color;

    [JsonConstructor]
    public RecentlyUsedItemModel(string name, DateTime dateTime, DateTime lastOpened, Color color)
    {
        _name = name;
        _dateTime = dateTime;
        _lastOpened = lastOpened;
        if (color.ToString().EndsWith("000000"))
        {
            color = ColorHelper.GetRandomColor();
        }

        _color = color;
    }

    public RecentlyUsedItemModel(Cp77Project project)
    {
        _name = project.Name;
        _dateTime = DateTime.Now;
        _lastOpened = DateTime.Now;
        _color = project.ProjectColor;
    }

    public void SetPropertiesFrom(RecentlyUsedItemModel other)
    {
        this.Name = other.Name;
        this.DateTime = other.DateTime;
        this.LastOpened = other.DateTime;
        this.Color = other.Color;
    }
}
