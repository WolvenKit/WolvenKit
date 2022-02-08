using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseSkillCheckContainer : IScriptable
	{
		[Ordinal(0)] 
		[RED("hackingCheckSlot")] 
		public CHandle<HackingSkillCheck> HackingCheckSlot
		{
			get => GetPropertyValue<CHandle<HackingSkillCheck>>();
			set => SetPropertyValue<CHandle<HackingSkillCheck>>(value);
		}

		[Ordinal(1)] 
		[RED("engineeringCheckSlot")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheckSlot
		{
			get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
			set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
		}

		[Ordinal(2)] 
		[RED("demolitionCheckSlot")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheckSlot
		{
			get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
			set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
		}
	}
}
