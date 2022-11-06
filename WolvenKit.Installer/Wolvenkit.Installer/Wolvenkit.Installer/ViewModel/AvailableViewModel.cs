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
using Wolvenkit.Installer.Services;

namespace Wolvenkit.Installer.ViewModel;
internal class AvailableViewModel
{
    public ILibraryService LibraryService { get; }

    public AvailableViewModel(ILibraryService libraryService) => LibraryService = libraryService;

}
