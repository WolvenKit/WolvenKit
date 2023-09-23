using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIHumanComponent : AICAgent
	{
		[Ordinal(4)] 
		[RED("movementParamsRecord")] 
		public TweakDBID MovementParamsRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("shootingBlackboard")] 
		public CWeakHandle<gameIBlackboard> ShootingBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("gadgetBlackboard")] 
		public CWeakHandle<gameIBlackboard> GadgetBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("coverBlackboard")] 
		public CWeakHandle<gameIBlackboard> CoverBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(8)] 
		[RED("actionBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActionBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(9)] 
		[RED("patrolBlackboard")] 
		public CWeakHandle<gameIBlackboard> PatrolBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("alertedPatrolBlackboard")] 
		public CWeakHandle<gameIBlackboard> AlertedPatrolBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("prereqsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PrereqsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("friendlyFireCheckID")] 
		public CUInt32 FriendlyFireCheckID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("ffs")] 
		public CHandle<gameIFriendlyFireSystem> Ffs
		{
			get => GetPropertyValue<CHandle<gameIFriendlyFireSystem>>();
			set => SetPropertyValue<CHandle<gameIFriendlyFireSystem>>(value);
		}

		[Ordinal(14)] 
		[RED("LoSFinderCheckID")] 
		public CUInt32 LoSFinderCheckID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(15)] 
		[RED("loSFinderSystem")] 
		public CHandle<gameLoSIFinderSystem> LoSFinderSystem
		{
			get => GetPropertyValue<CHandle<gameLoSIFinderSystem>>();
			set => SetPropertyValue<CHandle<gameLoSIFinderSystem>>(value);
		}

		[Ordinal(16)] 
		[RED("LoSFinderVisibleObject")] 
		public CWeakHandle<senseVisibleObject> LoSFinderVisibleObject
		{
			get => GetPropertyValue<CWeakHandle<senseVisibleObject>>();
			set => SetPropertyValue<CWeakHandle<senseVisibleObject>>(value);
		}

		[Ordinal(17)] 
		[RED("actionAnimationScriptProxy")] 
		public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy
		{
			get => GetPropertyValue<CHandle<ActionAnimationScriptProxy>>();
			set => SetPropertyValue<CHandle<ActionAnimationScriptProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("lastOwnerBlockedAttackEventID")] 
		public gameDelayID LastOwnerBlockedAttackEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(19)] 
		[RED("lastOwnerParriedAttackEventID")] 
		public gameDelayID LastOwnerParriedAttackEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(20)] 
		[RED("lastOwnerDodgedAttackEventID")] 
		public gameDelayID LastOwnerDodgedAttackEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(21)] 
		[RED("grenadeThrowQueryTarget")] 
		public CWeakHandle<gameObject> GrenadeThrowQueryTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(22)] 
		[RED("grenadeThrowQueryId")] 
		public CInt32 GrenadeThrowQueryId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("scriptContext")] 
		public AIbehaviorScriptExecutionContext ScriptContext
		{
			get => GetPropertyValue<AIbehaviorScriptExecutionContext>();
			set => SetPropertyValue<AIbehaviorScriptExecutionContext>(value);
		}

		[Ordinal(24)] 
		[RED("scriptContextInitialized")] 
		public CBool ScriptContextInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("kerenzikovAbilityRecord")] 
		public CHandle<gamedataGameplayAbility_Record> KerenzikovAbilityRecord
		{
			get => GetPropertyValue<CHandle<gamedataGameplayAbility_Record>>();
			set => SetPropertyValue<CHandle<gamedataGameplayAbility_Record>>(value);
		}

		[Ordinal(26)] 
		[RED("highLevelCb")] 
		public CUInt32 HighLevelCb
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(27)] 
		[RED("lastReservedSeatVehicle")] 
		public entEntityID LastReservedSeatVehicle
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(28)] 
		[RED("assignedVehicleStuck")] 
		public CBool AssignedVehicleStuck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("activeCommands")] 
		public AIbehaviorUniqueActiveCommandList ActiveCommands
		{
			get => GetPropertyValue<AIbehaviorUniqueActiveCommandList>();
			set => SetPropertyValue<AIbehaviorUniqueActiveCommandList>(value);
		}

		public AIHumanComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
