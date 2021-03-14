using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainNodeInfo : CVariable
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CBool _externalDataSource;
		private CBool _isTerrainNode;
		private CUInt8 _blendOrder;
		private CBool _blendModeHeightIsIgnore;
		private CBool _blendModeHeightIsNormal;
		private CBool _blendModeColorIsIgnore;
		private CBool _blendModeHolesIsIgnore;
		private CUInt16 _terrainSysID;
		private CString _nodeName;
		private Vector3 _nodeScale;
		private Transform _nodeTransform;
		private CFloat _nodeCellResScale;
		private CFloat _densityTexelSize;
		private toolsEditorObjectIDPath _nodeIDPath;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CUInt32) CR2WTypeManager.Create("Uint32", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CUInt32) CR2WTypeManager.Create("Uint32", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("externalDataSource")] 
		public CBool ExternalDataSource
		{
			get
			{
				if (_externalDataSource == null)
				{
					_externalDataSource = (CBool) CR2WTypeManager.Create("Bool", "externalDataSource", cr2w, this);
				}
				return _externalDataSource;
			}
			set
			{
				if (_externalDataSource == value)
				{
					return;
				}
				_externalDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isTerrainNode")] 
		public CBool IsTerrainNode
		{
			get
			{
				if (_isTerrainNode == null)
				{
					_isTerrainNode = (CBool) CR2WTypeManager.Create("Bool", "isTerrainNode", cr2w, this);
				}
				return _isTerrainNode;
			}
			set
			{
				if (_isTerrainNode == value)
				{
					return;
				}
				_isTerrainNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("blendOrder")] 
		public CUInt8 BlendOrder
		{
			get
			{
				if (_blendOrder == null)
				{
					_blendOrder = (CUInt8) CR2WTypeManager.Create("Uint8", "blendOrder", cr2w, this);
				}
				return _blendOrder;
			}
			set
			{
				if (_blendOrder == value)
				{
					return;
				}
				_blendOrder = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blendModeHeightIsIgnore")] 
		public CBool BlendModeHeightIsIgnore
		{
			get
			{
				if (_blendModeHeightIsIgnore == null)
				{
					_blendModeHeightIsIgnore = (CBool) CR2WTypeManager.Create("Bool", "blendModeHeightIsIgnore", cr2w, this);
				}
				return _blendModeHeightIsIgnore;
			}
			set
			{
				if (_blendModeHeightIsIgnore == value)
				{
					return;
				}
				_blendModeHeightIsIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blendModeHeightIsNormal")] 
		public CBool BlendModeHeightIsNormal
		{
			get
			{
				if (_blendModeHeightIsNormal == null)
				{
					_blendModeHeightIsNormal = (CBool) CR2WTypeManager.Create("Bool", "blendModeHeightIsNormal", cr2w, this);
				}
				return _blendModeHeightIsNormal;
			}
			set
			{
				if (_blendModeHeightIsNormal == value)
				{
					return;
				}
				_blendModeHeightIsNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("blendModeColorIsIgnore")] 
		public CBool BlendModeColorIsIgnore
		{
			get
			{
				if (_blendModeColorIsIgnore == null)
				{
					_blendModeColorIsIgnore = (CBool) CR2WTypeManager.Create("Bool", "blendModeColorIsIgnore", cr2w, this);
				}
				return _blendModeColorIsIgnore;
			}
			set
			{
				if (_blendModeColorIsIgnore == value)
				{
					return;
				}
				_blendModeColorIsIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("blendModeHolesIsIgnore")] 
		public CBool BlendModeHolesIsIgnore
		{
			get
			{
				if (_blendModeHolesIsIgnore == null)
				{
					_blendModeHolesIsIgnore = (CBool) CR2WTypeManager.Create("Bool", "blendModeHolesIsIgnore", cr2w, this);
				}
				return _blendModeHolesIsIgnore;
			}
			set
			{
				if (_blendModeHolesIsIgnore == value)
				{
					return;
				}
				_blendModeHolesIsIgnore = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("terrainSysID")] 
		public CUInt16 TerrainSysID
		{
			get
			{
				if (_terrainSysID == null)
				{
					_terrainSysID = (CUInt16) CR2WTypeManager.Create("Uint16", "terrainSysID", cr2w, this);
				}
				return _terrainSysID;
			}
			set
			{
				if (_terrainSysID == value)
				{
					return;
				}
				_terrainSysID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("nodeName")] 
		public CString NodeName
		{
			get
			{
				if (_nodeName == null)
				{
					_nodeName = (CString) CR2WTypeManager.Create("String", "nodeName", cr2w, this);
				}
				return _nodeName;
			}
			set
			{
				if (_nodeName == value)
				{
					return;
				}
				_nodeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("nodeScale")] 
		public Vector3 NodeScale
		{
			get
			{
				if (_nodeScale == null)
				{
					_nodeScale = (Vector3) CR2WTypeManager.Create("Vector3", "nodeScale", cr2w, this);
				}
				return _nodeScale;
			}
			set
			{
				if (_nodeScale == value)
				{
					return;
				}
				_nodeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("nodeTransform")] 
		public Transform NodeTransform
		{
			get
			{
				if (_nodeTransform == null)
				{
					_nodeTransform = (Transform) CR2WTypeManager.Create("Transform", "nodeTransform", cr2w, this);
				}
				return _nodeTransform;
			}
			set
			{
				if (_nodeTransform == value)
				{
					return;
				}
				_nodeTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("nodeCellResScale")] 
		public CFloat NodeCellResScale
		{
			get
			{
				if (_nodeCellResScale == null)
				{
					_nodeCellResScale = (CFloat) CR2WTypeManager.Create("Float", "nodeCellResScale", cr2w, this);
				}
				return _nodeCellResScale;
			}
			set
			{
				if (_nodeCellResScale == value)
				{
					return;
				}
				_nodeCellResScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("densityTexelSize")] 
		public CFloat DensityTexelSize
		{
			get
			{
				if (_densityTexelSize == null)
				{
					_densityTexelSize = (CFloat) CR2WTypeManager.Create("Float", "densityTexelSize", cr2w, this);
				}
				return _densityTexelSize;
			}
			set
			{
				if (_densityTexelSize == value)
				{
					return;
				}
				_densityTexelSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("nodeIDPath")] 
		public toolsEditorObjectIDPath NodeIDPath
		{
			get
			{
				if (_nodeIDPath == null)
				{
					_nodeIDPath = (toolsEditorObjectIDPath) CR2WTypeManager.Create("toolsEditorObjectIDPath", "nodeIDPath", cr2w, this);
				}
				return _nodeIDPath;
			}
			set
			{
				if (_nodeIDPath == value)
				{
					return;
				}
				_nodeIDPath = value;
				PropertySet(this);
			}
		}

		public interopTerrainNodeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
