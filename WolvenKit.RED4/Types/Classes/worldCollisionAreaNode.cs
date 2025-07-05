using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCollisionAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(8)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public worldCollisionAreaNode()
		{
			NavigationSetting = new NavGenNavigationSetting { NavmeshImpact = Enums.NavGenNavmeshImpact.Blocking };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
