using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PauseResumePhoneCallEvent : redEvent
	{
		[Ordinal(0)] [RED("callDuration")] public CFloat CallDuration { get; set; }
		[Ordinal(1)] [RED("pauseCall")] public CBool PauseCall { get; set; }
		[Ordinal(2)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public PauseResumePhoneCallEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
