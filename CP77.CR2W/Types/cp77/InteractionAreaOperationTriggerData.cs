using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(0)]  [RED("areaTag")] public CName AreaTag { get; set; }
		[Ordinal(1)]  [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(2)]  [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(3)]  [RED("operationType")] public CEnum<gameinteractionsEInteractionEventType> OperationType { get; set; }

		public InteractionAreaOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
