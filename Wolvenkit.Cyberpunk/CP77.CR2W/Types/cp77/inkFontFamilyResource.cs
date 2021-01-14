using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkFontFamilyResource : CResource
	{
		[Ordinal(0)]  [RED("familyName")] public CName FamilyName { get; set; }
		[Ordinal(1)]  [RED("fontStyles")] public CArray<inkFontStyle> FontStyles { get; set; }

		public inkFontFamilyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
