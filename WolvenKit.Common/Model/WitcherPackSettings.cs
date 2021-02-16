using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    public class WitcherPackSettings
    {
        public bool dlcPackBundles { get; set; }
        public bool dlcGenMetadata { get; set; }
        public bool dlcGenTexCache { get; set; }
        public bool dlcGenCollCache { get; set; }
        public bool dlcScripts { get; set; }
        public bool dlcSound { get; set; }
        public bool dlcStrings { get; set; }
        public bool dlcInstallProject { get; set; }
        public bool modPackBundles { get; set; }
        public bool modGenMetadata { get; set; }
        public bool modGenTexCache { get; set; }
        public bool modGenCollCache { get; set; }
        public bool modScripts { get; set; }
        public bool modSound { get; set; }
        public bool modStrings { get; set; }
        public bool modInstallProject { get; set; }

        public WitcherPackSettings() { }
    }
}
