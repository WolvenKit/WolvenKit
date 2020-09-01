using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileArea : W3Trap
	{
		[Ordinal(0)] [RED("("projectile")] 		public CHandle<CEntityTemplate> Projectile { get; set;}

		[Ordinal(0)] [RED("("density")] 		public CFloat Density { get; set;}

		[Ordinal(0)] [RED("("maxShots")] 		public CInt32 MaxShots { get; set;}

		[Ordinal(0)] [RED("("reloadAtActivation")] 		public CBool ReloadAtActivation { get; set;}

		[Ordinal(0)] [RED("("projAtOnce")] 		public SRange ProjAtOnce { get; set;}

		[Ordinal(0)] [RED("("delay")] 		public SRangeF Delay { get; set;}

		[Ordinal(0)] [RED("("targetPlayerDelay")] 		public SRangeF TargetPlayerDelay { get; set;}

		[Ordinal(0)] [RED("("height")] 		public SRangeF Height { get; set;}

		[Ordinal(0)] [RED("("velocity")] 		public SRangeF Velocity { get; set;}

		[Ordinal(0)] [RED("("projectileOriginOffsetX")] 		public SRangeF ProjectileOriginOffsetX { get; set;}

		[Ordinal(0)] [RED("("projectileOriginOffsetY")] 		public SRangeF ProjectileOriginOffsetY { get; set;}

		[Ordinal(0)] [RED("("shootOnlyWhenTargetInside")] 		public CBool ShootOnlyWhenTargetInside { get; set;}

		[Ordinal(0)] [RED("("deactivateAutomatically")] 		public CBool DeactivateAutomatically { get; set;}

		[Ordinal(0)] [RED("("useAdvancedDistribution")] 		public CBool UseAdvancedDistribution { get; set;}

		[Ordinal(0)] [RED("("useGridPositioning")] 		public CBool UseGridPositioning { get; set;}

		[Ordinal(0)] [RED("("excludedEntityTags", 2,0)] 		public CArray<CName> ExcludedEntityTags { get; set;}

		[Ordinal(0)] [RED("("magnetTags", 2,0)] 		public CArray<CName> MagnetTags { get; set;}

		[Ordinal(0)] [RED("("magnetRange")] 		public CFloat MagnetRange { get; set;}

		[Ordinal(0)] [RED("("magnetOffset")] 		public Vector MagnetOffset { get; set;}

		[Ordinal(0)] [RED("("maxDistanceFromPlayer")] 		public CFloat MaxDistanceFromPlayer { get; set;}

		[Ordinal(0)] [RED("("forbidingAreaRadius")] 		public CFloat ForbidingAreaRadius { get; set;}

		[Ordinal(0)] [RED("("m_AreaComponent")] 		public CHandle<CTriggerAreaComponent> M_AreaComponent { get; set;}

		[Ordinal(0)] [RED("("m_ProjectilePositionGrid", 2,0)] 		public CArray<Vector> M_ProjectilePositionGrid { get; set;}

		[Ordinal(0)] [RED("("m_UsedProjectilePosition", 2,0)] 		public CArray<Vector> M_UsedProjectilePosition { get; set;}

		[Ordinal(0)] [RED("("m_AcceptablePos", 2,0)] 		public CArray<Vector> M_AcceptablePos { get; set;}

		[Ordinal(0)] [RED("("m_ForbiddenPos", 2,0)] 		public CArray<Vector> M_ForbiddenPos { get; set;}

		[Ordinal(0)] [RED("("m_LastPlayerCheckedPos")] 		public Vector M_LastPlayerCheckedPos { get; set;}

		[Ordinal(0)] [RED("("m_LastQuantOfForbidAreas")] 		public CInt32 M_LastQuantOfForbidAreas { get; set;}

		[Ordinal(0)] [RED("("m_GridSquareWidth")] 		public CFloat M_GridSquareWidth { get; set;}

		[Ordinal(0)] [RED("("m_GridSquareLength")] 		public CFloat M_GridSquareLength { get; set;}

		[Ordinal(0)] [RED("("m_DelayUntilNextShoot")] 		public CFloat M_DelayUntilNextShoot { get; set;}

		[Ordinal(0)] [RED("("m_DelayUntilNextPlayerShoot")] 		public CFloat M_DelayUntilNextPlayerShoot { get; set;}

		[Ordinal(0)] [RED("("m_QuantityShotNext")] 		public CInt32 M_QuantityShotNext { get; set;}

		[Ordinal(0)] [RED("("m_PlayerIsInArea")] 		public CBool M_PlayerIsInArea { get; set;}

		[Ordinal(0)] [RED("("m_TargetsInArea", 2,0)] 		public CArray<CHandle<CEntity>> M_TargetsInArea { get; set;}

		[Ordinal(0)] [RED("("m_CreateEntityHelper")] 		public CHandle<W3TrapProjectileArea_CreateEntityHelper> M_CreateEntityHelper { get; set;}

		[Ordinal(0)] [RED("("m_EntityCreated")] 		public CInt32 M_EntityCreated { get; set;}

		[Ordinal(0)] [RED("("m_WasCreatingLastFrame")] 		public CBool M_WasCreatingLastFrame { get; set;}

		[Ordinal(0)] [RED("("m_Shot")] 		public CBool M_Shot { get; set;}

		[Ordinal(0)] [RED("("m_DebugFloat")] 		public CFloat M_DebugFloat { get; set;}

		[Ordinal(0)] [RED("("m_DebugIndex")] 		public CInt32 M_DebugIndex { get; set;}

		[Ordinal(0)] [RED("("m_TotalQuantityShot")] 		public CInt32 M_TotalQuantityShot { get; set;}

		public W3TrapProjectileArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}