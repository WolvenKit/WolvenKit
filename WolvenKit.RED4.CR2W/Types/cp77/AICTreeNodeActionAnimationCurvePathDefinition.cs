using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionAnimationCurvePathDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] [RED("nodeReference")] public LibTreeDefNodeRef NodeReference { get; set; }
		[Ordinal(2)] [RED("controllersSetupName")] public LibTreeDefCName ControllersSetupName { get; set; }
		[Ordinal(3)] [RED("useStart")] public LibTreeDefBool UseStart { get; set; }
		[Ordinal(4)] [RED("useStop")] public LibTreeDefBool UseStop { get; set; }
		[Ordinal(5)] [RED("blendTime")] public LibTreeDefFloat BlendTime { get; set; }
		[Ordinal(6)] [RED("globalInBlendTime")] public LibTreeDefFloat GlobalInBlendTime { get; set; }
		[Ordinal(7)] [RED("globalOutBlendTime")] public LibTreeDefFloat GlobalOutBlendTime { get; set; }
		[Ordinal(8)] [RED("turnCharacterToMatchVelocity")] public LibTreeDefBool TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(9)] [RED("customStartAnimationName")] public LibTreeDefCName CustomStartAnimationName { get; set; }
		[Ordinal(10)] [RED("customMainAnimationName")] public LibTreeDefCName CustomMainAnimationName { get; set; }
		[Ordinal(11)] [RED("customStopAnimationName")] public LibTreeDefCName CustomStopAnimationName { get; set; }
		[Ordinal(12)] [RED("startSnapToTerrain")] public LibTreeDefBool StartSnapToTerrain { get; set; }
		[Ordinal(13)] [RED("mainSnapToTerrain")] public LibTreeDefBool MainSnapToTerrain { get; set; }
		[Ordinal(14)] [RED("stopSnapToTerrain")] public LibTreeDefBool StopSnapToTerrain { get; set; }
		[Ordinal(15)] [RED("startSnapToTerrainBlendTime")] public LibTreeDefFloat StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(16)] [RED("stopSnapToTerrainBlendTime")] public LibTreeDefFloat StopSnapToTerrainBlendTime { get; set; }

		public AICTreeNodeActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
