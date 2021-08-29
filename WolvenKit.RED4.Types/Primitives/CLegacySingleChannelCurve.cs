using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public class CurvePoint<T> : IRedCurvePoint<T> where T : IRedType
    {
        public float Point { get; set; }
        public T Value { get; set; }


        public void SetPoint(float point) => Point = point;
        public void SetValue(object value) => Value = (T)value;
    }

    public class CLegacySingleChannelCurve<T> : IRedLegacySingleChannelCurve<T> where T : IRedType
    {
        public List<CurvePoint<T>> Elements { get; set; } = new();

        public void Add(object value) => Elements.Add((CurvePoint<T>)value);
    }
}
