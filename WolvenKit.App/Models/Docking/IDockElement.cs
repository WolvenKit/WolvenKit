namespace WolvenKit.App.Models.Docking;

public interface IDockElement
{
    public string Header { get; set; }

    public DockState State { get; set; }

    public DockSide SideInDockedMode { get; set; }

    public bool IsActive { get; set; }

    bool IsVisible { get; set; }
}
