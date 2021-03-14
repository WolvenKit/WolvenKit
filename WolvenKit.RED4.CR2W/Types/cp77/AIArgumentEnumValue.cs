using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentEnumValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CName _enumClass;
		private CInt64 _defaultValue;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<AIArgumentType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<AIArgumentType>) CR2WTypeManager.Create("AIArgumentType", "type", cr2w, this);
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

		[Ordinal(4)] 
		[RED("enumClass")] 
		public CName EnumClass
		{
			get
			{
				if (_enumClass == null)
				{
					_enumClass = (CName) CR2WTypeManager.Create("CName", "enumClass", cr2w, this);
				}
				return _enumClass;
			}
			set
			{
				if (_enumClass == value)
				{
					return;
				}
				_enumClass = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("defaultValue")] 
		public CInt64 DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CInt64) CR2WTypeManager.Create("Int64", "defaultValue", cr2w, this);
				}
				return _defaultValue;
			}
			set
			{
				if (_defaultValue == value)
				{
					return;
				}
				_defaultValue = value;
				PropertySet(this);
			}
		}

		public AIArgumentEnumValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
