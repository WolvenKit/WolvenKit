using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCStatePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("previousState")] public CBool PreviousState { get; set; }
		[Ordinal(1)] [RED("isInState")] public CBool IsInState { get; set; }
		[Ordinal(2)] [RED("skipWhenApplied")] public CBool SkipWhenApplied { get; set; }

		public NPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
