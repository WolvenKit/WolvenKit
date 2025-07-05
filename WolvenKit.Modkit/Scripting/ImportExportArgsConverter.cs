using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.Scripting;

public class ImportExportArgsConverter : JsonConverter<AbstractGlobalArgs>
{
    private readonly Dictionary<string, Type> _typeMap = new();

    public override bool CanConvert(Type typeToConvert) => typeof(AbstractGlobalArgs).IsAssignableFrom(typeToConvert);

    private void GenerateTypeMap(AbstractGlobalArgs globalArgs)
    {
        foreach (var type in globalArgs.GetTypes())
        {
            _typeMap.Add(type.Name[..^10], type);
        }
    }

    public override AbstractGlobalArgs? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var globalArgs = (AbstractGlobalArgs?)System.Activator.CreateInstance(typeToConvert);
        if (globalArgs == null)
        {
            throw new JsonException();
        }
        GenerateTypeMap(globalArgs);

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                break;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var type = _typeMap[reader.GetString()!];
            var args = globalArgs.Get(type);
            reader.Read();

            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    break;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                var propertyName = reader.GetString()!;
                foreach (var prop in type.GetProperties())
                {
                    if (Attribute.GetCustomAttribute(prop, typeof(WkitScriptAccess)) is WkitScriptAccess scriptAccess && scriptAccess.ScriptName == propertyName)
                    {
                        if (prop.PropertyType.IsEnum)
                        {
                            reader.Read();

                            var enumStr = reader.GetString()!;
                            prop.SetValue(args, Enum.Parse(prop.PropertyType, enumStr));
                        }
                        else
                        {
                            prop.SetValue(args, JsonSerializer.Deserialize(ref reader, prop.PropertyType, options));
                        }
                    }
                }
            }
        }

        return globalArgs;
    }

    public override void Write(Utf8JsonWriter writer, AbstractGlobalArgs value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        foreach (var type in value.GetTypes())
        {
            writer.WritePropertyName(type.Name[..^10]);

            writer.WriteStartObject();

            var args = value.Get(type);
            foreach (var propertyInfo in type.GetProperties())
            {
                var attr = propertyInfo.GetCustomAttribute<WkitScriptAccess>();
                if (attr == null)
                {
                    continue;
                }

                writer.WritePropertyName(attr.ScriptName);

                var propertyValue = propertyInfo.GetValue(args);
                if (propertyValue!.GetType().IsEnum)
                {
                    writer.WriteStringValue($"{(Enum)propertyValue}");
                }
                else
                {
                    JsonSerializer.Serialize(writer, propertyValue, options);
                }
            }

            writer.WriteEndObject();
        }

        writer.WriteEndObject();
    }
}