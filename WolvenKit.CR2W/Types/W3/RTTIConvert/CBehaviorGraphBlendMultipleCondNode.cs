using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendMultipleCondNode : CBehaviorGraphNode
	{
		[RED("inputValues", 2,0)] 		public CArray<CFloat> InputValues { get; set;}

		[RED("synchronizeAnimations")] 		public CBool SynchronizeAnimations { get; set;}

		[RED("syncMethodAnimation")] 		public CPtr<IBehaviorSyncMethod> SyncMethodAnimation { get; set;}

		[RED("useTransitions")] 		public CBool UseTransitions { get; set;}

		[RED("transitions", 2,0)] 		public CArray<CPtr<CBehaviorGraphBlendMultipleCondNode_Transition>> Transitions { get; set;}

		[RED("useWeightDamp")] 		public CBool UseWeightDamp { get; set;}

		[RED("weightDampMethod")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_DampMethod> WeightDampMethod { get; set;}

		[RED("useControlValueDamp")] 		public CBool UseControlValueDamp { get; set;}

		[RED("controlValueDampMethod")] 		public CPtr<IBehaviorGraphBlendMultipleCondNode_DampMethod> ControlValueDampMethod { get; set;}

		[RED("radialBlending")] 		public CBool RadialBlending { get; set;}

		[RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphBlendMultipleCondNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendMultipleCondNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}