using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportParams : CVariable
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
			get
			{
				if (_cellRes == null)
				{
					_cellRes = (CUInt32) CR2WTypeManager.Create("Uint32", "cellRes", cr2w, this);
				}
				return _cellRes;
			}
			set
			{
				if (_cellRes == value)
				{
					return;
				}
				_cellRes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cellSize")] 
		public CUInt32 CellSize
		{
			get
			{
				if (_cellSize == null)
				{
					_cellSize = (CUInt32) CR2WTypeManager.Create("Uint32", "cellSize", cr2w, this);
				}
				return _cellSize;
			}
			set
			{
				if (_cellSize == value)
				{
					return;
				}
				_cellSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scale")] 
		public Vector3 Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (Vector3) CR2WTypeManager.Create("Vector3", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("extraOffset")] 
		public Vector2 ExtraOffset
		{
			get
			{
				if (_extraOffset == null)
				{
					_extraOffset = (Vector2) CR2WTypeManager.Create("Vector2", "extraOffset", cr2w, this);
				}
				return _extraOffset;
			}
			set
			{
				if (_extraOffset == value)
				{
					return;
				}
				_extraOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("tileWidth")] 
		public CUInt32 TileWidth
		{
			get
			{
				if (_tileWidth == null)
				{
					_tileWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "tileWidth", cr2w, this);
				}
				return _tileWidth;
			}
			set
			{
				if (_tileWidth == value)
				{
					return;
				}
				_tileWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tileHeight")] 
		public CUInt32 TileHeight
		{
			get
			{
				if (_tileHeight == null)
				{
					_tileHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "tileHeight", cr2w, this);
				}
				return _tileHeight;
			}
			set
			{
				if (_tileHeight == value)
				{
					return;
				}
				_tileHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("prefabPlacementInterval")] 
		public CUInt32 PrefabPlacementInterval
		{
			get
			{
				if (_prefabPlacementInterval == null)
				{
					_prefabPlacementInterval = (CUInt32) CR2WTypeManager.Create("Uint32", "prefabPlacementInterval", cr2w, this);
				}
				return _prefabPlacementInterval;
			}
			set
			{
				if (_prefabPlacementInterval == value)
				{
					return;
				}
				_prefabPlacementInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("importHeightMaps")] 
		public CBool ImportHeightMaps
		{
			get
			{
				if (_importHeightMaps == null)
				{
					_importHeightMaps = (CBool) CR2WTypeManager.Create("Bool", "importHeightMaps", cr2w, this);
				}
				return _importHeightMaps;
			}
			set
			{
				if (_importHeightMaps == value)
				{
					return;
				}
				_importHeightMaps = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("importColorMaps")] 
		public CBool ImportColorMaps
		{
			get
			{
				if (_importColorMaps == null)
				{
					_importColorMaps = (CBool) CR2WTypeManager.Create("Bool", "importColorMaps", cr2w, this);
				}
				return _importColorMaps;
			}
			set
			{
				if (_importColorMaps == value)
				{
					return;
				}
				_importColorMaps = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("importControlMaps")] 
		public CBool ImportControlMaps
		{
			get
			{
				if (_importControlMaps == null)
				{
					_importControlMaps = (CBool) CR2WTypeManager.Create("Bool", "importControlMaps", cr2w, this);
				}
				return _importControlMaps;
			}
			set
			{
				if (_importControlMaps == value)
				{
					return;
				}
				_importControlMaps = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("overwriteTransformsOfExistingNodes")] 
		public CBool OverwriteTransformsOfExistingNodes
		{
			get
			{
				if (_overwriteTransformsOfExistingNodes == null)
				{
					_overwriteTransformsOfExistingNodes = (CBool) CR2WTypeManager.Create("Bool", "overwriteTransformsOfExistingNodes", cr2w, this);
				}
				return _overwriteTransformsOfExistingNodes;
			}
			set
			{
				if (_overwriteTransformsOfExistingNodes == value)
				{
					return;
				}
				_overwriteTransformsOfExistingNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("nodesNamingPattern")] 
		public CString NodesNamingPattern
		{
			get
			{
				if (_nodesNamingPattern == null)
				{
					_nodesNamingPattern = (CString) CR2WTypeManager.Create("String", "nodesNamingPattern", cr2w, this);
				}
				return _nodesNamingPattern;
			}
			set
			{
				if (_nodesNamingPattern == value)
				{
					return;
				}
				_nodesNamingPattern = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("prefabsNamingPattern")] 
		public CString PrefabsNamingPattern
		{
			get
			{
				if (_prefabsNamingPattern == null)
				{
					_prefabsNamingPattern = (CString) CR2WTypeManager.Create("String", "prefabsNamingPattern", cr2w, this);
				}
				return _prefabsNamingPattern;
			}
			set
			{
				if (_prefabsNamingPattern == value)
				{
					return;
				}
				_prefabsNamingPattern = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("prefabsDestinationPath")] 
		public CString PrefabsDestinationPath
		{
			get
			{
				if (_prefabsDestinationPath == null)
				{
					_prefabsDestinationPath = (CString) CR2WTypeManager.Create("String", "prefabsDestinationPath", cr2w, this);
				}
				return _prefabsDestinationPath;
			}
			set
			{
				if (_prefabsDestinationPath == value)
				{
					return;
				}
				_prefabsDestinationPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dstPrefabNodePath")] 
		public toolsEditorObjectIDPath DstPrefabNodePath
		{
			get
			{
				if (_dstPrefabNodePath == null)
				{
					_dstPrefabNodePath = (toolsEditorObjectIDPath) CR2WTypeManager.Create("toolsEditorObjectIDPath", "dstPrefabNodePath", cr2w, this);
				}
				return _dstPrefabNodePath;
			}
			set
			{
				if (_dstPrefabNodePath == value)
				{
					return;
				}
				_dstPrefabNodePath = value;
				PropertySet(this);
			}
		}

		public interopTerrainImportParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
