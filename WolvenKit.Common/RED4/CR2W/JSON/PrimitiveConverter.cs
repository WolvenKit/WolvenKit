#nullable enable
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Semver;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.CR2W.JSON;

#region Internal

public class CByteArrayConverter : JsonConverter<CByteArray>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CByteArray? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        return reader.GetBytesFromBase64();
    }

    public override void Write(Utf8JsonWriter writer, CByteArray value, JsonSerializerOptions options) => writer.WriteBase64StringValue((byte[])value);
}

public class CKeyValuePairConverter : JsonConverter<CKeyValuePair>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override CKeyValuePair? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        var propertyName = reader.GetString();

        if (RedJsonSerializer.IsVersion("0.0.1") && propertyName != "Type")
        {
            throw new JsonException();
        }

        if (RedJsonSerializer.IsVersion("0.0.2") && propertyName != "$type")
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException();
        }
        var (valType, _) = RedReflection.GetCSTypeFromRedType(reader.GetString());
        if (valType == null)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }

        propertyName = reader.GetString();

        object? result;
        var converter = options.GetConverter(valType);
        if (converter is ICustomRedConverter conv)
        {
            reader.Read();
            result = conv.ReadRedType(ref reader, valType, options);
        }
        else
        {
            result = JsonSerializer.Deserialize(ref reader, valType, options);
        }

        if (result is not IRedType val)
        {
            throw new JsonException();
        }

        reader.Read();
        if (reader.TokenType != JsonTokenType.EndObject)
        {
            throw new JsonException();
        }

        return new CKeyValuePair(propertyName, val);
    }

    public override void Write(Utf8JsonWriter writer, CKeyValuePair value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        var valType = RedReflection.GetRedTypeFromCSType(value.Value.GetType());
        writer.WriteString("$type", valType);

        writer.WritePropertyName(value.Key);
        JsonSerializer.Serialize(writer, (object)value.Value, options);

        writer.WriteEndObject();
    }
}

#endregion Internal


#region HandleConverter

public class HandleConverterFactory : JsonConverterFactory
{
    private readonly HandleConverter _handleConverter;

    public HandleConverterFactory(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _handleConverter = new(referenceResolver);
    }

    public override bool CanConvert(Type typeToConvert) => typeof(IRedBaseHandle).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert.GetGenericTypeDefinition() == typeof(CHandle<>))
        {
            return _handleConverter;
        }

        if (typeToConvert.GetGenericTypeDefinition() == typeof(CWeakHandle<>))
        {
            return _handleConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class HandleConverter : JsonConverter<IRedBaseHandle>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;

    public HandleConverter(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }

    public override bool HandleNull => true;

    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedBaseHandle? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        string? id = null;
        var handle = (IRedBaseHandle)RedTypeManager.CreateRedType(typeToConvert);

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return handle;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "HandleId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    id = reader.GetString();

                    break;
                }

                case "Data":
                {
                    if (id == null)
                    {
                        throw new JsonException();
                    }

                    if (reader.TokenType != JsonTokenType.StartObject)
                    {
                        throw new JsonException();
                    }

                    var conv = (RedClassConverter)options.GetConverter(typeof(RedBaseClass));
                    handle.SetValue(conv.CustomRead(ref reader, typeof(RedBaseClass), options, id));

                    break;
                }

                case "HandleRefId":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var refId = reader.GetString();
                    if (refId == null)
                    {
                        throw new JsonException();
                    }

                    if (refId != "-1")
                    {
                        handle.SetValue(_referenceResolver.ResolveReference(refId));
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedBaseHandle? value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
        }
        else
        {
            writer.WriteStartObject();

            var cls = value.GetValue();
            if (cls != null)
            {
                var refId = _referenceResolver.GetReference(cls, out var alreadyExists);
                if (alreadyExists)
                {
                    writer.WriteString("HandleRefId", refId);
                }
                else
                {
                    writer.WriteString("HandleId", refId);

                    writer.WritePropertyName("Data");
                    JsonSerializer.Serialize(writer, cls, options);
                }
            }
            else
            {
                writer.WriteString("HandleRefId", "-1");
            }

            writer.WriteEndObject();
        }
    }
}

#endregion HandleConverter

#region ResourceConverter

public class ResourceConverterFactory : JsonConverterFactory
{
    private readonly ResourceReferenceConverter _resourceReferenceConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeof(IRedResourceReference).IsAssignableFrom(typeToConvert) || typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeof(IRedResourceReference).IsAssignableFrom(typeToConvert))
        {
            return _resourceReferenceConverter;
        }

        if (typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert))
        {
            return _resourceReferenceConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class ResourceReferenceConverter : JsonConverter<IRedRef>, ICustomRedConverter
{
    public object ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override IRedRef Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return (IRedRef)RedTypeManager.CreateRedType(typeToConvert);
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = (IRedRef)RedTypeManager.CreateRedType(typeToConvert);
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "DepotPath":
                {
                    var converter = options.GetConverter(typeof(CName));
                    if (converter is ICustomRedConverter conv)
                    {
                        reader.Read();
                        result.DepotPath = (CName?)conv.ReadRedType(ref reader, typeof(CName), options);
                    }
                    else
                    {
                        throw new JsonException();
                    }

                    break;
                }

                case "Flags":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    var str = reader.GetString();
                    if (str == null)
                    {
                        throw new JsonException();
                    }

                    result.Flags = Enum.Parse<InternalEnums.EImportFlags>(str);
                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IRedRef value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("DepotPath");
        JsonSerializer.Serialize(writer, value.DepotPath, options);

        writer.WriteString("Flags", value.Flags.ToString());

        writer.WriteEndObject();
    }
}

#endregion ResourceConverter

#region ClassConverter

public class ClassConverterFactory : JsonConverterFactory
{
    private readonly RedClassConverter _redBaseClassConverter;

    public ClassConverterFactory(ReferenceResolver<RedBaseClass> classResolver)
    {
        _redBaseClassConverter = new(classResolver);
    }

    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(RedBaseClass)) || typeToConvert == typeof(RedBaseClass);

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert.IsSubclassOf(typeof(RedBaseClass)) || typeToConvert == typeof(RedBaseClass))
        {
            return _redBaseClassConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class RedClassConverter : JsonConverter<RedBaseClass>, ICustomRedConverter
{
    private readonly ReferenceResolver<RedBaseClass> _referenceResolver;

    public RedClassConverter(ReferenceResolver<RedBaseClass> referenceResolver)
    {
        _referenceResolver = referenceResolver;
    }


    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public RedBaseClass? CustomRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, string? refId)
    {
        if (RedJsonSerializer.IsVersion("0.0.1"))
        {
            return CustomReadV1(ref reader, typeToConvert, options, refId);
        }

        if (RedJsonSerializer.IsVersion("0.0.2"))
        {
            return CustomReadV2(ref reader, typeToConvert, options, refId);
        }

        throw new JsonException("Unsupported version");
    }

    public RedBaseClass? CustomReadV1(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, string? refId)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        RedReflection.ExtendedTypeInfo? typeInfo = null;

        RedBaseClass? cls = null;
        string? clsType;

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return cls;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            reader.Read();

            switch (propertyName)
            {
                case "Type":
                {
                    if (reader.TokenType != JsonTokenType.String)
                    {
                        throw new JsonException();
                    }

                    clsType = reader.GetString();

                    if (refId != null && _referenceResolver.HasReference(refId))
                    {
                        cls = _referenceResolver.ResolveReference(refId);
                    }
                    else
                    {
                        cls = RedTypeManager.Create(clsType);
                    }

                    typeInfo = RedReflection.GetTypeInfo(cls);

                    if (refId != null && !_referenceResolver.HasReference(refId))
                    {
                        _referenceResolver.AddReference(refId, cls);
                    }

                    break;
                }

                case "Properties":
                {
                    if (cls == null || typeInfo == null)
                    {
                        throw new JsonException();
                    }

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

                        var key = reader.GetString();
                        if (key == null)
                        {
                            throw new JsonException();
                        }

                        var valInfo = typeInfo.PropertyInfos.FirstOrDefault(x => x.RedName == key);
                        if (valInfo == null)
                        {
                            throw new JsonException();
                        }

                        object? val;
                        var converter = options.GetConverter(valInfo.Type);
                        if (converter is ICustomRedConverter conv)
                        {
                            reader.Read();
                            val = conv.ReadRedType(ref reader, valInfo.Type, options);
                        }
                        else
                        {
                            val = JsonSerializer.Deserialize(ref reader, valInfo.Type, options);
                        }

                        if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), valInfo.RedName, val))
                        {
                            continue;
                        }

                        cls.SetProperty(valInfo.RedName, (IRedType?)val);
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public RedBaseClass? CustomReadV2(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, string? refId)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        reader.Read();

        if (reader.TokenType != JsonTokenType.PropertyName)
        {
            throw new JsonException();
        }
        var propertyName = reader.GetString();
        if (propertyName != "$type")
        {
            throw new JsonException();
        }
        reader.Read();

        var clsType = reader.GetString();

        RedBaseClass? cls;
        if (refId != null && _referenceResolver.HasReference(refId))
        {
            cls = _referenceResolver.ResolveReference(refId);
        }
        else
        {
            cls = RedTypeManager.Create(clsType);
        }

        if (refId != null && !_referenceResolver.HasReference(refId))
        {
            _referenceResolver.AddReference(refId, cls);
        }

        var typeInfo = RedReflection.GetTypeInfo(cls);

        if (cls == null || typeInfo == null)
        {
            throw new JsonException();
        }

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return cls;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var key = reader.GetString();
            if (key == null)
            {
                throw new JsonException();
            }

            var valInfo = typeInfo.PropertyInfos.FirstOrDefault(x => x.RedName == key);
            if (valInfo == null)
            {
                throw new JsonException();
            }

            object? val;
            var converter = options.GetConverter(valInfo.Type);
            if (converter is ICustomRedConverter conv)
            {
                reader.Read();
                val = conv.ReadRedType(ref reader, valInfo.Type, options);
            }
            else
            {
                val = JsonSerializer.Deserialize(ref reader, valInfo.Type, options);
            }

            if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), valInfo.RedName, val))
            {
                continue;
            }

            cls.SetProperty(valInfo.RedName, (IRedType?)val);
        }

        throw new JsonException();
    }

    public override RedBaseClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return CustomRead(ref reader, typeToConvert, options, null);
    }

    public override void Write(Utf8JsonWriter writer, RedBaseClass value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("$type", RedReflection.GetRedTypeFromCSType(value.GetType()));

        var typeInfo = RedReflection.GetTypeInfo(value);
        foreach (var propertyInfo in typeInfo.PropertyInfos.OrderBy(x => x.RedName))
        {
            if (propertyInfo is not null)
            {
                if (propertyInfo.RedName is not null)
                {
                    writer.WritePropertyName(propertyInfo.RedName);
                    JsonSerializer.Serialize(writer, (object)value.GetProperty(propertyInfo.RedName), options);
                }
                else if (propertyInfo is { Name: { } })
                {
                    writer.WritePropertyName(propertyInfo.Name);
                    JsonSerializer.Serialize(writer, (object)value.GetProperty(propertyInfo.Name), options);
                }
            }
            else
            {
                Locator.Current.GetService<ILoggerService>()?.Error($"propertyInfo was null i guess");
            }
        }

        writer.WriteEndObject();
    }
}

#endregion ClassConverter

#region Red4FileConverter

public class Red4FileConverterFactory : JsonConverterFactory
{
    private readonly RedPackageConverter _redPackageConverter = new();

    public override bool CanConvert(Type typeToConvert) => typeToConvert.IsSubclassOf(typeof(Red4File));

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert == typeof(RedPackage))
        {
            return _redPackageConverter;
        }

        throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
    }
}

public class RedPackageConverter : JsonConverter<RedPackage>, ICustomRedConverter
{
    public object? ReadRedType(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => Read(ref reader, typeToConvert, options);

    public override RedPackage? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var result = new RedPackage();
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return result;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            var propertyName = reader.GetString();
            switch (propertyName)
            {
                case "Version":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Version = reader.GetUInt16();
                    break;
                }

                case "Sections":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.Sections = reader.GetUInt16();
                    break;
                }

                case "CruidIndex":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.Number)
                    {
                        throw new JsonException();
                    }

                    result.CruidIndex = reader.GetInt16();
                    break;
                }

                case "RootCruids":
                {
                    reader.Read();
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

                        result.RootCruids.Add(reader.GetUInt64());
                    }

                    break;
                }

                case "Chunks":
                {
                    reader.Read();
                    if (reader.TokenType != JsonTokenType.StartArray)
                    {
                        throw new JsonException();
                    }

                    result.Chunks = new List<RedBaseClass>();
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonTokenType.EndArray)
                        {
                            break;
                        }

                        var converter = options.GetConverter(typeof(RedBaseClass));
                        if (converter is ICustomRedConverter conv)
                        {
                            result.Chunks.Add((RedBaseClass?)conv.ReadRedType(ref reader, typeof(RedBaseClass), options));
                        }
                        else
                        {
                            throw new JsonException();
                        }
                    }

                    break;
                }

                default:
                {
                    throw new JsonException();
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, RedPackage value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber("Version", value.Version);
        writer.WriteNumber("Sections", value.Sections);
        writer.WriteNumber("CruidIndex", value.CruidIndex);

        writer.WritePropertyName("RootCruids");
        writer.WriteStartArray();
        foreach (var cruid in value.RootCruids)
        {
            writer.WriteNumberValue(cruid);
        }
        writer.WriteEndArray();

        writer.WritePropertyName("Chunks");
        writer.WriteStartArray();
        foreach (var chunk in value.Chunks)
        {
            JsonSerializer.Serialize(writer, chunk, options);
        }
        writer.WriteEndArray();

        writer.WriteEndObject();
    }
}

#endregion Red4FileConverter

public class ReferenceResolver<T> where T : class
{
    private readonly ConcurrentDictionary<int, uint> _threadedReferenceCount = new();

    private readonly ConcurrentDictionary<int, Dictionary<string, T>> _threadedReferenceIdToObjectMap = new();
    private readonly ConcurrentDictionary<int, Dictionary<T, string>> _threadedObjectToReferenceIdMap = new();

    public void Begin()
    {
        _threadedReferenceCount.TryAdd(Environment.CurrentManagedThreadId, 0);
        _threadedReferenceIdToObjectMap.TryAdd(Environment.CurrentManagedThreadId, new Dictionary<string, T>());
        _threadedObjectToReferenceIdMap.TryAdd(Environment.CurrentManagedThreadId, new Dictionary<T, string>(ReferenceEqualityComparer.Instance));
    }

    public void End()
    {
        _threadedReferenceCount.TryRemove(Environment.CurrentManagedThreadId, out _);
        _threadedReferenceIdToObjectMap.TryRemove(Environment.CurrentManagedThreadId, out _);
        _threadedObjectToReferenceIdMap.TryRemove(Environment.CurrentManagedThreadId, out _);
    }

    private uint GetNextId() => _threadedReferenceCount[Environment.CurrentManagedThreadId]++;

    private Dictionary<string, T> ReferenceIdToObjectMap => _threadedReferenceIdToObjectMap[Environment.CurrentManagedThreadId];
    private Dictionary<T, string> ObjectToReferenceIdMap => _threadedObjectToReferenceIdMap[Environment.CurrentManagedThreadId];

    public void AddReference(string referenceId, T value)
    {
        /*try
        {
            ReferenceIdToObjectMap[referenceId] = value;
        }
        catch (Exception ex)
        {
            throw new JsonException($"{ex}");
        }*/

        if (!ReferenceIdToObjectMap.TryAdd(referenceId, value))
        {
            throw new JsonException();
        }
    }

    public string GetReference(T value, out bool alreadyExists)
    {
        if (ObjectToReferenceIdMap.TryGetValue(value, out var referenceId))
        {
            alreadyExists = true;
        }
        else
        {
            referenceId = GetNextId().ToString();
            ObjectToReferenceIdMap.Add(value, referenceId);
            alreadyExists = false;
        }

        return referenceId;
    }

    public bool HasReference(string referenceId) => ReferenceIdToObjectMap.ContainsKey(referenceId);

    public T ResolveReference(string referenceId)
    {
        if (!ReferenceIdToObjectMap.TryGetValue(referenceId, out var value))
        {
            throw new JsonException();
        }

        return value;
    }
}

public class SemVersionConverter : JsonConverter<SemVersion>
{
    public override SemVersion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => SemVersion.Parse(reader.GetString(), SemVersionStyles.Strict);

    public override void Write(Utf8JsonWriter writer, SemVersion value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}
