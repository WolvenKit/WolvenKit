using ReactiveUI;
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

namespace WolvenKit.Views.Editors.VisualEditor.Nodes
{
    /// <summary>
    /// Interaction logic for OUT_Node.xaml
    /// </summary>
    public partial class OUT_Node : IViewFor<Views.VisualEditor.VisualEditorView.OUT_Node_Class>
    {
        public static readonly DependencyProperty ViewModelProperty =
                DependencyProperty.Register(nameof(ViewModel), typeof(Views.VisualEditor.VisualEditorView.OUT_Node_Class), typeof(OUT_Node), new PropertyMetadata(null));

        public Views.VisualEditor.VisualEditorView.OUT_Node_Class ViewModel
        {
            get => (Views.VisualEditor.VisualEditorView.OUT_Node_Class)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => SetValue(ViewModelProperty, (Views.VisualEditor.VisualEditorView.OUT_Node_Class)value);
        }

        public OUT_Node()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                this.WhenAnyValue(v => v.ViewModel).BindTo(this, v => v.NodeView.ViewModel).DisposeWith(d);
            });
        }
    }
}