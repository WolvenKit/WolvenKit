using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questBehind_ConditionType : questISensesConditionType
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<questBehindInteractionEventType> EventType { get; set; }
		[Ordinal(1)]  [RED("targetRef")] public gameEntityReference TargetRef { get; set; }

		public questBehind_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
