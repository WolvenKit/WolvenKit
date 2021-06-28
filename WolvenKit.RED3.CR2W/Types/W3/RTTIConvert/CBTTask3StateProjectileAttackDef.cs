using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateProjectileAttackDef : CBTTask3StateAttackDef
	{
		[Ordinal(1)] [RED("attackRange")] 		public CFloat AttackRange { get; set;}

		[Ordinal(2)] [RED("projectileName")] 		public CName ProjectileName { get; set;}

		[Ordinal(3)] [RED("dodgeable")] 		public CBool Dodgeable { get; set;}

		[Ordinal(4)] [RED("useLookatTarget")] 		public CBool UseLookatTarget { get; set;}

		[Ordinal(5)] [RED("dontShootAboveAngleDistanceToTarget")] 		public CFloat DontShootAboveAngleDistanceToTarget { get; set;}

		public CBTTask3StateProjectileAttackDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}