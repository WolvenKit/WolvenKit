using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStyleTheme : CVariable
	{
		[Ordinal(0)]  [RED("styleResource")] public rRef<inkStyleResource> StyleResource { get; set; }
		[Ordinal(1)]  [RED("themeID")] public CName ThemeID { get; set; }

		public inkStyleTheme(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
