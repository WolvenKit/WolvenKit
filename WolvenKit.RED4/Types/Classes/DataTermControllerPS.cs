using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(105)] 
		[RED("triggerType")] 
		public CEnum<EFastTravelTriggerType> TriggerType
		{
			get => GetPropertyValue<CEnum<EFastTravelTriggerType>>();
			set => SetPropertyValue<CEnum<EFastTravelTriggerType>>(value);
		}

		[Ordinal(106)] 
		[RED("fastTravelDeviceType")] 
		public CEnum<EFastTravelDeviceType> FastTravelDeviceType
		{
			get => GetPropertyValue<CEnum<EFastTravelDeviceType>>();
			set => SetPropertyValue<CEnum<EFastTravelDeviceType>>(value);
		}

		public DataTermControllerPS()
		{
			TweakDBRecord = "Devices.DataTerm";
			TweakDBDescriptionRecord = 120924954229;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
