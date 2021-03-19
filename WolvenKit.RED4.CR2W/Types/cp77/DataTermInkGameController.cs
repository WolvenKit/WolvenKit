using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkHorizontalPanelWidget> _fcPointsPanel;
		private wCHandle<inkTextWidget> _districtText;
		private wCHandle<inkTextWidget> _pointText;
		private wCHandle<gameFastTravelPointData> _point;
		private CUInt32 _onFastTravelPointUpdateListener;

		[Ordinal(16)] 
		[RED("fcPointsPanel")] 
		public wCHandle<inkHorizontalPanelWidget> FcPointsPanel
		{
			get => GetProperty(ref _fcPointsPanel);
			set => SetProperty(ref _fcPointsPanel, value);
		}

		[Ordinal(17)] 
		[RED("districtText")] 
		public wCHandle<inkTextWidget> DistrictText
		{
			get => GetProperty(ref _districtText);
			set => SetProperty(ref _districtText, value);
		}

		[Ordinal(18)] 
		[RED("pointText")] 
		public wCHandle<inkTextWidget> PointText
		{
			get => GetProperty(ref _pointText);
			set => SetProperty(ref _pointText, value);
		}

		[Ordinal(19)] 
		[RED("point")] 
		public wCHandle<gameFastTravelPointData> Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		[Ordinal(20)] 
		[RED("onFastTravelPointUpdateListener")] 
		public CUInt32 OnFastTravelPointUpdateListener
		{
			get => GetProperty(ref _onFastTravelPointUpdateListener);
			set => SetProperty(ref _onFastTravelPointUpdateListener, value);
		}

		public DataTermInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
