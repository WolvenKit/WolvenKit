using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugContourSet : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("contours")] 
		public CArray<navgendebugCompactContour> Contours
		{
			get => GetPropertyValue<CArray<navgendebugCompactContour>>();
			set => SetPropertyValue<CArray<navgendebugCompactContour>>(value);
		}

		[Ordinal(1)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(2)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CInt32 Width
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CInt32 Height
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("borderSize")] 
		public CInt32 BorderSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("maxError")] 
		public CFloat MaxError
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public navgendebugContourSet()
		{
			Contours = new();
			BoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
