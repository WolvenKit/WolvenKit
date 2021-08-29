using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Converters
{
    public sealed class CNameJsonConverter : JsonConverter<CName>
    {
        public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Text);
        }
    }

    public sealed class CStringJsonConverter : JsonConverter<CString>
    {
        public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Text);
        }
    }


    public class ITypeConverterWithTypeDiscriminator : JsonConverter<IType>
    {
        private readonly IEnumerable<Type> _types;

        public ITypeConverterWithTypeDiscriminator()
        {
            var type = typeof(IType);
            _types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass && !p.IsAbstract)
                .ToList();
        }

        public override IType Read(
            ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            using (var jsonDocument = JsonDocument.ParseValue(ref reader))
            {
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
                var result = (IType)JsonSerializer.Deserialize(jsonObject, type, options);

                return result;
            }

            throw new JsonException();
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
