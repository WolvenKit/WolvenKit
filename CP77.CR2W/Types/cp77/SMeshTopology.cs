using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SMeshTopology : CVariable
	{
		[Ordinal(0)] [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)] [RED("metadata")] public DataBuffer Metadata { get; set; }

		public SMeshTopology(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
