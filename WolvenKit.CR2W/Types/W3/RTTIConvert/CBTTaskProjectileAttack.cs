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
		[RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("depotPathInsteadOfAlias")] 		public CBool DepotPathInsteadOfAlias { get; set;}

		[RED("depotPath")] 		public CString DepotPath { get; set;}

		[RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[RED("wasShot")] 		public CBool WasShot { get; set;}

		[RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		[RED("homingProjectile")] 		public CBool HomingProjectile { get; set;}

		[RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[RED("shootOnGround")] 		public CBool ShootOnGround { get; set;}

		[RED("useLookatTarget")] 		public CBool UseLookatTarget { get; set;}

		[RED("startPosFrontOffset")] 		public CFloat StartPosFrontOffset { get; set;}

		[RED("playFXOnShootProjectile")] 		public CName PlayFXOnShootProjectile { get; set;}

		[RED("shootOnEventName")] 		public CName ShootOnEventName { get; set;}

		[RED("useCustomCollisionGroups")] 		public CBool UseCustomCollisionGroups { get; set;}

		[RED("collideWithRagdoll")] 		public CBool CollideWithRagdoll { get; set;}

		[RED("collideWithTerrain")] 		public CBool CollideWithTerrain { get; set;}

		[RED("collideWithStatic")] 		public CBool CollideWithStatic { get; set;}

		[RED("collideWithWater")] 		public CBool CollideWithWater { get; set;}

		[RED("useCustomTargetWithTag")] 		public CBool UseCustomTargetWithTag { get; set;}

		[RED("tagToFind")] 		public CName TagToFind { get; set;}

		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("couldntLoadResource")] 		public CBool CouldntLoadResource { get; set;}

		[RED("m_Projectiles", 2,0)] 		public CArray<CHandle<W3AdvancedProjectile>> M_Projectiles { get; set;}

		[RED("projectile")] 		public CHandle<W3AdvancedProjectile> Projectile { get; set;}

		public CBTTaskProjectileAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}