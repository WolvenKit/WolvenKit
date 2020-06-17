using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimatedComponent : CComponent
	{
		[RED("ragdoll")] 		public CHandle<CRagdoll> Ragdoll { get; set;}

		[RED("ragdollCollisionType")] 		public CPhysicalCollision RagdollCollisionType { get; set;}

		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("physicsRepresentation")] 		public CPtr<CAnimatedComponentPhysicsRepresentation> PhysicsRepresentation { get; set;}

		[RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		[RED("behaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> BehaviorInstanceSlots { get; set;}

		[RED("useExtractedMotion")] 		public CBool UseExtractedMotion { get; set;}

		[RED("stickRagdollToCapsule")] 		public CBool StickRagdollToCapsule { get; set;}

		[RED("includedInAllAppearances")] 		public CBool IncludedInAllAppearances { get; set;}

		[RED("savable")] 		public CBool Savable { get; set;}

		[RED("defaultBehaviorAnimationSlotNode")] 		public CName DefaultBehaviorAnimationSlotNode { get; set;}

		[RED("isFrozenOnStart")] 		public CBool IsFrozenOnStart { get; set;}

		[RED("defaultSpeedConfigKey")] 		public CName DefaultSpeedConfigKey { get; set;}

		[RED("overrideBudgetedTickDistance")] 		public CFloat OverrideBudgetedTickDistance { get; set;}

		[RED("overrideDisableTickDistance")] 		public CFloat OverrideDisableTickDistance { get; set;}

		[RED("runtimeBehaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> RuntimeBehaviorInstanceSlots { get; set;}

		public CAnimatedComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimatedComponent(cr2w);

	}
}