using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSwitchNodeDefinition : questDisableableNodeDefinition
	{
		private CEnum<questESwitchBehaviourType> _behaviour;
		private CArray<questConditionItem> _conditions;

		[Ordinal(2)] 
		[RED("behaviour")] 
		public CEnum<questESwitchBehaviourType> Behaviour
		{
			get
			{
				if (_behaviour == null)
				{
					_behaviour = (CEnum<questESwitchBehaviourType>) CR2WTypeManager.Create("questESwitchBehaviourType", "behaviour", cr2w, this);
				}
				return _behaviour;
			}
			set
			{
				if (_behaviour == value)
				{
					return;
				}
				_behaviour = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("conditions")] 
		public CArray<questConditionItem> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<questConditionItem>) CR2WTypeManager.Create("array:questConditionItem", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public questSwitchNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
