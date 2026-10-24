using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCollisionAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetPropertyValue<NavGenNavigationSetting>();
			set => SetPropertyValue<NavGenNavigationSetting>(value);
		}

		[Ordinal(6)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public worldCollisionAreaNode()
		{
			Color = new CColor { Red = 100, Green = 100, Blue = 100, Alpha = 100 };
			NavigationSetting = new NavGenNavigationSetting();
			FilterData = new physicsFilterData { SimulationFilter = new physicsSimulationFilter { Mask1 = 376836, Mask2 = 5070 }, QueryFilter = new physicsQueryFilter { Mask2 = 143769604 }, Preset = "World Static" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
