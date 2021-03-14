using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentReference : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CVariant _defaultValue;
		private CName _rttiClassName;

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
		[RED("defaultValue")] 
		public CVariant DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CVariant) CR2WTypeManager.Create("Variant", "defaultValue", cr2w, this);
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

		[Ordinal(5)] 
		[RED("rttiClassName")] 
		public CName RttiClassName
		{
			get
			{
				if (_rttiClassName == null)
				{
					_rttiClassName = (CName) CR2WTypeManager.Create("CName", "rttiClassName", cr2w, this);
				}
				return _rttiClassName;
			}
			set
			{
				if (_rttiClassName == value)
				{
					return;
				}
				_rttiClassName = value;
				PropertySet(this);
			}
		}

		public AIArgumentReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
