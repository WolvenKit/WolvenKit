
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
		
		[RED("actionParamsPackageName")]
		[REDProperty(IsIgnored = true)]
		public CString ActionParamsPackageName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("affiliation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Affiliation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("airDeathRagdollDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirDeathRagdollDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("alertedSensesPreset")]
		[REDProperty(IsIgnored = true)]
		public CString AlertedSensesPreset
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
		
		[RED("amountOfQuests")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AmountOfQuests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("appearanceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("BodyDisposalFact")]
		[REDProperty(IsIgnored = true)]
		public CName BodyDisposalFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("combatDefaultZOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat CombatDefaultZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("combatSensesPreset")]
		[REDProperty(IsIgnored = true)]
		public CString CombatSensesPreset
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("communitySquad")]
		[REDProperty(IsIgnored = true)]
		public CName CommunitySquad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("communitySquads")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> CommunitySquads
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
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
		
		[RED("dropsAmmoOnDeath")]
		[REDProperty(IsIgnored = true)]
		public CBool DropsAmmoOnDeath
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
		
		[RED("effectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Effectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("enableSensesOnStart")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableSensesOnStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("entityTemplatePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> EntityTemplatePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("EquipmentAreas")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipmentAreas
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("factCounterName")]
		[REDProperty(IsIgnored = true)]
		public CName FactCounterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("globalSquads")]
		[REDProperty(IsIgnored = true)]
		public CName GlobalSquads
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
		
		[RED("hasToBeKilledInWounded")]
		[REDProperty(IsIgnored = true)]
		public CBool HasToBeKilledInWounded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hide_nametag")]
		[REDProperty(IsIgnored = true)]
		public CBool Hide_nametag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hide_nametag_displayname")]
		[REDProperty(IsIgnored = true)]
		public CBool Hide_nametag_displayname
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
		
		[RED("keepColliderOnDeath")]
		[REDProperty(IsIgnored = true)]
		public CBool KeepColliderOnDeath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
		
		[RED("mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("massNormalizedCoefficient")]
		[REDProperty(IsIgnored = true)]
		public CFloat MassNormalizedCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minigameInstance")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MinigameInstance
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("multiplayerTemplatePaths")]
		[REDProperty(IsIgnored = true)]
		public CArray<CResourceAsyncReference<CResource>> MultiplayerTemplatePaths
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}
		
		[RED("nameplate")]
		[REDProperty(IsIgnored = true)]
		public CBool Nameplate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("objectActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("onSpawnGLPs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnSpawnGLPs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("persistentName")]
		[REDProperty(IsIgnored = true)]
		public CName PersistentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("preferedWeapon")]
		[REDProperty(IsIgnored = true)]
		public CName PreferedWeapon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("primaryEquipment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrimaryEquipment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Priority
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("pseudoAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat PseudoAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("relaxedSensesPreset")]
		[REDProperty(IsIgnored = true)]
		public CString RelaxedSensesPreset
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("savable")]
		[REDProperty(IsIgnored = true)]
		public CBool Savable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("saveStatPools")]
		[REDProperty(IsIgnored = true)]
		public CBool SaveStatPools
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
		
		[RED("shieldControllerDestroyed_staggerThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShieldControllerDestroyed_staggerThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeBack")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeBack
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeFront")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeLeft")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sizeRight")]
		[REDProperty(IsIgnored = true)]
		public CFloat SizeRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("skipDisplayArchetype")]
		[REDProperty(IsIgnored = true)]
		public CBool SkipDisplayArchetype
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("speedIdleThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpeedIdleThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("squadParamsID")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SquadParamsID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("startingRecoveryBalance")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartingRecoveryBalance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("statModifierGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifierGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statPools")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPools
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statusEffectParamsPackageName")]
		[REDProperty(IsIgnored = true)]
		public CString StatusEffectParamsPackageName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("temp_doNotNotifySS")]
		[REDProperty(IsIgnored = true)]
		public CBool Temp_doNotNotifySS
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
		
		[RED("thresholds")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> Thresholds
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("tiltAngleOnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TiltAngleOnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tooltipAvatar")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TooltipAvatar
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("turnInertiaDamping")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnInertiaDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("visualTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("voiceTag")]
		[REDProperty(IsIgnored = true)]
		public CName VoiceTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("walkTiltCoefficient")]
		[REDProperty(IsIgnored = true)]
		public CFloat WalkTiltCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weakspots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Weakspots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weaponSlot")]
		[REDProperty(IsIgnored = true)]
		public CName WeaponSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
