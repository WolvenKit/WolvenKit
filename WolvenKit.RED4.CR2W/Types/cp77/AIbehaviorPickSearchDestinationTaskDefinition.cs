using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPickSearchDestinationTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("destinationPosition")] public CHandle<AIArgumentMapping> DestinationPosition { get; set; }
		[Ordinal(2)] [RED("desiredDistance")] public CHandle<AIArgumentMapping> DesiredDistance { get; set; }
		[Ordinal(3)] [RED("maxDistance")] public CHandle<AIArgumentMapping> MaxDistance { get; set; }
		[Ordinal(4)] [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }
		[Ordinal(5)] [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
		[Ordinal(6)] [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }
		[Ordinal(7)] [RED("ignoreRestrictMovementArea")] public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea { get; set; }

		public AIbehaviorPickSearchDestinationTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
