using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceGameController : gameuiHUDGameController
	{
		private inkWidgetReference _currentTimerMarker;
		private inkTextWidgetReference _currentTimerText;
		private inkTextWidgetReference _activeLayer;
		private inkImageWidgetReference _layerIcon;
		private inkImageWidgetReference _layerThermalIcon;
		private inkImageWidgetReference _layerVisualIcon;
		private inkImageWidgetReference _layerAudioIcon;
		private inkWidgetReference _cursorPoint;
		private inkWidgetReference _buttonHintsManagerRef;
		private CArray<inkCompoundWidgetReference> _clueHolder;
		private CArray<inkWidgetReference> _clueBarHolder;
		private CArray<inkWidgetReference> _speedIndicatorManagers;
		private CArray<CHandle<BraindanceClueLogicController>> _clueArray;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CFloat _barSize;
		private CFloat _braindanceDuration;
		private CFloat _currentTime;
		private CHandle<inkWidget> _rootWidget;
		private CEnum<gameuiEBraindanceLayer> _currentLayer;
		private CEnum<scnPlaySpeed> _currentSpeed;
		private CEnum<scnPlayDirection> _currentDirection;
		private CFloat _startingTimerTopMargin;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameIBlackboard> _braindanceBB;
		private CHandle<BraindanceBlackboardDef> _braindanceDef;
		private CUInt32 _clueBBID;
		private CUInt32 _visionModeBBID;
		private CUInt32 _progressBBID;
		private CUInt32 _sectionTimeBBID;
		private CUInt32 _isActiveBBID;
		private CUInt32 _enableExitBBID;
		private CUInt32 _isFPPBBID;
		private CUInt32 _playbackSpeedID;
		private CUInt32 _playbackDirectionID;
		private CBool _isFPPMode;
		private CHandle<inkanimProxy> _showTimelineAnimation;
		private CHandle<inkanimProxy> _hideTimelineAnimation;
		private CHandle<inkanimProxy> _showWidgetAnimation;

		[Ordinal(9)] 
		[RED("currentTimerMarker")] 
		public inkWidgetReference CurrentTimerMarker
		{
			get
			{
				if (_currentTimerMarker == null)
				{
					_currentTimerMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "currentTimerMarker", cr2w, this);
				}
				return _currentTimerMarker;
			}
			set
			{
				if (_currentTimerMarker == value)
				{
					return;
				}
				_currentTimerMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentTimerText")] 
		public inkTextWidgetReference CurrentTimerText
		{
			get
			{
				if (_currentTimerText == null)
				{
					_currentTimerText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "currentTimerText", cr2w, this);
				}
				return _currentTimerText;
			}
			set
			{
				if (_currentTimerText == value)
				{
					return;
				}
				_currentTimerText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("activeLayer")] 
		public inkTextWidgetReference ActiveLayer
		{
			get
			{
				if (_activeLayer == null)
				{
					_activeLayer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "activeLayer", cr2w, this);
				}
				return _activeLayer;
			}
			set
			{
				if (_activeLayer == value)
				{
					return;
				}
				_activeLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("layerIcon")] 
		public inkImageWidgetReference LayerIcon
		{
			get
			{
				if (_layerIcon == null)
				{
					_layerIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "layerIcon", cr2w, this);
				}
				return _layerIcon;
			}
			set
			{
				if (_layerIcon == value)
				{
					return;
				}
				_layerIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("layerThermalIcon")] 
		public inkImageWidgetReference LayerThermalIcon
		{
			get
			{
				if (_layerThermalIcon == null)
				{
					_layerThermalIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "layerThermalIcon", cr2w, this);
				}
				return _layerThermalIcon;
			}
			set
			{
				if (_layerThermalIcon == value)
				{
					return;
				}
				_layerThermalIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("layerVisualIcon")] 
		public inkImageWidgetReference LayerVisualIcon
		{
			get
			{
				if (_layerVisualIcon == null)
				{
					_layerVisualIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "layerVisualIcon", cr2w, this);
				}
				return _layerVisualIcon;
			}
			set
			{
				if (_layerVisualIcon == value)
				{
					return;
				}
				_layerVisualIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("layerAudioIcon")] 
		public inkImageWidgetReference LayerAudioIcon
		{
			get
			{
				if (_layerAudioIcon == null)
				{
					_layerAudioIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "layerAudioIcon", cr2w, this);
				}
				return _layerAudioIcon;
			}
			set
			{
				if (_layerAudioIcon == value)
				{
					return;
				}
				_layerAudioIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cursorPoint")] 
		public inkWidgetReference CursorPoint
		{
			get
			{
				if (_cursorPoint == null)
				{
					_cursorPoint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cursorPoint", cr2w, this);
				}
				return _cursorPoint;
			}
			set
			{
				if (_cursorPoint == value)
				{
					return;
				}
				_cursorPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("clueHolder")] 
		public CArray<inkCompoundWidgetReference> ClueHolder
		{
			get
			{
				if (_clueHolder == null)
				{
					_clueHolder = (CArray<inkCompoundWidgetReference>) CR2WTypeManager.Create("array:inkCompoundWidgetReference", "clueHolder", cr2w, this);
				}
				return _clueHolder;
			}
			set
			{
				if (_clueHolder == value)
				{
					return;
				}
				_clueHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("clueBarHolder")] 
		public CArray<inkWidgetReference> ClueBarHolder
		{
			get
			{
				if (_clueBarHolder == null)
				{
					_clueBarHolder = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "clueBarHolder", cr2w, this);
				}
				return _clueBarHolder;
			}
			set
			{
				if (_clueBarHolder == value)
				{
					return;
				}
				_clueBarHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("speedIndicatorManagers")] 
		public CArray<inkWidgetReference> SpeedIndicatorManagers
		{
			get
			{
				if (_speedIndicatorManagers == null)
				{
					_speedIndicatorManagers = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "speedIndicatorManagers", cr2w, this);
				}
				return _speedIndicatorManagers;
			}
			set
			{
				if (_speedIndicatorManagers == value)
				{
					return;
				}
				_speedIndicatorManagers = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("clueArray")] 
		public CArray<CHandle<BraindanceClueLogicController>> ClueArray
		{
			get
			{
				if (_clueArray == null)
				{
					_clueArray = (CArray<CHandle<BraindanceClueLogicController>>) CR2WTypeManager.Create("array:handle:BraindanceClueLogicController", "clueArray", cr2w, this);
				}
				return _clueArray;
			}
			set
			{
				if (_clueArray == value)
				{
					return;
				}
				_clueArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("barSize")] 
		public CFloat BarSize
		{
			get
			{
				if (_barSize == null)
				{
					_barSize = (CFloat) CR2WTypeManager.Create("Float", "barSize", cr2w, this);
				}
				return _barSize;
			}
			set
			{
				if (_barSize == value)
				{
					return;
				}
				_barSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("braindanceDuration")] 
		public CFloat BraindanceDuration
		{
			get
			{
				if (_braindanceDuration == null)
				{
					_braindanceDuration = (CFloat) CR2WTypeManager.Create("Float", "braindanceDuration", cr2w, this);
				}
				return _braindanceDuration;
			}
			set
			{
				if (_braindanceDuration == value)
				{
					return;
				}
				_braindanceDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get
			{
				if (_currentTime == null)
				{
					_currentTime = (CFloat) CR2WTypeManager.Create("Float", "currentTime", cr2w, this);
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

		[Ordinal(26)] 
		[RED("rootWidget")] 
		public CHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("currentLayer")] 
		public CEnum<gameuiEBraindanceLayer> CurrentLayer
		{
			get
			{
				if (_currentLayer == null)
				{
					_currentLayer = (CEnum<gameuiEBraindanceLayer>) CR2WTypeManager.Create("gameuiEBraindanceLayer", "currentLayer", cr2w, this);
				}
				return _currentLayer;
			}
			set
			{
				if (_currentLayer == value)
				{
					return;
				}
				_currentLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("currentSpeed")] 
		public CEnum<scnPlaySpeed> CurrentSpeed
		{
			get
			{
				if (_currentSpeed == null)
				{
					_currentSpeed = (CEnum<scnPlaySpeed>) CR2WTypeManager.Create("scnPlaySpeed", "currentSpeed", cr2w, this);
				}
				return _currentSpeed;
			}
			set
			{
				if (_currentSpeed == value)
				{
					return;
				}
				_currentSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("currentDirection")] 
		public CEnum<scnPlayDirection> CurrentDirection
		{
			get
			{
				if (_currentDirection == null)
				{
					_currentDirection = (CEnum<scnPlayDirection>) CR2WTypeManager.Create("scnPlayDirection", "currentDirection", cr2w, this);
				}
				return _currentDirection;
			}
			set
			{
				if (_currentDirection == value)
				{
					return;
				}
				_currentDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("startingTimerTopMargin")] 
		public CFloat StartingTimerTopMargin
		{
			get
			{
				if (_startingTimerTopMargin == null)
				{
					_startingTimerTopMargin = (CFloat) CR2WTypeManager.Create("Float", "startingTimerTopMargin", cr2w, this);
				}
				return _startingTimerTopMargin;
			}
			set
			{
				if (_startingTimerTopMargin == value)
				{
					return;
				}
				_startingTimerTopMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("braindanceBB")] 
		public CHandle<gameIBlackboard> BraindanceBB
		{
			get
			{
				if (_braindanceBB == null)
				{
					_braindanceBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "braindanceBB", cr2w, this);
				}
				return _braindanceBB;
			}
			set
			{
				if (_braindanceBB == value)
				{
					return;
				}
				_braindanceBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("braindanceDef")] 
		public CHandle<BraindanceBlackboardDef> BraindanceDef
		{
			get
			{
				if (_braindanceDef == null)
				{
					_braindanceDef = (CHandle<BraindanceBlackboardDef>) CR2WTypeManager.Create("handle:BraindanceBlackboardDef", "braindanceDef", cr2w, this);
				}
				return _braindanceDef;
			}
			set
			{
				if (_braindanceDef == value)
				{
					return;
				}
				_braindanceDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("ClueBBID")] 
		public CUInt32 ClueBBID
		{
			get
			{
				if (_clueBBID == null)
				{
					_clueBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "ClueBBID", cr2w, this);
				}
				return _clueBBID;
			}
			set
			{
				if (_clueBBID == value)
				{
					return;
				}
				_clueBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("VisionModeBBID")] 
		public CUInt32 VisionModeBBID
		{
			get
			{
				if (_visionModeBBID == null)
				{
					_visionModeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "VisionModeBBID", cr2w, this);
				}
				return _visionModeBBID;
			}
			set
			{
				if (_visionModeBBID == value)
				{
					return;
				}
				_visionModeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("ProgressBBID")] 
		public CUInt32 ProgressBBID
		{
			get
			{
				if (_progressBBID == null)
				{
					_progressBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "ProgressBBID", cr2w, this);
				}
				return _progressBBID;
			}
			set
			{
				if (_progressBBID == value)
				{
					return;
				}
				_progressBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("SectionTimeBBID")] 
		public CUInt32 SectionTimeBBID
		{
			get
			{
				if (_sectionTimeBBID == null)
				{
					_sectionTimeBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "SectionTimeBBID", cr2w, this);
				}
				return _sectionTimeBBID;
			}
			set
			{
				if (_sectionTimeBBID == value)
				{
					return;
				}
				_sectionTimeBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("IsActiveBBID")] 
		public CUInt32 IsActiveBBID
		{
			get
			{
				if (_isActiveBBID == null)
				{
					_isActiveBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "IsActiveBBID", cr2w, this);
				}
				return _isActiveBBID;
			}
			set
			{
				if (_isActiveBBID == value)
				{
					return;
				}
				_isActiveBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("EnableExitBBID")] 
		public CUInt32 EnableExitBBID
		{
			get
			{
				if (_enableExitBBID == null)
				{
					_enableExitBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "EnableExitBBID", cr2w, this);
				}
				return _enableExitBBID;
			}
			set
			{
				if (_enableExitBBID == value)
				{
					return;
				}
				_enableExitBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("IsFPPBBID")] 
		public CUInt32 IsFPPBBID
		{
			get
			{
				if (_isFPPBBID == null)
				{
					_isFPPBBID = (CUInt32) CR2WTypeManager.Create("Uint32", "IsFPPBBID", cr2w, this);
				}
				return _isFPPBBID;
			}
			set
			{
				if (_isFPPBBID == value)
				{
					return;
				}
				_isFPPBBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("PlaybackSpeedID")] 
		public CUInt32 PlaybackSpeedID
		{
			get
			{
				if (_playbackSpeedID == null)
				{
					_playbackSpeedID = (CUInt32) CR2WTypeManager.Create("Uint32", "PlaybackSpeedID", cr2w, this);
				}
				return _playbackSpeedID;
			}
			set
			{
				if (_playbackSpeedID == value)
				{
					return;
				}
				_playbackSpeedID = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("PlaybackDirectionID")] 
		public CUInt32 PlaybackDirectionID
		{
			get
			{
				if (_playbackDirectionID == null)
				{
					_playbackDirectionID = (CUInt32) CR2WTypeManager.Create("Uint32", "PlaybackDirectionID", cr2w, this);
				}
				return _playbackDirectionID;
			}
			set
			{
				if (_playbackDirectionID == value)
				{
					return;
				}
				_playbackDirectionID = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("isFPPMode")] 
		public CBool IsFPPMode
		{
			get
			{
				if (_isFPPMode == null)
				{
					_isFPPMode = (CBool) CR2WTypeManager.Create("Bool", "isFPPMode", cr2w, this);
				}
				return _isFPPMode;
			}
			set
			{
				if (_isFPPMode == value)
				{
					return;
				}
				_isFPPMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("showTimelineAnimation")] 
		public CHandle<inkanimProxy> ShowTimelineAnimation
		{
			get
			{
				if (_showTimelineAnimation == null)
				{
					_showTimelineAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showTimelineAnimation", cr2w, this);
				}
				return _showTimelineAnimation;
			}
			set
			{
				if (_showTimelineAnimation == value)
				{
					return;
				}
				_showTimelineAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("hideTimelineAnimation")] 
		public CHandle<inkanimProxy> HideTimelineAnimation
		{
			get
			{
				if (_hideTimelineAnimation == null)
				{
					_hideTimelineAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "hideTimelineAnimation", cr2w, this);
				}
				return _hideTimelineAnimation;
			}
			set
			{
				if (_hideTimelineAnimation == value)
				{
					return;
				}
				_hideTimelineAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("showWidgetAnimation")] 
		public CHandle<inkanimProxy> ShowWidgetAnimation
		{
			get
			{
				if (_showWidgetAnimation == null)
				{
					_showWidgetAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showWidgetAnimation", cr2w, this);
				}
				return _showWidgetAnimation;
			}
			set
			{
				if (_showWidgetAnimation == value)
				{
					return;
				}
				_showWidgetAnimation = value;
				PropertySet(this);
			}
		}

		public BraindanceGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
