using System;
using System.Collections.Generic;
using System.Linq;
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

            using var jsonDocument = JsonDocument.ParseValue(ref reader);
            if (!jsonDocument.RootElement.TryGetProperty("Type", out var typeProperty))
            {
                throw new JsonException();
            }

            var type = _types.FirstOrDefault(x => x.Name == typeProperty.GetString());
            if (type == null)
            {
                var wtype = GetWType(typeProperty.GetString());
                type = !string.IsNullOrEmpty(wtype)
                    ? _types.FirstOrDefault(x => x.Name == wtype)
                    : throw new JsonException();
            }

            if (!jsonDocument.RootElement.TryGetProperty("Value", out var valueProperty))
            {
                throw new JsonException();
            }

            var jsonObject = valueProperty.GetRawText();
            if (type == null)
            {
                throw new JsonException();
            }

            var result = (IType)JsonSerializer.Deserialize(jsonObject, type, options);

            return result;
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
            JsonSerializer.Serialize(writer, (object)value, options);
            writer.WriteEndObject();
        }
    }
}
