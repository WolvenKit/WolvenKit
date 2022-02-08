using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCrosshairContainerController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("defaultCrosshair")] 
		public TweakDBID DefaultCrosshair
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(10)] 
		[RED("sprintWidget")] 
		public inkWidgetReference SprintWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("bbUIData")] 
		public CWeakHandle<gameIBlackboard> BbUIData
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("bbWeaponInfo")] 
		public CWeakHandle<gameIBlackboard> BbWeaponInfo
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(13)] 
		[RED("bbPlayerTierEventId")] 
		public CHandle<redCallbackObject> BbPlayerTierEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("bbWeaponEventId")] 
		public CHandle<redCallbackObject> BbWeaponEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("interactionBlackboardId")] 
		public CHandle<redCallbackObject> InteractionBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("isMountedBlackboardId")] 
		public CHandle<redCallbackObject> IsMountedBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("fadeOutAnimation")] 
		public CHandle<inkanimDefinition> FadeOutAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(20)] 
		[RED("fadeInAnimation")] 
		public CHandle<inkanimDefinition> FadeInAnimation
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(21)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(22)] 
		[RED("isUnarmed")] 
		public CBool IsUnarmed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("fadeOutValue")] 
		public CFloat FadeOutValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("wasLastInteractionWithDevice")] 
		public CBool WasLastInteractionWithDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("CombatStateBlackboardId")] 
		public CHandle<redCallbackObject> CombatStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("hiddenAnimProxy")] 
		public CHandle<inkanimProxy> HiddenAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("Player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(29)] 
		[RED("HiddenTextCanvas")] 
		public inkWidgetReference HiddenTextCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiCrosshairContainerController()
		{
			SprintWidget = new();
			HiddenTextCanvas = new();
		}
	}
}
