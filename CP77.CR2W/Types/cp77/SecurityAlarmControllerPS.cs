using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAlarmControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("securityAlarmSetup")] public SecurityAlarmSetup SecurityAlarmSetup { get; set; }
		[Ordinal(1)]  [RED("securityAlarmState")] public CEnum<ESecuritySystemState> SecurityAlarmState { get; set; }

		public SecurityAlarmControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
