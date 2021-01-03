using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindNavigablePointTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("destination")] public CHandle<AIArgumentMapping> Destination { get; set; }
		[Ordinal(1)]  [RED("outAdjustedDestination")] public CHandle<AIArgumentMapping> OutAdjustedDestination { get; set; }
		[Ordinal(2)]  [RED("outWasAdjusted")] public CHandle<AIArgumentMapping> OutWasAdjusted { get; set; }

		public AIbehaviorFindNavigablePointTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
