using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HackingContainer : BaseSkillCheckContainer
	{
		[Ordinal(4)] 
		[RED("hackingCheck")] 
		public CHandle<HackingSkillCheck> HackingCheck
		{
			get => GetPropertyValue<CHandle<HackingSkillCheck>>();
			set => SetPropertyValue<CHandle<HackingSkillCheck>>(value);
		}

		public HackingContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
