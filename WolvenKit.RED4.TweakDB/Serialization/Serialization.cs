using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public static class Serialization
    {
        private static readonly JsonSerializerOptions s_options = new()
        {
            WriteIndented = true,
            Converters =
                {
                    new ITypeConverterWithTypeDiscriminator(),
                    new JsonStringEnumConverter(),

                    new CNameJsonConverter(),
                    new CStringJsonConverter(),

                    new CFloatJsonConverter(),
                    new CBoolJsonConverter(),

                    new JsonConverterCUint8(),
                    new JsonConverterCUint16(),
                    new JsonConverterCUint32(),
                    new JsonConverterCUint64(),
                    new JsonConverterCInt8(),
                    new JsonConverterCInt16(),
                    new JsonConverterCInt32(),
                    new JsonConverterCInt64(),  
                        
                }

        };

        public static bool TryParseJsonFlats(string json, out Dictionary<string, IType> dictionary)
        {
            dictionary = new Dictionary<string, IType>();
            try
            {
                var dict = JsonSerializer.Deserialize<Dictionary<string, IType>>(json, s_options);
               
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool TryParseValue(EIType type, string input, out IType variable)
        {
            try
            {
                object obj = null;
                switch (type)
                {
                    case EIType.CName:
                        obj = (CName)input;
                        break;
                    case EIType.CString:
                        obj = (CString)input;
                        break;
                    case EIType.CFloat:
                        obj = (CFloat)float.Parse(input);
                        break;
                    case EIType.CBool:
                        obj = (CBool)bool.Parse(input);
                        break;
                    case EIType.CUint8:
                        obj = (CUint8)byte.Parse(input);
                        break;
                    case EIType.CUint16:
                        obj = (CUint16)ushort.Parse(input);
                        break;
                    case EIType.CUint32:
                        obj = (CUint32)uint.Parse(input);
                        break;
                    case EIType.CUint64:
                        obj = (CUint64)ulong.Parse(input);
                        break;
                    case EIType.CInt8:
                        obj = (CInt8)sbyte.Parse(input);
                        break;
                    case EIType.CInt16:
                        obj = (CInt16)short.Parse(input);
                        break;
                    case EIType.CInt32:
                        obj = (CInt32)int.Parse(input);
                        break;
                    case EIType.CInt64:
                        obj = (CInt64)long.Parse(input);
                        break;
                    //case EIType.CColor:
                    //    value = CColor.Parse(ValueString);
                    //    break;
                    //case EIType.CEulerAngles:
                    //    value = CEulerAngles.Parse(ValueString);
                    //    break;
                    //case EIType.CQuaternion:
                    //    value = CQuaternion.Parse(ValueString);
                    //    break;
                    //case EIType.CVector2:
                    //    value = CVector2.Parse(ValueString);
                    //    break;
                    //case EIType.CVector3:
                    //    value = CVector3.Parse(ValueString);
                    //    break;
                    default:
                        break;
                }

                // parse Value
                if (obj is not IType ivalue)
                {
                    variable = null;
                    return false;
                }

                variable = ivalue;
                return true;
            }
            catch (Exception)
            {
                variable = null;
                return false;
            }
        }


    }
}
