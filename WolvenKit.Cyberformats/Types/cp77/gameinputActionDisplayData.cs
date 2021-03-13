using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinputActionDisplayData : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("isHold")] public CBool IsHold { get; set; }
		[Ordinal(2)] [RED("inputDisplayPad")] public CString InputDisplayPad { get; set; }
		[Ordinal(3)] [RED("inputDisplayKeyboard")] public CString InputDisplayKeyboard { get; set; }

		public gameinputActionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
