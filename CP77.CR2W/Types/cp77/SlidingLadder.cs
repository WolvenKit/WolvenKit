using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlidingLadder : BaseAnimatedDevice
	{
		[Ordinal(98)] [RED("offMeshConnectionDown")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionDown { get; set; }
		[Ordinal(99)] [RED("offMeshConnectionUp")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionUp { get; set; }
		[Ordinal(100)] [RED("ladderInteraction")] public CHandle<gameinteractionsComponent> LadderInteraction { get; set; }
		[Ordinal(101)] [RED("wasShot")] public CBool WasShot { get; set; }

		public SlidingLadder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
