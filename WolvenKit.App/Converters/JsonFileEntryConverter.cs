using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Functionality.Converters;

public class JsonFileEntryConverter : JsonConverter<FileEntry>
{
    public override FileEntry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (Locator.Current.GetService<IArchiveManager>() is not ArchiveManager archiveManager)
        {
            throw new Exception();
        }

        var fileHash = reader.TokenType switch
        {
            JsonTokenType.String => FNV1A64HashAlgorithm.HashString(reader.GetString()),
            JsonTokenType.Number => reader.GetUInt64(),
            _ => throw new NotImplementedException()
        };

        var fileEntry = archiveManager.Lookup(fileHash);
        if (fileEntry.HasValue)
        {
            return (FileEntry)fileEntry.Value;
        }

        throw new FileNotFoundException();
    }

    public override void Write(Utf8JsonWriter writer, FileEntry value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.NameOrHash);
    }
}
