using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAnimMoveOnSplineParams : CVariable
	{
		[Ordinal(0)] [RED("controllersSetupName")] public CName ControllersSetupName { get; set; }
		[Ordinal(1)] [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(2)] [RED("globalInBlendTime")] public CFloat GlobalInBlendTime { get; set; }
		[Ordinal(3)] [RED("globalOutBlendTime")] public CFloat GlobalOutBlendTime { get; set; }
		[Ordinal(4)] [RED("turnCharacterToMatchVelocity")] public CBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(5)] [RED("customStartAnimationName")] public CName CustomStartAnimationName { get; set; }
		[Ordinal(6)] [RED("customMainAnimationName")] public CName CustomMainAnimationName { get; set; }
		[Ordinal(7)] [RED("customStopAnimationName")] public CName CustomStopAnimationName { get; set; }
		[Ordinal(8)] [RED("startSnapToTerrain")] public CBool StartSnapToTerrain { get; set; }
		[Ordinal(9)] [RED("mainSnapToTerrain")] public CBool MainSnapToTerrain { get; set; }
		[Ordinal(10)] [RED("stopSnapToTerrain")] public CBool StopSnapToTerrain { get; set; }
		[Ordinal(11)] [RED("startSnapToTerrainBlendTime")] public CFloat StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(12)] [RED("stopSnapToTerrainBlendTime")] public CFloat StopSnapToTerrainBlendTime { get; set; }

		public questAnimMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
