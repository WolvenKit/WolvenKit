using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StimParams : CVariable
	{
		[Ordinal(0)] [RED("reactionOutput")] public ReactionOutput ReactionOutput { get; set; }
		[Ordinal(1)] [RED("stimData")] public StimEventData StimData { get; set; }

		public StimParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
