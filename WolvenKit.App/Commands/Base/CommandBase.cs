using System;
using System.Windows.Input;

namespace WolvenKit.App.Commands.Base
{
    /// <summary>
    /// Base abstract class for all commands
    /// </summary>
    public abstract class CommandBase : ICommand
    {
        #region Events

        public virtual event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        #endregion Events

        #region Methods

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

        #endregion Methods
    }
}
