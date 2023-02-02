#define USEYAML

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Modkit.RED4.Serialization.json;
using WolvenKit.Modkit.RED4.Serialization.yaml;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.Types;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using Activator = System.Activator;

namespace WolvenKit.Modkit.RED4.Serialization
{
    public static class Serialization
    {
        public sealed class Yaml
        {
            public static string SerializeYaml(TweakDocument tweakDocument)
            {
                var serializer = new SerializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .WithTypeConverter(new TweakTypeConverter())
                    .Build();
                return serializer.Serialize(tweakDocument);
            }


            public static TweakDocument DeserializeYaml(string yaml)
            {
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .WithTypeConverter(new TweakTypeConverter())
                    .Build();

                return deserializer.Deserialize<TweakDocument>(yaml);
            }
        }


        public sealed class Json
        {
            private static readonly JsonSerializerOptions s_options = new()
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

                    new CResourceConverterFactory(),
                }

            };

            private static string SerializeJson(Dictionary<string, IRedType> dict) => JsonSerializer.Serialize(dict, s_options);

            //private static Dictionary<string, IRedType> DeserializeJson(string text) => JsonSerializer.Deserialize<Dictionary<string, IRedType>>(text, s_options);

            /// <summary>
            /// Tries to convert the specified string representation to its IType equivalent.
            /// </summary>
            /// <param name="type">Type of the value to convert.</param>
            /// <param name="value">A json string containing the value to convert.</param>
            /// <param name="flat"></param>
            /// <returns>true if value was converted successfully; otherwise, false.</returns>
            public static bool TryParseJsonFlat(string type, string value, out IRedType? flat)
            {
                flat = null;

                // parse type
                if (!Enum.TryParse<ETweakType>(type, out var enumType))
                {
                    // try other types
                    if (!Enum.TryParse<ERedType>(type, out var renumType))
                    {
                        return false;
                    }

                    enumType = (ETweakType)renumType;
                }

                var jsonvalue = value;
                // parse value
                // some pretty input helpers
                switch (enumType)
                {
                    case ETweakType.CName:
                    case ETweakType.CString:
                    case ETweakType.CResource:
                        if (!jsonvalue.StartsWith('\"'))
                        {
                            jsonvalue = $"\"{jsonvalue}";
                        }
                        if (!jsonvalue.EndsWith('\"'))
                        {
                            jsonvalue = $"{jsonvalue}\"";
                        }

                        jsonvalue = jsonvalue.Replace("\\", "\\\\");
                        break;
                    case ETweakType.CColor:
                    case ETweakType.CEulerAngles:
                    case ETweakType.CQuaternion:
                    case ETweakType.CVector2:
                    case ETweakType.CVector3:
                        if (!jsonvalue.StartsWith('['))
                        {
                            jsonvalue = $"[{jsonvalue}";
                        }
                        if (!jsonvalue.EndsWith(']'))
                        {
                            jsonvalue = $"{jsonvalue}]";
                        }
                        break;
                    case ETweakType.TweakDBID:
                    case ETweakType.CFloat:
                    case ETweakType.CBool:
                    case ETweakType.CUint8:
                    case ETweakType.CUint16:
                    case ETweakType.CUint32:
                    case ETweakType.CUint64:
                    case ETweakType.CInt8:
                    case ETweakType.CInt16:
                    case ETweakType.CInt32:
                    case ETweakType.CInt64:
                    case ETweakType.LocKey:
                    default:
                        break;
                }

                if (!TryParseJsonFlat(GetTypeFromEnum(enumType), jsonvalue, out var ivalue))
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
            private static bool TryParseJsonFlat(Type type, string value, out IRedType? result)
            {
                if (value == null)
                {
                    result = null;
                    return false;
                }

                try
                {
                    var obj = JsonSerializer.Deserialize(value, type, s_options);
                    if (obj is not IRedType ivalue)
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string Serialize(TweakDocument doc) =>
#if USEYAML
            Yaml.SerializeYaml(doc);
#else
            return SerializeJson(doc);
#endif



        /// <summary>
        /// Tries to convert a list of  string representation of a logical value to its IType equivalent.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static bool Deserialize(string text, out TweakDocument dictionary)
        {
#if USEYAML
            dictionary = Yaml.DeserializeYaml(text);
#else
            dictionary = DeserializeJson(text);
#endif
            return true;
        }

        public static ETweakType GetEnumFromType(Type t)
        {
            var typename = t.Name;
            if (typename == "CResourceAsyncReference`1")
            {
                typename = "CResource";
            }

            if (!Enum.TryParse<ETweakType>(typename, out var type))
            {
                throw new ArgumentOutOfRangeException(nameof(t));
            }

            return type;
        }


        /// <summary>
        /// Get the runtime type from enum
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Type GetTypeFromEnum(ETweakType enumType)
            => enumType switch
            {
                ETweakType.CName => typeof(CName),
                ETweakType.CString => typeof(CString),
                ETweakType.TweakDBID => typeof(TweakDBID),
                ETweakType.CResource => typeof(CResourceAsyncReference<CResource>),
                ETweakType.CFloat => typeof(CFloat),
                ETweakType.CBool => typeof(CBool),
                ETweakType.CUint8 => typeof(CUInt8),
                ETweakType.CUint16 => typeof(CUInt16),
                ETweakType.CUint32 => typeof(CUInt32),
                ETweakType.CUint64 => typeof(CUInt64),
                ETweakType.CInt8 => typeof(CInt8),
                ETweakType.CInt16 => typeof(CInt16),
                ETweakType.CInt32 => typeof(CInt32),
                ETweakType.CInt64 => typeof(CInt64),
                ETweakType.CColor => typeof(CColor),
                ETweakType.CEulerAngles => typeof(EulerAngles),
                ETweakType.CQuaternion => typeof(Quaternion),
                ETweakType.CVector2 => typeof(Vector2),
                ETweakType.CVector3 => typeof(Vector3),
                ETweakType.LocKey => typeof(gamedataLocKeyWrapper),
                _ => throw new ArgumentOutOfRangeException(nameof(enumType))
            };

        private static string? GetTypeStrFromRedTypeStr(string redtype)
        {
            if (!Enum.TryParse<ERedType>(redtype.Replace(":", ""), out var type))
            {
                return null;
            }

            var tweakType = (ETweakType)type;
            return tweakType.ToString();
        }

        public static Type? GetTypeFromRedTypeStr(string? redtype)
        {
            if (string.IsNullOrEmpty(redtype))
            {
                throw new ArgumentNullException(nameof(redtype));
            }

            var types = Enum.GetValues<ETweakType>().Select(GetTypeFromEnum).ToList();

            var type = types.FirstOrDefault(x => x.Name == redtype);
            if (type == null)
            {
                // check simple type
                var wtype = GetTypeStrFromRedTypeStr(redtype);
                if (!string.IsNullOrEmpty(wtype))
                {
                    if (wtype == "CResource")
                    {
                        wtype = "CResourceAsyncReference`1";
                    }

                    type = types.FirstOrDefault(x => x.Name == wtype);
                    return type;
                }

                // check array type
                var splits = redtype.Split(':');
                if (splits.Length > 1 && splits[0].Equals("array"))
                {
                    var innertype = GetTypeFromRedTypeStr(redtype.Replace("array:", ""));
                    if (innertype == null)
                    {
                        throw new InvalidDataException();
                    }
                    var outer = Activator.CreateInstance(
                        typeof(CArray<>).MakeGenericType(innertype),
                        BindingFlags.Instance | BindingFlags.Public,
                        binder: null,
                        args: null,
                        culture: null);
                    if (outer == null)
                    {
                        throw new InvalidDataException();
                    }
                    return outer.GetType();
                }
                else
                {
                    throw new InvalidDataException();
                }
            }

            return type;
        }
    }
}
