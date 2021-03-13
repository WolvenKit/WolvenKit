using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipCycleInitDecisions : EquipmentBaseDecisions
	{
		[Ordinal(0)] [RED("stateMachineInstanceData")] public gamestateMachineStateMachineInstanceData StateMachineInstanceData { get; set; }

		public EquipCycleInitDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
