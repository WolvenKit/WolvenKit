using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmControllerPS : MasterControllerPS
	{
		private SecurityAlarmSetup _securityAlarmSetup;
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(104)] 
		[RED("securityAlarmSetup")] 
		public SecurityAlarmSetup SecurityAlarmSetup
		{
			get => GetProperty(ref _securityAlarmSetup);
			set => SetProperty(ref _securityAlarmSetup, value);
		}

		[Ordinal(105)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetProperty(ref _securityAlarmState);
			set => SetProperty(ref _securityAlarmState, value);
		}

		public SecurityAlarmControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
