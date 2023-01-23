using System.Collections.Generic;
using WolvenKit.Modkit.RED4.Sounds;

namespace WolvenKit.Models
{
    public class ModInfo
    {
        public string Name { get; set; }

        public ModInfo(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public string Version { get; set; }

        public string? Description { get; set; }

        public List<CustomSoundsModel> CustomSounds { get; set; } = new();

    }

}
