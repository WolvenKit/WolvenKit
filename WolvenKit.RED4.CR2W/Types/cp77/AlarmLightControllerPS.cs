using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecuritySystemState> _securityAlarmState;

		[Ordinal(109)] 
		[RED("securityAlarmState")] 
		public CEnum<ESecuritySystemState> SecurityAlarmState
		{
			get => GetProperty(ref _securityAlarmState);
			set => SetProperty(ref _securityAlarmState, value);
		}

		public AlarmLightControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
