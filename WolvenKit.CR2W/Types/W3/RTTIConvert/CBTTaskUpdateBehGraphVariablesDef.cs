using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUpdateBehGraphVariablesDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("updateOnlyOnActivate")] 		public CBool UpdateOnlyOnActivate { get; set;}

		[Ordinal(0)] [RED("DistanceToTarget")] 		public CBool DistanceToTarget { get; set;}

		[Ordinal(0)] [RED("AngleToTarget")] 		public CBool AngleToTarget { get; set;}

		[Ordinal(0)] [RED("TargetIsOnGround")] 		public CBool TargetIsOnGround { get; set;}

		[Ordinal(0)] [RED("predictionDelay")] 		public CFloat PredictionDelay { get; set;}

		[Ordinal(0)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskUpdateBehGraphVariablesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUpdateBehGraphVariablesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}