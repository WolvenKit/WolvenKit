namespace WolvenKit.RED4.Types;

public static class CurvePoint
{
    public static IRedCurvePoint Create(Type innerType)
    {
        switch (innerType.Name)
        {
            case "CFloat":
                return new CurvePoint<CFloat>(0, 0);

            case "HDRColor":
                return new CurvePoint<HDRColor>(0, new HDRColor());

            case "Vector2":
                return new CurvePoint<Vector2>(0, new Vector2());

            case "Vector3":
                return new CurvePoint<Vector3>(0, new Vector3());

            case "Vector4":
                return new CurvePoint<Vector4>(0, new Vector4());

            default:
                throw new NotSupportedException($"{innerType.Name} is not a valid curve value");
        }
    }
}

public class CurvePoint<T> : IRedCurvePoint<T>, IEquatable<CurvePoint<T>> where T : IRedType
{
    public CFloat Point { get; set; }
    public T Value { get; set; }

    public CurvePoint(CFloat point, T value)
    {
        Point = point;
        Value = value;
    }

    public CFloat GetPoint() => Point;
    public void SetPoint(CFloat point) => Point = point;

    public IRedType GetValue() => Value;
    public void SetValue(object value) => Value = (T)value;

    public bool Equals(CurvePoint<T>? other)
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

    public override bool Equals(object? obj)
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

    #region IRedCloneable

    public object ShallowCopy() => MemberwiseClone();

    public object DeepCopy()
    {
        if (Value.GetType().IsValueType)
        {
            return new CurvePoint<T>(Point, Value);
        }

        if (Value is IRedCloneable cloneable)
        {
            return new CurvePoint<T>(Point, (T)cloneable.DeepCopy());
        }

        throw new NotImplementedException();
    }

    #endregion IRedCloneable
}

[RED("curveData")]
public class CLegacySingleChannelCurve<T> : CArrayBase<IRedCurvePoint>, IRedLegacySingleChannelCurve<T>, IEquatable<CLegacySingleChannelCurve<T>> where T : IRedType
{
    public Type ElementType => typeof(T);
    public string RedElementType => RedReflection.GetRedTypeFromCSType(typeof(T));

    public Enums.EInterpolationType InterpolationType { get; set; }
    public Enums.ESegmentsLinkType LinkType { get; set; }


    public IEnumerable<IRedCurvePoint> GetCurvePoints() => this;

    public void Add(CFloat point, object value) => Add(point, (T)value);
    public void Add(CFloat point, T value) => Add(new CurvePoint<T>(point, value));

    public override bool Equals(object? obj)
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

    public bool Equals(CLegacySingleChannelCurve<T>? other)
    {
        if (other == null)
        {
            return false;
        }

        return this.SequenceEqual(other) && InterpolationType.Equals(other.InterpolationType) && LinkType.Equals(other.LinkType);
    }

    public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), InterpolationType.GetHashCode(), LinkType.GetHashCode());

    #region IRedCloneable

    public override object DeepCopy()
    {
        var ret = new CLegacySingleChannelCurve<T>
        {
            InterpolationType = InterpolationType,
            LinkType = LinkType
        };

        foreach (var curvePoint in this)
        {
            ret.Add(curvePoint.DeepCopy());
        }

        return ret;
    }

    #endregion IRedCloneable
}