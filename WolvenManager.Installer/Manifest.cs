using System.Collections.Generic;

namespace WolvenManager.Installer
{
    public class Manifest
    {
        public string Version { get; set; }
        public string AssemblyName { get; set; }

        public KeyValuePair<string, string> Installer { get; set; }
        public KeyValuePair<string, string> Portable { get; set; }
    }
}
