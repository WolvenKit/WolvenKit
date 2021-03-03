using System.Windows;
using Catel.Windows;
using WolvenKit.MVVM.ViewModels.Others;

namespace WolvenKit.MVVM.Views.Others
{
    public partial class DialogControlHostWindowView : DataWindow
    {
        public DialogControlHostWindowView(DialogControlHostWindowViewModel ucvm) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            UserContentControl.Content = ucvm.ContentUserControl;
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => DragMove();

        private void ButtonClose(object sender, RoutedEventArgs e) => Close();

        private void ButtonMinimize(object sender, RoutedEventArgs e) => SetCurrentValue(WindowStateProperty, WindowState.Minimized);
    }
}
