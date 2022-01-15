using System;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Commands
{
    public class AsyncCommand : AsyncCommandBase
    {
        private readonly Func<bool> _canExecute;
        private readonly Func<Task> _command;

        public AsyncCommand(Func<Task> command)
        {
            _command = command;
        }

        public AsyncCommand(Func<Task> command, Func<bool> canExecute)
        {
            _command = command ?? throw new ArgumentNullException(nameof(command));
            _canExecute = canExecute;
        }

        public override bool CanExecute(object parameter)
        {
            if (_canExecute is null)
            {
                return true;
            }
            return _canExecute();
        }

        public override Task ExecuteAsync(object parameter) => _command();
    }
}
