using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.Common;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WReader : Red4Reader
    {
        public CR2WReader(Stream input) : base(input)
        {
        }

        public CR2WReader(Stream input, Encoding encoding) : base(input, encoding)
        {
        }

        public CR2WReader(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
        }

        public CR2WReader(BinaryReader reader) : base(reader)
        {
        }

        public override IRedArray<T> ReadCArray<T>(uint size)
        {
            var array = new CArray<T>();

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, Flags.Empty);
                array.Add((T)element);
            }

            return array;
        }

        public override IRedArrayFixedSize<T> ReadCArrayFixedSize<T>(uint size, Flags flags)
        {
            var array = new CArrayFixedSize<T>(flags.MoveNext() ? flags.Current : 0);

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, flags.Clone());
                ((IList<T>)array)[i] = (T)element;
            }

            return array;
        }

        public override IRedStatic<T> ReadCStaticArray<T>(uint size, Flags flags)
        {
            var array = new CStatic<T>(flags.MoveNext() ? flags.Current : 0);

            var elementCount = _reader.ReadUInt32();

            uint elementSize = 0;
            if (elementCount > 0)
            {
                elementSize = (size - 4) / elementCount;
            }

            for (var i = 0; i < elementCount; i++)
            {
                var element = Read(typeof(T), elementSize, flags.Clone());
                ((IList<T>)array)[i] = (T)element;
            }

            return array;
        }

        public override void ReadClass(IRedClass cls, uint size)
        {
            if (cls.GetType() == typeof(AITrafficWorkspotCompiled))
            {
                cls = ReadAITrafficWorkspotCompiled(size);
                return;
            }

            var meta = (REDMetaAttribute)Attribute.GetCustomAttribute(cls.GetType(), typeof(REDMetaAttribute));
            EREDMetaInfo[] tags = meta?.Keywords;

            var startpos = _reader.BaseStream.Position;

            // fixed class/struct (no leading null byte), read all properties in order
            if ((tags ?? throw new InvalidOperationException()).Contains(EREDMetaInfo.REDStruct))
            {
                // parse all RED variables (normal + buffers)
                // ReadAllRedVariables<REDAttribute>(file);
            }
            // CVectors
            else
            {
                #region initial checks
                int zero = ReadVLQ();

                // ... okay CDPR, is that a joke or what?
                if (zero != 0)
                {
                    if (cls is IRedCustomData customCls)
                    {
                        customCls.CustomRead(this, (uint)(size - (BaseStream.Position - startpos)), zero);
                        return;
                    }

                    /*var pos = _reader.BaseStream.Position;
                    _reader.BaseStream.Position = startpos;
                    var buf = _reader.ReadBytes((int)size);
                    _reader.BaseStream.Position = pos;
                    File.WriteAllBytes(@"C:\Dev\dump.bin", buf);*/

                    throw new Exception($"Tried parsing a CVariable: zero read {zero}.");

                    //Debugger.Break();
                    switch (zero)
                    {
                        case 1:
                            int joke = _reader.ReadInt32();
                            break;
                        case -128:
                            //var dzero2 = file.BaseReader.ReadBit6();
                            return;
                        case 0x07ffffff: // nulled
                            //IsNulled = true;
                            break;
                        default:
                            throw new Exception($"Tried parsing a CVariable: zero read {zero}.");
                    }
                }
                #endregion

                _propNames.Clear();

                #region parse sequential variables
                List<string> dbg_varnames = new List<string>();
                while (true)
                {
                    var cvar = ReadVariable(cls);
                    if (!cvar)
                        break;
                }
                #endregion

                var endpos = _reader.BaseStream.Position;
                var bytesread = endpos - startpos;

                if (cls is IRedAppendix app)
                {
                    app.Read(this, (uint)(size - bytesread));
                }

                if (bytesread != size)
                {
                    //throw new InvalidParsingException($"Read bytes not equal to expected bytes. Difference: {bytesread - size}");
                }
            }

            if (((RedBaseClass)cls).GetCustomProperties().Count > 0)
            {
                RedTypeManager.ClassReferences.TryAdd(cls, 0);
            }
        }

        private void PostProcessing(IRedType value)
        {
            if (value is IRedHandle handle)
            {
                //handle.SetReferenceList(_file.Chunks);
            }
        }

        private List<string> _propNames = new();
        private HashSet<(string, string)> _defaultValues = new();

        public bool ReadVariable(IRedClass cls)
        {
            var nameId = _reader.ReadUInt16();
            if (nameId == 0)
            {
                return false;
            }
            var varname = _stringList[nameId];
            _propNames.Add(varname);

            // Read Type
            var typeId = _reader.ReadUInt16();
            var typename = _stringList[typeId];

            // Read Size
            var sizepos = _reader.BaseStream.Position;
            var size = _reader.ReadUInt32();

            IRedType value;

            var prop = RedReflection.GetPropertyByRedName(cls.GetType(), varname);
            if (cls.GetType() == typeof(audioPlayerWeaponSettings) && varname == "animEventOverrides")
            {
                var i = prop.Ordinal;
            }

            if (prop == null)
            {
                var (type, flags) = RedReflection.GetCSTypeFromRedType(typename);
                value = Read(type, size - 4, flags);

                RedReflection.AddDynamicProperty(cls, varname, value);
                //throw new MissingRTTIException(varname, typename, cls.GetType().Name);
            }
            else
            {
                value = Read(prop.Type, size - 4, prop.Flags.Clone());
                //PostProcessing(value);

                var typeInfo = RedReflection.GetTypeInfo(cls.GetType());
                if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), varname, value))
                {
                    _defaultValues.Add((cls.GetType().Name, varname));
                    RedReflection.IsDefault(cls.GetType(), varname, value);
                }

                prop.SetValue(cls, value);
            }

            return true;
        }

        public void ReadAreaShapeOutline(IRedClass cls)
        {
            var result = new AreaShapeOutline();

            var count = BaseReader.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                result.Points[i] = new Vector3();
                result.Points[i].X = BaseReader.ReadSingle();
                result.Points[i].Y = BaseReader.ReadSingle();
                result.Points[i].Z = BaseReader.ReadSingle();
            }
            result.Height = BaseReader.ReadSingle();

            cls = result;
        }

        public override IRedResourceReference<T> ReadCResourceReference<T>()
        {
            var index = _reader.ReadUInt16();

            if (index > 0)
            {
                return new CResourceReference<T>
                {
                    DepotPath = _file.Imports[index - 1].DepotPath,
                    Flags = (InternalEnums.EImportFlags)_file.Imports[index - 1].Flags
                };
            }
            else
            {
                return new CResourceReference<T>
                {
                    DepotPath = "",
                    Flags = (InternalEnums.EImportFlags)EImportFlags.Default
                };
            }
        }

        public override IRedResourceAsyncReference<T> ReadCResourceAsyncReference<T>()
        {
            var index = _reader.ReadUInt16();

            if (index > 0)
            {
                return new CResourceAsyncReference<T>
                {
                    DepotPath = _file.Imports[index - 1].DepotPath,
                    Flags = (InternalEnums.EImportFlags)_file.Imports[index - 1].Flags
                };
            }
            else
            {
                return new CResourceAsyncReference<T>
                {
                    DepotPath = "",
                    Flags = (InternalEnums.EImportFlags)EImportFlags.Default
                };
            }
        }
    }
}
