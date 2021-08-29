using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DataTermInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<inkHorizontalPanelWidget> _fcPointsPanel;
		private CWeakHandle<inkTextWidget> _districtText;
		private CWeakHandle<inkTextWidget> _pointText;
		private CWeakHandle<gameFastTravelPointData> _point;
		private CHandle<redCallbackObject> _onFastTravelPointUpdateListener;

		[Ordinal(16)] 
		[RED("fcPointsPanel")] 
		public CWeakHandle<inkHorizontalPanelWidget> FcPointsPanel
		{
			get => GetProperty(ref _fcPointsPanel);
			set => SetProperty(ref _fcPointsPanel, value);
		}

		[Ordinal(17)] 
		[RED("districtText")] 
		public CWeakHandle<inkTextWidget> DistrictText
		{
			get => GetProperty(ref _districtText);
			set => SetProperty(ref _districtText, value);
		}

		[Ordinal(18)] 
		[RED("pointText")] 
		public CWeakHandle<inkTextWidget> PointText
		{
			get => GetProperty(ref _pointText);
			set => SetProperty(ref _pointText, value);
		}

		[Ordinal(19)] 
		[RED("point")] 
		public CWeakHandle<gameFastTravelPointData> Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		[Ordinal(20)] 
		[RED("onFastTravelPointUpdateListener")] 
		public CHandle<redCallbackObject> OnFastTravelPointUpdateListener
		{
			get => GetProperty(ref _onFastTravelPointUpdateListener);
			set => SetProperty(ref _onFastTravelPointUpdateListener, value);
		}
	}
}
