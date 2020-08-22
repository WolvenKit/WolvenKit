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
		[RED("chanceOfBeingScared")] 		public CFloat ChanceOfBeingScared { get; set;}

		[RED("chanceOfBeingScaredRerollTime")] 		public CFloat ChanceOfBeingScaredRerollTime { get; set;}

		[RED("scaredIfTargetRuns")] 		public CBool ScaredIfTargetRuns { get; set;}

		[RED("maxTolerableTargetDistance")] 		public CFloat MaxTolerableTargetDistance { get; set;}

		[RED("rollSaysScared")] 		public CBool RollSaysScared { get; set;}

		[RED("rerollChanceTime")] 		public CFloat RerollChanceTime { get; set;}

		public CBTCondAnimalFlee(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondAnimalFlee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}