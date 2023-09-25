using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public AlarmLightControllerPS()
		{
			SecurityAlarmState = Enums.ESecuritySystemState.SAFE;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
