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
			get => GetProperty(ref _behaviour);
			set => SetProperty(ref _behaviour, value);
		}

		[Ordinal(3)] 
		[RED("conditions")] 
		public CArray<questConditionItem> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public questSwitchNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
