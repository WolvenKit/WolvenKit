using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CreateCustomBlackboardEvent : redEvent
	{
		[Ordinal(0)]  [RED("blackboardDef")] public CHandle<CustomBlackboardDef> BlackboardDef { get; set; }
		[Ordinal(1)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }

		public CreateCustomBlackboardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
