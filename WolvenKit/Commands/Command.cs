using System;
using System.Windows.Input;

namespace WolvenKit.Commands
{
    /// <summary>
    /// Base abstract class for all commands
    /// </summary>
    public abstract class Command : ICommand
    {
        public virtual event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }
}