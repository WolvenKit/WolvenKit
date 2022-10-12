using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.Json;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.Types;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using Activator = System.Activator;

namespace WolvenKit.Modkit.RED4.Serialization.yaml
{
    public class TweakTypeConverter : IYamlTypeConverter
    {
        private const string s_typeName = "type";
        private const string s_valueName = "value";
        private static readonly Type _sequenceEndType = typeof(SequenceEnd);
        private static readonly Type _sequenceStartType = typeof(SequenceStart);
        private static readonly Type _scalarType = typeof(Scalar);

        public bool Accepts(Type type) => typeof(IRedType).IsAssignableFrom(type);


        public object ReadYaml(IParser parser, Type xtype)
        {
            IRedType result;

            parser.ReadMappingStart();

            // read name property
            var typeName = parser.SafeReadScalarProperty(s_typeName);
            var type = Serialization.GetTypeFromRedTypeStr(typeName);
            if (type == null)
            {
                throw new InvalidDataException();
            }

            if (IsArray(type))
            {
                var innertype = type.GetGenericArguments()[0];
                var array = (IRedArray)Activator.CreateInstance(
                    typeof(CArray<>).MakeGenericType(innertype),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: null);
                if (array is null)
                {
                    throw new InvalidDataException();
                }

                // read values
                parser.SafeReadScalarValue(s_valueName);
                if (parser.Current.GetType() != _sequenceStartType)
                {
                    throw new InvalidDataException("Invalid YAML content.");
                }

                parser.MoveNext(); // skip the sequence start

                if (parser.Current is Scalar scalar)
                {
                    do
                    {
                        var x = Parse(parser.ReadScalarValue(), innertype);
                        array.Add(x);
                    } while (parser.Current.GetType() != _sequenceEndType);
                }
                else if (parser.Current.GetType() != _sequenceEndType)
                {
                    do
                    {
                        var x = ReadYaml(parser, innertype);
                        array.Add(x);
                    } while (parser.Current.GetType() != _sequenceEndType);
                }
                parser.MoveNext(); // skip the mapping end (or crash)

                result = array is IRedType o ? o : throw new JsonException();
            }
            else
            {
                if (typeof(IRedPrimitive).IsAssignableFrom(type))
                {
                    result = Parse(parser.SafeReadScalarProperty(s_valueName), type);
                }
                else
                {
                    parser.SafeReadScalarValue(s_valueName);
                    parser.ReadMappingStart();

                    switch (Serialization.GetEnumFromType(type))
                    {
                        case ETweakType.CColor:
                        {
                            result = new CColor
                            {
                                Red = byte.Parse(parser.SafeReadScalarProperty(nameof(CColor.Red))),
                                Green = byte.Parse(parser.SafeReadScalarProperty(nameof(CColor.Green))),
                                Blue = byte.Parse(parser.SafeReadScalarProperty(nameof(CColor.Blue))),
                                Alpha = byte.Parse(parser.SafeReadScalarProperty(nameof(CColor.Alpha))),
                            };
                            break;
                        }
                        case ETweakType.CEulerAngles:
                        {
                            result = new EulerAngles
                            {
                                Pitch = float.Parse(parser.SafeReadScalarProperty(nameof(EulerAngles.Pitch))),
                                Yaw = float.Parse(parser.SafeReadScalarProperty(nameof(EulerAngles.Yaw))),
                                Roll = float.Parse(parser.SafeReadScalarProperty(nameof(EulerAngles.Roll))),
                            };
                            break;
                        }
                        case ETweakType.CQuaternion:
                        {
                            result = new Quaternion
                            {
                                I = float.Parse(parser.SafeReadScalarProperty(nameof(Quaternion.I))),
                                J = float.Parse(parser.SafeReadScalarProperty(nameof(Quaternion.J))),
                                K = float.Parse(parser.SafeReadScalarProperty(nameof(Quaternion.K))),
                                R = float.Parse(parser.SafeReadScalarProperty(nameof(Quaternion.R))),
                            };
                            break;
                        }
                        case ETweakType.CVector2:
                        {
                            result = new Vector2
                            {
                                X = float.Parse(parser.SafeReadScalarProperty(nameof(Vector2.X))),
                                Y = float.Parse(parser.SafeReadScalarProperty(nameof(Vector2.Y)))
                            };
                            break;
                        }
                        case ETweakType.CVector3:
                        {
                            result = new Vector3
                            {
                                X = float.Parse(parser.SafeReadScalarProperty(nameof(Vector3.X))),
                                Y = float.Parse(parser.SafeReadScalarProperty(nameof(Vector3.Y))),
                                Z = float.Parse(parser.SafeReadScalarProperty(nameof(Vector3.Z)))
                            };
                            break;
                        }
                        case ETweakType.CResource:
                        {
                            result = new CResourceAsyncReference<CResource>(parser.SafeReadScalarProperty(nameof(CResourceAsyncReference<CResource>.DepotPath)));
                            break;
                        }
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    parser.MoveNext(); // skip the mapping end (or crash)
                }
            }

            parser.MoveNext(); // skip the mapping end (or crash)

            return result;
        }

        public void WriteYaml(IEmitter emitter, object value, Type type)
        {
            if (value is not IRedType itype)
            {
                throw new YamlException(type.ToString());
            }

            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            var redName = RedReflection.GetRedTypeFromCSType(itype.GetType());
            emitter.WriteProperty(s_typeName, redName);

            if (IsArray(type))
            {
                if (value is not IRedArray array)
                {
                    throw new YamlException(type.ToString());
                }

                emitter.Emit(new Scalar(null, s_valueName));
                emitter.Emit(new SequenceStart(default, default, false, SequenceStyle.Any));
                foreach (var item in array)
                {
                    if (item is IRedType i)
                    {
                        WriteYaml(emitter, i, i.GetType());
                    }
                    else
                    {
                        throw new YamlException(type.ToString());
                    }
                }
                emitter.Emit(new SequenceEnd());
            }
            else
            {
                if (value is IRedPrimitive fundamental)
                {
                    emitter.WriteProperty(s_valueName, fundamental.ToString());
                }
                else
                {
                    emitter.Emit(new Scalar(null, s_valueName));
                    emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

                    switch (value)
                    {
                        case CColor node:
                        {
                            emitter.WriteProperty(nameof(CColor.Red), node.Red.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Green), node.Green.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Blue), node.Blue.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Alpha), node.Alpha.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case EulerAngles node:
                        {
                            emitter.WriteProperty(nameof(EulerAngles.Pitch), node.Pitch.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(EulerAngles.Yaw), node.Yaw.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(EulerAngles.Roll), node.Roll.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case Quaternion node:
                        {
                            emitter.WriteProperty(nameof(Quaternion.I), node.I.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Quaternion.J), node.J.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Quaternion.K), node.K.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Quaternion.R), node.R.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case Vector2 node:
                        {
                            emitter.WriteProperty(nameof(Vector2.X), node.X.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Vector2.Y), node.Y.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case Vector3 node:
                        {
                            emitter.WriteProperty(nameof(Vector3.X), node.X.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Vector3.Y), node.Y.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(Vector3.Z), node.Y.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case CResourceAsyncReference<CResource> cres:
                        {
                            emitter.WriteProperty(nameof(CResourceAsyncReference<CResource>.DepotPath), cres.DepotPath.ToString());
                            break;
                        }

                        default:
                            throw new YamlException(type.ToString());
                    }

                    emitter.Emit(new MappingEnd());

                }
            }

            emitter.Emit(new MappingEnd());
        }

        private static bool IsArray(Type type) =>
            type is not { IsGenericType: false } and { } && type.GetGenericTypeDefinition() == typeof(CArray<>);

        public IRedType Parse(string s, Type type)
        {
            if (typeof(IRedPrimitive).IsAssignableFrom(type))
            {
                return Serialization.GetEnumFromType(type) switch
                {
                    ETweakType.CName => (CName)s,
                    ETweakType.CString => (CString)s,
                    ETweakType.TweakDBID => (TweakDBID)s,
                    ETweakType.CResource => ParseCResource(s),
                    ETweakType.CFloat => (CFloat)float.Parse(s),
                    ETweakType.CBool => (CBool)bool.Parse(s),
                    ETweakType.CUint8 => (CUInt8)byte.Parse(s),
                    ETweakType.CUint16 => (CUInt16)ushort.Parse(s),
                    ETweakType.CUint32 => (CUInt32)uint.Parse(s),
                    ETweakType.CUint64 => (CUInt64)ulong.Parse(s),
                    ETweakType.LocKey => (gamedataLocKeyWrapper)ulong.Parse(s),
                    ETweakType.CInt8 => (CInt8)sbyte.Parse(s),
                    ETweakType.CInt16 => (CInt16)short.Parse(s),
                    ETweakType.CInt32 => (CInt32)int.Parse(s),
                    ETweakType.CInt64 => (CInt64)long.Parse(s),
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            throw new ArgumentOutOfRangeException();
        }

        private CResourceAsyncReference<CResource> ParseCResource(string value)
        {
            if (ulong.TryParse(value, out var key))
            {
                return new CResourceAsyncReference<CResource>(key);
            }

            return new CResourceAsyncReference<CResource>(value);
        }
    }
}
