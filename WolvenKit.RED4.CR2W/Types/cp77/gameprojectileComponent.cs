using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("onCollisionAction")] public CEnum<gameprojectileOnCollisionAction> OnCollisionAction { get; set; }
		[Ordinal(6)] [RED("useSweepCollision")] public CBool UseSweepCollision { get; set; }
		[Ordinal(7)] [RED("collisionsFilterClosest")] public CBool CollisionsFilterClosest { get; set; }
		[Ordinal(8)] [RED("sweepCollisionRadius")] public CFloat SweepCollisionRadius { get; set; }
		[Ordinal(9)] [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }
		[Ordinal(10)] [RED("deriveOwnerVelocity")] public CBool DeriveOwnerVelocity { get; set; }
		[Ordinal(11)] [RED("derivedVelocityParams")] public gameprojectileVelocityParams DerivedVelocityParams { get; set; }
		[Ordinal(12)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(13)] [RED("previewEffect")] public raRef<worldEffect> PreviewEffect { get; set; }
		[Ordinal(14)] [RED("bouncePreviewEffect")] public raRef<worldEffect> BouncePreviewEffect { get; set; }
		[Ordinal(15)] [RED("explosionPreviewEffect")] public raRef<worldEffect> ExplosionPreviewEffect { get; set; }
		[Ordinal(16)] [RED("explosionPreviewTime")] public CFloat ExplosionPreviewTime { get; set; }
		[Ordinal(17)] [RED("gameEffectRef")] public gameEffectRef GameEffectRef { get; set; }

		public gameprojectileComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
