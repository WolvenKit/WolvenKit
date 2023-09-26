using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugSpansData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spans")] 
		public CArray<navgendebugCompactSpan> Spans
		{
			get => GetPropertyValue<CArray<navgendebugCompactSpan>>();
			set => SetPropertyValue<CArray<navgendebugCompactSpan>>(value);
		}

		[Ordinal(1)] 
		[RED("areas")] 
		public CArray<CUInt8> Areas
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(2)] 
		[RED("filteredAreas")] 
		public CArray<CUInt8> FilteredAreas
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public navgendebugSpansData()
		{
			Spans = new();
			Areas = new();
			FilteredAreas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
