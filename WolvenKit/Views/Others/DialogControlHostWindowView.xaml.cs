using System.Windows;
using Catel.Windows;
using WolvenKit.ViewModels.Others;

namespace WolvenKit.Views.Others
{
    public partial class DialogControlHostWindowView : DataWindow
    {
        #region Constructors

        public DialogControlHostWindowView(DialogControlHostWindowViewModel ucvm) : base(DataWindowMode.Custom)
        {
            InitializeComponent();
            UserContentControl.Content = ucvm.ContentUserControl;
        }

        #endregion Constructors

        #region Methods

        private void ButtonClose(object sender, RoutedEventArgs e) => Close();

        private void ButtonMinimize(object sender, RoutedEventArgs e) => SetCurrentValue(WindowStateProperty, WindowState.Minimized);

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => DragMove();

        #endregion Methods
    }
}
