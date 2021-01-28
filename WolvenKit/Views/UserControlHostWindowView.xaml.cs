
using Catel.Windows;
using Catel.Windows.Controls;
using WolvenKit.ViewModels;

namespace WolvenKit.Views
{
    public partial class UserControlHostWindowView : DataWindow
    {
        public UserControlHostWindowView(UserControlHostWindowViewModel ucvm)
            : base(DataWindowMode.Custom)
        {
            InitializeComponent();

            UserContentControl.Content = ucvm.ContentUserControl;
            
        }
    }
}
