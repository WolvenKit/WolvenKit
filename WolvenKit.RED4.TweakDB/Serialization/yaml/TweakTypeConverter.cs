using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text.Json;
using WolvenKit.RED4.TweakDB.Types;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace WolvenKit.RED4.TweakDB.Serialization.yaml
{
    public class TweakTypeConverter : IYamlTypeConverter
    {
        private const string s_typeName = "type";
        private const string s_valueName = "value";
        private static readonly Type _sequenceEndType = typeof(SequenceEnd);
        private static readonly Type _sequenceStartType = typeof(SequenceStart);

        public bool Accepts(Type type) => typeof(IType).IsAssignableFrom(type);


        public object ReadYaml(IParser parser, Type xtype)
        {
            IType result;

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
                var list = (IList)Activator.CreateInstance(
                    typeof(List<>).MakeGenericType(
                        new Type[] { innertype }),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: null);
                if (list is null)
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

                do
                {
                    var x = this.ReadYaml(parser, innertype);

                    list.Add(x);
                } while (parser.Current.GetType() != _sequenceEndType);

                parser.MoveNext(); // skip the mapping end (or crash)

                var array = (IArray)Activator.CreateInstance(
                    typeof(CArray<>).MakeGenericType(
                        new Type[] { innertype }),
                    BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    args: null,
                    culture: null);
                if (array is null)
                {
                    throw new InvalidDataException();
                }

                array.SetItems(list);

                result = array is IType o ? o : throw new JsonException();
            }
            else
            {
                if (typeof(IPrimitive).IsAssignableFrom(type))
                {
                    result = IPrimitive.Parse(parser.SafeReadScalarProperty(s_valueName), type);
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
                            result = new CEulerAngles
                            {
                                Pitch = float.Parse(parser.SafeReadScalarProperty(nameof(CEulerAngles.Pitch))),
                                Yaw = float.Parse(parser.SafeReadScalarProperty(nameof(CEulerAngles.Yaw))),
                                Roll = float.Parse(parser.SafeReadScalarProperty(nameof(CEulerAngles.Roll))),
                            };
                            break;
                        }
                        case ETweakType.CQuaternion:
                        {
                            result = new CQuaternion
                            {
                                I = float.Parse(parser.SafeReadScalarProperty(nameof(CQuaternion.I))),
                                J = float.Parse(parser.SafeReadScalarProperty(nameof(CQuaternion.J))),
                                K = float.Parse(parser.SafeReadScalarProperty(nameof(CQuaternion.K))),
                                R = float.Parse(parser.SafeReadScalarProperty(nameof(CQuaternion.R))),
                            };
                            break;
                        }
                        case ETweakType.CVector2:
                        {
                            result = new CVector2
                            {
                                X = float.Parse(parser.SafeReadScalarProperty(nameof(CVector2.X))),
                                Y = float.Parse(parser.SafeReadScalarProperty(nameof(CVector2.Y)))
                            };
                            break;
                        }
                        case ETweakType.CVector3:
                        {
                            result = new CVector3
                            {
                                X = float.Parse(parser.SafeReadScalarProperty(nameof(CVector3.X))),
                                Y = float.Parse(parser.SafeReadScalarProperty(nameof(CVector3.Y))),
                                Z = float.Parse(parser.SafeReadScalarProperty(nameof(CVector3.Z)))
                            };
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
            if (value is not IType itype)
            {
                throw new YamlException(type.ToString());
            }

            emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

            emitter.WriteProperty(s_typeName, itype.Name);

            if (IsArray(type))
            {
                if (value is not IArray array)
                {
                    throw new YamlException(type.ToString());
                }

                foreach (var item in array.GetItems())
                {
                    if (item is IType i)
                    {
                        this.WriteYaml(emitter, i, i.GetType());
                    }
                    else
                    {
                        throw new YamlException(type.ToString());
                    }
                }

            }
            else
            {
                if (value is IPrimitive fundamental)
                {
                    emitter.WriteProperty(s_valueName, fundamental.GetValueString());
                }
                else
                {
                    emitter.Emit(new Scalar(null, s_valueName));
                    emitter.Emit(new MappingStart(null, null, false, MappingStyle.Block));

                    switch (value)
                    {
                        case CColor node:
                        {
                            emitter.WriteProperty(nameof(CColor.Red), node.Red.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Green), node.Green.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Blue), node.Blue.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CColor.Alpha), node.Alpha.Value.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case CEulerAngles node:
                        {
                            emitter.WriteProperty(nameof(CEulerAngles.Pitch), node.Pitch.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CEulerAngles.Yaw), node.Yaw.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CEulerAngles.Roll), node.Roll.Value.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case CQuaternion node:
                        {
                            emitter.WriteProperty(nameof(CQuaternion.I), node.I.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CQuaternion.J), node.J.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CQuaternion.K), node.K.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CQuaternion.R), node.R.Value.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case CVector2 node:
                        {
                            emitter.WriteProperty(nameof(CVector2.X), node.X.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CVector2.Y), node.Y.Value.ToString(CultureInfo.InvariantCulture));
                            break;
                        }
                        case CVector3 node:
                        {
                            emitter.WriteProperty(nameof(CVector3.X), node.X.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CVector3.Y), node.Y.Value.ToString(CultureInfo.InvariantCulture));
                            emitter.WriteProperty(nameof(CVector3.Z), node.Y.Value.ToString(CultureInfo.InvariantCulture));
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
    }
}
