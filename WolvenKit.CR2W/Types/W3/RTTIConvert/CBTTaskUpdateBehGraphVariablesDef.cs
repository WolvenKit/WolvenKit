using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUpdateBehGraphVariablesDef : IBehTreeTaskDefinition
	{
		[RED("updateOnlyOnActivate")] 		public CBool UpdateOnlyOnActivate { get; set;}

		[RED("DistanceToTarget")] 		public CBool DistanceToTarget { get; set;}

		[RED("AngleToTarget")] 		public CBool AngleToTarget { get; set;}

		[RED("TargetIsOnGround")] 		public CBool TargetIsOnGround { get; set;}

		[RED("predictionDelay")] 		public CFloat PredictionDelay { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskUpdateBehGraphVariablesDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskUpdateBehGraphVariablesDef(cr2w);

	}
}