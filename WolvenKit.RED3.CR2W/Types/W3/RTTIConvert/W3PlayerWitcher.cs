using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcher : CR4Player
	{
		[Ordinal(1)] [RED("craftingSchematics", 2,0)] 		public CArray<CName> CraftingSchematics { get; set;}

		[Ordinal(2)] [RED("expandedCraftingCategories", 2,0)] 		public CArray<CName> ExpandedCraftingCategories { get; set;}

		[Ordinal(3)] [RED("craftingFilters")] 		public SCraftingFilters CraftingFilters { get; set;}

		[Ordinal(4)] [RED("alchemyRecipes", 2,0)] 		public CArray<CName> AlchemyRecipes { get; set;}

		[Ordinal(5)] [RED("expandedAlchemyCategories", 2,0)] 		public CArray<CName> ExpandedAlchemyCategories { get; set;}

		[Ordinal(6)] [RED("alchemyFilters")] 		public SCraftingFilters AlchemyFilters { get; set;}

		[Ordinal(7)] [RED("expandedBestiaryCategories", 2,0)] 		public CArray<CName> ExpandedBestiaryCategories { get; set;}

		[Ordinal(8)] [RED("mAutoLootConfig")] 		public CHandle<CAHDAutoLootConfig> MAutoLootConfig { get; set;}

		[Ordinal(9)] [RED("mAutoLootNotificationManager")] 		public CHandle<CAHDAutoLootNotificationManager> MAutoLootNotificationManager { get; set;}

		[Ordinal(10)] [RED("booksRead", 2,0)] 		public CArray<CName> BooksRead { get; set;}

		[Ordinal(11)] [RED("fastAttackCounter")] 		public CInt32 FastAttackCounter { get; set;}

		[Ordinal(12)] [RED("heavyAttackCounter")] 		public CInt32 HeavyAttackCounter { get; set;}

		[Ordinal(13)] [RED("isInFrenzy")] 		public CBool IsInFrenzy { get; set;}

		[Ordinal(14)] [RED("hasRecentlyCountered")] 		public CBool HasRecentlyCountered { get; set;}

		[Ordinal(15)] [RED("cannotUseUndyingSkill")] 		public CBool CannotUseUndyingSkill { get; set;}

		[Ordinal(16)] [RED("amountOfSetPiecesEquipped", 2,0)] 		public CArray<CInt32> AmountOfSetPiecesEquipped { get; set;}

		[Ordinal(17)] [RED("canSwitchFocusModeTarget")] 		public CBool CanSwitchFocusModeTarget { get; set;}

		[Ordinal(18)] [RED("switchFocusModeTargetAllowed")] 		public CBool SwitchFocusModeTargetAllowed { get; set;}

		[Ordinal(19)] [RED("signs", 2,0)] 		public CArray<SWitcherSign> Signs { get; set;}

		[Ordinal(20)] [RED("equippedSign")] 		public CEnum<ESignType> EquippedSign { get; set;}

		[Ordinal(21)] [RED("currentlyCastSign")] 		public CEnum<ESignType> CurrentlyCastSign { get; set;}

		[Ordinal(22)] [RED("signOwner")] 		public CHandle<W3SignOwnerPlayer> SignOwner { get; set;}

		[Ordinal(23)] [RED("usedQuenInCombat")] 		public CBool UsedQuenInCombat { get; set;}

		[Ordinal(24)] [RED("yrdenEntities", 2,0)] 		public CArray<CHandle<W3YrdenEntity>> YrdenEntities { get; set;}

		[Ordinal(25)] [RED("m_quenReappliedCount")] 		public CInt32 M_quenReappliedCount { get; set;}

		[Ordinal(26)] [RED("bDispalyHeavyAttackIndicator")] 		public CBool BDispalyHeavyAttackIndicator { get; set;}

		[Ordinal(27)] [RED("bDisplayHeavyAttackFirstLevelTimer")] 		public CBool BDisplayHeavyAttackFirstLevelTimer { get; set;}

		[Ordinal(28)] [RED("specialAttackHeavyAllowed")] 		public CBool SpecialAttackHeavyAllowed { get; set;}

		[Ordinal(29)] [RED("companionNPCTag")] 		public CName CompanionNPCTag { get; set;}

		[Ordinal(30)] [RED("companionNPCTag2")] 		public CName CompanionNPCTag2 { get; set;}

		[Ordinal(31)] [RED("companionNPCIconPath")] 		public CString CompanionNPCIconPath { get; set;}

		[Ordinal(32)] [RED("companionNPCIconPath2")] 		public CString CompanionNPCIconPath2 { get; set;}

		[Ordinal(33)] [RED("itemSlots", 2,0)] 		public CArray<SItemUniqueId> ItemSlots { get; set;}

		[Ordinal(34)] [RED("remainingBombThrowDelaySlot1")] 		public CFloat RemainingBombThrowDelaySlot1 { get; set;}

		[Ordinal(35)] [RED("remainingBombThrowDelaySlot2")] 		public CFloat RemainingBombThrowDelaySlot2 { get; set;}

		[Ordinal(36)] [RED("previouslyUsedBolt")] 		public SItemUniqueId PreviouslyUsedBolt { get; set;}

		[Ordinal(37)] [RED("questMarkedSelectedQuickslotItems", 2,0)] 		public CArray<SSelectedQuickslotItem> QuestMarkedSelectedQuickslotItems { get; set;}

		[Ordinal(38)] [RED("tempLearnedSignSkills", 2,0)] 		public CArray<SSimpleSkill> TempLearnedSignSkills { get; set;}

		[Ordinal(39)] [RED("autoLevel")] 		public CBool AutoLevel { get; set;}

		[Ordinal(40)] [RED("skillBonusPotionEffect")] 		public CHandle<CBaseGameplayEffect> SkillBonusPotionEffect { get; set;}

		[Ordinal(41)] [RED("levelManager")] 		public CHandle<W3LevelManager> LevelManager { get; set;}

		[Ordinal(42)] [RED("reputationManager")] 		public CHandle<W3Reputation> ReputationManager { get; set;}

		[Ordinal(43)] [RED("medallionEntity")] 		public CHandle<CEntityTemplate> MedallionEntity { get; set;}

		[Ordinal(44)] [RED("medallionController")] 		public CHandle<W3MedallionController> MedallionController { get; set;}

		[Ordinal(45)] [RED("bShowRadialMenu")] 		public CBool BShowRadialMenu { get; set;}

		[Ordinal(46)] [RED("_HoldBeforeOpenRadialMenuTime")] 		public CFloat _HoldBeforeOpenRadialMenuTime { get; set;}

		[Ordinal(47)] [RED("MappinToHighlight", 2,0)] 		public CArray<SHighlightMappin> MappinToHighlight { get; set;}

		[Ordinal(48)] [RED("horseManagerHandle")] 		public EntityHandle HorseManagerHandle { get; set;}

		[Ordinal(49)] [RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[Ordinal(50)] [RED("timeForPerk21")] 		public CFloat TimeForPerk21 { get; set;}

		[Ordinal(51)] [RED("invUpdateTransaction")] 		public CBool InvUpdateTransaction { get; set;}

		[Ordinal(52)] [RED("mutation12IsOnCooldown")] 		public CBool Mutation12IsOnCooldown { get; set;}

		[Ordinal(53)] [RED("mutation11QuenEntity")] 		public CHandle<W3QuenEntity> Mutation11QuenEntity { get; set;}

		[Ordinal(54)] [RED("storedInteractionPriority")] 		public CEnum<EInteractionPriority> StoredInteractionPriority { get; set;}

		[Ordinal(55)] [RED("selectedPotionSlotUpper")] 		public CEnum<EEquipmentSlots> SelectedPotionSlotUpper { get; set;}

		[Ordinal(56)] [RED("selectedPotionSlotLower")] 		public CEnum<EEquipmentSlots> SelectedPotionSlotLower { get; set;}

		[Ordinal(57)] [RED("potionDoubleTapTimerRunning")] 		public CBool PotionDoubleTapTimerRunning { get; set;}

		[Ordinal(58)] [RED("potionDoubleTapSlotIsUpper")] 		public CBool PotionDoubleTapSlotIsUpper { get; set;}

		[Ordinal(59)] [RED("findActorTargetTimeStamp")] 		public CFloat FindActorTargetTimeStamp { get; set;}

		[Ordinal(60)] [RED("pcModeChanneledSignTimeStamp")] 		public CFloat PcModeChanneledSignTimeStamp { get; set;}

		[Ordinal(61)] [RED("runewordInfusionType")] 		public CEnum<ESignType> RunewordInfusionType { get; set;}

		[Ordinal(62)] [RED("savedQuenHealth")] 		public CFloat SavedQuenHealth { get; set;}

		[Ordinal(63)] [RED("savedQuenDuration")] 		public CFloat SavedQuenDuration { get; set;}

		[Ordinal(64)] [RED("clockMenu")] 		public CHandle<CR4MeditationClockMenu> ClockMenu { get; set;}

		[Ordinal(65)] [RED("waitTimeHour")] 		public CInt32 WaitTimeHour { get; set;}

		[Ordinal(66)] [RED("runeword10TriggerredOnFinisher")] 		public CBool Runeword10TriggerredOnFinisher { get; set;}

		[Ordinal(67)] [RED("runeword12TriggerredOnFinisher")] 		public CBool Runeword12TriggerredOnFinisher { get; set;}

		public W3PlayerWitcher(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}