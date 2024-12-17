using System.ComponentModel;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Shell;
using System;
using WolvenKit.RED4.TweakDB;

namespace WolvenKit.App.ViewModels.Tools;

public abstract class ToolViewModel : PaneViewModel
{
    /// <summary>
    /// Class constructor.
    /// </summary>
    /// <param name="name"></param>
    public ToolViewModel(string name) : base(name, name)
    {
        State = DockState.Dock;
        CanSerialize = true;

        Name = name;

        this.WhenActivated(disposables =>
        {
            Observable.FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
              handler => PropertyChanged += handler,
              handler => PropertyChanged -= handler)
                .Subscribe(e =>
                {
                    if (e.EventArgs.PropertyName == nameof(State))
                    {
                        OnPropertyChanged(nameof(IsVisible));
                    }
                })
                .DisposeWith(disposables);
        });
    }


    /// <summary>
    /// Gets the name of this tool window.
    /// </summary>
    public string Name { get; }


    
}
