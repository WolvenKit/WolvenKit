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
		[RED("tileIndex")] 
		public CUInt32 TileIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("bufferIndex")] 
		public CUInt32 BufferIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetPropertyValue<CEnum<NavGenAgentSize>>();
			set => SetPropertyValue<CEnum<NavGenAgentSize>>(value);
		}

		[Ordinal(5)] 
		[RED("offMeshConnections")] 
		public worldOffMeshConnectionsData OffMeshConnections
		{
			get => GetPropertyValue<worldOffMeshConnectionsData>();
			set => SetPropertyValue<worldOffMeshConnectionsData>(value);
		}

		[Ordinal(6)] 
		[RED("tileRef")] 
		public CUInt64 TileRef
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(7)] 
		[RED("activeVariantIDs")] 
		public CArray<CUInt32> ActiveVariantIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(8)] 
		[RED("allVariantIDs")] 
		public CArray<CUInt32> AllVariantIDs
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public worldNavigationTileData()
		{
			TileIndex = uint.MaxValue;
			BufferIndex = uint.MaxValue;
			OffMeshConnections = new worldOffMeshConnectionsData { Verts = new(), Radii = new(), Flags = new(), Areas = new(), Directions = new(), Ids = new(), TagIntervals = new(), TagsX = new(), GlobalNodeIDs = new(), UserData = new() };
			TileRef = long.MaxValue;
			ActiveVariantIDs = new();
			AllVariantIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
