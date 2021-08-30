using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB.Serialization
{
    /// <summary>
    /// Converts types of BaseFundamental where T: struct to json
    /// where in all cases the JsonSerializer of T is used
    /// </summary>
    public class BaseFundamentalConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            var baseType = typeToConvert.BaseType;
            if (baseType is { IsGenericType: false })
            {
                return false;
            }

            return baseType != null && baseType.GetGenericTypeDefinition() == typeof(BaseFundamental<>);
        }

        public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
        {
            if (type.BaseType == null)
            {
                throw new JsonException();
            }

            var keyType = type.BaseType.GetGenericArguments()[0];

            var converter = (JsonConverter)Activator.CreateInstance(
                typeof(BaseFundamentalConverterInner<>).MakeGenericType(
                    new Type[] { keyType }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] {  options },
                culture: null);

            return converter;

        }

        private class BaseFundamentalConverterInner<T> : JsonConverter<BaseFundamental<T>> where T : struct
        {
            private readonly JsonConverter<T> _valueConverter;
            private readonly Type _baseType;

            public BaseFundamentalConverterInner(JsonSerializerOptions options)
            {
                _valueConverter = (JsonConverter<T>)options.GetConverter(typeof(T));
                _baseType = typeof(T);
            }

            public override BaseFundamental<T> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                var value = _valueConverter?.Read(ref reader, _baseType, options) ?? JsonSerializer.Deserialize<T>(ref reader, options);

                var instance = (BaseFundamental<T>)Activator.CreateInstance(typeToConvert);
                if (instance == null)
                {
                    throw new JsonException();
                }

                instance.Value = value;
                return instance;
            }

            public override void Write(
                Utf8JsonWriter writer,
                BaseFundamental<T> fundamental,
                JsonSerializerOptions options)
            {

                if (_valueConverter != null)
                {
                    _valueConverter.Write(writer, fundamental.Value, options);
                }
                else
                {
                    JsonSerializer.Serialize(writer, fundamental, options);
                }
            }
        }
    }

}
