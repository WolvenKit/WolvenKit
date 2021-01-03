using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsWorkspotEntry : CVariable
	{
		[Ordinal(0)]  [RED("entries")] public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Entries { get; set; }
		[Ordinal(1)]  [RED("exits")] public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Exits { get; set; }
		[Ordinal(2)]  [RED("instanceId")] public CRUID InstanceId { get; set; }
		[Ordinal(3)]  [RED("instanceOrigin")] public Transform InstanceOrigin { get; set; }

		public scnSceneMarkerInternalsWorkspotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
