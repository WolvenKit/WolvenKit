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
		[RED("lookAtName")] 		public CName LookAtName { get; set;}

		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("animationA")] 		public CName AnimationA { get; set;}

		[RED("animationB")] 		public CName AnimationB { get; set;}

		[RED("additiveMode")] 		public CBool AdditiveMode { get; set;}

		[RED("additiveType")] 		public CEnum<EAdditiveType> AdditiveType { get; set;}

		[RED("writeToPoseLikeAdditiveNode")] 		public CBool WriteToPoseLikeAdditiveNode { get; set;}

		[RED("convertAnimationToAdditiveFlagA")] 		public CBool ConvertAnimationToAdditiveFlagA { get; set;}

		[RED("convertAnimationToAdditiveRefFrameNumA")] 		public CInt32 ConvertAnimationToAdditiveRefFrameNumA { get; set;}

		[RED("convertAnimationToAdditiveFlagB")] 		public CBool ConvertAnimationToAdditiveFlagB { get; set;}

		[RED("convertAnimationToAdditiveRefFrameNumB")] 		public CInt32 ConvertAnimationToAdditiveRefFrameNumB { get; set;}

		[RED("Lower body part bones", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Lower_body_part_bones { get; set;}

		[RED("targetWeightCurve")] 		public CPtr<CCurve> TargetWeightCurve { get; set;}

		[RED("targetWeightCurve2")] 		public CPtr<CCurve> TargetWeightCurve2 { get; set;}

		[RED("headDownCurve")] 		public CPtr<CCurve> HeadDownCurve { get; set;}

		[RED("headProgressCurve")] 		public CPtr<CCurve> HeadProgressCurve { get; set;}

		[RED("handL")] 		public CString HandL { get; set;}

		[RED("handR")] 		public CString HandR { get; set;}

		[RED("handDragCurve")] 		public CPtr<CCurve> HandDragCurve { get; set;}

		[RED("useBlendInsteadOfTargetTransition")] 		public CBool UseBlendInsteadOfTargetTransition { get; set;}

		[RED("transition")] 		public CPtr<IBehaviorGraphPointCloudLookAtTransition> Transition { get; set;}

		[RED("useTransitionWeightPred")] 		public CBool UseTransitionWeightPred { get; set;}

		[RED("transitionBonesPred", 2,0)] 		public CArray<CName> TransitionBonesPred { get; set;}

		[RED("transitionPredCurve")] 		public CPtr<CCurve> TransitionPredCurve { get; set;}

		[RED("secondaryMotion")] 		public CPtr<CBehaviorGraphPointCloudLookAtSecMotion> SecondaryMotion { get; set;}

		[RED("cachedTargetNodeA")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNodeA { get; set;}

		[RED("cachedTargetNodeB")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNodeB { get; set;}

		[RED("cachedFallbackNode")] 		public CPtr<CBehaviorGraphNode> CachedFallbackNode { get; set;}

		[RED("cachedProgressNode")] 		public CPtr<CBehaviorGraphValueNode> CachedProgressNode { get; set;}

		[RED("cachedWeightANode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightANode { get; set;}

		[RED("cachedWeightBNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightBNode { get; set;}

		[RED("cachedUseSecBlendANode")] 		public CPtr<CBehaviorGraphValueNode> CachedUseSecBlendANode { get; set;}

		[RED("cachedUseSecBlendBNode")] 		public CPtr<CBehaviorGraphValueNode> CachedUseSecBlendBNode { get; set;}

		[RED("cachedDurationNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationNode { get; set;}

		public CBehaviorGraphPointCloudLookAtNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPointCloudLookAtNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}