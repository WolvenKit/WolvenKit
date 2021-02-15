using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkGridEvent : redEvent
	{
		[Ordinal(0)] [RED("shouldDraw")] public CBool ShouldDraw { get; set; }
		[Ordinal(1)] [RED("ownerEntityPosition")] public Vector4 OwnerEntityPosition { get; set; }
		[Ordinal(2)] [RED("fxDefault")] public gameFxResource FxDefault { get; set; }
		[Ordinal(3)] [RED("fxBreached")] public gameFxResource FxBreached { get; set; }
		[Ordinal(4)] [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(5)] [RED("revealMaster")] public CBool RevealMaster { get; set; }

		public RevealNetworkGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
