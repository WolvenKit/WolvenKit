using System;

namespace WolvenKit.Commands
{
    /// <summary>
    /// Defines an ICommand that delegates implementation to an <see cref="Action{T}(Object)"/> and <see cref="Predicate{T}(Object)"/>.
    /// </summary>
    public class DelegateCommand : Command
    {
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        public DelegateCommand(Action<object> execute)
            : this(execute, null)
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        /// <param name="canExecute">The method used to check if the command can be executed.</param>
        public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        #region ICommand Members
        /// <summary>
        /// Check if the command can be executed.
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        /// <returns>True if the command can be executed, otherwise false.</returns>
        public override bool CanExecute(object parameter)
        {
            if (_canExecute is null)
            {
                return true;
            }
            return _canExecute(parameter);
        }
        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        public override void Execute(object parameter)
        {
            _execute(parameter);
        }
        #endregion
    }
}