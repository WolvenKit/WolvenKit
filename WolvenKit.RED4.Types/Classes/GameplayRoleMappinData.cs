using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayRoleMappinData : gamemappinsMappinScriptData
	{
		private CEnum<EMappinVisualState> _mappinVisualState;
		private CBool _isTagged;
		private CBool _isQuest;
		private CBool _isIconic;
		private CBool _isScanningCluesBlocked;
		private CBool _isCurrentTarget;
		private CBool _visibleThroughWalls;
		private CBool _hasOffscreenArrow;
		private CFloat _range;
		private CFloat _duration;
		private CEnum<EProgressBarType> _progressBarType;
		private CEnum<EProgressBarContext> _progressBarContext;
		private CEnum<EGameplayRole> _gameplayRole;
		private CEnum<braindanceVisionMode> _braindanceLayer;
		private CEnum<gamedataQuality> _quality;
		private CName _slotName;
		private TweakDBID _textureID;
		private CBool _showOnMiniMap;

		[Ordinal(1)] 
		[RED("mappinVisualState")] 
		public CEnum<EMappinVisualState> MappinVisualState
		{
			get => GetProperty(ref _mappinVisualState);
			set => SetProperty(ref _mappinVisualState, value);
		}

		[Ordinal(2)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(3)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetProperty(ref _isQuest);
			set => SetProperty(ref _isQuest, value);
		}

		[Ordinal(4)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(5)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetProperty(ref _isScanningCluesBlocked);
			set => SetProperty(ref _isScanningCluesBlocked, value);
		}

		[Ordinal(6)] 
		[RED("isCurrentTarget")] 
		public CBool IsCurrentTarget
		{
			get => GetProperty(ref _isCurrentTarget);
			set => SetProperty(ref _isCurrentTarget, value);
		}

		[Ordinal(7)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetProperty(ref _visibleThroughWalls);
			set => SetProperty(ref _visibleThroughWalls, value);
		}

		[Ordinal(8)] 
		[RED("hasOffscreenArrow")] 
		public CBool HasOffscreenArrow
		{
			get => GetProperty(ref _hasOffscreenArrow);
			set => SetProperty(ref _hasOffscreenArrow, value);
		}

		[Ordinal(9)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(10)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(11)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get => GetProperty(ref _progressBarType);
			set => SetProperty(ref _progressBarType, value);
		}

		[Ordinal(12)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get => GetProperty(ref _progressBarContext);
			set => SetProperty(ref _progressBarContext, value);
		}

		[Ordinal(13)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetProperty(ref _gameplayRole);
			set => SetProperty(ref _gameplayRole, value);
		}

		[Ordinal(14)] 
		[RED("braindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get => GetProperty(ref _braindanceLayer);
			set => SetProperty(ref _braindanceLayer, value);
		}

		[Ordinal(15)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(16)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(17)] 
		[RED("textureID")] 
		public TweakDBID TextureID
		{
			get => GetProperty(ref _textureID);
			set => SetProperty(ref _textureID, value);
		}

		[Ordinal(18)] 
		[RED("showOnMiniMap")] 
		public CBool ShowOnMiniMap
		{
			get => GetProperty(ref _showOnMiniMap);
			set => SetProperty(ref _showOnMiniMap, value);
		}

		public GameplayRoleMappinData()
		{
			_showOnMiniMap = true;
		}
	}
}
