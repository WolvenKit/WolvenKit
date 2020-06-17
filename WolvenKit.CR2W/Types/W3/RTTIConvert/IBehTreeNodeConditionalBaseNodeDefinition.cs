using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IBehTreeNodeConditionalBaseNodeDefinition : IBehTreeMetanodeDefinition
	{
		[RED("childNodeToDisableCount")] 		public CUInt32 ChildNodeToDisableCount { get; set;}

		[RED("child")] 		public CPtr<IBehTreeNodeDefinition> Child { get; set;}

		[RED("invertCondition")] 		public CBool InvertCondition { get; set;}

		public IBehTreeNodeConditionalBaseNodeDefinition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new IBehTreeNodeConditionalBaseNodeDefinition(cr2w);

	}
}