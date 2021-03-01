using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HandyControl.Controls;
using DatePicker = HandyControl.Controls.DatePicker;
using TimePicker = HandyControl.Controls.TimePicker;

namespace WolvenKit.Extensions
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
