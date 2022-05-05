using System.Collections.Generic;
using WolvenKit.Modkit.RED4.Sounds;

namespace WolvenKit.Models
{
    public class ModInfo
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public List<CustomSoundsModel> CustomSounds { get; set; } = new();

    }

    public class ModInfoEntry
    {
        public string folder { get; set; }
        public bool enabled { get; set; }
        public bool deployed { get; set; }
        public string deployedVersion { get; set; }
        public object[] customSounds { get; set; }
    }

    public class ModsInfo
    {
        public List<ModInfoEntry> Mods { get; set; } = new();

    }

}
