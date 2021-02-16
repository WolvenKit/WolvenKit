using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionAnimationCurvePathDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("nodeReference")] public CHandle<AIArgumentMapping> NodeReference { get; set; }
		[Ordinal(2)] [RED("controllersSetupName")] public CHandle<AIArgumentMapping> ControllersSetupName { get; set; }
		[Ordinal(3)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(4)] [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }
		[Ordinal(5)] [RED("blendTime")] public CHandle<AIArgumentMapping> BlendTime { get; set; }
		[Ordinal(6)] [RED("globalInBlendTime")] public CHandle<AIArgumentMapping> GlobalInBlendTime { get; set; }
		[Ordinal(7)] [RED("globalOutBlendTime")] public CHandle<AIArgumentMapping> GlobalOutBlendTime { get; set; }
		[Ordinal(8)] [RED("turnCharacterToMatchVelocity")] public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(9)] [RED("customStartAnimationName")] public CHandle<AIArgumentMapping> CustomStartAnimationName { get; set; }
		[Ordinal(10)] [RED("customMainAnimationName")] public CHandle<AIArgumentMapping> CustomMainAnimationName { get; set; }
		[Ordinal(11)] [RED("customStopAnimationName")] public CHandle<AIArgumentMapping> CustomStopAnimationName { get; set; }
		[Ordinal(12)] [RED("startSnapToTerrain")] public CHandle<AIArgumentMapping> StartSnapToTerrain { get; set; }
		[Ordinal(13)] [RED("mainSnapToTerrain")] public CHandle<AIArgumentMapping> MainSnapToTerrain { get; set; }
		[Ordinal(14)] [RED("stopSnapToTerrain")] public CHandle<AIArgumentMapping> StopSnapToTerrain { get; set; }
		[Ordinal(15)] [RED("startSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(16)] [RED("stopSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime { get; set; }

		public AIbehaviorActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
