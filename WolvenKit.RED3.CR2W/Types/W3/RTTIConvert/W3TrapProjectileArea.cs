using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TrapProjectileArea : W3Trap
	{
		[Ordinal(1)] [RED("projectile")] 		public CHandle<CEntityTemplate> Projectile { get; set;}

		[Ordinal(2)] [RED("density")] 		public CFloat Density { get; set;}

		[Ordinal(3)] [RED("maxShots")] 		public CInt32 MaxShots { get; set;}

		[Ordinal(4)] [RED("reloadAtActivation")] 		public CBool ReloadAtActivation { get; set;}

		[Ordinal(5)] [RED("projAtOnce")] 		public SRange ProjAtOnce { get; set;}

		[Ordinal(6)] [RED("delay")] 		public SRangeF Delay { get; set;}

		[Ordinal(7)] [RED("targetPlayerDelay")] 		public SRangeF TargetPlayerDelay { get; set;}

		[Ordinal(8)] [RED("height")] 		public SRangeF Height { get; set;}

		[Ordinal(9)] [RED("velocity")] 		public SRangeF Velocity { get; set;}

		[Ordinal(10)] [RED("projectileOriginOffsetX")] 		public SRangeF ProjectileOriginOffsetX { get; set;}

		[Ordinal(11)] [RED("projectileOriginOffsetY")] 		public SRangeF ProjectileOriginOffsetY { get; set;}

		[Ordinal(12)] [RED("shootOnlyWhenTargetInside")] 		public CBool ShootOnlyWhenTargetInside { get; set;}

		[Ordinal(13)] [RED("deactivateAutomatically")] 		public CBool DeactivateAutomatically { get; set;}

		[Ordinal(14)] [RED("useAdvancedDistribution")] 		public CBool UseAdvancedDistribution { get; set;}

		[Ordinal(15)] [RED("useGridPositioning")] 		public CBool UseGridPositioning { get; set;}

		[Ordinal(16)] [RED("excludedEntityTags", 2,0)] 		public CArray<CName> ExcludedEntityTags { get; set;}

		[Ordinal(17)] [RED("magnetTags", 2,0)] 		public CArray<CName> MagnetTags { get; set;}

		[Ordinal(18)] [RED("magnetRange")] 		public CFloat MagnetRange { get; set;}

		[Ordinal(19)] [RED("magnetOffset")] 		public Vector MagnetOffset { get; set;}

		[Ordinal(20)] [RED("maxDistanceFromPlayer")] 		public CFloat MaxDistanceFromPlayer { get; set;}

		[Ordinal(21)] [RED("forbidingAreaRadius")] 		public CFloat ForbidingAreaRadius { get; set;}

		[Ordinal(22)] [RED("m_AreaComponent")] 		public CHandle<CTriggerAreaComponent> M_AreaComponent { get; set;}

		[Ordinal(23)] [RED("m_ProjectilePositionGrid", 2,0)] 		public CArray<Vector> M_ProjectilePositionGrid { get; set;}

		[Ordinal(24)] [RED("m_UsedProjectilePosition", 2,0)] 		public CArray<Vector> M_UsedProjectilePosition { get; set;}

		[Ordinal(25)] [RED("m_AcceptablePos", 2,0)] 		public CArray<Vector> M_AcceptablePos { get; set;}

		[Ordinal(26)] [RED("m_ForbiddenPos", 2,0)] 		public CArray<Vector> M_ForbiddenPos { get; set;}

		[Ordinal(27)] [RED("m_LastPlayerCheckedPos")] 		public Vector M_LastPlayerCheckedPos { get; set;}

		[Ordinal(28)] [RED("m_LastQuantOfForbidAreas")] 		public CInt32 M_LastQuantOfForbidAreas { get; set;}

		[Ordinal(29)] [RED("m_GridSquareWidth")] 		public CFloat M_GridSquareWidth { get; set;}

		[Ordinal(30)] [RED("m_GridSquareLength")] 		public CFloat M_GridSquareLength { get; set;}

		[Ordinal(31)] [RED("m_DelayUntilNextShoot")] 		public CFloat M_DelayUntilNextShoot { get; set;}

		[Ordinal(32)] [RED("m_DelayUntilNextPlayerShoot")] 		public CFloat M_DelayUntilNextPlayerShoot { get; set;}

		[Ordinal(33)] [RED("m_QuantityShotNext")] 		public CInt32 M_QuantityShotNext { get; set;}

		[Ordinal(34)] [RED("m_PlayerIsInArea")] 		public CBool M_PlayerIsInArea { get; set;}

		[Ordinal(35)] [RED("m_TargetsInArea", 2,0)] 		public CArray<CHandle<CEntity>> M_TargetsInArea { get; set;}

		[Ordinal(36)] [RED("m_CreateEntityHelper")] 		public CHandle<W3TrapProjectileArea_CreateEntityHelper> M_CreateEntityHelper { get; set;}

		[Ordinal(37)] [RED("m_EntityCreated")] 		public CInt32 M_EntityCreated { get; set;}

		[Ordinal(38)] [RED("m_WasCreatingLastFrame")] 		public CBool M_WasCreatingLastFrame { get; set;}

		[Ordinal(39)] [RED("m_Shot")] 		public CBool M_Shot { get; set;}

		[Ordinal(40)] [RED("m_DebugFloat")] 		public CFloat M_DebugFloat { get; set;}

		[Ordinal(41)] [RED("m_DebugIndex")] 		public CInt32 M_DebugIndex { get; set;}

		[Ordinal(42)] [RED("m_TotalQuantityShot")] 		public CInt32 M_TotalQuantityShot { get; set;}

		public W3TrapProjectileArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TrapProjectileArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}