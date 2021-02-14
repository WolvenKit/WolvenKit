using Pathoschild.FluentNexus;
using Pathoschild.FluentNexus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.WKitGlobal
{
    class NexusHelper
    {


        public async Task ConnectUserToNexusAsync()
        {
            var nexus = new NexusClient("bzBNZ0lTd1lRZnZ2RjEyMXcvazVINWMwMEE3NlpjUStDVHBGY3BYNmQ1NHpNTEJhcUZjc3o1cno3SmVvblUvOS0ta1hhbkFVSDcwWEYrNDJzWjBHVmxCUT09--b5ad33edf85c9d79422b467a326a4457bb68f253", "WolvenKit", "DESIGN_3043293212_3482348)34883)");

            var q = await nexus.Users.ValidateAsync();

            UserTrackedMod[] mods = await nexus.Users.GetTrackedMods();

        }
    }
}
