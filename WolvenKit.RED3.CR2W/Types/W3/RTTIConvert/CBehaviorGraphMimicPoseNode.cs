using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicPoseNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(1)] [RED("poseType")] 		public CEnum<EMimicNodePoseType> PoseType { get; set;}

		[Ordinal(2)] [RED("poseName")] 		public CName PoseName { get; set;}

		[Ordinal(3)] [RED("cachedPoseValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseValueNode { get; set;}

		[Ordinal(4)] [RED("cachedPoseWeightNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseWeightNode { get; set;}

		public CBehaviorGraphMimicPoseNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}