using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using WolvenKit.App.Commands;
using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{
   

    public class SettingsViewModel : ViewModel
    {
        





        public SettingsViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            Logger = MainController.Get().Logger;
            

            RunCommand = new RelayCommand(Run, CanRun);


        }

        #region Fields
        private /*readonly*/ LoggerService Logger;

        #endregion

        #region Properties
        
        #endregion

        #region Commands
        public ICommand RunCommand { get; }

        #endregion

        #region Commands Implementation
        protected bool CanRun()
        {
            
            return true;
        }

        protected /*async*/ void Run()
        {

        }

        #endregion

        #region Methods



        #endregion



    }
}
