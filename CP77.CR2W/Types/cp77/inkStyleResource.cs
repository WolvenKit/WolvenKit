using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStyleResource : CResource
	{
		[Ordinal(0)]  [RED("hideInInheritingStyles")] public CBool HideInInheritingStyles { get; set; }
		[Ordinal(1)]  [RED("styleImports")] public CArray<rRef<inkStyleResource>> StyleImports { get; set; }
		[Ordinal(2)]  [RED("styles")] public CArray<inkStyle> Styles { get; set; }
		[Ordinal(3)]  [RED("themes")] public CArray<inkStyleTheme> Themes { get; set; }

		public inkStyleResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
