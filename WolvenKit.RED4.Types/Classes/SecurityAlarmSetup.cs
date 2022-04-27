using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAlarmSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("useSound")] 
		public CBool UseSound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("alarmSound")] 
		public CName AlarmSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SecurityAlarmSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
