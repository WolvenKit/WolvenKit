using System.Windows;
using System.Windows.Media;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.Edit;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Documents
{
    public partial class CodeEditorView : ReactiveUserControl<CodeEditorViewModel>
    {
        #region Constructors

        public CodeEditorView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<CodeEditorViewModel>();
            DataContext = ViewModel;

            //customLanguage.Lexem = this.Resources["pythonLanguageLexems"] as LexemCollection;

            //  customLanguage.Formats = this.Resources["pythonLanguageFormats"] as FormatsCollection;
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

    public class PythonLanguage : ProceduralLanguageBase

    {

        public PythonLanguage(EditControl control)

        : base(control)

        {

            this.Name = "Python";

            this.FileExtension = "py";

            this.ApplyColoring = true;

            this.SupportsIntellisense = false;

            this.SupportsOutlining = true;

            this.TextForeground = Brushes.Black;

        }

    }
}
