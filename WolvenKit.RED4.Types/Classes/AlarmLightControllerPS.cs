using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(109)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetProperty(ref _securityAlarmState);
			set => SetProperty(ref _securityAlarmState, value);
		}
	}
}
