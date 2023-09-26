using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckSpawningStrategy : PreventionConditionAbstract
	{
		[Ordinal(0)] 
		[RED("spawningStrategyToCompare")] 
		public CHandle<AIArgumentMapping> SpawningStrategyToCompare
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("spawningStrategyToCompareAsInt")] 
		public CInt32 SpawningStrategyToCompareAsInt
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("system")] 
		public CHandle<PreventionSystem> System
		{
			get => GetPropertyValue<CHandle<PreventionSystem>>();
			set => SetPropertyValue<CHandle<PreventionSystem>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		public CheckSpawningStrategy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
