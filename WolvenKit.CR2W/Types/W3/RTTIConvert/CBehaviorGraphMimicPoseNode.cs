using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicPoseNode : CBehaviorGraphBaseMimicNode
	{
		[Ordinal(0)] [RED("("poseType")] 		public CEnum<EMimicNodePoseType> PoseType { get; set;}

		[Ordinal(0)] [RED("("poseName")] 		public CName PoseName { get; set;}

		[Ordinal(0)] [RED("("cachedPoseValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedPoseWeightNode")] 		public CPtr<CBehaviorGraphValueNode> CachedPoseWeightNode { get; set;}

		public CBehaviorGraphMimicPoseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphMimicPoseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}