using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStyleThemeDescriptor : CVariable
	{
		[Ordinal(0)]  [RED("themeID")] public CName ThemeID { get; set; }
		[Ordinal(1)]  [RED("themeNameLocKey")] public CName ThemeNameLocKey { get; set; }

		public inkStyleThemeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
