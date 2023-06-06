using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Models.Docking;

namespace WolvenKit.App.ViewModels.Shell;

public abstract partial class PaneViewModel : ObservableObject, IDockElement
{
    protected PaneViewModel(string header, string contentId)
    {
        _header = header;
        _contentId = contentId;
    }

    [ObservableProperty] private string _header;

    [ObservableProperty] private DockState _state;

    [ObservableProperty] private DockSide _sideInDockedMode;

    [ObservableProperty] private string _contentId;

    //public ImageSource IconSource
    //{
    //    get;
    //    protected set;
    //}

    [ObservableProperty] private bool _isActive;

    [ObservableProperty] private bool _canSerialize;

    /// <summary>
    /// Gets/sets whether this tool window is visible or not.
    /// </summary>
    public bool IsVisible
    {
        get => State != DockState.Hidden;
        set
        {
            State = value ? DockState.Dock : DockState.Hidden;
            OnPropertyChanged();
        }
    }
}
