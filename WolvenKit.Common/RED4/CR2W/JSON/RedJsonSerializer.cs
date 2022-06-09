#nullable enable
using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

public static class RedJsonSerializer
{
    private static readonly ReferenceResolver<RedBuffer> s_bufferResolver;
    private static readonly ReferenceResolver<RedBaseClass> s_classResolver;

    static RedJsonSerializer()
    {
        s_bufferResolver = new();
        s_classResolver = new();

        Options = new()
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true,
            MaxDepth = 2048,
            Converters =
            {
                new CBoolConverter(),
                new CDoubleConverter(),
                new CFloatConverter(),
                new CInt8Converter(),
                new CInt16Converter(),
                new CInt32Converter(),
                new CInt64Converter(),
                new CUInt8Converter(),
                new CUInt16Converter(),
                new CUInt32Converter(),
                new CUInt64Converter(),
                new CDateTimeConverter(),
                new CGuidConverter(),
                new CNameConverter(),
                new CRUIDConverter(),
                new CStringConverter(),
                new CVariantConverter(),
                new BufferConverterFactory(s_bufferResolver),
                new LocalizationStringConverter(),
                new CLegacySingleChannelCurveConverterFactory(),
                new MultiChannelCurveConverterFactory(),
                new NodeRefConverter(),
                new TweakDBIDConverter(),
                new CByteArrayConverter(),
                new CKeyValuePairConverter(),
                new ArrayConverterFactory(),
                new EnumConverterFactory(),
                new HandleConverterFactory(s_classResolver),
                new ResourceConverterFactory(),
                new ClassConverterFactory(s_classResolver),
                new Red4FileConverterFactory(),
                new SemVersionConverter(),
                new RedFileDtoConverter(s_classResolver)
            }
        };
    }

    public static JsonSerializerOptions Options { get; }

    public static string Serialize(object value)
    {
        s_bufferResolver.Begin();
        s_classResolver.Begin();

        var result = JsonSerializer.Serialize(value, Options);

        s_bufferResolver.End();
        s_classResolver.End();

        return result;
    }


    public static bool TryDeserialize<T>(string json, out T? result)
    {
        try
        {
            result = Deserialize<T>(json);
            return true;
        }
        catch (Exception)
        {
            result = default;
            return false;
        }
    }

    public static T? Deserialize<T>(string json)
    {
        s_bufferResolver.Begin();
        s_classResolver.Begin();
        var result = JsonSerializer.Deserialize<T>(json, Options);
        s_bufferResolver.End();
        s_classResolver.End();
        return result;
    }
}
