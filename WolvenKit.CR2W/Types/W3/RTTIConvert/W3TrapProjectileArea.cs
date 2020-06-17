using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileArea : W3Trap
	{
		[RED("projectile")] 		public CHandle<CEntityTemplate> Projectile { get; set;}

		[RED("density")] 		public CFloat Density { get; set;}

		[RED("maxShots")] 		public CInt32 MaxShots { get; set;}

		[RED("reloadAtActivation")] 		public CBool ReloadAtActivation { get; set;}

		[RED("projAtOnce")] 		public SRange ProjAtOnce { get; set;}

		[RED("delay")] 		public SRangeF Delay { get; set;}

		[RED("targetPlayerDelay")] 		public SRangeF TargetPlayerDelay { get; set;}

		[RED("height")] 		public SRangeF Height { get; set;}

		[RED("velocity")] 		public SRangeF Velocity { get; set;}

		[RED("projectileOriginOffsetX")] 		public SRangeF ProjectileOriginOffsetX { get; set;}

		[RED("projectileOriginOffsetY")] 		public SRangeF ProjectileOriginOffsetY { get; set;}

		[RED("shootOnlyWhenTargetInside")] 		public CBool ShootOnlyWhenTargetInside { get; set;}

		[RED("deactivateAutomatically")] 		public CBool DeactivateAutomatically { get; set;}

		[RED("useAdvancedDistribution")] 		public CBool UseAdvancedDistribution { get; set;}

		[RED("useGridPositioning")] 		public CBool UseGridPositioning { get; set;}

		[RED("excludedEntityTags", 2,0)] 		public CArray<CName> ExcludedEntityTags { get; set;}

		[RED("magnetTags", 2,0)] 		public CArray<CName> MagnetTags { get; set;}

		[RED("magnetRange")] 		public CFloat MagnetRange { get; set;}

		[RED("magnetOffset")] 		public Vector MagnetOffset { get; set;}

		[RED("maxDistanceFromPlayer")] 		public CFloat MaxDistanceFromPlayer { get; set;}

		[RED("forbidingAreaRadius")] 		public CFloat ForbidingAreaRadius { get; set;}

		public W3TrapProjectileArea(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3TrapProjectileArea(cr2w);

	}
}