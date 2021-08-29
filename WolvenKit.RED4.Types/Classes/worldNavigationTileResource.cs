using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationTileResource : resStreamedResource
	{
		private Box _localBoundingBox;
		private CArray<worldNavigationTileData> _tilesData;

		[Ordinal(1)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get => GetProperty(ref _localBoundingBox);
			set => SetProperty(ref _localBoundingBox, value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public CArray<worldNavigationTileData> TilesData
		{
			get => GetProperty(ref _tilesData);
			set => SetProperty(ref _tilesData, value);
		}
	}
}
