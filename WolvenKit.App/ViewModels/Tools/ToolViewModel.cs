using System.ComponentModel;
using WolvenKit.App.Models.Docking;
using WolvenKit.App.ViewModels.Shell;

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

        PropertyChanged += delegate (object? sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == nameof(State))
            {
                OnPropertyChanged(nameof(IsVisible));
            }
        };
    }


    /// <summary>
    /// Gets the name of this tool window.
    /// </summary>
    public string Name { get; }


    
}
