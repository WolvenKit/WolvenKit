using System.Reactive.Linq;
using System.Windows;
using DynamicData;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using ReactiveUI;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Views.Editor.VisualEditor.Nodes;

namespace WolvenKit.Views.Editor.VisualEditor
{
    public partial class VisualEditorView
    {
        #region Constructors

        public VisualEditorView()
        {
            InitializeComponent();

            //Create a new viewmodel for the NetworkView
            var network = new NetworkViewModel();

            //Create the node for the first node, set its name and add it to the network.
            var innode = new IN_Node_Class
            {
                Name = "IN"
            };
            network.Nodes.Add(innode);

            var outnode = new OUT_Node_Class
            {
                Name = "OUT"
            };
            network.Nodes.Add(outnode);

            //Assign the viewmodel to the view.
            networkView.ViewModel = network;
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

        #region Classes

        public class IN_Node_Class : NodeViewModel
        {
            #region Constructors

            static IN_Node_Class()
            {
                Splat.Locator.CurrentMutable.Register(() => new IN_Node(), typeof(IViewFor<IN_Node_Class>));
            }

            public IN_Node_Class()
            {
                TextOutput = new ValueNodeOutputViewModel<string>()
                {
                    Name = "Input",
                    Value = this.WhenAnyObservable(vm => vm.NameInput.ValueChanged)
                        .Select(name => $"Hello {name}!")
                };
                Outputs.Add(TextOutput);
            }

            #endregion Constructors

            #region Properties

            public ValueNodeInputViewModel<string> NameInput { get; }
            public ValueNodeOutputViewModel<string> TextOutput { get; }

            #endregion Properties
        }

        public class OUT_Node_Class : NodeViewModel
        {
            #region Constructors

            static OUT_Node_Class()
            {
                Splat.Locator.CurrentMutable.Register(() => new OUT_Node(), typeof(IViewFor<OUT_Node_Class>));
            }

            public OUT_Node_Class()
            {
                NameInput = new ValueNodeInputViewModel<string>()
                {
                    Name = "Output",
                };
                Inputs.Add(NameInput);
            }

            #endregion Constructors

            #region Properties

            public ValueNodeInputViewModel<string> NameInput { get; }
            public ValueNodeOutputViewModel<string> TextOutput { get; }

            #endregion Properties
        }

        #endregion Classes

        // Begin dragging the window
    }
}
