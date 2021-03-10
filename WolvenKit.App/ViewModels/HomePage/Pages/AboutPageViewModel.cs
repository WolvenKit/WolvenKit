using System.Collections.ObjectModel;
using Catel.MVVM;
using HandyControl.Controls;

namespace WolvenKit.ViewModels.HomePage.Pages
{
    public class AboutPageViewModel : ViewModelBase
    {

        public static ObservableCollection<GithubTimeLine> GithubCollection { get; set; }
    }
}
