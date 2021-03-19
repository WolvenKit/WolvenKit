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
			get => GetProperty(ref _tileX);
			set => SetProperty(ref _tileX, value);
		}

		[Ordinal(1)] 
		[RED("tileY")] 
		public CInt32 TileY
		{
			get => GetProperty(ref _tileY);
			set => SetProperty(ref _tileY, value);
		}

		[Ordinal(2)] 
		[RED("tileLayer")] 
		public CInt32 TileLayer
		{
			get => GetProperty(ref _tileLayer);
			set => SetProperty(ref _tileLayer, value);
		}

		[Ordinal(3)] 
		[RED("tilesBuffer")] 
		public DataBuffer TilesBuffer
		{
			get => GetProperty(ref _tilesBuffer);
			set => SetProperty(ref _tilesBuffer, value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetProperty(ref _agentSize);
			set => SetProperty(ref _agentSize, value);
		}

		[Ordinal(5)] 
		[RED("offMeshConnections")] 
		public worldOffMeshConnectionsData OffMeshConnections
		{
			get => GetProperty(ref _offMeshConnections);
			set => SetProperty(ref _offMeshConnections, value);
		}

		[Ordinal(6)] 
		[RED("regenerable")] 
		public CBool Regenerable
		{
			get => GetProperty(ref _regenerable);
			set => SetProperty(ref _regenerable, value);
		}

		public worldNavigationTileData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
