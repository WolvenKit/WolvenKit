
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGrenade_Record
	{
		[RED("addAxisRotationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat AddAxisRotationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("addAxisRotationSpeedMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat AddAxisRotationSpeedMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("addAxisRotationSpeedMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat AddAxisRotationSpeedMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("additionalAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AdditionalAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("additionalAttackOnDetonate")]
		[REDProperty(IsIgnored = true)]
		public CBool AdditionalAttackOnDetonate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("attackDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("attackRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat AttackRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("deepWaterAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DeepWaterAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("delayToDetonate")]
		[REDProperty(IsIgnored = true)]
		public CFloat DelayToDetonate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("deliveryMethod")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DeliveryMethod
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("detonationRumbleName")]
		[REDProperty(IsIgnored = true)]
		public CString DetonationRumbleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("detonationSound")]
		[REDProperty(IsIgnored = true)]
		public CString DetonationSound
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("detonationStimRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat DetonationStimRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("detonationStimType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DetonationStimType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("effectCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat EffectCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("enemyAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EnemyAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("freezeDelayAfterBounce")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDelayAfterBounce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("freezingDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("isContinuousEffect")]
		[REDProperty(IsIgnored = true)]
		public CBool IsContinuousEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("minimumDistanceFromFloor")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinimumDistanceFromFloor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("npcHitReactionAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NpcHitReactionAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("numberOfHitsForAdditionalAttack")]
		[REDProperty(IsIgnored = true)]
		public CInt32 NumberOfHitsForAdditionalAttack
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("randomRotationAxes")]
		[REDProperty(IsIgnored = true)]
		public CInt32 RandomRotationAxes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("releaseOnDetonation")]
		[REDProperty(IsIgnored = true)]
		public CBool ReleaseOnDetonation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("removeMeshOnDetonation")]
		[REDProperty(IsIgnored = true)]
		public CBool RemoveMeshOnDetonation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("rotationAxesSpeeds")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> RotationAxesSpeeds
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("rotationAxesX")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> RotationAxesX
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("rotationAxesY")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> RotationAxesY
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("rotationAxesZ")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> RotationAxesZ
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("rotationSpeedMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat RotationSpeedMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotationSpeedMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat RotationSpeedMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("seed")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Seed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("setStickyTracker")]
		[REDProperty(IsIgnored = true)]
		public CBool SetStickyTracker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shallowWaterAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ShallowWaterAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("shallowWaterDepth")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShallowWaterDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("shootCollisionEnableDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat ShootCollisionEnableDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sinkingDepth")]
		[REDProperty(IsIgnored = true)]
		public CFloat SinkingDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spawnFxAtWaterSurface")]
		[REDProperty(IsIgnored = true)]
		public CBool SpawnFxAtWaterSurface
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("stickyTrackerTimeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat StickyTrackerTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("stopAttackDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat StopAttackDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("underwaterDetonationRumbleName")]
		[REDProperty(IsIgnored = true)]
		public CString UnderwaterDetonationRumbleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("underwaterDetonationStimRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat UnderwaterDetonationStimRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useSeed")]
		[REDProperty(IsIgnored = true)]
		public CBool UseSeed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("waterDetonationImpulseRadiusCoef")]
		[REDProperty(IsIgnored = true)]
		public CFloat WaterDetonationImpulseRadiusCoef
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
