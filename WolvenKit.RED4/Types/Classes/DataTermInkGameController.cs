using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DataTermInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("fcPointsPanel")] 
		public CWeakHandle<inkHorizontalPanelWidget> FcPointsPanel
		{
			get => GetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkHorizontalPanelWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("districtText")] 
		public CWeakHandle<inkTextWidget> DistrictText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("pointText")] 
		public CWeakHandle<inkTextWidget> PointText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("point")] 
		public CWeakHandle<gameFastTravelPointData> Point
		{
			get => GetPropertyValue<CWeakHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CWeakHandle<gameFastTravelPointData>>(value);
		}

		[Ordinal(20)] 
		[RED("onFastTravelPointUpdateListener")] 
		public CHandle<redCallbackObject> OnFastTravelPointUpdateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
		[RED("onToggleHologramListener")] 
		public CHandle<redCallbackObject> OnToggleHologramListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DataTermInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
