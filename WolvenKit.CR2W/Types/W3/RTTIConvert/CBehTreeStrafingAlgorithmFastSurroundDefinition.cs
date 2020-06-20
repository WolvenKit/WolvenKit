using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeStrafingAlgorithmFastSurroundDefinition : CBehTreeStrafingAlgorithmDefinition
	{
		[RED("usageDelay")] 		public CBehTreeValFloat UsageDelay { get; set;}

		[RED("distanceToActivate")] 		public CBehTreeValFloat DistanceToActivate { get; set;}

		[RED("speedMinToActivate")] 		public CBehTreeValFloat SpeedMinToActivate { get; set;}

		[RED("distanceToBreak")] 		public CBehTreeValFloat DistanceToBreak { get; set;}

		[RED("verticalHeadingLimitToBreak")] 		public CBehTreeValFloat VerticalHeadingLimitToBreak { get; set;}

		[RED("speedMinLimitToBreak")] 		public CBehTreeValFloat SpeedMinLimitToBreak { get; set;}

		[RED("surroundMoveType")] 		public CBehTreeValEMoveType SurroundMoveType { get; set;}

		public CBehTreeStrafingAlgorithmFastSurroundDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeStrafingAlgorithmFastSurroundDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}