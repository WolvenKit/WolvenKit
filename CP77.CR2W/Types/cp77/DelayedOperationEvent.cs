using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DelayedOperationEvent : redEvent
	{
		[Ordinal(0)]  [RED("operation")] public SBaseDeviceOperationData Operation { get; set; }
		[Ordinal(1)]  [RED("operationHandler")] public CHandle<DeviceOperations> OperationHandler { get; set; }

		public DelayedOperationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
