using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkShapeWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] 
		[RED("shapeResource")] 
		public CResourceReference<inkShapeCollectionResource> ShapeResource
		{
			get => GetPropertyValue<CResourceReference<inkShapeCollectionResource>>();
			set => SetPropertyValue<CResourceReference<inkShapeCollectionResource>>(value);
		}

		[Ordinal(21)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("shapeVariant")] 
		public CEnum<inkEShapeVariant> ShapeVariant
		{
			get => GetPropertyValue<CEnum<inkEShapeVariant>>();
			set => SetPropertyValue<CEnum<inkEShapeVariant>>(value);
		}

		[Ordinal(23)] 
		[RED("keepInBounds")] 
		public CBool KeepInBounds
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("nineSliceScale")] 
		public inkMargin NineSliceScale
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(25)] 
		[RED("useNineSlice")] 
		public CBool UseNineSlice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(27)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetPropertyValue<CEnum<inkEVerticalAlign>>();
			set => SetPropertyValue<CEnum<inkEVerticalAlign>>(value);
		}

		[Ordinal(28)] 
		[RED("borderColor")] 
		public HDRColor BorderColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(29)] 
		[RED("borderOpacity")] 
		public CFloat BorderOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("fillOpacity")] 
		public CFloat FillOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("lineThickness")] 
		public CFloat LineThickness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("endCapStyle")] 
		public CEnum<inkEEndCapStyle> EndCapStyle
		{
			get => GetPropertyValue<CEnum<inkEEndCapStyle>>();
			set => SetPropertyValue<CEnum<inkEEndCapStyle>>(value);
		}

		[Ordinal(33)] 
		[RED("jointStyle")] 
		public CEnum<inkEJointStyle> JointStyle
		{
			get => GetPropertyValue<CEnum<inkEJointStyle>>();
			set => SetPropertyValue<CEnum<inkEJointStyle>>(value);
		}

		[Ordinal(34)] 
		[RED("vertexList")] 
		public CArray<Vector2> VertexList
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		public inkShapeWidget()
		{
			Size = new Vector2 { X = 1.000000F, Y = 1.000000F };
			NineSliceScale = new inkMargin();
			BorderColor = new HDRColor { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			BorderOpacity = 1.000000F;
			FillOpacity = 1.000000F;
			VertexList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
