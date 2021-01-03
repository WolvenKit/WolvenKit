using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)]  [RED("triggerData")] public CHandle<InteractionAreaOperationTriggerData> TriggerData { get; set; }

		public InteractionAreaOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
