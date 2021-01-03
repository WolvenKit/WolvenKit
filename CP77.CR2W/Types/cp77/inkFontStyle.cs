using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkFontStyle : CVariable
	{
		[Ordinal(0)]  [RED("font")] public rRef<rendFont> Font { get; set; }
		[Ordinal(1)]  [RED("styleName")] public CName StyleName { get; set; }

		public inkFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
