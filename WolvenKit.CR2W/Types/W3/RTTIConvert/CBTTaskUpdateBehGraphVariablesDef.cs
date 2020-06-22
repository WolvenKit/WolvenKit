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
		[RED("updateOnlyOnActivate")] 		public CBool UpdateOnlyOnActivate { get; set;}

		[RED("DistanceToTarget")] 		public CBool DistanceToTarget { get; set;}

		[RED("AngleToTarget")] 		public CBool AngleToTarget { get; set;}

		[RED("TargetIsOnGround")] 		public CBool TargetIsOnGround { get; set;}

		[RED("predictionDelay")] 		public CFloat PredictionDelay { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskUpdateBehGraphVariablesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUpdateBehGraphVariablesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}