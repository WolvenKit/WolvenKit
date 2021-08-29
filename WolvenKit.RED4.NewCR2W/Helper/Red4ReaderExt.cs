using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.NewCR2W
{
    public class Red4ReaderExt : Red4Reader
    {
        public Red4ReaderExt(Stream input) : base(input)
        {
        }

        public Red4ReaderExt(Stream input, Encoding encoding) : base(input, encoding)
        {
        }

        public Red4ReaderExt(Stream input, Encoding encoding, bool leaveOpen) : base(input, encoding, leaveOpen)
        {
        }

        private void InternalReadArray(IRedArray array)
        {
            var innerType = array.GetType().GetGenericArguments()[0];

            var elementCount = _reader.ReadUInt32();
            for (var i = 0; i < elementCount; i++)
            {
                IRedType element;

                try
                {
                    if (typeof(IRedClass).IsAssignableFrom(innerType))
                    {
                        element = (IRedType)System.Activator.CreateInstance(innerType);
                        ReadClass((IRedClass)element, 0);
                    }
                    else
                    {
                        element = Read(innerType);
                    }

                    array.Add(element);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        protected override void InternalReadCArray(IRedArray array) => InternalReadArray(array);

        protected override void InternalReadCStaticArray(IRedArray array) => InternalReadArray(array);

        public void ReadClass(IRedClass cls, uint size)
        {
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
                sbyte zero = _reader.ReadSByte();

                // ... okay CDPR, is that a joke or what?
                if (zero != 0)
                {
                    switch (zero)
                    {
                        case 1:
                            int joke = _reader.ReadInt32();
                            break;
                        case -128:
                            //var dzero2 = file.BaseReader.ReadBit6();
                            return;
                        case -1: // nulled
                            //IsNulled = true;
                            return;
                        default:
                            throw new Exception($"Tried parsing a CVariable: zero read {zero}.");
                    }
                }
                #endregion

                #region parse sequential variables
                List<string> dbg_varnames = new List<string>();
                while (true)
                {

                    //cvar is a "children variable" : a property of a class.
                    var cvar = ReadVariable(cls);
                    if (!cvar)
                        break;
                }
                #endregion

                //dbg
                var endpos1 = _reader.BaseStream.Position;
                var bytesread1 = endpos1 - startpos;
                var bytesleft = size - bytesread1;

                // parse only buffers
                // ReadAllRedVariables<REDBufferAttribute>(file);

                // checks
                var endpos = _reader.BaseStream.Position;
                var bytesread = endpos - startpos;
                if (bytesread > size)
                {
                    if (size > 0)
                    {

                    }
                    // parsed to far: possible file corruption
                    // BUT: this check is impossible for elements of an array.
                    // in this case, passed size is 0, so we can check for that
                    //if (size != 0)
                    //    throw new InvalidParsingException($"Read bytes not equal to expected bytes. Difference: {bytesread - size}");
                }
                else if (bytesread < size)
                {
                    // parsed too few bytes: add to unknown bytes later
                }
            }
        }

        public bool ReadVariable(IRedClass cls)
        {
            var nameId = _reader.ReadUInt16();
            if (nameId == 0)
            {
                return false;
            }
            var varname = _stringList[nameId];

            // Read Type
            var typeId = _reader.ReadUInt16();
            var typename = _stringList[typeId];

            // Read Size
            var sizepos = _reader.BaseStream.Position;
            var size = _reader.ReadUInt32();

            var prop = RedReflection.GetProperty(cls.GetType(), varname);
            if (prop == null)
            {
                throw new MissingRTTIException(varname, typename, cls.GetType().Name);
            }

            IRedType value;
            try
            {
                if (typeof(IRedClass).IsAssignableFrom(prop.Type))
                {
                    value = (IRedType)System.Activator.CreateInstance(prop.Type);
                    ReadClass((IRedClass)value, size - 4);
                }
                else
                {
                    value = Read(prop.Type, size - 4);
                }

                prop.SetValue(cls, value);
            }
            catch (MissingRTTIException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }

            return true;
        }
    }
}
