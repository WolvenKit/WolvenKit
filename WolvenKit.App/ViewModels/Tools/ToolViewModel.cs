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
            Header = name;

            this.WhenAnyValue(x => x.State).Subscribe(b =>
            {
                this.RaisePropertyChanged("IsVisible");
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
        public bool IsVisible
        {
            get => State != DockState.Hidden;
            set
            {
                State = value ? DockState.Dock : DockState.Hidden;
                this.RaisePropertyChanged("IsVisible");
            }
        }

        #endregion IsVisible

        #endregion properties
    }
}
