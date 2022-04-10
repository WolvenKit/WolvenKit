using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NavGenNavigationSetting : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("navmeshImpact")] 
		public CEnum<NavGenNavmeshImpact> NavmeshImpact
		{
			get => GetPropertyValue<CEnum<NavGenNavmeshImpact>>();
			set => SetPropertyValue<CEnum<NavGenNavmeshImpact>>(value);
		}

		public NavGenNavigationSetting()
		{
			NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
