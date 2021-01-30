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
using static WolvenKit.Views.VisualEditor.VisualEditorView;

namespace WolvenKit.Views.VisualEditor.Nodes
{
    /// <summary>
    /// Interaction logic for HelloWorldNodeView.xaml
    /// </summary>
    public partial class HelloWorldNodeView : IViewFor<HelloWorldNode>
    {
        #region ViewModel
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(HelloWorldNode), typeof(HelloWorldNodeView), new PropertyMetadata(null));

        public HelloWorldNode ViewModel
        {
            get => (HelloWorldNode)GetValue(ViewModelProperty);
            set => SetValue(ViewModelProperty, value);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (HelloWorldNode)value;
        }
        #endregion

        public HelloWorldNodeView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                this.WhenAnyValue(v => v.ViewModel).BindTo(this, v => v.NodeView.ViewModel).DisposeWith(d);
            });
        }
    }
}
