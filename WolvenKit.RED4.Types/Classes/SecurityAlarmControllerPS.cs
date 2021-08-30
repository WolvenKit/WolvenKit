using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarmControllerPS : MasterControllerPS
	{
		private SecurityAlarmSetup _securityAlarmSetup;
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(105)] 
		[RED("securityAlarmSetup")] 
		public SecurityAlarmSetup SecurityAlarmSetup
		{
			get => GetProperty(ref _securityAlarmSetup);
			set => SetProperty(ref _securityAlarmSetup, value);
		}

		[Ordinal(106)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetProperty(ref _securityAlarmState);
			set => SetProperty(ref _securityAlarmState, value);
		}

		public SecurityAlarmControllerPS()
		{
			_securityAlarmState = new() { Value = Enums.ESecuritySystemState.SAFE };
		}
	}
}
