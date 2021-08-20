using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Editor
{
    public class ModkitViewModel : ToolViewModel
    {
        /// <summary>
        /// Identifies the caption string used for this tool window.
        /// </summary>
        public const string ToolTitle = "Bulk Editor";

        #region Fields

        private readonly IProjectManager _projectManager;
        private readonly ILoggerService Logger;
        private readonly Tw3Controller _tw3Controller;

        #endregion Fields

        #region Constructors

        public ModkitViewModel(
            IProjectManager projectManager,
            ILoggerService loggerService
            //Tw3Controller tw3Controller
        ) : base(ToolTitle)
        {
            _projectManager = projectManager;
            Logger = loggerService;
            //_tw3Controller = tw3Controller;

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


        #region Properties

        public readonly List<Common.Wcc.WCC_Command> Commands = new List<Common.Wcc.WCC_Command>();

        #region SelectedObject

        [Reactive] public Common.Wcc.WCC_Command SelectedObject { get; set; }

        #endregion SelectedObject

        #endregion Properties

        #region Commands

        public ICommand RunCommand { get; }

        #endregion Commands

        #region Commands Implementation

        protected bool CanRun() => true;

        protected async void Run() => await Task.Run(() => _tw3Controller.RunCommand(SelectedObject));

        #endregion Commands Implementation
    }
}
