#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public class EnumConverterFactory : JsonConverterFactory
{
    private readonly CBitFieldConverter _cBitFieldConverter = new();
    private readonly CEnumConverter _cEnumConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedBitField).IsAssignableFrom(typeToConvert) || typeof(IRedEnum).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedBitField).IsAssignableFrom(typeToConvert))
        {
            return _cBitFieldConverter;
        }

        if (typeof(IRedEnum).IsAssignableFrom(typeToConvert))
        {
            return _cEnumConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class CBitFieldConverter : JsonConverter<IRedBitField>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedBitField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedBitField)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        var enumType = typeToConvert.GetGenericArguments()[0];
        var str = reader.GetString().NotNull();
        return CBitField.Parse(enumType, str);
    }

    public override void Write(Utf8JsonWriter writer, IRedBitField value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToBitFieldString());
}

public class CEnumConverter : JsonConverter<IRedEnum>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedEnum)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }

        var enumType = typeToConvert.GetGenericArguments()[0];
        var str = reader.GetString().NotNull();
        return CEnum.Parse(enumType, str);
    }

    public override void Write(Utf8JsonWriter writer, IRedEnum value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToEnumString());
}
