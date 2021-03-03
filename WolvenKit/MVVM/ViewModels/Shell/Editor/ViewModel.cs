using Catel.MVVM;
using WolvenKit.Common.Services;

//using Ninject;
//using Ninject.Activation;
//using Ninject.Syntax;

namespace WolvenKit.MVVM.ViewModels.Shell.Editor
{
    /// <summary>
    /// Base abstract class for all viewmodels.
    /// </summary>
    public abstract class ViewModel : ViewModelBase
    {
        protected readonly IWindowFactory m_windowFactory;

        public ViewModel(IWindowFactory windowFactory)
        {
            m_windowFactory = windowFactory;
        }

        public ViewModel()
        {
        }

        public virtual void Initialize()
        {
        }
    }
}
