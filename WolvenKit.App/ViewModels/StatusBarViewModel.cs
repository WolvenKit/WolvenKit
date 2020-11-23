using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.App.ViewModels
{
    using Catel.MVVM;
    using System.CodeDom;
    using System.Windows.Input;
    using WolvenKit.App.Commands;

    public class StatusBarViewModel : ViewModelBase
    {
        #region Properties
        public override string Title => "Status bar title binding";

        #endregion

        public bool EnableAutomaticUpdates { get; set; }

        public StatusBarViewModel()
        {
            Command1 = new RelayCommand(RunCommand1, CanRunCommand1);
        }

        public ICommand Command1 { get; }

        private bool CanRunCommand1() => true;
        private void RunCommand1()
        {
        }
    }
}
