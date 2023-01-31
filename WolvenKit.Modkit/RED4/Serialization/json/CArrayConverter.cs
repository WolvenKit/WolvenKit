using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;
using Activator = System.Activator;

namespace WolvenKit.Modkit.RED4.Serialization.json
{
    /// <summary>
    /// Converts types of CArray where T: IType to json
    /// where in all cases the JsonSerializer of T is used
    /// </summary>
    public class CArrayConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            var baseType = typeToConvert.BaseType;
            if (baseType is { IsGenericType: false })
            {
                return false;
            }

            return baseType != null && baseType.GetGenericTypeDefinition() == typeof(CArray<>);
        }

        public override JsonConverter? CreateConverter(Type type, JsonSerializerOptions options)
        {
            if (type.BaseType == null)
            {
                throw new JsonException();
            }

            var keyType = type.BaseType.GetGenericArguments()[0];

            var converter = Activator.CreateInstance(
                typeof(CArrayConverterInner<>).MakeGenericType(
                    new Type[] { keyType }),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { options },
                culture: null);

            return converter as JsonConverter;

        }

        private class CArrayConverterInner<T> : JsonConverter<CArray<T>> where T : IRedType
        {
            private readonly JsonConverter<IList<T>> _valueConverter;
            private readonly Type _baseType;

            public CArrayConverterInner(JsonSerializerOptions options)
            {
                _valueConverter = (JsonConverter<IList<T>>)options.GetConverter(typeof(T));
                _baseType = typeof(T);
            }

            public override CArray<T> Read(
                ref Utf8JsonReader reader,
                Type typeToConvert,
                JsonSerializerOptions options)
            {
                var value = _valueConverter.Read(ref reader, _baseType, options) ?? JsonSerializer.Deserialize<IList<T>>(ref reader, options).NotNull();

                var instance = Activator.CreateInstance(typeToConvert) as CArray<T> ?? throw new JsonException();

                instance.AddRange(value);
                return instance;
            }

            public override void Write(
                Utf8JsonWriter writer,
                CArray<T> fundamental,
                JsonSerializerOptions options)
            {

                if (_valueConverter != null)
                {
                    _valueConverter.Write(writer, fundamental, options);
                }
                else
                {
                    JsonSerializer.Serialize(writer, fundamental, options);
                }
            }
        }
    }

}
