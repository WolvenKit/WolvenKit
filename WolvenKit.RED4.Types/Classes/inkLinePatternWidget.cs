using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLinePatternWidget : inkImageWidget
	{
		[Ordinal(32)] 
		[RED("vertexList")] 
		public CArray<inkLineVertex> VertexList
		{
			get => GetPropertyValue<CArray<inkLineVertex>>();
			set => SetPropertyValue<CArray<inkLineVertex>>(value);
		}

		[Ordinal(33)] 
		[RED("spacing")] 
		public CFloat Spacing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(34)] 
		[RED("looseSpacing")] 
		public CFloat LooseSpacing
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(36)] 
		[RED("endOffset")] 
		public CFloat EndOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("fadeInLength")] 
		public CFloat FadeInLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("rotateWithSegment")] 
		public CBool RotateWithSegment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("patternDirection")] 
		public CEnum<inkEChildOrder> PatternDirection
		{
			get => GetPropertyValue<CEnum<inkEChildOrder>>();
			set => SetPropertyValue<CEnum<inkEChildOrder>>(value);
		}

		public inkLinePatternWidget()
		{
			VertexList = new();
			Spacing = 10.000000F;
			LooseSpacing = 20.000000F;
			RotateWithSegment = true;
		}
	}
}
