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
		[RED("CSType")] 		public CEnum<ECriticalStateType> CSType { get; set;}

		[RED("requestedCSType")] 		public CEnum<ECriticalStateType> RequestedCSType { get; set;}

		[RED("buffType")] 		public CEnum<EEffectType> BuffType { get; set;}

		[RED("buff")] 		public CHandle<CBaseGameplayEffect> Buff { get; set;}

		[RED("finisherAnimName")] 		public CName FinisherAnimName { get; set;}

		[RED("hasBuff")] 		public CBool HasBuff { get; set;}

		[RED("allowBlend")] 		public CBool AllowBlend { get; set;}

		[RED("hitReactionDisabled")] 		public CBool HitReactionDisabled { get; set;}

		[RED("waitForDropItem")] 		public CBool WaitForDropItem { get; set;}

		[RED("isInAir")] 		public CBool IsInAir { get; set;}

		[RED("heightDiff")] 		public CFloat HeightDiff { get; set;}

		[RED("isInPotentialRagdoll")] 		public CBool IsInPotentialRagdoll { get; set;}

		[RED("guardOpen")] 		public CBool GuardOpen { get; set;}

		[RED("criticalStatesToResist")] 		public CInt32 CriticalStatesToResist { get; set;}

		[RED("resistCriticalStateChance")] 		public CInt32 ResistCriticalStateChance { get; set;}

		[RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		[RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		[RED("finisherEnabled")] 		public CBool FinisherEnabled { get; set;}

		[RED("forceFinisherActivation")] 		public CBool ForceFinisherActivation { get; set;}

		[RED("finisherDisabled")] 		public CBool FinisherDisabled { get; set;}

		[RED("pullToNavRadiusMult")] 		public CFloat PullToNavRadiusMult { get; set;}

		[RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		[RED("armored")] 		public CBool Armored { get; set;}

		[RED("hitAnim")] 		public CBool HitAnim { get; set;}

		[RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[RED("ragdollPullingEventReceived")] 		public CBool RagdollPullingEventReceived { get; set;}

		[RED("distanceFromRootToBone")] 		public CFloat DistanceFromRootToBone { get; set;}

		[RED("boneIndex")] 		public CInt32 BoneIndex { get; set;}

		[RED("hitsToRaiseGuard")] 		public CFloat HitsToRaiseGuard { get; set;}

		[RED("raiseGuardChance")] 		public CFloat RaiseGuardChance { get; set;}

		[RED("hitsToCounter")] 		public CFloat HitsToCounter { get; set;}

		[RED("counterChance")] 		public CFloat CounterChance { get; set;}

		[RED("counterStaminaCost")] 		public CFloat CounterStaminaCost { get; set;}

		[RED("canCounter")] 		public CBool CanCounter { get; set;}

		[RED("counterRequested")] 		public CBool CounterRequested { get; set;}

		[RED("counterRequestTimeStamp")] 		public CFloat CounterRequestTimeStamp { get; set;}

		[RED("counterType")] 		public CEnum<ECriticalEffectCounterType> CounterType { get; set;}

		[RED("startAirPos")] 		public Vector StartAirPos { get; set;}

		[RED("endAirPos")] 		public Vector EndAirPos { get; set;}

		[RED("cachedInAir")] 		public CBool CachedInAir { get; set;}

		[RED("airStartTime")] 		public CFloat AirStartTime { get; set;}

		[RED("screamPlayed")] 		public CBool ScreamPlayed { get; set;}

		[RED("fallingDamage")] 		public CFloat FallingDamage { get; set;}

		[RED("maxFallingHeightDiff")] 		public CFloat MaxFallingHeightDiff { get; set;}

		public CBehTreeTaskCSEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeTaskCSEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}