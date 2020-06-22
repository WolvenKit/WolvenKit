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

		[RED("m_AreaComponent")] 		public CHandle<CTriggerAreaComponent> M_AreaComponent { get; set;}

		[RED("m_ProjectilePositionGrid", 2,0)] 		public CArray<Vector> M_ProjectilePositionGrid { get; set;}

		[RED("m_UsedProjectilePosition", 2,0)] 		public CArray<Vector> M_UsedProjectilePosition { get; set;}

		[RED("m_AcceptablePos", 2,0)] 		public CArray<Vector> M_AcceptablePos { get; set;}

		[RED("m_ForbiddenPos", 2,0)] 		public CArray<Vector> M_ForbiddenPos { get; set;}

		[RED("m_LastPlayerCheckedPos")] 		public Vector M_LastPlayerCheckedPos { get; set;}

		[RED("m_LastQuantOfForbidAreas")] 		public CInt32 M_LastQuantOfForbidAreas { get; set;}

		[RED("m_GridSquareWidth")] 		public CFloat M_GridSquareWidth { get; set;}

		[RED("m_GridSquareLength")] 		public CFloat M_GridSquareLength { get; set;}

		[RED("m_DelayUntilNextShoot")] 		public CFloat M_DelayUntilNextShoot { get; set;}

		[RED("m_DelayUntilNextPlayerShoot")] 		public CFloat M_DelayUntilNextPlayerShoot { get; set;}

		[RED("m_QuantityShotNext")] 		public CInt32 M_QuantityShotNext { get; set;}

		[RED("m_PlayerIsInArea")] 		public CBool M_PlayerIsInArea { get; set;}

		[RED("m_TargetsInArea", 2,0)] 		public CArray<CHandle<CEntity>> M_TargetsInArea { get; set;}

		[RED("m_CreateEntityHelper")] 		public CHandle<W3TrapProjectileArea_CreateEntityHelper> M_CreateEntityHelper { get; set;}

		[RED("m_EntityCreated")] 		public CInt32 M_EntityCreated { get; set;}

		[RED("m_WasCreatingLastFrame")] 		public CBool M_WasCreatingLastFrame { get; set;}

		[RED("m_Shot")] 		public CBool M_Shot { get; set;}

		[RED("m_DebugFloat")] 		public CFloat M_DebugFloat { get; set;}

		[RED("m_DebugIndex")] 		public CInt32 M_DebugIndex { get; set;}

		[RED("m_TotalQuantityShot")] 		public CInt32 M_TotalQuantityShot { get; set;}

		public W3TrapProjectileArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}