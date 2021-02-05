using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotEntryTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }
		[Ordinal(1)]  [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
		[Ordinal(2)]  [RED("tangentPoint")] public CHandle<AIArgumentMapping> TangentPoint { get; set; }
		[Ordinal(3)]  [RED("entranceFromStand")] public CHandle<AIArgumentMapping> EntranceFromStand { get; set; }

		public AIbehaviorSelectWorkspotEntryTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
