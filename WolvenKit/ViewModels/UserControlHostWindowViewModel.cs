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

            // TODO: Move code below to constructor
            Exit = new Command(OnExitExecute);
            // TODO: Move code above to constructor
        }

        public UserControlHostWindowViewModel(UserControl uc, int height, int width)
        {
            ContentUserControl = uc;
            Height = height;
            Width = width;
            uc.Height = height;
            uc.Width = width;
        }

        public IView ContentUserControl { get; internal set; }
        public int Height { get; }
        public Command Exit { get; private set; }
        public int Width { get; }

        private void OnExitExecute()
        {
            _ = CloseAsync();
        }

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
