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
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(2)] 
		[RED("externalDataSource")] 
		public CBool ExternalDataSource
		{
			get => GetProperty(ref _externalDataSource);
			set => SetProperty(ref _externalDataSource, value);
		}

		[Ordinal(3)] 
		[RED("isTerrainNode")] 
		public CBool IsTerrainNode
		{
			get => GetProperty(ref _isTerrainNode);
			set => SetProperty(ref _isTerrainNode, value);
		}

		[Ordinal(4)] 
		[RED("blendOrder")] 
		public CUInt8 BlendOrder
		{
			get => GetProperty(ref _blendOrder);
			set => SetProperty(ref _blendOrder, value);
		}

		[Ordinal(5)] 
		[RED("blendModeHeightIsIgnore")] 
		public CBool BlendModeHeightIsIgnore
		{
			get => GetProperty(ref _blendModeHeightIsIgnore);
			set => SetProperty(ref _blendModeHeightIsIgnore, value);
		}

		[Ordinal(6)] 
		[RED("blendModeHeightIsNormal")] 
		public CBool BlendModeHeightIsNormal
		{
			get => GetProperty(ref _blendModeHeightIsNormal);
			set => SetProperty(ref _blendModeHeightIsNormal, value);
		}

		[Ordinal(7)] 
		[RED("blendModeColorIsIgnore")] 
		public CBool BlendModeColorIsIgnore
		{
			get => GetProperty(ref _blendModeColorIsIgnore);
			set => SetProperty(ref _blendModeColorIsIgnore, value);
		}

		[Ordinal(8)] 
		[RED("blendModeHolesIsIgnore")] 
		public CBool BlendModeHolesIsIgnore
		{
			get => GetProperty(ref _blendModeHolesIsIgnore);
			set => SetProperty(ref _blendModeHolesIsIgnore, value);
		}

		[Ordinal(9)] 
		[RED("terrainSysID")] 
		public CUInt16 TerrainSysID
		{
			get => GetProperty(ref _terrainSysID);
			set => SetProperty(ref _terrainSysID, value);
		}

		[Ordinal(10)] 
		[RED("nodeName")] 
		public CString NodeName
		{
			get => GetProperty(ref _nodeName);
			set => SetProperty(ref _nodeName, value);
		}

		[Ordinal(11)] 
		[RED("nodeScale")] 
		public Vector3 NodeScale
		{
			get => GetProperty(ref _nodeScale);
			set => SetProperty(ref _nodeScale, value);
		}

		[Ordinal(12)] 
		[RED("nodeTransform")] 
		public Transform NodeTransform
		{
			get => GetProperty(ref _nodeTransform);
			set => SetProperty(ref _nodeTransform, value);
		}

		[Ordinal(13)] 
		[RED("nodeCellResScale")] 
		public CFloat NodeCellResScale
		{
			get => GetProperty(ref _nodeCellResScale);
			set => SetProperty(ref _nodeCellResScale, value);
		}

		[Ordinal(14)] 
		[RED("densityTexelSize")] 
		public CFloat DensityTexelSize
		{
			get => GetProperty(ref _densityTexelSize);
			set => SetProperty(ref _densityTexelSize, value);
		}

		[Ordinal(15)] 
		[RED("nodeIDPath")] 
		public toolsEditorObjectIDPath NodeIDPath
		{
			get => GetProperty(ref _nodeIDPath);
			set => SetProperty(ref _nodeIDPath, value);
		}

		public interopTerrainNodeInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
