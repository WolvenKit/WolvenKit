using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphOutputNode : CBehaviorGraphNode
	{
		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[RED("cachedCustomInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphValueNode>> CachedCustomInputNodes { get; set;}

		[RED("cachedFloatInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphValueNode>> CachedFloatInputNodes { get; set;}

		public CBehaviorGraphOutputNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphOutputNode(cr2w);

	}
}