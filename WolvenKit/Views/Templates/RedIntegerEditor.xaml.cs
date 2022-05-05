using System;
using System.Windows;
using System.Windows.Controls;
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
            get => (IRedInteger)GetValue(RedIntegerProperty);
            set => SetValue(RedIntegerProperty, value);
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
                    CFloat => float.MinValue,
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
                    CFloat => float.MaxValue,
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
                case CFloat:
                    SetCurrentValue(RedIntegerProperty, (CFloat)value);
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
            CUInt8 uint64 => uint64,
            CInt8 uint64 => uint64,
            CInt16 uint64 => uint64,
            CUInt16 uint64 => uint64,
            CInt32 uint64 => uint64,
            CUInt32 uint64 => uint64,
            CInt64 uint64 => uint64,
            CFloat uint64 => uint64,
            _ => throw new ArgumentOutOfRangeException(nameof(RedInteger)),
        };

        #endregion
    }
}
