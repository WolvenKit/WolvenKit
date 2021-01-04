using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetStateDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("BehaviorState")] public gamebbScriptID_Int32 BehaviorState { get; set; }
		[Ordinal(1)]  [RED("DefenseMode")] public gamebbScriptID_Int32 DefenseMode { get; set; }
		[Ordinal(2)]  [RED("DetectionPercentage")] public gamebbScriptID_Float DetectionPercentage { get; set; }
		[Ordinal(3)]  [RED("ForceRagdollOnDeath")] public gamebbScriptID_Bool ForceRagdollOnDeath { get; set; }
		[Ordinal(4)]  [RED("HasCalledReinforcements")] public gamebbScriptID_Bool HasCalledReinforcements { get; set; }
		[Ordinal(5)]  [RED("HighLevel")] public gamebbScriptID_Int32 HighLevel { get; set; }
		[Ordinal(6)]  [RED("HitReactionMode")] public gamebbScriptID_Int32 HitReactionMode { get; set; }
		[Ordinal(7)]  [RED("InExclusiveAction")] public gamebbScriptID_Bool InExclusiveAction { get; set; }
		[Ordinal(8)]  [RED("InPendingBehavior")] public gamebbScriptID_Bool InPendingBehavior { get; set; }
		[Ordinal(9)]  [RED("LocomotionMode")] public gamebbScriptID_Int32 LocomotionMode { get; set; }
		[Ordinal(10)]  [RED("PhaseState")] public gamebbScriptID_Int32 PhaseState { get; set; }
		[Ordinal(11)]  [RED("ReactionBehavior")] public gamebbScriptID_Int32 ReactionBehavior { get; set; }
		[Ordinal(12)]  [RED("SlotAnimationInProgress")] public gamebbScriptID_Bool SlotAnimationInProgress { get; set; }
		[Ordinal(13)]  [RED("Stance")] public gamebbScriptID_Int32 Stance { get; set; }
		[Ordinal(14)]  [RED("UpperBody")] public gamebbScriptID_Int32 UpperBody { get; set; }
		[Ordinal(15)]  [RED("WeakSpots")] public gamebbScriptID_Int32 WeakSpots { get; set; }

		public PuppetStateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
