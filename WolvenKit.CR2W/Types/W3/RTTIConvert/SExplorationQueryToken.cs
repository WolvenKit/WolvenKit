using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SExplorationQueryToken : CVariable
	{
		[RED("valid")] 		public CBool Valid { get; set;}

		[RED("type")] 		public CEnum<EExplorationType> Type { get; set;}

		[RED("pointOnEdge")] 		public Vector PointOnEdge { get; set;}

		[RED("normal")] 		public Vector Normal { get; set;}

		[RED("usesHands")] 		public CBool UsesHands { get; set;}

		public SExplorationQueryToken(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SExplorationQueryToken(cr2w);

	}
}