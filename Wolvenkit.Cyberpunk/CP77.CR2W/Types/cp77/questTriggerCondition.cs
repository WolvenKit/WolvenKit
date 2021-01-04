using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTriggerCondition : questCondition
	{
		[Ordinal(0)]  [RED("activatorRef")] public gameEntityReference ActivatorRef { get; set; }
		[Ordinal(1)]  [RED("isPlayerActivator")] public CBool IsPlayerActivator { get; set; }
		[Ordinal(2)]  [RED("triggerAreaRef")] public NodeRef TriggerAreaRef { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<questTriggerConditionType> Type { get; set; }

		public questTriggerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
