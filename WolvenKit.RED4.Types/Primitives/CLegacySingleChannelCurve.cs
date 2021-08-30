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

        public object GetValue() => Value;
        public void SetValue(object value) => Value = (T)value;


        public override bool Equals(object obj)
        {
            if (obj is CurvePoint<T> cObj)
            {
                return Equals(cObj);
            }

            return false;
        }

        public bool Equals(CurvePoint<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return Point.Equals(other.Point) && Value.Equals(other.Value);
        }
    }

    public class CLegacySingleChannelCurve<T> : List<IRedCurvePoint>, IRedLegacySingleChannelCurve<T>, IEquatable<CLegacySingleChannelCurve<T>> where T : IRedType
    {
        public uint Tail { get; set; }


        public override bool Equals(object obj)
        {
            if (obj is CLegacySingleChannelCurve<T> cObj)
            {
                return Equals(obj);
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
    }
}
