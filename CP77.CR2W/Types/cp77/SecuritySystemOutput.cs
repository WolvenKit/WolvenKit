using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutput : ActionBool
	{
		[Ordinal(22)]  [RED("currentSecurityState")] public CEnum<ESecuritySystemState> CurrentSecurityState { get; set; }
		[Ordinal(23)]  [RED("breachOrigin")] public CEnum<EBreachOrigin> BreachOrigin { get; set; }
		[Ordinal(24)]  [RED("originalInputEvent")] public CHandle<SecuritySystemInput> OriginalInputEvent { get; set; }
		[Ordinal(25)]  [RED("securityStateChanged")] public CBool SecurityStateChanged { get; set; }

		public SecuritySystemOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
