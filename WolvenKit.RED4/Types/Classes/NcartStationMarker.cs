using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartStationMarker : gameObject
	{
		[Ordinal(36)] 
		[RED("station")] 
		public CEnum<ENcartStations> Station
		{
			get => GetPropertyValue<CEnum<ENcartStations>>();
			set => SetPropertyValue<CEnum<ENcartStations>>(value);
		}

		[Ordinal(37)] 
		[RED("callBackOnlyIfMatchesDestination")] 
		public CBool CallBackOnlyIfMatchesDestination
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("setAsNewActive")] 
		public CBool SetAsNewActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("onTrainApproachingFact")] 
		public CName OnTrainApproachingFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("TrainGlobalRef")] 
		public CName TrainGlobalRef
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NcartStationMarker()
		{
			CallBackOnlyIfMatchesDestination = true;
			SetAsNewActive = true;
			OnTrainApproachingFact = "ue_metro_arriving_at_station";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
