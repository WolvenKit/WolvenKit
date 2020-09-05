using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMathNode : CBehaviorGraphValueNode
	{
		[Ordinal(1)] [RED("operation")] 		public CEnum<EBehaviorMathOp> Operation { get; set;}

		[Ordinal(2)] [RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

		[Ordinal(3)] [RED("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSecondInputNode { get; set;}

		public CBehaviorGraphMathNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMathNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}