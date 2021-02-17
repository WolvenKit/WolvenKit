using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopStringWithID : CVariable
	{
		[Ordinal(0)] [RED("text")] public CString Text { get; set; }
		[Ordinal(1)] [RED("id")] public CUInt64 Id { get; set; }

		public interopStringWithID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
