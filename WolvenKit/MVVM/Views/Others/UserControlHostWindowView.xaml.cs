using System.Windows;
using Catel.Windows;
using WolvenKit.ViewModels;

namespace WolvenKit.MVVM.Views.Others
{
    public partial class UserControlHostWindowView : DataWindow
    {
        public UserControlHostWindowView(UserControlHostWindowViewModel ucvm) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            UserContentControl.Content = ucvm.ContentUserControl;
            ucvm.ClosedAsync += (s, e) => { return System.Threading.Tasks.Task.Run(() => Dispatcher.Invoke(() => Close())); };
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => DragMove();
        private void ButtonClose(object sender, RoutedEventArgs e) => Close();
        private void ButtonMinimize(object sender, RoutedEventArgs e) => SetCurrentValue(WindowStateProperty, WindowState.Minimized);
    }
}
