using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealInteractionWheel : redEvent
	{
		[Ordinal(0)] [RED("lookAtObject")] public wCHandle<gameObject> LookAtObject { get; set; }
		[Ordinal(1)] [RED("commands")] public CArray<CHandle<QuickhackData>> Commands { get; set; }
		[Ordinal(2)] [RED("shouldReveal")] public CBool ShouldReveal { get; set; }

		public RevealInteractionWheel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
