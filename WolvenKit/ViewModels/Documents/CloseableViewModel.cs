using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels
{
    /// <summary>
    /// https://stackoverflow.com/a/11948550
    /// </summary>
    public abstract class CloseableViewModel : ViewModel
    {
        public CloseableViewModel(IWindowFactory windowFactory) : base(windowFactory)
        {
            
        }

        public event EventHandler ClosingRequest;
        public event EventHandler ActivateRequest;

        protected void OnClosingRequest() => ClosingRequest?.Invoke(this, EventArgs.Empty);

        protected void OnActivateRequest() => ActivateRequest?.Invoke(this, EventArgs.Empty);

        public void Close() => OnClosingRequest();
        public void Activate() => OnActivateRequest();
    }
}
