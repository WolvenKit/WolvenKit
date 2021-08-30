using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    public sealed class CNameJsonConverter : JsonConverter<CName>
    {
        public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options) => writer.WriteStringValue(value.Text);
    }

    public sealed class CStringJsonConverter : JsonConverter<CString>
    {
        public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options) => writer.WriteStringValue(value.Text);
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
            List<byte> list = new() { value.Red.Value, value.Green.Value, value.Blue.Value, value.Alpha.Value };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CEulerAnglesJsonConverter : JsonConverter<CEulerAngles>
    {
        public override CEulerAngles Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new CEulerAngles() { Pitch = list[0], Yaw = list[1], Roll = list[2] };
        }

        public override void Write(Utf8JsonWriter writer, CEulerAngles value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.Pitch.Value, value.Yaw.Value, value.Roll.Value };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CQuaternionJsonConverter : JsonConverter<CQuaternion>
    {
        public override CQuaternion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new CQuaternion() { I = list[0], J = list[1], K = list[2], R = list[3] };
        }

        public override void Write(Utf8JsonWriter writer, CQuaternion value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.I.Value, value.J.Value, value.K.Value, value.R.Value };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CVector2JsonConverter : JsonConverter<CVector2>
    {
        public override CVector2 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new CVector2() { X = list[0], Y = list[1], };
        }

        public override void Write(Utf8JsonWriter writer, CVector2 value, JsonSerializerOptions options)
        {
            List<float> list = new() { value.X.Value, value.Y.Value };
            JsonSerializer.Serialize(writer, list, options);
        }
    }

    public sealed class CVector3JsonConverter : JsonConverter<CVector3>
    {
        public override CVector3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
            var list = (List<float>)JsonSerializer.Deserialize(json, typeof(List<float>));
            if (list == null)
            {
                throw new JsonException();
            }
            return new CVector3() { X = list[0], Y = list[1], Z = list[2] };
        }

        public override void Write(Utf8JsonWriter writer, CVector3 value, JsonSerializerOptions options)
        {
            List<CFloat> list = new() { value.X, value.Y, value.Z };
            JsonSerializer.Serialize(writer, list, options);
        }
    }
}
