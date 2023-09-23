using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(108)] 
		[RED("triggerType")] 
		public CEnum<EFastTravelTriggerType> TriggerType
		{
			get => GetPropertyValue<CEnum<EFastTravelTriggerType>>();
			set => SetPropertyValue<CEnum<EFastTravelTriggerType>>(value);
		}

		[Ordinal(109)] 
		[RED("fastTravelDeviceType")] 
		public CEnum<EFastTravelDeviceType> FastTravelDeviceType
		{
			get => GetPropertyValue<CEnum<EFastTravelDeviceType>>();
			set => SetPropertyValue<CEnum<EFastTravelDeviceType>>(value);
		}

		public DataTermControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
