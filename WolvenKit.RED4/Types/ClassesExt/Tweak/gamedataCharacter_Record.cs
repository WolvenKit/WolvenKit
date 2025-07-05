
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCharacter_Record
	{
		[RED("abilities")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Abilities
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("actionMap")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActionMap
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("affiliation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Affiliation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("alternativeDisplayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper AlternativeDisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("alternativeFullDisplayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper AlternativeFullDisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("archetypeData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ArchetypeData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("archetypeName")]
		[REDProperty(IsIgnored = true)]
		public CName ArchetypeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("attachmentSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AttachmentSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("audioMeleeMaterial")]
		[REDProperty(IsIgnored = true)]
		public CName AudioMeleeMaterial
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("audioResourceName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioResourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("baseAttitudeGroup")]
		[REDProperty(IsIgnored = true)]
		public CName BaseAttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("bossHealthBarThresholds")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> BossHealthBarThresholds
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("bountyDrawTable")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BountyDrawTable
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("canHaveGenericTalk")]
		[REDProperty(IsIgnored = true)]
		public CBool CanHaveGenericTalk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("characterType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CharacterType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("communitySquad")]
		[REDProperty(IsIgnored = true)]
		public CName CommunitySquad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("contentAssignment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ContentAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cpoCharacterBuild")]
		[REDProperty(IsIgnored = true)]
		public CString CpoCharacterBuild
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("cpoClassName")]
		[REDProperty(IsIgnored = true)]
		public CName CpoClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("crowdAppearanceNames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CrowdAppearanceNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("crowdMemberSettings")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CrowdMemberSettings
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("defaultCrosshair")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultCrosshair
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("defaultEquipment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultEquipment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("despawnChildCommunityWhenPlayerInVehicle")]
		[REDProperty(IsIgnored = true)]
		public CBool DespawnChildCommunityWhenPlayerInVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("devNotes")]
		[REDProperty(IsIgnored = true)]
		public CString DevNotes
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("disableDefeatedState")]
		[REDProperty(IsIgnored = true)]
		public CBool DisableDefeatedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("displayDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("driving")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Driving
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("dropsAmmoOnDeathChance")]
		[REDProperty(IsIgnored = true)]
		public CFloat DropsAmmoOnDeathChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dropsControlledLoot")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsControlledLoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dropsMoneyOnDeath")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsMoneyOnDeath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dropsWeaponOnDeath")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsWeaponOnDeath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("enableSensesOnStart")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableSensesOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("EquipmentAreas")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipmentAreas
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("forceCanHaveGenericTalk")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceCanHaveGenericTalk
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forcedTBHZOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat ForcedTBHZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fullDisplayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper FullDisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("genders")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Genders
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("globalSquad")]
		[REDProperty(IsIgnored = true)]
		public CName GlobalSquad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("hasDirectionalStarts")]
		[REDProperty(IsIgnored = true)]
		public CBool HasDirectionalStarts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hideUIDetection")]
		[REDProperty(IsIgnored = true)]
		public CBool HideUIDetection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hideUIElements")]
		[REDProperty(IsIgnored = true)]
		public CBool HideUIElements
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("holocallInitializerPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> HolocallInitializerPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("idleActions")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID IdleActions
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("ignoreDetectionForAudioCue")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreDetectionForAudioCue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isBumpable")]
		[REDProperty(IsIgnored = true)]
		public CBool IsBumpable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isChild")]
		[REDProperty(IsIgnored = true)]
		public CBool IsChild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isCrowd")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isLightCrowd")]
		[REDProperty(IsIgnored = true)]
		public CBool IsLightCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("itemGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ItemGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("items")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Items
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("lootBagEntity")]
		[REDProperty(IsIgnored = true)]
		public CName LootBagEntity
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("lootDrop")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LootDrop
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("lootInjectionParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LootInjectionParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("minigameInstance")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MinigameInstance
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("onSpawnGLPs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnSpawnGLPs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("primaryEquipment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrimaryEquipment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("quest")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Quest
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rarity")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Rarity
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("reactionPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ReactionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("scannerModulePreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ScannerModulePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("secondaryEquipment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryEquipment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("securitySquad")]
		[REDProperty(IsIgnored = true)]
		public CName SecuritySquad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sensePreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SensePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("skipDisplayArchetype")]
		[REDProperty(IsIgnored = true)]
		public CBool SkipDisplayArchetype
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("squadParamsID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SquadParamsID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stateMachineName")]
		[REDProperty(IsIgnored = true)]
		public CName StateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("staticCommunityAppearancesDistributionEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool StaticCommunityAppearancesDistributionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("threatTrackingPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ThreatTrackingPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("uiNameplate")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UiNameplate
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useForcedTBHZOffset")]
		[REDProperty(IsIgnored = true)]
		public CBool UseForcedTBHZOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vendorID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VendorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("voiceTag")]
		[REDProperty(IsIgnored = true)]
		public CName VoiceTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
