using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;

namespace WolvenKit.MVVM.Views.Components.Editors.VisualEditor.Nodes
{
    /// <summary>
    /// Interaction logic for IN_Node.xaml
    /// </summary>
    public partial class IN_Node : IViewFor<VisualEditor.VisualEditorView.IN_Node_Class>
    {
        public static readonly DependencyProperty ViewModelProperty =
                DependencyProperty.Register(nameof(ViewModel), typeof(VisualEditor.VisualEditorView.IN_Node_Class), typeof(IN_Node), new PropertyMetadata(null));

        public VisualEditor.VisualEditorView.IN_Node_Class ViewModel
        {
            get => (VisualEditor.VisualEditorView.IN_Node_Class)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => SetValue(ViewModelProperty, (VisualEditor.VisualEditorView.IN_Node_Class)value);
        }

        public IN_Node()
        {
            InitializeComponent();

            this.WhenActivated(d => this.WhenAnyValue(v => v.ViewModel).BindTo(this, v => v.NodeView.ViewModel).DisposeWith(d));
        }
    }
}
