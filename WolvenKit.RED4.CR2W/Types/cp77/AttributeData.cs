using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeData : IDisplayData
	{
		private CString _label;
		private CString _icon;
		private TweakDBID _id;
		private CInt32 _value;
		private CInt32 _maxValue;
		private CString _description;
		private CBool _availableToUpgrade;
		private CEnum<gamedataStatType> _type;

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
		[RED("icon")] 
		public CString Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CString) CR2WTypeManager.Create("String", "icon", cr2w, this);
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

		[Ordinal(2)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("availableToUpgrade")] 
		public CBool AvailableToUpgrade
		{
			get
			{
				if (_availableToUpgrade == null)
				{
					_availableToUpgrade = (CBool) CR2WTypeManager.Create("Bool", "availableToUpgrade", cr2w, this);
				}
				return _availableToUpgrade;
			}
			set
			{
				if (_availableToUpgrade == value)
				{
					return;
				}
				_availableToUpgrade = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public AttributeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
