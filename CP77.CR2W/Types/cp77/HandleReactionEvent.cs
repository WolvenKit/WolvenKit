using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HandleReactionEvent : redEvent
	{
		[Ordinal(0)]  [RED("fearPhase")] public CInt32 FearPhase { get; set; }
		[Ordinal(1)]  [RED("stimEvent")] public CHandle<senseStimuliEvent> StimEvent { get; set; }
		[Ordinal(2)]  [RED("eventResent")] public CBool EventResent { get; set; }

		public HandleReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
