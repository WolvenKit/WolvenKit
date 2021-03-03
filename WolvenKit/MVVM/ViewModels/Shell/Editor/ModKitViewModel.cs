using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    public class ModkitViewModel : ViewModel
    {
        #region Constructors

        public ModkitViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            Logger = MainController.Get().Logger;

            RunCommand = new Functionality.Commands.RelayCommand(Run, CanRun);

            var x = typeof(Common.Wcc.Wcc_lite).GetNestedTypes().ToList();//.Cast<WCC_Command>().ToList();
            foreach (var item in x)
            {
                var cmd = (Common.Wcc.WCC_Command)Activator.CreateInstance(item);
                Commands.Add(cmd);
            }
            Commands = Commands.OrderBy(_ => _.Name).ToList();
        }

        #endregion Constructors



        #region Fields

        private /*readonly*/ LoggerService Logger;

        #endregion Fields

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

        #endregion SelectedObject

        #endregion Properties

        #region Commands

        public ICommand RunCommand { get; }

        #endregion Commands

        #region Commands Implementation

        protected bool CanRun() => true;

        protected async void Run() => await Task.Run(() => MainController.Get().WccHelper.RunCommand(SelectedObject));

        #endregion Commands Implementation
    }
}
