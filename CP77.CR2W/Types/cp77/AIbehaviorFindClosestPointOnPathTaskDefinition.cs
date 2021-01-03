using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("entryTangent")] public CHandle<AIArgumentMapping> EntryTangent { get; set; }
		[Ordinal(1)]  [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
		[Ordinal(2)]  [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
		[Ordinal(3)]  [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }

		public AIbehaviorFindClosestPointOnPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
