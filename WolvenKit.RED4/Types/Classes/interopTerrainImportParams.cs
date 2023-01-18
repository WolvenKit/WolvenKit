using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainImportParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cellRes")] 
		public CUInt32 CellRes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("cellSize")] 
		public CUInt32 CellSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("extraOffset")] 
		public Vector2 ExtraOffset
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("tileWidth")] 
		public CUInt32 TileWidth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("tileHeight")] 
		public CUInt32 TileHeight
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("prefabPlacementInterval")] 
		public CUInt32 PrefabPlacementInterval
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("importHeightMaps")] 
		public CBool ImportHeightMaps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("importColorMaps")] 
		public CBool ImportColorMaps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("importControlMaps")] 
		public CBool ImportControlMaps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("overwriteTransformsOfExistingNodes")] 
		public CBool OverwriteTransformsOfExistingNodes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("nodesNamingPattern")] 
		public CString NodesNamingPattern
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("prefabsNamingPattern")] 
		public CString PrefabsNamingPattern
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("prefabsDestinationPath")] 
		public CString PrefabsDestinationPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("dstPrefabNodePath")] 
		public toolsEditorObjectIDPath DstPrefabNodePath
		{
			get => GetPropertyValue<toolsEditorObjectIDPath>();
			set => SetPropertyValue<toolsEditorObjectIDPath>(value);
		}

		public interopTerrainImportParams()
		{
			CellRes = 128;
			CellSize = 256;
			Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			Position = new();
			ExtraOffset = new();
			ImportHeightMaps = true;
			ImportColorMaps = true;
			ImportControlMaps = true;
			OverwriteTransformsOfExistingNodes = true;
			DstPrefabNodePath = new() { Elements = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
