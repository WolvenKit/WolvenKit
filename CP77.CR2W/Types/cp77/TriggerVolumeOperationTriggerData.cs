using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TriggerVolumeOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("isActivatorNPC")] public CBool IsActivatorNPC { get; set; }
		[Ordinal(2)]  [RED("isActivatorPlayer")] public CBool IsActivatorPlayer { get; set; }
		[Ordinal(3)]  [RED("operationType")] public CEnum<ETriggerOperationType> OperationType { get; set; }

		public TriggerVolumeOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
