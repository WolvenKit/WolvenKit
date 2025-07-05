using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericContainer : BaseSkillCheckContainer
	{
		[Ordinal(4)] 
		[RED("hackingCheck")] 
		public CHandle<HackingSkillCheck> HackingCheck
		{
			get => GetPropertyValue<CHandle<HackingSkillCheck>>();
			set => SetPropertyValue<CHandle<HackingSkillCheck>>(value);
		}

		[Ordinal(5)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
			set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
		}

		[Ordinal(6)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
			set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
		}

		public GenericContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
