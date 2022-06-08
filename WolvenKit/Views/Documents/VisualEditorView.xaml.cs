using ReactiveUI;
using Splat;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    public partial class VisualEditorView : ReactiveUserControl<VisualEditorViewModel>
    {
        #region Constructors

        public VisualEditorView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<VisualEditorViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors

        #region Methods

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => base.OnMouseLeftButtonDown(e);

        #endregion Methods

        // Begin dragging the window
    }
}
