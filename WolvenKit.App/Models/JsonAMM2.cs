using System.Collections.Generic;

namespace WolvenKit.App.Models
{
    public class JsonAMM2
    {
        public List<Child> childs { get; set; } = new();
        public Pos? pos { get; set; }
        public int loadRange { get; set; }
        public bool headerOpen { get; set; }
        public string? type { get; set; }
        public Rot? rot { get; set; }
        public string? name { get; set; }
        public bool autoLoad { get; set; }
    }

}
