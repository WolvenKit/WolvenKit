using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AlarmLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("securityAlarmState")] public CEnum<ESecuritySystemState> SecurityAlarmState { get; set; }

		public AlarmLightControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
