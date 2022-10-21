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


    }

    public ObservableCollection<RemotePackageViewModel> AvailableApps { get; } = new();
}
