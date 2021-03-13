using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedOperationEvent : redEvent
	{
		[Ordinal(0)] [RED("operationHandler")] public CHandle<DeviceOperations> OperationHandler { get; set; }
		[Ordinal(1)] [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }

		public DelayedOperationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
