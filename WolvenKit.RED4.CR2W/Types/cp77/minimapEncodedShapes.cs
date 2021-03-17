using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapEncodedShapes : CResource
	{
		private DataBuffer _buffer;
		private Vector2 _quantizationScale;
		private Vector2 _quantizationBias;
		private Vector3 _boxQuantizationScale;
		private Vector3 _boxQuantizationBias;
		private CUInt32 _numPoints;
		private CUInt32 _numBorderPoints;
		private CUInt32 _numFillPoints;
		private CUInt32 _numShapes;
		private CUInt32 _numSpatialBuckets;
		private CUInt32 _numUniqueGeometry;
		private CUInt32 _numOwners;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("Buffer")] 
		public DataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		[Ordinal(2)] 
		[RED("QuantizationScale")] 
		public Vector2 QuantizationScale
		{
			get => GetProperty(ref _quantizationScale);
			set => SetProperty(ref _quantizationScale, value);
		}

		[Ordinal(3)] 
		[RED("QuantizationBias")] 
		public Vector2 QuantizationBias
		{
			get => GetProperty(ref _quantizationBias);
			set => SetProperty(ref _quantizationBias, value);
		}

		[Ordinal(4)] 
		[RED("BoxQuantizationScale")] 
		public Vector3 BoxQuantizationScale
		{
			get => GetProperty(ref _boxQuantizationScale);
			set => SetProperty(ref _boxQuantizationScale, value);
		}

		[Ordinal(5)] 
		[RED("BoxQuantizationBias")] 
		public Vector3 BoxQuantizationBias
		{
			get => GetProperty(ref _boxQuantizationBias);
			set => SetProperty(ref _boxQuantizationBias, value);
		}

		[Ordinal(6)] 
		[RED("NumPoints")] 
		public CUInt32 NumPoints
		{
			get => GetProperty(ref _numPoints);
			set => SetProperty(ref _numPoints, value);
		}

		[Ordinal(7)] 
		[RED("NumBorderPoints")] 
		public CUInt32 NumBorderPoints
		{
			get => GetProperty(ref _numBorderPoints);
			set => SetProperty(ref _numBorderPoints, value);
		}

		[Ordinal(8)] 
		[RED("NumFillPoints")] 
		public CUInt32 NumFillPoints
		{
			get => GetProperty(ref _numFillPoints);
			set => SetProperty(ref _numFillPoints, value);
		}

		[Ordinal(9)] 
		[RED("NumShapes")] 
		public CUInt32 NumShapes
		{
			get => GetProperty(ref _numShapes);
			set => SetProperty(ref _numShapes, value);
		}

		[Ordinal(10)] 
		[RED("NumSpatialBuckets")] 
		public CUInt32 NumSpatialBuckets
		{
			get => GetProperty(ref _numSpatialBuckets);
			set => SetProperty(ref _numSpatialBuckets, value);
		}

		[Ordinal(11)] 
		[RED("NumUniqueGeometry")] 
		public CUInt32 NumUniqueGeometry
		{
			get => GetProperty(ref _numUniqueGeometry);
			set => SetProperty(ref _numUniqueGeometry, value);
		}

		[Ordinal(12)] 
		[RED("NumOwners")] 
		public CUInt32 NumOwners
		{
			get => GetProperty(ref _numOwners);
			set => SetProperty(ref _numOwners, value);
		}

		[Ordinal(13)] 
		[RED("Version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public minimapEncodedShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
