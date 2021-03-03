using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Windows.Controls;

namespace WolvenKit.MVVM.ViewModels.Others
{
    public class UserControlHostWindowViewModel : ViewModelBase
    {
        #region Constructors

        public UserControlHostWindowViewModel(ViewModelBase vm)
        {
            var viewManager = ServiceLocator.Default.ResolveType<IViewManager>();
            var views = viewManager.GetViewsOfViewModel(vm);

            ContentUserControl = views.FirstOrDefault();
        }

        public UserControlHostWindowViewModel(UserControl uc)
        {
            ContentUserControl = uc;
            uc.ViewModelChanged += (_s, _e) =>
            {
                if (uc.ViewModel == null)
                    return;
                uc.ViewModel.ClosedAsync += (s, e) =>
                {
                    return CloseViewModelAsync(null);
                };
            };
        }

        public UserControlHostWindowViewModel(UserControl uc, int height, int width)
            : this(uc)
        {
            Height = height;
            Width = width;
            uc.Height = height;
            uc.Width = width;
        }

        #endregion Constructors



        #region Properties

        public IView ContentUserControl { get; internal set; }
        public int Height { get; }
        public int Width { get; }

        #endregion Properties

        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets



        #region Methods

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        #endregion Methods
    }
}
