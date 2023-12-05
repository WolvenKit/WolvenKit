
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItem_Record
	{
		[RED("animationParameters")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AnimationParameters
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("animFeatureName")]
		[REDProperty(IsIgnored = true)]
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("animName")]
		[REDProperty(IsIgnored = true)]
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("animSetResource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AnimSetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("appearanceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("appearanceResourceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceResourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("appearanceSuffixes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AppearanceSuffixes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("appearanceSuffixesOwnerOverride")]
		[REDProperty(IsIgnored = true)]
		public CArray<CBool> AppearanceSuffixesOwnerOverride
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}
		
		[RED("attachmentSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AttachmentSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("audioName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("audioSwitchName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioSwitchName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("audioSwitchValue")]
		[REDProperty(IsIgnored = true)]
		public CName AudioSwitchValue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("blueprint")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Blueprint
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("buyPrice")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> BuyPrice
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("cameraForward")]
		[REDProperty(IsIgnored = true)]
		public Vector3 CameraForward
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("cameraUp")]
		[REDProperty(IsIgnored = true)]
		public Vector3 CameraUp
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("canDrop")]
		[REDProperty(IsIgnored = true)]
		public CBool CanDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("connections")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Connections
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("counterpart")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Counterpart
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cpoItemCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CpoItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("CraftingData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CraftingData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("crosshair")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Crosshair
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("deprecated")]
		[REDProperty(IsIgnored = true)]
		public CBool Deprecated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("dropObject")]
		[REDProperty(IsIgnored = true)]
		public CName DropObject
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("dropSettings")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DropSettings
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enableNpcRPGData")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableNpcRPGData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("entityName")]
		[REDProperty(IsIgnored = true)]
		public CName EntityName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("equipArea")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EquipArea
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("equipAreas")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipAreas
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("equipPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("equipSoundMetadata")]
		[REDProperty(IsIgnored = true)]
		public CName EquipSoundMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("equivalent")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Equivalent
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("friendlyName")]
		[REDProperty(IsIgnored = true)]
		public CString FriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("gameplayRestrictions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> GameplayRestrictions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("garmentOffset")]
		[REDProperty(IsIgnored = true)]
		public CInt32 GarmentOffset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hairSkinnedMeshComponents")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HairSkinnedMeshComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("icon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CString IconPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("isCached")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isCoreCW")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCoreCW
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isCustomizable")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCustomizable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isGarment")]
		[REDProperty(IsIgnored = true)]
		public CBool IsGarment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isPart")]
		[REDProperty(IsIgnored = true)]
		public CBool IsPart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isSingleInstance")]
		[REDProperty(IsIgnored = true)]
		public CBool IsSingleInstance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("itemCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemSecondaryAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemSecondaryAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemStructure")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemStructure
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Mass
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
		
		[RED("movementPattern")]
		[REDProperty(IsIgnored = true)]
		public CName MovementPattern
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("movementSound")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID MovementSound
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("nextUpgradeItem")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NextUpgradeItem
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("npcRPGData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NpcRPGData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("OnAttach")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnAttach
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("OnEquip")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnEquip
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("onEquipStats")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID OnEquipStats
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("OnLooted")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnLooted
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("parentAttachmentType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ParentAttachmentType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("parts")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Parts
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("placementSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PlacementSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("powerLevelDeterminedByParent")]
		[REDProperty(IsIgnored = true)]
		public CBool PowerLevelDeterminedByParent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("previewBBoxOverride")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector3> PreviewBBoxOverride
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}
		
		[RED("quality")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Quality
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("qualityRestrictedByParent")]
		[REDProperty(IsIgnored = true)]
		public CBool QualityRestrictedByParent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("replicateWhenNotActive")]
		[REDProperty(IsIgnored = true)]
		public CBool ReplicateWhenNotActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("requiredSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RequiredSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("sellPrice")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SellPrice
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("sideUpgradeItem")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SideUpgradeItem
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("slotPartList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SlotPartList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("slotPartListPreset")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SlotPartListPreset
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("stateMachineName")]
		[REDProperty(IsIgnored = true)]
		public CName StateMachineName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("upgradeCostMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat UpgradeCostMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useHeadgearGarmentAggregator")]
		[REDProperty(IsIgnored = true)]
		public CBool UseHeadgearGarmentAggregator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("useNewSpawnMethod")]
		[REDProperty(IsIgnored = true)]
		public CBool UseNewSpawnMethod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("usesVariants")]
		[REDProperty(IsIgnored = true)]
		public CBool UsesVariants
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("variants")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Variants
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("visualTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
