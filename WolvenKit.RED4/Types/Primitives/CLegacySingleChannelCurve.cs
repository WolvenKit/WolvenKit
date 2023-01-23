namespace WolvenKit.RED4.Types;

public class CurvePoint<T> : IRedCurvePoint<T>, IEquatable<CurvePoint<T>> where T : IRedType
{
    public CFloat Point { get; set; }
    public T Value { get; set; }


    public CFloat GetPoint() => Point;
    public void SetPoint(CFloat point) => Point = point;

    public IRedType GetValue() => Value;
    public void SetValue(object value) => Value = (T)value;

    public bool Equals(CurvePoint<T> other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return Point.Equals(other.Point) && EqualityComparer<T>.Default.Equals(Value, other.Value);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CurvePoint<T>)obj);
    }

    public override int GetHashCode() => HashCode.Combine(Point, Value);
}

[RED("curveData")]
public class CLegacySingleChannelCurve<T> : List<IRedCurvePoint>, IRedLegacySingleChannelCurve<T>, IEquatable<CLegacySingleChannelCurve<T>> where T : IRedType
{
    public Type ElementType => typeof(T);
    public string RedElementType => RedReflection.GetRedTypeFromCSType(typeof(T));

    public Enums.EInterpolationType InterpolationType { get; set; }
    public Enums.ESegmentsLinkType LinkType { get; set; }


    public IEnumerable<IRedCurvePoint> GetCurvePoints() => this;

    public void Add(CFloat point, object value) => Add(point, (T)value);
    public void Add(CFloat point, T value) => Add(new CurvePoint<T> {Point = point, Value = value});

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((CLegacySingleChannelCurve<T>)obj);
    }

    public bool Equals(CLegacySingleChannelCurve<T> other)
    {
        if (other == null)
        {
            return false;
        }

        return this.SequenceEqual(other) && InterpolationType.Equals(other.InterpolationType) && LinkType.Equals(other.LinkType);
    }

    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), InterpolationType.GetHashCode(), LinkType.GetHashCode());
}