using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondAnimalFlee : IBehTreeTask
	{
		[Ordinal(1)] [RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[Ordinal(2)] [RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[Ordinal(3)] [RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[Ordinal(4)] [RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[Ordinal(5)] [RED("rollSaysScared")] 		public CBool RollSaysScared { get; set;}

		[Ordinal(6)] [RED("rerollChanceTime")] 		public CFloat RerollChanceTime { get; set;}

		public CBTCondAnimalFlee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondAnimalFlee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}