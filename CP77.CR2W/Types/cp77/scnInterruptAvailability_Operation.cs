using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)]  [RED("available")] public CBool Available { get; set; }

		public scnInterruptAvailability_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
