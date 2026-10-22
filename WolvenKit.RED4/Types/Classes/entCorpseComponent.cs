using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entCorpseComponent : entISkinableComponent
	{
		[Ordinal(5)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(6)] 
		[RED("material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entCorpseComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			FilterData = new physicsFilterData { SimulationFilter = new physicsSimulationFilter { Mask1 = 114696, Mask2 = 23627 }, QueryFilter = new physicsQueryFilter { Mask2 = 139837704 }, Preset = "Device solid visible" };
			Material = "flesh.physmat";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
