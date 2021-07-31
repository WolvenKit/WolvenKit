using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models.Docking;

namespace WolvenKit.ViewModels.Shell
{
    public abstract class PaneViewModel : ReactiveObject, IDockElement
    {
        #region fields

        #endregion fields

        #region Properties

        public string Header { get; set; }
        public DockState State { get; set; }

        [Reactive] public string ContentId { get; set; }

        public ImageSource IconSource
        {
            get;
            protected set;
        }

        [Reactive] public bool IsActive { get; set; }

        [Reactive] public bool IsSelected { get; set; }

        [Reactive] public string Title { get; set; }

        #endregion Properties

        
    }
}
