using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondAnimalFleeDef : IBehTreeHorseConditionalTaskDefinition
	{
		[RED("chanceOfBeingScared")] 		public CBehTreeValFloat ChanceOfBeingScared { get; set;}

		[RED("chanceOfBeingScaredRerollTime")] 		public CBehTreeValFloat ChanceOfBeingScaredRerollTime { get; set;}

		[RED("scaredIfTargetRuns")] 		public CBehTreeValBool ScaredIfTargetRuns { get; set;}

		[RED("maxTolerableTargetDistance")] 		public CBehTreeValFloat MaxTolerableTargetDistance { get; set;}

		public CBTCondAnimalFleeDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondAnimalFleeDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}