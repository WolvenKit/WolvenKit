using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicPoseNode : CBehaviorGraphBaseMimicNode
	{
		[RED("poseType")] 		public EMimicNodePoseType PoseType { get; set;}

		[RED("poseName")] 		public CName PoseName { get; set;}

		[RED("cachedPoseValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseValueNode { get; set;}

		[RED("cachedPoseWeightNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseWeightNode { get; set;}

		public CBehaviorGraphMimicPoseNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicPoseNode(cr2w);

	}
}