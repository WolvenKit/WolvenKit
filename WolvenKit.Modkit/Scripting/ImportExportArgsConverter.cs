using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.Scripting;

public class ImportExportArgsConverter : JsonConverter<ImportExportArgs>
{
    public override bool CanConvert(Type typeToConvert) => typeof(ImportExportArgs).IsAssignableFrom(typeToConvert);

    public override ImportExportArgs? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, ImportExportArgs value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        foreach (var propertyInfo in value.GetType().GetProperties())
        {
            var attr = propertyInfo.GetCustomAttribute<WkitScriptAccess>();
            if (attr == null)
            {
                continue;
            }

            writer.WritePropertyName(attr.ScriptName);
            JsonSerializer.Serialize(writer, propertyInfo.GetValue(value), options);
        }

        writer.WriteEndObject();
    }
}