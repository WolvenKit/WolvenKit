using System.Text.Json;
using System;
using System.Text.Json.Serialization;
using Flags = WolvenKit.RED4.Types.Flags;

namespace WolvenKit.RED4.CR2W.JSON;

public abstract class CustomRedConverter<T> : JsonConverter<T>, ICustomRedConverter
{
    protected Flags _flags = Flags.Empty;

    public virtual object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        _flags = Flags.Empty;
        return Read(ref reader, typeToConvert, options);
    }

    public virtual object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, Flags flags)
    {
        _flags = flags;
        return Read(ref reader, typeToConvert, options);
    }
}