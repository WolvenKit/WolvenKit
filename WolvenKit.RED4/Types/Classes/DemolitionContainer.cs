using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DemolitionContainer : BaseSkillCheckContainer
	{
		[Ordinal(4)] 
		[RED("demolitionCheck")] 
		public CHandle<DemolitionSkillCheck> DemolitionCheck
		{
			get => GetPropertyValue<CHandle<DemolitionSkillCheck>>();
			set => SetPropertyValue<CHandle<DemolitionSkillCheck>>(value);
		}

		public DemolitionContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
