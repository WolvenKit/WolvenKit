using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayRoleComponent : gameScriptableComponent
	{
		private CEnum<EGameplayRole> _gameplayRole;
		private CBool _autoDeterminGameplayRole;
		private CEnum<EMappinDisplayMode> _mappinsDisplayMode;
		private CBool _displayAllRolesAsGeneric;
		private CBool _alwaysCreateMappinAsDynamic;
		private CArray<SDeviceMappinData> _mappins;
		private CFloat _offsetValue;
		private CBool _isBeingScanned;
		private CBool _isCurrentTarget;
		private CBool _isShowingMappins;
		private CBool _canShowMappinsByTask;
		private CBool _canHideMappinsByTask;
		private CBool _isHighlightedInFocusMode;
		private CEnum<EGameplayRole> _currentGameplayRole;
		private CBool _isGameplayRoleInitialized;
		private CBool _isForceHidden;
		private CBool _isForcedVisibleThroughWalls;

		[Ordinal(5)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetProperty(ref _gameplayRole);
			set => SetProperty(ref _gameplayRole, value);
		}

		[Ordinal(6)] 
		[RED("autoDeterminGameplayRole")] 
		public CBool AutoDeterminGameplayRole
		{
			get => GetProperty(ref _autoDeterminGameplayRole);
			set => SetProperty(ref _autoDeterminGameplayRole, value);
		}

		[Ordinal(7)] 
		[RED("mappinsDisplayMode")] 
		public CEnum<EMappinDisplayMode> MappinsDisplayMode
		{
			get => GetProperty(ref _mappinsDisplayMode);
			set => SetProperty(ref _mappinsDisplayMode, value);
		}

		[Ordinal(8)] 
		[RED("displayAllRolesAsGeneric")] 
		public CBool DisplayAllRolesAsGeneric
		{
			get => GetProperty(ref _displayAllRolesAsGeneric);
			set => SetProperty(ref _displayAllRolesAsGeneric, value);
		}

		[Ordinal(9)] 
		[RED("alwaysCreateMappinAsDynamic")] 
		public CBool AlwaysCreateMappinAsDynamic
		{
			get => GetProperty(ref _alwaysCreateMappinAsDynamic);
			set => SetProperty(ref _alwaysCreateMappinAsDynamic, value);
		}

		[Ordinal(10)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get => GetProperty(ref _mappins);
			set => SetProperty(ref _mappins, value);
		}

		[Ordinal(11)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get => GetProperty(ref _offsetValue);
			set => SetProperty(ref _offsetValue, value);
		}

		[Ordinal(12)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetProperty(ref _isBeingScanned);
			set => SetProperty(ref _isBeingScanned, value);
		}

		[Ordinal(13)] 
		[RED("isCurrentTarget")] 
		public CBool IsCurrentTarget
		{
			get => GetProperty(ref _isCurrentTarget);
			set => SetProperty(ref _isCurrentTarget, value);
		}

		[Ordinal(14)] 
		[RED("isShowingMappins")] 
		public CBool IsShowingMappins
		{
			get => GetProperty(ref _isShowingMappins);
			set => SetProperty(ref _isShowingMappins, value);
		}

		[Ordinal(15)] 
		[RED("canShowMappinsByTask")] 
		public CBool CanShowMappinsByTask
		{
			get => GetProperty(ref _canShowMappinsByTask);
			set => SetProperty(ref _canShowMappinsByTask, value);
		}

		[Ordinal(16)] 
		[RED("canHideMappinsByTask")] 
		public CBool CanHideMappinsByTask
		{
			get => GetProperty(ref _canHideMappinsByTask);
			set => SetProperty(ref _canHideMappinsByTask, value);
		}

		[Ordinal(17)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetProperty(ref _isHighlightedInFocusMode);
			set => SetProperty(ref _isHighlightedInFocusMode, value);
		}

		[Ordinal(18)] 
		[RED("currentGameplayRole")] 
		public CEnum<EGameplayRole> CurrentGameplayRole
		{
			get => GetProperty(ref _currentGameplayRole);
			set => SetProperty(ref _currentGameplayRole, value);
		}

		[Ordinal(19)] 
		[RED("isGameplayRoleInitialized")] 
		public CBool IsGameplayRoleInitialized
		{
			get => GetProperty(ref _isGameplayRoleInitialized);
			set => SetProperty(ref _isGameplayRoleInitialized, value);
		}

		[Ordinal(20)] 
		[RED("isForceHidden")] 
		public CBool IsForceHidden
		{
			get => GetProperty(ref _isForceHidden);
			set => SetProperty(ref _isForceHidden, value);
		}

		[Ordinal(21)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get => GetProperty(ref _isForcedVisibleThroughWalls);
			set => SetProperty(ref _isForcedVisibleThroughWalls, value);
		}

		public GameplayRoleComponent()
		{
			_autoDeterminGameplayRole = true;
			_mappinsDisplayMode = new() { Value = Enums.EMappinDisplayMode.MINIMALISTIC };
			_alwaysCreateMappinAsDynamic = true;
			_offsetValue = 0.040000F;
		}
	}
}
