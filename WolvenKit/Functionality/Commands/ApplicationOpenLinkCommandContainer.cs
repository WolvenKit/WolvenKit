using System;
using System.Diagnostics;
using Catel.MVVM;
using WolvenKit.Functionality.WKitGlobal;

namespace WolvenKit.Functionality.Commands
{
    class ApplicationOpenLinkCommandContainer : Catel.MVVM.CommandContainerBase
    {

        public ApplicationOpenLinkCommandContainer(ICommandManager commandManager)
            : base(AppCommands.Application.OpenLink, commandManager)
        {

        }
        protected override bool CanExecute(object parameter) => true;

        protected override void Execute(object parameter)
        {
            var ps = new ProcessStartInfo((string)parameter)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }       
    }
}
