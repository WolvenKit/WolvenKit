using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationAttributeData : IScriptable
	{
		private CString _label;
		private CString _desc;
		private CInt32 _value;
		private CEnum<gamedataStatType> _attribute;
		private CName _icon;
		private CInt32 _maxValue;
		private CInt32 _minValue;
		private CBool _maxed;
		private CBool _atMinimum;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("desc")] 
		public CString Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (CString) CR2WTypeManager.Create("String", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
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

		[Ordinal(3)] 
		[RED("attribute")] 
		public CEnum<gamedataStatType> Attribute
		{
			get
			{
				if (_attribute == null)
				{
					_attribute = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "attribute", cr2w, this);
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

		[Ordinal(4)] 
		[RED("icon")] 
		public CName Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CName) CR2WTypeManager.Create("CName", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CInt32) CR2WTypeManager.Create("Int32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("minValue")] 
		public CInt32 MinValue
		{
			get
			{
				if (_minValue == null)
				{
					_minValue = (CInt32) CR2WTypeManager.Create("Int32", "minValue", cr2w, this);
				}
				return _minValue;
			}
			set
			{
				if (_minValue == value)
				{
					return;
				}
				_minValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get
			{
				if (_maxed == null)
				{
					_maxed = (CBool) CR2WTypeManager.Create("Bool", "maxed", cr2w, this);
				}
				return _maxed;
			}
			set
			{
				if (_maxed == value)
				{
					return;
				}
				_maxed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("atMinimum")] 
		public CBool AtMinimum
		{
			get
			{
				if (_atMinimum == null)
				{
					_atMinimum = (CBool) CR2WTypeManager.Create("Bool", "atMinimum", cr2w, this);
				}
				return _atMinimum;
			}
			set
			{
				if (_atMinimum == value)
				{
					return;
				}
				_atMinimum = value;
				PropertySet(this);
			}
		}

		public CharacterCreationAttributeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
