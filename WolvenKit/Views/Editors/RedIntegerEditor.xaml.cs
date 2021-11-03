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
using WolvenKit.Common.Model.Cr2w;

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


        public int NumberDecimalDigits => GetNumberDecimalDigits();

        private int GetNumberDecimalDigits()
        {
            if (RedInteger != null)
            {
                var redvalue = RedInteger.GetValue();
                if (redvalue != null)
                {
                    if (redvalue is float)
                    {
                        return 8;
                    }
                }
            }

            return 0;
        }

        public double MinValue => GetMinValue();

        private double GetMinValue()
        {
            if (RedInteger != null)
            {
                var redvalue = RedInteger.GetValue();
                if (redvalue != null)
                {
                    return redvalue switch
                    {
                        float => float.MinValue,
                        double => double.MinValue,

                        byte => byte.MinValue,
                        sbyte => sbyte.MinValue,
                        short => short.MinValue,
                        ushort => ushort.MinValue,
                        int => int.MinValue,
                        uint => uint.MinValue,
                        long => long.MinValue,
                        ulong => ulong.MinValue,
                        _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
                    };
                }
            }
            return double.MinValue;
        }

        public double MaxValue => GetMaxValue();

        private double GetMaxValue()
        {
            if (RedInteger != null)
            {
                var redvalue = RedInteger.GetValue();
                if (redvalue != null)
                {
                    return redvalue switch
                    {
                        float => float.MaxValue,
                        double => double.MaxValue,

                        byte => byte.MaxValue,
                        sbyte => sbyte.MaxValue,
                        short => short.MaxValue,
                        ushort => ushort.MaxValue,
                        int => int.MaxValue,
                        uint => uint.MaxValue,
                        long => long.MaxValue,
                        ulong => ulong.MaxValue,
                        _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
                    };
                }
            }
            return double.MinValue;
        }

        public double Value {
            get => GetValueFromRedValue();
            set => SetRedValue(value);
        }

        private void SetRedValue(double value)
        {
            var redvalue = RedInteger.GetValue();
            
            _ = redvalue switch
            {
                float => RedInteger.SetValue((float)value),
                double => RedInteger.SetValue((double)value),

                byte => RedInteger.SetValue((byte)value),
                sbyte => RedInteger.SetValue((sbyte)value),
                short => RedInteger.SetValue((short)value),
                ushort => RedInteger.SetValue((ushort)value),
                int => RedInteger.SetValue((int)value),
                uint => RedInteger.SetValue((uint)value),
                long => RedInteger.SetValue((long)value),
                ulong => RedInteger.SetValue((ulong)value),
                _ => throw new ArgumentOutOfRangeException(nameof(redvalue))
            };

        }

        private double GetValueFromRedValue()
        {
            var redvalue = RedInteger.GetValue();
            return double.Parse(redvalue.ToString());
        }

       

        public IREDIntegerType RedInteger
        {
            get => (IREDIntegerType)this.GetValue(RedIntegerProperty);
            set => this.SetValue(RedIntegerProperty, value);
        }
        public static readonly DependencyProperty RedIntegerProperty = DependencyProperty.Register(
            nameof(RedInteger), typeof(IREDIntegerType), typeof(RedIntegerEditor), new PropertyMetadata(default(IREDIntegerType)));

    }
}
