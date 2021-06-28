using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeTaskCSEffect : IBehTreeTask
	{
		[Ordinal(1)] [RED("CSType")] 		public CEnum<ECriticalStateType> CSType { get; set;}

		[Ordinal(2)] [RED("requestedCSType")] 		public CEnum<ECriticalStateType> RequestedCSType { get; set;}

		[Ordinal(3)] [RED("buffType")] 		public CEnum<EEffectType> BuffType { get; set;}

		[Ordinal(4)] [RED("buff")] 		public CHandle<CBaseGameplayEffect> Buff { get; set;}

		[Ordinal(5)] [RED("finisherAnimName")] 		public CName FinisherAnimName { get; set;}

		[Ordinal(6)] [RED("hasBuff")] 		public CBool HasBuff { get; set;}

		[Ordinal(7)] [RED("allowBlend")] 		public CBool AllowBlend { get; set;}

		[Ordinal(8)] [RED("hitReactionDisabled")] 		public CBool HitReactionDisabled { get; set;}

		[Ordinal(9)] [RED("waitForDropItem")] 		public CBool WaitForDropItem { get; set;}

		[Ordinal(10)] [RED("isInAir")] 		public CBool IsInAir { get; set;}

		[Ordinal(11)] [RED("heightDiff")] 		public CFloat HeightDiff { get; set;}

		[Ordinal(12)] [RED("isInPotentialRagdoll")] 		public CBool IsInPotentialRagdoll { get; set;}

		[Ordinal(13)] [RED("guardOpen")] 		public CBool GuardOpen { get; set;}

		[Ordinal(14)] [RED("criticalStatesToResist")] 		public CInt32 CriticalStatesToResist { get; set;}

		[Ordinal(15)] [RED("resistCriticalStateChance")] 		public CInt32 ResistCriticalStateChance { get; set;}

		[Ordinal(16)] [RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(17)] [RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		[Ordinal(18)] [RED("finisherEnabled")] 		public CBool FinisherEnabled { get; set;}

		[Ordinal(19)] [RED("forceFinisherActivation")] 		public CBool ForceFinisherActivation { get; set;}

		[Ordinal(20)] [RED("finisherDisabled")] 		public CBool FinisherDisabled { get; set;}

		[Ordinal(21)] [RED("pullToNavRadiusMult")] 		public CFloat PullToNavRadiusMult { get; set;}

		[Ordinal(22)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		[Ordinal(23)] [RED("armored")] 		public CBool Armored { get; set;}

		[Ordinal(24)] [RED("hitAnim")] 		public CBool HitAnim { get; set;}

		[Ordinal(25)] [RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[Ordinal(26)] [RED("ragdollPullingEventReceived")] 		public CBool RagdollPullingEventReceived { get; set;}

		[Ordinal(27)] [RED("distanceFromRootToBone")] 		public CFloat DistanceFromRootToBone { get; set;}

		[Ordinal(28)] [RED("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[Ordinal(29)] [RED("hitsToRaiseGuard")] 		public CFloat HitsToRaiseGuard { get; set;}

		[Ordinal(30)] [RED("raiseGuardChance")] 		public CFloat RaiseGuardChance { get; set;}

		[Ordinal(31)] [RED("hitsToCounter")] 		public CFloat HitsToCounter { get; set;}

		[Ordinal(32)] [RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[Ordinal(33)] [RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		[Ordinal(34)] [RED("canCounter")] 		public CBool CanCounter { get; set;}

		[Ordinal(35)] [RED("counterRequested")] 		public CBool CounterRequested { get; set;}

		[Ordinal(36)] [RED("counterRequestTimeStamp")] 		public CFloat CounterRequestTimeStamp { get; set;}

		[Ordinal(37)] [RED("counterType")] 		public CEnum<ECriticalEffectCounterType> CounterType { get; set;}

		[Ordinal(38)] [RED("startAirPos")] 		public Vector StartAirPos { get; set;}

		[Ordinal(39)] [RED("endAirPos")] 		public Vector EndAirPos { get; set;}

		[Ordinal(40)] [RED("cachedInAir")] 		public CBool CachedInAir { get; set;}

		[Ordinal(41)] [RED("airStartTime")] 		public CFloat AirStartTime { get; set;}

		[Ordinal(42)] [RED("screamPlayed")] 		public CBool ScreamPlayed { get; set;}

		[Ordinal(43)] [RED("fallingDamage")] 		public CFloat FallingDamage { get; set;}

		[Ordinal(44)] [RED("maxFallingHeightDiff")] 		public CFloat MaxFallingHeightDiff { get; set;}

		public CBehTreeTaskCSEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}