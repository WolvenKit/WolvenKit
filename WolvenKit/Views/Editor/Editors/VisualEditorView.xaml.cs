using System.Reactive.Linq;
using System.Windows;
using DynamicData;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using ReactiveUI;
using WolvenKit.Functionality.WKitGlobal.Helpers;

namespace WolvenKit.Views.Editor.VisualEditor
{
    public partial class VisualEditorView
    {
        #region Constructors

        public VisualEditorView()
        {
            InitializeComponent();
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

        // Begin dragging the window
    }
}
