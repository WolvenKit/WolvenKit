using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTerrainCollisionNode : worldNode
	{
		private CArray<CName> _materials;
		private CArray<CUInt8> _materialIndices;
		private serializationDeferredDataBuffer _heightfieldGeometry;
		private WorldTransform _actorTransform;
		private Vector4 _extents;
		private CFloat _streamingDistance;
		private CFloat _rowScale;
		private CFloat _columnScale;
		private CFloat _heightScale;
		private CBool _increaseStreamingDistance;

		[Ordinal(4)] 
		[RED("materials")] 
		public CArray<CName> Materials
		{
			get
			{
				if (_materials == null)
				{
					_materials = (CArray<CName>) CR2WTypeManager.Create("array:CName", "materials", cr2w, this);
				}
				return _materials;
			}
			set
			{
				if (_materials == value)
				{
					return;
				}
				_materials = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("materialIndices")] 
		public CArray<CUInt8> MaterialIndices
		{
			get
			{
				if (_materialIndices == null)
				{
					_materialIndices = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "materialIndices", cr2w, this);
				}
				return _materialIndices;
			}
			set
			{
				if (_materialIndices == value)
				{
					return;
				}
				_materialIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("heightfieldGeometry")] 
		public serializationDeferredDataBuffer HeightfieldGeometry
		{
			get
			{
				if (_heightfieldGeometry == null)
				{
					_heightfieldGeometry = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "heightfieldGeometry", cr2w, this);
				}
				return _heightfieldGeometry;
			}
			set
			{
				if (_heightfieldGeometry == value)
				{
					return;
				}
				_heightfieldGeometry = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("actorTransform")] 
		public WorldTransform ActorTransform
		{
			get
			{
				if (_actorTransform == null)
				{
					_actorTransform = (WorldTransform) CR2WTypeManager.Create("WorldTransform", "actorTransform", cr2w, this);
				}
				return _actorTransform;
			}
			set
			{
				if (_actorTransform == value)
				{
					return;
				}
				_actorTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get
			{
				if (_extents == null)
				{
					_extents = (Vector4) CR2WTypeManager.Create("Vector4", "extents", cr2w, this);
				}
				return _extents;
			}
			set
			{
				if (_extents == value)
				{
					return;
				}
				_extents = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get
			{
				if (_streamingDistance == null)
				{
					_streamingDistance = (CFloat) CR2WTypeManager.Create("Float", "streamingDistance", cr2w, this);
				}
				return _streamingDistance;
			}
			set
			{
				if (_streamingDistance == value)
				{
					return;
				}
				_streamingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("rowScale")] 
		public CFloat RowScale
		{
			get
			{
				if (_rowScale == null)
				{
					_rowScale = (CFloat) CR2WTypeManager.Create("Float", "rowScale", cr2w, this);
				}
				return _rowScale;
			}
			set
			{
				if (_rowScale == value)
				{
					return;
				}
				_rowScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("columnScale")] 
		public CFloat ColumnScale
		{
			get
			{
				if (_columnScale == null)
				{
					_columnScale = (CFloat) CR2WTypeManager.Create("Float", "columnScale", cr2w, this);
				}
				return _columnScale;
			}
			set
			{
				if (_columnScale == value)
				{
					return;
				}
				_columnScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("heightScale")] 
		public CFloat HeightScale
		{
			get
			{
				if (_heightScale == null)
				{
					_heightScale = (CFloat) CR2WTypeManager.Create("Float", "heightScale", cr2w, this);
				}
				return _heightScale;
			}
			set
			{
				if (_heightScale == value)
				{
					return;
				}
				_heightScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("increaseStreamingDistance")] 
		public CBool IncreaseStreamingDistance
		{
			get
			{
				if (_increaseStreamingDistance == null)
				{
					_increaseStreamingDistance = (CBool) CR2WTypeManager.Create("Bool", "increaseStreamingDistance", cr2w, this);
				}
				return _increaseStreamingDistance;
			}
			set
			{
				if (_increaseStreamingDistance == value)
				{
					return;
				}
				_increaseStreamingDistance = value;
				PropertySet(this);
			}
		}

		public worldTerrainCollisionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
