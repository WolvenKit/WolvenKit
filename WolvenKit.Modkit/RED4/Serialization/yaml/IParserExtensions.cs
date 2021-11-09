using System.IO;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;

namespace WolvenKit.Modkit.RED4.Serialization.yaml
{
    public static class IParserExtensions
    {
        public static void WriteProperty(this IEmitter emitter, string propertyname, string str)
        {
            emitter.Emit(new Scalar(null, propertyname));
            emitter.Emit(new Scalar(null, str));
        }

        public static void ReadMappingStart(this IParser parser)
        {
            if (parser.Current != null && parser.Current.GetType() != typeof(MappingStart))
            {
                throw new InvalidDataException($"Invalid YAML content. Got type: {parser.Current.GetType()} for {parser.Current.Start} to {parser.Current.End}");
            }
            parser.MoveNext();
        }
        public static void SafeReadScalarValue(this IParser parser, string propertyName)
        {
            // read value
            var valueName = parser.ReadScalarValue();
            if (valueName != propertyName)
            {
                throw new InvalidDataException($"Unexpected scalar value '{valueName}'. Expected value: '{propertyName}'");
            }
        }
        public static string ReadScalarValue(this IParser parser)
        {
            if (parser.Current is not Scalar scalar)
            {
                throw new InvalidDataException("Failed to retrieve scalar value.");
            }
            var val = scalar.Value;
            parser.MoveNext();
            return val;
        }
        public static string SafeReadScalarProperty(this IParser parser, string propertyName)
        {
            parser.SafeReadScalarValue(propertyName);
            return parser.ReadScalarValue();
        }
    }
}
