using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAlarmControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("securityAlarmSetup")] 
		public SecurityAlarmSetup SecurityAlarmSetup
		{
			get => GetPropertyValue<SecurityAlarmSetup>();
			set => SetPropertyValue<SecurityAlarmSetup>(value);
		}

		[Ordinal(109)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public SecurityAlarmControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
