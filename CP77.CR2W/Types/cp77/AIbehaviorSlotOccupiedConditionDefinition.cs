using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSlotOccupiedConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("slot")] public CHandle<AIArgumentMapping> Slot { get; set; }

		public AIbehaviorSlotOccupiedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
