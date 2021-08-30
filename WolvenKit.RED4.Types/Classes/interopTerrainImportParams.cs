using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopTerrainImportParams : RedBaseClass
	{
		private CUInt32 _cellRes;
		private CUInt32 _cellSize;
		private Vector3 _scale;
		private Vector3 _position;
		private Vector2 _extraOffset;
		private CUInt32 _tileWidth;
		private CUInt32 _tileHeight;
		private CUInt32 _prefabPlacementInterval;
		private CBool _importHeightMaps;
		private CBool _importColorMaps;
		private CBool _importControlMaps;
		private CBool _overwriteTransformsOfExistingNodes;
		private CString _nodesNamingPattern;
		private CString _prefabsNamingPattern;
		private CString _prefabsDestinationPath;
		private toolsEditorObjectIDPath _dstPrefabNodePath;

		[Ordinal(0)] 
		[RED("cellRes")] 
		public CUInt32 CellRes
		{
			get => GetProperty(ref _cellRes);
			set => SetProperty(ref _cellRes, value);
		}

		[Ordinal(1)] 
		[RED("cellSize")] 
		public CUInt32 CellSize
		{
			get => GetProperty(ref _cellSize);
			set => SetProperty(ref _cellSize, value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(4)] 
		[RED("extraOffset")] 
		public Vector2 ExtraOffset
		{
			get => GetProperty(ref _extraOffset);
			set => SetProperty(ref _extraOffset, value);
		}

		[Ordinal(5)] 
		[RED("tileWidth")] 
		public CUInt32 TileWidth
		{
			get => GetProperty(ref _tileWidth);
			set => SetProperty(ref _tileWidth, value);
		}

		[Ordinal(6)] 
		[RED("tileHeight")] 
		public CUInt32 TileHeight
		{
			get => GetProperty(ref _tileHeight);
			set => SetProperty(ref _tileHeight, value);
		}

		[Ordinal(7)] 
		[RED("prefabPlacementInterval")] 
		public CUInt32 PrefabPlacementInterval
		{
			get => GetProperty(ref _prefabPlacementInterval);
			set => SetProperty(ref _prefabPlacementInterval, value);
		}

		[Ordinal(8)] 
		[RED("importHeightMaps")] 
		public CBool ImportHeightMaps
		{
			get => GetProperty(ref _importHeightMaps);
			set => SetProperty(ref _importHeightMaps, value);
		}

		[Ordinal(9)] 
		[RED("importColorMaps")] 
		public CBool ImportColorMaps
		{
			get => GetProperty(ref _importColorMaps);
			set => SetProperty(ref _importColorMaps, value);
		}

		[Ordinal(10)] 
		[RED("importControlMaps")] 
		public CBool ImportControlMaps
		{
			get => GetProperty(ref _importControlMaps);
			set => SetProperty(ref _importControlMaps, value);
		}

		[Ordinal(11)] 
		[RED("overwriteTransformsOfExistingNodes")] 
		public CBool OverwriteTransformsOfExistingNodes
		{
			get => GetProperty(ref _overwriteTransformsOfExistingNodes);
			set => SetProperty(ref _overwriteTransformsOfExistingNodes, value);
		}

		[Ordinal(12)] 
		[RED("nodesNamingPattern")] 
		public CString NodesNamingPattern
		{
			get => GetProperty(ref _nodesNamingPattern);
			set => SetProperty(ref _nodesNamingPattern, value);
		}

		[Ordinal(13)] 
		[RED("prefabsNamingPattern")] 
		public CString PrefabsNamingPattern
		{
			get => GetProperty(ref _prefabsNamingPattern);
			set => SetProperty(ref _prefabsNamingPattern, value);
		}

		[Ordinal(14)] 
		[RED("prefabsDestinationPath")] 
		public CString PrefabsDestinationPath
		{
			get => GetProperty(ref _prefabsDestinationPath);
			set => SetProperty(ref _prefabsDestinationPath, value);
		}

		[Ordinal(15)] 
		[RED("dstPrefabNodePath")] 
		public toolsEditorObjectIDPath DstPrefabNodePath
		{
			get => GetProperty(ref _dstPrefabNodePath);
			set => SetProperty(ref _dstPrefabNodePath, value);
		}

		public interopTerrainImportParams()
		{
			_cellRes = 128;
			_cellSize = 256;
			_importHeightMaps = true;
			_importColorMaps = true;
			_importControlMaps = true;
			_overwriteTransformsOfExistingNodes = true;
		}
	}
}
