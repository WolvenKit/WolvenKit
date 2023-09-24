
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_Melee_Record
	{
		[RED("activeDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat ActiveDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("activeHitDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat ActiveHitDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackDirection")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackDirection
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attackEffectDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackEffectDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackEffectDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackEffectDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackSubtype")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackSubtype
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attackWindowClosed")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackWindowClosed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackWindowOpen")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackWindowOpen
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blockCostFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlockCostFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("blockTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat BlockTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cameraSpaceImpulse")]
		[REDProperty(IsIgnored = true)]
		public CFloat CameraSpaceImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("canSkipBlock")]
		[REDProperty(IsIgnored = true)]
		public CBool CanSkipBlock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("dontScaleWithAttackSpeed")]
		[REDProperty(IsIgnored = true)]
		public CBool DontScaleWithAttackSpeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("enableAdjustingPlayerPositionToTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableAdjustingPlayerPositionToTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("forwardImpulse")]
		[REDProperty(IsIgnored = true)]
		public CFloat ForwardImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hasDeflectAnim")]
		[REDProperty(IsIgnored = true)]
		public CBool HasDeflectAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hasHitAnim")]
		[REDProperty(IsIgnored = true)]
		public CBool HasHitAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("holdTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat HoldTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("idleTransitionTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat IdleTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("ikOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 IkOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("impactFxSlot")]
		[REDProperty(IsIgnored = true)]
		public CName ImpactFxSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("impulseDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat ImpulseDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("incrementsCombo")]
		[REDProperty(IsIgnored = true)]
		public CBool IncrementsCombo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("radius")]
		[REDProperty(IsIgnored = true)]
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("recoverDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat RecoverDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("recoverHitDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat RecoverHitDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpawnDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("standUpDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat StandUpDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startupDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat StartupDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("trailAttackSide")]
		[REDProperty(IsIgnored = true)]
		public CString TrailAttackSide
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("trailStartDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrailStartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("trailStopDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat TrailStopDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("upImpulse")]
		[REDProperty(IsIgnored = true)]
		public CFloat UpImpulse
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useAdjustmentInsteadOfImpulse")]
		[REDProperty(IsIgnored = true)]
		public CBool UseAdjustmentInsteadOfImpulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("vfxName")]
		[REDProperty(IsIgnored = true)]
		public CName VfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("weaponChargeCost")]
		[REDProperty(IsIgnored = true)]
		public CFloat WeaponChargeCost
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
