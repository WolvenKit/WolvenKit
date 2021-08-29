using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetStateDef : gamebbScriptDefinition
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
		private gamebbScriptID_Bool _isBodyDisposed;
		private gamebbScriptID_Float _detectionPercentage;

		[Ordinal(0)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get => GetProperty(ref _highLevel);
			set => SetProperty(ref _highLevel, value);
		}

		[Ordinal(1)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get => GetProperty(ref _upperBody);
			set => SetProperty(ref _upperBody, value);
		}

		[Ordinal(2)] 
		[RED("BehaviorState")] 
		public gamebbScriptID_Int32 BehaviorState
		{
			get => GetProperty(ref _behaviorState);
			set => SetProperty(ref _behaviorState, value);
		}

		[Ordinal(3)] 
		[RED("PhaseState")] 
		public gamebbScriptID_Int32 PhaseState
		{
			get => GetProperty(ref _phaseState);
			set => SetProperty(ref _phaseState, value);
		}

		[Ordinal(4)] 
		[RED("Stance")] 
		public gamebbScriptID_Int32 Stance
		{
			get => GetProperty(ref _stance);
			set => SetProperty(ref _stance, value);
		}

		[Ordinal(5)] 
		[RED("HitReactionMode")] 
		public gamebbScriptID_Int32 HitReactionMode
		{
			get => GetProperty(ref _hitReactionMode);
			set => SetProperty(ref _hitReactionMode, value);
		}

		[Ordinal(6)] 
		[RED("DefenseMode")] 
		public gamebbScriptID_Int32 DefenseMode
		{
			get => GetProperty(ref _defenseMode);
			set => SetProperty(ref _defenseMode, value);
		}

		[Ordinal(7)] 
		[RED("LocomotionMode")] 
		public gamebbScriptID_Int32 LocomotionMode
		{
			get => GetProperty(ref _locomotionMode);
			set => SetProperty(ref _locomotionMode, value);
		}

		[Ordinal(8)] 
		[RED("WeakSpots")] 
		public gamebbScriptID_Int32 WeakSpots
		{
			get => GetProperty(ref _weakSpots);
			set => SetProperty(ref _weakSpots, value);
		}

		[Ordinal(9)] 
		[RED("ReactionBehavior")] 
		public gamebbScriptID_Int32 ReactionBehavior
		{
			get => GetProperty(ref _reactionBehavior);
			set => SetProperty(ref _reactionBehavior, value);
		}

		[Ordinal(10)] 
		[RED("ForceRagdollOnDeath")] 
		public gamebbScriptID_Bool ForceRagdollOnDeath
		{
			get => GetProperty(ref _forceRagdollOnDeath);
			set => SetProperty(ref _forceRagdollOnDeath, value);
		}

		[Ordinal(11)] 
		[RED("InExclusiveAction")] 
		public gamebbScriptID_Bool InExclusiveAction
		{
			get => GetProperty(ref _inExclusiveAction);
			set => SetProperty(ref _inExclusiveAction, value);
		}

		[Ordinal(12)] 
		[RED("SlotAnimationInProgress")] 
		public gamebbScriptID_Bool SlotAnimationInProgress
		{
			get => GetProperty(ref _slotAnimationInProgress);
			set => SetProperty(ref _slotAnimationInProgress, value);
		}

		[Ordinal(13)] 
		[RED("InPendingBehavior")] 
		public gamebbScriptID_Bool InPendingBehavior
		{
			get => GetProperty(ref _inPendingBehavior);
			set => SetProperty(ref _inPendingBehavior, value);
		}

		[Ordinal(14)] 
		[RED("HasCalledReinforcements")] 
		public gamebbScriptID_Bool HasCalledReinforcements
		{
			get => GetProperty(ref _hasCalledReinforcements);
			set => SetProperty(ref _hasCalledReinforcements, value);
		}

		[Ordinal(15)] 
		[RED("IsBodyDisposed")] 
		public gamebbScriptID_Bool IsBodyDisposed
		{
			get => GetProperty(ref _isBodyDisposed);
			set => SetProperty(ref _isBodyDisposed, value);
		}

		[Ordinal(16)] 
		[RED("DetectionPercentage")] 
		public gamebbScriptID_Float DetectionPercentage
		{
			get => GetProperty(ref _detectionPercentage);
			set => SetProperty(ref _detectionPercentage, value);
		}
	}
}
