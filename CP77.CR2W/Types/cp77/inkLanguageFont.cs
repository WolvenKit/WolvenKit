using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFont : CVariable
	{
		[Ordinal(0)]  [RED("font")] public raRef<inkFontFamilyResource> Font { get; set; }
		[Ordinal(1)]  [RED("mapper")] public CHandle<inkLanguageFontMapper> Mapper { get; set; }

		public inkLanguageFont(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
