using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ReactiveUI;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.ViewModels.Documents;

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

            this.WhenActivated(disposables =>
            {
                if (DataContext is RDTTextViewModel vm)
                {
                    SetCurrentValue(ViewModelProperty, vm);
                }

                this.Bind(ViewModel,
                       viewModel => viewModel.IsDirty,
                       view => view.textEditor.IsModified)
                   .DisposeWith(disposables);
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
