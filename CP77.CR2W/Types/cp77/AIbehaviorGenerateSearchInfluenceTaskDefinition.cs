using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorGenerateSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("position")] public CHandle<AIArgumentMapping> Position { get; set; }
		[Ordinal(1)]  [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
		[Ordinal(2)]  [RED("radius")] public CHandle<AIArgumentMapping> Radius { get; set; }

		public AIbehaviorGenerateSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
