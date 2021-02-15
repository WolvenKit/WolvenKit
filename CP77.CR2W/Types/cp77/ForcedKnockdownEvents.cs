using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForcedKnockdownEvents : KnockdownEvents
	{
		[Ordinal(8)] [RED("firstUpdate")] public CBool FirstUpdate { get; set; }

		public ForcedKnockdownEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
