using System;
using System.Text.Json;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public interface ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, Flags flags);
}
