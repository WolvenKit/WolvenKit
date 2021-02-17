using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayDefaultMountedSlotWorkspotEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(7)] [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
		[Ordinal(8)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(9)] [RED("puppetVehicleState")] public CEnum<scnPuppetVehicleState> PuppetVehicleState { get; set; }

		public scnPlayDefaultMountedSlotWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
