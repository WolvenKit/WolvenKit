using System;
using System.IO;
using System.Text;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Archive.CR2W;

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

        public override void ReadClass(IRedClass cls, uint size)
        {
            if (cls is IRedCustomData customCls)
            {
                customCls.CustomRead(this, size);
                return;
            }

            var startpos = _reader.BaseStream.Position;

            #region initial checks

            // ... okay CDPR, is that a joke or what?
            int zero = _reader.ReadByte();
            if (zero != 0)
            {
                throw new Exception($"Tried parsing a CVariable: zero read {zero}.");
            }

            #endregion

            #region parse sequential variables
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

        public bool ReadVariable(IRedClass cls)
        {
            var nameId = _reader.ReadUInt16();
            if (nameId == 0)
            {
                return false;
            }
            var varname = GetStringValue(nameId);

            // Read Type
            var typeId = _reader.ReadUInt16();
            var typename = GetStringValue(typeId);

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
            }
            else
            {
                value = Read(prop.Type, size - 4, prop.Flags.Clone());

                var typeInfo = RedReflection.GetTypeInfo(cls.GetType());
                if (!typeInfo.SerializeDefault && RedReflection.IsDefault(cls.GetType(), varname, value))
                {
                    throw new TodoException($"Invalid default val for: \"{cls.RedType}.{varname}\"");
                }

                prop.SetValue(cls, value);
            }

            return true;
        }

        public override DataBuffer ReadDataBuffer()
        {
            var result = base.ReadDataBuffer();

            if (_parseBuffer && result.Pointer == -1 && result.Buffer.MemSize > 0)
            {
                var ms = new MemoryStream(result.Buffer.GetBytes());
                var reader = new PackageReader(ms);
                reader.ReadPackage(result.Buffer);
            }

            return result;
        }

        public override SharedDataBuffer ReadSharedDataBuffer(uint size)
        {
            var bufferSize = _reader.ReadUInt32();
            var result = base.ReadSharedDataBuffer(bufferSize);

            if (_parseBuffer)
            {
                var ms = new MemoryStream(result.Buffer.GetBytes());

                using var br = new BinaryReader(ms, Encoding.Default, true);
                //br.BaseStream.Position += 4;
                var magic = br.ReadUInt32();
                var isCr2wFile = magic == CR2WFile.MAGIC;
                if (isCr2wFile)
                {
                    br.BaseStream.Seek(-4, SeekOrigin.Current);

                    using var cr2wReader = new CR2WReader(br);
                    var readResult = cr2wReader.ReadFile(out var c, true);

                    result.File = c;
                }
                else
                {
                    var reader = new PackageReader(ms);
                    reader.ReadPackage(result.Buffer);
                }
            }

            return result;
        }
    }
}
