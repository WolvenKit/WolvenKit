using System.Windows.Input;

namespace WolvenKit.App.Commands.Base
{
    public static class ICommandExtensions
    {
        #region Methods

        public static void SafeExecute(this ICommand command, object parameter)
        {
            if (command.CanExecute(parameter))
            {
                command.Execute(parameter);
            }
        }

        public static void SafeExecute(this ICommand command)
        {
            if (command.CanExecute(null))
            {
                command.Execute(null);
            }
        }

        #endregion Methods
    }
}
