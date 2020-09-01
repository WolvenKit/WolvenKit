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
		[Ordinal(0)] [RED("ragdoll")] 		public CHandle<CRagdoll> Ragdoll { get; set;}

		[Ordinal(0)] [RED("ragdollCollisionType")] 		public CPhysicalCollision RagdollCollisionType { get; set;}

		[Ordinal(0)] [RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[Ordinal(0)] [RED("physicsRepresentation")] 		public CPtr<CAnimatedComponentPhysicsRepresentation> PhysicsRepresentation { get; set;}

		[Ordinal(0)] [RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		[Ordinal(0)] [RED("behaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> BehaviorInstanceSlots { get; set;}

		[Ordinal(0)] [RED("useExtractedMotion")] 		public CBool UseExtractedMotion { get; set;}

		[Ordinal(0)] [RED("stickRagdollToCapsule")] 		public CBool StickRagdollToCapsule { get; set;}

		[Ordinal(0)] [RED("includedInAllAppearances")] 		public CBool IncludedInAllAppearances { get; set;}

		[Ordinal(0)] [RED("savable")] 		public CBool Savable { get; set;}

		[Ordinal(0)] [RED("defaultBehaviorAnimationSlotNode")] 		public CName DefaultBehaviorAnimationSlotNode { get; set;}

		[Ordinal(0)] [RED("isFrozenOnStart")] 		public CBool IsFrozenOnStart { get; set;}

		[Ordinal(0)] [RED("defaultSpeedConfigKey")] 		public CName DefaultSpeedConfigKey { get; set;}

		[Ordinal(0)] [RED("overrideBudgetedTickDistance")] 		public CFloat OverrideBudgetedTickDistance { get; set;}

		[Ordinal(0)] [RED("overrideDisableTickDistance")] 		public CFloat OverrideDisableTickDistance { get; set;}

		[Ordinal(0)] [RED("runtimeBehaviorInstanceSlots", 2,0)] 		public CArray<SBehaviorGraphInstanceSlot> RuntimeBehaviorInstanceSlots { get; set;}

		[Ordinal(0)] [RED("nextFreeAnimMultCauserId")] 		public CInt32 NextFreeAnimMultCauserId { get; set;}

		[Ordinal(0)] [RED("animationMultiplierCausers", 2,0)] 		public CArray<SAnimMultiplyCauser> AnimationMultiplierCausers { get; set;}

		public CAnimatedComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimatedComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}