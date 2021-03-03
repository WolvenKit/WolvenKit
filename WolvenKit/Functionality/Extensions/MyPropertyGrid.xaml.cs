using HandyControl.Controls;

namespace WolvenKit.Functionality.Extensions
{
    /// <summary>
    /// Interaction logic for MyPropertyGrid.xaml
    /// </summary>
    public partial class MyPropertyGrid : PropertyGrid
    {
        #region Constructors

        public MyPropertyGrid()
        {
            InitializeComponent();
        }

        #endregion Constructors



        #region Properties

        public override PropertyResolver PropertyResolver => new MyPropertyResolver();

        #endregion Properties
    }
}
