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
			get
			{
				if (_buffer == null)
				{
					_buffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "Buffer", cr2w, this);
				}
				return _buffer;
			}
			set
			{
				if (_buffer == value)
				{
					return;
				}
				_buffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("QuantizationScale")] 
		public Vector2 QuantizationScale
		{
			get
			{
				if (_quantizationScale == null)
				{
					_quantizationScale = (Vector2) CR2WTypeManager.Create("Vector2", "QuantizationScale", cr2w, this);
				}
				return _quantizationScale;
			}
			set
			{
				if (_quantizationScale == value)
				{
					return;
				}
				_quantizationScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("QuantizationBias")] 
		public Vector2 QuantizationBias
		{
			get
			{
				if (_quantizationBias == null)
				{
					_quantizationBias = (Vector2) CR2WTypeManager.Create("Vector2", "QuantizationBias", cr2w, this);
				}
				return _quantizationBias;
			}
			set
			{
				if (_quantizationBias == value)
				{
					return;
				}
				_quantizationBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("BoxQuantizationScale")] 
		public Vector3 BoxQuantizationScale
		{
			get
			{
				if (_boxQuantizationScale == null)
				{
					_boxQuantizationScale = (Vector3) CR2WTypeManager.Create("Vector3", "BoxQuantizationScale", cr2w, this);
				}
				return _boxQuantizationScale;
			}
			set
			{
				if (_boxQuantizationScale == value)
				{
					return;
				}
				_boxQuantizationScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("BoxQuantizationBias")] 
		public Vector3 BoxQuantizationBias
		{
			get
			{
				if (_boxQuantizationBias == null)
				{
					_boxQuantizationBias = (Vector3) CR2WTypeManager.Create("Vector3", "BoxQuantizationBias", cr2w, this);
				}
				return _boxQuantizationBias;
			}
			set
			{
				if (_boxQuantizationBias == value)
				{
					return;
				}
				_boxQuantizationBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("NumPoints")] 
		public CUInt32 NumPoints
		{
			get
			{
				if (_numPoints == null)
				{
					_numPoints = (CUInt32) CR2WTypeManager.Create("Uint32", "NumPoints", cr2w, this);
				}
				return _numPoints;
			}
			set
			{
				if (_numPoints == value)
				{
					return;
				}
				_numPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("NumBorderPoints")] 
		public CUInt32 NumBorderPoints
		{
			get
			{
				if (_numBorderPoints == null)
				{
					_numBorderPoints = (CUInt32) CR2WTypeManager.Create("Uint32", "NumBorderPoints", cr2w, this);
				}
				return _numBorderPoints;
			}
			set
			{
				if (_numBorderPoints == value)
				{
					return;
				}
				_numBorderPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("NumFillPoints")] 
		public CUInt32 NumFillPoints
		{
			get
			{
				if (_numFillPoints == null)
				{
					_numFillPoints = (CUInt32) CR2WTypeManager.Create("Uint32", "NumFillPoints", cr2w, this);
				}
				return _numFillPoints;
			}
			set
			{
				if (_numFillPoints == value)
				{
					return;
				}
				_numFillPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("NumShapes")] 
		public CUInt32 NumShapes
		{
			get
			{
				if (_numShapes == null)
				{
					_numShapes = (CUInt32) CR2WTypeManager.Create("Uint32", "NumShapes", cr2w, this);
				}
				return _numShapes;
			}
			set
			{
				if (_numShapes == value)
				{
					return;
				}
				_numShapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("NumSpatialBuckets")] 
		public CUInt32 NumSpatialBuckets
		{
			get
			{
				if (_numSpatialBuckets == null)
				{
					_numSpatialBuckets = (CUInt32) CR2WTypeManager.Create("Uint32", "NumSpatialBuckets", cr2w, this);
				}
				return _numSpatialBuckets;
			}
			set
			{
				if (_numSpatialBuckets == value)
				{
					return;
				}
				_numSpatialBuckets = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("NumUniqueGeometry")] 
		public CUInt32 NumUniqueGeometry
		{
			get
			{
				if (_numUniqueGeometry == null)
				{
					_numUniqueGeometry = (CUInt32) CR2WTypeManager.Create("Uint32", "NumUniqueGeometry", cr2w, this);
				}
				return _numUniqueGeometry;
			}
			set
			{
				if (_numUniqueGeometry == value)
				{
					return;
				}
				_numUniqueGeometry = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("NumOwners")] 
		public CUInt32 NumOwners
		{
			get
			{
				if (_numOwners == null)
				{
					_numOwners = (CUInt32) CR2WTypeManager.Create("Uint32", "NumOwners", cr2w, this);
				}
				return _numOwners;
			}
			set
			{
				if (_numOwners == value)
				{
					return;
				}
				_numOwners = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "Version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public minimapEncodedShapes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
