using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationTileResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public CArray<worldNavigationTileData> TilesData
		{
			get => GetPropertyValue<CArray<worldNavigationTileData>>();
			set => SetPropertyValue<CArray<worldNavigationTileData>>(value);
		}

		[Ordinal(3)] 
		[RED("tileBuffers")] 
		public CArray<DataBuffer> TileBuffers
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetPropertyValue<CEnum<NavGenAgentSize>>();
			set => SetPropertyValue<CEnum<NavGenAgentSize>>(value);
		}

		public worldNavigationTileResource()
		{
			LocalBoundingBox = new Box { Min = new Vector4 { W = 1.000000F }, Max = new Vector4 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };
			TilesData = new();
			TileBuffers = new();
			AgentSize = Enums.NavGenAgentSize.AgentSize_Count;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
