using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.App.ViewModels
{
    /// <summary>
    /// https://stackoverflow.com/a/11948550
    /// </summary>
    public abstract class CloseableViewModel : ViewModel
    {
        public event EventHandler ClosingRequest;
        public event EventHandler ActivateRequest;

        protected void OnClosingRequest()
        {
            if (this.ClosingRequest != null)
            {
                this.ClosingRequest(this, EventArgs.Empty);
            }
        }

        protected void OnActivateRequest()
        {
            if (this.ActivateRequest != null)
            {
                this.ActivateRequest(this, EventArgs.Empty);
            }
        }

        public void Close() => OnClosingRequest();
        public void Activate() => OnActivateRequest();
    }
}
