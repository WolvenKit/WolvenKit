using System.Windows;
using Catel.Windows;
using WolvenKit.MVVM.ViewModels.Others;

namespace WolvenKit.MVVM.Views.Others
{
    public partial class UserControlHostWindowView : DataWindow
    {
        #region Constructors

        public UserControlHostWindowView(UserControlHostWindowViewModel ucvm) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            UserContentControl.Content = ucvm.ContentUserControl;
            ucvm.ClosedAsync += (s, e) => System.Threading.Tasks.Task.Run(() => Dispatcher.Invoke(() => Close()));
        }

        #endregion Constructors

        #region Methods

        private void ButtonClose(object sender, RoutedEventArgs e) => Close();

        private void ButtonMinimize(object sender, RoutedEventArgs e) => SetCurrentValue(WindowStateProperty, WindowState.Minimized);

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => DragMove();

        #endregion Methods
    }
}
