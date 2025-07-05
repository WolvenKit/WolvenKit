using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OxygenbarWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("oxygenControllerRef")] 
		public inkWidgetReference OxygenControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("oxygenPercTextPath")] 
		public inkTextWidgetReference OxygenPercTextPath
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("oxygenStatusTextPath")] 
		public inkTextWidgetReference OxygenStatusTextPath
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
		[RED("swimmingStateBlackboardId")] 
		public CHandle<redCallbackObject> SwimmingStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("oxygenController")] 
		public CWeakHandle<NameplateBarLogicController> OxygenController
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
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(19)] 
		[RED("animHideOxygenProxy")] 
		public CHandle<inkanimProxy> AnimHideOxygenProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("currentOxygen")] 
		public CFloat CurrentOxygen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(22)] 
		[RED("currentSwimmingState")] 
		public CEnum<gamePSMSwimming> CurrentSwimmingState
		{
			get => GetPropertyValue<CEnum<gamePSMSwimming>>();
			set => SetPropertyValue<CEnum<gamePSMSwimming>>(value);
		}

		[Ordinal(23)] 
		[RED("oxygenListener")] 
		public CHandle<OxygenListener> OxygenListener
		{
			get => GetPropertyValue<CHandle<OxygenListener>>();
			set => SetPropertyValue<CHandle<OxygenListener>>(value);
		}

		public OxygenbarWidgetGameController()
		{
			OxygenControllerRef = new inkWidgetReference();
			OxygenPercTextPath = new inkTextWidgetReference();
			OxygenStatusTextPath = new inkTextWidgetReference();
			CurrentOxygen = 100.000000F;
			SceneTier = Enums.GameplayTier.Tier1_FullGameplay;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
