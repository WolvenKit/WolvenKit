using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStaticConditionNode : CBehaviorGraphNode
	{
		[RED("condition")] 		public CPtr<IBehaviorGraphStaticCondition> Condition { get; set;}

		[RED("cachedInputANode")] 		public CPtr<CBehaviorGraphNode> CachedInputANode { get; set;}

		[RED("cachedInputBNode")] 		public CPtr<CBehaviorGraphNode> CachedInputBNode { get; set;}

		public CBehaviorGraphStaticConditionNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphStaticConditionNode(cr2w);

	}
}