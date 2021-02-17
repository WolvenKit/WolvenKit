using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class redResourceListResource : CResource
	{
		[Ordinal(1)] [RED("resources")] public CArray<raRef<CResource>> Resources { get; set; }
		[Ordinal(2)] [RED("descriptions")] public CArray<CString> Descriptions { get; set; }

		public redResourceListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
