using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkShapeWidget : inkBaseShapeWidget
	{
		[Ordinal(0)]  [RED("borderColor")] public HDRColor BorderColor { get; set; }
		[Ordinal(1)]  [RED("borderOpacity")] public CFloat BorderOpacity { get; set; }
		[Ordinal(2)]  [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(3)]  [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }
		[Ordinal(4)]  [RED("endCapStyle")] public CEnum<inkEEndCapStyle> EndCapStyle { get; set; }
		[Ordinal(5)]  [RED("fillOpacity")] public CFloat FillOpacity { get; set; }
		[Ordinal(6)]  [RED("jointStyle")] public CEnum<inkEJointStyle> JointStyle { get; set; }
		[Ordinal(7)]  [RED("keepInBounds")] public CBool KeepInBounds { get; set; }
		[Ordinal(8)]  [RED("lineThickness")] public CFloat LineThickness { get; set; }
		[Ordinal(9)]  [RED("nineSliceScale")] public inkMargin NineSliceScale { get; set; }
		[Ordinal(10)]  [RED("shapeName")] public CName ShapeName { get; set; }
		[Ordinal(11)]  [RED("shapeResource")] public rRef<inkShapeCollectionResource> ShapeResource { get; set; }
		[Ordinal(12)]  [RED("shapeVariant")] public CEnum<inkEShapeVariant> ShapeVariant { get; set; }
		[Ordinal(13)]  [RED("useNineSlice")] public CBool UseNineSlice { get; set; }
		[Ordinal(14)]  [RED("vertexList")] public CArray<Vector2> VertexList { get; set; }

		public inkShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
