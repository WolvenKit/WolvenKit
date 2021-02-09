using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponent : AICAgent
	{
		[Ordinal(0)]  [RED("movementParamsRecord")] public TweakDBID MovementParamsRecord { get; set; }
		[Ordinal(1)]  [RED("shootingBlackboard")] public CHandle<gameIBlackboard> ShootingBlackboard { get; set; }
		[Ordinal(2)]  [RED("gadgetBlackboard")] public CHandle<gameIBlackboard> GadgetBlackboard { get; set; }
		[Ordinal(3)]  [RED("coverBlackboard")] public CHandle<gameIBlackboard> CoverBlackboard { get; set; }
		[Ordinal(4)]  [RED("actionBlackboard")] public CHandle<gameIBlackboard> ActionBlackboard { get; set; }
		[Ordinal(5)]  [RED("patrolBlackboard")] public CHandle<gameIBlackboard> PatrolBlackboard { get; set; }
		[Ordinal(6)]  [RED("alertedPatrolBlackboard")] public CHandle<gameIBlackboard> AlertedPatrolBlackboard { get; set; }
		[Ordinal(7)]  [RED("friendlyFireCheckID")] public CUInt32 FriendlyFireCheckID { get; set; }
		[Ordinal(8)]  [RED("ffs")] public CHandle<gameIFriendlyFireSystem> Ffs { get; set; }
		[Ordinal(9)]  [RED("LoSFinderCheckID")] public CUInt32 LoSFinderCheckID { get; set; }
		[Ordinal(10)]  [RED("loSFinderSystem")] public CHandle<gameLoSIFinderSystem> LoSFinderSystem { get; set; }
		[Ordinal(11)]  [RED("LoSFinderVisibleObject")] public wCHandle<senseVisibleObject> LoSFinderVisibleObject { get; set; }
		[Ordinal(12)]  [RED("actionAnimationScriptProxy")] public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy { get; set; }
		[Ordinal(13)]  [RED("lastOwnerBlockedAttackEventID")] public gameDelayID LastOwnerBlockedAttackEventID { get; set; }
		[Ordinal(14)]  [RED("lastOwnerParriedAttackEventID")] public gameDelayID LastOwnerParriedAttackEventID { get; set; }
		[Ordinal(15)]  [RED("lastOwnerDodgedAttackEventID")] public gameDelayID LastOwnerDodgedAttackEventID { get; set; }
		[Ordinal(16)]  [RED("grenadeThrowQueryTarget")] public wCHandle<gameObject> GrenadeThrowQueryTarget { get; set; }
		[Ordinal(17)]  [RED("grenadeThrowQueryId")] public CInt32 GrenadeThrowQueryId { get; set; }
		[Ordinal(18)]  [RED("scriptContext")] public AIbehaviorScriptExecutionContext ScriptContext { get; set; }
		[Ordinal(19)]  [RED("scriptContextInitialized")] public CBool ScriptContextInitialized { get; set; }
		[Ordinal(20)]  [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(21)]  [RED("activeCommands")] public AIbehaviorUniqueActiveCommandList ActiveCommands { get; set; }

		public AIHumanComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
