using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudDroneController : gameuiHUDGameController
	{
		private inkTextWidgetReference _date;
		private inkTextWidgetReference _timer;
		private inkTextWidgetReference _cameraID;
		private wCHandle<gameIBlackboard> _scanBlackboard;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private wCHandle<inkCompoundWidget> _root;
		private CFloat _currentZoom;
		private GameTime _currentTime;

		[Ordinal(9)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get => GetProperty(ref _date);
			set => SetProperty(ref _date, value);
		}

		[Ordinal(10)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get => GetProperty(ref _timer);
			set => SetProperty(ref _timer, value);
		}

		[Ordinal(11)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get => GetProperty(ref _cameraID);
			set => SetProperty(ref _cameraID, value);
		}

		[Ordinal(12)] 
		[RED("scanBlackboard")] 
		public wCHandle<gameIBlackboard> ScanBlackboard
		{
			get => GetProperty(ref _scanBlackboard);
			set => SetProperty(ref _scanBlackboard, value);
		}

		[Ordinal(13)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(15)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(16)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetProperty(ref _currentZoom);
			set => SetProperty(ref _currentZoom, value);
		}

		[Ordinal(17)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		public hudDroneController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
