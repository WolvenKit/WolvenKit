using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimatedComponent : CComponent
	{
		[Ordinal(1)] [RED("ragdoll")] 		public CHandle<CRagdoll> Ragdoll { get; set;}

		[Ordinal(2)] [RED("ragdollCollisionType")] 		public CPhysicalCollision RagdollCollisionType { get; set;}

		[Ordinal(3)] [RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[Ordinal(4)] [RED("physicsRepresentation")] 		public CPtr<CAnimatedComponentPhysicsRepresentation> PhysicsRepresentation { get; set;}

		[Ordinal(5)] [RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		[Ordinal(6)] [RED("behaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> BehaviorInstanceSlots { get; set;}

		[Ordinal(7)] [RED("useExtractedMotion")] 		public CBool UseExtractedMotion { get; set;}

		[Ordinal(8)] [RED("stickRagdollToCapsule")] 		public CBool StickRagdollToCapsule { get; set;}

		[Ordinal(9)] [RED("includedInAllAppearances")] 		public CBool IncludedInAllAppearances { get; set;}

		[Ordinal(10)] [RED("savable")] 		public CBool Savable { get; set;}

		[Ordinal(11)] [RED("defaultBehaviorAnimationSlotNode")] 		public CName DefaultBehaviorAnimationSlotNode { get; set;}

		[Ordinal(12)] [RED("isFrozenOnStart")] 		public CBool IsFrozenOnStart { get; set;}

		[Ordinal(13)] [RED("defaultSpeedConfigKey")] 		public CName DefaultSpeedConfigKey { get; set;}

		[Ordinal(14)] [RED("overrideBudgetedTickDistance")] 		public CFloat OverrideBudgetedTickDistance { get; set;}

		[Ordinal(15)] [RED("overrideDisableTickDistance")] 		public CFloat OverrideDisableTickDistance { get; set;}

		[Ordinal(16)] [RED("runtimeBehaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> RuntimeBehaviorInstanceSlots { get; set;}

		[Ordinal(17)] [RED("nextFreeAnimMultCauserId")] 		public CInt32 NextFreeAnimMultCauserId { get; set;}

		[Ordinal(18)] [RED("animationMultiplierCausers", 2,0)] 		public CArray<SAnimMultiplyCauser> AnimationMultiplierCausers { get; set;}

		public CAnimatedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimatedComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}