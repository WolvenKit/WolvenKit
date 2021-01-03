using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotEntryTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
		[Ordinal(1)]  [RED("entranceFromStand")] public CHandle<AIArgumentMapping> EntranceFromStand { get; set; }
		[Ordinal(2)]  [RED("tangentPoint")] public CHandle<AIArgumentMapping> TangentPoint { get; set; }
		[Ordinal(3)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }

		public AIbehaviorSelectWorkspotEntryTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
