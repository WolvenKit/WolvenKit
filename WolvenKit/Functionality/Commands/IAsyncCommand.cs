using System;
using System.Windows.Input;

namespace WolvenKit.Functionality.Commands
{
    /// <summary>
    /// Defines an asynchronous command.
    /// </summary>
    public interface IAsyncCommand : ICommand
    {
        #region Methods

        IAsyncResult BeginExecute(object parameter);

        void EndExecute(IAsyncResult result);

        #endregion Methods
    }
}
