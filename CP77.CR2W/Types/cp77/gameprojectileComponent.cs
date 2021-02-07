using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("onCollisionAction")] public CEnum<gameprojectileOnCollisionAction> OnCollisionAction { get; set; }
		[Ordinal(1)]  [RED("useSweepCollision")] public CBool UseSweepCollision { get; set; }
		[Ordinal(2)]  [RED("collisionsFilterClosest")] public CBool CollisionsFilterClosest { get; set; }
		[Ordinal(3)]  [RED("sweepCollisionRadius")] public CFloat SweepCollisionRadius { get; set; }
		[Ordinal(4)]  [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }
		[Ordinal(5)]  [RED("deriveOwnerVelocity")] public CBool DeriveOwnerVelocity { get; set; }
		[Ordinal(6)]  [RED("derivedVelocityParams")] public gameprojectileVelocityParams DerivedVelocityParams { get; set; }
		[Ordinal(7)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(8)]  [RED("previewEffect")] public raRef<worldEffect> PreviewEffect { get; set; }
		[Ordinal(9)]  [RED("bouncePreviewEffect")] public raRef<worldEffect> BouncePreviewEffect { get; set; }
		[Ordinal(10)]  [RED("explosionPreviewEffect")] public raRef<worldEffect> ExplosionPreviewEffect { get; set; }
		[Ordinal(11)]  [RED("explosionPreviewTime")] public CFloat ExplosionPreviewTime { get; set; }
		[Ordinal(12)]  [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }

		public gameprojectileComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
