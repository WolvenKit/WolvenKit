using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsDestructionParams : CVariable
	{
		private CBool _startInactive;
		private CEnum<physicsSimulationType> _simulationType;
		private CBool _markEdgeChunks;
		private CBool _useAggregatesForClusters;
		private CBool _turnDynamicOnImpulse;
		private CBool _buildConvexForClusters;
		private CFloat _damageThreshold;
		private CFloat _damageEndurance;
		private CFloat _bondEndurance;
		private CBool _accumulateDamage;
		private CFloat _impulseToDamage;
		private CFloat _contactToDamage;
		private CFloat _maxContactImpulseRatio;
		private CFloat _impulseChildPropagationFactor;
		private CFloat _impulsePropagationFactor;
		private CFloat _impulseDiminishingFactor;
		private CBool _breakBonds;
		private CBool _debrisTimeout;
		private CFloat _debrisTimeoutMin;
		private CFloat _debrisTimeoutMax;
		private CFloat _fadeOutTime;
		private CFloat _debrisMaxSeparation;
		private CBool _visualsRemain;
		private CBool _debrisDestructible;
		private CBool _supportDamage;
		private CFloat _maxAngularVelocity;

		[Ordinal(0)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(1)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(2)] 
		[RED("markEdgeChunks")] 
		public CBool MarkEdgeChunks
		{
			get => GetProperty(ref _markEdgeChunks);
			set => SetProperty(ref _markEdgeChunks, value);
		}

		[Ordinal(3)] 
		[RED("useAggregatesForClusters")] 
		public CBool UseAggregatesForClusters
		{
			get => GetProperty(ref _useAggregatesForClusters);
			set => SetProperty(ref _useAggregatesForClusters, value);
		}

		[Ordinal(4)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get => GetProperty(ref _turnDynamicOnImpulse);
			set => SetProperty(ref _turnDynamicOnImpulse, value);
		}

		[Ordinal(5)] 
		[RED("buildConvexForClusters")] 
		public CBool BuildConvexForClusters
		{
			get => GetProperty(ref _buildConvexForClusters);
			set => SetProperty(ref _buildConvexForClusters, value);
		}

		[Ordinal(6)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetProperty(ref _damageThreshold);
			set => SetProperty(ref _damageThreshold, value);
		}

		[Ordinal(7)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetProperty(ref _damageEndurance);
			set => SetProperty(ref _damageEndurance, value);
		}

		[Ordinal(8)] 
		[RED("bondEndurance")] 
		public CFloat BondEndurance
		{
			get => GetProperty(ref _bondEndurance);
			set => SetProperty(ref _bondEndurance, value);
		}

		[Ordinal(9)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetProperty(ref _accumulateDamage);
			set => SetProperty(ref _accumulateDamage, value);
		}

		[Ordinal(10)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetProperty(ref _impulseToDamage);
			set => SetProperty(ref _impulseToDamage, value);
		}

		[Ordinal(11)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get => GetProperty(ref _contactToDamage);
			set => SetProperty(ref _contactToDamage, value);
		}

		[Ordinal(12)] 
		[RED("maxContactImpulseRatio")] 
		public CFloat MaxContactImpulseRatio
		{
			get => GetProperty(ref _maxContactImpulseRatio);
			set => SetProperty(ref _maxContactImpulseRatio, value);
		}

		[Ordinal(13)] 
		[RED("impulseChildPropagationFactor")] 
		public CFloat ImpulseChildPropagationFactor
		{
			get => GetProperty(ref _impulseChildPropagationFactor);
			set => SetProperty(ref _impulseChildPropagationFactor, value);
		}

		[Ordinal(14)] 
		[RED("impulsePropagationFactor")] 
		public CFloat ImpulsePropagationFactor
		{
			get => GetProperty(ref _impulsePropagationFactor);
			set => SetProperty(ref _impulsePropagationFactor, value);
		}

		[Ordinal(15)] 
		[RED("impulseDiminishingFactor")] 
		public CFloat ImpulseDiminishingFactor
		{
			get => GetProperty(ref _impulseDiminishingFactor);
			set => SetProperty(ref _impulseDiminishingFactor, value);
		}

		[Ordinal(16)] 
		[RED("breakBonds")] 
		public CBool BreakBonds
		{
			get => GetProperty(ref _breakBonds);
			set => SetProperty(ref _breakBonds, value);
		}

		[Ordinal(17)] 
		[RED("debrisTimeout")] 
		public CBool DebrisTimeout
		{
			get => GetProperty(ref _debrisTimeout);
			set => SetProperty(ref _debrisTimeout, value);
		}

		[Ordinal(18)] 
		[RED("debrisTimeoutMin")] 
		public CFloat DebrisTimeoutMin
		{
			get => GetProperty(ref _debrisTimeoutMin);
			set => SetProperty(ref _debrisTimeoutMin, value);
		}

		[Ordinal(19)] 
		[RED("debrisTimeoutMax")] 
		public CFloat DebrisTimeoutMax
		{
			get => GetProperty(ref _debrisTimeoutMax);
			set => SetProperty(ref _debrisTimeoutMax, value);
		}

		[Ordinal(20)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get => GetProperty(ref _fadeOutTime);
			set => SetProperty(ref _fadeOutTime, value);
		}

		[Ordinal(21)] 
		[RED("debrisMaxSeparation")] 
		public CFloat DebrisMaxSeparation
		{
			get => GetProperty(ref _debrisMaxSeparation);
			set => SetProperty(ref _debrisMaxSeparation, value);
		}

		[Ordinal(22)] 
		[RED("visualsRemain")] 
		public CBool VisualsRemain
		{
			get => GetProperty(ref _visualsRemain);
			set => SetProperty(ref _visualsRemain, value);
		}

		[Ordinal(23)] 
		[RED("debrisDestructible")] 
		public CBool DebrisDestructible
		{
			get => GetProperty(ref _debrisDestructible);
			set => SetProperty(ref _debrisDestructible, value);
		}

		[Ordinal(24)] 
		[RED("supportDamage")] 
		public CBool SupportDamage
		{
			get => GetProperty(ref _supportDamage);
			set => SetProperty(ref _supportDamage, value);
		}

		[Ordinal(25)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get => GetProperty(ref _maxAngularVelocity);
			set => SetProperty(ref _maxAngularVelocity, value);
		}

		public physicsDestructionParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
