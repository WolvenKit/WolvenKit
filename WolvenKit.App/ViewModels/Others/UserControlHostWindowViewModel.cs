using System;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using Catel.MVVM;
using Catel.MVVM.Views;
using Catel.Services;
using Catel.Windows.Controls;
using WolvenKit.ViewModels.Wizards;

namespace WolvenKit.ViewModels.Others
{
    public class UserControlHostWindowViewModel : ViewModelBase
    { // #MVVM
        #region Constructors

        public UserControlHostWindowViewModel(ViewModelBase vm)
        {
            var viewManager = ServiceLocator.Default.ResolveType<IViewManager>();
            var views = viewManager.GetViewsOfViewModel(vm);

            
            if (views.Length < 1)
            {
                
            }


            ContentUserControl = views.FirstOrDefault();
        }

        public UserControlHostWindowViewModel(UserControl uc)
        {
            ContentUserControl = uc;
            uc.ViewModelChanged += (_s, _e) =>
            {
                if (uc.ViewModel == null)
                {
                    return;
                }

                uc.ViewModel.ClosedAsync += (s, e) => OnWrappedViewModelClosedAsync(s, e);
               
                
            };
        }

        private async Task OnWrappedViewModelClosedAsync(object s, ViewModelClosedEventArgs e)
        {
            await this.CloseViewModelAsync(e.Result);
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


        #region Methods

        protected override async Task CloseAsync() => await base.CloseAsync();

        protected override async Task InitializeAsync() => await base.InitializeAsync();

        #endregion Methods
    }
}
