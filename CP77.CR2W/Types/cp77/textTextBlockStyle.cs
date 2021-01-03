using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class textTextBlockStyle : CVariable
	{
		[Ordinal(0)]  [RED("fontSize")] public CUInt16 FontSize { get; set; }
		[Ordinal(1)]  [RED("fontStyle")] public textTextBlockFontStyle FontStyle { get; set; }
		[Ordinal(2)]  [RED("shadowColor")] public HDRColor ShadowColor { get; set; }
		[Ordinal(3)]  [RED("shadowOffset")] public Vector2 ShadowOffset { get; set; }
		[Ordinal(4)]  [RED("tintColor")] public HDRColor TintColor { get; set; }

		public textTextBlockStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
