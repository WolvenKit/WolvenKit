using System;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using ReactiveUI;
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

            NewFileCommand = ReactiveCommand.Create(() => MainViewModel.NewFileCommand.SafeExecute(null));
            SaveFileCommand = ReactiveCommand.Create(() => MainViewModel.SaveFileCommand.SafeExecute());
            SaveAsCommand = ReactiveCommand.Create(() => MainViewModel.SaveAsCommand.SafeExecute());
            SaveAllCommand = ReactiveCommand.Create(() => MainViewModel.SaveAllCommand.SafeExecute());
        }


        public AppViewModel MainViewModel { get; }

        public ReactiveCommand<Unit, Unit> NewFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveFileCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAsCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveAllCommand { get; }
    }
}
