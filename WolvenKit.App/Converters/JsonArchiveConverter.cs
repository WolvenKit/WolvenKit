using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.Converters;

public class JsonArchiveConverter : JsonConverter<ICyberGameArchive>
{
    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsAssignableFrom(typeof(ICyberGameArchive));

    public override ICyberGameArchive Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();

    public override void Write(Utf8JsonWriter writer, ICyberGameArchive value, JsonSerializerOptions options) { }
}