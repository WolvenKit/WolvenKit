using ReactiveUI;
using Syncfusion.Windows.Edit;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for TextEditorView.xaml
    /// </summary>
    public partial class ScriptDocumentView : ReactiveUserControl<ScriptDocumentViewModel>
    {
        public ScriptDocumentView()
        {
            InitializeComponent();

            //var redscriptResourceDictionary = new ResourceDictionary();
            //redscriptResourceDictionary.Source = new Uri(";component/Functionality/RedscriptLanguage.xaml",UriKind.RelativeOrAbsolute);

            var redscriptLanguage = new RedscriptLanguage(editControl1)
            {
                Lexem = editControl1.Resources["redscriptLanguageLexems"] as LexemCollection,
                Formats = editControl1.Resources["redscriptLanguageFormats"] as FormatsCollection
            };
            editControl1.CustomLanguage = redscriptLanguage;

            this.WhenActivated(disposables =>
            {
                if (DataContext is ScriptDocumentViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                // TEXT EDITOR

                // bind this directly
                //Document = "{Binding Document, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}"
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.Document,
                //        view => view.textEditor.Document)
                //    .DisposeWith(disposables);

                //this.Bind(ViewModel,
                //        viewModel => viewModel.IsDirty,
                //        view => view.textEditor.IsModified)
                //    .DisposeWith(disposables);
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.IsReadOnly,
                //        view => view.textEditor.IsReadOnly)
                //    .DisposeWith(disposables);
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.HighlightingDefinition,
                //        view => view.textEditor.SyntaxHighlighting)
                //    .DisposeWith(disposables);

            });
        }
    }
}
