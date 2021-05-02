using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondAnimalFleeDef : IBehTreeHorseConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("chanceOfBeingScared")] 		public CBehTreeValFloat ChanceOfBeingScared { get; set;}

		[Ordinal(2)] [RED("chanceOfBeingScaredRerollTime")] 		public CBehTreeValFloat ChanceOfBeingScaredRerollTime { get; set;}

		[Ordinal(3)] [RED("scaredIfTargetRuns")] 		public CBehTreeValBool ScaredIfTargetRuns { get; set;}

		[Ordinal(4)] [RED("maxTolerableTargetDistance")] 		public CBehTreeValFloat MaxTolerableTargetDistance { get; set;}

		public CBTCondAnimalFleeDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondAnimalFleeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}