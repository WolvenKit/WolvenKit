using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OutputValidationDataStruct : CVariable
	{
		[Ordinal(0)] [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(1)] [RED("agentID")] public gamePersistentID AgentID { get; set; }
		[Ordinal(2)] [RED("reprimenderID")] public entEntityID ReprimenderID { get; set; }
		[Ordinal(3)] [RED("eventReportedFromArea")] public gamePersistentID EventReportedFromArea { get; set; }
		[Ordinal(4)] [RED("eventType")] public CEnum<ESecurityNotificationType> EventType { get; set; }
		[Ordinal(5)] [RED("breachedAreas")] public CArray<gamePersistentID> BreachedAreas { get; set; }

		public OutputValidationDataStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
