using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(2)] [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(3)] [RED("areaTag")] public CName AreaTag { get; set; }
		[Ordinal(4)] [RED("operationType")] public CEnum<gameinteractionsEInteractionEventType> OperationType { get; set; }

		public InteractionAreaOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
