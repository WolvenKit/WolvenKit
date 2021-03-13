using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)] [RED("triggerData")] public CHandle<InteractionAreaOperationTriggerData> TriggerData { get; set; }

		public InteractionAreaOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
