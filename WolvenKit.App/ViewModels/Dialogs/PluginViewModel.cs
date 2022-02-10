using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Dialogs
{
    public class PluginViewModel : DialogViewModel
    {

        public PluginViewModel()
        {
            
        }

       

        [Reactive]
        public ObservableCollection<PluginModel> Plugins { get; set; } = new ObservableCollection<PluginModel>()
        {
            new PluginModel()
            {
                Name = "RedMod",
                Description = "XXX",
                Version = "1.0"
            }
        };

        [Reactive]
        public PluginModel SelectedPlugin { get; set; }

        

    }

    public class PluginModel : ReactiveObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }

        public PluginModel()
        {
            InstallCommand = ReactiveCommand.Create(() =>
            {
                IsCreating = true;




            }, this.WhenAnyValue(
                x => x.IsCreating,
                (isCreating) =>
                    !isCreating));
        }

        [Reactive] public bool IsCreating { get; set; }
        public ICommand InstallCommand { get; private set; }
    }


}
