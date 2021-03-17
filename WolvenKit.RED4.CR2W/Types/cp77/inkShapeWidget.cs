using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkShapeWidget : inkBaseShapeWidget
	{
		private rRef<inkShapeCollectionResource> _shapeResource;
		private CName _shapeName;
		private CEnum<inkEShapeVariant> _shapeVariant;
		private CBool _keepInBounds;
		private inkMargin _nineSliceScale;
		private CBool _useNineSlice;
		private CEnum<inkEHorizontalAlign> _contentHAlign;
		private CEnum<inkEVerticalAlign> _contentVAlign;
		private HDRColor _borderColor;
		private CFloat _borderOpacity;
		private CFloat _fillOpacity;
		private CFloat _lineThickness;
		private CEnum<inkEEndCapStyle> _endCapStyle;
		private CEnum<inkEJointStyle> _jointStyle;
		private CArray<Vector2> _vertexList;

		[Ordinal(20)] 
		[RED("shapeResource")] 
		public rRef<inkShapeCollectionResource> ShapeResource
		{
			get => GetProperty(ref _shapeResource);
			set => SetProperty(ref _shapeResource, value);
		}

		[Ordinal(21)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetProperty(ref _shapeName);
			set => SetProperty(ref _shapeName, value);
		}

		[Ordinal(22)] 
		[RED("shapeVariant")] 
		public CEnum<inkEShapeVariant> ShapeVariant
		{
			get => GetProperty(ref _shapeVariant);
			set => SetProperty(ref _shapeVariant, value);
		}

		[Ordinal(23)] 
		[RED("keepInBounds")] 
		public CBool KeepInBounds
		{
			get => GetProperty(ref _keepInBounds);
			set => SetProperty(ref _keepInBounds, value);
		}

		[Ordinal(24)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get => GetProperty(ref _nineSliceScale);
			set => SetProperty(ref _nineSliceScale, value);
		}

		[Ordinal(25)] 
		[RED("useNineSlice")] 
		public CBool UseNineSlice
		{
			get => GetProperty(ref _useNineSlice);
			set => SetProperty(ref _useNineSlice, value);
		}

		[Ordinal(26)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetProperty(ref _contentHAlign);
			set => SetProperty(ref _contentHAlign, value);
		}

		[Ordinal(27)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetProperty(ref _contentVAlign);
			set => SetProperty(ref _contentVAlign, value);
		}

		[Ordinal(28)] 
		[RED("borderColor")] 
		public HDRColor BorderColor
		{
			get => GetProperty(ref _borderColor);
			set => SetProperty(ref _borderColor, value);
		}

		[Ordinal(29)] 
		[RED("borderOpacity")] 
		public CFloat BorderOpacity
		{
			get => GetProperty(ref _borderOpacity);
			set => SetProperty(ref _borderOpacity, value);
		}

		[Ordinal(30)] 
		[RED("fillOpacity")] 
		public CFloat FillOpacity
		{
			get => GetProperty(ref _fillOpacity);
			set => SetProperty(ref _fillOpacity, value);
		}

		[Ordinal(31)] 
		[RED("lineThickness")] 
		public CFloat LineThickness
		{
			get => GetProperty(ref _lineThickness);
			set => SetProperty(ref _lineThickness, value);
		}

		[Ordinal(32)] 
		[RED("endCapStyle")] 
		public CEnum<inkEEndCapStyle> EndCapStyle
		{
			get => GetProperty(ref _endCapStyle);
			set => SetProperty(ref _endCapStyle, value);
		}

		[Ordinal(33)] 
		[RED("jointStyle")] 
		public CEnum<inkEJointStyle> JointStyle
		{
			get => GetProperty(ref _jointStyle);
			set => SetProperty(ref _jointStyle, value);
		}

		[Ordinal(34)] 
		[RED("vertexList")] 
		public CArray<Vector2> VertexList
		{
			get => GetProperty(ref _vertexList);
			set => SetProperty(ref _vertexList, value);
		}

		public inkShapeWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
