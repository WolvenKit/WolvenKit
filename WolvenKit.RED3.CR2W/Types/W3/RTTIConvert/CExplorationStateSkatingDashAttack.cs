using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDashAttack : CExplorationStateSkatingDash
	{
		[Ordinal(1)] [RED("attacked")] 		public CBool Attacked { get; set;}

		[Ordinal(2)] [RED("afterAttackTime")] 		public CFloat AfterAttackTime { get; set;}

		[Ordinal(3)] [RED("timeToEndCur")] 		public CFloat TimeToEndCur { get; set;}

		[Ordinal(4)] [RED("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[Ordinal(5)] [RED("afterAttackImpulse")] 		public CFloat AfterAttackImpulse { get; set;}

		public CExplorationStateSkatingDashAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDashAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}