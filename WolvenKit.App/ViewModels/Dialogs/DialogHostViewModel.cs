using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Dialogs
{
    public class DialogHostViewModel : ReactiveObject
    {
        [Reactive] public DialogViewModel HostedViewModel { get; set; }
    }
}
