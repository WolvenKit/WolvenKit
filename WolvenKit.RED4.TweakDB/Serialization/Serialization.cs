using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.TweakDB.Types;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public static class Serialization
    {
        public sealed class FlatDto
        {
            public string Type { get; set; }
            public string ValueString { get; set; }
        }

        public static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = false,
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

        public static string Serialize(Dictionary<string, IType> dict)
        {
            return SerializeJson(dict);
            //return SerializeYaml(dict);
        }

        private static string SerializeJson(Dictionary<string, IType> dict) => JsonSerializer.Serialize(dict, Serialization.Options);

        private static string SerializeYaml(Dictionary<string, IType> dict)
        {
            var flatsDict = dict.ToDictionary(x => x.Key, y => new FlatDto()
            {
                Type = y.Value.Name,
                ValueString = JsonSerializer.Serialize((object)y.Value, Serialization.Options)
            });

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(flatsDict);

            return yaml;
        }

        /// <summary>
        /// Tries to convert a list of  string representation of a logical value to its IType equivalent.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static bool Deserialize(string text, out Dictionary<string, IType> dictionary)
        {
            dictionary = null;
            try
            {
                dictionary = DeserializeJson(text);
                //dictionary = DeserializeYaml(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static Dictionary<string, IType> DeserializeJson(string text) => JsonSerializer.Deserialize<Dictionary<string, IType>>(text, Options);

        private static Dictionary<string, IType> DeserializeYaml(string text)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var d = deserializer.Deserialize<Dictionary<string, FlatDto>>(text);

            return d.ToDictionary(x => x.Key, y =>
            {
                if (!TryParseJsonFlat(y.Value.Type, y.Value.ValueString, out var itype))
                {
                    throw new SerializationException();
                }
                return itype;
            });

        }

        /// <summary>
        /// Tries to convert the specified string representation to its IType equivalent.
        /// </summary>
        /// <param name="type">Type of the value to convert.</param>
        /// <param name="value">A json string containing the value to convert.</param>
        /// <param name="flat"></param>
        /// <returns>true if value was converted successfully; otherwise, false.</returns>
        public static bool TryParseJsonFlat(string type, string value, out IType flat)
        {
            flat = null;

            // parse type
            if (!Enum.TryParse<EIType>(type, out var enumType))
            {
                // try other types
                if (!Enum.TryParse<ERIType>(type, out var renumType))
                {
                    return false;
                }

                enumType = (EIType)renumType;
            }

            var jsonvalue = value;
            // parse value
            // some pretty input helpers
            switch (enumType)
            {
                case EIType.CName:
                case EIType.CString:
                    if (!jsonvalue.StartsWith('\"'))
                    {
                        jsonvalue = $"\"{jsonvalue}";
                    }
                    if (!jsonvalue.EndsWith('\"'))
                    {
                        jsonvalue = $"{jsonvalue}\"";
                    }
                    break;
                case EIType.CColor:
                case EIType.CEulerAngles:
                case EIType.CQuaternion:
                case EIType.CVector2:
                case EIType.CVector3:
                    if (!jsonvalue.StartsWith('['))
                    {
                        jsonvalue = $"[{jsonvalue}";
                    }
                    if (!jsonvalue.EndsWith(']'))
                    {
                        jsonvalue = $"{jsonvalue}]";
                    }
                    break;
            }

            if (!Serialization.TryParseJsonFlat(Serialization.GetTypeFromEnum(enumType), jsonvalue, out var ivalue))
            {
                return false;
            }

            flat = ivalue;
            return true;
        }

        /// <summary>
        /// Tries to convert the specified string representation to its IType equivalent.
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
