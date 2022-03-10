
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEffector_Record
	{
		[RED("actionID")]
		[REDProperty(IsIgnored = true)]
		public CString ActionID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("activationSFXName")]
		[REDProperty(IsIgnored = true)]
		public CName ActivationSFXName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("amountOfPoints")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AmountOfPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("amplitudeWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat AmplitudeWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("animFeatureName")]
		[REDProperty(IsIgnored = true)]
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("appearanceName")]
		[REDProperty(IsIgnored = true)]
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("applicationTarget")]
		[REDProperty(IsIgnored = true)]
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("applyToOwner")]
		[REDProperty(IsIgnored = true)]
		public CBool ApplyToOwner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("applyToWeapon")]
		[REDProperty(IsIgnored = true)]
		public CBool ApplyToWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("attackRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attributeType")]
		[REDProperty(IsIgnored = true)]
		public CString AttributeType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("blendInDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlendInDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blendOutDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlendOutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("comparePercentage")]
		[REDProperty(IsIgnored = true)]
		public CBool ComparePercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("deactivationSFXName")]
		[REDProperty(IsIgnored = true)]
		public CName DeactivationSFXName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dilation")]
		[REDProperty(IsIgnored = true)]
		public CFloat Dilation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("easeInCurve")]
		[REDProperty(IsIgnored = true)]
		public CName EaseInCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("easeOutCurve")]
		[REDProperty(IsIgnored = true)]
		public CName EaseOutCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectorClassName")]
		[REDProperty(IsIgnored = true)]
		public CName EffectorClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectPath")]
		[REDProperty(IsIgnored = true)]
		public CString EffectPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("effectTag")]
		[REDProperty(IsIgnored = true)]
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("effectTypes")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> EffectTypes
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("fact")]
		[REDProperty(IsIgnored = true)]
		public CName Fact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("fireAndForget")]
		[REDProperty(IsIgnored = true)]
		public CBool FireAndForget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hitFlag")]
		[REDProperty(IsIgnored = true)]
		public CString HitFlag
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("increaseWithDistance")]
		[REDProperty(IsIgnored = true)]
		public CBool IncreaseWithDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("level")]
		[REDProperty(IsIgnored = true)]
		public CFloat Level
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxDmg")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxDmg
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("networkAction")]
		[REDProperty(IsIgnored = true)]
		public CString NetworkAction
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("operationType")]
		[REDProperty(IsIgnored = true)]
		public CString OperationType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("overrideMaterialClearOnDetach")]
		[REDProperty(IsIgnored = true)]
		public CBool OverrideMaterialClearOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("overrideMaterialName")]
		[REDProperty(IsIgnored = true)]
		public CName OverrideMaterialName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("overrideMaterialTag")]
		[REDProperty(IsIgnored = true)]
		public CName OverrideMaterialTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("percentMult")]
		[REDProperty(IsIgnored = true)]
		public CFloat PercentMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pointsType")]
		[REDProperty(IsIgnored = true)]
		public CString PointsType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("poolStatus")]
		[REDProperty(IsIgnored = true)]
		public CString PoolStatus
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("prereqRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PrereqRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("primaryText")]
		[REDProperty(IsIgnored = true)]
		public CString PrimaryText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reason")]
		[REDProperty(IsIgnored = true)]
		public CName Reason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("refObj")]
		[REDProperty(IsIgnored = true)]
		public CString RefObj
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("removeAfterActionCall")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveAfterActionCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("resetAppearance")]
		[REDProperty(IsIgnored = true)]
		public CBool ResetAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("reward")]
		[REDProperty(IsIgnored = true)]
		public CString Reward
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("secondaryText")]
		[REDProperty(IsIgnored = true)]
		public CString SecondaryText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("setValue")]
		[REDProperty(IsIgnored = true)]
		public CBool SetValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("sfxName")]
		[REDProperty(IsIgnored = true)]
		public CName SfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sfxToStart")]
		[REDProperty(IsIgnored = true)]
		public CName SfxToStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("sfxToStop")]
		[REDProperty(IsIgnored = true)]
		public CName SfxToStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("startOnUninitialize")]
		[REDProperty(IsIgnored = true)]
		public CBool StartOnUninitialize
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
		
		[RED("statPool")]
		[REDProperty(IsIgnored = true)]
		public CString StatPool
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("statPoolUpdates")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatPoolUpdates
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statusEffect")]
		[REDProperty(IsIgnored = true)]
		public CString StatusEffect
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("statusEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> StatusEffects
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("unique")]
		[REDProperty(IsIgnored = true)]
		public CBool Unique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("unitThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat UnitThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("usePercent")]
		[REDProperty(IsIgnored = true)]
		public CBool UsePercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("valueOff")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ValueOff
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("valueOn")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ValueOn
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("vfxName")]
		[REDProperty(IsIgnored = true)]
		public CName VfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfxToStart")]
		[REDProperty(IsIgnored = true)]
		public CName VfxToStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("vfxToStop")]
		[REDProperty(IsIgnored = true)]
		public CName VfxToStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("weakSpotIndex")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WeakSpotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
