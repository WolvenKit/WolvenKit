using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerEnemy : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(0)]  [RED("bulletLibraryName")] public CName BulletLibraryName { get; set; }
		[Ordinal(1)]  [RED("bulletSpeed")] public CFloat BulletSpeed { get; set; }
		[Ordinal(2)]  [RED("explosionLibraryName")] public CName ExplosionLibraryName { get; set; }
		[Ordinal(3)]  [RED("gameLayerName")] public CName GameLayerName { get; set; }
		[Ordinal(4)]  [RED("health")] public CInt32 Health { get; set; }
		[Ordinal(5)]  [RED("lifeBonusChanceCoeff")] public CUInt32 LifeBonusChanceCoeff { get; set; }
		[Ordinal(6)]  [RED("lifeBonusLibraryName")] public CName LifeBonusLibraryName { get; set; }
		[Ordinal(7)]  [RED("noBonusChanceCoeff")] public CUInt32 NoBonusChanceCoeff { get; set; }
		[Ordinal(8)]  [RED("score")] public CUInt32 Score { get; set; }
		[Ordinal(9)]  [RED("score100ChanceCoeff")] public CUInt32 Score100ChanceCoeff { get; set; }
		[Ordinal(10)]  [RED("score200ChanceCoeff")] public CUInt32 Score200ChanceCoeff { get; set; }
		[Ordinal(11)]  [RED("score50ChanceCoeff")] public CUInt32 Score50ChanceCoeff { get; set; }
		[Ordinal(12)]  [RED("scoreBonusChanceCoeff")] public CUInt32 ScoreBonusChanceCoeff { get; set; }
		[Ordinal(13)]  [RED("scoreBonusLibraryName")] public CName ScoreBonusLibraryName { get; set; }
		[Ordinal(14)]  [RED("shootPoint")] public Vector2 ShootPoint { get; set; }

		public gameuiPanzerEnemy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
