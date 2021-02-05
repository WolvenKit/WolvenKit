using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCoverTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("cover")] public CHandle<AIArgumentMapping> Cover { get; set; }
		[Ordinal(1)]  [RED("coverID")] public CHandle<AIArgumentMapping> CoverID { get; set; }
		[Ordinal(2)]  [RED("multiCoverID")] public CHandle<AIArgumentMapping> MultiCoverID { get; set; }
		[Ordinal(3)]  [RED("combatTarget")] public CHandle<AIArgumentMapping> CombatTarget { get; set; }
		[Ordinal(4)]  [RED("friendlyTarget")] public CHandle<AIArgumentMapping> FriendlyTarget { get; set; }
		[Ordinal(5)]  [RED("combatZone")] public CHandle<AIArgumentMapping> CombatZone { get; set; }
		[Ordinal(6)]  [RED("sectorSelection")] public CName SectorSelection { get; set; }
		[Ordinal(7)]  [RED("ignoreRestrictMovementArea")] public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea { get; set; }
		[Ordinal(8)]  [RED("selectionPreset")] public CHandle<AIArgumentMapping> SelectionPreset { get; set; }
		[Ordinal(9)]  [RED("onActivationSelectionPreset")] public CHandle<AIArgumentMapping> OnActivationSelectionPreset { get; set; }
		[Ordinal(10)]  [RED("secondStagePreset")] public CHandle<AIArgumentMapping> SecondStagePreset { get; set; }
		[Ordinal(11)]  [RED("coverChangeThreshold")] public CHandle<AIArgumentMapping> CoverChangeThreshold { get; set; }
		[Ordinal(12)]  [RED("coverGatheringCenterObject")] public CHandle<AIArgumentMapping> CoverGatheringCenterObject { get; set; }
		[Ordinal(13)]  [RED("coverDisablingDuration")] public CHandle<AIArgumentMapping> CoverDisablingDuration { get; set; }

		public AIbehaviorSelectCoverTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
