using System;
using System.Collections.Generic;
using System.Dynamic;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class RedClassDto : DynamicObject
    {
        internal object Header;
        internal string Type;
        internal Dictionary<string, object> Properties = new();
        internal RedClassDto _parent;
        internal IRedType _data;
        internal Type _propertyType;
        internal string _propertyName;

        public RedClassDto()
        {

        }

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
                    parentData = handle.GetValue();
                }
                var propInfo = RedReflection.GetPropertyByName(parent.GetType(), _propertyName) ?? null;
                type = propInfo?.Type ?? null;
            }
            _propertyType = type;
            Type = RedReflection.GetRedTypeFromCSType(_propertyType);

            if (_data == null)
            {
                return;
            }

            try
            {
                var data = chunk;
                if (chunk is IRedBaseHandle handle)
                {
                    data = handle.GetValue();
                }
                if (data is RedBaseClass redClass)
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
                        var redType = RedReflection.GetRedTypeFromCSType(pi.Type);
                        Properties.Add(pi.Name + ":" + redType, PrimativeDecider(value, pi.Name, this));
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            if (Header != null)
            {
                yield return nameof(Header);
                yield return ":" + Type;
            }
            else
            {
                foreach (var (name, _) in Properties)
                {
                    if (name != null)
                    {
                        yield return name;
                    }
                }
            }
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (Header != null)
            {
                if (binder.Name == "Header")
                {
                    result = Header;
                    return true;
                }
                else if (binder.Name == (":" + Type))
                {
                    result = Properties;
                    return true;
                }
                return base.TryGetMember(binder, out result);
            }
            else
            {
                return Properties.TryGetValue(binder.Name, out result);
            }
        }

        private object PrimativeDecider(IRedType data, string propertyName, RedClassDto parent)
        {
            if (data == null)
            {
                return null;
            }

            if (data is IRedArray ary)
            {
                var list = new List<object>();
                for (var i = 0; i < ary.Count; i++)
                {
                    list.Add(PrimativeDecider((IRedType)ary[i], null, this));
                }
                return list;
            }

            Package04 pkg = null;

            if (data is SerializationDeferredDataBuffer sddb && sddb.Buffer.Data is Package04 sddbp4)
            {
                pkg = sddbp4;
            }
            else if (data is DataBuffer db && db.Buffer.Data is Package04 dbp4)
            {
                pkg = dbp4;
            }
            else if (data is SharedDataBuffer sdb && sdb.Buffer.Data is Package04 sdbp4)
            {
                pkg = sdbp4;
            }

            if (pkg != null)
            {
                var list = new List<object>();
                var chunks = pkg.Chunks;
                for (var i = 0; i < chunks.Count; i++)
                {
                    var obj = PrimativeDecider(chunks[i], null, this);
                    if (obj is RedClassDto rcd)
                    {
                        list.Add(new Dictionary<string, object>() {
                            {":" + rcd.Type, obj }
                        });
                    }
                    else
                    {
                        list.Add(new Dictionary<string, object>() {
                            { ":" + obj.GetType(), obj }
                        });
                    }
                }
                return list;
            }

            switch (data)
            {
                case CBool b:
                    return (bool)b;
                case IRedString s:
                    return s.GetValue();
                case IRedRef r:
                    return r.DepotPath?.GetValue() ?? null;
                case IRedEnum e:
                    return e.ToEnumString();
                case IRedBitField e:
                    return e.ToBitFieldString();
                case CDateTime d:
                    return d.ToUInt64();
                case CRUID c:
                    return (ulong)c;
                case CUInt64 c:
                    return (ulong)c;
                case CUInt8 uint64:
                    return (byte)uint64;
                case CInt8 uint64:
                    return (sbyte)uint64;
                case CInt16 uint64:
                    return (short)uint64;
                case CUInt16 uint64:
                    return (ushort)uint64;
                case CInt32 uint64:
                    return (int)uint64;
                case CUInt32 uint64:
                    return (uint)uint64;
                case CInt64 uint64:
                    return (long)uint64;
                case IRedPrimitive<float> i:
                    return ((float)(CFloat)i);
                default:
                    return new RedClassDto(data, propertyName, parent);
            }
        }

        public CR2WFile ToW2rc()
        {
            var cr2w = new CR2WFile
            {
                //Buffers = Buffers
                //    .OrderBy(_ => _.Index)
                //    .Select(_ => _.ToRedBuffer())
                //    .ToList()
            };

            // chunks
            // order so that parent chunks get created first
            //var groupedChunks = Chunks.GroupBy(_ => _.Value.ParentIndex);
            //foreach (IGrouping<int, KeyValuePair<int, RedExportDto>> groupedChunk in groupedChunks)
            //{
            //    foreach (var (chunkIndex, chunk) in groupedChunk.OrderBy(_ => _.Key))
            //    {
            //        chunk.CreateChunkInFile(cr2w, chunkIndex);
            //    }
            //}

            return cr2w;
        }
    }
}
