using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Extensions
{
    public static class TypeExtensions
    {
        public static CColor ParseCColor(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 4)
            {
                throw new FormatException();
            }

            var red = byte.Parse(splits[0]);
            var green = byte.Parse(splits[1]);
            var blue = byte.Parse(splits[2]);
            var alpha = byte.Parse(splits[2]);

            return new CColor
            {
                Red = red,
                Green = green,
                Blue = blue,
                Alpha = alpha
            };
        }

        public static CEulerAngles ParseCEulerAngles(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 3)
            {
                throw new FormatException();
            }

            var pitch = float.Parse(splits[0]);
            var yaw = float.Parse(splits[1]);
            var roll = float.Parse(splits[2]);

            return new CEulerAngles
            {
                Pitch = pitch,
                Yaw = yaw,
                Roll = roll
            };
        }

        public static CQuaternion ParseCQuaternion(string valueString)
        {
            // parse this: 6.7,5,8.333,0
            var splits = valueString.Split(',');
            if (splits.Length != 4)
            {
                throw new FormatException();
            }

            var i = float.Parse(splits[0]);
            var j = float.Parse(splits[1]);
            var k = float.Parse(splits[2]);
            var r = float.Parse(splits[2]);

            return new CQuaternion
            {
                I = i,
                J = j,
                K = k,
                R = r
            };
        }

        public static CVector2 ParseCVector2(string valueString)
        {
            // parse this: 6.7,5
            var splits = valueString.Split(',');
            if (splits.Length != 2)
            {
                throw new FormatException();
            }

            var x = float.Parse(splits[0]);
            var y = float.Parse(splits[1]);

            return new CVector2
            {
                X = x,
                Y = y,
            };
        }

        public static CVector3 ParseCVector3(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 3)
            {
                throw new FormatException();
            }

            var x = float.Parse(splits[0]);
            var y = float.Parse(splits[1]);
            var z = float.Parse(splits[2]);

            return new CVector3
            {
                X = x,
                Y = y,
                Z = z
            };
        }
    }
}
