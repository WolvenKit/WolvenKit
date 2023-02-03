using System;
using System.IO;
using System.Reactive.Disposables;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ReactiveUI;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTTextureView.xaml
    /// </summary>
    public partial class RDTTextView : ReactiveUserControl<RDTTextViewModel>
    {
        public RDTTextView()
        {
            InitializeComponent();

            textEditor.Options = new TextEditorOptions
            {
                IndentationSize = 2,
                ConvertTabsToSpaces = true,
                EnableHyperlinks = false,
                EnableEmailHyperlinks = false
            };

            textEditor.Document = new TextDocument();
            textEditor.Document.TextChanged += textEditor_Document_TextChanged;

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTTextViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                this.WhenAnyValue(x => x.ViewModel.FilePath)
                    .Subscribe(x =>
                    {
                        if (!File.Exists(x))
                        {
                            return;
                        }

                        textEditor.SetCurrentValue(TextEditor.SyntaxHighlightingProperty, HighlightingManager.Instance.GetDefinitionByExtension(Path.GetExtension(x)));
                    });

                this.WhenAnyValue(x => x.ViewModel.Text)
                    .Subscribe(text =>
                    {
                        if (textEditor.Document.Text != text)
                        {
                            textEditor.Document.Text = text;
                        }
                    });

                this.Bind(ViewModel,
                       viewModel => viewModel.IsDirty,
                       view => view.textEditor.IsModified)
                   .DisposeWith(disposables);
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.IsReadOnly,
                //        view => view.textEditor.IsReadOnly)
                //    .DisposeWith(disposables);
            });
        }

        private void textEditor_Document_TextChanged(object sender, EventArgs e)
        {
            if (ViewModel != null && ViewModel.Text != textEditor.Document.Text)
            {
                ViewModel.Text = textEditor.Document.Text;
            }
        }
    }
}
