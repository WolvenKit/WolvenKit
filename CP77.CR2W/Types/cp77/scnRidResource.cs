using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnRidResource : CResource
	{
		[Ordinal(1)] [RED("actors")] public CArray<scnActorRid> Actors { get; set; }
		[Ordinal(2)] [RED("cameras")] public CArray<scnCameraRid> Cameras { get; set; }
		[Ordinal(3)] [RED("nextSerialNumber")] public scnRidSerialNumber NextSerialNumber { get; set; }
		[Ordinal(4)] [RED("version")] public CUInt32 Version { get; set; }

		public scnRidResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
