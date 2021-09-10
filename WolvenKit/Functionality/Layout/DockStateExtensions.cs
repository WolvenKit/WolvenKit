using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Models.Docking;

namespace WolvenKit.Functionality.Layout
{
    public static class DockStateExtensions
    {
        public static DockState ToDockState(this Syncfusion.Windows.Tools.Controls.DockState sfDockState) =>
            sfDockState switch
            {
                Syncfusion.Windows.Tools.Controls.DockState.Dock => DockState.Dock,
                Syncfusion.Windows.Tools.Controls.DockState.Float => DockState.Float,
                Syncfusion.Windows.Tools.Controls.DockState.Hidden => DockState.Hidden,
                Syncfusion.Windows.Tools.Controls.DockState.AutoHidden => DockState.AutoHidden,
                Syncfusion.Windows.Tools.Controls.DockState.Document => DockState.Document,
                _ => throw new ArgumentOutOfRangeException(nameof(sfDockState), sfDockState, null)
            };

        public static Syncfusion.Windows.Tools.Controls.DockState ToSfDockState(this DockState dockState) =>
            dockState switch
            {
                DockState.Dock => Syncfusion.Windows.Tools.Controls.DockState.Dock,
                DockState.Float => Syncfusion.Windows.Tools.Controls.DockState.Float,
                DockState.Hidden => Syncfusion.Windows.Tools.Controls.DockState.Hidden,
                DockState.AutoHidden => Syncfusion.Windows.Tools.Controls.DockState.AutoHidden,
                DockState.Document => Syncfusion.Windows.Tools.Controls.DockState.Document,
                _ => throw new ArgumentOutOfRangeException(nameof(dockState), dockState, null)
            };
    }
}
