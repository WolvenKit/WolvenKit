using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyAV : gameuiPanzerEnemy
	{
		[Ordinal(16)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(17)] [RED("shotsAmount")] public CUInt32 ShotsAmount { get; set; }
		[Ordinal(18)] [RED("longShotInterval")] public CFloat LongShotInterval { get; set; }
		[Ordinal(19)] [RED("shortShotInterval")] public CFloat ShortShotInterval { get; set; }

		public gameuiPanzerEnemyAV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
