using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkShapeWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] [RED("shapeResource")] public rRef<inkShapeCollectionResource> ShapeResource { get; set; }
		[Ordinal(21)] [RED("shapeName")] public CName ShapeName { get; set; }
		[Ordinal(22)] [RED("shapeVariant")] public CEnum<inkEShapeVariant> ShapeVariant { get; set; }
		[Ordinal(23)] [RED("keepInBounds")] public CBool KeepInBounds { get; set; }
		[Ordinal(24)] [RED("nineSliceScale")] public inkMargin NineSliceScale { get; set; }
		[Ordinal(25)] [RED("useNineSlice")] public CBool UseNineSlice { get; set; }
		[Ordinal(26)] [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(27)] [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }
		[Ordinal(28)] [RED("borderColor")] public HDRColor BorderColor { get; set; }
		[Ordinal(29)] [RED("borderOpacity")] public CFloat BorderOpacity { get; set; }
		[Ordinal(30)] [RED("fillOpacity")] public CFloat FillOpacity { get; set; }
		[Ordinal(31)] [RED("lineThickness")] public CFloat LineThickness { get; set; }
		[Ordinal(32)] [RED("endCapStyle")] public CEnum<inkEEndCapStyle> EndCapStyle { get; set; }
		[Ordinal(33)] [RED("jointStyle")] public CEnum<inkEJointStyle> JointStyle { get; set; }
		[Ordinal(34)] [RED("vertexList")] public CArray<Vector2> VertexList { get; set; }

		public inkShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
