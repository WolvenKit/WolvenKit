using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public static class Serialization
    {
        public static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true,
            Converters =
                {
                    new ITypeConverterWithTypeDiscriminator(),
                    new JsonStringEnumConverter(),

                    new CFloatJsonConverter(),
                    new CBoolJsonConverter(),

                    new CUint8JsonConverter(),
                    new CUint16JsonConverter(),
                    new CUint32JsonConverter(),
                    new CUint64JsonConverter(),
                    new CInt8JsonConverter(),
                    new CInt16JsonConverter(),
                    new CInt32JsonConverter(),
                    new CInt64JsonConverter(),

                    new CNameJsonConverter(),
                    new CStringJsonConverter(),
                    new CColorJsonConverter(),
                    new CEulerAnglesJsonConverter(),
                    new CQuaternionJsonConverter(),
                    new CVector2JsonConverter(),
                    new CVector3JsonConverter(),

                }

        };

        /// <summary>
        /// Tries to convert a list of  string representation of a logical value to its IType equivalent.
        /// </summary>
        /// <param name="json"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static bool TryParseJsonFlatsDict(string json, out Dictionary<string, IType> dictionary)
        {
            dictionary = null;
            try
            {
                dictionary = JsonSerializer.Deserialize<Dictionary<string, IType>>(json, Options);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to convert the specified json string representation to its IType equivalent.
        /// </summary>
        /// <param name="type">Type of the value to convert.</param>
        /// <param name="value">A json string containing the value to convert.</param>
        /// <param name="result"></param>
        /// <returns>true if value was converted successfully; otherwise, false.</returns>
        public static bool TryParseJsonFlat(Type type, string value, out IType result)
        {
            if (value == null)
            {
                result = null;
                return false;
            }

            try
            {
                var obj = JsonSerializer.Deserialize(value, type, Options);
                if (obj is not IType ivalue)
                {
                    result = null;
                    return false;
                }

                result = ivalue;
                return true;
            }
            catch (Exception)
            {
                result = null;
                return false;
            }

        }

        /// <summary>
        /// Get the runtime type from enum
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Type GetTypeFromEnum(EIType enumType)
            => enumType switch
            {
                EIType.CName => typeof(CName),
                EIType.CString => typeof(CString),
                EIType.CFloat => typeof(CFloat),
                EIType.CBool => typeof(CBool),
                EIType.CUint8 => typeof(CUint8),
                EIType.CUint16 => typeof(CUint16),
                EIType.CUint32 => typeof(CUint32),
                EIType.CUint64 => typeof(CUint64),
                EIType.CInt8 => typeof(CInt8),
                EIType.CInt16 => typeof(CInt16),
                EIType.CInt32 => typeof(CInt32),
                EIType.CInt64 => typeof(CInt64),
                EIType.CColor => typeof(CColor),
                EIType.CEulerAngles => typeof(CEulerAngles),
                EIType.CQuaternion => typeof(CQuaternion),
                EIType.CVector2 => typeof(CVector2),
                EIType.CVector3 => typeof(CVector3),
                _ => throw new ArgumentOutOfRangeException(nameof(enumType))
            };
    }
}
