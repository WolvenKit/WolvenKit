using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entGarmentParameterComponentData : CVariable
	{
		private CRUID _componentID;
		private CUInt64 _meshGeometryHash;
		private CArray<entGarmentParameterChunkData> _chunks;
		private CBool _hideComponent;
		private CFloat _bendPowerMultiplier;
		private CFloat _bendPowerOffset;
		private CFloat _smoothingStrength;
		private CFloat _smoothingThreshold;
		private CFloat _smoothingExponent;
		private CUInt32 _smoothingNumNeighbours;
		private CFloat _garmentBorderThreshold;
		private CBool _removeHiddenTriangles;
		private CBool _disableGarment;
		private CBool _mergeWithInnerLayer;

		[Ordinal(0)] 
		[RED("componentID")] 
		public CRUID ComponentID
		{
			get
			{
				if (_componentID == null)
				{
					_componentID = (CRUID) CR2WTypeManager.Create("CRUID", "componentID", cr2w, this);
				}
				return _componentID;
			}
			set
			{
				if (_componentID == value)
				{
					return;
				}
				_componentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshGeometryHash")] 
		public CUInt64 MeshGeometryHash
		{
			get
			{
				if (_meshGeometryHash == null)
				{
					_meshGeometryHash = (CUInt64) CR2WTypeManager.Create("Uint64", "meshGeometryHash", cr2w, this);
				}
				return _meshGeometryHash;
			}
			set
			{
				if (_meshGeometryHash == value)
				{
					return;
				}
				_meshGeometryHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chunks")] 
		public CArray<entGarmentParameterChunkData> Chunks
		{
			get
			{
				if (_chunks == null)
				{
					_chunks = (CArray<entGarmentParameterChunkData>) CR2WTypeManager.Create("array:entGarmentParameterChunkData", "chunks", cr2w, this);
				}
				return _chunks;
			}
			set
			{
				if (_chunks == value)
				{
					return;
				}
				_chunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hideComponent")] 
		public CBool HideComponent
		{
			get
			{
				if (_hideComponent == null)
				{
					_hideComponent = (CBool) CR2WTypeManager.Create("Bool", "hideComponent", cr2w, this);
				}
				return _hideComponent;
			}
			set
			{
				if (_hideComponent == value)
				{
					return;
				}
				_hideComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bendPowerMultiplier")] 
		public CFloat BendPowerMultiplier
		{
			get
			{
				if (_bendPowerMultiplier == null)
				{
					_bendPowerMultiplier = (CFloat) CR2WTypeManager.Create("Float", "bendPowerMultiplier", cr2w, this);
				}
				return _bendPowerMultiplier;
			}
			set
			{
				if (_bendPowerMultiplier == value)
				{
					return;
				}
				_bendPowerMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bendPowerOffset")] 
		public CFloat BendPowerOffset
		{
			get
			{
				if (_bendPowerOffset == null)
				{
					_bendPowerOffset = (CFloat) CR2WTypeManager.Create("Float", "bendPowerOffset", cr2w, this);
				}
				return _bendPowerOffset;
			}
			set
			{
				if (_bendPowerOffset == value)
				{
					return;
				}
				_bendPowerOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get
			{
				if (_smoothingStrength == null)
				{
					_smoothingStrength = (CFloat) CR2WTypeManager.Create("Float", "smoothingStrength", cr2w, this);
				}
				return _smoothingStrength;
			}
			set
			{
				if (_smoothingStrength == value)
				{
					return;
				}
				_smoothingStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("smoothingThreshold")] 
		public CFloat SmoothingThreshold
		{
			get
			{
				if (_smoothingThreshold == null)
				{
					_smoothingThreshold = (CFloat) CR2WTypeManager.Create("Float", "smoothingThreshold", cr2w, this);
				}
				return _smoothingThreshold;
			}
			set
			{
				if (_smoothingThreshold == value)
				{
					return;
				}
				_smoothingThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get
			{
				if (_smoothingExponent == null)
				{
					_smoothingExponent = (CFloat) CR2WTypeManager.Create("Float", "smoothingExponent", cr2w, this);
				}
				return _smoothingExponent;
			}
			set
			{
				if (_smoothingExponent == value)
				{
					return;
				}
				_smoothingExponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get
			{
				if (_smoothingNumNeighbours == null)
				{
					_smoothingNumNeighbours = (CUInt32) CR2WTypeManager.Create("Uint32", "smoothingNumNeighbours", cr2w, this);
				}
				return _smoothingNumNeighbours;
			}
			set
			{
				if (_smoothingNumNeighbours == value)
				{
					return;
				}
				_smoothingNumNeighbours = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get
			{
				if (_garmentBorderThreshold == null)
				{
					_garmentBorderThreshold = (CFloat) CR2WTypeManager.Create("Float", "garmentBorderThreshold", cr2w, this);
				}
				return _garmentBorderThreshold;
			}
			set
			{
				if (_garmentBorderThreshold == value)
				{
					return;
				}
				_garmentBorderThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get
			{
				if (_removeHiddenTriangles == null)
				{
					_removeHiddenTriangles = (CBool) CR2WTypeManager.Create("Bool", "removeHiddenTriangles", cr2w, this);
				}
				return _removeHiddenTriangles;
			}
			set
			{
				if (_removeHiddenTriangles == value)
				{
					return;
				}
				_removeHiddenTriangles = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("disableGarment")] 
		public CBool DisableGarment
		{
			get
			{
				if (_disableGarment == null)
				{
					_disableGarment = (CBool) CR2WTypeManager.Create("Bool", "disableGarment", cr2w, this);
				}
				return _disableGarment;
			}
			set
			{
				if (_disableGarment == value)
				{
					return;
				}
				_disableGarment = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("mergeWithInnerLayer")] 
		public CBool MergeWithInnerLayer
		{
			get
			{
				if (_mergeWithInnerLayer == null)
				{
					_mergeWithInnerLayer = (CBool) CR2WTypeManager.Create("Bool", "mergeWithInnerLayer", cr2w, this);
				}
				return _mergeWithInnerLayer;
			}
			set
			{
				if (_mergeWithInnerLayer == value)
				{
					return;
				}
				_mergeWithInnerLayer = value;
				PropertySet(this);
			}
		}

		public entGarmentParameterComponentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
