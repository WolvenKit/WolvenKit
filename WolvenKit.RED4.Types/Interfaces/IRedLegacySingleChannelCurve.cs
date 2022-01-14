using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public interface IRedLegacySingleChannelCurve : IList<IRedCurvePoint>, IRedType
    {
        public string ElementType { get; }
        public Enums.EInterpolationType InterpolationType { get; set; }
        public Enums.ESegmentsLinkType LinkType { get; set; }

        public IEnumerable<IRedCurvePoint> GetCurvePoints();

        public void Add(float point, object value);
    }

    public interface IRedLegacySingleChannelCurve<T> : IRedLegacySingleChannelCurve, IRedType<T>, IRedGenericType<T> where T : IRedType
    {
        public void Add(float point, T value);
    }

    public interface IRedCurvePoint
    {
        public float GetPoint();
        public void SetPoint(float point);

        public IRedType GetValue();
        public void SetValue(object value);
    }

    public interface IRedCurvePoint<T> : IRedCurvePoint, IRedType<T> where T : IRedType
    {
        public float Point { get; set; }
        public T Value { get; set; }
    }
}
