using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPickSearchDestinationTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }
		[Ordinal(1)]  [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
		[Ordinal(2)]  [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }
		[Ordinal(3)]  [RED("desiredDistance")] public CHandle<AIArgumentMapping> DesiredDistance { get; set; }
		[Ordinal(4)]  [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
		[Ordinal(5)]  [RED("ignoreRestrictMovementArea")] public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea { get; set; }
		[Ordinal(6)]  [RED("maxDistance")] public CHandle<AIArgumentMapping> MaxDistance { get; set; }

		public AIbehaviorPickSearchDestinationTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
