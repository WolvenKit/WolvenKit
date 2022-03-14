
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItem_Record
	{
		[RED("angle")]
		[REDProperty(IsIgnored = true)]
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("angleInterpolationDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AngleInterpolationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
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
		
		[RED("applyAdditiveProjectileSpiraling")]
		[REDProperty(IsIgnored = true)]
		public CBool ApplyAdditiveProjectileSpiraling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("attachmentSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AttachmentSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("attack")]
		[REDProperty(IsIgnored = true)]
		public CString Attack
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
		
		[RED("bendFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bendTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat BendTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("canTargetDevices")]
		[REDProperty(IsIgnored = true)]
		public CBool CanTargetDevices
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("canTargetVehicles")]
		[REDProperty(IsIgnored = true)]
		public CBool CanTargetVehicles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("chargeActionChargeCost")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChargeActionChargeCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("chargeActionlaunchMode")]
		[REDProperty(IsIgnored = true)]
		public CName ChargeActionlaunchMode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("collisionAction")]
		[REDProperty(IsIgnored = true)]
		public CName CollisionAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("collisionActionCharged")]
		[REDProperty(IsIgnored = true)]
		public CName CollisionActionCharged
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("connections")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Connections
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
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
		
		[RED("cyberwareType")]
		[REDProperty(IsIgnored = true)]
		public CName CyberwareType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("deepWaterDepth")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeepWaterDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detonationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetonationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("effectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Effectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("enableNpcRPGData")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableNpcRPGData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("endLeanAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat EndLeanAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("energyLossFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat EnergyLossFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("gravitySimulation")]
		[REDProperty(IsIgnored = true)]
		public Vector3 GravitySimulation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("hairSkinnedMeshComponents")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HairSkinnedMeshComponents
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("halfLeanAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat HalfLeanAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hideCooldownUI")]
		[REDProperty(IsIgnored = true)]
		public CBool HideCooldownUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hideDurationUI")]
		[REDProperty(IsIgnored = true)]
		public CBool HideDurationUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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
		
		[RED("interpolationTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat InterpolationTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isCached")]
		[REDProperty(IsIgnored = true)]
		public CBool IsCached
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
		
		[RED("isIKEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsIKEnabled
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
		
		[RED("launchTrajectory")]
		[REDProperty(IsIgnored = true)]
		public CName LaunchTrajectory
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("lifetime")]
		[REDProperty(IsIgnored = true)]
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("linearTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat LinearTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
		
		[RED("maxBounceCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxBounceCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
		
		[RED("npcRPGData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NpcRPGData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("objectActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ObjectActions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("OnAttach")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OnAttach
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("onCollisionStimBroadcastLifetime")]
		[REDProperty(IsIgnored = true)]
		public CFloat OnCollisionStimBroadcastLifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("onCollisionStimBroadcastRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat OnCollisionStimBroadcastRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("onCollisionStimType")]
		[REDProperty(IsIgnored = true)]
		public CName OnCollisionStimType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("price")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Price
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("projectileTemplateName")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileTemplateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("quickActionChargeCost")]
		[REDProperty(IsIgnored = true)]
		public CFloat QuickActionChargeCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("quickActionlaunchMode")]
		[REDProperty(IsIgnored = true)]
		public CName QuickActionlaunchMode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("rampDownDistanceEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat RampDownDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rampDownDistanceStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat RampDownDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rampDownFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat RampDownFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rampUpDistanceEnd")]
		[REDProperty(IsIgnored = true)]
		public CFloat RampUpDistanceEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rampUpDistanceStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat RampUpDistanceStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("randomizeDirection")]
		[REDProperty(IsIgnored = true)]
		public CBool RandomizeDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("randomizePhase")]
		[REDProperty(IsIgnored = true)]
		public CBool RandomizePhase
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
		
		[RED("returnTimeMargin")]
		[REDProperty(IsIgnored = true)]
		public CFloat ReturnTimeMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("savable")]
		[REDProperty(IsIgnored = true)]
		public CBool Savable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("secondaryAttack")]
		[REDProperty(IsIgnored = true)]
		public CString SecondaryAttack
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("sellPrice")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SellPrice
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("shardType")]
		[REDProperty(IsIgnored = true)]
		public CName ShardType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sinkingDetonationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat SinkingDetonationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slotPartList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SlotPartList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("slotPartList2")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> SlotPartList2
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
		
		[RED("startVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startVelocityCharged")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartVelocityCharged
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
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
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
		
		[RED("waterDetonationImpulseRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterDetonationImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waterDetonationImpulseStrength")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterDetonationImpulseStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waterSurfaceImpactImpulseRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterSurfaceImpactImpulseRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("waterSurfaceImpactImpulseStrength")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterSurfaceImpactImpulseStrength
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
	}
}
