using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolvenkit.Installer.Models;
internal class RemotePackageModel
{
    public string Url { get; set; }
    public string Name { get; set; }
    public string AssetPattern { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}
