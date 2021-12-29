using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace WolvenKit.ViewModels.Dialogs
{
    public abstract class DialogViewModel : ReactiveObject
    {
        public delegate void DialogHandlerDelegate(DialogViewModel sender);
        public DialogHandlerDelegate DialogHandler { get; set; }
    }
}
