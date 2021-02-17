using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponent : AICAgent
	{
		[Ordinal(4)] [RED("movementParamsRecord")] public TweakDBID MovementParamsRecord { get; set; }
		[Ordinal(5)] [RED("shootingBlackboard")] public CHandle<gameIBlackboard> ShootingBlackboard { get; set; }
		[Ordinal(6)] [RED("gadgetBlackboard")] public CHandle<gameIBlackboard> GadgetBlackboard { get; set; }
		[Ordinal(7)] [RED("coverBlackboard")] public CHandle<gameIBlackboard> CoverBlackboard { get; set; }
		[Ordinal(8)] [RED("actionBlackboard")] public CHandle<gameIBlackboard> ActionBlackboard { get; set; }
		[Ordinal(9)] [RED("patrolBlackboard")] public CHandle<gameIBlackboard> PatrolBlackboard { get; set; }
		[Ordinal(10)] [RED("alertedPatrolBlackboard")] public CHandle<gameIBlackboard> AlertedPatrolBlackboard { get; set; }
		[Ordinal(11)] [RED("friendlyFireCheckID")] public CUInt32 FriendlyFireCheckID { get; set; }
		[Ordinal(12)] [RED("ffs")] public CHandle<gameIFriendlyFireSystem> Ffs { get; set; }
		[Ordinal(13)] [RED("LoSFinderCheckID")] public CUInt32 LoSFinderCheckID { get; set; }
		[Ordinal(14)] [RED("loSFinderSystem")] public CHandle<gameLoSIFinderSystem> LoSFinderSystem { get; set; }
		[Ordinal(15)] [RED("LoSFinderVisibleObject")] public wCHandle<senseVisibleObject> LoSFinderVisibleObject { get; set; }
		[Ordinal(16)] [RED("actionAnimationScriptProxy")] public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy { get; set; }
		[Ordinal(17)] [RED("lastOwnerBlockedAttackEventID")] public gameDelayID LastOwnerBlockedAttackEventID { get; set; }
		[Ordinal(18)] [RED("lastOwnerParriedAttackEventID")] public gameDelayID LastOwnerParriedAttackEventID { get; set; }
		[Ordinal(19)] [RED("lastOwnerDodgedAttackEventID")] public gameDelayID LastOwnerDodgedAttackEventID { get; set; }
		[Ordinal(20)] [RED("grenadeThrowQueryTarget")] public wCHandle<gameObject> GrenadeThrowQueryTarget { get; set; }
		[Ordinal(21)] [RED("grenadeThrowQueryId")] public CInt32 GrenadeThrowQueryId { get; set; }
		[Ordinal(22)] [RED("scriptContext")] public AIbehaviorScriptExecutionContext ScriptContext { get; set; }
		[Ordinal(23)] [RED("scriptContextInitialized")] public CBool ScriptContextInitialized { get; set; }
		[Ordinal(24)] [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(25)] [RED("activeCommands")] public AIbehaviorUniqueActiveCommandList ActiveCommands { get; set; }

		public AIHumanComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
