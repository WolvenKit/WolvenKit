using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphVectorMathNode : CBehaviorGraphVectorValueNode
	{
		[RED("operation")] 		public CEnum<EBehaviorVectorMathOp> Operation { get; set;}

		[RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedFirstInputNode { get; set;}

		[RED("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedSecondInputNode { get; set;}

		[RED("cachedScalarInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedScalarInputNode { get; set;}

		public CBehaviorGraphVectorMathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphVectorMathNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}