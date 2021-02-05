using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayStandaloneComment : CVariable
	{
		[Ordinal(0)]  [RED("itemId")] public scnscreenplayItemId ItemId { get; set; }
		[Ordinal(1)]  [RED("comment")] public CString Comment { get; set; }

		public scnscreenplayStandaloneComment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
