using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNodesGroup : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(2)] 
		[RED("groupUniqueId")] 
		public CRUID GroupUniqueId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(3)] 
		[RED("nodes")] 
		public CArray<CHandle<worldNode>> Nodes
		{
			get => GetPropertyValue<CArray<CHandle<worldNode>>>();
			set => SetPropertyValue<CArray<CHandle<worldNode>>>(value);
		}

		[Ordinal(4)] 
		[RED("subGroups")] 
		public CArray<CHandle<worldNodesGroup>> SubGroups
		{
			get => GetPropertyValue<CArray<CHandle<worldNodesGroup>>>();
			set => SetPropertyValue<CArray<CHandle<worldNodesGroup>>>(value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeGroupType> Type
		{
			get => GetPropertyValue<CEnum<worldNodeGroupType>>();
			set => SetPropertyValue<CEnum<worldNodeGroupType>>(value);
		}

		[Ordinal(6)] 
		[RED("keepPosition")] 
		public CBool KeepPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(8)] 
		[RED("transformCalculated")] 
		public CBool TransformCalculated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("customPivotOffset")] 
		public Transform CustomPivotOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(10)] 
		[RED("proxyMeshGroupBuildParams")] 
		public worldProxyMeshGroupBuildParams ProxyMeshGroupBuildParams
		{
			get => GetPropertyValue<worldProxyMeshGroupBuildParams>();
			set => SetPropertyValue<worldProxyMeshGroupBuildParams>(value);
		}

		[Ordinal(11)] 
		[RED("proxyMesh")] 
		public CResourceAsyncReference<CMesh> ProxyMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(12)] 
		[RED("proxyDistanceFactor")] 
		public CFloat ProxyDistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("metadataArray")] 
		public CArray<CHandle<worldPrefabMetadata>> MetadataArray
		{
			get => GetPropertyValue<CArray<CHandle<worldPrefabMetadata>>>();
			set => SetPropertyValue<CArray<CHandle<worldPrefabMetadata>>>(value);
		}

		public worldNodesGroup()
		{
			Nodes = new();
			SubGroups = new();
			Transform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			CustomPivotOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			ProxyMeshGroupBuildParams = new() { BuildParams = new() };
			ProxyDistanceFactor = 1.000000F;
			MetadataArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
