using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerWitcher : CR4Player
	{
		[RED("craftingSchematics", 2,0)] 		public CArray<CName> CraftingSchematics { get; set;}

		[RED("expandedCraftingCategories", 2,0)] 		public CArray<CName> ExpandedCraftingCategories { get; set;}

		[RED("craftingFilters")] 		public SCraftingFilters CraftingFilters { get; set;}

		[RED("alchemyRecipes", 2,0)] 		public CArray<CName> AlchemyRecipes { get; set;}

		[RED("expandedAlchemyCategories", 2,0)] 		public CArray<CName> ExpandedAlchemyCategories { get; set;}

		[RED("alchemyFilters")] 		public SCraftingFilters AlchemyFilters { get; set;}

		[RED("expandedBestiaryCategories", 2,0)] 		public CArray<CName> ExpandedBestiaryCategories { get; set;}

		[RED("mAutoLootConfig")] 		public CHandle<CAHDAutoLootConfig> MAutoLootConfig { get; set;}

		[RED("mAutoLootNotificationManager")] 		public CHandle<CAHDAutoLootNotificationManager> MAutoLootNotificationManager { get; set;}

		[RED("booksRead", 2,0)] 		public CArray<CName> BooksRead { get; set;}

		[RED("fastAttackCounter")] 		public CInt32 FastAttackCounter { get; set;}

		[RED("heavyAttackCounter")] 		public CInt32 HeavyAttackCounter { get; set;}

		[RED("isInFrenzy")] 		public CBool IsInFrenzy { get; set;}

		[RED("hasRecentlyCountered")] 		public CBool HasRecentlyCountered { get; set;}

		[RED("cannotUseUndyingSkill")] 		public CBool CannotUseUndyingSkill { get; set;}

		[RED("amountOfSetPiecesEquipped", 2,0)] 		public CArray<CInt32> AmountOfSetPiecesEquipped { get; set;}

		[RED("canSwitchFocusModeTarget")] 		public CBool CanSwitchFocusModeTarget { get; set;}

		[RED("switchFocusModeTargetAllowed")] 		public CBool SwitchFocusModeTargetAllowed { get; set;}

		[RED("signs", 2,0)] 		public CArray<SWitcherSign> Signs { get; set;}

		[RED("equippedSign")] 		public CEnum<ESignType> EquippedSign { get; set;}

		[RED("currentlyCastSign")] 		public CEnum<ESignType> CurrentlyCastSign { get; set;}

		[RED("signOwner")] 		public CHandle<W3SignOwnerPlayer> SignOwner { get; set;}

		[RED("usedQuenInCombat")] 		public CBool UsedQuenInCombat { get; set;}

		[RED("yrdenEntities", 2,0)] 		public CArray<CHandle<W3YrdenEntity>> YrdenEntities { get; set;}

		[RED("m_quenReappliedCount")] 		public CInt32 M_quenReappliedCount { get; set;}

		[RED("bDispalyHeavyAttackIndicator")] 		public CBool BDispalyHeavyAttackIndicator { get; set;}

		[RED("bDisplayHeavyAttackFirstLevelTimer")] 		public CBool BDisplayHeavyAttackFirstLevelTimer { get; set;}

		[RED("specialAttackHeavyAllowed")] 		public CBool SpecialAttackHeavyAllowed { get; set;}

		[RED("companionNPCTag")] 		public CName CompanionNPCTag { get; set;}

		[RED("companionNPCTag2")] 		public CName CompanionNPCTag2 { get; set;}

		[RED("companionNPCIconPath")] 		public CString CompanionNPCIconPath { get; set;}

		[RED("companionNPCIconPath2")] 		public CString CompanionNPCIconPath2 { get; set;}

		[RED("itemSlots", 2,0)] 		public CArray<SItemUniqueId> ItemSlots { get; set;}

		[RED("remainingBombThrowDelaySlot1")] 		public CFloat RemainingBombThrowDelaySlot1 { get; set;}

		[RED("remainingBombThrowDelaySlot2")] 		public CFloat RemainingBombThrowDelaySlot2 { get; set;}

		[RED("previouslyUsedBolt")] 		public SItemUniqueId PreviouslyUsedBolt { get; set;}

		[RED("questMarkedSelectedQuickslotItems", 2,0)] 		public CArray<SSelectedQuickslotItem> QuestMarkedSelectedQuickslotItems { get; set;}

		[RED("tempLearnedSignSkills", 2,0)] 		public CArray<SSimpleSkill> TempLearnedSignSkills { get; set;}

		[RED("autoLevel")] 		public CBool AutoLevel { get; set;}

		[RED("skillBonusPotionEffect")] 		public CHandle<CBaseGameplayEffect> SkillBonusPotionEffect { get; set;}

		[RED("levelManager")] 		public CHandle<W3LevelManager> LevelManager { get; set;}

		[RED("reputationManager")] 		public CHandle<W3Reputation> ReputationManager { get; set;}

		[RED("medallionEntity")] 		public CHandle<CEntityTemplate> MedallionEntity { get; set;}

		[RED("medallionController")] 		public CHandle<W3MedallionController> MedallionController { get; set;}

		[RED("bShowRadialMenu")] 		public CBool BShowRadialMenu { get; set;}

		[RED("_HoldBeforeOpenRadialMenuTime")] 		public CFloat _HoldBeforeOpenRadialMenuTime { get; set;}

		[RED("MappinToHighlight", 2,0)] 		public CArray<SHighlightMappin> MappinToHighlight { get; set;}

		[RED("horseManagerHandle")] 		public EntityHandle HorseManagerHandle { get; set;}

		[RED("isInitialized")] 		public CBool IsInitialized { get; set;}

		[RED("timeForPerk21")] 		public CFloat TimeForPerk21 { get; set;}

		[RED("invUpdateTransaction")] 		public CBool InvUpdateTransaction { get; set;}

		[RED("mutation12IsOnCooldown")] 		public CBool Mutation12IsOnCooldown { get; set;}

		[RED("mutation11QuenEntity")] 		public CHandle<W3QuenEntity> Mutation11QuenEntity { get; set;}

		[RED("storedInteractionPriority")] 		public CEnum<EInteractionPriority> StoredInteractionPriority { get; set;}

		[RED("selectedPotionSlotUpper")] 		public CEnum<EEquipmentSlots> SelectedPotionSlotUpper { get; set;}

		[RED("selectedPotionSlotLower")] 		public CEnum<EEquipmentSlots> SelectedPotionSlotLower { get; set;}

		[RED("potionDoubleTapTimerRunning")] 		public CBool PotionDoubleTapTimerRunning { get; set;}

		[RED("potionDoubleTapSlotIsUpper")] 		public CBool PotionDoubleTapSlotIsUpper { get; set;}

		[RED("findActorTargetTimeStamp")] 		public CFloat FindActorTargetTimeStamp { get; set;}

		[RED("pcModeChanneledSignTimeStamp")] 		public CFloat PcModeChanneledSignTimeStamp { get; set;}

		[RED("runewordInfusionType")] 		public CEnum<ESignType> RunewordInfusionType { get; set;}

		[RED("savedQuenHealth")] 		public CFloat SavedQuenHealth { get; set;}

		[RED("savedQuenDuration")] 		public CFloat SavedQuenDuration { get; set;}

		[RED("clockMenu")] 		public CHandle<CR4MeditationClockMenu> ClockMenu { get; set;}

		[RED("waitTimeHour")] 		public CInt32 WaitTimeHour { get; set;}

		[RED("runeword10TriggerredOnFinisher")] 		public CBool Runeword10TriggerredOnFinisher { get; set;}

		[RED("runeword12TriggerredOnFinisher")] 		public CBool Runeword12TriggerredOnFinisher { get; set;}

		public W3PlayerWitcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerWitcher(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}