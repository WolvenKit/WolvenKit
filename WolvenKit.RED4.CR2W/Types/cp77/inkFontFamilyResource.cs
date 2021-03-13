using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontFamilyResource : CResource
	{
		[Ordinal(1)] [RED("familyName")] public CName FamilyName { get; set; }
		[Ordinal(2)] [RED("fontStyles")] public CArray<inkFontStyle> FontStyles { get; set; }

		public inkFontFamilyResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
