
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGrenade_Record
	{
		[RED("additionalAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AdditionalAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("deepWaterDepth")]
		[REDProperty(IsIgnored = true)]
		public CFloat DeepWaterDepth
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
		
		[RED("enemyAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EnemyAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enhancedAttackDurationFromPerk")]
		[REDProperty(IsIgnored = true)]
		public CFloat EnhancedAttackDurationFromPerk
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("enhancedAttackRadiusFromPerk")]
		[REDProperty(IsIgnored = true)]
		public CFloat EnhancedAttackRadiusFromPerk
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("enhancedPerkAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EnhancedPerkAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("npcHitReactionAttack")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NpcHitReactionAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("sinkingDetonationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat SinkingDetonationDelay
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
	}
}
