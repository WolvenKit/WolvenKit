using System;

namespace WolvenKit.App.Commands.Base
{
    /// <summary>
    /// Defines an ICommand that delegates implementation to an <see cref="Action{T}"/> and <see cref="Predicate{T}"/>.
    /// </summary>
    /// <typeparam name="T">The command parameter type.</typeparam>
    public class DelegateCommand<T> : CommandBase
    {
        #region Fields

        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand{T}"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        public DelegateCommand(Action<T> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand{T}"/> class.
        /// </summary>
        /// <param name="execute">The method used to execute the command.</param>
        /// <param name="canExecute">The method used to check if the command can be executed.</param>
        public DelegateCommand(Action<T> execute, Predicate<T> canExecute)
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
        public override bool CanExecute(object parameter) => _canExecute is null || _canExecute((T)parameter);

        /// <summary>
        /// Execute the command
        /// </summary>
        /// <param name="parameter">The command parameter</param>
        public override void Execute(object parameter) => _execute((T)parameter);

        #endregion ICommand Members
    }
}
