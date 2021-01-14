using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyAV : gameuiPanzerEnemy
	{
		[Ordinal(0)]  [RED("longShotInterval")] public CFloat LongShotInterval { get; set; }
		[Ordinal(1)]  [RED("shortShotInterval")] public CFloat ShortShotInterval { get; set; }
		[Ordinal(2)]  [RED("shotsAmount")] public CUInt32 ShotsAmount { get; set; }
		[Ordinal(3)]  [RED("speed")] public CFloat Speed { get; set; }

		public gameuiPanzerEnemyAV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
