using System.Collections.ObjectModel;
using Catel.MVVM;
using Pathoschild.FluentNexus;
using Pathoschild.FluentNexus.Models;
using Syncfusion.UI.Xaml.Kanban;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class UserPageViewModel : ViewModelBase
    {
        public UserPageViewModel()
        {
            InitializeNexus();

        }

        private async void InitializeNexus()
        {
            var nexus = new NexusClient("bzBNZ0lTd1lRZnZ2RjEyMXcvazVINWMwMEE3NlpjUStDVHBGY3BYNmQ1NHpNTEJhcUZjc3o1cno3SmVvblUvOS0ta1hhbkFVSDcwWEYrNDJzWjBHVmxCUT09--b5ad33edf85c9d79422b467a326a4457bb68f253", "WolvenKit", "DESIGN_3043293212_348234834883");


            ModFileList files = await nexus.ModFiles.GetModFiles("stardewvalley", 2400);

            var q = await nexus.Users.ValidateAsync();

            var trackedMods = await nexus.Users.GetTrackedMods();
            foreach (var mod in trackedMods)
            {

                var actualmod = await nexus.Mods.GetMod(mod.DomainName, mod.ModID);
                var qa = new Syncfusion.UI.Xaml.Kanban.KanbanModel()
                {
                    Title = actualmod.Name,
                    Description = actualmod.Description + "\n " + actualmod.Version,
                    Category = actualmod.Author,
                    ImageURL = actualmod.PictureUrl

                };




                NexusTrackedMods.Add(qa);

            }


        }



        public static ObservableCollection<KanbanModel> NexusTrackedMods { get; set; } = new ObservableCollection<KanbanModel>();

    }
}
