using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Converters
{
    public sealed class JsonConverterCName : JsonConverter<CName>
    {
        public override CName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CName value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.Text);
    }

    public sealed class JsonConverterCString : JsonConverter<CString>
    {
        public override CString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.GetString();

        public override void Write(Utf8JsonWriter writer, CString value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.Text);
    }
}
