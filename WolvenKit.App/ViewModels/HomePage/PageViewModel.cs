using System;
using ReactiveUI;
using Splat;

namespace WolvenKit.App.ViewModels.HomePage
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
