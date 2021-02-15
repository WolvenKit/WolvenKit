using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearUsedAlertedSpotsTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("usedTokens")] public CHandle<AIArgumentMapping> UsedTokens { get; set; }

		public AIbehaviorClearUsedAlertedSpotsTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
