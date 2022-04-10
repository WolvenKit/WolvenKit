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
		[RED("animationMaxCharge")] 
		public CHandle<inkanimProxy> AnimationMaxCharge
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(7)] 
		[RED("canFullyCharge")] 
		public CBool CanFullyCharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("canOvercharge")] 
		public CBool CanOvercharge
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("listenerFullCharge")] 
		public CHandle<ChargebarStatsListener> ListenerFullCharge
		{
			get => GetPropertyValue<CHandle<ChargebarStatsListener>>();
			set => SetPropertyValue<CHandle<ChargebarStatsListener>>(value);
		}

		[Ordinal(10)] 
		[RED("listenerOvercharge")] 
		public CHandle<ChargebarStatsListener> ListenerOvercharge
		{
			get => GetPropertyValue<CHandle<ChargebarStatsListener>>();
			set => SetPropertyValue<CHandle<ChargebarStatsListener>>(value);
		}

		public ChargebarController()
		{
			Foreground = new();
			Midground = new();
			Background = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
