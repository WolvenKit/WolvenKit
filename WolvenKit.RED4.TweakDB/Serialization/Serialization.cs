#define USEYAML

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.TweakDB.Serialization.yaml;
using WolvenKit.RED4.TweakDB.Types;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public sealed class TweakRecord
    {
        public string Type { get; set; }
        public string Inherits { get; set; }
        public Dictionary<string, IType> Members { get; set; } = new();

        public override string ToString() => $"[:{Inherits}] {string.Join(',', Members.Keys)}";
    }

    public sealed class TweakDocument
    {
        public Dictionary<string, IType> Flats { get; set; } = new();
        public Dictionary<string, TweakRecord> Groups { get; set; } = new();
    }

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

                }

            };

            private static string SerializeJson(Dictionary<string, IType> dict) => JsonSerializer.Serialize(dict, Serialization.Json.s_options);

            private static Dictionary<string, IType> DeserializeJson(string text) => JsonSerializer.Deserialize<Dictionary<string, IType>>(text, Serialization.Json.s_options);

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
                        if (!jsonvalue.StartsWith('\"'))
                        {
                            jsonvalue = $"\"{jsonvalue}";
                        }
                        if (!jsonvalue.EndsWith('\"'))
                        {
                            jsonvalue = $"{jsonvalue}\"";
                        }
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
                }

                if (!Serialization.Json.TryParseJsonFlat(Serialization.GetTypeFromEnum(enumType), jsonvalue, out var ivalue))
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
            private static bool TryParseJsonFlat(Type type, string value, out IType result)
            {
                if (value == null)
                {
                    result = null;
                    return false;
                }

                try
                {
                    var obj = JsonSerializer.Deserialize(value, type, s_options);
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public static string Serialize(TweakDocument doc)
        {
#if USEYAML
            return Yaml.SerializeYaml(doc);
#else
            return SerializeJson(doc);
#endif
        }


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
                ETweakType.CFloat => typeof(CFloat),
                ETweakType.CBool => typeof(CBool),
                ETweakType.CUint8 => typeof(CUint8),
                ETweakType.CUint16 => typeof(CUint16),
                ETweakType.CUint32 => typeof(CUint32),
                ETweakType.CUint64 => typeof(CUint64),
                ETweakType.CInt8 => typeof(CInt8),
                ETweakType.CInt16 => typeof(CInt16),
                ETweakType.CInt32 => typeof(CInt32),
                ETweakType.CInt64 => typeof(CInt64),
                ETweakType.CColor => typeof(CColor),
                ETweakType.CEulerAngles => typeof(CEulerAngles),
                ETweakType.CQuaternion => typeof(CQuaternion),
                ETweakType.CVector2 => typeof(CVector2),
                ETweakType.CVector3 => typeof(CVector3),
                _ => throw new ArgumentOutOfRangeException(nameof(enumType))
            };

        private static string GetTypeStrFromRedTypeStr(string redtype)
        {
            if (!Enum.TryParse<ERedType>(redtype, out var type))
            {
                return null;
            }

            var tweakType = (ETweakType)type;
            return tweakType.ToString();
        }

        public static Type GetTypeFromRedTypeStr(string redtype)
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
                    type = types.FirstOrDefault(x => x.Name == wtype);
                    return type;
                }

                // check array type
                var splits = redtype.Split(':');
                if (splits.Length == 2 && splits[0].Equals("array"))
                {
                    var innertype = GetTypeFromRedTypeStr(splits[1]);
                    var outer = Activator.CreateInstance(
                        typeof(CArray<>).MakeGenericType(
                            new Type[] { innertype }),
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
