using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutput : ActionBool
	{
		[Ordinal(25)] [RED("currentSecurityState")] public CEnum<ESecuritySystemState> CurrentSecurityState { get; set; }
		[Ordinal(26)] [RED("breachOrigin")] public CEnum<EBreachOrigin> BreachOrigin { get; set; }
		[Ordinal(27)] [RED("originalInputEvent")] public CHandle<SecuritySystemInput> OriginalInputEvent { get; set; }
		[Ordinal(28)] [RED("securityStateChanged")] public CBool SecurityStateChanged { get; set; }

		public SecuritySystemOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
