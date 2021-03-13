using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<HitOperationTriggerData> TriggerData { get; set; }

		public HitOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
