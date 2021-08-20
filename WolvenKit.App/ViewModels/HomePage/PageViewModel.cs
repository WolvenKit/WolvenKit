using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.HomePage;

namespace WolvenKit.ViewModels.HomePage
{
    /// <summary>
    /// A mainViewModel class for Pages
    /// </summary>
    public class PageViewModel : ReactiveObject
    {
        protected readonly HomePageViewModel _homePageViewModel;

        protected PageViewModel(
            //HomePageViewModel homePageViewModel
            )
        {
            //_homePageViewModel = homePageViewModel;
            _homePageViewModel = Locator.Current.GetService<HomePageViewModel>();
        }


    }
}
