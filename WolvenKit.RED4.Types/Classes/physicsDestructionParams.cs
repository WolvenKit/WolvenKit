using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsDestructionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetPropertyValue<CEnum<physicsSimulationType>>();
			set => SetPropertyValue<CEnum<physicsSimulationType>>(value);
		}

		[Ordinal(2)] 
		[RED("markEdgeChunks")] 
		public CBool MarkEdgeChunks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("useAggregatesForClusters")] 
		public CBool UseAggregatesForClusters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("buildConvexForClusters")] 
		public CBool BuildConvexForClusters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("bondEndurance")] 
		public CFloat BondEndurance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("maxContactImpulseRatio")] 
		public CFloat MaxContactImpulseRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("impulseChildPropagationFactor")] 
		public CFloat ImpulseChildPropagationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("impulsePropagationFactor")] 
		public CFloat ImpulsePropagationFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("impulseDiminishingFactor")] 
		public CFloat ImpulseDiminishingFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("breakBonds")] 
		public CBool BreakBonds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("debrisTimeout")] 
		public CBool DebrisTimeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("debrisTimeoutMin")] 
		public CFloat DebrisTimeoutMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("debrisTimeoutMax")] 
		public CFloat DebrisTimeoutMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("debrisMaxSeparation")] 
		public CFloat DebrisMaxSeparation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("visualsRemain")] 
		public CBool VisualsRemain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("debrisDestructible")] 
		public CBool DebrisDestructible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("supportDamage")] 
		public CBool SupportDamage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("fractureFieldMask")] 
		public CBitField<physicsFractureFieldType> FractureFieldMask
		{
			get => GetPropertyValue<CBitField<physicsFractureFieldType>>();
			set => SetPropertyValue<CBitField<physicsFractureFieldType>>(value);
		}

		public physicsDestructionParams()
		{
			DamageThreshold = 25.000000F;
			DamageEndurance = 10.000000F;
			BondEndurance = 20.000000F;
			AccumulateDamage = true;
			ImpulseToDamage = 1.000000F;
			ContactToDamage = 10.000000F;
			MaxContactImpulseRatio = 1.000000F;
			ImpulseChildPropagationFactor = 1.000000F;
			ImpulsePropagationFactor = 0.500000F;
			ImpulseDiminishingFactor = 0.500000F;
			DebrisMaxSeparation = 50.000000F;
			MaxAngularVelocity = -1.000000F;
			FractureFieldMask = Enums.physicsFractureFieldType.FF_Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
