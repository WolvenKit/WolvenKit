using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIEntityReuseEvent : AIAIEvent
	{
		[Ordinal(2)] [RED("destination")] public worldGlobalNodeID Destination { get; set; }

		public AIEntityReuseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
