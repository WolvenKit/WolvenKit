using System;

namespace WolvenKit.App.Commands.Base
{
    /// <summary>
    /// Defines an ICommand that delegates implementation to an <see cref="Action"/> and <see cref="Func{TResult}(bool)"/>.
    /// Implementation is parametless.
    /// </summary>
    public class RelayCommand : CommandBase
    {
        private readonly Func<bool> _canExecute;

        private readonly Action _execute;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        /// <param name="canExecute">The method used to check if the command can be executed.</param>
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Check if the command can be executed.
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        /// <returns>True if the command can be executed, otherwise false.</returns>
        public override bool CanExecute(object parameter) => _canExecute is null || _canExecute();

        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        public override void Execute(object parameter) => _execute();
    }
}
