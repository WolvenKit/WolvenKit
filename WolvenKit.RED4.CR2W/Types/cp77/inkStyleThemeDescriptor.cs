using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleThemeDescriptor : CVariable
	{
		[Ordinal(0)] [RED("themeID")] public CName ThemeID { get; set; }
		[Ordinal(1)] [RED("themeNameLocKey")] public CName ThemeNameLocKey { get; set; }

		public inkStyleThemeDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
