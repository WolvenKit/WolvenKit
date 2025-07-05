using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugHeightfield : ISerializable
	{
		[Ordinal(0)] 
		[RED("bounds")] 
		public Box Bounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(1)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("width")] 
		public CUInt16 Width
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(4)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("rawSpans")] 
		public navgendebugSpansData RawSpans
		{
			get => GetPropertyValue<navgendebugSpansData>();
			set => SetPropertyValue<navgendebugSpansData>(value);
		}

		[Ordinal(6)] 
		[RED("compactSpans")] 
		public navgendebugSpansData CompactSpans
		{
			get => GetPropertyValue<navgendebugSpansData>();
			set => SetPropertyValue<navgendebugSpansData>(value);
		}

		[Ordinal(7)] 
		[RED("cells")] 
		public CArray<navgendebugCompactCell> Cells
		{
			get => GetPropertyValue<CArray<navgendebugCompactCell>>();
			set => SetPropertyValue<CArray<navgendebugCompactCell>>(value);
		}

		[Ordinal(8)] 
		[RED("regions")] 
		public CArray<CUInt16> Regions
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(9)] 
		[RED("distancefield")] 
		public CArray<CUInt16> Distancefield
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(10)] 
		[RED("maxDistancefieldValue")] 
		public CUInt16 MaxDistancefieldValue
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public navgendebugHeightfield()
		{
			Bounds = new Box { Min = new Vector4(), Max = new Vector4() };
			RawSpans = new navgendebugSpansData { Spans = new(), Areas = new(), FilteredAreas = new() };
			CompactSpans = new navgendebugSpansData { Spans = new(), Areas = new(), FilteredAreas = new() };
			Cells = new();
			Regions = new();
			Distancefield = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
