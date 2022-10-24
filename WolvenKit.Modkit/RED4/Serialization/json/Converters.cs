using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Serialization.json
{
    public sealed class CFloatJsonConverter : JsonConverter<CFloat>
    {
        public override CFloat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetSingle();

        public override void Write(Utf8JsonWriter writer, CFloat value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }

    public sealed class CBoolJsonConverter : JsonConverter<CBool>
    {
        public override CBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetBoolean();

        public override void Write(Utf8JsonWriter writer, CBool value, JsonSerializerOptions options)
            => writer.WriteBooleanValue(value);
    }

    public sealed class CUint8JsonConverter : JsonConverter<CUInt8>
    {
        public override CUInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetByte();

        public override void Write(Utf8JsonWriter writer, CUInt8 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CUint16JsonConverter : JsonConverter<CUInt16>
    {
        public override CUInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt16();

        public override void Write(Utf8JsonWriter writer, CUInt16 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CUint32JsonConverter : JsonConverter<CUInt32>
    {
        public override CUInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt32();

        public override void Write(Utf8JsonWriter writer, CUInt32 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CUint64JsonConverter : JsonConverter<CUInt64>
    {
        public override CUInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt64();

        public override void Write(Utf8JsonWriter writer, CUInt64 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }

    public sealed class CInt8JsonConverter : JsonConverter<CInt8>
    {
        public override CInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetSByte();

        public override void Write(Utf8JsonWriter writer, CInt8 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CInt16JsonConverter : JsonConverter<CInt16>
    {
        public override CInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt16();

        public override void Write(Utf8JsonWriter writer, CInt16 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CInt32JsonConverter : JsonConverter<CInt32>
    {
        public override CInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt32();

        public override void Write(Utf8JsonWriter writer, CInt32 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
    public sealed class CInt64JsonConverter : JsonConverter<CInt64>
    {
        public override CInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt64();

        public override void Write(Utf8JsonWriter writer, CInt64 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }



    public sealed class CNameJsonConverter : JsonConverter<CName>
    {
        public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.GetString();

        public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value);
    }

    public sealed class CStringJsonConverter : JsonConverter<CString>
    {
        public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.GetString();

        public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value);
    }

    public sealed class CColorJsonConverter : JsonConverter<CColor>
    {
        public override CColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<byte>)JsonSerializer.Deserialize(json, typeof(List<byte>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new CColor() { Red = list[0], Green = list[1], Blue = list[2], Alpha = list[3] };
        }

        public override void Write(Utf8JsonWriter writer, CColor value, JsonSerializerOptions options)
        {
            List<byte> list = new() { value.Red, value.Green, value.Blue, value.Alpha };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CEulerAnglesJsonConverter : JsonConverter<EulerAngles>
    {
        public override EulerAngles Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new EulerAngles() { Pitch = list[0], Yaw = list[1], Roll = list[2] };
        }

        public override void Write(Utf8JsonWriter writer, EulerAngles value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.Pitch, value.Yaw, value.Roll };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CQuaternionJsonConverter : JsonConverter<Quaternion>
    {
        public override Quaternion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new Quaternion() { I = list[0], J = list[1], K = list[2], R = list[3] };
        }

        public override void Write(Utf8JsonWriter writer, Quaternion value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.I, value.J, value.K, value.R };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CVector2JsonConverter : JsonConverter<Vector2>
    {
        public override Vector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new Vector2() { X = list[0], Y = list[1], };
        }

        public override void Write(Utf8JsonWriter writer, Vector2 value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.X, value.Y };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CVector3JsonConverter : JsonConverter<Vector3>
    {
        public override Vector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new Vector3() { X = list[0], Y = list[1], Z = list[2] };
        }

        public override void Write(Utf8JsonWriter writer, Vector3 value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.X, value.Y, value.Z };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CResourceConverterFactory : JsonConverterFactory
    {
        private readonly CResourceConverter _resourceReferenceConverter = new();

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeof(IRedResourceAsyncReference).IsAssignableFrom(typeToConvert))
            {
                return _resourceReferenceConverter;
            }

            throw new NotSupportedException("CreateConverter got called on a type that this converter factory doesn't support");
        }

        private sealed class CResourceConverter : JsonConverter<CResourceAsyncReference<CResource>>
        {
            public override CResourceAsyncReference<CResource> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                var text = reader.GetString();
                if (ulong.TryParse(text, out var hash))
                {
                    return new CResourceAsyncReference<CResource>(hash);
                }
                else
                {
                    return new CResourceAsyncReference<CResource>(text);
                }
            }

            public override void Write(Utf8JsonWriter writer, CResourceAsyncReference<CResource> value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.DepotPath);
            }
        }
    }
}
