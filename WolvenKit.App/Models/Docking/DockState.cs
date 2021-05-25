using System;

namespace WolvenKit.Models.Docking
{
    public enum DockState
    {
        Dock,
        Float,
        Hidden,
        AutoHidden,
        Document
    }

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

    ///// <summary>
    ///// Specifies the state of the control is Dock, Float, Hidden, AutoHidden, or Document.
    ///// </summary>
    //public enum DockState
    //{
    //    /// <summary>Control is docked to the docking manager's surface.</summary>
    //    Dock,
    //    /// <summary>
    //    /// Control is not docked to the docking manager's surface.
    //    /// </summary>
    //    Float,
    //    /// <summary>Control is not visible at all.</summary>
    //    Hidden,
    //    /// <summary>
    //    /// Control is hidden and will show if mouse move under tab.
    //    /// </summary>
    //    AutoHidden,
    //    /// <summary>Control is tabbed or MDI document.</summary>
    //    Document,
    //}
}
