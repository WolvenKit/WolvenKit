using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealDevicesGridEvent : redEvent
	{
		[Ordinal(0)]  [RED("fxDefault")] public gameFxResource FxDefault { get; set; }
		[Ordinal(1)]  [RED("ownerEntityPosition")] public Vector4 OwnerEntityPosition { get; set; }
		[Ordinal(2)]  [RED("revealMaster")] public CBool RevealMaster { get; set; }
		[Ordinal(3)]  [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(4)]  [RED("shouldDraw")] public CBool ShouldDraw { get; set; }

		public RevealDevicesGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
