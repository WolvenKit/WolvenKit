using WolvenKit.Models.Docking;

namespace WolvenKit.Models.Docking
{
    public interface IDockElement
    {
        public string Header { get; set; }

        public DockState State { get; set; }

        public bool IsActive { get; set; }
    }
}
