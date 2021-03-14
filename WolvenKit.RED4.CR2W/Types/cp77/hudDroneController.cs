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
		private CHandle<gameIBlackboard> _scanBlackboard;
		private CHandle<gameIBlackboard> _psmBlackboard;
		private CUInt32 _pSM_BBID;
		private wCHandle<inkCompoundWidget> _root;
		private CFloat _currentZoom;
		private GameTime _currentTime;

		[Ordinal(9)] 
		[RED("Date")] 
		public inkTextWidgetReference Date
		{
			get
			{
				if (_date == null)
				{
					_date = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Date", cr2w, this);
				}
				return _date;
			}
			set
			{
				if (_date == value)
				{
					return;
				}
				_date = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Timer")] 
		public inkTextWidgetReference Timer
		{
			get
			{
				if (_timer == null)
				{
					_timer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Timer", cr2w, this);
				}
				return _timer;
			}
			set
			{
				if (_timer == value)
				{
					return;
				}
				_timer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("CameraID")] 
		public inkTextWidgetReference CameraID
		{
			get
			{
				if (_cameraID == null)
				{
					_cameraID = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CameraID", cr2w, this);
				}
				return _cameraID;
			}
			set
			{
				if (_cameraID == value)
				{
					return;
				}
				_cameraID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scanBlackboard")] 
		public CHandle<gameIBlackboard> ScanBlackboard
		{
			get
			{
				if (_scanBlackboard == null)
				{
					_scanBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "scanBlackboard", cr2w, this);
				}
				return _scanBlackboard;
			}
			set
			{
				if (_scanBlackboard == value)
				{
					return;
				}
				_scanBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("psmBlackboard")] 
		public CHandle<gameIBlackboard> PsmBlackboard
		{
			get
			{
				if (_psmBlackboard == null)
				{
					_psmBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "psmBlackboard", cr2w, this);
				}
				return _psmBlackboard;
			}
			set
			{
				if (_psmBlackboard == value)
				{
					return;
				}
				_psmBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("PSM_BBID")] 
		public CUInt32 PSM_BBID
		{
			get
			{
				if (_pSM_BBID == null)
				{
					_pSM_BBID = (CUInt32) CR2WTypeManager.Create("Uint32", "PSM_BBID", cr2w, this);
				}
				return _pSM_BBID;
			}
			set
			{
				if (_pSM_BBID == value)
				{
					return;
				}
				_pSM_BBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get
			{
				if (_currentZoom == null)
				{
					_currentZoom = (CFloat) CR2WTypeManager.Create("Float", "currentZoom", cr2w, this);
				}
				return _currentZoom;
			}
			set
			{
				if (_currentZoom == value)
				{
					return;
				}
				_currentZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (GameTime) CR2WTypeManager.Create("GameTime", "currentTime", cr2w, this);
				}
				return _currentTime;
			}
			set
			{
				if (_currentTime == value)
				{
					return;
				}
				_currentTime = value;
				PropertySet(this);
			}
		}

		public hudDroneController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
