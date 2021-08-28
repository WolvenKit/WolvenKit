using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;
using Syncfusion.Windows.Edit;
using WolvenKit.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for TextEditorView.xaml
    /// </summary>
    public partial class TweakDocumentView : ReactiveUserControl<TweakDocumentViewModel>
    {
        public TweakDocumentView()
        {
            InitializeComponent();

            this.WhenActivated(disposables =>
            {
                //Document = "{Binding Document, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}"
                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.Document,
                //        view => view.textEditor.Document)
                //    .DisposeWith(disposables);

                //IsModified = "{Binding Path=IsDirty, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"
                this.Bind(ViewModel,
                        viewModel => viewModel.IsDirty,
                        view => view.textEditor.IsModified)
                    .DisposeWith(disposables);
                //IsReadOnly = "{Binding IsReadOnly, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}"
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.IsReadOnly,
                        view => view.textEditor.IsReadOnly)
                    .DisposeWith(disposables);
                //SyntaxHighlighting="{Binding HighlightingDefinition, Mode=OneWay, UpdateSourceTrigger=PropertyChanged}"
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.HighlightingDefinition,
                        view => view.textEditor.SyntaxHighlighting)
                    .DisposeWith(disposables);

                //this.OneWayBind(ViewModel,
                //        viewModel => viewModel.DocumentSource,
                //        view => view.textEditor.DocumentSource)
                //    .DisposeWith(disposables);
                //this.Bind(ViewModel,
                //        viewModel => viewModel.DocumentSource,
                //        view => view.textbox.Text)
                //    .DisposeWith(disposables);

            });
        }
    }
}
