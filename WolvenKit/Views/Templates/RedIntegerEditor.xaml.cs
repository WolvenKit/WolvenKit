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
using WolvenKit.RED4.Types.Exceptions;

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
                return RedInteger switch
                {
                    CDouble => double.MinValue,

                    CUInt8 => byte.MinValue,
                    CInt8 => sbyte.MinValue,
                    CInt16 => short.MinValue,
                    CUInt16 => ushort.MinValue,
                    CInt32 => int.MinValue,
                    CUInt32 => uint.MinValue,
                    CInt64 => long.MinValue,
                    _ => throw new ArgumentOutOfRangeException(nameof(RedInteger))
                };
            }
            return double.MinValue;
        }

        private double GetMaxValue()
        {
            if (RedInteger != null)
            {
                return RedInteger switch
                {
                    CDouble => double.MaxValue,

                    CUInt8 => byte.MaxValue,
                    CInt8 => sbyte.MaxValue,
                    CInt16 => short.MaxValue,
                    CUInt16 => ushort.MaxValue,
                    CInt32 => int.MaxValue,
                    CUInt32 => uint.MaxValue,
                    CInt64 => long.MaxValue,
                    _ => throw new ArgumentOutOfRangeException(nameof(RedInteger))
                };
            }
            return double.MinValue;
        }

        private void SetRedValue(double value)
        {
            switch (RedInteger)
            {
                case CDouble:
                    SetCurrentValue(RedIntegerProperty, (CDouble)value);
                    break;
                case CUInt8:
                    SetCurrentValue(RedIntegerProperty, (CUInt8)value);
                    break;
                case CInt8:
                    SetCurrentValue(RedIntegerProperty, (CInt8)value);
                    break;
                case CInt16:
                    SetCurrentValue(RedIntegerProperty, (CInt16)value);
                    break;
                case CUInt16:
                    SetCurrentValue(RedIntegerProperty, (CUInt16)value);
                    break;
                case CInt32:
                    SetCurrentValue(RedIntegerProperty, (CInt32)value);
                    break;
                case CUInt32:
                    SetCurrentValue(RedIntegerProperty, (CUInt32)value);
                    break;
                case CInt64:
                    SetCurrentValue(RedIntegerProperty, (CInt64)value);
                    break;
            }

        }

        private double GetValueFromRedValue() => RedInteger switch
        {
            CDouble cruid => (double)cruid,
            CUInt8 uint64 => (double)uint64,
            CInt8 uint64 => (double)uint64,
            CInt16 uint64 => (double)uint64,
            CUInt16 uint64 => (double)uint64,
            CInt32 uint64 => (double)uint64,
            CUInt32 uint64 => (double)uint64,
            CInt64 uint64 => (double)uint64,
            _ => throw new ArgumentOutOfRangeException(nameof(RedInteger)),
        };

        #endregion
    }
}
