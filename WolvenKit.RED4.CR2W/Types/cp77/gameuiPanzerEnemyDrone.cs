using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemyDrone : gameuiPanzerEnemy
	{
		[Ordinal(16)] [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(17)] [RED("shootIntervalMinimum")] public CFloat ShootIntervalMinimum { get; set; }
		[Ordinal(18)] [RED("shootIntervalMaximum")] public CFloat ShootIntervalMaximum { get; set; }

		public gameuiPanzerEnemyDrone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
