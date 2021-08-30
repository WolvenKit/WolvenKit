using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedLegacySingleChannelCurve : IList<IRedCurvePoint>
    {
        public uint Tail { get; set; }
    }

    public interface IRedLegacySingleChannelCurve<T> : IRedPrimitive<T>, IRedLegacySingleChannelCurve where T : IRedType
    {
        public List<CurvePoint<T>> Elements { get; set; }
}

    public interface IRedCurvePoint
    {
        public float GetPoint();
        public void SetPoint(float point);

        public object GetValue();
        public void SetValue(object value);
    }

    public interface IRedCurvePoint<T> : IRedPrimitive<T>, IRedCurvePoint where T : IRedType
    {
        public float Point { get; set; }
        public T Value { get; set; }
    }
}
