using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Rect : CVariable
	{
		[Ordinal(0)] [RED("left")] public CInt32 Left { get; set; }
		[Ordinal(1)] [RED("top")] public CInt32 Top { get; set; }
		[Ordinal(2)] [RED("right")] public CInt32 Right { get; set; }
		[Ordinal(3)] [RED("bottom")] public CInt32 Bottom { get; set; }

		public Rect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
