using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseTechCrosshairController : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("fullChargeAvailable")] public CBool FullChargeAvailable { get; set; }
		[Ordinal(1)]  [RED("fullChargeListener")] public CHandle<CrosshairWeaponStatsListener> FullChargeListener { get; set; }
		[Ordinal(2)]  [RED("overChargeAvailable")] public CBool OverChargeAvailable { get; set; }
		[Ordinal(3)]  [RED("overChargeListener")] public CHandle<CrosshairWeaponStatsListener> OverChargeListener { get; set; }
		[Ordinal(4)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(5)]  [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }

		public BaseTechCrosshairController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
