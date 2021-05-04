using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CNewNPC : CActor
	{
		[Ordinal(1)] [RED("aiEnabled")] 		public CBool AiEnabled { get; set;}

		[Ordinal(2)] [RED("suppressBroadcastingReactions")] 		public CBool SuppressBroadcastingReactions { get; set;}

		[Ordinal(3)] [RED("berserkTime")] 		public EngineTime BerserkTime { get; set;}

		[Ordinal(4)] [RED("npcGroupType")] 		public CEnum<ENPCGroupType> NpcGroupType { get; set;}

		[Ordinal(5)] [RED("isImmortal")] 		public CBool IsImmortal { get; set;}

		[Ordinal(6)] [RED("isInvulnerable")] 		public CBool IsInvulnerable { get; set;}

		[Ordinal(7)] [RED("willBeUnconscious")] 		public CBool WillBeUnconscious { get; set;}

		[Ordinal(8)] [RED("minUnconsciousTime")] 		public CFloat MinUnconsciousTime { get; set;}

		[Ordinal(9)] [RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[Ordinal(10)] [RED("RemainsTags", 2,0)] 		public CArray<CName> RemainsTags { get; set;}

		[Ordinal(11)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(12)] [RED("currentLevel")] 		public CInt32 CurrentLevel { get; set;}

		[Ordinal(13)] [RED("levelFakeAddon")] 		public CInt32 LevelFakeAddon { get; set;}

		[Ordinal(14)] [RED("newGamePlusFakeLevelAddon")] 		public CBool NewGamePlusFakeLevelAddon { get; set;}

		[Ordinal(15)] [RED("xmlLevel")] 		public SAbilityAttributeValue XmlLevel { get; set;}

		[Ordinal(16)] [RED("isXmlLevelSet")] 		public CBool IsXmlLevelSet { get; set;}

		[Ordinal(17)] [RED("isMiniBossLevel")] 		public CBool IsMiniBossLevel { get; set;}

		[Ordinal(18)] [RED("dontUseReactionOneLiners")] 		public CBool DontUseReactionOneLiners { get; set;}

		[Ordinal(19)] [RED("disableConstrainLookat")] 		public CBool DisableConstrainLookat { get; set;}

		[Ordinal(20)] [RED("isMonsterType_Group")] 		public CBool IsMonsterType_Group { get; set;}

		[Ordinal(21)] [RED("useSoundValue")] 		public CBool UseSoundValue { get; set;}

		[Ordinal(22)] [RED("soundValue")] 		public CInt32 SoundValue { get; set;}

		[Ordinal(23)] [RED("clearInvOnDeath")] 		public CBool ClearInvOnDeath { get; set;}

		[Ordinal(24)] [RED("noAdaptiveBalance")] 		public CBool NoAdaptiveBalance { get; set;}

		[Ordinal(25)] [RED("grantNoExperienceAfterKill")] 		public CBool GrantNoExperienceAfterKill { get; set;}

		[Ordinal(26)] [RED("abilityBuffStackedOnEnemyHitName")] 		public CName AbilityBuffStackedOnEnemyHitName { get; set;}

		[Ordinal(27)] [RED("levelBonusesComputedAtPlayerLevel")] 		public CInt32 LevelBonusesComputedAtPlayerLevel { get; set;}

		[Ordinal(28)] [RED("horseComponent")] 		public CHandle<W3HorseComponent> HorseComponent { get; set;}

		[Ordinal(29)] [RED("isHorse")] 		public CBool IsHorse { get; set;}

		[Ordinal(30)] [RED("canFlee")] 		public CBool CanFlee { get; set;}

		[Ordinal(31)] [RED("isFallingFromHorse")] 		public CBool IsFallingFromHorse { get; set;}

		[Ordinal(32)] [RED("immortalityInitialized")] 		public CBool ImmortalityInitialized { get; set;}

		[Ordinal(33)] [RED("canBeFollowed")] 		public CBool CanBeFollowed { get; set;}

		[Ordinal(34)] [RED("bAgony")] 		public CBool BAgony { get; set;}

		[Ordinal(35)] [RED("bFinisher")] 		public CBool BFinisher { get; set;}

		[Ordinal(36)] [RED("bPlayDeathAnim")] 		public CBool BPlayDeathAnim { get; set;}

		[Ordinal(37)] [RED("bAgonyDisabled")] 		public CBool BAgonyDisabled { get; set;}

		[Ordinal(38)] [RED("bFinisherInterrupted")] 		public CBool BFinisherInterrupted { get; set;}

		[Ordinal(39)] [RED("bIsInHitAnim")] 		public CBool BIsInHitAnim { get; set;}

		[Ordinal(40)] [RED("threatLevel")] 		public CInt32 ThreatLevel { get; set;}

		[Ordinal(41)] [RED("counterWindowStartTime")] 		public EngineTime CounterWindowStartTime { get; set;}

		[Ordinal(42)] [RED("bIsCountering")] 		public CBool BIsCountering { get; set;}

		[Ordinal(43)] [RED("allowBehGraphChange")] 		public CBool AllowBehGraphChange { get; set;}

		[Ordinal(44)] [RED("aardedFlight")] 		public CBool AardedFlight { get; set;}

		[Ordinal(45)] [RED("lastMeleeHitTime")] 		public EngineTime LastMeleeHitTime { get; set;}

		[Ordinal(46)] [RED("preferedCombatStyle")] 		public CEnum<EBehaviorGraph> PreferedCombatStyle { get; set;}

		[Ordinal(47)] [RED("previousStance")] 		public CEnum<ENpcStance> PreviousStance { get; set;}

		[Ordinal(48)] [RED("regularStance")] 		public CEnum<ENpcStance> RegularStance { get; set;}

		[Ordinal(49)] [RED("currentFightStage")] 		public CEnum<ENPCFightStage> CurrentFightStage { get; set;}

		[Ordinal(50)] [RED("currentState")] 		public CName CurrentState { get; set;}

		[Ordinal(51)] [RED("behaviorGraphEventListened", 2,0)] 		public CArray<CName> BehaviorGraphEventListened { get; set;}

		[Ordinal(52)] [RED("isTemporaryOffGround")] 		public CBool IsTemporaryOffGround { get; set;}

		[Ordinal(53)] [RED("npc_health_bar")] 		public CFloat Npc_health_bar { get; set;}

		[Ordinal(54)] [RED("isUnderwater")] 		public CBool IsUnderwater { get; set;}

		[Ordinal(55)] [RED("isTranslationScaled")] 		public CBool IsTranslationScaled { get; set;}

		[Ordinal(56)] [RED("tauntedToAttackTimeStamp")] 		public CFloat TauntedToAttackTimeStamp { get; set;}

		[Ordinal(57)] [RED("isTeleporting")] 		public CBool IsTeleporting { get; set;}

		[Ordinal(58)] [RED("itemToEquip")] 		public SItemUniqueId ItemToEquip { get; set;}

		[Ordinal(59)] [RED("wasBleedingBurningPoisoned")] 		public CBool WasBleedingBurningPoisoned { get; set;}

		[Ordinal(60)] [RED("wasInTalkInteraction")] 		public CBool WasInTalkInteraction { get; set;}

		[Ordinal(61)] [RED("wasInCutscene")] 		public CBool WasInCutscene { get; set;}

		[Ordinal(62)] [RED("shieldDebris")] 		public CHandle<CItemEntity> ShieldDebris { get; set;}

		[Ordinal(63)] [RED("lastMealTime")] 		public CFloat LastMealTime { get; set;}

		[Ordinal(64)] [RED("packName")] 		public CName PackName { get; set;}

		[Ordinal(65)] [RED("isPackLeader")] 		public CBool IsPackLeader { get; set;}

		[Ordinal(66)] [RED("mac")] 		public CHandle<CMovingPhysicalAgentComponent> Mac { get; set;}

		[Ordinal(67)] [RED("parentEncounter")] 		public CHandle<CEncounter> ParentEncounter { get; set;}

		[Ordinal(68)] [RED("npcLevelToUpscaledLevelDifference")] 		public CInt32 NpcLevelToUpscaledLevelDifference { get; set;}

		[Ordinal(69)] [RED("isTalkDisabled")] 		public CBool IsTalkDisabled { get; set;}

		[Ordinal(70)] [RED("isTalkDisabledTemporary")] 		public CBool IsTalkDisabledTemporary { get; set;}

		[Ordinal(71)] [RED("wasNGPlusLevelAdded")] 		public CBool WasNGPlusLevelAdded { get; set;}

		[Ordinal(72)] [RED("deathTimestamp")] 		public CFloat DeathTimestamp { get; set;}

		[Ordinal(73)] [RED("combatStorage")] 		public CHandle<CBaseAICombatStorage> CombatStorage { get; set;}

		[Ordinal(74)] [RED("fistFightForcedFromQuest")] 		public CBool FistFightForcedFromQuest { get; set;}

		[Ordinal(75)] [RED("SHIELD_BURN_TIMER")] 		public CFloat SHIELD_BURN_TIMER { get; set;}

		[Ordinal(76)] [RED("beingHitByIgni")] 		public CBool BeingHitByIgni { get; set;}

		[Ordinal(77)] [RED("firstIgniTick")] 		public CFloat FirstIgniTick { get; set;}

		[Ordinal(78)] [RED("lastIgniTick")] 		public CFloat LastIgniTick { get; set;}

		[Ordinal(79)] [RED("isRagdollOn")] 		public CBool IsRagdollOn { get; set;}

		[Ordinal(80)] [RED("m_storedInteractionPri")] 		public CEnum<EInteractionPriority> M_storedInteractionPri { get; set;}

		public CNewNPC(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}