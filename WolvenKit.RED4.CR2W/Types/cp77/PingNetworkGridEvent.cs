using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PingNetworkGridEvent : redEvent
	{
		[Ordinal(0)] [RED("ownerEntityPosition")] public Vector4 OwnerEntityPosition { get; set; }
		[Ordinal(1)] [RED("fxResource")] public gameFxResource FxResource { get; set; }
		[Ordinal(2)] [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(3)] [RED("pingType")] public CEnum<EPingType> PingType { get; set; }
		[Ordinal(4)] [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(5)] [RED("revealMaster")] public CBool RevealMaster { get; set; }
		[Ordinal(6)] [RED("ignoreRevealed")] public CBool IgnoreRevealed { get; set; }

		public PingNetworkGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
