using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorInkGameController : DeviceInkGameControllerBase
	{
		private inkVerticalPanelWidgetReference _verticalPanel;
		private inkTextWidgetReference _currentFloorTextWidget;
		private inkCanvasWidgetReference _openCloseButtonWidgets;
		private inkFlexWidgetReference _elevatorUpArrowsWidget;
		private inkFlexWidgetReference _elevatorDownArrowsWidget;
		private inkCanvasWidgetReference _waitingStateWidget;
		private inkCanvasWidgetReference _dataScanningWidget;
		private inkCanvasWidgetReference _elevatorStoppedWidget;
		private CBool _isPlayerScanned;
		private CBool _isPaused;
		private CBool _isAuthorized;
		private CHandle<inkanimProxy> _animProxy;
		private CArray<CFloat> _buttonSizes;
		private CUInt32 _onChangeFloorListener;
		private CUInt32 _onPlayerScannedListener;
		private CUInt32 _onPausedChangeListener;

		[Ordinal(16)] 
		[RED("verticalPanel")] 
		public inkVerticalPanelWidgetReference VerticalPanel
		{
			get
			{
				if (_verticalPanel == null)
				{
					_verticalPanel = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "verticalPanel", cr2w, this);
				}
				return _verticalPanel;
			}
			set
			{
				if (_verticalPanel == value)
				{
					return;
				}
				_verticalPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("currentFloorTextWidget")] 
		public inkTextWidgetReference CurrentFloorTextWidget
		{
			get
			{
				if (_currentFloorTextWidget == null)
				{
					_currentFloorTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentFloorTextWidget", cr2w, this);
				}
				return _currentFloorTextWidget;
			}
			set
			{
				if (_currentFloorTextWidget == value)
				{
					return;
				}
				_currentFloorTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("openCloseButtonWidgets")] 
		public inkCanvasWidgetReference OpenCloseButtonWidgets
		{
			get
			{
				if (_openCloseButtonWidgets == null)
				{
					_openCloseButtonWidgets = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "openCloseButtonWidgets", cr2w, this);
				}
				return _openCloseButtonWidgets;
			}
			set
			{
				if (_openCloseButtonWidgets == value)
				{
					return;
				}
				_openCloseButtonWidgets = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("elevatorUpArrowsWidget")] 
		public inkFlexWidgetReference ElevatorUpArrowsWidget
		{
			get
			{
				if (_elevatorUpArrowsWidget == null)
				{
					_elevatorUpArrowsWidget = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "elevatorUpArrowsWidget", cr2w, this);
				}
				return _elevatorUpArrowsWidget;
			}
			set
			{
				if (_elevatorUpArrowsWidget == value)
				{
					return;
				}
				_elevatorUpArrowsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("elevatorDownArrowsWidget")] 
		public inkFlexWidgetReference ElevatorDownArrowsWidget
		{
			get
			{
				if (_elevatorDownArrowsWidget == null)
				{
					_elevatorDownArrowsWidget = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "elevatorDownArrowsWidget", cr2w, this);
				}
				return _elevatorDownArrowsWidget;
			}
			set
			{
				if (_elevatorDownArrowsWidget == value)
				{
					return;
				}
				_elevatorDownArrowsWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("waitingStateWidget")] 
		public inkCanvasWidgetReference WaitingStateWidget
		{
			get
			{
				if (_waitingStateWidget == null)
				{
					_waitingStateWidget = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "waitingStateWidget", cr2w, this);
				}
				return _waitingStateWidget;
			}
			set
			{
				if (_waitingStateWidget == value)
				{
					return;
				}
				_waitingStateWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("dataScanningWidget")] 
		public inkCanvasWidgetReference DataScanningWidget
		{
			get
			{
				if (_dataScanningWidget == null)
				{
					_dataScanningWidget = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "dataScanningWidget", cr2w, this);
				}
				return _dataScanningWidget;
			}
			set
			{
				if (_dataScanningWidget == value)
				{
					return;
				}
				_dataScanningWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("elevatorStoppedWidget")] 
		public inkCanvasWidgetReference ElevatorStoppedWidget
		{
			get
			{
				if (_elevatorStoppedWidget == null)
				{
					_elevatorStoppedWidget = (inkCanvasWidgetReference) CR2WTypeManager.Create("inkCanvasWidgetReference", "elevatorStoppedWidget", cr2w, this);
				}
				return _elevatorStoppedWidget;
			}
			set
			{
				if (_elevatorStoppedWidget == value)
				{
					return;
				}
				_elevatorStoppedWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("isPlayerScanned")] 
		public CBool IsPlayerScanned
		{
			get
			{
				if (_isPlayerScanned == null)
				{
					_isPlayerScanned = (CBool) CR2WTypeManager.Create("Bool", "isPlayerScanned", cr2w, this);
				}
				return _isPlayerScanned;
			}
			set
			{
				if (_isPlayerScanned == value)
				{
					return;
				}
				_isPlayerScanned = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get
			{
				if (_isPaused == null)
				{
					_isPaused = (CBool) CR2WTypeManager.Create("Bool", "isPaused", cr2w, this);
				}
				return _isPaused;
			}
			set
			{
				if (_isPaused == value)
				{
					return;
				}
				_isPaused = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("isAuthorized")] 
		public CBool IsAuthorized
		{
			get
			{
				if (_isAuthorized == null)
				{
					_isAuthorized = (CBool) CR2WTypeManager.Create("Bool", "isAuthorized", cr2w, this);
				}
				return _isAuthorized;
			}
			set
			{
				if (_isAuthorized == value)
				{
					return;
				}
				_isAuthorized = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("buttonSizes")] 
		public CArray<CFloat> ButtonSizes
		{
			get
			{
				if (_buttonSizes == null)
				{
					_buttonSizes = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "buttonSizes", cr2w, this);
				}
				return _buttonSizes;
			}
			set
			{
				if (_buttonSizes == value)
				{
					return;
				}
				_buttonSizes = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("onChangeFloorListener")] 
		public CUInt32 OnChangeFloorListener
		{
			get
			{
				if (_onChangeFloorListener == null)
				{
					_onChangeFloorListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onChangeFloorListener", cr2w, this);
				}
				return _onChangeFloorListener;
			}
			set
			{
				if (_onChangeFloorListener == value)
				{
					return;
				}
				_onChangeFloorListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("onPlayerScannedListener")] 
		public CUInt32 OnPlayerScannedListener
		{
			get
			{
				if (_onPlayerScannedListener == null)
				{
					_onPlayerScannedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onPlayerScannedListener", cr2w, this);
				}
				return _onPlayerScannedListener;
			}
			set
			{
				if (_onPlayerScannedListener == value)
				{
					return;
				}
				_onPlayerScannedListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("onPausedChangeListener")] 
		public CUInt32 OnPausedChangeListener
		{
			get
			{
				if (_onPausedChangeListener == null)
				{
					_onPausedChangeListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onPausedChangeListener", cr2w, this);
				}
				return _onPausedChangeListener;
			}
			set
			{
				if (_onPausedChangeListener == value)
				{
					return;
				}
				_onPausedChangeListener = value;
				PropertySet(this);
			}
		}

		public ElevatorInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
