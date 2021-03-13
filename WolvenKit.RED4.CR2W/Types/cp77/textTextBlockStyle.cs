using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textTextBlockStyle : CVariable
	{
		[Ordinal(0)] [RED("tintColor")] public HDRColor TintColor { get; set; }
		[Ordinal(1)] [RED("shadowOffset")] public Vector2 ShadowOffset { get; set; }
		[Ordinal(2)] [RED("shadowColor")] public HDRColor ShadowColor { get; set; }
		[Ordinal(3)] [RED("fontStyle")] public textTextBlockFontStyle FontStyle { get; set; }
		[Ordinal(4)] [RED("fontSize")] public CUInt16 FontSize { get; set; }

		public textTextBlockStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
