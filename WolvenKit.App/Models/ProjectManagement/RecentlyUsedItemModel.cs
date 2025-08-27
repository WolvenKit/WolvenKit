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

    [ObservableProperty] private string _absolutePath;

    [ObservableProperty] private DateTime _dateTime;

    [ObservableProperty] private DateTime _lastOpened;

    [ObservableProperty] private bool _isPinned;

    [ObservableProperty] private Color _color;

    [JsonConstructor]
    public RecentlyUsedItemModel(string name, DateTime dateTime, DateTime lastOpened, Color color,
        string absolutePath)
    {
        _name = name;
        _dateTime = dateTime;
        _lastOpened = lastOpened;
        _absolutePath = absolutePath;
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
        _absolutePath = project.Location;
    }

    public void SetPropertiesFrom(RecentlyUsedItemModel other)
    {
        Name = other.Name;
        DateTime = other.DateTime;
        LastOpened = other.DateTime;
        Color = other.Color;
        AbsolutePath = other.AbsolutePath;
    }

    public override bool Equals(object? obj) => obj is RecentlyUsedItemModel other && Equals(other);

    public bool Equals(RecentlyUsedItemModel other) =>
        Name == other.Name
        && AbsolutePath == other.AbsolutePath
        && DateTime.Equals(other.DateTime)
        && LastOpened.Equals(other.LastOpened)
        && IsPinned == other.IsPinned
        && Color.Equals(other.Color);

    public override int GetHashCode() =>
        HashCode.Combine(Name, AbsolutePath, DateTime, LastOpened, IsPinned, Color);
}
