using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendMultipleCondNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("inputValues", 2,0)] 		public CArray<CFloat> InputValues { get; set;}

		[Ordinal(2)] [RED("synchronizeAnimations")] 		public CBool SynchronizeAnimations { get; set;}

		[Ordinal(3)] [RED("syncMethodAnimation")] 		public CPtr<IBehaviorSyncMethod> SyncMethodAnimation { get; set;}

		[Ordinal(4)] [RED("useTransitions")] 		public CBool UseTransitions { get; set;}

		[Ordinal(5)] [RED("transitions", 2,0)] 		public CArray<CPtr<CBehaviorGraphBlendMultipleCondNode_Transition>> Transitions { get; set;}

		[Ordinal(6)] [RED("useWeightDamp")] 		public CBool UseWeightDamp { get; set;}

		[Ordinal(7)] [RED("weightDampMethod")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_DampMethod> WeightDampMethod { get; set;}

		[Ordinal(8)] [RED("useControlValueDamp")] 		public CBool UseControlValueDamp { get; set;}

		[Ordinal(9)] [RED("controlValueDampMethod")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_DampMethod> ControlValueDampMethod { get; set;}

		[Ordinal(10)] [RED("radialBlending")] 		public CBool RadialBlending { get; set;}

		[Ordinal(11)] [RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[Ordinal(12)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphBlendMultipleCondNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendMultipleCondNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}