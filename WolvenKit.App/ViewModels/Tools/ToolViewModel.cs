using System;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models.Docking;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Tools
{
    public abstract class ToolViewModel : PaneViewModel
    {

        #region constructors

        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="name"></param>
        public ToolViewModel(string name)
        {
            State = DockState.Dock;

            Name = name;
            Title = name;
            Header = name;

            this.WhenAnyValue(x => x.IsVisible).Subscribe(b =>
            {
                State = !b ? DockState.Hidden : DockState.Dock;
            });

        }

        /// <summary>
        /// Hidden default class constructor
        /// </summary>
        protected ToolViewModel()
        {
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// Gets the name of this tool window.
        /// </summary>
        public string Name { get; }

        #region IsVisible

        /// <summary>
        /// Gets/sets whether this tool window is visible or not.
        /// </summary>
        [Reactive] public bool IsVisible { get; set; }

        #endregion IsVisible

        #endregion properties
    }
}
