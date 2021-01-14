using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UnequippedDecisions : EquipmentBaseDecisions
	{
		[Ordinal(0)]  [RED("stateMachineInstanceData")] public gamestateMachineStateMachineInstanceData StateMachineInstanceData { get; set; }

		public UnequippedDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
