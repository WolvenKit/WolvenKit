using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Wolvenkit.Installer.Models;

namespace Wolvenkit.Installer.ViewModel;
internal class AvailableViewModel
{
    public AvailableViewModel()
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"Wolvenkit.Installer.Resources.AvailableApps.json");


        var apps = JsonSerializer.Deserialize<List<RemotePackageModel>>(stream,
            new JsonSerializerOptions()
            {
                WriteIndented = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

        //var ordered = apps.OrderBy(x => x.Category).ToList();

        foreach (var item in apps)
        {

        }

    }

    public ObservableCollection<RemotePackageViewModel> AvailableApps { get; } = new();
}
