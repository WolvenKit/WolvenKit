#nullable enable
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Common.Conversion;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public class RedFileDtoConverter : JsonConverter<RedFileDto>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;
    private bool _skipHeader;

    public RedFileDtoConverter(ReferenceResolver<RedBaseClass> referenceResolver, bool skipHeader = false)
    {
        _referenceResolver = referenceResolver;
        _skipHeader = skipHeader;
    }

    public void SetSkipHeader(bool skipHeader) => _skipHeader = skipHeader;

    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override RedFileDto Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        RedFileDto result = new();

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        var propertyName = reader.GetString();
        if (propertyName != "Header")
        {
            throw new JsonException();
        }

        result.Header = JsonSerializer.Deserialize<JsonHeader>(ref reader, options) ?? throw new JsonException("Invalid JSON format");
        RedJsonSerializer.SetHeader(result.Header);

        if (RedJsonSerializer.IsNewerThen(new JsonHeader().WKitJsonVersion))
        {
            throw new JsonException("This JSON was created with a newer version of WKit!");
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        propertyName = reader.GetString();
        if (propertyName != "Data")
        {
            throw new JsonException();
        }
        reader.Read();

        switch (result.Header!.DataType)
        {
            case DataTypes.CR2W:
            {
                result.Data = ReadRegular(ref reader, options);
                break;
            }

            case DataTypes.CR2WFlat:
            {
                result.Data = ReadFlat(ref reader, options);
                break;
            }

            default:
            {
                throw new JsonException();
            }
        }

        reader.Read();
        return reader.TokenType != JsonTokenType.EndObject ? throw new JsonException() : result;
    }

    private CR2WFile ReadRegular(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new CR2WFile();

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

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Version":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.Version = reader.GetUInt32();

                    break;
                }

                case "BuildVersion":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.BuildVersion = reader.GetUInt32();

                    break;
                }

                case "RootChunk":
                {
                    var converter = options.GetConverter(typeof(RedBaseClass));
                    result.RootChunk = converter is ICustomRedConverter conv
                        ? (RedBaseClass?)conv.ReadRedType(ref reader, typeof(RedBaseClass), options)
                        : throw new JsonException();

                    break;
                }

                case "EmbeddedFiles":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        result.EmbeddedFiles.Add(JsonSerializer.Deserialize<CR2WEmbedded>(ref reader, options));
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        return result;
    }

    private CR2WFile ReadFlat(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new CR2WFile();

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

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Version":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.Version = reader.GetUInt32();

                    break;
                }

                case "BuildVersion":
                {
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.MetaData.BuildVersion = reader.GetUInt32();

                    break;
                }

                case "RootChunk":
                {
                    if (reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }

                    result.RootChunk = JsonSerializer.Deserialize<RedBaseClass>(ref reader, options);

                    break;
                }

                case "EmbeddedFiles":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        result.EmbeddedFiles.Add(JsonSerializer.Deserialize<CR2WEmbedded>(ref reader, options));
                    }

                    break;
                }

                case "ChunkReferences":
                {
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    var chunkList = JsonSerializer.Deserialize<List<JsonElement>>(ref reader, options)!;

                    for (var i = 0; i < chunkList.Count; i++)
                    {
                        var type = RedJsonSerializer.IsOlderThen("0.0.2")
                            ? chunkList[i].GetProperty("Type").GetString()
                            : chunkList[i].GetProperty("$type").GetString();

                        if (type == null)
                        {
                            throw new JsonException();
                        }

                        _referenceResolver.AddReference(i.ToString(), RedTypeManager.Create(type));
                    }

                    var conv = (RedClassConverter)options.GetConverter(typeof(RedBaseClass));
                    for (var i = 0; i < chunkList.Count; i++)
                    {
                        var bufferWriter = new ArrayBufferWriter<byte>();
                        using (var writer = new Utf8JsonWriter(bufferWriter))
                        {
                            chunkList[i].WriteTo(writer);
                        }

                        var subReader = new Utf8JsonReader(bufferWriter.WrittenSpan, reader.CurrentState.Options);
                        subReader.Read();

                        conv.CustomRead(ref subReader, typeof(RedBaseClass), options, i.ToString());
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        return result;
    }

    public override void Write(Utf8JsonWriter writer, RedFileDto value, JsonSerializerOptions options)
    {
        RedJsonSerializer.SetHeader(value.Header);

        writer.WriteStartObject();

        if (!_skipHeader)
        {
            writer.WritePropertyName("Header");
            JsonSerializer.Serialize(writer, value.Header, options);
        }

        writer.WritePropertyName("Data");
        JsonSerializer.Serialize(writer, value.Data, options);

        writer.WriteEndObject();
    }
}
