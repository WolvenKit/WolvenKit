using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels.Wizards.WizardPages.PublishWizard
{
    class W3PackSettingsViewModel : ViewModelBase
    {

        public string[] PackerSource
        {
            get
            {
                return new string[] { "DLC", "MOD" };
            }
        }
          
    }
}
