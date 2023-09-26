using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleController : gameComponent
	{
		[Ordinal(4)] 
		[RED("alarmCurve")] 
		public CName AlarmCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("alarmTime")] 
		public CFloat AlarmTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("overrideHeadlightsSettingsForPlayer")] 
		public CBool OverrideHeadlightsSettingsForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleController()
		{
			AlarmCurve = "default_alarm";
			AlarmTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
