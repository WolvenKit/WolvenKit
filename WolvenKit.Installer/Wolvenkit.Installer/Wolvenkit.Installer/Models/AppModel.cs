using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolvenkit.Installer.Models;
internal class AppModel
{
    public AppModel(string idStr, string version)
    {
        Version = version;
        IdStr = idStr;
    }

    public string IdStr { get; set; }
    public string Path { get; set; }
    public string Version { get; set; }
    public string[] Files { get; set; }
}
