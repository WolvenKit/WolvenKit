using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateProjectileAttack : CBTTask3StateAttack
	{
		[Ordinal(1)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(2)] [RED("projEntity")] 		public CHandle<CEntityTemplate> ProjEntity { get; set;}

		[Ordinal(3)] [RED("projectileName")] 		public CName ProjectileName { get; set;}

		[Ordinal(4)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(5)] [RED("useLookatTarget")] 		public CBool UseLookatTarget { get; set;}

		[Ordinal(6)] [RED("dontShootAboveAngleDistanceToTarget")] 		public CFloat DontShootAboveAngleDistanceToTarget { get; set;}

		[Ordinal(7)] [RED("projectiles", 2,0)] 		public CArray<CHandle<W3AdvancedProjectile>> Projectiles { get; set;}

		[Ordinal(8)] [RED("collisionGroups", 2,0)] 		public CArray<CName> CollisionGroups { get; set;}

		public CBTTask3StateProjectileAttack(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateProjectileAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}