using System.Reactive.Linq;
using System.Windows;
using DynamicData;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using ReactiveUI;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.MVVM.Views.Components.Editors.VisualEditor.Nodes;
using WolvenKit.Views.Editors.VisualEditor.Nodes;

namespace WolvenKit.MVVM.Views.Components.Editors.VisualEditor
{
    public partial class VisualEditorView
    {


        public VisualEditorView()
        {
            InitializeComponent();


            //Create a new viewmodel for the NetworkView
            var network = new NetworkViewModel();

            //Create the node for the first node, set its name and add it to the network.
            var innode = new IN_Node_Class();
            innode.Name = "IN";
            network.Nodes.Add(innode);


            var outnode = new OUT_Node_Class();
            outnode.Name = "OUT";
            network.Nodes.Add(outnode);

        



            //Assign the viewmodel to the view.
            networkView.ViewModel = network;


        }

        public class IN_Node_Class : NodeViewModel
        {
            public ValueNodeInputViewModel<string> NameInput { get; }
            public ValueNodeOutputViewModel<string> TextOutput { get; }

            public IN_Node_Class()
            {       

                TextOutput = new ValueNodeOutputViewModel<string>()
                {
                    Name = "Input",
                    Value = this.WhenAnyObservable(vm => vm.NameInput.ValueChanged)
                        .Select(name => $"Hello {name}!")
                };
                this.Outputs.Add(TextOutput);
            }
            static IN_Node_Class()
            {
                Splat.Locator.CurrentMutable.Register(() => new IN_Node(), typeof(IViewFor<IN_Node_Class>));
            }
        }


        public class OUT_Node_Class : NodeViewModel
        {
            public ValueNodeInputViewModel<string> NameInput { get; }
            public ValueNodeOutputViewModel<string> TextOutput { get; }

            public OUT_Node_Class()
            {

                NameInput = new ValueNodeInputViewModel<string>()
                {
                    Name = "Output",
             
                };
                this.Inputs.Add(NameInput);
            }
            static OUT_Node_Class()
            {
                Splat.Locator.CurrentMutable.Register(() => new OUT_Node(), typeof(IViewFor<OUT_Node_Class>));
            }
        }




        private void DraggableTitleBar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void DataWindow_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (this.IsVisible )
            {
                DiscordHelper.SetDiscordRPCStatus("Visual Editor");
            }
        }
    }
}
