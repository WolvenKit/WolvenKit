using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(2)] [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(3)] [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(4)] [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }

		public TriggerVolumeOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
