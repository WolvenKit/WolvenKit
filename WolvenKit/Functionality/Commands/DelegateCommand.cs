using System;

namespace WolvenKit.Functionality.Commands
{
    /// <summary>
    /// Defines an ICommand that delegates implementation to an <see cref="Action{T}(object)"/> and <see cref="Predicate{T}(object)"/>.
    /// </summary>
    public class DelegateCommand : Command
    {
        #region Fields

        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        #endregion Fields

        #region Constructors

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

        #endregion Constructors

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
        public override void Execute(object parameter) => _execute(parameter);

        #endregion ICommand Members
    }
}
