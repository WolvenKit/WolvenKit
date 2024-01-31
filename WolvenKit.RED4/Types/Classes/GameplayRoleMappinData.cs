using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayRoleMappinData : gamemappinsMappinScriptData
	{
		[Ordinal(1)] 
		[RED("mappinVisualState")] 
		public CEnum<EMappinVisualState> MappinVisualState
		{
			get => GetPropertyValue<CEnum<EMappinVisualState>>();
			set => SetPropertyValue<CEnum<EMappinVisualState>>(value);
		}

		[Ordinal(2)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isQuest")] 
		public CBool IsQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isCurrentTarget")] 
		public CBool IsCurrentTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("visibleThroughWalls")] 
		public CBool VisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("hasOffscreenArrow")] 
		public CBool HasOffscreenArrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isShardRead")] 
		public CBool IsShardRead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("progressBarType")] 
		public CEnum<EProgressBarType> ProgressBarType
		{
			get => GetPropertyValue<CEnum<EProgressBarType>>();
			set => SetPropertyValue<CEnum<EProgressBarType>>(value);
		}

		[Ordinal(14)] 
		[RED("progressBarContext")] 
		public CEnum<EProgressBarContext> ProgressBarContext
		{
			get => GetPropertyValue<CEnum<EProgressBarContext>>();
			set => SetPropertyValue<CEnum<EProgressBarContext>>(value);
		}

		[Ordinal(15)] 
		[RED("gameplayRole")] 
		public CEnum<EGameplayRole> GameplayRole
		{
			get => GetPropertyValue<CEnum<EGameplayRole>>();
			set => SetPropertyValue<CEnum<EGameplayRole>>(value);
		}

		[Ordinal(16)] 
		[RED("braindanceLayer")] 
		public CEnum<braindanceVisionMode> BraindanceLayer
		{
			get => GetPropertyValue<CEnum<braindanceVisionMode>>();
			set => SetPropertyValue<CEnum<braindanceVisionMode>>(value);
		}

		[Ordinal(17)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(18)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("textureID")] 
		public TweakDBID TextureID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(20)] 
		[RED("showOnMiniMap")] 
		public CBool ShowOnMiniMap
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		public GameplayRoleMappinData()
		{
			ShowOnMiniMap = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
