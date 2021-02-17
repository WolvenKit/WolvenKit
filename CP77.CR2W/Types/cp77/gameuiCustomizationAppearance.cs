using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiCustomizationAppearance : gameuiCensorshipInfo
	{
		[Ordinal(2)] [RED("name")] public CName Name { get; set; }
		[Ordinal(3)] [RED("resource")] public raRef<appearanceAppearanceResource> Resource { get; set; }
		[Ordinal(4)] [RED("definition")] public CName Definition { get; set; }

		public gameuiCustomizationAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
