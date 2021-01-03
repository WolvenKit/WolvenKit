using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OutputValidationDataStruct : CVariable
	{
		[Ordinal(0)]  [RED("agentID")] public gamePersistentID AgentID { get; set; }
		[Ordinal(1)]  [RED("breachedAreas")] public CArray<gamePersistentID> BreachedAreas { get; set; }
		[Ordinal(2)]  [RED("eventReportedFromArea")] public gamePersistentID EventReportedFromArea { get; set; }
		[Ordinal(3)]  [RED("eventType")] public CEnum<ESecurityNotificationType> EventType { get; set; }
		[Ordinal(4)]  [RED("reprimenderID")] public entEntityID ReprimenderID { get; set; }
		[Ordinal(5)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public OutputValidationDataStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
