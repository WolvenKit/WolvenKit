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
			get
			{
				if (_startInactive == null)
				{
					_startInactive = (CBool) CR2WTypeManager.Create("Bool", "startInactive", cr2w, this);
				}
				return _startInactive;
			}
			set
			{
				if (_startInactive == value)
				{
					return;
				}
				_startInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("markEdgeChunks")] 
		public CBool MarkEdgeChunks
		{
			get
			{
				if (_markEdgeChunks == null)
				{
					_markEdgeChunks = (CBool) CR2WTypeManager.Create("Bool", "markEdgeChunks", cr2w, this);
				}
				return _markEdgeChunks;
			}
			set
			{
				if (_markEdgeChunks == value)
				{
					return;
				}
				_markEdgeChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useAggregatesForClusters")] 
		public CBool UseAggregatesForClusters
		{
			get
			{
				if (_useAggregatesForClusters == null)
				{
					_useAggregatesForClusters = (CBool) CR2WTypeManager.Create("Bool", "useAggregatesForClusters", cr2w, this);
				}
				return _useAggregatesForClusters;
			}
			set
			{
				if (_useAggregatesForClusters == value)
				{
					return;
				}
				_useAggregatesForClusters = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get
			{
				if (_turnDynamicOnImpulse == null)
				{
					_turnDynamicOnImpulse = (CBool) CR2WTypeManager.Create("Bool", "turnDynamicOnImpulse", cr2w, this);
				}
				return _turnDynamicOnImpulse;
			}
			set
			{
				if (_turnDynamicOnImpulse == value)
				{
					return;
				}
				_turnDynamicOnImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("buildConvexForClusters")] 
		public CBool BuildConvexForClusters
		{
			get
			{
				if (_buildConvexForClusters == null)
				{
					_buildConvexForClusters = (CBool) CR2WTypeManager.Create("Bool", "buildConvexForClusters", cr2w, this);
				}
				return _buildConvexForClusters;
			}
			set
			{
				if (_buildConvexForClusters == value)
				{
					return;
				}
				_buildConvexForClusters = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get
			{
				if (_damageThreshold == null)
				{
					_damageThreshold = (CFloat) CR2WTypeManager.Create("Float", "damageThreshold", cr2w, this);
				}
				return _damageThreshold;
			}
			set
			{
				if (_damageThreshold == value)
				{
					return;
				}
				_damageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get
			{
				if (_damageEndurance == null)
				{
					_damageEndurance = (CFloat) CR2WTypeManager.Create("Float", "damageEndurance", cr2w, this);
				}
				return _damageEndurance;
			}
			set
			{
				if (_damageEndurance == value)
				{
					return;
				}
				_damageEndurance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bondEndurance")] 
		public CFloat BondEndurance
		{
			get
			{
				if (_bondEndurance == null)
				{
					_bondEndurance = (CFloat) CR2WTypeManager.Create("Float", "bondEndurance", cr2w, this);
				}
				return _bondEndurance;
			}
			set
			{
				if (_bondEndurance == value)
				{
					return;
				}
				_bondEndurance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get
			{
				if (_accumulateDamage == null)
				{
					_accumulateDamage = (CBool) CR2WTypeManager.Create("Bool", "accumulateDamage", cr2w, this);
				}
				return _accumulateDamage;
			}
			set
			{
				if (_accumulateDamage == value)
				{
					return;
				}
				_accumulateDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get
			{
				if (_impulseToDamage == null)
				{
					_impulseToDamage = (CFloat) CR2WTypeManager.Create("Float", "impulseToDamage", cr2w, this);
				}
				return _impulseToDamage;
			}
			set
			{
				if (_impulseToDamage == value)
				{
					return;
				}
				_impulseToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("contactToDamage")] 
		public CFloat ContactToDamage
		{
			get
			{
				if (_contactToDamage == null)
				{
					_contactToDamage = (CFloat) CR2WTypeManager.Create("Float", "contactToDamage", cr2w, this);
				}
				return _contactToDamage;
			}
			set
			{
				if (_contactToDamage == value)
				{
					return;
				}
				_contactToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("maxContactImpulseRatio")] 
		public CFloat MaxContactImpulseRatio
		{
			get
			{
				if (_maxContactImpulseRatio == null)
				{
					_maxContactImpulseRatio = (CFloat) CR2WTypeManager.Create("Float", "maxContactImpulseRatio", cr2w, this);
				}
				return _maxContactImpulseRatio;
			}
			set
			{
				if (_maxContactImpulseRatio == value)
				{
					return;
				}
				_maxContactImpulseRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("impulseChildPropagationFactor")] 
		public CFloat ImpulseChildPropagationFactor
		{
			get
			{
				if (_impulseChildPropagationFactor == null)
				{
					_impulseChildPropagationFactor = (CFloat) CR2WTypeManager.Create("Float", "impulseChildPropagationFactor", cr2w, this);
				}
				return _impulseChildPropagationFactor;
			}
			set
			{
				if (_impulseChildPropagationFactor == value)
				{
					return;
				}
				_impulseChildPropagationFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("impulsePropagationFactor")] 
		public CFloat ImpulsePropagationFactor
		{
			get
			{
				if (_impulsePropagationFactor == null)
				{
					_impulsePropagationFactor = (CFloat) CR2WTypeManager.Create("Float", "impulsePropagationFactor", cr2w, this);
				}
				return _impulsePropagationFactor;
			}
			set
			{
				if (_impulsePropagationFactor == value)
				{
					return;
				}
				_impulsePropagationFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("impulseDiminishingFactor")] 
		public CFloat ImpulseDiminishingFactor
		{
			get
			{
				if (_impulseDiminishingFactor == null)
				{
					_impulseDiminishingFactor = (CFloat) CR2WTypeManager.Create("Float", "impulseDiminishingFactor", cr2w, this);
				}
				return _impulseDiminishingFactor;
			}
			set
			{
				if (_impulseDiminishingFactor == value)
				{
					return;
				}
				_impulseDiminishingFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("breakBonds")] 
		public CBool BreakBonds
		{
			get
			{
				if (_breakBonds == null)
				{
					_breakBonds = (CBool) CR2WTypeManager.Create("Bool", "breakBonds", cr2w, this);
				}
				return _breakBonds;
			}
			set
			{
				if (_breakBonds == value)
				{
					return;
				}
				_breakBonds = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("debrisTimeout")] 
		public CBool DebrisTimeout
		{
			get
			{
				if (_debrisTimeout == null)
				{
					_debrisTimeout = (CBool) CR2WTypeManager.Create("Bool", "debrisTimeout", cr2w, this);
				}
				return _debrisTimeout;
			}
			set
			{
				if (_debrisTimeout == value)
				{
					return;
				}
				_debrisTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("debrisTimeoutMin")] 
		public CFloat DebrisTimeoutMin
		{
			get
			{
				if (_debrisTimeoutMin == null)
				{
					_debrisTimeoutMin = (CFloat) CR2WTypeManager.Create("Float", "debrisTimeoutMin", cr2w, this);
				}
				return _debrisTimeoutMin;
			}
			set
			{
				if (_debrisTimeoutMin == value)
				{
					return;
				}
				_debrisTimeoutMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("debrisTimeoutMax")] 
		public CFloat DebrisTimeoutMax
		{
			get
			{
				if (_debrisTimeoutMax == null)
				{
					_debrisTimeoutMax = (CFloat) CR2WTypeManager.Create("Float", "debrisTimeoutMax", cr2w, this);
				}
				return _debrisTimeoutMax;
			}
			set
			{
				if (_debrisTimeoutMax == value)
				{
					return;
				}
				_debrisTimeoutMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("fadeOutTime")] 
		public CFloat FadeOutTime
		{
			get
			{
				if (_fadeOutTime == null)
				{
					_fadeOutTime = (CFloat) CR2WTypeManager.Create("Float", "fadeOutTime", cr2w, this);
				}
				return _fadeOutTime;
			}
			set
			{
				if (_fadeOutTime == value)
				{
					return;
				}
				_fadeOutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("debrisMaxSeparation")] 
		public CFloat DebrisMaxSeparation
		{
			get
			{
				if (_debrisMaxSeparation == null)
				{
					_debrisMaxSeparation = (CFloat) CR2WTypeManager.Create("Float", "debrisMaxSeparation", cr2w, this);
				}
				return _debrisMaxSeparation;
			}
			set
			{
				if (_debrisMaxSeparation == value)
				{
					return;
				}
				_debrisMaxSeparation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("visualsRemain")] 
		public CBool VisualsRemain
		{
			get
			{
				if (_visualsRemain == null)
				{
					_visualsRemain = (CBool) CR2WTypeManager.Create("Bool", "visualsRemain", cr2w, this);
				}
				return _visualsRemain;
			}
			set
			{
				if (_visualsRemain == value)
				{
					return;
				}
				_visualsRemain = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("debrisDestructible")] 
		public CBool DebrisDestructible
		{
			get
			{
				if (_debrisDestructible == null)
				{
					_debrisDestructible = (CBool) CR2WTypeManager.Create("Bool", "debrisDestructible", cr2w, this);
				}
				return _debrisDestructible;
			}
			set
			{
				if (_debrisDestructible == value)
				{
					return;
				}
				_debrisDestructible = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("supportDamage")] 
		public CBool SupportDamage
		{
			get
			{
				if (_supportDamage == null)
				{
					_supportDamage = (CBool) CR2WTypeManager.Create("Bool", "supportDamage", cr2w, this);
				}
				return _supportDamage;
			}
			set
			{
				if (_supportDamage == value)
				{
					return;
				}
				_supportDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("maxAngularVelocity")] 
		public CFloat MaxAngularVelocity
		{
			get
			{
				if (_maxAngularVelocity == null)
				{
					_maxAngularVelocity = (CFloat) CR2WTypeManager.Create("Float", "maxAngularVelocity", cr2w, this);
				}
				return _maxAngularVelocity;
			}
			set
			{
				if (_maxAngularVelocity == value)
				{
					return;
				}
				_maxAngularVelocity = value;
				PropertySet(this);
			}
		}

		public physicsDestructionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
