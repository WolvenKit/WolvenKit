using System;
using System.Collections.Generic;
using System.Linq;
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
using WolvenKit.RED4.Types;

namespace WolvenKit.Views.Editors
{
    /// <summary>
    /// Interaction logic for RedIntegerEditor.xaml
    /// </summary>
    public partial class RedIntegerEditor : UserControl
    {
        public RedIntegerEditor()
        {
            InitializeComponent();
        }

        #region properties

        public IRedInteger RedInteger
        {
            get => (IRedInteger)this.GetValue(RedIntegerProperty);
            set => this.SetValue(RedIntegerProperty, value);
        }
        public static readonly DependencyProperty RedIntegerProperty = DependencyProperty.Register(
            nameof(RedInteger), typeof(IRedInteger), typeof(RedIntegerEditor), new PropertyMetadata(default(IRedInteger)));

        public int NumberDecimalDigits => GetNumberDecimalDigits();

        public double MinValue => GetMinValue();

        public double MaxValue => GetMaxValue();

        public double Value
        {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        #endregion

        #region methods

        private int GetNumberDecimalDigits() => 0;

        private double GetMinValue()
        {
            if (RedInteger != null)
            {
                var redvalue = RedInteger.GetValue();
                if (redvalue != null)
                {
                    return redvalue switch
                    {
                        double => double.MinValue,

                        byte => byte.MinValue,
                        sbyte => sbyte.MinValue,
                        short => short.MinValue,
                        ushort => ushort.MinValue,
                        int => int.MinValue,
                        uint => uint.MinValue,
                        long => long.MinValue,
                        _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
                    };
                }
            }
            return double.MinValue;
        }

        private double GetMaxValue()
        {
            if (RedInteger != null)
            {
                var redvalue = RedInteger.GetValue();
                if (redvalue != null)
                {
                    return redvalue switch
                    {
                        double => double.MaxValue,

                        byte => byte.MaxValue,
                        sbyte => sbyte.MaxValue,
                        short => short.MaxValue,
                        ushort => ushort.MaxValue,
                        int => int.MaxValue,
                        uint => uint.MaxValue,
                        long => long.MaxValue,
                        _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
                    };
                }
            }
            return double.MinValue;
        }

        private void SetRedValue(double value)
        {
            var redvalue = RedInteger.GetValue();

            _ = redvalue switch
            {
                double => RedInteger.SetValue((double)value),

                byte => RedInteger.SetValue((byte)value),
                sbyte => RedInteger.SetValue((sbyte)value),
                short => RedInteger.SetValue((short)value),
                ushort => RedInteger.SetValue((ushort)value),
                int => RedInteger.SetValue((int)value),
                uint => RedInteger.SetValue((uint)value),
                long => RedInteger.SetValue((long)value),
                _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
            };

        }

        private double GetValueFromRedValue()
        {
            var redvalue = RedInteger.GetValue();
            var valstr = redvalue.ToString();
            var dbl = double.Parse(valstr);
            return dbl;
        }

        #endregion
    }
}
