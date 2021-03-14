using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRagdollNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("allowToProvidePreRagdollPose")] 		public CBool AllowToProvidePreRagdollPose { get; set;}

		[Ordinal(2)] [RED("updateAndSampleInputIfPreRagdollWeightIsNonZero")] 		public CBool UpdateAndSampleInputIfPreRagdollWeightIsNonZero { get; set;}

		[Ordinal(3)] [RED("keepInFrozenRagdollPose")] 		public CBool KeepInFrozenRagdollPose { get; set;}

		[Ordinal(4)] [RED("switchToSwimming")] 		public CBool SwitchToSwimming { get; set;}

		[Ordinal(5)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(6)] [RED("cachedRootBoneImpulseVariable")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedRootBoneImpulseVariable { get; set;}

		public CBehaviorGraphRagdollNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRagdollNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}