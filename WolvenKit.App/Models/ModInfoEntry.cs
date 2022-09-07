using WolvenKit.RED4.Types;
using static WolvenKit.Functionality.Extensions.TreeExtensions;

namespace WolvenKit.Models
{
    public class ModInfoEntry
    {
        // Is this intended? folder is using camelCase, but the other classes have PascalCase. -wopss
        public string folder { get; set; }
        public bool enabled { get; set; }
        public bool deployed { get; set; }
        public string deployedVersion { get; set; }

        //I suggest to create a class for these sounds or is it not possible / are they dynamic? -wopss
        public object[] customSounds { get; set; }
    }

}
