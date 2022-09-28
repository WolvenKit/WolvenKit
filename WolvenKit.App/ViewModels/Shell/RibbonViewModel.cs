using System;
using System.Collections.Generic;
using System.IO;
using System.Reactive;
using System.Threading.Tasks;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Common.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;

namespace WolvenKit.ViewModels.Shell
{
    public class RibbonViewModel : ReactiveObject
    {
        public RibbonViewModel(
            AppViewModel appViewModel
        )
        {
            MainViewModel = appViewModel;

            LaunchProfileText = "Launch Profiles";
            LaunchProfiles = GetLaunchProfiles();

            NewFileCommand = ReactiveCommand.Create(() => MainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => MainViewModel.SaveFileCommand.SafeExecute());
            SaveAsCommand = ReactiveCommand.Create(() => MainViewModel.SaveAsCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => MainViewModel.SaveAllCommand.SafeExecute());
            LaunchOptionsCommand = ReactiveCommand.Create(LaunchOptions);
            LaunchProfileCommand = ReactiveCommand.Create(LaunchProfile);

            this.WhenAnyValue(x => x.MainViewModel.ActiveProject).WhereNotNull().Subscribe(p =>
            {
                if (p is not null)
                {
                    LaunchProfileText = p.Name;
                }
            });

        }

        private Dictionary<string, LaunchProfile> GetLaunchProfiles()
        {
            var profiles = new Dictionary<string, LaunchProfile>();

            // deserialize

            // and add MenuItems



            return profiles;
        }

        public AppViewModel MainViewModel { get; }


        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAsCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }

        public ReactiveCommand<Unit, Unit> LaunchOptionsCommand { get; }
        private void LaunchOptions()
        {
            // open launch profiles menu
        }

        public ReactiveCommand<Unit, Unit> LaunchProfileCommand { get; }
        private void LaunchProfile()
        {
            // launch the selected profile
            // this would be by name
        }



        [Reactive] public string LaunchProfileText { get; set; }

        public Dictionary<string, LaunchProfile> LaunchProfiles { get; set; }


    }
}
