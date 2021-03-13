using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase : CResource
	{
		[Ordinal(1)] [RED("rows")] public CArray<animActionAnimDatabase_DatabaseRow> Rows { get; set; }

		public animActionAnimDatabase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
