using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnPlayDefaultMountedSlotWorkspotEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("parentRef")] public gameEntityReference ParentRef { get; set; }
		[Ordinal(1)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(2)]  [RED("puppetVehicleState")] public CEnum<scnPuppetVehicleState> PuppetVehicleState { get; set; }
		[Ordinal(3)]  [RED("slotName")] public CName SlotName { get; set; }

		public scnPlayDefaultMountedSlotWorkspotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
