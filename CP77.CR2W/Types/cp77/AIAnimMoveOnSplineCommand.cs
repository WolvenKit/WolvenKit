using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIAnimMoveOnSplineCommand : AIMoveCommand
	{
		[Ordinal(0)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(1)]  [RED("controllerSetupName")] public CName ControllerSetupName { get; set; }
		[Ordinal(2)]  [RED("customMainAnimationName")] public CName CustomMainAnimationName { get; set; }
		[Ordinal(3)]  [RED("customStartAnimationName")] public CName CustomStartAnimationName { get; set; }
		[Ordinal(4)]  [RED("customStopAnimationName")] public CName CustomStopAnimationName { get; set; }
		[Ordinal(5)]  [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(6)]  [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(7)]  [RED("mainSnapToTerrain")] public CBool MainSnapToTerrain { get; set; }
		[Ordinal(8)]  [RED("spline")] public NodeRef Spline { get; set; }
		[Ordinal(9)]  [RED("startSnapToTerrain")] public CBool StartSnapToTerrain { get; set; }
		[Ordinal(10)]  [RED("startSnapToTerrainBlendTime")] public CFloat StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(11)]  [RED("stopSnapToTerrain")] public CBool StopSnapToTerrain { get; set; }
		[Ordinal(12)]  [RED("stopSnapToTerrainBlendTime")] public CFloat StopSnapToTerrainBlendTime { get; set; }
		[Ordinal(13)]  [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(14)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(15)]  [RED("useStop")] public CBool UseStop { get; set; }

		public AIAnimMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
