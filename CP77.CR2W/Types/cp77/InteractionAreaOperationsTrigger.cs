using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractionAreaOperationsTrigger : DeviceOperationsTrigger
	{
		[Ordinal(0)]  [RED("triggerData")] public CHandle<InteractionAreaOperationTriggerData> TriggerData { get; set; }

		public InteractionAreaOperationsTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
