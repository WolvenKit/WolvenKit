using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnlocLangId : CVariable
	{
		[Ordinal(0)]  [RED("langId")] public CUInt8 LangId { get; set; }

		public scnlocLangId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
