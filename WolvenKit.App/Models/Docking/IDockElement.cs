using WolvenKit.Models.Docking;

namespace WolvenKit.Models.Docking
{
    public interface IDockElement
    {
        string Header { get; set; }

        DockState State { get; set; }
    }
}
