using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;
using Point = System.Windows.Point;

namespace WolvenKit.App.ViewModels.GraphEditor;

public abstract partial class NodeViewModel : ObservableObject, IDisposable
{
    public abstract uint UniqueId { get; }

    [ObservableProperty]
    private Point _location;

    public Size Size { get; set; }

    public string Title { get; protected set; } = null!;
    public Dictionary<string, string> Details { get; } = new();
    public Visibility Visible { get; set; } = Visibility.Visible;

    public ObservableCollection<InputConnectorViewModel> Input { get; } = new();
    public ObservableCollection<OutputConnectorViewModel> Output { get; } = new();

    public RedBaseClass Data { get; }

    protected NodeViewModel(RedBaseClass data)
    {
        Data = data;
    }

    protected virtual void DataOnPropertyChanging(object? sender, PropertyChangingEventArgs e)
    {

    }

    protected virtual void DataOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {

    }

    internal abstract void GenerateSockets();

    public void ToggleDetails()
    {
        if (Visible == Visibility.Visible)
        {
            Visible = Visibility.Collapsed;
        }
        else
        {
            Visible = Visibility.Visible;
        }

        OnPropertyChanged(nameof(Visible));
    }


    #region IDisposable

    private bool _disposedValue;

    ~NodeViewModel() => Dispose(false);

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
            }

            _disposedValue = true;
        }
    }

    #endregion IDisposable
}