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
                if (DataContext is TweakDocumentViewModel vm)
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

                this.Bind(ViewModel,
                        viewModel => viewModel.IsDirty,
                        view => view.textEditor.IsModified)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.IsReadOnly,
                        view => view.textEditor.IsReadOnly)
                    .DisposeWith(disposables);
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.HighlightingDefinition,
                        view => view.textEditor.SyntaxHighlighting)
                    .DisposeWith(disposables);


                // LIST VIEW
                this.OneWayBind(ViewModel,
                        viewModel => viewModel.Flats,
                        view => view.FlatsTree.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.SelectedItem,
                        view => view.FlatsTree.SelectedItem)
                    .DisposeWith(disposables);

                // ADD VALUE BOX
                this.OneWayBind(ViewModel,
                       viewModel => viewModel.SelectedType,
                       view => view.TypeComboBox.SelectedItem)
                   .DisposeWith(disposables);

                this.Bind(ViewModel,
                        viewModel => viewModel.FlatName,
                        view => view.NameTextBox.Text)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                        viewModel => viewModel.ValueString,
                        view => view.ValueTextBox.Text)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel,
                        viewModel => viewModel.AddFlatCommand,
                        view => view.AddButton)
                    .DisposeWith(disposables);


               
            });
        }

        private void EditButton_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.EditFlatCommand.Execute().Subscribe();
        }

        private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel?.DeleteFlatCommand.Execute().Subscribe();
        }
    }
}
