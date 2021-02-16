using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIAnimMoveOnSplineCommand : AIMoveCommand
	{
		[Ordinal(7)] [RED("spline")] public NodeRef Spline { get; set; }
		[Ordinal(8)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(9)] [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(10)] [RED("controllerSetupName")] public CName ControllerSetupName { get; set; }
		[Ordinal(11)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(12)] [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(13)] [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(14)] [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(15)] [RED("customStartAnimationName")] public CName CustomStartAnimationName { get; set; }
		[Ordinal(16)] [RED("customMainAnimationName")] public CName CustomMainAnimationName { get; set; }
		[Ordinal(17)] [RED("customStopAnimationName")] public CName CustomStopAnimationName { get; set; }
		[Ordinal(18)] [RED("startSnapToTerrain")] public CBool StartSnapToTerrain { get; set; }
		[Ordinal(19)] [RED("mainSnapToTerrain")] public CBool MainSnapToTerrain { get; set; }
		[Ordinal(20)] [RED("stopSnapToTerrain")] public CBool StopSnapToTerrain { get; set; }
		[Ordinal(21)] [RED("startSnapToTerrainBlendTime")] public CFloat StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(22)] [RED("stopSnapToTerrainBlendTime")] public CFloat StopSnapToTerrainBlendTime { get; set; }

		public AIAnimMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
