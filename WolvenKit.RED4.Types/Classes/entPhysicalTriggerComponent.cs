using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entPhysicalTriggerComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(6)] 
		[RED("shape")] 
		public physicsTriggerShape Shape
		{
			get => GetPropertyValue<physicsTriggerShape>();
			set => SetPropertyValue<physicsTriggerShape>(value);
		}

		[Ordinal(7)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetPropertyValue<CHandle<physicsFilterData>>();
			set => SetPropertyValue<CHandle<physicsFilterData>>(value);
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entPhysicalTriggerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
