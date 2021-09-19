using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WolvenKit.RED4.Types
{
    public class CurvePoint<T> : IRedCurvePoint<T>, IEquatable<CurvePoint<T>> where T : IRedType
    {
        public float Point { get; set; }
        public T Value { get; set; }


        public float GetPoint() => Point;
        public void SetPoint(float point) => Point = point;

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
        public ushort Tail { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is CLegacySingleChannelCurve<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CLegacySingleChannelCurve<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.SequenceEqual(other) && Tail.Equals(other.Tail);
        }

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Tail.GetHashCode());
    }
}
