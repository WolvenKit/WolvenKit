using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseStateOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("state")] public CEnum<EDeviceStatus> State { get; set; }

		public BaseStateOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
