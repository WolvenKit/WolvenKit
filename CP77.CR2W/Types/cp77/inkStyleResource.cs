using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStyleResource : CResource
	{
		[Ordinal(0)]  [RED("styles")] public CArray<inkStyle> Styles { get; set; }
		[Ordinal(1)]  [RED("styleImports")] public CArray<rRef<inkStyleResource>> StyleImports { get; set; }
		[Ordinal(2)]  [RED("themes")] public CArray<inkStyleTheme> Themes { get; set; }
		[Ordinal(3)]  [RED("hideInInheritingStyles")] public CBool HideInInheritingStyles { get; set; }

		public inkStyleResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
