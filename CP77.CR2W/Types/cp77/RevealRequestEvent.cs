using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealRequestEvent : redEvent
	{
		[Ordinal(0)]  [RED("oneFrame")] public CBool OneFrame { get; set; }
		[Ordinal(1)]  [RED("requester")] public entEntityID Requester { get; set; }
		[Ordinal(2)]  [RED("shouldReveal")] public CBool ShouldReveal { get; set; }

		public RevealRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
