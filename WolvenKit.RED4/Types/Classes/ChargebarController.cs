using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChargebarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("midground")] 
		public inkWidgetReference Midground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("maxChargeAnimationName")] 
		public CName MaxChargeAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("maxChargeResetAnimationName")] 
		public CName MaxChargeResetAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("staticChargeAnimationName")] 
		public CName StaticChargeAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("chargedShootAnimationName")] 
		public CName ChargedShootAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("radialWipe")] 
		public CBool RadialWipe
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("verticalChargeBar")] 
		public CBool VerticalChargeBar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("playStaticChargeAnimationInstead")] 
		public CBool PlayStaticChargeAnimationInstead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(13)] 
		[RED("canFullyCharge")] 
		public CBool CanFullyCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("canOvercharge")] 
		public CBool CanOvercharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("listenerFullCharge")] 
		public CHandle<ChargebarStatsListener> ListenerFullCharge
		{
			get => GetPropertyValue<CHandle<ChargebarStatsListener>>();
			set => SetPropertyValue<CHandle<ChargebarStatsListener>>(value);
		}

		[Ordinal(16)] 
		[RED("listenerOvercharge")] 
		public CHandle<ChargebarStatsListener> ListenerOvercharge
		{
			get => GetPropertyValue<CHandle<ChargebarStatsListener>>();
			set => SetPropertyValue<CHandle<ChargebarStatsListener>>(value);
		}

		[Ordinal(17)] 
		[RED("animationMaxCharge")] 
		public CHandle<inkanimProxy> AnimationMaxCharge
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("animationStaticCharge")] 
		public CHandle<inkanimProxy> AnimationStaticCharge
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("animationChargedShoot")] 
		public CHandle<inkanimProxy> AnimationChargedShoot
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("animationStaticChargePlayed")] 
		public CBool AnimationStaticChargePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("isCharged")] 
		public CBool IsCharged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChargebarController()
		{
			Foreground = new inkWidgetReference();
			Midground = new inkWidgetReference();
			Background = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
