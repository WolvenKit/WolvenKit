using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;

namespace WolvenKit.App.Converters;

public class JsonFileEntryConverter : JsonConverter<FileEntry>
{
    private IArchiveManager _archiveManager;

    public JsonFileEntryConverter(IArchiveManager archiveManager)
    {
        _archiveManager = archiveManager;
    }

    public override FileEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var fileHash = reader.TokenType switch
        {
            JsonTokenType.String => FNV1A64HashAlgorithm.HashString(reader.GetString().NotNull()),
            JsonTokenType.Number => reader.GetUInt64(),
            JsonTokenType.None => throw new NotImplementedException(),
            JsonTokenType.StartObject => throw new NotImplementedException(),
            JsonTokenType.EndObject => throw new NotImplementedException(),
            JsonTokenType.StartArray => throw new NotImplementedException(),
            JsonTokenType.EndArray => throw new NotImplementedException(),
            JsonTokenType.PropertyName => throw new NotImplementedException(),
            JsonTokenType.Comment => throw new NotImplementedException(),
            JsonTokenType.True => throw new NotImplementedException(),
            JsonTokenType.False => throw new NotImplementedException(),
            JsonTokenType.Null => throw new NotImplementedException(),
            _ => throw new NotImplementedException()
        };

        var fileEntry = _archiveManager.Lookup(fileHash);
        if (fileEntry.HasValue)
        {
            return (FileEntry)fileEntry.Value;
        }

        throw new FileNotFoundException();
    }

    public override void Write(Utf8JsonWriter writer, FileEntry value, JsonSerializerOptions options) => JsonSerializer.Serialize(writer, value.NameOrHash);
}
