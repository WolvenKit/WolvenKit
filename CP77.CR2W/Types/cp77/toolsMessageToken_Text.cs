using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class toolsMessageToken_Text : toolsIMessageToken
	{
		[Ordinal(0)] [RED("text")] public CString Text { get; set; }

		public toolsMessageToken_Text(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
