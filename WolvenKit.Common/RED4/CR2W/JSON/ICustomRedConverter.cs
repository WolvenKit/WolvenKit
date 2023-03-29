using System;
using System.Text.Json;

namespace WolvenKit.RED4.CR2W.JSON;

public interface ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);
}
