using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackEngContainer : BaseSkillCheckContainer
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

		public HackEngContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
