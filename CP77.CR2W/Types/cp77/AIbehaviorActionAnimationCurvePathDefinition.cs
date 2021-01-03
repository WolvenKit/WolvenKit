using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionAnimationCurvePathDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("blendTime")] public CHandle<AIArgumentMapping> BlendTime { get; set; }
		[Ordinal(1)]  [RED("controllersSetupName")] public CHandle<AIArgumentMapping> ControllersSetupName { get; set; }
		[Ordinal(2)]  [RED("customMainAnimationName")] public CHandle<AIArgumentMapping> CustomMainAnimationName { get; set; }
		[Ordinal(3)]  [RED("customStartAnimationName")] public CHandle<AIArgumentMapping> CustomStartAnimationName { get; set; }
		[Ordinal(4)]  [RED("customStopAnimationName")] public CHandle<AIArgumentMapping> CustomStopAnimationName { get; set; }
		[Ordinal(5)]  [RED("globalInBlendTime")] public CHandle<AIArgumentMapping> GlobalInBlendTime { get; set; }
		[Ordinal(6)]  [RED("globalOutBlendTime")] public CHandle<AIArgumentMapping> GlobalOutBlendTime { get; set; }
		[Ordinal(7)]  [RED("mainSnapToTerrain")] public CHandle<AIArgumentMapping> MainSnapToTerrain { get; set; }
		[Ordinal(8)]  [RED("nodeReference")] public CHandle<AIArgumentMapping> NodeReference { get; set; }
		[Ordinal(9)]  [RED("startSnapToTerrain")] public CHandle<AIArgumentMapping> StartSnapToTerrain { get; set; }
		[Ordinal(10)]  [RED("startSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime { get; set; }
		[Ordinal(11)]  [RED("stopSnapToTerrain")] public CHandle<AIArgumentMapping> StopSnapToTerrain { get; set; }
		[Ordinal(12)]  [RED("stopSnapToTerrainBlendTime")] public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime { get; set; }
		[Ordinal(13)]  [RED("turnCharacterToMatchVelocity")] public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity { get; set; }
		[Ordinal(14)]  [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(15)]  [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }

		public AIbehaviorActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
