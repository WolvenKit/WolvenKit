using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StaminabarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("staminaControllerRef")] 
		public inkWidgetReference StaminaControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("staminaPercTextPath")] 
		public inkTextWidgetReference StaminaPercTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("staminaStatusTextPath")] 
		public inkTextWidgetReference StaminaStatusTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("bbPStaminaPSMEventId")] 
		public CHandle<redCallbackObject> BbPStaminaPSMEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("bbAreaZoneEventId")] 
		public CHandle<redCallbackObject> BbAreaZoneEventId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("combatModeListener")] 
		public CHandle<redCallbackObject> CombatModeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("staminaController")] 
		public CWeakHandle<NameplateBarLogicController> StaminaController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(17)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("currentBarValue")] 
		public CFloat CurrentBarValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("currentStatPool")] 
		public CEnum<gamedataStatPoolType> CurrentStatPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(20)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(21)] 
		[RED("staminaState")] 
		public CEnum<gamePSMStamina> StaminaState
		{
			get => GetPropertyValue<CEnum<gamePSMStamina>>();
			set => SetPropertyValue<CEnum<gamePSMStamina>>(value);
		}

		[Ordinal(22)] 
		[RED("zoneState")] 
		public CEnum<gamePSMZones> ZoneState
		{
			get => GetPropertyValue<CEnum<gamePSMZones>>();
			set => SetPropertyValue<CEnum<gamePSMZones>>(value);
		}

		[Ordinal(23)] 
		[RED("staminaPoolListener")] 
		public CHandle<StaminaPoolListener> StaminaPoolListener
		{
			get => GetPropertyValue<CHandle<StaminaPoolListener>>();
			set => SetPropertyValue<CHandle<StaminaPoolListener>>(value);
		}

		[Ordinal(24)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(25)] 
		[RED("forceHidden")] 
		public CBool ForceHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("staminaRatioEnterCondition")] 
		public CFloat StaminaRatioEnterCondition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		[Ordinal(28)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public StaminabarWidgetGameController()
		{
			StaminaControllerRef = new inkWidgetReference();
			StaminaPercTextPath = new inkTextWidgetReference();
			StaminaStatusTextPath = new inkTextWidgetReference();
			CurrentBarValue = 100.000000F;
			SceneTier = Enums.GameplayTier.Tier1_FullGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
