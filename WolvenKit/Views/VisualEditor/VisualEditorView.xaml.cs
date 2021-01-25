
using Catel.Windows;
using DynamicData;
using NodeNetwork.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using NodeNetwork;
using System.Reactive.Linq;
using NodeNetwork.Toolkit.ValueNode;
using ReactiveUI;
using NodeNetwork.Views;
using WolvenKit.Views.VisualEditor.Nodes;

namespace WolvenKit.Views.VisualEditor
{
    public partial class VisualEditorView
    {


        public VisualEditorView() : base(DataWindowMode.Custom)
        {
            InitializeComponent();


            //Create a new viewmodel for the NetworkView
            var network = new NetworkViewModel();

            //Create the node for the first node, set its name and add it to the network.
            var node1 = new HelloWorldNode();
            node1.Name = "Node 1";
            network.Nodes.Add(node1);

            //Create the viewmodel for the input on the first node, set its name and add it to the node.
            var node1Input = new ValueNodeInputViewModel<string>();

            node1Input.Name = "Node 1 input";
            node1.Inputs.Add(node1Input);
            node1Input.ValueChanged.Subscribe(newValue =>
            {
                Console.WriteLine(newValue);
            });
            //Create the second node viewmodel, set its name, add it to the network and add an output in a similar fashion.
            var node2 = new NodeViewModel();
            node2.Name = "Node 2";
            network.Nodes.Add(node2);

            var node2Output = new ValueNodeOutputViewModel<string>();
            node2Output.Name = "Node 2 output";
            node2.Outputs.Add(node2Output); 
            node2Output.Value = Observable.Return("Example string");



            //Assign the viewmodel to the view.
            networkView.ViewModel = network;


        }

        public class HelloWorldNode : NodeViewModel
        {
            public ValueNodeInputViewModel<string> NameInput { get; }
            public ValueNodeOutputViewModel<string> TextOutput { get; }

            public HelloWorldNode()
            {
                this.Name = "Hello World Node";

                NameInput = new ValueNodeInputViewModel<string>()
                {
                    Name = "Name"
                };
                this.Inputs.Add(NameInput);

                TextOutput = new ValueNodeOutputViewModel<string>()
                {
                    Name = "Text",
                    Value = this.WhenAnyObservable(vm => vm.NameInput.ValueChanged)
                        .Select(name => $"Hello {name}!")
                };
                this.Outputs.Add(TextOutput);
            }
            static HelloWorldNode()
            {
                Splat.Locator.CurrentMutable.Register(() => new HelloWorldNodeView(), typeof(IViewFor<HelloWorldNode>));
            }
        }





        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            SetCurrentValue(WindowStateProperty, System.Windows.WindowState.Minimized);
        }
    }
}
