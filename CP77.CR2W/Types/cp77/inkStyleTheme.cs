using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStyleTheme : CVariable
	{
		[Ordinal(0)] [RED("themeID")] public CName ThemeID { get; set; }
		[Ordinal(1)] [RED("styleResource")] public rRef<inkStyleResource> StyleResource { get; set; }

		public inkStyleTheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
