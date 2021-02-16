using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherOption : CVariable
	{
		[Ordinal(0)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)] [RED("name")] public CName Name { get; set; }
		[Ordinal(2)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(3)] [RED("actions")] public CArray<gameuiCharacterCustomizationAction> Actions { get; set; }
		[Ordinal(4)] [RED("tags")] public redTagList Tags { get; set; }

		public gameuiSwitcherOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
