using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontStyle : CVariable
	{
		[Ordinal(0)] [RED("styleName")] public CName StyleName { get; set; }
		[Ordinal(1)] [RED("font")] public rRef<rendFont> Font { get; set; }

		public inkFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
