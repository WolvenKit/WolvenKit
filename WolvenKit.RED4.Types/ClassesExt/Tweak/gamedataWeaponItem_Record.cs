
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponItem_Record
	{
		[RED("ammo")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ammo
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attacks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Attacks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("audioWeaponConfiguration")]
		[REDProperty(IsIgnored = true)]
		public CName AudioWeaponConfiguration
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("baseEmptyReloadTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BaseEmptyReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("baseReloadTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BaseReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("damageType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("divideAttacksByPelletsOnUI")]
		[REDProperty(IsIgnored = true)]
		public CBool DivideAttacksByPelletsOnUI
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("effectiveRangeCurve")]
		[REDProperty(IsIgnored = true)]
		public CName EffectiveRangeCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectiveRangeFalloffCurve")]
		[REDProperty(IsIgnored = true)]
		public CName EffectiveRangeFalloffCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("evolution")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Evolution
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("forcedMinHitReaction")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ForcedMinHitReaction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("fxPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("fxPackageQuickMelee")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxPackageQuickMelee
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hide_nametag")]
		[REDProperty(IsIgnored = true)]
		public CBool Hide_nametag
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("holsteredItem")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID HolsteredItem
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hudIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID HudIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("ikOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 IkOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("ironsightAngleWithScope")]
		[REDProperty(IsIgnored = true)]
		public CFloat IronsightAngleWithScope
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("IsIKEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsIKEnabled2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("manufacturer")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Manufacturer
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("minimumReloadTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinimumReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("NPCAnimWrapperWeightOverride")]
		[REDProperty(IsIgnored = true)]
		public CName NPCAnimWrapperWeightOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("offset")]
		[REDProperty(IsIgnored = true)]
		public CFloat Offset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("position")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("previewEffectName")]
		[REDProperty(IsIgnored = true)]
		public CName PreviewEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("previewEffectTag")]
		[REDProperty(IsIgnored = true)]
		public CName PreviewEffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("primaryTriggerMode")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrimaryTriggerMode
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("projectileEaseOutCurveName")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileEaseOutCurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("projectileSmartTargetingAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat ProjectileSmartTargetingAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("projectileSmartTargetingDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ProjectileSmartTargetingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rangedAttacks")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RangedAttacks
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("safeActionDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat SafeActionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("saveStatPools")]
		[REDProperty(IsIgnored = true)]
		public CBool SaveStatPools
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("scaleToPlayer")]
		[REDProperty(IsIgnored = true)]
		public CBool ScaleToPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("secondaryTriggerMode")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SecondaryTriggerMode
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("shootingPatternPackages")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ShootingPatternPackages
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("specific_player_appearance")]
		[REDProperty(IsIgnored = true)]
		public CName Specific_player_appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("triggerEffectName")]
		[REDProperty(IsIgnored = true)]
		public CName TriggerEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("triggerModes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TriggerModes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("uninterruptibleEmptyReloadStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat UninterruptibleEmptyReloadStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("uninterruptibleReloadStart")]
		[REDProperty(IsIgnored = true)]
		public CFloat UninterruptibleReloadStart
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useForcedTBHZOffset")]
		[REDProperty(IsIgnored = true)]
		public CBool UseForcedTBHZOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("weaponBlurIntensity")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponBlurIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponBlurIntensity_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponBlurIntensity_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponEdgesSharpness")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponEdgesSharpness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponEdgesSharpness_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponEdgesSharpness_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponFarPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponFarPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponFarPlane_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponFarPlane_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponNearPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponNearPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponNearPlane_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponNearPlane_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteCircular")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteCircular
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteCircular_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteCircular_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteIntensity")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteIntensity_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteIntensity_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("weaponVignetteRadius_aim")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponVignetteRadius_aim
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
