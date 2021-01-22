using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkLinePatternWidget : inkImageWidget
	{
		[Ordinal(0)]  [RED("endOffset")] public CFloat EndOffset { get; set; }
		[Ordinal(1)]  [RED("fadeInLength")] public CFloat FadeInLength { get; set; }
		[Ordinal(2)]  [RED("looseSpacing")] public CFloat LooseSpacing { get; set; }
		[Ordinal(3)]  [RED("patternDirection")] public CEnum<inkEChildOrder> PatternDirection { get; set; }
		[Ordinal(4)]  [RED("rotateWithSegment")] public CBool RotateWithSegment { get; set; }
		[Ordinal(5)]  [RED("spacing")] public CFloat Spacing { get; set; }
		[Ordinal(6)]  [RED("startOffset")] public CFloat StartOffset { get; set; }
		[Ordinal(7)]  [RED("vertexList")] public CArray<inkLineVertex> VertexList { get; set; }

		public inkLinePatternWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
