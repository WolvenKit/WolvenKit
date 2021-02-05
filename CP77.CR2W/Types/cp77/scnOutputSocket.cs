using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocket : CVariable
	{
		[Ordinal(0)]  [RED("stamp")] public scnOutputSocketStamp Stamp { get; set; }
		[Ordinal(1)]  [RED("destinations")] public CArray<scnInputSocketId> Destinations { get; set; }

		public scnOutputSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
