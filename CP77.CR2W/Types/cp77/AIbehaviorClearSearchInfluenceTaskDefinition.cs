using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }
		[Ordinal(1)]  [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
		[Ordinal(2)]  [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }

		public AIbehaviorClearSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
