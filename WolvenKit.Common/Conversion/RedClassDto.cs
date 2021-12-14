using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class RedClassDto
    {
        public object Header { get; set; }

        public bool ShouldSerializeHeader() => Header != null;

        public string Type { get; set; }

        public bool ShouldSerializeType() => Properties.Count > 0;

        public Dictionary<string, object> Properties { get; set; } = new();

        public bool ShouldSerializeProperties() => Properties.Count > 0;


        internal RedClassDto _parent;
        internal IRedType _data;
        internal Type _propertyType;
        internal string _propertyName;

        public RedClassDto(IRedType chunk, object header) : this(chunk)
        {
            Header = header;
        }

        public RedClassDto(IRedType chunk, string propertyName = null, RedClassDto parent = null)
        {
            _data = chunk;
            _propertyName = propertyName;
            _parent = parent;

            var type = _data?.GetType() ?? null;
            if (type == null && _parent != null)
            {
                var parentData = _parent._data;
                if (_parent._propertyType == typeof(IRedBaseHandle))
                {
                    var handle = (IRedBaseHandle)parentData;
                    parentData = handle.File.Chunks[handle.Pointer];
                }
                var propInfo = RedReflection.GetPropertyByName(parent.GetType(), _propertyName) ?? null;
                type = propInfo?.Type ?? null;
            }
            _propertyType = type;
            Type = _propertyType?.Name ?? null;

            if (_data == null)
                return;

            try
            {
                var obj = chunk;
                if (chunk is IRedBaseHandle handle)
                {
                    obj = handle.File.Chunks[handle.Pointer];
                }
                if (obj is IRedArray ary)
                {
                    for (var i = 0; i < ary.Count; i++)
                    {
                        Properties.Add(i.ToString(), PrimativeDecider((IRedType)ary[i], null, this));
                    }
                }
                else if (obj is RedBaseClass redClass)
                {
                    var pis = RedReflection.GetTypeInfo(redClass.GetType()).PropertyInfos;
                    pis.Sort((a, b) => a.Name.CompareTo(b.Name));
                    pis.ForEach((pi) =>
                    {
                        IRedType value;
                        if (pi.RedName == null)
                        {
                            value = (IRedType)redClass.GetType().GetProperty(pi.Name).GetValue(redClass, null);
                        }
                        else
                        {
                            value = (IRedType)pi.GetValue(redClass);
                        }
                        Properties.Add(pi.Name, PrimativeDecider(value, pi.Name, this));
                    });
                }
                else if (obj is SerializationDeferredDataBuffer sddb)
                {
                    if (sddb.File is CR2WFile cR2WFile)
                    {
                        var chunks = cR2WFile.Buffers[sddb.Pointer].Chunks;
                        for (var i = 0; i < chunks.Count; i++)
                        {
                            Properties.Add(i.ToString(), PrimativeDecider(chunks[i], null, this));
                        }
                    }
                }
                else if (obj is DataBuffer db)
                {
                    if (db.File is CR2WFile cR2WFile)
                    {
                        var chunks = cR2WFile.Buffers[db.Pointer].Chunks;
                        for (var i = 0; i < chunks.Count; i++)
                        {
                            Properties.Add(i.ToString(), PrimativeDecider(chunks[i], null, this));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        private object PrimativeDecider(IRedType data, string propertyName, RedClassDto parent)
        {
            if (data == null)
                return null;
            switch (data)
            {
                case CBool b:
                    return (bool)b;
                case IRedString s:
                    return s.GetValue();
                case IRedRef r:
                    return r.DepotPath.GetValue();
                case IRedEnum e:
                    return e.ToEnumString();
                case CDateTime d:
                    return d.ToUInt64();
                case CRUID c:
                    return ((ulong)c).ToString();
                case CUInt64 c:
                    return ((ulong)c).ToString();
                case CUInt8 uint64:
                    return uint64;
                case CInt8 uint64:
                    return uint64;
                case CInt16 uint64:
                    return uint64;
                case CUInt16 uint64:
                    return uint64;
                case CInt32 uint64:
                    return uint64;
                case CUInt32 uint64:
                    return uint64;
                case CInt64 uint64:
                    return uint64;
                case IRedPrimitive<float> i:
                    return ((float)(CFloat)i);
                default:
                    return new RedClassDto(data, propertyName, parent);
            }
        }
    }
}
