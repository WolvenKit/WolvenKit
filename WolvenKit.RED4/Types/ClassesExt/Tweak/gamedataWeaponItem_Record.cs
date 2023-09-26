
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
		
		[RED("gameplayDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper GameplayDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
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
		
		[RED("IsIKEnabled")]
		[REDProperty(IsIgnored = true)]
		public CBool IsIKEnabled
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
		
		[RED("NPCAnimWrapperWeightOverride")]
		[REDProperty(IsIgnored = true)]
		public CName NPCAnimWrapperWeightOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
		
		[RED("rangedAttacks")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RangedAttacks
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("UseShootVFXOnlyOnFirstShot")]
		[REDProperty(IsIgnored = true)]
		public CBool UseShootVFXOnlyOnFirstShot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
