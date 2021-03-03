using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    using Common.Services;
    using WolvenKit.Functionality.Controllers;

    public class ModkitViewModel : ViewModel
    {
        

        public ModkitViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            Logger = MainController.Get().Logger;
            

            RunCommand = new Functionality.Commands.RelayCommand(Run, CanRun);

            List<Type> x = typeof(Common.Wcc.Wcc_lite).GetNestedTypes().ToList();//.Cast<WCC_Command>().ToList();
            foreach (var item in x)
            {
                var cmd = (Common.Wcc.WCC_Command)Activator.CreateInstance(item);
                Commands.Add(cmd);
            }
            Commands = Commands.OrderBy(_ => _.Name).ToList();
            
        }



        #region Fields
        private /*readonly*/ LoggerService Logger;
        #endregion

        #region Properties
        public readonly List<Common.Wcc.WCC_Command> Commands = new List<Common.Wcc.WCC_Command>();
        #region SelectedObject
        private Common.Wcc.WCC_Command _selectedObject;
        public Common.Wcc.WCC_Command SelectedObject
        {
            get => _selectedObject;
            set
            {
                if (_selectedObject != value)
                {
                    var oldValue = _selectedObject;
                    _selectedObject = value;
                    RaisePropertyChanged(() => SelectedObject, oldValue, value);
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
