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
using WolvenKit.Common.Wcc;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.Radish.Model;

namespace WolvenKit.App.ViewModels
{

    public class ModkitViewModel : ViewModel
    {
        

        public ModkitViewModel()
        {
            Logger = MainController.Get().Logger;
            

            RunCommand = new RelayCommand(Run, CanRun);

            List<Type> x = typeof(Wcc_lite).GetNestedTypes().ToList();//.Cast<WCC_Command>().ToList();
            foreach (var item in x)
            {
                var cmd = (WCC_Command)Activator.CreateInstance(item);
                Commands.Add(cmd);
            }
            Commands = Commands.OrderBy(_ => _.Name).ToList();
            
        }



        #region Fields
        private /*readonly*/ LoggerService Logger;
        #endregion

        #region Properties
        public readonly List<WCC_Command> Commands = new List<WCC_Command>();
        #region SelectedObject
        private WCC_Command _selectedObject;
        public WCC_Command SelectedObject
        {
            get => _selectedObject;
            set
            {
                if (_selectedObject != value)
                {
                    _selectedObject = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #endregion

        #region Commands
        public ICommand RunCommand { get; }

        #endregion

        #region Commands Implementation
        protected bool CanRun()
        {
          
            
            return true;
        }

        protected async void Run()
        {
            await Task.Run(() => MainController.Get().WccHelper.RunCommand(SelectedObject));
        }

        #endregion

        #region Methods
        
        #endregion



    }
}
