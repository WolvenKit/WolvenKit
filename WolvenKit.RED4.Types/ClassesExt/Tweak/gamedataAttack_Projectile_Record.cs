
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_Projectile_Record
	{
		[RED("attackName")]
		[REDProperty(IsIgnored = true)]
		public CName AttackName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("attackType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttackType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("className")]
		[REDProperty(IsIgnored = true)]
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("damageType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DamageType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("explosionAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ExplosionAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("explosionRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat ExplosionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("finalTargetPositionCalculationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat FinalTargetPositionCalculationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("followTargetInPhase2")]
		[REDProperty(IsIgnored = true)]
		public CBool FollowTargetInPhase2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("hitCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat HitCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("hitFlags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> HitFlags
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
		
		[RED("hitReactionSeverityMax")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitReactionSeverityMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitReactionSeverityMin")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitReactionSeverityMin
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("p1AngleInHitPlaneMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1AngleInHitPlaneMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1AngleInHitPlaneMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1AngleInHitPlaneMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1AngleInVerticalPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1AngleInVerticalPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1BendFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1BendTimeRatio")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1BendTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1DurationMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1DurationMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1DurationMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1DurationMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1PositionForwardOffsetMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1PositionForwardOffsetMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1PositionForwardOffsetMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1PositionForwardOffsetMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1PositionLateralOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1PositionLateralOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1PositionZOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1PositionZOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1SnapRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1SnapRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p1StartVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat P1StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2AngleInHitPlaneMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2AngleInHitPlaneMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2AngleInHitPlaneMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2AngleInHitPlaneMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2AngleInVerticalPlane")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2AngleInVerticalPlane
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2BendFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2BendRation")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2BendRation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("p2ShouldRotate")]
		[REDProperty(IsIgnored = true)]
		public CBool P2ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("p2StartVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat P2StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("playerIncomingDamageMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat PlayerIncomingDamageMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("playerPositionGrabTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat PlayerPositionGrabTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("projectileAccelOverride")]
		[REDProperty(IsIgnored = true)]
		public CFloat ProjectileAccelOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("projectileTemplateName")]
		[REDProperty(IsIgnored = true)]
		public CName ProjectileTemplateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("puppetBroadphaseHitRadiusSquared")]
		[REDProperty(IsIgnored = true)]
		public CFloat PuppetBroadphaseHitRadiusSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("range")]
		[REDProperty(IsIgnored = true)]
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("statModifiers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatModifiers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("statusEffects")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StatusEffects
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("targetPositionOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetPositionOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("targetPositionXYAdditive")]
		[REDProperty(IsIgnored = true)]
		public CFloat TargetPositionXYAdditive
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useDefaultAimData")]
		[REDProperty(IsIgnored = true)]
		public CBool UseDefaultAimData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("userDataPath")]
		[REDProperty(IsIgnored = true)]
		public CString UserDataPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
