using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractVehicleSlotWorkspotTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }

		public AIbehaviorExtractVehicleSlotWorkspotTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
