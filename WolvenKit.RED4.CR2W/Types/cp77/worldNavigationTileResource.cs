using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileResource : resStreamedResource
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

		public worldNavigationTileResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
