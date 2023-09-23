using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayRoleComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		[Ordinal(6)] 
		[RED("autoDeterminGameplayRole")] 
		public CBool AutoDeterminGameplayRole
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("mappinsDisplayMode")] 
		public CEnum<EMappinDisplayMode> MappinsDisplayMode
		{
			get => GetPropertyValue<CEnum<EMappinDisplayMode>>();
			set => SetPropertyValue<CEnum<EMappinDisplayMode>>(value);
		}

		[Ordinal(8)] 
		[RED("displayAllRolesAsGeneric")] 
		public CBool DisplayAllRolesAsGeneric
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("alwaysCreateMappinAsDynamic")] 
		public CBool AlwaysCreateMappinAsDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("forcedMappinVisualState")] 
		public CEnum<EMappinVisualState> ForcedMappinVisualState
		{
			get => GetPropertyValue<CEnum<EMappinVisualState>>();
			set => SetPropertyValue<CEnum<EMappinVisualState>>(value);
		}

		[Ordinal(11)] 
		[RED("mappins")] 
		public CArray<SDeviceMappinData> Mappins
		{
			get => GetPropertyValue<CArray<SDeviceMappinData>>();
			set => SetPropertyValue<CArray<SDeviceMappinData>>(value);
		}

		[Ordinal(12)] 
		[RED("offsetValue")] 
		public CFloat OffsetValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("isBeingScanned")] 
		public CBool IsBeingScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("isCurrentTarget")] 
		public CBool IsCurrentTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isShowingMappins")] 
		public CBool IsShowingMappins
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("canShowMappinsByTask")] 
		public CBool CanShowMappinsByTask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("canHideMappinsByTask")] 
		public CBool CanHideMappinsByTask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("currentGameplayRole")] 
		public CEnum<EGameplayRole> CurrentGameplayRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		[Ordinal(20)] 
		[RED("isGameplayRoleInitialized")] 
		public CBool IsGameplayRoleInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isForceHidden")] 
		public CBool IsForceHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isForcedVisibleThroughWalls")] 
		public CBool IsForcedVisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("enabledMinimapMappins")] 
		public CArray<CEnum<gamedataMappinVariant>> EnabledMinimapMappins
		{
			get => GetPropertyValue<CArray<CEnum<gamedataMappinVariant>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataMappinVariant>>>(value);
		}

		public GameplayRoleComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
