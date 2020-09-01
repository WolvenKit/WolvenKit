using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondAnimalFlee : IBehTreeTask
	{
		[Ordinal(0)] [RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[Ordinal(0)] [RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[Ordinal(0)] [RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[Ordinal(0)] [RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[Ordinal(0)] [RED("rollSaysScared")] 		public CBool RollSaysScared { get; set;}

		[Ordinal(0)] [RED("rerollChanceTime")] 		public CFloat RerollChanceTime { get; set;}

		public CBTCondAnimalFlee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondAnimalFlee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}