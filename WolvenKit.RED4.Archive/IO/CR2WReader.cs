using System;
using System.IO;
using System.Text;
using Splat;
using WolvenKit.Common.Services;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

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

        public override void ReadClass(RedBaseClass cls, uint size)
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
                {
                    break;
                }
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

        public bool ReadVariable(RedBaseClass cls)
        {
            var nameId = _reader.ReadUInt16();
            if (nameId == 0)
            {
                return false;
            }
            var varName = GetStringValue(nameId);

            // Read Type
            var typeId = _reader.ReadUInt16();
            var typename = GetStringValue(typeId);

            // Read Size
            var sizepos = _reader.BaseStream.Position;
            var size = _reader.ReadUInt32();

            var (type, flags) = RedReflection.GetCSTypeFromRedType(typename);

            IRedType value;
            var prop = RedReflection.GetPropertyByRedName(cls.GetType(), varName);
            if (prop == null)
            {
                value = Read(type, size - 4, flags);

                RedReflection.AddDynamicProperty(cls, varName, value);
            }
            else
            {
                value = Read(prop.Type, size - 4, prop.Flags.Clone());

                var typeInfo = RedReflection.GetTypeInfo(cls.GetType());

                var propName = $"{RedReflection.GetRedTypeFromCSType(cls.GetType())}.{varName}";
                if (type != prop.Type)
                {
                    throw new InvalidRTTIException(propName, prop.Type, type);
                }

#if DEBUG
                if (!typeInfo.SerializeDefault && !prop.SerializeDefault && RedReflection.IsDefault(cls.GetType(), varName, value))
                {
                    throw new InvalidParsingException($"Invalid default val for: \"{propName}\"");
                }
#endif

                prop.SetValue(cls, value);
            }

            PostProcess();

            return true;

            void PostProcess()
            {
                if (value is IRedBufferPointer buf)
                {
                    buf.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                    buf.GetValue().Parent = cls;
                }

                if (value is IRedArray arr)
                {
                    if (typeof(IRedBufferPointer).IsAssignableFrom(arr.InnerType))
                    {
                        foreach (IRedBufferPointer entry in arr)
                        {
                            entry.GetValue().ParentTypes.Add($"{cls.GetType().Name}.{varName}");
                        }
                    }
                }
            }
        }

        public override TweakDBID ReadTweakDBID()
        {
            var hash = _reader.ReadUInt64();
            var str = Locator.Current.GetService<ITweakDBService>().GetString(hash);
            if (str != null)
            {
                return str;
            }
            return hash;
        }

        public override SharedDataBuffer ReadSharedDataBuffer(uint size)
        {
            var innerSize = BaseReader.ReadUInt32();
            if (size != innerSize + 4)
            {
                throw new TodoException("ReadSharedDataBuffer");
            }

            var result = base.ReadSharedDataBuffer(innerSize);

            if (_parseBuffer)
            {
                using var ms = new MemoryStream(result.Buffer.GetBytes());
                using var br = new BinaryReader(ms, Encoding.Default, true);

                using var cr2wReader = new CR2WReader(br);
                var readResult = cr2wReader.ReadFile(out var c, true);
                if (readResult == EFileReadErrorCodes.NoCr2w)
                {
                    throw new TodoException("ReadSharedDataBuffer");
                }

                result.File = c;
            }

            return result;
        }
    }
}
