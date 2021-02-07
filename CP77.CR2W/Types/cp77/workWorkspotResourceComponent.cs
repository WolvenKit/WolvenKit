using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResourceComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("resource")] public rRef<workWorkspotResource> Resource { get; set; }
		[Ordinal(1)]  [RED("npcResource")] public rRef<workWorkspotResource> NpcResource { get; set; }
		[Ordinal(2)]  [RED("deviceResource")] public rRef<workWorkspotResource> DeviceResource { get; set; }
		[Ordinal(3)]  [RED("syncSlotName")] public CName SyncSlotName { get; set; }

		public workWorkspotResourceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
