using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Windows.Controls;
using System.Linq;
using System.Threading.Tasks;

namespace WolvenKit.ViewModels
{
    public class UserControlHostWindowViewModel : ViewModelBase
    {
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

        public IView ContentUserControl { get; internal set; }
        public int Height { get; }
        public int Width { get; }


        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
