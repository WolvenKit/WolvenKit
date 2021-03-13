using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDrawArea : CVariable
	{
		[Ordinal(0)] [RED("size")] public Vector2 Size { get; set; }
		[Ordinal(1)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(2)] [RED("relativePosition")] public Vector2 RelativePosition { get; set; }
		[Ordinal(3)] [RED("absolutePosition")] public Vector2 AbsolutePosition { get; set; }

		public inkDrawArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
