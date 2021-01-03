using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questInteraction_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<questObjectInteractionEventType> EventType { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public NodeRef ObjectRef { get; set; }

		public questInteraction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
