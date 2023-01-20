using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Models.Docking;

namespace WolvenKit.ViewModels.Shell;

public abstract class PaneViewModel : ReactiveObject, IDockElement
{
    protected PaneViewModel(string header, string contentId)
    {
        Header = header;
        ContentId = contentId;
    }

    [Reactive] public virtual string Header { get; set; }

    [Reactive] public DockState State { get; set; }

    [Reactive] public DockSide SideInDockedMode { get; set; }

    [Reactive] public string ContentId { get; set; }

    //public ImageSource IconSource
    //{
    //    get;
    //    protected set;
    //}

    [Reactive] public bool IsActive { get; set; }

}
