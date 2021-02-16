using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleNetrunnerDive : ActionBool
	{
		[Ordinal(25)] [RED("skipMinigame")] public CBool SkipMinigame { get; set; }
		[Ordinal(26)] [RED("attempt")] public CInt32 Attempt { get; set; }
		[Ordinal(27)] [RED("isRemote")] public CBool IsRemote { get; set; }

		public ToggleNetrunnerDive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
