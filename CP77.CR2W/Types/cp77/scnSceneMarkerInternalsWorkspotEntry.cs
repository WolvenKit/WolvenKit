using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsWorkspotEntry : CVariable
	{
		[Ordinal(0)] [RED("instanceId")] public CRUID InstanceId { get; set; }
		[Ordinal(1)] [RED("instanceOrigin")] public Transform InstanceOrigin { get; set; }
		[Ordinal(2)] [RED("entries")] public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Entries { get; set; }
		[Ordinal(3)] [RED("exits")] public CArray<scnSceneMarkerInternalsWorkspotEntrySocket> Exits { get; set; }

		public scnSceneMarkerInternalsWorkspotEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
