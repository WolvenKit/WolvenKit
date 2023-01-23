using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EngDemoContainer : BaseSkillCheckContainer
	{
		[Ordinal(4)] 
		[RED("engineeringCheck")] 
		public CHandle<EngineeringSkillCheck> EngineeringCheck
		{
			get => GetPropertyValue<CHandle<EngineeringSkillCheck>>();
			set => SetPropertyValue<CHandle<EngineeringSkillCheck>>(value);
		}

		[Ordinal(5)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
			set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
		}

		public EngDemoContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
