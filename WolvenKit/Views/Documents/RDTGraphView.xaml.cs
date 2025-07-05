using System.Windows;
using System.Windows.Input;
using Nodify;
using ReactiveUI;
using WolvenKit.App.ViewModels.Documents;

namespace WolvenKit.Views.Documents
{
    /// <summary>
    /// Interaction logic for RDTGraphView.xaml
    /// </summary>
    public partial class RDTGraphView : ReactiveUserControl<RDTGraphViewModel>
    {
        public RDTGraphView()
        {
            InitializeComponent();

            // TODO miroiu There's a SplitCommand and DisconnectCommand on the connection that you can bind to in v2.0.0.
            EventManager.RegisterClassHandler(typeof(BaseConnection), MouseLeftButtonDownEvent, new MouseButtonEventHandler(OnConnectionInteraction));
        }

        private void OnConnectionInteraction(object sender, MouseButtonEventArgs e)
        {
            if (sender is BaseConnection ctrl && ctrl.DataContext is ConnectionViewModel connection)
            {
                if (Keyboard.Modifiers == ModifierKeys.Alt)
                {
                    connection.Remove();
                }
                else if (e.ClickCount > 1)
                {
                    connection.Split(e.GetPosition(ctrl) - new Vector(30, 15));
                }
            }
        }
    }
}
