using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Carry : animAnimFeature
	{
		[Ordinal(0)]  [RED("instant")] public CBool Instant { get; set; }
		[Ordinal(1)]  [RED("pickupAnimation")] public CInt32 PickupAnimation { get; set; }
		[Ordinal(2)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(3)]  [RED("useBothHands")] public CBool UseBothHands { get; set; }

		public AnimFeature_Carry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
