using System.Windows.Input;

namespace WolvenKit.App.Extensions;

public static class ICommandExtensions
{
    public static void SafeExecute(this ICommand command, object? parameter)
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
}
