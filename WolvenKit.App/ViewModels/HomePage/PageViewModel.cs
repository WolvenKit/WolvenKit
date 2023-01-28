using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Splat;
using WolvenKit.Core.Extensions;

namespace WolvenKit.ViewModels.HomePage
{
    /// <summary>
    /// A mainViewModel class for Pages
    /// </summary>
    public class PageViewModel : ObservableObject
    {
        protected readonly HomePageViewModel _homePageViewModel;

        protected PageViewModel(
            //HomePageViewModel homePageViewModel
            ) =>
            //_homePageViewModel = homePageViewModel;
            _homePageViewModel = Locator.Current.GetService<HomePageViewModel>().NotNull();


    }
}
