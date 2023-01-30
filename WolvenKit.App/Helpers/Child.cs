using System.Collections.Generic;

namespace WolvenKit.ViewModels.Shell
{
    public class Child
    {
        public Child(string name, Pos pos, Rot rot)
        {
            this.name = name;
            this.pos = pos;
            this.rot = rot;
        }

        public bool headerOpen { get; set; }
        public bool autoLoad { get; set; }
        public Rot rot { get; set; }
        public string? path { get; set; }
        public Pos pos { get; set; }
        public string? type { get; set; }
        public int loadRange { get; set; }
        public string name { get; set; }
        public string? app { get; set; }
        public List<Child> childs { get; set; } = new();
    }

}
