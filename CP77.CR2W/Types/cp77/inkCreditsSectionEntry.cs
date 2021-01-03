using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCreditsSectionEntry : CVariable
	{
		[Ordinal(0)]  [RED("displayMode")] public CEnum<inkDisplayMode> DisplayMode { get; set; }
		[Ordinal(1)]  [RED("names")] public CArray<CString> Names { get; set; }
		[Ordinal(2)]  [RED("sectionTitle")] public CString SectionTitle { get; set; }

		public inkCreditsSectionEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
