using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldGlobalNodeID : CVariable
	{
		[Ordinal(0)]  [RED("hash")] public CUInt64 Hash { get; set; }

		public worldGlobalNodeID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
