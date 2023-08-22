using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTerrainNodeInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("externalDataSource")] 
		public CBool ExternalDataSource
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isTerrainNode")] 
		public CBool IsTerrainNode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("blendOrder")] 
		public CUInt8 BlendOrder
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("blendModeHeightIsIgnore")] 
		public CBool BlendModeHeightIsIgnore
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("blendModeHeightIsNormal")] 
		public CBool BlendModeHeightIsNormal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("blendModeColorIsIgnore")] 
		public CBool BlendModeColorIsIgnore
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("blendModeHolesIsIgnore")] 
		public CBool BlendModeHolesIsIgnore
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("terrainSysID")] 
		public CUInt16 TerrainSysID
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(10)] 
		[RED("nodeName")] 
		public CString NodeName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("nodeScale")] 
		public Vector3 NodeScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(12)] 
		[RED("nodeTransform")] 
		public Transform NodeTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(13)] 
		[RED("nodeCellResScale")] 
		public CFloat NodeCellResScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("densityTexelSize")] 
		public CFloat DensityTexelSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("nodeIDPath")] 
		public toolsEditorObjectIDPath NodeIDPath
		{
			get => GetPropertyValue<toolsEditorObjectIDPath>();
			set => SetPropertyValue<toolsEditorObjectIDPath>(value);
		}

		public interopTerrainNodeInfo()
		{
			IsTerrainNode = true;
			NodeScale = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			NodeTransform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			NodeCellResScale = 1.000000F;
			NodeIDPath = new toolsEditorObjectIDPath { Elements = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
