
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicle_Record
	{
		[RED("affiliation")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Affiliation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("appearancesToColorTemplate")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AppearancesToColorTemplate
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
		
		[RED("audioResourceName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioResourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("bikeDriveModelData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BikeDriveModelData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("blockadeLeftPassengerOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlockadeLeftPassengerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blockadeRightPassengerOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlockadeRightPassengerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("brakelightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> BrakelightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("cameraManagerParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CameraManagerParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[RED("canBeActiveVehicle")]
		[REDProperty(IsIgnored = true)]
		public CBool CanBeActiveVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("canDeleteUniqueTemplates")]
		[REDProperty(IsIgnored = true)]
		public CBool CanDeleteUniqueTemplates
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("canOnlySpawnOnValidRoad")]
		[REDProperty(IsIgnored = true)]
		public CBool CanOnlySpawnOnValidRoad
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("colorProfilesRestricted")]
		[REDProperty(IsIgnored = true)]
		public CBool ColorProfilesRestricted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("crowdMemberSettings")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CrowdMemberSettings
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("curvesPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> CurvesPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("customizableAppearance")]
		[REDProperty(IsIgnored = true)]
		public CName CustomizableAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("customizationMenuType")]
		[REDProperty(IsIgnored = true)]
		public CName CustomizationMenuType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("customizationPreview")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CustomizationPreview
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("customizationPreviewGlow")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CustomizationPreviewGlow
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("customizeCarRims")]
		[REDProperty(IsIgnored = true)]
		public CBool CustomizeCarRims
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("customizeLights")]
		[REDProperty(IsIgnored = true)]
		public CBool CustomizeLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("debugStatusString")]
		[REDProperty(IsIgnored = true)]
		public CString DebugStatusString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("destroyedAppearance")]
		[REDProperty(IsIgnored = true)]
		public CName DestroyedAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("destruction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Destruction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("displayOverride")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DisplayOverride
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("driving")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Driving
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("drivingParamsGeneric")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DrivingParamsGeneric
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("drivingParamsPanic")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DrivingParamsPanic
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("drivingParamsRace")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DrivingParamsRace
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enableDestruction")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableDestruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("excludedComponentsCustomization")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ExcludedComponentsCustomization
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("excludedComponentsGeneric")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> ExcludedComponentsGeneric
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("fxCollision")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxCollision
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxWheelsDecals")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxWheelsDecals
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxWheelsDecalsFrontOverride")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxWheelsDecalsFrontOverride
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxWheelsParticles")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxWheelsParticles
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("genericCustomizationMask")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> GenericCustomizationMask
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("hasSideWindows")]
		[REDProperty(IsIgnored = true)]
		public CBool HasSideWindows
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("hasUniqueCustomization")]
		[REDProperty(IsIgnored = true)]
		public CBool HasUniqueCustomization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("hasVisualCustomization")]
		[REDProperty(IsIgnored = true)]
		public CBool HasVisualCustomization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("headlightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> HeadlightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("hitCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat HitCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("icon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Icon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("interiorColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> InteriorColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("interiorDamageColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> InteriorDamageColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("isArmoredVehicle")]
		[REDProperty(IsIgnored = true)]
		public CBool IsArmoredVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isHackable")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID IsHackable
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("leftBackCamber")]
		[REDProperty(IsIgnored = true)]
		public CFloat LeftBackCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("leftBackCamberOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 LeftBackCamberOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("leftBlinkerlightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> LeftBlinkerlightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("leftFrontCamber")]
		[REDProperty(IsIgnored = true)]
		public CFloat LeftFrontCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("leftFrontCamberOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 LeftFrontCamberOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("manufacturer")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Manufacturer
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxVehiclePassengersCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxVehiclePassengersCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minVehiclePassengersCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinVehiclePassengersCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("model")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Model
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("player_audio_resource")]
		[REDProperty(IsIgnored = true)]
		public CString Player_audio_resource
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("preventionPassengers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PreventionPassengers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("queryOnlyExceptions")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> QueryOnlyExceptions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("randomPassengers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RandomPassengers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("reverselightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> ReverselightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("rightBackCamber")]
		[REDProperty(IsIgnored = true)]
		public CFloat RightBackCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rightBackCamberOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 RightBackCamberOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("rightBLinkerlightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> RightBLinkerlightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("rightFrontCamber")]
		[REDProperty(IsIgnored = true)]
		public CFloat RightFrontCamber
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rightFrontCamberOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 RightFrontCamberOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("tankDriveModelData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TankDriveModelData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tppCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TppCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tppCameraPresets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TppCameraPresets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("traffic_audio_resource")]
		[REDProperty(IsIgnored = true)]
		public CString Traffic_audio_resource
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("trafficSuspension")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TrafficSuspension
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("twintoneModelName")]
		[REDProperty(IsIgnored = true)]
		public CName TwintoneModelName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("unmountOffsetPosition")]
		[REDProperty(IsIgnored = true)]
		public Vector3 UnmountOffsetPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("usesSecondaryHoodEmitter")]
		[REDProperty(IsIgnored = true)]
		public CBool UsesSecondaryHoodEmitter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("utilityLightColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> UtilityLightColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("vehAirControl")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehAirControl
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehAirControlAI")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehAirControlAI
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehBehaviorData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehBehaviorData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDataPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDataPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDefaultState")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDefaultState
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriveModelData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriveModelData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriveModelDataAI")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriveModelDataAI
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriver_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriver_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriver_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriver_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriverCombat_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriverCombat_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehDriverCombat_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehDriverCombat_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehEngineData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehEngineData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehicleUIData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehicleUIData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehImpactTraffic")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehImpactTraffic
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassCombatL_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassCombatL_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassCombatL_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassCombatL_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassCombatR_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassCombatR_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassCombatR_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassCombatR_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassL_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassL_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassL_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassL_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassR_FPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassR_FPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehPassR_ProceduralFPPCameraParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehPassR_ProceduralFPPCameraParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vehWheelDimensionsSetup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VehWheelDimensionsSetup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("visualCustomizationTeaser")]
		[REDProperty(IsIgnored = true)]
		public CBool VisualCustomizationTeaser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("visualCustomizationUpdateRequired")]
		[REDProperty(IsIgnored = true)]
		public CBool VisualCustomizationUpdateRequired
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[RED("visualDestruction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VisualDestruction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weapons")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Weapons
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("weaponSafeModeBounds")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WeaponSafeModeBounds
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("widgetStyleSheetPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> WidgetStyleSheetPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
