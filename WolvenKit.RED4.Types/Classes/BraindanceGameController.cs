using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BraindanceGameController : gameuiHUDGameController
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
		private CArray<CWeakHandle<BraindanceClueLogicController>> _clueArray;
		private CWeakHandle<ButtonHints> _buttonHintsController;
		private CFloat _barSize;
		private CFloat _braindanceDuration;
		private CFloat _currentTime;
		private CWeakHandle<inkWidget> _rootWidget;
		private CEnum<gameuiEBraindanceLayer> _currentLayer;
		private CEnum<scnPlaySpeed> _currentSpeed;
		private CEnum<scnPlayDirection> _currentDirection;
		private CFloat _startingTimerTopMargin;
		private ScriptGameInstance _gameInstance;
		private CWeakHandle<gameIBlackboard> _braindanceBB;
		private CHandle<BraindanceBlackboardDef> _braindanceDef;
		private CHandle<redCallbackObject> _clueBBID;
		private CHandle<redCallbackObject> _visionModeBBID;
		private CHandle<redCallbackObject> _progressBBID;
		private CHandle<redCallbackObject> _sectionTimeBBID;
		private CHandle<redCallbackObject> _isActiveBBID;
		private CHandle<redCallbackObject> _enableExitBBID;
		private CHandle<redCallbackObject> _isFPPBBID;
		private CHandle<redCallbackObject> _playbackSpeedID;
		private CHandle<redCallbackObject> _playbackDirectionID;
		private CBool _isFPPMode;
		private CHandle<inkanimProxy> _showTimelineAnimation;
		private CHandle<inkanimProxy> _hideTimelineAnimation;
		private CHandle<inkanimProxy> _showWidgetAnimation;

		[Ordinal(9)] 
		[RED("currentTimerMarker")] 
		public inkWidgetReference CurrentTimerMarker
		{
			get => GetProperty(ref _currentTimerMarker);
			set => SetProperty(ref _currentTimerMarker, value);
		}

		[Ordinal(10)] 
		[RED("currentTimerText")] 
		public inkTextWidgetReference CurrentTimerText
		{
			get => GetProperty(ref _currentTimerText);
			set => SetProperty(ref _currentTimerText, value);
		}

		[Ordinal(11)] 
		[RED("activeLayer")] 
		public inkTextWidgetReference ActiveLayer
		{
			get => GetProperty(ref _activeLayer);
			set => SetProperty(ref _activeLayer, value);
		}

		[Ordinal(12)] 
		[RED("layerIcon")] 
		public inkImageWidgetReference LayerIcon
		{
			get => GetProperty(ref _layerIcon);
			set => SetProperty(ref _layerIcon, value);
		}

		[Ordinal(13)] 
		[RED("layerThermalIcon")] 
		public inkImageWidgetReference LayerThermalIcon
		{
			get => GetProperty(ref _layerThermalIcon);
			set => SetProperty(ref _layerThermalIcon, value);
		}

		[Ordinal(14)] 
		[RED("layerVisualIcon")] 
		public inkImageWidgetReference LayerVisualIcon
		{
			get => GetProperty(ref _layerVisualIcon);
			set => SetProperty(ref _layerVisualIcon, value);
		}

		[Ordinal(15)] 
		[RED("layerAudioIcon")] 
		public inkImageWidgetReference LayerAudioIcon
		{
			get => GetProperty(ref _layerAudioIcon);
			set => SetProperty(ref _layerAudioIcon, value);
		}

		[Ordinal(16)] 
		[RED("cursorPoint")] 
		public inkWidgetReference CursorPoint
		{
			get => GetProperty(ref _cursorPoint);
			set => SetProperty(ref _cursorPoint, value);
		}

		[Ordinal(17)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(18)] 
		[RED("clueHolder")] 
		public CArray<inkCompoundWidgetReference> ClueHolder
		{
			get => GetProperty(ref _clueHolder);
			set => SetProperty(ref _clueHolder, value);
		}

		[Ordinal(19)] 
		[RED("clueBarHolder")] 
		public CArray<inkWidgetReference> ClueBarHolder
		{
			get => GetProperty(ref _clueBarHolder);
			set => SetProperty(ref _clueBarHolder, value);
		}

		[Ordinal(20)] 
		[RED("speedIndicatorManagers")] 
		public CArray<inkWidgetReference> SpeedIndicatorManagers
		{
			get => GetProperty(ref _speedIndicatorManagers);
			set => SetProperty(ref _speedIndicatorManagers, value);
		}

		[Ordinal(21)] 
		[RED("clueArray")] 
		public CArray<CWeakHandle<BraindanceClueLogicController>> ClueArray
		{
			get => GetProperty(ref _clueArray);
			set => SetProperty(ref _clueArray, value);
		}

		[Ordinal(22)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(23)] 
		[RED("barSize")] 
		public CFloat BarSize
		{
			get => GetProperty(ref _barSize);
			set => SetProperty(ref _barSize, value);
		}

		[Ordinal(24)] 
		[RED("braindanceDuration")] 
		public CFloat BraindanceDuration
		{
			get => GetProperty(ref _braindanceDuration);
			set => SetProperty(ref _braindanceDuration, value);
		}

		[Ordinal(25)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(26)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(27)] 
		[RED("currentLayer")] 
		public CEnum<gameuiEBraindanceLayer> CurrentLayer
		{
			get => GetProperty(ref _currentLayer);
			set => SetProperty(ref _currentLayer, value);
		}

		[Ordinal(28)] 
		[RED("currentSpeed")] 
		public CEnum<scnPlaySpeed> CurrentSpeed
		{
			get => GetProperty(ref _currentSpeed);
			set => SetProperty(ref _currentSpeed, value);
		}

		[Ordinal(29)] 
		[RED("currentDirection")] 
		public CEnum<scnPlayDirection> CurrentDirection
		{
			get => GetProperty(ref _currentDirection);
			set => SetProperty(ref _currentDirection, value);
		}

		[Ordinal(30)] 
		[RED("startingTimerTopMargin")] 
		public CFloat StartingTimerTopMargin
		{
			get => GetProperty(ref _startingTimerTopMargin);
			set => SetProperty(ref _startingTimerTopMargin, value);
		}

		[Ordinal(31)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(32)] 
		[RED("braindanceBB")] 
		public CWeakHandle<gameIBlackboard> BraindanceBB
		{
			get => GetProperty(ref _braindanceBB);
			set => SetProperty(ref _braindanceBB, value);
		}

		[Ordinal(33)] 
		[RED("braindanceDef")] 
		public CHandle<BraindanceBlackboardDef> BraindanceDef
		{
			get => GetProperty(ref _braindanceDef);
			set => SetProperty(ref _braindanceDef, value);
		}

		[Ordinal(34)] 
		[RED("ClueBBID")] 
		public CHandle<redCallbackObject> ClueBBID
		{
			get => GetProperty(ref _clueBBID);
			set => SetProperty(ref _clueBBID, value);
		}

		[Ordinal(35)] 
		[RED("VisionModeBBID")] 
		public CHandle<redCallbackObject> VisionModeBBID
		{
			get => GetProperty(ref _visionModeBBID);
			set => SetProperty(ref _visionModeBBID, value);
		}

		[Ordinal(36)] 
		[RED("ProgressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		[Ordinal(37)] 
		[RED("SectionTimeBBID")] 
		public CHandle<redCallbackObject> SectionTimeBBID
		{
			get => GetProperty(ref _sectionTimeBBID);
			set => SetProperty(ref _sectionTimeBBID, value);
		}

		[Ordinal(38)] 
		[RED("IsActiveBBID")] 
		public CHandle<redCallbackObject> IsActiveBBID
		{
			get => GetProperty(ref _isActiveBBID);
			set => SetProperty(ref _isActiveBBID, value);
		}

		[Ordinal(39)] 
		[RED("EnableExitBBID")] 
		public CHandle<redCallbackObject> EnableExitBBID
		{
			get => GetProperty(ref _enableExitBBID);
			set => SetProperty(ref _enableExitBBID, value);
		}

		[Ordinal(40)] 
		[RED("IsFPPBBID")] 
		public CHandle<redCallbackObject> IsFPPBBID
		{
			get => GetProperty(ref _isFPPBBID);
			set => SetProperty(ref _isFPPBBID, value);
		}

		[Ordinal(41)] 
		[RED("PlaybackSpeedID")] 
		public CHandle<redCallbackObject> PlaybackSpeedID
		{
			get => GetProperty(ref _playbackSpeedID);
			set => SetProperty(ref _playbackSpeedID, value);
		}

		[Ordinal(42)] 
		[RED("PlaybackDirectionID")] 
		public CHandle<redCallbackObject> PlaybackDirectionID
		{
			get => GetProperty(ref _playbackDirectionID);
			set => SetProperty(ref _playbackDirectionID, value);
		}

		[Ordinal(43)] 
		[RED("isFPPMode")] 
		public CBool IsFPPMode
		{
			get => GetProperty(ref _isFPPMode);
			set => SetProperty(ref _isFPPMode, value);
		}

		[Ordinal(44)] 
		[RED("showTimelineAnimation")] 
		public CHandle<inkanimProxy> ShowTimelineAnimation
		{
			get => GetProperty(ref _showTimelineAnimation);
			set => SetProperty(ref _showTimelineAnimation, value);
		}

		[Ordinal(45)] 
		[RED("hideTimelineAnimation")] 
		public CHandle<inkanimProxy> HideTimelineAnimation
		{
			get => GetProperty(ref _hideTimelineAnimation);
			set => SetProperty(ref _hideTimelineAnimation, value);
		}

		[Ordinal(46)] 
		[RED("showWidgetAnimation")] 
		public CHandle<inkanimProxy> ShowWidgetAnimation
		{
			get => GetProperty(ref _showWidgetAnimation);
			set => SetProperty(ref _showWidgetAnimation, value);
		}
	}
}
