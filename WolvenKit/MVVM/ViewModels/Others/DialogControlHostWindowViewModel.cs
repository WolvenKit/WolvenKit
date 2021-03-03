using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Windows.Controls;

namespace WolvenKit.MVVM.ViewModels.Others
{
    public class DialogControlHostWindowViewModel : ViewModelBase
    {
        public DialogControlHostWindowViewModel(ViewModelBase vm)

        {
            var viewManager = ServiceLocator.Default.ResolveType<IViewManager>();
            var views = viewManager.GetViewsOfViewModel(vm);

            ContentUserControl = views.FirstOrDefault();
        }

        public DialogControlHostWindowViewModel(UserControl uc)
        {
            ContentUserControl = uc;
        }

        public DialogControlHostWindowViewModel(UserControl uc, int height, int width)
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

        protected override async Task InitializeAsync() => await base.InitializeAsync();// TODO: subscribe to events here

        protected override async Task CloseAsync() =>
            // TODO: unsubscribe from events here

            await base.CloseAsync();
    }
}
