using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyDrone : gameuiPanzerEnemy
	{
		[Ordinal(0)]  [RED("shootIntervalMaximum")] public CFloat ShootIntervalMaximum { get; set; }
		[Ordinal(1)]  [RED("shootIntervalMinimum")] public CFloat ShootIntervalMinimum { get; set; }
		[Ordinal(2)]  [RED("speed")] public CFloat Speed { get; set; }

		public gameuiPanzerEnemyDrone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
