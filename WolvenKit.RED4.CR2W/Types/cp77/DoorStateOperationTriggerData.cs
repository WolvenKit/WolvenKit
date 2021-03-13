using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorStateOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] [RED("state")] public CEnum<EDoorStatus> State { get; set; }

		public DoorStateOperationTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
