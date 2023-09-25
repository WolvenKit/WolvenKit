using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Rasetsu : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("hipFire")] 
		public inkWidgetReference HipFire
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("aimFire")] 
		public inkWidgetReference AimFire
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("showAdsAnimName")] 
		public CName ShowAdsAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("hideAdsAnimName")] 
		public CName HideAdsAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("loopAdsAnimName")] 
		public CName LoopAdsAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("targetHitAnimationName")] 
		public CName TargetHitAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("shootAnimationName")] 
		public CName ShootAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(34)] 
		[RED("hipFireLogicController")] 
		public CWeakHandle<CrosshairLogicController_RasetsuHipFire> HipFireLogicController
		{
			get => GetPropertyValue<CWeakHandle<CrosshairLogicController_RasetsuHipFire>>();
			set => SetPropertyValue<CWeakHandle<CrosshairLogicController_RasetsuHipFire>>(value);
		}

		[Ordinal(35)] 
		[RED("aimFireLogicController")] 
		public CWeakHandle<CrosshairLogicController_RasetsuAimFire> AimFireLogicController
		{
			get => GetPropertyValue<CWeakHandle<CrosshairLogicController_RasetsuAimFire>>();
			set => SetPropertyValue<CWeakHandle<CrosshairLogicController_RasetsuAimFire>>(value);
		}

		[Ordinal(36)] 
		[RED("weaponLocalBB")] 
		public CWeakHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(37)] 
		[RED("uiGameDataBB")] 
		public CWeakHandle<gameIBlackboard> UiGameDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("onChargeChangeBBID")] 
		public CHandle<redCallbackObject> OnChargeChangeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("onChargeTriggerModeBBID")] 
		public CHandle<redCallbackObject> OnChargeTriggerModeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("weaponDataTargetHitBBID")] 
		public CHandle<redCallbackObject> WeaponDataTargetHitBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("weaponDataShootBBID")] 
		public CHandle<redCallbackObject> WeaponDataShootBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("targetHitAnimation")] 
		public CHandle<inkanimProxy> TargetHitAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("shootAnimation")] 
		public CHandle<inkanimProxy> ShootAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("visibilityAnimProxy")] 
		public CHandle<inkanimProxy> VisibilityAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(45)] 
		[RED("rootAnimProxy")] 
		public CHandle<inkanimProxy> RootAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(46)] 
		[RED("isRootVisible")] 
		public CBool IsRootVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CrosshairGameController_Rasetsu()
		{
			HipFire = new inkWidgetReference();
			AimFire = new inkWidgetReference();
			IsRootVisible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
