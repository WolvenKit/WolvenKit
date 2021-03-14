using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetStateDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _highLevel;
		private gamebbScriptID_Int32 _upperBody;
		private gamebbScriptID_Int32 _behaviorState;
		private gamebbScriptID_Int32 _phaseState;
		private gamebbScriptID_Int32 _stance;
		private gamebbScriptID_Int32 _hitReactionMode;
		private gamebbScriptID_Int32 _defenseMode;
		private gamebbScriptID_Int32 _locomotionMode;
		private gamebbScriptID_Int32 _weakSpots;
		private gamebbScriptID_Int32 _reactionBehavior;
		private gamebbScriptID_Bool _forceRagdollOnDeath;
		private gamebbScriptID_Bool _inExclusiveAction;
		private gamebbScriptID_Bool _slotAnimationInProgress;
		private gamebbScriptID_Bool _inPendingBehavior;
		private gamebbScriptID_Bool _hasCalledReinforcements;
		private gamebbScriptID_Float _detectionPercentage;

		[Ordinal(0)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get
			{
				if (_highLevel == null)
				{
					_highLevel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "HighLevel", cr2w, this);
				}
				return _highLevel;
			}
			set
			{
				if (_highLevel == value)
				{
					return;
				}
				_highLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get
			{
				if (_upperBody == null)
				{
					_upperBody = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "UpperBody", cr2w, this);
				}
				return _upperBody;
			}
			set
			{
				if (_upperBody == value)
				{
					return;
				}
				_upperBody = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BehaviorState")] 
		public gamebbScriptID_Int32 BehaviorState
		{
			get
			{
				if (_behaviorState == null)
				{
					_behaviorState = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "BehaviorState", cr2w, this);
				}
				return _behaviorState;
			}
			set
			{
				if (_behaviorState == value)
				{
					return;
				}
				_behaviorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PhaseState")] 
		public gamebbScriptID_Int32 PhaseState
		{
			get
			{
				if (_phaseState == null)
				{
					_phaseState = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "PhaseState", cr2w, this);
				}
				return _phaseState;
			}
			set
			{
				if (_phaseState == value)
				{
					return;
				}
				_phaseState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("Stance")] 
		public gamebbScriptID_Int32 Stance
		{
			get
			{
				if (_stance == null)
				{
					_stance = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Stance", cr2w, this);
				}
				return _stance;
			}
			set
			{
				if (_stance == value)
				{
					return;
				}
				_stance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("HitReactionMode")] 
		public gamebbScriptID_Int32 HitReactionMode
		{
			get
			{
				if (_hitReactionMode == null)
				{
					_hitReactionMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "HitReactionMode", cr2w, this);
				}
				return _hitReactionMode;
			}
			set
			{
				if (_hitReactionMode == value)
				{
					return;
				}
				_hitReactionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("DefenseMode")] 
		public gamebbScriptID_Int32 DefenseMode
		{
			get
			{
				if (_defenseMode == null)
				{
					_defenseMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "DefenseMode", cr2w, this);
				}
				return _defenseMode;
			}
			set
			{
				if (_defenseMode == value)
				{
					return;
				}
				_defenseMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("LocomotionMode")] 
		public gamebbScriptID_Int32 LocomotionMode
		{
			get
			{
				if (_locomotionMode == null)
				{
					_locomotionMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "LocomotionMode", cr2w, this);
				}
				return _locomotionMode;
			}
			set
			{
				if (_locomotionMode == value)
				{
					return;
				}
				_locomotionMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("WeakSpots")] 
		public gamebbScriptID_Int32 WeakSpots
		{
			get
			{
				if (_weakSpots == null)
				{
					_weakSpots = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "WeakSpots", cr2w, this);
				}
				return _weakSpots;
			}
			set
			{
				if (_weakSpots == value)
				{
					return;
				}
				_weakSpots = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ReactionBehavior")] 
		public gamebbScriptID_Int32 ReactionBehavior
		{
			get
			{
				if (_reactionBehavior == null)
				{
					_reactionBehavior = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ReactionBehavior", cr2w, this);
				}
				return _reactionBehavior;
			}
			set
			{
				if (_reactionBehavior == value)
				{
					return;
				}
				_reactionBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ForceRagdollOnDeath")] 
		public gamebbScriptID_Bool ForceRagdollOnDeath
		{
			get
			{
				if (_forceRagdollOnDeath == null)
				{
					_forceRagdollOnDeath = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ForceRagdollOnDeath", cr2w, this);
				}
				return _forceRagdollOnDeath;
			}
			set
			{
				if (_forceRagdollOnDeath == value)
				{
					return;
				}
				_forceRagdollOnDeath = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("InExclusiveAction")] 
		public gamebbScriptID_Bool InExclusiveAction
		{
			get
			{
				if (_inExclusiveAction == null)
				{
					_inExclusiveAction = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "InExclusiveAction", cr2w, this);
				}
				return _inExclusiveAction;
			}
			set
			{
				if (_inExclusiveAction == value)
				{
					return;
				}
				_inExclusiveAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("SlotAnimationInProgress")] 
		public gamebbScriptID_Bool SlotAnimationInProgress
		{
			get
			{
				if (_slotAnimationInProgress == null)
				{
					_slotAnimationInProgress = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SlotAnimationInProgress", cr2w, this);
				}
				return _slotAnimationInProgress;
			}
			set
			{
				if (_slotAnimationInProgress == value)
				{
					return;
				}
				_slotAnimationInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("InPendingBehavior")] 
		public gamebbScriptID_Bool InPendingBehavior
		{
			get
			{
				if (_inPendingBehavior == null)
				{
					_inPendingBehavior = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "InPendingBehavior", cr2w, this);
				}
				return _inPendingBehavior;
			}
			set
			{
				if (_inPendingBehavior == value)
				{
					return;
				}
				_inPendingBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("HasCalledReinforcements")] 
		public gamebbScriptID_Bool HasCalledReinforcements
		{
			get
			{
				if (_hasCalledReinforcements == null)
				{
					_hasCalledReinforcements = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "HasCalledReinforcements", cr2w, this);
				}
				return _hasCalledReinforcements;
			}
			set
			{
				if (_hasCalledReinforcements == value)
				{
					return;
				}
				_hasCalledReinforcements = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("DetectionPercentage")] 
		public gamebbScriptID_Float DetectionPercentage
		{
			get
			{
				if (_detectionPercentage == null)
				{
					_detectionPercentage = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "DetectionPercentage", cr2w, this);
				}
				return _detectionPercentage;
			}
			set
			{
				if (_detectionPercentage == value)
				{
					return;
				}
				_detectionPercentage = value;
				PropertySet(this);
			}
		}

		public PuppetStateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
