using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealRequestEvent : redEvent
	{
		[Ordinal(0)] [RED("shouldReveal")] public CBool ShouldReveal { get; set; }
		[Ordinal(1)] [RED("requester")] public entEntityID Requester { get; set; }
		[Ordinal(2)] [RED("oneFrame")] public CBool OneFrame { get; set; }

		public RevealRequestEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
