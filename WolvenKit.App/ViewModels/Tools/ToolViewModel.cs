using System.ComponentModel;
using WolvenKit.Models.Docking;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Tools
{
    public abstract class ToolViewModel : PaneViewModel
    {
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name"></param>
        public ToolViewModel(string name) : base(name, name)
        {
            State = DockState.Dock;

            Name = name;

            this.PropertyChanged += delegate(object? sender, PropertyChangedEventArgs args)
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
}
