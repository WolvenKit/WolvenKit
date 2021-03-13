using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RectF : CVariable
	{
		[Ordinal(0)] [RED("Left")] public CFloat Left { get; set; }
		[Ordinal(1)] [RED("Top")] public CFloat Top { get; set; }
		[Ordinal(2)] [RED("Right")] public CFloat Right { get; set; }
		[Ordinal(3)] [RED("Bottom")] public CFloat Bottom { get; set; }

		public RectF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
