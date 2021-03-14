using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentTreeRefValue : AIArgumentDefinition
	{
		private CEnum<AIArgumentType> _type;
		private CHandle<AIbehaviorParameterizedBehavior> _defaultValue;

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
		public CHandle<AIbehaviorParameterizedBehavior> DefaultValue
		{
			get
			{
				if (_defaultValue == null)
				{
					_defaultValue = (CHandle<AIbehaviorParameterizedBehavior>) CR2WTypeManager.Create("handle:AIbehaviorParameterizedBehavior", "defaultValue", cr2w, this);
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

		public AIArgumentTreeRefValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
