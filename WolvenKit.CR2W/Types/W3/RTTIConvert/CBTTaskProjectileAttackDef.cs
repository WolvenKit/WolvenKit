using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttackDef : CBTTaskAttackDef
	{
		[RED("attackRange")] 		public CBehTreeValFloat AttackRange { get; set;}

		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("depotPathInsteadOfAlias")] 		public CBool DepotPathInsteadOfAlias { get; set;}

		[RED("depotPath")] 		public CString DepotPath { get; set;}

		[RED("parametrizedResourceName")] 		public CBehTreeValCName ParametrizedResourceName { get; set;}

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

		public CBTTaskProjectileAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}