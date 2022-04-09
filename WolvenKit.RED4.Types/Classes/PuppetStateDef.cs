using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PuppetStateDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("BehaviorState")] 
		public gamebbScriptID_Int32 BehaviorState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("PhaseState")] 
		public gamebbScriptID_Int32 PhaseState
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("Stance")] 
		public gamebbScriptID_Int32 Stance
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(5)] 
		[RED("HitReactionMode")] 
		public gamebbScriptID_Int32 HitReactionMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("DefenseMode")] 
		public gamebbScriptID_Int32 DefenseMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("LocomotionMode")] 
		public gamebbScriptID_Int32 LocomotionMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("WeakSpots")] 
		public gamebbScriptID_Int32 WeakSpots
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(9)] 
		[RED("ReactionBehavior")] 
		public gamebbScriptID_Int32 ReactionBehavior
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("ForceRagdollOnDeath")] 
		public gamebbScriptID_Bool ForceRagdollOnDeath
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(11)] 
		[RED("InExclusiveAction")] 
		public gamebbScriptID_Bool InExclusiveAction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(12)] 
		[RED("SlotAnimationInProgress")] 
		public gamebbScriptID_Bool SlotAnimationInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(13)] 
		[RED("WorkspotAnimationInProgress")] 
		public gamebbScriptID_Bool WorkspotAnimationInProgress
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("InAirAnimation")] 
		public gamebbScriptID_Bool InAirAnimation
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(15)] 
		[RED("InPendingBehavior")] 
		public gamebbScriptID_Bool InPendingBehavior
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("HasCalledReinforcements")] 
		public gamebbScriptID_Bool HasCalledReinforcements
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(17)] 
		[RED("IsBodyDisposed")] 
		public gamebbScriptID_Bool IsBodyDisposed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(18)] 
		[RED("DetectionPercentage")] 
		public gamebbScriptID_Float DetectionPercentage
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		public PuppetStateDef()
		{
			HighLevel = new();
			UpperBody = new();
			BehaviorState = new();
			PhaseState = new();
			Stance = new();
			HitReactionMode = new();
			DefenseMode = new();
			LocomotionMode = new();
			WeakSpots = new();
			ReactionBehavior = new();
			ForceRagdollOnDeath = new();
			InExclusiveAction = new();
			SlotAnimationInProgress = new();
			WorkspotAnimationInProgress = new();
			InAirAnimation = new();
			InPendingBehavior = new();
			HasCalledReinforcements = new();
			IsBodyDisposed = new();
			DetectionPercentage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
