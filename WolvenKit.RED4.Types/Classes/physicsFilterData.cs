using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsFilterData : ISerializable
	{
		[Ordinal(0)] 
		[RED("simulationFilter")] 
		public physicsSimulationFilter SimulationFilter
		{
			get => GetPropertyValue<physicsSimulationFilter>();
			set => SetPropertyValue<physicsSimulationFilter>(value);
		}

		[Ordinal(1)] 
		[RED("queryFilter")] 
		public physicsQueryFilter QueryFilter
		{
			get => GetPropertyValue<physicsQueryFilter>();
			set => SetPropertyValue<physicsQueryFilter>(value);
		}

		[Ordinal(2)] 
		[RED("preset")] 
		public CName Preset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("customFilterData")] 
		public CHandle<physicsCustomFilterData> CustomFilterData
		{
			get => GetPropertyValue<CHandle<physicsCustomFilterData>>();
			set => SetPropertyValue<CHandle<physicsCustomFilterData>>(value);
		}

		public physicsFilterData()
		{
			SimulationFilter = new();
			QueryFilter = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
