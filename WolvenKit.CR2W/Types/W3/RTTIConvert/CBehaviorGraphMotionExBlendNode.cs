using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMotionExBlendNode : CBehaviorGraphNode
	{
		[RED("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphNode> CachedFirstInputNode { get; set;}

		[RED("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphNode> CachedSecondInputNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedSpeedVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedVariableNode { get; set;}

		[RED("threshold")] 		public CFloat Threshold { get; set;}

		public CBehaviorGraphMotionExBlendNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMotionExBlendNode(cr2w);

	}
}