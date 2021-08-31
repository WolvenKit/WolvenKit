using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    /// <summary>
    /// Comverts object implementing the IType interface to a json equivalent
    /// a TypeDiscriminator is used to serialize the type of the object
    /// </summary>
    public class ITypeConverterWithTypeDiscriminator : JsonConverter<IType>
    {
        private readonly IEnumerable<Type> _types;

        public ITypeConverterWithTypeDiscriminator()
        {
            // This is faster than reflection for few types
            _types = Enum.GetValues<EIType>().Select(Serialization.GetTypeFromEnum);

            // otherwise use reflection
            //var type = typeof(IType);
            //_types = assmembly.GetTypes()
            //    .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
            //    .ToList();
        }

        public override bool CanConvert(Type typeToConvert)
        {
            var b = base.CanConvert(typeToConvert);
            return b;
        }

        public override IType Read(
            ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            // get type
            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            if (!jsonDocument.RootElement.TryGetProperty("Type", out var typeProperty))
            {
                throw new JsonException();
            }
            var type = GetRedTypeFromString(typeProperty.GetString());
            if (type == null)
            {
                throw new JsonException();
            }

            // get value
            if (!jsonDocument.RootElement.TryGetProperty("Value", out var valueProperty))
            {
                throw new JsonException();
            }
            var jsonObject = valueProperty.GetRawText();

            // check here for arrays?
            if (IsArray(type))
            {
                var innertype = type.GetGenericArguments()[0];

                var list = Activator.CreateInstance(
                    typeof(List<>).MakeGenericType(
                        new Type[] { innertype }),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: null);

                if (list is null)
                {
                    throw new JsonException();
                }

                var items = JsonSerializer.Deserialize(jsonObject, list.GetType(), options);


                var array = (IArray)Activator.CreateInstance(
                    typeof(CArray<>).MakeGenericType(
                        new Type[] { innertype }),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: null);
                if (array is null)
                {
                    throw new JsonException();
                }
                array.SetItems(items);

                return array is IType o ? o : throw new JsonException();
            }
            else
            {
                return (IType)JsonSerializer.Deserialize(jsonObject, type, options);
            }

        }

        private Type GetRedTypeFromString(string redtype)
        {
            if (string.IsNullOrEmpty(redtype))
            {
                throw new JsonException();
            }

            var type = _types.FirstOrDefault(x => x.Name == redtype);
            if (type == null)
            {
                // check simple type
                var wtype = GetWType(redtype);
                if (!string.IsNullOrEmpty(wtype))
                {
                    type = _types.FirstOrDefault(x => x.Name == wtype);
                    return type;
                }

                // check array type
                var splits = redtype.Split(':');
                if (splits.Length == 2 && splits[0].Equals("array"))
                {
                    var innertype = GetRedTypeFromString(splits[1]);
                    var outer =  Activator.CreateInstance(
                        typeof(CArray<>).MakeGenericType(
                            new Type[] { innertype }),
                        BindingFlags.Instance | BindingFlags.Public,
                        binder: null,
                        args: null,
                        culture: null);
                    if (outer == null)
                    {
                        throw new JsonException();
                    }
                    return outer.GetType();
                }
                else
                {
                    throw new JsonException();
                }
            }

            return type;
        }

        private static bool IsArray(Type type)
        {
            if (type is { IsGenericType: false })
            {
                return false;
            }

            return type != null && type.GetGenericTypeDefinition() == typeof(CArray<>);
        }

        private static string GetWType(string redtype)
        {
            if (!Enum.TryParse<ERIType>(redtype, out var type))
            {
                return null;
            }

            var wtype = (EIType)type;
            return wtype.ToString();
        }

        public override void Write(Utf8JsonWriter writer, IType value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("Type", value.Name);
            writer.WritePropertyName("Value");
            if (IsArray(value.GetType()))
            {
                if (value is not IArray array)
                {
                    throw new JsonException();
                }

                var x = array.GetItems();
                JsonSerializer.Serialize(writer, (object)array.GetItems(), options);
            }
            else
            {
                JsonSerializer.Serialize(writer, (object)value, options);
            }
            writer.WriteEndObject();
        }
    }
}
