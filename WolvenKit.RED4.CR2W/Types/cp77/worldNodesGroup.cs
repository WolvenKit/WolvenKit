using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodesGroup : ISerializable
	{
		private CName _name;
		private CUInt64 _id;
		private CRUID _groupUniqueId;
		private CArray<CHandle<worldNode>> _nodes;
		private CArray<CHandle<worldNodesGroup>> _subGroups;
		private CEnum<worldNodeGroupType> _type;
		private CBool _keepPosition;
		private Transform _transform;
		private CBool _transformCalculated;
		private Transform _customPivotOffset;
		private worldProxyMeshGroupBuildParams _proxyMeshGroupBuildParams;
		private raRef<CMesh> _proxyMesh;
		private CFloat _proxyDistanceFactor;
		private CArray<CHandle<worldPrefabMetadata>> _metadataArray;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(2)] 
		[RED("groupUniqueId")] 
		public CRUID GroupUniqueId
		{
			get => GetProperty(ref _groupUniqueId);
			set => SetProperty(ref _groupUniqueId, value);
		}

		[Ordinal(3)] 
		[RED("nodes")] 
		public CArray<CHandle<worldNode>> Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}

		[Ordinal(4)] 
		[RED("subGroups")] 
		public CArray<CHandle<worldNodesGroup>> SubGroups
		{
			get => GetProperty(ref _subGroups);
			set => SetProperty(ref _subGroups, value);
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<worldNodeGroupType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(6)] 
		[RED("keepPosition")] 
		public CBool KeepPosition
		{
			get => GetProperty(ref _keepPosition);
			set => SetProperty(ref _keepPosition, value);
		}

		[Ordinal(7)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(8)] 
		[RED("transformCalculated")] 
		public CBool TransformCalculated
		{
			get => GetProperty(ref _transformCalculated);
			set => SetProperty(ref _transformCalculated, value);
		}

		[Ordinal(9)] 
		[RED("customPivotOffset")] 
		public Transform CustomPivotOffset
		{
			get => GetProperty(ref _customPivotOffset);
			set => SetProperty(ref _customPivotOffset, value);
		}

		[Ordinal(10)] 
		[RED("proxyMeshGroupBuildParams")] 
		public worldProxyMeshGroupBuildParams ProxyMeshGroupBuildParams
		{
			get => GetProperty(ref _proxyMeshGroupBuildParams);
			set => SetProperty(ref _proxyMeshGroupBuildParams, value);
		}

		[Ordinal(11)] 
		[RED("proxyMesh")] 
		public raRef<CMesh> ProxyMesh
		{
			get => GetProperty(ref _proxyMesh);
			set => SetProperty(ref _proxyMesh, value);
		}

		[Ordinal(12)] 
		[RED("proxyDistanceFactor")] 
		public CFloat ProxyDistanceFactor
		{
			get => GetProperty(ref _proxyDistanceFactor);
			set => SetProperty(ref _proxyDistanceFactor, value);
		}

		[Ordinal(13)] 
		[RED("metadataArray")] 
		public CArray<CHandle<worldPrefabMetadata>> MetadataArray
		{
			get => GetProperty(ref _metadataArray);
			set => SetProperty(ref _metadataArray, value);
		}

		public worldNodesGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
