using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationTileData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tileX")] 
		public CInt32 TileX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("tileY")] 
		public CInt32 TileY
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("tilesBuffer")] 
		public DataBuffer TilesBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(3)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetPropertyValue<CEnum<NavGenAgentSize>>();
			set => SetPropertyValue<CEnum<NavGenAgentSize>>(value);
		}

		[Ordinal(4)] 
		[RED("offMeshConnections")] 
		public worldOffMeshConnectionsData OffMeshConnections
		{
			get => GetPropertyValue<worldOffMeshConnectionsData>();
			set => SetPropertyValue<worldOffMeshConnectionsData>(value);
		}

		public worldNavigationTileData()
		{
			OffMeshConnections = new worldOffMeshConnectionsData { Verts = new(), Radii = new(), Flags = new(), Areas = new(), Directions = new(), Ids = new(), TagIntervals = new(), TagsX = new(), GlobalNodeIDs = new(), UserData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
