using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerPlayerController : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] [RED("bulletSpeed")] public CFloat BulletSpeed { get; set; }
		[Ordinal(2)] [RED("bulletSpawnOffset")] public Vector2 BulletSpawnOffset { get; set; }
		[Ordinal(3)] [RED("bulletLibraryname")] public CName BulletLibraryname { get; set; }
		[Ordinal(4)] [RED("shootInterval")] public CFloat ShootInterval { get; set; }
		[Ordinal(5)] [RED("gameLayerName")] public CName GameLayerName { get; set; }
		[Ordinal(6)] [RED("invulnerableAnimationName")] public CName InvulnerableAnimationName { get; set; }
		[Ordinal(7)] [RED("explosionLibraryName")] public CName ExplosionLibraryName { get; set; }

		public gameuiPanzerPlayerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
