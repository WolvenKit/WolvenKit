using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class inkWidgetDto : DynamicObject
    {
        internal object Header;
        internal string Type;
        internal Dictionary<string, object> Properties = new();
        internal inkWidgetDto _parent;
        internal inkWidget _data;
        internal Type _propertyType;
        internal string _propertyName;
        internal List<inkWidget> _widgetList;

        public inkWidgetDto()
        {

        }

        public inkWidgetDto(inkWidget widget, object header) : this(widget)
        {
            Header = header;
            _widgetList = new();
            _widgetList.Add(widget);
        }

        public inkWidgetDto(inkWidget widget, string propertyName = null, inkWidgetDto parent = null)
        {
            _data = widget;
            _propertyName = propertyName;
            _parent = parent;

            var type = _data?.GetType() ?? null;
            if (type == null && _parent != null)
            {
                var parentData = _parent._data;
                if (_parent._propertyType == typeof(IRedBaseHandle))
                {
                    var handle = (IRedBaseHandle)parentData;
                    parentData = (inkWidget)handle.GetValue();
                }
                var propInfo = RedReflection.GetPropertyByName(parent.GetType(), _propertyName) ?? null;
                type = propInfo?.Type ?? null;
            }
            _propertyType = type;
            Type = RedReflection.GetRedTypeFromCSType(_propertyType);

            if (_data == null)
                return;

            try
            {
                IRedType data = _data;
                if (data is IRedBaseHandle handle)
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
                        if (!RedReflection.IsDefault(redClass.GetType(), pi, value))
                        {
                            Properties.Add(pi.Name, PrimativeDecider(value, pi.Name, this));
                        }
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

        public bool ContainsWidget(inkWidget widget)
        {
            if (_parent != null)
                return _parent.ContainsWidget(widget);
            if (_widgetList != null)
            {
                if (!_widgetList.Contains(widget))
                {
                    _widgetList.Add(widget);
                    return false;
                }
                return true;
            }
            return false;
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

        private object PrimativeDecider(IRedType data, string propertyName, inkWidgetDto parent)
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
                case inkWidget w:
                    if (!ContainsWidget(w))
                    {
                        return new inkWidgetDto(w, propertyName, parent);
                    }
                    else
                    {
                        return w.GetPath();
                    }
                default:
                    return data.ToString();
            }
        }
    }
}
