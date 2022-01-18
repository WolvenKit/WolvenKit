using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class RedClassDto
    {
        internal RedClassDto _parent;
        internal IRedType _data;
        internal Type _propertyType;
        internal string _propertyName;
        internal RedFileDto _file;

        public string Type;

        public Dictionary<string, object> Properties = new();

        public bool ShouldSerializeProperties()
        {
            return Properties.Count > 0;
        }

        public string XPath;

        public bool ShouldSerializeXPath()
        {
            return XPath != null;
        }

        public RedClassDto()
        {

        }

        public RedClassDto(IRedType chunk, RedFileDto file, string propertyName = null, RedClassDto parent = null)
        {
            _data = chunk;
            _propertyName = propertyName;
            _parent = parent;
            _file = file;

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
            if (_data is IRedBaseHandle handl)
            {
                type = handl.GetValue().GetType();
            }

            _propertyType = type;
            Type = RedReflection.GetRedTypeFromCSType(_propertyType);

            if (_data == null)
                return;

            try
            {
                var data = chunk;
                if (data is inkWidgetReference iwr && iwr.Widget != null)
                {
                    XPath = ((inkWidget)iwr.Widget.GetValue()).GetPath();
                    return;
                }
                if (data is IRedBaseHandle handle)
                {
                    if (_file == null || _file.RegisterHandle(_data.GetHashCode()))
                    {
                        data = handle.GetValue();
                    }
                    else
                    {
                        XPath = "need.to.implement.this.still";
                        return;
                    }
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
                            value = (IRedType)redClass.GetType().GetProperty(pi.RedName).GetValue(redClass, null);
                        }
                        else
                        {
                            value = (IRedType)pi.GetValue(redClass);
                        }
                        var redType = RedReflection.GetRedTypeFromCSType(pi.Type);
                        Properties.Add(pi.RedName, PrimativeDecider(value, pi.RedName, this));
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        //public override IEnumerable<string> GetDynamicMemberNames()
        //{
        //    if (Header != null)
        //    {
        //        yield return nameof(Header);
        //        yield return ":" + Type;
        //    }
        //    else
        //    {
        //        foreach (var (name, _) in Properties)
        //        {
        //            if (name != null)
        //            {
        //                yield return name;
        //            }
        //        }
        //    }
        //}

        //public override bool TryGetMember(GetMemberBinder binder, out object result)
        //{
        //    if (Header != null)
        //    {
        //        if (binder.Name == "Header")
        //        {
        //            result = Header;
        //            return true;
        //        }
        //        else if (binder.Name == (":" + Type))
        //        {
        //            result = Properties;
        //            return true;
        //        }
        //        return base.TryGetMember(binder, out result);
        //    }
        //    else
        //    {
        //        return Properties.TryGetValue(binder.Name, out result);
        //    }
        //}

        private object PrimativeDecider(IRedType data, string propertyName, RedClassDto parent)
        {
            if (data == null)
                return null;

            if (data is IRedArray ary)
            {
                var list = new List<object>();
                for (var i = 0; i < ary.Count; i++)
                {
                    list.Add(PrimativeDecider((IRedType)ary[i], null, this));
                }
                return list;
            }

            if (data is IRedBufferWrapper bw && bw.Buffer.Data is Package04 pkg)
            {
                var list = new List<object>();
                var chunks = pkg.Chunks;
                for (var i = 0; i < chunks.Count; i++)
                {
                    var obj = PrimativeDecider(chunks[i], null, this);
                    list.Add(obj);
                    //if (obj is RedClassDto rcd)
                    //{
                    //    list.Add(new Dictionary<string, object>() {
                    //        {":" + rcd.Type, obj }
                    //    });
                    //}
                    //else
                    //{
                    //    list.Add(new Dictionary<string, object>() {
                    //        { ":" + obj.GetType(), obj }
                    //    });
                    //}
                }
                return list;
            }
            else if (data is SharedDataBuffer sdb && sdb.File is CR2WFile cr2wFile)
            {
                data = cr2wFile.RootChunk;
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
                case TweakDBID t:
                    return ((ulong)t).ToString();
                case LocalizationString lockey:
                    return lockey.Value;
                default:
                    return new RedClassDto(data, _file, propertyName, parent);
            }
        }

        public IRedType PropertyParser(Type type, object value)
        {
            if (value is JObject jo && jo.ContainsKey("Type"))
            {
                return JsonConvert.DeserializeObject<RedClassDto>(jo.ToString()).ToRedBaseClass();
            }
            if (value is RedClassDto rcdto)
            {
                return rcdto.ToRedBaseClass();
            }
            else if (type.IsAssignableTo(typeof(IRedArray)))
            {
                var cary = (IRedArray)RedTypeManager.CreateRedType(type);
                var ja = (JArray)value;
                var innerType = type.GetGenericArguments()[0];
                foreach (var j in ja)
                {
                    cary.Add(PropertyParser(innerType, j));
                }
                return cary;
            }
            else if (type.IsAssignableTo(typeof(CBool)))
            {
                return (CBool)(bool)value;
            }
            else if (type.IsAssignableTo(typeof(CName)))
            {
                return (CName)(string)value;
            }
            else if (type.IsAssignableTo(typeof(CString)))
            {
                return (CString)(string)value;
            }
            else if (type.IsAssignableTo(typeof(IRedRef)))
            {
                var irr = (IRedRef)RedTypeManager.CreateRedType(type);
                if (value is JValue jv)
                {
                    value = jv.Value;
                }
                irr.DepotPath = (string)value;
                return irr;
            }
            else if (type.IsAssignableTo(typeof(IRedEnum)))
            {
                var innerType = type.GetGenericArguments()[0];
                return CEnum.Parse(innerType, (string)value);
            }
            else if (type.IsAssignableTo(typeof(IRedBitField)))
            {
                var innerType = type.GetGenericArguments()[0];
                return CBitField.Parse(innerType, (string) value);
            }
            else if (type.IsAssignableTo(typeof(CDateTime)))
            {
                return CDateTime.Parse((ulong)value);
            }
            else if (type.IsAssignableTo(typeof(CRUID)))
            {
                return (CRUID)Convert.ToUInt64(value);
            }
            else if (type.IsAssignableTo(typeof(CUInt64)))
            {
                return (CUInt64)Convert.ToUInt64(value);
            }
            else if (type.IsAssignableTo(typeof(CUInt8)))
            {
                return (CUInt8)Convert.ToByte(value);
            }
            else if (type.IsAssignableTo(typeof(CInt8)))
            {
                return (CInt8)Convert.ToSByte(value);
            }
            else if (type.IsAssignableTo(typeof(CInt16)))
            {
                return (CInt16)Convert.ToInt16(value);
            }
            else if (type.IsAssignableTo(typeof(CUInt16)))
            {
                return (CUInt16)Convert.ToUInt16(value);
            }
            else if (type.IsAssignableTo(typeof(CInt32)))
            {
                return (CInt32)Convert.ToInt32(value);
            }
            else if (type.IsAssignableTo(typeof(CUInt32)))
            {
                return (CUInt32)Convert.ToUInt32(value);
            }
            else if (type.IsAssignableTo(typeof(CInt64)))
            {
                return (CInt64)Convert.ToInt64(value);
            }
            else if (type.IsAssignableTo(typeof(IRedPrimitive<float>)))
            {
                return (CFloat)(float)(double)value;
            }
            else
            {
                return null;
            }
        }

        public RedBaseClass ToRedBaseClass()
        {
            var chunk = RedTypeManager.Create(Type);

            var ti = RedReflection.GetTypeInfo(chunk.GetType());
            //foreach (var pi in ti.PropertyInfos)
            //{
            //    if (pi.RedName
            //}

            foreach (var (propertyName, propertyValue) in Properties)
            {
                if (ti.PropertyInfos.First(x => x.RedName == propertyName) is var propertyInfo && propertyInfo != null)
                {
                    var redValue = PropertyParser(propertyInfo.Type, propertyValue);
                    if (redValue != null)
                    {
                        if (propertyInfo.Type.IsAssignableTo(typeof(IRedBaseHandle)))
                        {
                            var innerType = propertyInfo.Type.GetGenericArguments()[0];
                            propertyInfo.SetValue(chunk, (IRedType)CHandle.Parse(innerType, (RedBaseClass)redValue));
                        }
                        else
                        {
                            propertyInfo.SetValue(chunk, redValue);
                        }
                    }
                }
            }

            return chunk;
        }
    }
}
