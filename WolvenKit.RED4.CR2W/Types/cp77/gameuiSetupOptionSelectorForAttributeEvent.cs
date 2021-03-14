using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetupOptionSelectorForAttributeEvent : redEvent
	{
		private CUInt32 _attribute;
		private CArray<gameuiPhotoModeOptionSelectorData> _values;
		private CInt32 _startDataValue;

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
		[RED("values")] 
		public CArray<gameuiPhotoModeOptionSelectorData> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (CArray<gameuiPhotoModeOptionSelectorData>) CR2WTypeManager.Create("array:gameuiPhotoModeOptionSelectorData", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startDataValue")] 
		public CInt32 StartDataValue
		{
			get
			{
				if (_startDataValue == null)
				{
					_startDataValue = (CInt32) CR2WTypeManager.Create("Int32", "startDataValue", cr2w, this);
				}
				return _startDataValue;
			}
			set
			{
				if (_startDataValue == value)
				{
					return;
				}
				_startDataValue = value;
				PropertySet(this);
			}
		}

		public gameuiSetupOptionSelectorForAttributeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
