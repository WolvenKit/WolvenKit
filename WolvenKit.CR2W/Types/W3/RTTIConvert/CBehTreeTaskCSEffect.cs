using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskCSEffect : IBehTreeTask
	{
		[Ordinal(0)] [RED("CSType")] 		public CEnum<ECriticalStateType> CSType { get; set;}

		[Ordinal(0)] [RED("requestedCSType")] 		public CEnum<ECriticalStateType> RequestedCSType { get; set;}

		[Ordinal(0)] [RED("buffType")] 		public CEnum<EEffectType> BuffType { get; set;}

		[Ordinal(0)] [RED("buff")] 		public CHandle<CBaseGameplayEffect> Buff { get; set;}

		[Ordinal(0)] [RED("finisherAnimName")] 		public CName FinisherAnimName { get; set;}

		[Ordinal(0)] [RED("hasBuff")] 		public CBool HasBuff { get; set;}

		[Ordinal(0)] [RED("allowBlend")] 		public CBool AllowBlend { get; set;}

		[Ordinal(0)] [RED("hitReactionDisabled")] 		public CBool HitReactionDisabled { get; set;}

		[Ordinal(0)] [RED("waitForDropItem")] 		public CBool WaitForDropItem { get; set;}

		[Ordinal(0)] [RED("isInAir")] 		public CBool IsInAir { get; set;}

		[Ordinal(0)] [RED("heightDiff")] 		public CFloat HeightDiff { get; set;}

		[Ordinal(0)] [RED("isInPotentialRagdoll")] 		public CBool IsInPotentialRagdoll { get; set;}

		[Ordinal(0)] [RED("guardOpen")] 		public CBool GuardOpen { get; set;}

		[Ordinal(0)] [RED("criticalStatesToResist")] 		public CInt32 CriticalStatesToResist { get; set;}

		[Ordinal(0)] [RED("resistCriticalStateChance")] 		public CInt32 ResistCriticalStateChance { get; set;}

		[Ordinal(0)] [RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(0)] [RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		[Ordinal(0)] [RED("finisherEnabled")] 		public CBool FinisherEnabled { get; set;}

		[Ordinal(0)] [RED("forceFinisherActivation")] 		public CBool ForceFinisherActivation { get; set;}

		[Ordinal(0)] [RED("finisherDisabled")] 		public CBool FinisherDisabled { get; set;}

		[Ordinal(0)] [RED("pullToNavRadiusMult")] 		public CFloat PullToNavRadiusMult { get; set;}

		[Ordinal(0)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		[Ordinal(0)] [RED("armored")] 		public CBool Armored { get; set;}

		[Ordinal(0)] [RED("hitAnim")] 		public CBool HitAnim { get; set;}

		[Ordinal(0)] [RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[Ordinal(0)] [RED("ragdollPullingEventReceived")] 		public CBool RagdollPullingEventReceived { get; set;}

		[Ordinal(0)] [RED("distanceFromRootToBone")] 		public CFloat DistanceFromRootToBone { get; set;}

		[Ordinal(0)] [RED("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[Ordinal(0)] [RED("hitsToRaiseGuard")] 		public CFloat HitsToRaiseGuard { get; set;}

		[Ordinal(0)] [RED("raiseGuardChance")] 		public CFloat RaiseGuardChance { get; set;}

		[Ordinal(0)] [RED("hitsToCounter")] 		public CFloat HitsToCounter { get; set;}

		[Ordinal(0)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(0)] [RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		[Ordinal(0)] [RED("canCounter")] 		public CBool CanCounter { get; set;}

		[Ordinal(0)] [RED("counterRequested")] 		public CBool CounterRequested { get; set;}

		[Ordinal(0)] [RED("counterRequestTimeStamp")] 		public CFloat CounterRequestTimeStamp { get; set;}

		[Ordinal(0)] [RED("counterType")] 		public CEnum<ECriticalEffectCounterType> CounterType { get; set;}

		[Ordinal(0)] [RED("startAirPos")] 		public Vector StartAirPos { get; set;}

		[Ordinal(0)] [RED("endAirPos")] 		public Vector EndAirPos { get; set;}

		[Ordinal(0)] [RED("cachedInAir")] 		public CBool CachedInAir { get; set;}

		[Ordinal(0)] [RED("airStartTime")] 		public CFloat AirStartTime { get; set;}

		[Ordinal(0)] [RED("screamPlayed")] 		public CBool ScreamPlayed { get; set;}

		[Ordinal(0)] [RED("fallingDamage")] 		public CFloat FallingDamage { get; set;}

		[Ordinal(0)] [RED("maxFallingHeightDiff")] 		public CFloat MaxFallingHeightDiff { get; set;}

		public CBehTreeTaskCSEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskCSEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}