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
        public abstract ReactiveCommand<Unit, Unit> CloseCommand { get; set; }
        public abstract ReactiveCommand<Unit, Unit> OkCommand { get; set; }
        public abstract ReactiveCommand<Unit, Unit> CancelCommand { get; set; }

        public DialogViewModel()
        {
            
        }


        [Reactive] public string Title { get; set; }

    }
}
