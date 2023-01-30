using System.Collections.Generic;

namespace WolvenKit.App.Models
{
    // serializable
    public class JsonAMM
    {
        public bool customIncluded { get; set; }
        public List<Prop>? props { get; set; }
        public List<object>? lights { get; set; }
        public string? name { get; set; }
        public string? file_name { get; set; }
    }

}
