using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DeviceActionOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)]  [RED("triggerData")] public CHandle<DeviceActionOperationTriggerData> TriggerData { get; set; }

		public DeviceActionOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
