using System;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor.Documents
{
    using Common.Services;

    /// <summary>
    /// https://stackoverflow.com/a/11948550
    /// </summary>
    public abstract class CloseableViewModel : ViewModel
    {
        #region Constructors

        public CloseableViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
        }

        #endregion Constructors



        #region Events

        public event EventHandler ActivateRequest;

        public event EventHandler ClosingRequest;

        #endregion Events



        #region Methods

        public void Activate() => OnActivateRequest();

        public void Close() => OnClosingRequest();

        protected void OnActivateRequest() => ActivateRequest?.Invoke(this, EventArgs.Empty);

        protected void OnClosingRequest() => ClosingRequest?.Invoke(this, EventArgs.Empty);

        #endregion Methods
    }
}
