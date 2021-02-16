using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSplineParams : questAICommandParams
	{
		[Ordinal(0)] [RED("splineNodeRef")] public NodeRef SplineNodeRef { get; set; }
		[Ordinal(1)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(2)] [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(3)] [RED("reverse")] public CBool Reverse { get; set; }
		[Ordinal(4)] [RED("startFromClosestPoint")] public CBool StartFromClosestPoint { get; set; }
		[Ordinal(5)] [RED("additionalParams")] public CHandle<questMoveOnSplineAdditionalParams> AdditionalParams { get; set; }
		[Ordinal(6)] [RED("useAlertedState")] public CBool UseAlertedState { get; set; }
		[Ordinal(7)] [RED("useCombatState")] public CBool UseCombatState { get; set; }
		[Ordinal(8)] [RED("executeWhileDespawned")] public CBool ExecuteWhileDespawned { get; set; }
		[Ordinal(9)] [RED("repeatCommandOnInterrupt")] public CBool RepeatCommandOnInterrupt { get; set; }
		[Ordinal(10)] [RED("noWaitToEndDistance")] public CFloat NoWaitToEndDistance { get; set; }
		[Ordinal(11)] [RED("noWaitToEndCompanionDistance")] public CFloat NoWaitToEndCompanionDistance { get; set; }
		[Ordinal(12)] [RED("removeAfterCombat")] public CBool RemoveAfterCombat { get; set; }
		[Ordinal(13)] [RED("ignoreInCombat")] public CBool IgnoreInCombat { get; set; }
		[Ordinal(14)] [RED("alwaysUseStealth")] public CBool AlwaysUseStealth { get; set; }

		public questMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
