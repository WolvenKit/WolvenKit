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
		[RED("aiEnabled")] 		public CBool AiEnabled { get; set;}

		[RED("suppressBroadcastingReactions")] 		public CBool SuppressBroadcastingReactions { get; set;}

		[RED("berserkTime")] 		public EngineTime BerserkTime { get; set;}

		[RED("npcGroupType")] 		public CEnum<ENPCGroupType> NpcGroupType { get; set;}

		[RED("isImmortal")] 		public CBool IsImmortal { get; set;}

		[RED("isInvulnerable")] 		public CBool IsInvulnerable { get; set;}

		[RED("willBeUnconscious")] 		public CBool WillBeUnconscious { get; set;}

		[RED("minUnconsciousTime")] 		public CFloat MinUnconsciousTime { get; set;}

		[RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[RED("RemainsTags", 2,0)] 		public CArray<CName> RemainsTags { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("currentLevel")] 		public CInt32 CurrentLevel { get; set;}

		[RED("levelFakeAddon")] 		public CInt32 LevelFakeAddon { get; set;}

		[RED("newGamePlusFakeLevelAddon")] 		public CBool NewGamePlusFakeLevelAddon { get; set;}

		[RED("xmlLevel")] 		public SAbilityAttributeValue XmlLevel { get; set;}

		[RED("isXmlLevelSet")] 		public CBool IsXmlLevelSet { get; set;}

		[RED("isMiniBossLevel")] 		public CBool IsMiniBossLevel { get; set;}

		[RED("dontUseReactionOneLiners")] 		public CBool DontUseReactionOneLiners { get; set;}

		[RED("disableConstrainLookat")] 		public CBool DisableConstrainLookat { get; set;}

		[RED("isMonsterType_Group")] 		public CBool IsMonsterType_Group { get; set;}

		[RED("useSoundValue")] 		public CBool UseSoundValue { get; set;}

		[RED("soundValue")] 		public CInt32 SoundValue { get; set;}

		[RED("clearInvOnDeath")] 		public CBool ClearInvOnDeath { get; set;}

		[RED("noAdaptiveBalance")] 		public CBool NoAdaptiveBalance { get; set;}

		[RED("grantNoExperienceAfterKill")] 		public CBool GrantNoExperienceAfterKill { get; set;}

		[RED("abilityBuffStackedOnEnemyHitName")] 		public CName AbilityBuffStackedOnEnemyHitName { get; set;}

		[RED("levelBonusesComputedAtPlayerLevel")] 		public CInt32 LevelBonusesComputedAtPlayerLevel { get; set;}

		[RED("horseComponent")] 		public CHandle<W3HorseComponent> HorseComponent { get; set;}

		[RED("isHorse")] 		public CBool IsHorse { get; set;}

		[RED("canFlee")] 		public CBool CanFlee { get; set;}

		[RED("isFallingFromHorse")] 		public CBool IsFallingFromHorse { get; set;}

		[RED("immortalityInitialized")] 		public CBool ImmortalityInitialized { get; set;}

		[RED("canBeFollowed")] 		public CBool CanBeFollowed { get; set;}

		[RED("bAgony")] 		public CBool BAgony { get; set;}

		[RED("bFinisher")] 		public CBool BFinisher { get; set;}

		[RED("bPlayDeathAnim")] 		public CBool BPlayDeathAnim { get; set;}

		[RED("bAgonyDisabled")] 		public CBool BAgonyDisabled { get; set;}

		[RED("bFinisherInterrupted")] 		public CBool BFinisherInterrupted { get; set;}

		[RED("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[RED("threatLevel")] 		public CInt32 ThreatLevel { get; set;}

		[RED("counterWindowStartTime")] 		public EngineTime CounterWindowStartTime { get; set;}

		[RED("bIsCountering")] 		public CBool BIsCountering { get; set;}

		[RED("allowBehGraphChange")] 		public CBool AllowBehGraphChange { get; set;}

		[RED("aardedFlight")] 		public CBool AardedFlight { get; set;}

		[RED("lastMeleeHitTime")] 		public EngineTime LastMeleeHitTime { get; set;}

		[RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[RED("previousStance")] 		public CEnum<ENpcStance> PreviousStance { get; set;}

		[RED("regularStance")] 		public CEnum<ENpcStance> RegularStance { get; set;}

		[RED("currentFightStage")] 		public CEnum<ENPCFightStage> CurrentFightStage { get; set;}

		[RED("currentState")] 		public CName CurrentState { get; set;}

		[RED("behaviorGraphEventListened", 2,0)] 		public CArray<CName> BehaviorGraphEventListened { get; set;}

		[RED("isTemporaryOffGround")] 		public CBool IsTemporaryOffGround { get; set;}

		[RED("npc_health_bar")] 		public CFloat Npc_health_bar { get; set;}

		[RED("isUnderwater")] 		public CBool IsUnderwater { get; set;}

		[RED("isTranslationScaled")] 		public CBool IsTranslationScaled { get; set;}

		[RED("tauntedToAttackTimeStamp")] 		public CFloat TauntedToAttackTimeStamp { get; set;}

		[RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[RED("itemToEquip")] 		public SItemUniqueId ItemToEquip { get; set;}

		[RED("wasBleedingBurningPoisoned")] 		public CBool WasBleedingBurningPoisoned { get; set;}

		[RED("wasInTalkInteraction")] 		public CBool WasInTalkInteraction { get; set;}

		[RED("wasInCutscene")] 		public CBool WasInCutscene { get; set;}

		[RED("shieldDebris")] 		public CHandle<CItemEntity> ShieldDebris { get; set;}

		[RED("lastMealTime")] 		public CFloat LastMealTime { get; set;}

		[RED("packName")] 		public CName PackName { get; set;}

		[RED("isPackLeader")] 		public CBool IsPackLeader { get; set;}

		[RED("mac")] 		public CHandle<CMovingPhysicalAgentComponent> Mac { get; set;}

		[RED("parentEncounter")] 		public CHandle<CEncounter> ParentEncounter { get; set;}

		[RED("npcLevelToUpscaledLevelDifference")] 		public CInt32 NpcLevelToUpscaledLevelDifference { get; set;}

		[RED("isTalkDisabled")] 		public CBool IsTalkDisabled { get; set;}

		[RED("isTalkDisabledTemporary")] 		public CBool IsTalkDisabledTemporary { get; set;}

		[RED("wasNGPlusLevelAdded")] 		public CBool WasNGPlusLevelAdded { get; set;}

		[RED("deathTimestamp")] 		public CFloat DeathTimestamp { get; set;}

		[RED("combatStorage")] 		public CHandle<CBaseAICombatStorage> CombatStorage { get; set;}

		[RED("fistFightForcedFromQuest")] 		public CBool FistFightForcedFromQuest { get; set;}

		[RED("SHIELD_BURN_TIMER")] 		public CFloat SHIELD_BURN_TIMER { get; set;}

		[RED("beingHitByIgni")] 		public CBool BeingHitByIgni { get; set;}

		[RED("firstIgniTick")] 		public CFloat FirstIgniTick { get; set;}

		[RED("lastIgniTick")] 		public CFloat LastIgniTick { get; set;}

		[RED("isRagdollOn")] 		public CBool IsRagdollOn { get; set;}

		[RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		public CNewNPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CNewNPC(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}