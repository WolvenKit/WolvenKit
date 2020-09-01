using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPointCloudLookAtNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("lookAtName")] 		public CName LookAtName { get; set;}

		[Ordinal(0)] [RED("("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(0)] [RED("("animationA")] 		public CName AnimationA { get; set;}

		[Ordinal(0)] [RED("("animationB")] 		public CName AnimationB { get; set;}

		[Ordinal(0)] [RED("("additiveMode")] 		public CBool AdditiveMode { get; set;}

		[Ordinal(0)] [RED("("additiveType")] 		public CEnum<EAdditiveType> AdditiveType { get; set;}

		[Ordinal(0)] [RED("("writeToPoseLikeAdditiveNode")] 		public CBool WriteToPoseLikeAdditiveNode { get; set;}

		[Ordinal(0)] [RED("("convertAnimationToAdditiveFlagA")] 		public CBool ConvertAnimationToAdditiveFlagA { get; set;}

		[Ordinal(0)] [RED("("convertAnimationToAdditiveRefFrameNumA")] 		public CInt32 ConvertAnimationToAdditiveRefFrameNumA { get; set;}

		[Ordinal(0)] [RED("("convertAnimationToAdditiveFlagB")] 		public CBool ConvertAnimationToAdditiveFlagB { get; set;}

		[Ordinal(0)] [RED("("convertAnimationToAdditiveRefFrameNumB")] 		public CInt32 ConvertAnimationToAdditiveRefFrameNumB { get; set;}

		[Ordinal(0)] [RED("("Lower body part bones", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Lower_body_part_bones { get; set;}

		[Ordinal(0)] [RED("("targetWeightCurve")] 		public CPtr<CCurve> TargetWeightCurve { get; set;}

		[Ordinal(0)] [RED("("targetWeightCurve2")] 		public CPtr<CCurve> TargetWeightCurve2 { get; set;}

		[Ordinal(0)] [RED("("headDownCurve")] 		public CPtr<CCurve> HeadDownCurve { get; set;}

		[Ordinal(0)] [RED("("headProgressCurve")] 		public CPtr<CCurve> HeadProgressCurve { get; set;}

		[Ordinal(0)] [RED("("handL")] 		public CString HandL { get; set;}

		[Ordinal(0)] [RED("("handR")] 		public CString HandR { get; set;}

		[Ordinal(0)] [RED("("handDragCurve")] 		public CPtr<CCurve> HandDragCurve { get; set;}

		[Ordinal(0)] [RED("("useBlendInsteadOfTargetTransition")] 		public CBool UseBlendInsteadOfTargetTransition { get; set;}

		[Ordinal(0)] [RED("("transition")] 		public CPtr<IBehaviorGraphPointCloudLookAtTransition> Transition { get; set;}

		[Ordinal(0)] [RED("("useTransitionWeightPred")] 		public CBool UseTransitionWeightPred { get; set;}

		[Ordinal(0)] [RED("("transitionBonesPred", 2,0)] 		public CArray<CName> TransitionBonesPred { get; set;}

		[Ordinal(0)] [RED("("transitionPredCurve")] 		public CPtr<CCurve> TransitionPredCurve { get; set;}

		[Ordinal(0)] [RED("("secondaryMotion")] 		public CPtr<CBehaviorGraphPointCloudLookAtSecMotion> SecondaryMotion { get; set;}

		[Ordinal(0)] [RED("("cachedTargetNodeA")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNodeA { get; set;}

		[Ordinal(0)] [RED("("cachedTargetNodeB")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNodeB { get; set;}

		[Ordinal(0)] [RED("("cachedFallbackNode")] 		public CPtr<CBehaviorGraphNode> CachedFallbackNode { get; set;}

		[Ordinal(0)] [RED("("cachedProgressNode")] 		public CPtr<CBehaviorGraphValueNode> CachedProgressNode { get; set;}

		[Ordinal(0)] [RED("("cachedWeightANode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightANode { get; set;}

		[Ordinal(0)] [RED("("cachedWeightBNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightBNode { get; set;}

		[Ordinal(0)] [RED("("cachedUseSecBlendANode")] 		public CPtr<CBehaviorGraphValueNode> CachedUseSecBlendANode { get; set;}

		[Ordinal(0)] [RED("("cachedUseSecBlendBNode")] 		public CPtr<CBehaviorGraphValueNode> CachedUseSecBlendBNode { get; set;}

		[Ordinal(0)] [RED("("cachedDurationNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationNode { get; set;}

		public CBehaviorGraphPointCloudLookAtNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPointCloudLookAtNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}