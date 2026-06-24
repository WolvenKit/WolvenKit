using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion;

public class RedTypeTemplateConverter : JsonConverter<RedTypeTemplate>
{
    private Type? _type;

    public RedTypeTemplateConverter(Type? targetType = null)
    {
        _type = targetType;
    }

    public override RedTypeTemplate? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);

        var root = doc.RootElement;

        if (root.ValueKind != JsonValueKind.Object)
        {
            throw new JsonException("Template file root must be an object");
        }

        if (!root.TryGetProperty(nameof(RedTypeTemplate.FormatVersion), out var formatVersion))
        {
            throw new JsonException("Template file is missing FormatVersion property");
        }

        if (!root.TryGetProperty(nameof(RedTypeTemplate.Data), out var data))
        {
            throw new JsonException("Template file is missing Data property");
        }

        var type = _type;
        if (type is null)
        {
            if (!data.TryGetProperty("$type", out var typeElement) && !data.TryGetProperty("$type", out typeElement))
            {
                throw new JsonException("Template Data property is missing $type property");
            }

            var typeName = typeElement.GetString();
            if (string.IsNullOrWhiteSpace(typeName))
            {
                throw new JsonException("Template Data $type property is empty");
            }

            type = ParseType(typeName);
            if (type is null)
            {
                throw new JsonException($"Template Data contains unknown type '{typeName}'");
            }
        }

        root.TryGetProperty(nameof(RedTypeTemplate.Author), out var author);
        root.TryGetProperty(nameof(RedTypeTemplate.Description), out var description);
        root.TryGetProperty(nameof(RedTypeTemplate.Version), out var version);

        IRedType? deserializedData;
        if (type.IsEnum)
        {
            deserializedData = CEnum.Parse(type, data.GetString() ?? "");
        }
        else
        {
            deserializedData = (IRedType?)RedJsonSerializer.Deserialize(type, data.GetRawText());
        }

        return new RedTypeTemplate
        {
            FormatVersion = formatVersion.GetInt32(),
            Author = GetStringOrDefault(author) ?? "",
            Description = GetStringOrDefault(description) ?? "",
            Version = GetStringOrDefault(version) ?? "",
            Data = deserializedData
        };
    }

    public override void Write(Utf8JsonWriter writer, RedTypeTemplate value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName(nameof(RedTypeTemplate.FormatVersion));
        JsonSerializer.Serialize(writer, value.FormatVersion, options);

        writer.WritePropertyName(nameof(RedTypeTemplate.Author));
        JsonSerializer.Serialize(writer, value.Author, options);

        writer.WritePropertyName(nameof(RedTypeTemplate.Description));
        JsonSerializer.Serialize(writer, value.Description, options);

        writer.WritePropertyName(nameof(RedTypeTemplate.Version));
        JsonSerializer.Serialize(writer, value.Version, options);

        writer.WritePropertyName(nameof(RedTypeTemplate.Data));
        if (value.Data is null)
        {
            writer.WriteNullValue();
        }
        else
        {
            using var dataDoc = JsonDocument.Parse(RedJsonSerializer.Serialize(value.Data));
            dataDoc.RootElement.WriteTo(writer);
        }

        writer.WriteEndObject();
    }

    private static string? GetStringOrDefault(JsonElement element) =>
        element.ValueKind is JsonValueKind.Undefined or JsonValueKind.Null ? null : element.GetString();

    private static Type? ParseType(string typeName) => AppDomain.CurrentDomain
        .GetAssemblies()
        .SelectMany(a => a.GetTypes())
        .FirstOrDefault(t =>
            t.Name == typeName ||
            t.FullName == typeName ||
            t.AssemblyQualifiedName == typeName);
}
