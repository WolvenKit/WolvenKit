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
        #region Fields

        protected readonly IWindowFactory m_windowFactory;

        #endregion Fields

        #region Constructors

        public ViewModel(IWindowFactory windowFactory)
        {
            m_windowFactory = windowFactory;
        }

        public ViewModel()
        {
        }

        #endregion Constructors

        #region Methods

        public virtual void Initialize()
        {
        }

        #endregion Methods
    }
}
