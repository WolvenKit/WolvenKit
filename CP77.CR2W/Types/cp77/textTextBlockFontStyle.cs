using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
