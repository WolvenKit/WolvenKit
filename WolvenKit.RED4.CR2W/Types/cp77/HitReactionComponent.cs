using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionComponent : AIMandatoryComponents
	{
		private CFloat _impactDamageDuration;
		private CFloat _staggerDamageDuration;
		private CFloat _impactDamageDurationMelee;
		private CFloat _staggerDamageDurationMelee;
		private CFloat _knockdownDamageDuration;
		private CFloat _defeatedMinDuration;
		private CFloat _previousHitTime;
		private CEnum<animHitReactionType> _reactionType;
		private CHandle<animAnimFeature_HitReactionsData> _animHitReaction;
		private CHandle<animAnimFeature_HitReactionsData> _lastAnimHitReaction;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;
		private CArray<ScriptHitData> _previousAnimHitReactionArray;
		private CEnum<EAILastHitReactionPlayed> _lastHitReactionPlayed;
		private gameShapeData _hitShapeData;
		private CInt32 _animVariation;
		private CFloat _specificHitTimeout;
		private CFloat _quickMeleeCooldown;
		private CArray<CFloat> _dismembermentBodyPartDamageThreshold;
		private CArray<CFloat> _woundedBodyPartDamageThreshold;
		private CArray<CFloat> _defeatedBodyPartDamageThreshold;
		private CFloat _impactDamageThreshold;
		private CFloat _staggerDamageThreshold;
		private CFloat _knockdownDamageThreshold;
		private CFloat _knockdownImpulseThreshold;
		private CBool _immuneToKnockDown;
		private CFloat _hitComboReset;
		private CFloat _physicalImpulseReset;
		private CFloat _cumulatedDamages;
		private CArray<CFloat> _bodyPartWoundCumulatedDamages;
		private CArray<CFloat> _bodyPartDismemberCumulatedDamages;
		private CFloat _overrideHitReactionImpulse;
		private CFloat _cumulatedPhysicalImpulse;
		private CFloat _comboResetTime;
		private CFloat _ragdollImpulse;
		private CEnum<EAIHitIntensity> _hitIntensity;
		private CFloat _previousMeleeHitTimeStamp;
		private CFloat _previousRangedHitTimeStamp;
		private CFloat _previousBlockTimeStamp;
		private CFloat _previousParryTimeStamp;
		private CFloat _previousDodgeTimeStamp;
		private CInt32 _blockCount;
		private CInt32 _parryCount;
		private CInt32 _dodgeCount;
		private CUInt32 _hitCount;
		private CBool _defeatedHasBeenPlayed;
		private CBool _deathHasBeenPlayed;
		private CFloat _deathRegisteredTime;
		private CFloat _extendedDeathRegisteredTime;
		private CFloat _extendedDeathDelayRegisteredTime;
		private CFloat _disableDismembermentAfterDeathDelay;
		private CFloat _extendedHitReactionRegisteredTime;
		private CFloat _extendedHitReactionDelayRegisteredTime;
		private CBool _scatteredGuts;
		private CFloat _cumulativeDamageUpdateInterval;
		private CBool _cumulativeDamageUpdateRequested;
		private CUInt32 _currentStimId;
		private CHandle<gamedamageAttackData> _attackData;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private CHandle<HitReactionBehaviorData> _lastHitReactionBehaviorData;
		private CName _lastStimName;
		private CName _deathStimName;
		private CInt32 _meleeHitCount;
		private CInt32 _strongMeleeHitCount;
		private CInt32 _maxHitChain;
		private CBool _isAlive;
		private CFloat _frameDamageHealthFactor;
		private CArrayFixedSize<CFloat> _hitCountData;
		private CInt32 _hitCountArrayEnd;
		private CInt32 _hitCountArrayCurrent;
		private CUInt32 _indicatorEnabledBlackboardId;
		private CBool _hitIndicatorEnabled;
		private CBool _hasBeenWounded;
		private CHandle<animAnimFeature_HitReactionsData> _hitReactionData;

		[Ordinal(5)] 
		[RED("impactDamageDuration")] 
		public CFloat ImpactDamageDuration
		{
			get
			{
				if (_impactDamageDuration == null)
				{
					_impactDamageDuration = (CFloat) CR2WTypeManager.Create("Float", "impactDamageDuration", cr2w, this);
				}
				return _impactDamageDuration;
			}
			set
			{
				if (_impactDamageDuration == value)
				{
					return;
				}
				_impactDamageDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("staggerDamageDuration")] 
		public CFloat StaggerDamageDuration
		{
			get
			{
				if (_staggerDamageDuration == null)
				{
					_staggerDamageDuration = (CFloat) CR2WTypeManager.Create("Float", "staggerDamageDuration", cr2w, this);
				}
				return _staggerDamageDuration;
			}
			set
			{
				if (_staggerDamageDuration == value)
				{
					return;
				}
				_staggerDamageDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("impactDamageDurationMelee")] 
		public CFloat ImpactDamageDurationMelee
		{
			get
			{
				if (_impactDamageDurationMelee == null)
				{
					_impactDamageDurationMelee = (CFloat) CR2WTypeManager.Create("Float", "impactDamageDurationMelee", cr2w, this);
				}
				return _impactDamageDurationMelee;
			}
			set
			{
				if (_impactDamageDurationMelee == value)
				{
					return;
				}
				_impactDamageDurationMelee = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("staggerDamageDurationMelee")] 
		public CFloat StaggerDamageDurationMelee
		{
			get
			{
				if (_staggerDamageDurationMelee == null)
				{
					_staggerDamageDurationMelee = (CFloat) CR2WTypeManager.Create("Float", "staggerDamageDurationMelee", cr2w, this);
				}
				return _staggerDamageDurationMelee;
			}
			set
			{
				if (_staggerDamageDurationMelee == value)
				{
					return;
				}
				_staggerDamageDurationMelee = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("knockdownDamageDuration")] 
		public CFloat KnockdownDamageDuration
		{
			get
			{
				if (_knockdownDamageDuration == null)
				{
					_knockdownDamageDuration = (CFloat) CR2WTypeManager.Create("Float", "knockdownDamageDuration", cr2w, this);
				}
				return _knockdownDamageDuration;
			}
			set
			{
				if (_knockdownDamageDuration == value)
				{
					return;
				}
				_knockdownDamageDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("defeatedMinDuration")] 
		public CFloat DefeatedMinDuration
		{
			get
			{
				if (_defeatedMinDuration == null)
				{
					_defeatedMinDuration = (CFloat) CR2WTypeManager.Create("Float", "defeatedMinDuration", cr2w, this);
				}
				return _defeatedMinDuration;
			}
			set
			{
				if (_defeatedMinDuration == value)
				{
					return;
				}
				_defeatedMinDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("previousHitTime")] 
		public CFloat PreviousHitTime
		{
			get
			{
				if (_previousHitTime == null)
				{
					_previousHitTime = (CFloat) CR2WTypeManager.Create("Float", "previousHitTime", cr2w, this);
				}
				return _previousHitTime;
			}
			set
			{
				if (_previousHitTime == value)
				{
					return;
				}
				_previousHitTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("reactionType")] 
		public CEnum<animHitReactionType> ReactionType
		{
			get
			{
				if (_reactionType == null)
				{
					_reactionType = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "reactionType", cr2w, this);
				}
				return _reactionType;
			}
			set
			{
				if (_reactionType == value)
				{
					return;
				}
				_reactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("animHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction
		{
			get
			{
				if (_animHitReaction == null)
				{
					_animHitReaction = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "animHitReaction", cr2w, this);
				}
				return _animHitReaction;
			}
			set
			{
				if (_animHitReaction == value)
				{
					return;
				}
				_animHitReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lastAnimHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction
		{
			get
			{
				if (_lastAnimHitReaction == null)
				{
					_lastAnimHitReaction = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "lastAnimHitReaction", cr2w, this);
				}
				return _lastAnimHitReaction;
			}
			set
			{
				if (_lastAnimHitReaction == value)
				{
					return;
				}
				_lastAnimHitReaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get
			{
				if (_hitReactionAction == null)
				{
					_hitReactionAction = (CHandle<ActionHitReactionScriptProxy>) CR2WTypeManager.Create("handle:ActionHitReactionScriptProxy", "hitReactionAction", cr2w, this);
				}
				return _hitReactionAction;
			}
			set
			{
				if (_hitReactionAction == value)
				{
					return;
				}
				_hitReactionAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("previousAnimHitReactionArray")] 
		public CArray<ScriptHitData> PreviousAnimHitReactionArray
		{
			get
			{
				if (_previousAnimHitReactionArray == null)
				{
					_previousAnimHitReactionArray = (CArray<ScriptHitData>) CR2WTypeManager.Create("array:ScriptHitData", "previousAnimHitReactionArray", cr2w, this);
				}
				return _previousAnimHitReactionArray;
			}
			set
			{
				if (_previousAnimHitReactionArray == value)
				{
					return;
				}
				_previousAnimHitReactionArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("lastHitReactionPlayed")] 
		public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed
		{
			get
			{
				if (_lastHitReactionPlayed == null)
				{
					_lastHitReactionPlayed = (CEnum<EAILastHitReactionPlayed>) CR2WTypeManager.Create("EAILastHitReactionPlayed", "lastHitReactionPlayed", cr2w, this);
				}
				return _lastHitReactionPlayed;
			}
			set
			{
				if (_lastHitReactionPlayed == value)
				{
					return;
				}
				_lastHitReactionPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("hitShapeData")] 
		public gameShapeData HitShapeData
		{
			get
			{
				if (_hitShapeData == null)
				{
					_hitShapeData = (gameShapeData) CR2WTypeManager.Create("gameShapeData", "hitShapeData", cr2w, this);
				}
				return _hitShapeData;
			}
			set
			{
				if (_hitShapeData == value)
				{
					return;
				}
				_hitShapeData = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CInt32) CR2WTypeManager.Create("Int32", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("specificHitTimeout")] 
		public CFloat SpecificHitTimeout
		{
			get
			{
				if (_specificHitTimeout == null)
				{
					_specificHitTimeout = (CFloat) CR2WTypeManager.Create("Float", "specificHitTimeout", cr2w, this);
				}
				return _specificHitTimeout;
			}
			set
			{
				if (_specificHitTimeout == value)
				{
					return;
				}
				_specificHitTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("quickMeleeCooldown")] 
		public CFloat QuickMeleeCooldown
		{
			get
			{
				if (_quickMeleeCooldown == null)
				{
					_quickMeleeCooldown = (CFloat) CR2WTypeManager.Create("Float", "quickMeleeCooldown", cr2w, this);
				}
				return _quickMeleeCooldown;
			}
			set
			{
				if (_quickMeleeCooldown == value)
				{
					return;
				}
				_quickMeleeCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("dismembermentBodyPartDamageThreshold")] 
		public CArray<CFloat> DismembermentBodyPartDamageThreshold
		{
			get
			{
				if (_dismembermentBodyPartDamageThreshold == null)
				{
					_dismembermentBodyPartDamageThreshold = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "dismembermentBodyPartDamageThreshold", cr2w, this);
				}
				return _dismembermentBodyPartDamageThreshold;
			}
			set
			{
				if (_dismembermentBodyPartDamageThreshold == value)
				{
					return;
				}
				_dismembermentBodyPartDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("woundedBodyPartDamageThreshold")] 
		public CArray<CFloat> WoundedBodyPartDamageThreshold
		{
			get
			{
				if (_woundedBodyPartDamageThreshold == null)
				{
					_woundedBodyPartDamageThreshold = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "woundedBodyPartDamageThreshold", cr2w, this);
				}
				return _woundedBodyPartDamageThreshold;
			}
			set
			{
				if (_woundedBodyPartDamageThreshold == value)
				{
					return;
				}
				_woundedBodyPartDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("defeatedBodyPartDamageThreshold")] 
		public CArray<CFloat> DefeatedBodyPartDamageThreshold
		{
			get
			{
				if (_defeatedBodyPartDamageThreshold == null)
				{
					_defeatedBodyPartDamageThreshold = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "defeatedBodyPartDamageThreshold", cr2w, this);
				}
				return _defeatedBodyPartDamageThreshold;
			}
			set
			{
				if (_defeatedBodyPartDamageThreshold == value)
				{
					return;
				}
				_defeatedBodyPartDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("impactDamageThreshold")] 
		public CFloat ImpactDamageThreshold
		{
			get
			{
				if (_impactDamageThreshold == null)
				{
					_impactDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "impactDamageThreshold", cr2w, this);
				}
				return _impactDamageThreshold;
			}
			set
			{
				if (_impactDamageThreshold == value)
				{
					return;
				}
				_impactDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("staggerDamageThreshold")] 
		public CFloat StaggerDamageThreshold
		{
			get
			{
				if (_staggerDamageThreshold == null)
				{
					_staggerDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "staggerDamageThreshold", cr2w, this);
				}
				return _staggerDamageThreshold;
			}
			set
			{
				if (_staggerDamageThreshold == value)
				{
					return;
				}
				_staggerDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("knockdownDamageThreshold")] 
		public CFloat KnockdownDamageThreshold
		{
			get
			{
				if (_knockdownDamageThreshold == null)
				{
					_knockdownDamageThreshold = (CFloat) CR2WTypeManager.Create("Float", "knockdownDamageThreshold", cr2w, this);
				}
				return _knockdownDamageThreshold;
			}
			set
			{
				if (_knockdownDamageThreshold == value)
				{
					return;
				}
				_knockdownDamageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("knockdownImpulseThreshold")] 
		public CFloat KnockdownImpulseThreshold
		{
			get
			{
				if (_knockdownImpulseThreshold == null)
				{
					_knockdownImpulseThreshold = (CFloat) CR2WTypeManager.Create("Float", "knockdownImpulseThreshold", cr2w, this);
				}
				return _knockdownImpulseThreshold;
			}
			set
			{
				if (_knockdownImpulseThreshold == value)
				{
					return;
				}
				_knockdownImpulseThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("immuneToKnockDown")] 
		public CBool ImmuneToKnockDown
		{
			get
			{
				if (_immuneToKnockDown == null)
				{
					_immuneToKnockDown = (CBool) CR2WTypeManager.Create("Bool", "immuneToKnockDown", cr2w, this);
				}
				return _immuneToKnockDown;
			}
			set
			{
				if (_immuneToKnockDown == value)
				{
					return;
				}
				_immuneToKnockDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("hitComboReset")] 
		public CFloat HitComboReset
		{
			get
			{
				if (_hitComboReset == null)
				{
					_hitComboReset = (CFloat) CR2WTypeManager.Create("Float", "hitComboReset", cr2w, this);
				}
				return _hitComboReset;
			}
			set
			{
				if (_hitComboReset == value)
				{
					return;
				}
				_hitComboReset = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("physicalImpulseReset")] 
		public CFloat PhysicalImpulseReset
		{
			get
			{
				if (_physicalImpulseReset == null)
				{
					_physicalImpulseReset = (CFloat) CR2WTypeManager.Create("Float", "physicalImpulseReset", cr2w, this);
				}
				return _physicalImpulseReset;
			}
			set
			{
				if (_physicalImpulseReset == value)
				{
					return;
				}
				_physicalImpulseReset = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("cumulatedDamages")] 
		public CFloat CumulatedDamages
		{
			get
			{
				if (_cumulatedDamages == null)
				{
					_cumulatedDamages = (CFloat) CR2WTypeManager.Create("Float", "cumulatedDamages", cr2w, this);
				}
				return _cumulatedDamages;
			}
			set
			{
				if (_cumulatedDamages == value)
				{
					return;
				}
				_cumulatedDamages = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("bodyPartWoundCumulatedDamages")] 
		public CArray<CFloat> BodyPartWoundCumulatedDamages
		{
			get
			{
				if (_bodyPartWoundCumulatedDamages == null)
				{
					_bodyPartWoundCumulatedDamages = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "bodyPartWoundCumulatedDamages", cr2w, this);
				}
				return _bodyPartWoundCumulatedDamages;
			}
			set
			{
				if (_bodyPartWoundCumulatedDamages == value)
				{
					return;
				}
				_bodyPartWoundCumulatedDamages = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("bodyPartDismemberCumulatedDamages")] 
		public CArray<CFloat> BodyPartDismemberCumulatedDamages
		{
			get
			{
				if (_bodyPartDismemberCumulatedDamages == null)
				{
					_bodyPartDismemberCumulatedDamages = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "bodyPartDismemberCumulatedDamages", cr2w, this);
				}
				return _bodyPartDismemberCumulatedDamages;
			}
			set
			{
				if (_bodyPartDismemberCumulatedDamages == value)
				{
					return;
				}
				_bodyPartDismemberCumulatedDamages = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("overrideHitReactionImpulse")] 
		public CFloat OverrideHitReactionImpulse
		{
			get
			{
				if (_overrideHitReactionImpulse == null)
				{
					_overrideHitReactionImpulse = (CFloat) CR2WTypeManager.Create("Float", "overrideHitReactionImpulse", cr2w, this);
				}
				return _overrideHitReactionImpulse;
			}
			set
			{
				if (_overrideHitReactionImpulse == value)
				{
					return;
				}
				_overrideHitReactionImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("cumulatedPhysicalImpulse")] 
		public CFloat CumulatedPhysicalImpulse
		{
			get
			{
				if (_cumulatedPhysicalImpulse == null)
				{
					_cumulatedPhysicalImpulse = (CFloat) CR2WTypeManager.Create("Float", "cumulatedPhysicalImpulse", cr2w, this);
				}
				return _cumulatedPhysicalImpulse;
			}
			set
			{
				if (_cumulatedPhysicalImpulse == value)
				{
					return;
				}
				_cumulatedPhysicalImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("comboResetTime")] 
		public CFloat ComboResetTime
		{
			get
			{
				if (_comboResetTime == null)
				{
					_comboResetTime = (CFloat) CR2WTypeManager.Create("Float", "comboResetTime", cr2w, this);
				}
				return _comboResetTime;
			}
			set
			{
				if (_comboResetTime == value)
				{
					return;
				}
				_comboResetTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("ragdollImpulse")] 
		public CFloat RagdollImpulse
		{
			get
			{
				if (_ragdollImpulse == null)
				{
					_ragdollImpulse = (CFloat) CR2WTypeManager.Create("Float", "ragdollImpulse", cr2w, this);
				}
				return _ragdollImpulse;
			}
			set
			{
				if (_ragdollImpulse == value)
				{
					return;
				}
				_ragdollImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("hitIntensity")] 
		public CEnum<EAIHitIntensity> HitIntensity
		{
			get
			{
				if (_hitIntensity == null)
				{
					_hitIntensity = (CEnum<EAIHitIntensity>) CR2WTypeManager.Create("EAIHitIntensity", "hitIntensity", cr2w, this);
				}
				return _hitIntensity;
			}
			set
			{
				if (_hitIntensity == value)
				{
					return;
				}
				_hitIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("previousMeleeHitTimeStamp")] 
		public CFloat PreviousMeleeHitTimeStamp
		{
			get
			{
				if (_previousMeleeHitTimeStamp == null)
				{
					_previousMeleeHitTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousMeleeHitTimeStamp", cr2w, this);
				}
				return _previousMeleeHitTimeStamp;
			}
			set
			{
				if (_previousMeleeHitTimeStamp == value)
				{
					return;
				}
				_previousMeleeHitTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("previousRangedHitTimeStamp")] 
		public CFloat PreviousRangedHitTimeStamp
		{
			get
			{
				if (_previousRangedHitTimeStamp == null)
				{
					_previousRangedHitTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousRangedHitTimeStamp", cr2w, this);
				}
				return _previousRangedHitTimeStamp;
			}
			set
			{
				if (_previousRangedHitTimeStamp == value)
				{
					return;
				}
				_previousRangedHitTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("previousBlockTimeStamp")] 
		public CFloat PreviousBlockTimeStamp
		{
			get
			{
				if (_previousBlockTimeStamp == null)
				{
					_previousBlockTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousBlockTimeStamp", cr2w, this);
				}
				return _previousBlockTimeStamp;
			}
			set
			{
				if (_previousBlockTimeStamp == value)
				{
					return;
				}
				_previousBlockTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("previousParryTimeStamp")] 
		public CFloat PreviousParryTimeStamp
		{
			get
			{
				if (_previousParryTimeStamp == null)
				{
					_previousParryTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousParryTimeStamp", cr2w, this);
				}
				return _previousParryTimeStamp;
			}
			set
			{
				if (_previousParryTimeStamp == value)
				{
					return;
				}
				_previousParryTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("previousDodgeTimeStamp")] 
		public CFloat PreviousDodgeTimeStamp
		{
			get
			{
				if (_previousDodgeTimeStamp == null)
				{
					_previousDodgeTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "previousDodgeTimeStamp", cr2w, this);
				}
				return _previousDodgeTimeStamp;
			}
			set
			{
				if (_previousDodgeTimeStamp == value)
				{
					return;
				}
				_previousDodgeTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("blockCount")] 
		public CInt32 BlockCount
		{
			get
			{
				if (_blockCount == null)
				{
					_blockCount = (CInt32) CR2WTypeManager.Create("Int32", "blockCount", cr2w, this);
				}
				return _blockCount;
			}
			set
			{
				if (_blockCount == value)
				{
					return;
				}
				_blockCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("parryCount")] 
		public CInt32 ParryCount
		{
			get
			{
				if (_parryCount == null)
				{
					_parryCount = (CInt32) CR2WTypeManager.Create("Int32", "parryCount", cr2w, this);
				}
				return _parryCount;
			}
			set
			{
				if (_parryCount == value)
				{
					return;
				}
				_parryCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("dodgeCount")] 
		public CInt32 DodgeCount
		{
			get
			{
				if (_dodgeCount == null)
				{
					_dodgeCount = (CInt32) CR2WTypeManager.Create("Int32", "dodgeCount", cr2w, this);
				}
				return _dodgeCount;
			}
			set
			{
				if (_dodgeCount == value)
				{
					return;
				}
				_dodgeCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get
			{
				if (_hitCount == null)
				{
					_hitCount = (CUInt32) CR2WTypeManager.Create("Uint32", "hitCount", cr2w, this);
				}
				return _hitCount;
			}
			set
			{
				if (_hitCount == value)
				{
					return;
				}
				_hitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("defeatedHasBeenPlayed")] 
		public CBool DefeatedHasBeenPlayed
		{
			get
			{
				if (_defeatedHasBeenPlayed == null)
				{
					_defeatedHasBeenPlayed = (CBool) CR2WTypeManager.Create("Bool", "defeatedHasBeenPlayed", cr2w, this);
				}
				return _defeatedHasBeenPlayed;
			}
			set
			{
				if (_defeatedHasBeenPlayed == value)
				{
					return;
				}
				_defeatedHasBeenPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get
			{
				if (_deathHasBeenPlayed == null)
				{
					_deathHasBeenPlayed = (CBool) CR2WTypeManager.Create("Bool", "deathHasBeenPlayed", cr2w, this);
				}
				return _deathHasBeenPlayed;
			}
			set
			{
				if (_deathHasBeenPlayed == value)
				{
					return;
				}
				_deathHasBeenPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("deathRegisteredTime")] 
		public CFloat DeathRegisteredTime
		{
			get
			{
				if (_deathRegisteredTime == null)
				{
					_deathRegisteredTime = (CFloat) CR2WTypeManager.Create("Float", "deathRegisteredTime", cr2w, this);
				}
				return _deathRegisteredTime;
			}
			set
			{
				if (_deathRegisteredTime == value)
				{
					return;
				}
				_deathRegisteredTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("extendedDeathRegisteredTime")] 
		public CFloat ExtendedDeathRegisteredTime
		{
			get
			{
				if (_extendedDeathRegisteredTime == null)
				{
					_extendedDeathRegisteredTime = (CFloat) CR2WTypeManager.Create("Float", "extendedDeathRegisteredTime", cr2w, this);
				}
				return _extendedDeathRegisteredTime;
			}
			set
			{
				if (_extendedDeathRegisteredTime == value)
				{
					return;
				}
				_extendedDeathRegisteredTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("extendedDeathDelayRegisteredTime")] 
		public CFloat ExtendedDeathDelayRegisteredTime
		{
			get
			{
				if (_extendedDeathDelayRegisteredTime == null)
				{
					_extendedDeathDelayRegisteredTime = (CFloat) CR2WTypeManager.Create("Float", "extendedDeathDelayRegisteredTime", cr2w, this);
				}
				return _extendedDeathDelayRegisteredTime;
			}
			set
			{
				if (_extendedDeathDelayRegisteredTime == value)
				{
					return;
				}
				_extendedDeathDelayRegisteredTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("disableDismembermentAfterDeathDelay")] 
		public CFloat DisableDismembermentAfterDeathDelay
		{
			get
			{
				if (_disableDismembermentAfterDeathDelay == null)
				{
					_disableDismembermentAfterDeathDelay = (CFloat) CR2WTypeManager.Create("Float", "disableDismembermentAfterDeathDelay", cr2w, this);
				}
				return _disableDismembermentAfterDeathDelay;
			}
			set
			{
				if (_disableDismembermentAfterDeathDelay == value)
				{
					return;
				}
				_disableDismembermentAfterDeathDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("extendedHitReactionRegisteredTime")] 
		public CFloat ExtendedHitReactionRegisteredTime
		{
			get
			{
				if (_extendedHitReactionRegisteredTime == null)
				{
					_extendedHitReactionRegisteredTime = (CFloat) CR2WTypeManager.Create("Float", "extendedHitReactionRegisteredTime", cr2w, this);
				}
				return _extendedHitReactionRegisteredTime;
			}
			set
			{
				if (_extendedHitReactionRegisteredTime == value)
				{
					return;
				}
				_extendedHitReactionRegisteredTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("extendedHitReactionDelayRegisteredTime")] 
		public CFloat ExtendedHitReactionDelayRegisteredTime
		{
			get
			{
				if (_extendedHitReactionDelayRegisteredTime == null)
				{
					_extendedHitReactionDelayRegisteredTime = (CFloat) CR2WTypeManager.Create("Float", "extendedHitReactionDelayRegisteredTime", cr2w, this);
				}
				return _extendedHitReactionDelayRegisteredTime;
			}
			set
			{
				if (_extendedHitReactionDelayRegisteredTime == value)
				{
					return;
				}
				_extendedHitReactionDelayRegisteredTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("scatteredGuts")] 
		public CBool ScatteredGuts
		{
			get
			{
				if (_scatteredGuts == null)
				{
					_scatteredGuts = (CBool) CR2WTypeManager.Create("Bool", "scatteredGuts", cr2w, this);
				}
				return _scatteredGuts;
			}
			set
			{
				if (_scatteredGuts == value)
				{
					return;
				}
				_scatteredGuts = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("cumulativeDamageUpdateInterval")] 
		public CFloat CumulativeDamageUpdateInterval
		{
			get
			{
				if (_cumulativeDamageUpdateInterval == null)
				{
					_cumulativeDamageUpdateInterval = (CFloat) CR2WTypeManager.Create("Float", "cumulativeDamageUpdateInterval", cr2w, this);
				}
				return _cumulativeDamageUpdateInterval;
			}
			set
			{
				if (_cumulativeDamageUpdateInterval == value)
				{
					return;
				}
				_cumulativeDamageUpdateInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("cumulativeDamageUpdateRequested")] 
		public CBool CumulativeDamageUpdateRequested
		{
			get
			{
				if (_cumulativeDamageUpdateRequested == null)
				{
					_cumulativeDamageUpdateRequested = (CBool) CR2WTypeManager.Create("Bool", "cumulativeDamageUpdateRequested", cr2w, this);
				}
				return _cumulativeDamageUpdateRequested;
			}
			set
			{
				if (_cumulativeDamageUpdateRequested == value)
				{
					return;
				}
				_cumulativeDamageUpdateRequested = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("currentStimId")] 
		public CUInt32 CurrentStimId
		{
			get
			{
				if (_currentStimId == null)
				{
					_currentStimId = (CUInt32) CR2WTypeManager.Create("Uint32", "currentStimId", cr2w, this);
				}
				return _currentStimId;
			}
			set
			{
				if (_currentStimId == value)
				{
					return;
				}
				_currentStimId = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get
			{
				if (_attackData == null)
				{
					_attackData = (CHandle<gamedamageAttackData>) CR2WTypeManager.Create("handle:gamedamageAttackData", "attackData", cr2w, this);
				}
				return _attackData;
			}
			set
			{
				if (_attackData == value)
				{
					return;
				}
				_attackData = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "hitPosition", cr2w, this);
				}
				return _hitPosition;
			}
			set
			{
				if (_hitPosition == value)
				{
					return;
				}
				_hitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (Vector4) CR2WTypeManager.Create("Vector4", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("lastHitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData
		{
			get
			{
				if (_lastHitReactionBehaviorData == null)
				{
					_lastHitReactionBehaviorData = (CHandle<HitReactionBehaviorData>) CR2WTypeManager.Create("handle:HitReactionBehaviorData", "lastHitReactionBehaviorData", cr2w, this);
				}
				return _lastHitReactionBehaviorData;
			}
			set
			{
				if (_lastHitReactionBehaviorData == value)
				{
					return;
				}
				_lastHitReactionBehaviorData = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("lastStimName")] 
		public CName LastStimName
		{
			get
			{
				if (_lastStimName == null)
				{
					_lastStimName = (CName) CR2WTypeManager.Create("CName", "lastStimName", cr2w, this);
				}
				return _lastStimName;
			}
			set
			{
				if (_lastStimName == value)
				{
					return;
				}
				_lastStimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
		[RED("deathStimName")] 
		public CName DeathStimName
		{
			get
			{
				if (_deathStimName == null)
				{
					_deathStimName = (CName) CR2WTypeManager.Create("CName", "deathStimName", cr2w, this);
				}
				return _deathStimName;
			}
			set
			{
				if (_deathStimName == value)
				{
					return;
				}
				_deathStimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(67)] 
		[RED("meleeHitCount")] 
		public CInt32 MeleeHitCount
		{
			get
			{
				if (_meleeHitCount == null)
				{
					_meleeHitCount = (CInt32) CR2WTypeManager.Create("Int32", "meleeHitCount", cr2w, this);
				}
				return _meleeHitCount;
			}
			set
			{
				if (_meleeHitCount == value)
				{
					return;
				}
				_meleeHitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(68)] 
		[RED("strongMeleeHitCount")] 
		public CInt32 StrongMeleeHitCount
		{
			get
			{
				if (_strongMeleeHitCount == null)
				{
					_strongMeleeHitCount = (CInt32) CR2WTypeManager.Create("Int32", "strongMeleeHitCount", cr2w, this);
				}
				return _strongMeleeHitCount;
			}
			set
			{
				if (_strongMeleeHitCount == value)
				{
					return;
				}
				_strongMeleeHitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(69)] 
		[RED("maxHitChain")] 
		public CInt32 MaxHitChain
		{
			get
			{
				if (_maxHitChain == null)
				{
					_maxHitChain = (CInt32) CR2WTypeManager.Create("Int32", "maxHitChain", cr2w, this);
				}
				return _maxHitChain;
			}
			set
			{
				if (_maxHitChain == value)
				{
					return;
				}
				_maxHitChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get
			{
				if (_isAlive == null)
				{
					_isAlive = (CBool) CR2WTypeManager.Create("Bool", "isAlive", cr2w, this);
				}
				return _isAlive;
			}
			set
			{
				if (_isAlive == value)
				{
					return;
				}
				_isAlive = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("frameDamageHealthFactor")] 
		public CFloat FrameDamageHealthFactor
		{
			get
			{
				if (_frameDamageHealthFactor == null)
				{
					_frameDamageHealthFactor = (CFloat) CR2WTypeManager.Create("Float", "frameDamageHealthFactor", cr2w, this);
				}
				return _frameDamageHealthFactor;
			}
			set
			{
				if (_frameDamageHealthFactor == value)
				{
					return;
				}
				_frameDamageHealthFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("hitCountData", 100)] 
		public CArrayFixedSize<CFloat> HitCountData
		{
			get
			{
				if (_hitCountData == null)
				{
					_hitCountData = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[100]Float", "hitCountData", cr2w, this);
				}
				return _hitCountData;
			}
			set
			{
				if (_hitCountData == value)
				{
					return;
				}
				_hitCountData = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("hitCountArrayEnd")] 
		public CInt32 HitCountArrayEnd
		{
			get
			{
				if (_hitCountArrayEnd == null)
				{
					_hitCountArrayEnd = (CInt32) CR2WTypeManager.Create("Int32", "hitCountArrayEnd", cr2w, this);
				}
				return _hitCountArrayEnd;
			}
			set
			{
				if (_hitCountArrayEnd == value)
				{
					return;
				}
				_hitCountArrayEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("hitCountArrayCurrent")] 
		public CInt32 HitCountArrayCurrent
		{
			get
			{
				if (_hitCountArrayCurrent == null)
				{
					_hitCountArrayCurrent = (CInt32) CR2WTypeManager.Create("Int32", "hitCountArrayCurrent", cr2w, this);
				}
				return _hitCountArrayCurrent;
			}
			set
			{
				if (_hitCountArrayCurrent == value)
				{
					return;
				}
				_hitCountArrayCurrent = value;
				PropertySet(this);
			}
		}

		[Ordinal(75)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CUInt32 IndicatorEnabledBlackboardId
		{
			get
			{
				if (_indicatorEnabledBlackboardId == null)
				{
					_indicatorEnabledBlackboardId = (CUInt32) CR2WTypeManager.Create("Uint32", "indicatorEnabledBlackboardId", cr2w, this);
				}
				return _indicatorEnabledBlackboardId;
			}
			set
			{
				if (_indicatorEnabledBlackboardId == value)
				{
					return;
				}
				_indicatorEnabledBlackboardId = value;
				PropertySet(this);
			}
		}

		[Ordinal(76)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get
			{
				if (_hitIndicatorEnabled == null)
				{
					_hitIndicatorEnabled = (CBool) CR2WTypeManager.Create("Bool", "hitIndicatorEnabled", cr2w, this);
				}
				return _hitIndicatorEnabled;
			}
			set
			{
				if (_hitIndicatorEnabled == value)
				{
					return;
				}
				_hitIndicatorEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(77)] 
		[RED("hasBeenWounded")] 
		public CBool HasBeenWounded
		{
			get
			{
				if (_hasBeenWounded == null)
				{
					_hasBeenWounded = (CBool) CR2WTypeManager.Create("Bool", "hasBeenWounded", cr2w, this);
				}
				return _hasBeenWounded;
			}
			set
			{
				if (_hasBeenWounded == value)
				{
					return;
				}
				_hasBeenWounded = value;
				PropertySet(this);
			}
		}

		[Ordinal(78)] 
		[RED("hitReactionData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitReactionData
		{
			get
			{
				if (_hitReactionData == null)
				{
					_hitReactionData = (CHandle<animAnimFeature_HitReactionsData>) CR2WTypeManager.Create("handle:animAnimFeature_HitReactionsData", "hitReactionData", cr2w, this);
				}
				return _hitReactionData;
			}
			set
			{
				if (_hitReactionData == value)
				{
					return;
				}
				_hitReactionData = value;
				PropertySet(this);
			}
		}

		public HitReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
