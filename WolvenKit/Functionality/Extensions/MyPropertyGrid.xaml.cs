using HandyControl.Controls;

namespace WolvenKit.Functionality.Extensions
{
    /// <summary>
    /// Interaction logic for MyPropertyGrid.xaml
    /// </summary>
    public partial class MyPropertyGrid : PropertyGrid
    {
        public MyPropertyGrid()
        {
            InitializeComponent();
        }

        public override PropertyResolver PropertyResolver => new MyPropertyResolver();
    }
}
