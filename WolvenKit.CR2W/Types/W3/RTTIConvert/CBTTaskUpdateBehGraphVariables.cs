using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUpdateBehGraphVariables : IBehTreeTask
	{
		[Ordinal(1)] [RED("updateOnlyOnActivate")] 		public CBool UpdateOnlyOnActivate { get; set;}

		[Ordinal(2)] [RED("DistanceToTarget")] 		public CBool DistanceToTarget { get; set;}

		[Ordinal(3)] [RED("AngleToTarget")] 		public CBool AngleToTarget { get; set;}

		[Ordinal(4)] [RED("TargetIsOnGround")] 		public CBool TargetIsOnGround { get; set;}

		[Ordinal(5)] [RED("predictionDelay")] 		public CFloat PredictionDelay { get; set;}

		[Ordinal(6)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBTTaskUpdateBehGraphVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUpdateBehGraphVariables(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}