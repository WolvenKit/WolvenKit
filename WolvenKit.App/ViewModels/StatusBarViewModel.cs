using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.App.ViewModels
{
    using Catel.MVVM;

    public class StatusBarViewModel : ViewModelBase
    {
        #region Properties
        public override string Title => "Status bar title binding";

        #endregion

        public bool EnableAutomaticUpdates { get; set; }
    }
}
