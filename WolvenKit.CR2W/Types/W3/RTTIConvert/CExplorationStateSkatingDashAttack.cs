using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateSkatingDashAttack : CExplorationStateSkatingDash
	{
		[Ordinal(0)] [RED("("attacked")] 		public CBool Attacked { get; set;}

		[Ordinal(0)] [RED("("afterAttackTime")] 		public CFloat AfterAttackTime { get; set;}

		[Ordinal(0)] [RED("("timeToEndCur")] 		public CFloat TimeToEndCur { get; set;}

		[Ordinal(0)] [RED("("behParamAttackName")] 		public CName BehParamAttackName { get; set;}

		[Ordinal(0)] [RED("("afterAttackImpulse")] 		public CFloat AfterAttackImpulse { get; set;}

		public CExplorationStateSkatingDashAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExplorationStateSkatingDashAttack(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}