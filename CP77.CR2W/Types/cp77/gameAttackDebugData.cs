using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAttackDebugData : CVariable
	{
		[Ordinal(0)]  [RED("bulletStartPosition")] public Vector4 BulletStartPosition { get; set; }
		[Ordinal(1)]  [RED("pointOfViewTransform")] public WorldTransform PointOfViewTransform { get; set; }
		[Ordinal(2)]  [RED("projectileHitplaneSpread")] public Vector4 ProjectileHitplaneSpread { get; set; }

		public gameAttackDebugData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
