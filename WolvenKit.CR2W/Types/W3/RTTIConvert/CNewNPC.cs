using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNewNPC : CActor
	{
		[Ordinal(0)] [RED("aiEnabled")] 		public CBool AiEnabled { get; set;}

		[Ordinal(0)] [RED("suppressBroadcastingReactions")] 		public CBool SuppressBroadcastingReactions { get; set;}

		[Ordinal(0)] [RED("berserkTime")] 		public EngineTime BerserkTime { get; set;}

		[Ordinal(0)] [RED("npcGroupType")] 		public CEnum<ENPCGroupType> NpcGroupType { get; set;}

		[Ordinal(0)] [RED("isImmortal")] 		public CBool IsImmortal { get; set;}

		[Ordinal(0)] [RED("isInvulnerable")] 		public CBool IsInvulnerable { get; set;}

		[Ordinal(0)] [RED("willBeUnconscious")] 		public CBool WillBeUnconscious { get; set;}

		[Ordinal(0)] [RED("minUnconsciousTime")] 		public CFloat MinUnconsciousTime { get; set;}

		[Ordinal(0)] [RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[Ordinal(0)] [RED("RemainsTags", 2,0)] 		public CArray<CName> RemainsTags { get; set;}

		[Ordinal(0)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(0)] [RED("currentLevel")] 		public CInt32 CurrentLevel { get; set;}

		[Ordinal(0)] [RED("levelFakeAddon")] 		public CInt32 LevelFakeAddon { get; set;}

		[Ordinal(0)] [RED("newGamePlusFakeLevelAddon")] 		public CBool NewGamePlusFakeLevelAddon { get; set;}

		[Ordinal(0)] [RED("xmlLevel")] 		public SAbilityAttributeValue XmlLevel { get; set;}

		[Ordinal(0)] [RED("isXmlLevelSet")] 		public CBool IsXmlLevelSet { get; set;}

		[Ordinal(0)] [RED("isMiniBossLevel")] 		public CBool IsMiniBossLevel { get; set;}

		[Ordinal(0)] [RED("dontUseReactionOneLiners")] 		public CBool DontUseReactionOneLiners { get; set;}

		[Ordinal(0)] [RED("disableConstrainLookat")] 		public CBool DisableConstrainLookat { get; set;}

		[Ordinal(0)] [RED("isMonsterType_Group")] 		public CBool IsMonsterType_Group { get; set;}

		[Ordinal(0)] [RED("useSoundValue")] 		public CBool UseSoundValue { get; set;}

		[Ordinal(0)] [RED("soundValue")] 		public CInt32 SoundValue { get; set;}

		[Ordinal(0)] [RED("clearInvOnDeath")] 		public CBool ClearInvOnDeath { get; set;}

		[Ordinal(0)] [RED("noAdaptiveBalance")] 		public CBool NoAdaptiveBalance { get; set;}

		[Ordinal(0)] [RED("grantNoExperienceAfterKill")] 		public CBool GrantNoExperienceAfterKill { get; set;}

		[Ordinal(0)] [RED("abilityBuffStackedOnEnemyHitName")] 		public CName AbilityBuffStackedOnEnemyHitName { get; set;}

		[Ordinal(0)] [RED("levelBonusesComputedAtPlayerLevel")] 		public CInt32 LevelBonusesComputedAtPlayerLevel { get; set;}

		[Ordinal(0)] [RED("horseComponent")] 		public CHandle<W3HorseComponent> HorseComponent { get; set;}

		[Ordinal(0)] [RED("isHorse")] 		public CBool IsHorse { get; set;}

		[Ordinal(0)] [RED("canFlee")] 		public CBool CanFlee { get; set;}

		[Ordinal(0)] [RED("isFallingFromHorse")] 		public CBool IsFallingFromHorse { get; set;}

		[Ordinal(0)] [RED("immortalityInitialized")] 		public CBool ImmortalityInitialized { get; set;}

		[Ordinal(0)] [RED("canBeFollowed")] 		public CBool CanBeFollowed { get; set;}

		[Ordinal(0)] [RED("bAgony")] 		public CBool BAgony { get; set;}

		[Ordinal(0)] [RED("bFinisher")] 		public CBool BFinisher { get; set;}

		[Ordinal(0)] [RED("bPlayDeathAnim")] 		public CBool BPlayDeathAnim { get; set;}

		[Ordinal(0)] [RED("bAgonyDisabled")] 		public CBool BAgonyDisabled { get; set;}

		[Ordinal(0)] [RED("bFinisherInterrupted")] 		public CBool BFinisherInterrupted { get; set;}

		[Ordinal(0)] [RED("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[Ordinal(0)] [RED("threatLevel")] 		public CInt32 ThreatLevel { get; set;}

		[Ordinal(0)] [RED("counterWindowStartTime")] 		public EngineTime CounterWindowStartTime { get; set;}

		[Ordinal(0)] [RED("bIsCountering")] 		public CBool BIsCountering { get; set;}

		[Ordinal(0)] [RED("allowBehGraphChange")] 		public CBool AllowBehGraphChange { get; set;}

		[Ordinal(0)] [RED("aardedFlight")] 		public CBool AardedFlight { get; set;}

		[Ordinal(0)] [RED("lastMeleeHitTime")] 		public EngineTime LastMeleeHitTime { get; set;}

		[Ordinal(0)] [RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[Ordinal(0)] [RED("previousStance")] 		public CEnum<ENpcStance> PreviousStance { get; set;}

		[Ordinal(0)] [RED("regularStance")] 		public CEnum<ENpcStance> RegularStance { get; set;}

		[Ordinal(0)] [RED("currentFightStage")] 		public CEnum<ENPCFightStage> CurrentFightStage { get; set;}

		[Ordinal(0)] [RED("currentState")] 		public CName CurrentState { get; set;}

		[Ordinal(0)] [RED("behaviorGraphEventListened", 2,0)] 		public CArray<CName> BehaviorGraphEventListened { get; set;}

		[Ordinal(0)] [RED("isTemporaryOffGround")] 		public CBool IsTemporaryOffGround { get; set;}

		[Ordinal(0)] [RED("npc_health_bar")] 		public CFloat Npc_health_bar { get; set;}

		[Ordinal(0)] [RED("isUnderwater")] 		public CBool IsUnderwater { get; set;}

		[Ordinal(0)] [RED("isTranslationScaled")] 		public CBool IsTranslationScaled { get; set;}

		[Ordinal(0)] [RED("tauntedToAttackTimeStamp")] 		public CFloat TauntedToAttackTimeStamp { get; set;}

		[Ordinal(0)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(0)] [RED("itemToEquip")] 		public SItemUniqueId ItemToEquip { get; set;}

		[Ordinal(0)] [RED("wasBleedingBurningPoisoned")] 		public CBool WasBleedingBurningPoisoned { get; set;}

		[Ordinal(0)] [RED("wasInTalkInteraction")] 		public CBool WasInTalkInteraction { get; set;}

		[Ordinal(0)] [RED("wasInCutscene")] 		public CBool WasInCutscene { get; set;}

		[Ordinal(0)] [RED("shieldDebris")] 		public CHandle<CItemEntity> ShieldDebris { get; set;}

		[Ordinal(0)] [RED("lastMealTime")] 		public CFloat LastMealTime { get; set;}

		[Ordinal(0)] [RED("packName")] 		public CName PackName { get; set;}

		[Ordinal(0)] [RED("isPackLeader")] 		public CBool IsPackLeader { get; set;}

		[Ordinal(0)] [RED("mac")] 		public CHandle<CMovingPhysicalAgentComponent> Mac { get; set;}

		[Ordinal(0)] [RED("parentEncounter")] 		public CHandle<CEncounter> ParentEncounter { get; set;}

		[Ordinal(0)] [RED("npcLevelToUpscaledLevelDifference")] 		public CInt32 NpcLevelToUpscaledLevelDifference { get; set;}

		[Ordinal(0)] [RED("isTalkDisabled")] 		public CBool IsTalkDisabled { get; set;}

		[Ordinal(0)] [RED("isTalkDisabledTemporary")] 		public CBool IsTalkDisabledTemporary { get; set;}

		[Ordinal(0)] [RED("wasNGPlusLevelAdded")] 		public CBool WasNGPlusLevelAdded { get; set;}

		[Ordinal(0)] [RED("deathTimestamp")] 		public CFloat DeathTimestamp { get; set;}

		[Ordinal(0)] [RED("combatStorage")] 		public CHandle<CBaseAICombatStorage> CombatStorage { get; set;}

		[Ordinal(0)] [RED("fistFightForcedFromQuest")] 		public CBool FistFightForcedFromQuest { get; set;}

		[Ordinal(0)] [RED("SHIELD_BURN_TIMER")] 		public CFloat SHIELD_BURN_TIMER { get; set;}

		[Ordinal(0)] [RED("beingHitByIgni")] 		public CBool BeingHitByIgni { get; set;}

		[Ordinal(0)] [RED("firstIgniTick")] 		public CFloat FirstIgniTick { get; set;}

		[Ordinal(0)] [RED("lastIgniTick")] 		public CFloat LastIgniTick { get; set;}

		[Ordinal(0)] [RED("isRagdollOn")] 		public CBool IsRagdollOn { get; set;}

		[Ordinal(0)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		public CNewNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNewNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}