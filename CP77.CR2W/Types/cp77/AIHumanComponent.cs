using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIHumanComponent : AICAgent
	{
		[Ordinal(0)]  [RED("LoSFinderCheckID")] public CUInt32 LoSFinderCheckID { get; set; }
		[Ordinal(1)]  [RED("LoSFinderVisibleObject")] public wCHandle<senseVisibleObject> LoSFinderVisibleObject { get; set; }
		[Ordinal(2)]  [RED("actionAnimationScriptProxy")] public CHandle<ActionAnimationScriptProxy> ActionAnimationScriptProxy { get; set; }
		[Ordinal(3)]  [RED("actionBlackboard")] public CHandle<gameIBlackboard> ActionBlackboard { get; set; }
		[Ordinal(4)]  [RED("activeCommands")] public AIbehaviorUniqueActiveCommandList ActiveCommands { get; set; }
		[Ordinal(5)]  [RED("alertedPatrolBlackboard")] public CHandle<gameIBlackboard> AlertedPatrolBlackboard { get; set; }
		[Ordinal(6)]  [RED("coverBlackboard")] public CHandle<gameIBlackboard> CoverBlackboard { get; set; }
		[Ordinal(7)]  [RED("ffs")] public CHandle<gameIFriendlyFireSystem> Ffs { get; set; }
		[Ordinal(8)]  [RED("friendlyFireCheckID")] public CUInt32 FriendlyFireCheckID { get; set; }
		[Ordinal(9)]  [RED("gadgetBlackboard")] public CHandle<gameIBlackboard> GadgetBlackboard { get; set; }
		[Ordinal(10)]  [RED("grenadeThrowQueryId")] public CInt32 GrenadeThrowQueryId { get; set; }
		[Ordinal(11)]  [RED("grenadeThrowQueryTarget")] public wCHandle<gameObject> GrenadeThrowQueryTarget { get; set; }
		[Ordinal(12)]  [RED("highLevelCb")] public CUInt32 HighLevelCb { get; set; }
		[Ordinal(13)]  [RED("lastOwnerBlockedAttackEventID")] public gameDelayID LastOwnerBlockedAttackEventID { get; set; }
		[Ordinal(14)]  [RED("lastOwnerDodgedAttackEventID")] public gameDelayID LastOwnerDodgedAttackEventID { get; set; }
		[Ordinal(15)]  [RED("lastOwnerParriedAttackEventID")] public gameDelayID LastOwnerParriedAttackEventID { get; set; }
		[Ordinal(16)]  [RED("loSFinderSystem")] public CHandle<gameLoSIFinderSystem> LoSFinderSystem { get; set; }
		[Ordinal(17)]  [RED("movementParamsRecord")] public TweakDBID MovementParamsRecord { get; set; }
		[Ordinal(18)]  [RED("patrolBlackboard")] public CHandle<gameIBlackboard> PatrolBlackboard { get; set; }
		[Ordinal(19)]  [RED("scriptContext")] public AIbehaviorScriptExecutionContext ScriptContext { get; set; }
		[Ordinal(20)]  [RED("scriptContextInitialized")] public CBool ScriptContextInitialized { get; set; }
		[Ordinal(21)]  [RED("shootingBlackboard")] public CHandle<gameIBlackboard> ShootingBlackboard { get; set; }

		public AIHumanComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
