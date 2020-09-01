using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttack : CBTTaskAttack
	{
		[Ordinal(0)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("depotPathInsteadOfAlias")] 		public CBool DepotPathInsteadOfAlias { get; set;}

		[Ordinal(0)] [RED("depotPath")] 		public CString DepotPath { get; set;}

		[Ordinal(0)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(0)] [RED("wasShot")] 		public CBool WasShot { get; set;}

		[Ordinal(0)] [RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		[Ordinal(0)] [RED("homingProjectile")] 		public CBool HomingProjectile { get; set;}

		[Ordinal(0)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(0)] [RED("shootOnGround")] 		public CBool ShootOnGround { get; set;}

		[Ordinal(0)] [RED("useLookatTarget")] 		public CBool UseLookatTarget { get; set;}

		[Ordinal(0)] [RED("startPosFrontOffset")] 		public CFloat StartPosFrontOffset { get; set;}

		[Ordinal(0)] [RED("playFXOnShootProjectile")] 		public CName PlayFXOnShootProjectile { get; set;}

		[Ordinal(0)] [RED("shootOnEventName")] 		public CName ShootOnEventName { get; set;}

		[Ordinal(0)] [RED("useCustomCollisionGroups")] 		public CBool UseCustomCollisionGroups { get; set;}

		[Ordinal(0)] [RED("collideWithRagdoll")] 		public CBool CollideWithRagdoll { get; set;}

		[Ordinal(0)] [RED("collideWithTerrain")] 		public CBool CollideWithTerrain { get; set;}

		[Ordinal(0)] [RED("collideWithStatic")] 		public CBool CollideWithStatic { get; set;}

		[Ordinal(0)] [RED("collideWithWater")] 		public CBool CollideWithWater { get; set;}

		[Ordinal(0)] [RED("useCustomTargetWithTag")] 		public CBool UseCustomTargetWithTag { get; set;}

		[Ordinal(0)] [RED("tagToFind")] 		public CName TagToFind { get; set;}

		[Ordinal(0)] [RED("distance")] 		public CFloat Distance { get; set;}

		[Ordinal(0)] [RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		[Ordinal(0)] [RED("m_Projectiles", 2,0)] 		public CArray<CHandle<W3AdvancedProjectile>> M_Projectiles { get; set;}

		[Ordinal(0)] [RED("projectile")] 		public CHandle<W3AdvancedProjectile> Projectile { get; set;}

		public CBTTaskProjectileAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}