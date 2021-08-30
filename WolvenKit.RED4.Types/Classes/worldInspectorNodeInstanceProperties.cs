using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldInspectorNodeInstanceProperties : ISerializable
	{
		private worldCompiledNodeInstanceSetupInfo _setupInfo;
		private CHandle<worldMeshNode> _meshNode;
		private CHandle<worldInstancedMeshNode> _instancedMeshNode;
		private CFloat _lastObserverDistanceToStreamingPoint;
		private CFloat _lastObserverDistanceToSecondaryReferencePoint;
		private CUInt64 _renderProxyAddressForDebug;

		[Ordinal(0)] 
		[RED("setupInfo")] 
		public worldCompiledNodeInstanceSetupInfo SetupInfo
		{
			get => GetProperty(ref _setupInfo);
			set => SetProperty(ref _setupInfo, value);
		}

		[Ordinal(1)] 
		[RED("meshNode")] 
		public CHandle<worldMeshNode> MeshNode
		{
			get => GetProperty(ref _meshNode);
			set => SetProperty(ref _meshNode, value);
		}

		[Ordinal(2)] 
		[RED("instancedMeshNode")] 
		public CHandle<worldInstancedMeshNode> InstancedMeshNode
		{
			get => GetProperty(ref _instancedMeshNode);
			set => SetProperty(ref _instancedMeshNode, value);
		}

		[Ordinal(3)] 
		[RED("lastObserverDistanceToStreamingPoint")] 
		public CFloat LastObserverDistanceToStreamingPoint
		{
			get => GetProperty(ref _lastObserverDistanceToStreamingPoint);
			set => SetProperty(ref _lastObserverDistanceToStreamingPoint, value);
		}

		[Ordinal(4)] 
		[RED("lastObserverDistanceToSecondaryReferencePoint")] 
		public CFloat LastObserverDistanceToSecondaryReferencePoint
		{
			get => GetProperty(ref _lastObserverDistanceToSecondaryReferencePoint);
			set => SetProperty(ref _lastObserverDistanceToSecondaryReferencePoint, value);
		}

		[Ordinal(5)] 
		[RED("renderProxyAddressForDebug")] 
		public CUInt64 RenderProxyAddressForDebug
		{
			get => GetProperty(ref _renderProxyAddressForDebug);
			set => SetProperty(ref _renderProxyAddressForDebug, value);
		}

		public worldInspectorNodeInstanceProperties()
		{
			_lastObserverDistanceToStreamingPoint = -1.000000F;
			_lastObserverDistanceToSecondaryReferencePoint = -1.000000F;
		}
	}
}
