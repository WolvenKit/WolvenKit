using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryDescriptionQuery : IScriptable
	{
		private Vector4 _refPosition;
		private Vector4 _refDirection;
		private Vector4 _refUp;
		private Vector4 _primitiveDimension;
		private Quaternion _primitiveRotation;
		private CFloat _maxDistance;
		private CFloat _maxExtent;
		private CFloat _raycastStartDistance;
		private CFloat _probingPrecision;
		private CFloat _probingMaxDistanceDiff;
		private CUInt32 _maxProbes;
		private Vector4 _probeDimensions;
		private physicsQueryFilter _filter;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("refPosition")] 
		public Vector4 RefPosition
		{
			get
			{
				if (_refPosition == null)
				{
					_refPosition = (Vector4) CR2WTypeManager.Create("Vector4", "refPosition", cr2w, this);
				}
				return _refPosition;
			}
			set
			{
				if (_refPosition == value)
				{
					return;
				}
				_refPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("refDirection")] 
		public Vector4 RefDirection
		{
			get
			{
				if (_refDirection == null)
				{
					_refDirection = (Vector4) CR2WTypeManager.Create("Vector4", "refDirection", cr2w, this);
				}
				return _refDirection;
			}
			set
			{
				if (_refDirection == value)
				{
					return;
				}
				_refDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("refUp")] 
		public Vector4 RefUp
		{
			get
			{
				if (_refUp == null)
				{
					_refUp = (Vector4) CR2WTypeManager.Create("Vector4", "refUp", cr2w, this);
				}
				return _refUp;
			}
			set
			{
				if (_refUp == value)
				{
					return;
				}
				_refUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("primitiveDimension")] 
		public Vector4 PrimitiveDimension
		{
			get
			{
				if (_primitiveDimension == null)
				{
					_primitiveDimension = (Vector4) CR2WTypeManager.Create("Vector4", "primitiveDimension", cr2w, this);
				}
				return _primitiveDimension;
			}
			set
			{
				if (_primitiveDimension == value)
				{
					return;
				}
				_primitiveDimension = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("primitiveRotation")] 
		public Quaternion PrimitiveRotation
		{
			get
			{
				if (_primitiveRotation == null)
				{
					_primitiveRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "primitiveRotation", cr2w, this);
				}
				return _primitiveRotation;
			}
			set
			{
				if (_primitiveRotation == value)
				{
					return;
				}
				_primitiveRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxExtent")] 
		public CFloat MaxExtent
		{
			get
			{
				if (_maxExtent == null)
				{
					_maxExtent = (CFloat) CR2WTypeManager.Create("Float", "maxExtent", cr2w, this);
				}
				return _maxExtent;
			}
			set
			{
				if (_maxExtent == value)
				{
					return;
				}
				_maxExtent = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("raycastStartDistance")] 
		public CFloat RaycastStartDistance
		{
			get
			{
				if (_raycastStartDistance == null)
				{
					_raycastStartDistance = (CFloat) CR2WTypeManager.Create("Float", "raycastStartDistance", cr2w, this);
				}
				return _raycastStartDistance;
			}
			set
			{
				if (_raycastStartDistance == value)
				{
					return;
				}
				_raycastStartDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("probingPrecision")] 
		public CFloat ProbingPrecision
		{
			get
			{
				if (_probingPrecision == null)
				{
					_probingPrecision = (CFloat) CR2WTypeManager.Create("Float", "probingPrecision", cr2w, this);
				}
				return _probingPrecision;
			}
			set
			{
				if (_probingPrecision == value)
				{
					return;
				}
				_probingPrecision = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("probingMaxDistanceDiff")] 
		public CFloat ProbingMaxDistanceDiff
		{
			get
			{
				if (_probingMaxDistanceDiff == null)
				{
					_probingMaxDistanceDiff = (CFloat) CR2WTypeManager.Create("Float", "probingMaxDistanceDiff", cr2w, this);
				}
				return _probingMaxDistanceDiff;
			}
			set
			{
				if (_probingMaxDistanceDiff == value)
				{
					return;
				}
				_probingMaxDistanceDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxProbes")] 
		public CUInt32 MaxProbes
		{
			get
			{
				if (_maxProbes == null)
				{
					_maxProbes = (CUInt32) CR2WTypeManager.Create("Uint32", "maxProbes", cr2w, this);
				}
				return _maxProbes;
			}
			set
			{
				if (_maxProbes == value)
				{
					return;
				}
				_maxProbes = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("probeDimensions")] 
		public Vector4 ProbeDimensions
		{
			get
			{
				if (_probeDimensions == null)
				{
					_probeDimensions = (Vector4) CR2WTypeManager.Create("Vector4", "probeDimensions", cr2w, this);
				}
				return _probeDimensions;
			}
			set
			{
				if (_probeDimensions == value)
				{
					return;
				}
				_probeDimensions = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("filter")] 
		public physicsQueryFilter Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (physicsQueryFilter) CR2WTypeManager.Create("physicsQueryFilter", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt32) CR2WTypeManager.Create("Uint32", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public worldgeometryDescriptionQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
