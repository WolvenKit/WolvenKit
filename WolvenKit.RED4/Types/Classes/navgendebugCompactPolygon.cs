using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugCompactPolygon : ISerializable
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<CUInt16> Indices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(2)] 
		[RED("neighbors")] 
		public CArray<CUInt16> Neighbors
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(3)] 
		[RED("area")] 
		public CUInt8 Area
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("region")] 
		public CUInt16 Region
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CUInt16 Flags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public navgendebugCompactPolygon()
		{
			Indices = new();
			Neighbors = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
