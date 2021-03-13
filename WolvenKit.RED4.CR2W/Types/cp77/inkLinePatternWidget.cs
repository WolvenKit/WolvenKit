using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLinePatternWidget : inkImageWidget
	{
		[Ordinal(30)] [RED("vertexList")] public CArray<inkLineVertex> VertexList { get; set; }
		[Ordinal(31)] [RED("spacing")] public CFloat Spacing { get; set; }
		[Ordinal(32)] [RED("looseSpacing")] public CFloat LooseSpacing { get; set; }
		[Ordinal(33)] [RED("startOffset")] public CFloat StartOffset { get; set; }
		[Ordinal(34)] [RED("endOffset")] public CFloat EndOffset { get; set; }
		[Ordinal(35)] [RED("fadeInLength")] public CFloat FadeInLength { get; set; }
		[Ordinal(36)] [RED("rotateWithSegment")] public CBool RotateWithSegment { get; set; }
		[Ordinal(37)] [RED("patternDirection")] public CEnum<inkEChildOrder> PatternDirection { get; set; }

		public inkLinePatternWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
