using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSelectorDefinition : IBehTreeNodeCompositeDefinition
	{
		[RED("checkFrequency")] 		public CFloat CheckFrequency { get; set;}

		[RED("useScoring")] 		public CBool UseScoring { get; set;}

		[RED("selectRandom")] 		public CBool SelectRandom { get; set;}

		[RED("forwardChildrenCompletness")] 		public CBool ForwardChildrenCompletness { get; set;}

		public CBehTreeNodeSelectorDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehTreeNodeSelectorDefinition(cr2w);

	}
}