using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileWeaponParams : CVariable
	{
		[Ordinal(0)] [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(1)] [RED("smartGunSpreadOnHitPlane")] public Vector3 SmartGunSpreadOnHitPlane { get; set; }
		[Ordinal(2)] [RED("charge")] public CFloat Charge { get; set; }
		[Ordinal(3)] [RED("trackedTargetComponent")] public wCHandle<entIPlacedComponent> TrackedTargetComponent { get; set; }
		[Ordinal(4)] [RED("smartGunAccuracy")] public CFloat SmartGunAccuracy { get; set; }
		[Ordinal(5)] [RED("smartGunIsProjectileGuided")] public CBool SmartGunIsProjectileGuided { get; set; }
		[Ordinal(6)] [RED("hitPlaneOffset")] public Vector4 HitPlaneOffset { get; set; }
		[Ordinal(7)] [RED("shootingOffset")] public CFloat ShootingOffset { get; set; }
		[Ordinal(8)] [RED("ignoreWeaponOwnerCollision")] public CBool IgnoreWeaponOwnerCollision { get; set; }
		[Ordinal(9)] [RED("ricochetData")] public gameRicochetData RicochetData { get; set; }

		public gameprojectileWeaponParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
