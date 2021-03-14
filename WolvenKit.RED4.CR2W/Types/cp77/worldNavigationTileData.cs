using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileData : CVariable
	{
		private CInt32 _tileX;
		private CInt32 _tileY;
		private CInt32 _tileLayer;
		private DataBuffer _tilesBuffer;
		private CEnum<NavGenAgentSize> _agentSize;
		private worldOffMeshConnectionsData _offMeshConnections;
		private CBool _regenerable;

		[Ordinal(0)] 
		[RED("tileX")] 
		public CInt32 TileX
		{
			get
			{
				if (_tileX == null)
				{
					_tileX = (CInt32) CR2WTypeManager.Create("Int32", "tileX", cr2w, this);
				}
				return _tileX;
			}
			set
			{
				if (_tileX == value)
				{
					return;
				}
				_tileX = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tileY")] 
		public CInt32 TileY
		{
			get
			{
				if (_tileY == null)
				{
					_tileY = (CInt32) CR2WTypeManager.Create("Int32", "tileY", cr2w, this);
				}
				return _tileY;
			}
			set
			{
				if (_tileY == value)
				{
					return;
				}
				_tileY = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tileLayer")] 
		public CInt32 TileLayer
		{
			get
			{
				if (_tileLayer == null)
				{
					_tileLayer = (CInt32) CR2WTypeManager.Create("Int32", "tileLayer", cr2w, this);
				}
				return _tileLayer;
			}
			set
			{
				if (_tileLayer == value)
				{
					return;
				}
				_tileLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tilesBuffer")] 
		public DataBuffer TilesBuffer
		{
			get
			{
				if (_tilesBuffer == null)
				{
					_tilesBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "tilesBuffer", cr2w, this);
				}
				return _tilesBuffer;
			}
			set
			{
				if (_tilesBuffer == value)
				{
					return;
				}
				_tilesBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get
			{
				if (_agentSize == null)
				{
					_agentSize = (CEnum<NavGenAgentSize>) CR2WTypeManager.Create("NavGenAgentSize", "agentSize", cr2w, this);
				}
				return _agentSize;
			}
			set
			{
				if (_agentSize == value)
				{
					return;
				}
				_agentSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("offMeshConnections")] 
		public worldOffMeshConnectionsData OffMeshConnections
		{
			get
			{
				if (_offMeshConnections == null)
				{
					_offMeshConnections = (worldOffMeshConnectionsData) CR2WTypeManager.Create("worldOffMeshConnectionsData", "offMeshConnections", cr2w, this);
				}
				return _offMeshConnections;
			}
			set
			{
				if (_offMeshConnections == value)
				{
					return;
				}
				_offMeshConnections = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("regenerable")] 
		public CBool Regenerable
		{
			get
			{
				if (_regenerable == null)
				{
					_regenerable = (CBool) CR2WTypeManager.Create("Bool", "regenerable", cr2w, this);
				}
				return _regenerable;
			}
			set
			{
				if (_regenerable == value)
				{
					return;
				}
				_regenerable = value;
				PropertySet(this);
			}
		}

		public worldNavigationTileData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
