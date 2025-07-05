namespace WolvenKit.App.Models.Docking;

public enum DockState
{
    Dock = 0,
    Float,
    Hidden,
    AutoHidden,
    Document
}

public enum DockSide
{
    Bottom = 0,
    Left,
    None,
    Right,
    Tabbed,
    Top
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
