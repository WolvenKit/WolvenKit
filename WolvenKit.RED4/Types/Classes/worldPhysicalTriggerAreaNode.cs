using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPhysicalTriggerAreaNode : worldNode
	{
		[Ordinal(2)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetPropertyValue<physicsTriggerShape>();
			set => SetPropertyValue<physicsTriggerShape>(value);
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		public worldPhysicalTriggerAreaNode()
		{
			SimulationType = Enums.physicsSimulationType.Dynamic;
			Shape = new physicsTriggerShape();
			FilterData = new physicsFilterData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
