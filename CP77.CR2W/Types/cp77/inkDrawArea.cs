using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkDrawArea : CVariable
	{
		[Ordinal(0)]  [RED("absolutePosition")] public Vector2 AbsolutePosition { get; set; }
		[Ordinal(1)]  [RED("relativePosition")] public Vector2 RelativePosition { get; set; }
		[Ordinal(2)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(3)]  [RED("size")] public Vector2 Size { get; set; }

		public inkDrawArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
