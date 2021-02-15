using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnInputSocketStamp : CVariable
	{
		[Ordinal(0)] [RED("name")] public CUInt16 Name { get; set; }
		[Ordinal(1)] [RED("ordinal")] public CUInt16 Ordinal { get; set; }

		public scnInputSocketStamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
