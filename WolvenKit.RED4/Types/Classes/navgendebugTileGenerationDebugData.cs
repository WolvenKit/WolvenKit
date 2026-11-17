using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugTileGenerationDebugData : ISerializable
	{
		[Ordinal(0)] 
		[RED("tileIndex")] 
		public CUInt32 TileIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("heightfield")] 
		public navgendebugHeightfield Heightfield
		{
			get => GetPropertyValue<navgendebugHeightfield>();
			set => SetPropertyValue<navgendebugHeightfield>(value);
		}

		[Ordinal(2)] 
		[RED("contours")] 
		public navgendebugContourSet Contours
		{
			get => GetPropertyValue<navgendebugContourSet>();
			set => SetPropertyValue<navgendebugContourSet>(value);
		}

		[Ordinal(3)] 
		[RED("polyMesh")] 
		public navgendebugPolyMesh PolyMesh
		{
			get => GetPropertyValue<navgendebugPolyMesh>();
			set => SetPropertyValue<navgendebugPolyMesh>(value);
		}

		public navgendebugTileGenerationDebugData()
		{
			Heightfield = new navgendebugHeightfield();
			Contours = new navgendebugContourSet();
			PolyMesh = new navgendebugPolyMesh();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
