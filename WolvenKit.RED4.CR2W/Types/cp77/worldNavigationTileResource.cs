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
			get
			{
				if (_localBoundingBox == null)
				{
					_localBoundingBox = (Box) CR2WTypeManager.Create("Box", "localBoundingBox", cr2w, this);
				}
				return _localBoundingBox;
			}
			set
			{
				if (_localBoundingBox == value)
				{
					return;
				}
				_localBoundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public CArray<worldNavigationTileData> TilesData
		{
			get
			{
				if (_tilesData == null)
				{
					_tilesData = (CArray<worldNavigationTileData>) CR2WTypeManager.Create("array:worldNavigationTileData", "tilesData", cr2w, this);
				}
				return _tilesData;
			}
			set
			{
				if (_tilesData == value)
				{
					return;
				}
				_tilesData = value;
				PropertySet(this);
			}
		}

		public worldNavigationTileResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
