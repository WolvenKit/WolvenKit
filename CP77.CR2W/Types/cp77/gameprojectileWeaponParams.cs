using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileWeaponParams : CVariable
	{
		[Ordinal(0)]  [RED("charge")] public CFloat Charge { get; set; }
		[Ordinal(1)]  [RED("hitPlaneOffset")] public Vector4 HitPlaneOffset { get; set; }
		[Ordinal(2)]  [RED("ignoreWeaponOwnerCollision")] public CBool IgnoreWeaponOwnerCollision { get; set; }
		[Ordinal(3)]  [RED("ricochetData")] public gameRicochetData RicochetData { get; set; }
		[Ordinal(4)]  [RED("shootingOffset")] public CFloat ShootingOffset { get; set; }
		[Ordinal(5)]  [RED("smartGunAccuracy")] public CFloat SmartGunAccuracy { get; set; }
		[Ordinal(6)]  [RED("smartGunIsProjectileGuided")] public CBool SmartGunIsProjectileGuided { get; set; }
		[Ordinal(7)]  [RED("smartGunSpreadOnHitPlane")] public Vector3 SmartGunSpreadOnHitPlane { get; set; }
		[Ordinal(8)]  [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(9)]  [RED("trackedTargetComponent")] public wCHandle<entIPlacedComponent> TrackedTargetComponent { get; set; }

		public gameprojectileWeaponParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
