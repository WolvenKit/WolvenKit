using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class minimapEncodedShapes : CResource
	{
		[Ordinal(1)] 
		[RED("Buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("QuantizationScale")] 
		public Vector2 QuantizationScale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("QuantizationBias")] 
		public Vector2 QuantizationBias
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("BoxQuantizationScale")] 
		public Vector3 BoxQuantizationScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("BoxQuantizationBias")] 
		public Vector3 BoxQuantizationBias
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("NumPoints")] 
		public CUInt32 NumPoints
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("NumBorderPoints")] 
		public CUInt32 NumBorderPoints
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("NumFillPoints")] 
		public CUInt32 NumFillPoints
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("NumShapes")] 
		public CUInt32 NumShapes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("NumSpatialBuckets")] 
		public CUInt32 NumSpatialBuckets
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("NumUniqueGeometry")] 
		public CUInt32 NumUniqueGeometry
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("NumOwners")] 
		public CUInt32 NumOwners
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("Version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public minimapEncodedShapes()
		{
			QuantizationScale = new Vector2();
			QuantizationBias = new Vector2();
			BoxQuantizationScale = new Vector3();
			BoxQuantizationBias = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
