using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeStrafingAlgorithmFastSurroundDefinition : CBehTreeStrafingAlgorithmDefinition
	{
		[Ordinal(1)] [RED("usageDelay")] 		public CBehTreeValFloat UsageDelay { get; set;}

		[Ordinal(2)] [RED("distanceToActivate")] 		public CBehTreeValFloat DistanceToActivate { get; set;}

		[Ordinal(3)] [RED("speedMinToActivate")] 		public CBehTreeValFloat SpeedMinToActivate { get; set;}

		[Ordinal(4)] [RED("distanceToBreak")] 		public CBehTreeValFloat DistanceToBreak { get; set;}

		[Ordinal(5)] [RED("verticalHeadingLimitToBreak")] 		public CBehTreeValFloat VerticalHeadingLimitToBreak { get; set;}

		[Ordinal(6)] [RED("speedMinLimitToBreak")] 		public CBehTreeValFloat SpeedMinLimitToBreak { get; set;}

		[Ordinal(7)] [RED("surroundMoveType")] 		public CBehTreeValEMoveType SurroundMoveType { get; set;}

		public CBehTreeStrafingAlgorithmFastSurroundDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeStrafingAlgorithmFastSurroundDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}