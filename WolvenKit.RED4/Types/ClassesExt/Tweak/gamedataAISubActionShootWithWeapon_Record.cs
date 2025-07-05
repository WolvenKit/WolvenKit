
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionShootWithWeapon_Record
	{
		[RED("aimingDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat AimingDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("dualWieldShootingStyle")]
		[REDProperty(IsIgnored = true)]
		public CName DualWieldShootingStyle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("instigator")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Instigator
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxNumberOfShots")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxNumberOfShots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("numberOfShots")]
		[REDProperty(IsIgnored = true)]
		public CInt32 NumberOfShots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("pauseCondition")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PauseCondition
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("pauseConditionCheckInterval")]
		[REDProperty(IsIgnored = true)]
		public CFloat PauseConditionCheckInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("predictionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PredictionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rangedAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RangedAttack
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
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 TargetOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("tbhCoefficient")]
		[REDProperty(IsIgnored = true)]
		public CFloat TbhCoefficient
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("triggerMode")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TriggerMode
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("weaponCustomEvent")]
		[REDProperty(IsIgnored = true)]
		public CName WeaponCustomEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("weaponSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> WeaponSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
