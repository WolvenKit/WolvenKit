using System;
using System.Collections.Generic;

namespace WolvenManager.Installer.Models
{
    public enum EIncludedFiles
    {
        Installer,
        Portable
    }

    public class Manifest
    {
        public string Version { get; set; }
        public string AssemblyName { get; set; }

        public KeyValuePair<string, string> Installer { get; set; }
        public KeyValuePair<string, string> Portable { get; set; }

        public KeyValuePair<string, string> Get(EIncludedFiles file) =>
            file switch
            {
                EIncludedFiles.Installer => Installer,
                EIncludedFiles.Portable => Portable,
                _ => throw new ArgumentOutOfRangeException(nameof(file), file, null)
            };
    }
}
