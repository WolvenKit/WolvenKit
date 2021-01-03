using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayedDeviceOperationTriggerEvent : redEvent
	{
		[Ordinal(0)]  [RED("namedOperation")] public CHandle<OperationExecutionData> NamedOperation { get; set; }
		[Ordinal(1)]  [RED("triggerHandler")] public CHandle<DeviceOperationsTrigger> TriggerHandler { get; set; }

		public DelayedDeviceOperationTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
