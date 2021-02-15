using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttackDebugData : CVariable
	{
		[Ordinal(0)] [RED("pointOfViewTransform")] public WorldTransform PointOfViewTransform { get; set; }
		[Ordinal(1)] [RED("projectileHitplaneSpread")] public Vector4 ProjectileHitplaneSpread { get; set; }
		[Ordinal(2)] [RED("bulletStartPosition")] public Vector4 BulletStartPosition { get; set; }

		public gameAttackDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
