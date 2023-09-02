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
		[RED("staminaController")] 
		public CWeakHandle<NameplateBarLogicController> StaminaController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(15)] 
		[RED("RootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("animHideStaminaProxy")] 
		public CHandle<inkanimProxy> AnimHideStaminaProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("currentStamina")] 
		public CFloat CurrentStamina
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(20)] 
		[RED("staminaState")] 
		public CEnum<gamePSMStamina> StaminaState
		{
			get => GetPropertyValue<CEnum<gamePSMStamina>>();
			set => SetPropertyValue<CEnum<gamePSMStamina>>(value);
		}

		[Ordinal(21)] 
		[RED("staminaPoolListener")] 
		public CHandle<StaminaPoolListener> StaminaPoolListener
		{
			get => GetPropertyValue<CHandle<StaminaPoolListener>>();
			set => SetPropertyValue<CHandle<StaminaPoolListener>>(value);
		}

		public StaminabarWidgetGameController()
		{
			StaminaControllerRef = new inkWidgetReference();
			StaminaPercTextPath = new inkTextWidgetReference();
			StaminaStatusTextPath = new inkTextWidgetReference();
			CurrentStamina = 100.000000F;
			SceneTier = Enums.GameplayTier.Tier1_FullGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
