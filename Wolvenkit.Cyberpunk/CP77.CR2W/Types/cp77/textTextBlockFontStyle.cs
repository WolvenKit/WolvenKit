using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class textTextBlockFontStyle : CVariable
	{
		[Ordinal(0)]  [RED("fontStyle")] public CName FontStyle { get; set; }
		[Ordinal(1)]  [RED("outlineColor")] public HDRColor OutlineColor { get; set; }
		[Ordinal(2)]  [RED("outlineSize")] public CInt32 OutlineSize { get; set; }

		public textTextBlockFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
