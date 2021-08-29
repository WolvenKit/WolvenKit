using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public sealed class CFloatJsonConverter : JsonConverter<CFloat>
    {
        public override CFloat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetSingle();

        public override void Write(Utf8JsonWriter writer, CFloat value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }

    public sealed class CBoolJsonConverter : JsonConverter<CBool>
    {
        public override CBool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetBoolean();

        public override void Write(Utf8JsonWriter writer, CBool value, JsonSerializerOptions options)
            => writer.WriteBooleanValue(value.Value);
    }

    public sealed class JsonConverterCUint8 : JsonConverter<CUint8>
    {
        public override CUint8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetByte();

        public override void Write(Utf8JsonWriter writer, CUint8 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCUint16 : JsonConverter<CUint16>
    {
        public override CUint16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt16();

        public override void Write(Utf8JsonWriter writer, CUint16 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCUint32 : JsonConverter<CUint32>
    {
        public override CUint32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt32();

        public override void Write(Utf8JsonWriter writer, CUint32 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCUint64 : JsonConverter<CUint64>
    {
        public override CUint64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetUInt64();

        public override void Write(Utf8JsonWriter writer, CUint64 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }

    public sealed class JsonConverterCInt8 : JsonConverter<CInt8>
    {
        public override CInt8 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetSByte();

        public override void Write(Utf8JsonWriter writer, CInt8 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCInt16 : JsonConverter<CInt16>
    {
        public override CInt16 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt16();

        public override void Write(Utf8JsonWriter writer, CInt16 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCInt32 : JsonConverter<CInt32>
    {
        public override CInt32 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt32();

        public override void Write(Utf8JsonWriter writer, CInt32 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }
    public sealed class JsonConverterCInt64 : JsonConverter<CInt64>
    {
        public override CInt64 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.GetInt64();

        public override void Write(Utf8JsonWriter writer, CInt64 value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value.Value);
    }


}
