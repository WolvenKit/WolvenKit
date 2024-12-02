namespace WolvenKit.RED4.Types;

public interface IRedLegacySingleChannelCurve : IList<IRedCurvePoint>, IRedType
{
    public Type ElementType { get; }
    public string RedElementType { get; }
    public Enums.EInterpolationType InterpolationType { get; set; }
    public Enums.ESegmentsLinkType LinkType { get; set; }

    public IEnumerable<IRedCurvePoint> GetCurvePoints();

    public void Add(CFloat point, object value);
}

public interface IRedLegacySingleChannelCurve<T> : IRedLegacySingleChannelCurve, IRedType<T>, IRedGenericType<T> where T : IRedType
{
    public void Add(CFloat point, T value);
}

public interface IRedCurvePoint : IRedCloneable
{
    public CFloat GetPoint();
    public void SetPoint(CFloat point);

    public IRedType GetValue();
    public void SetValue(object value);
}

public interface IRedCurvePoint<T> : IRedCurvePoint, IRedType<T> where T : IRedType
{
    public CFloat Point { get; set; }
    public T Value { get; set; }
}