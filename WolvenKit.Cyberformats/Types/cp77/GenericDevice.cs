using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericDevice : InteractiveDevice
	{
		[Ordinal(93)] [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(94)] [RED("currentSpiderbotAction")] public CHandle<CustomDeviceAction> CurrentSpiderbotAction { get; set; }

		public GenericDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
