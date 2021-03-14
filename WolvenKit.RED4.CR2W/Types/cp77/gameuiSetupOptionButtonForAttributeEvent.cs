using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionButtonForAttributeEvent : redEvent
	{
		private CUInt32 _attribute;
		private CString _value;

		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get
			{
				if (_attribute == null)
				{
					_attribute = (CUInt32) CR2WTypeManager.Create("Uint32", "attribute", cr2w, this);
				}
				return _attribute;
			}
			set
			{
				if (_attribute == value)
				{
					return;
				}
				_attribute = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CString Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CString) CR2WTypeManager.Create("String", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public gameuiSetupOptionButtonForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
