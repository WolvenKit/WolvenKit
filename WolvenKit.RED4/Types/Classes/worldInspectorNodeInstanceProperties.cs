using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInspectorNodeInstanceProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("setupInfo")] 
		public worldCompiledNodeInstanceSetupInfo SetupInfo
		{
			get => GetPropertyValue<worldCompiledNodeInstanceSetupInfo>();
			set => SetPropertyValue<worldCompiledNodeInstanceSetupInfo>(value);
		}

		[Ordinal(1)] 
		[RED("meshNode")] 
		public CHandle<worldMeshNode> MeshNode
		{
			get => GetPropertyValue<CHandle<worldMeshNode>>();
			set => SetPropertyValue<CHandle<worldMeshNode>>(value);
		}

		[Ordinal(2)] 
		[RED("instancedMeshNode")] 
		public CHandle<worldInstancedMeshNode> InstancedMeshNode
		{
			get => GetPropertyValue<CHandle<worldInstancedMeshNode>>();
			set => SetPropertyValue<CHandle<worldInstancedMeshNode>>(value);
		}

		[Ordinal(3)] 
		[RED("lastObserverDistanceToStreamingPoint")] 
		public CFloat LastObserverDistanceToStreamingPoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lastObserverDistanceToSecondaryReferencePoint")] 
		public CFloat LastObserverDistanceToSecondaryReferencePoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("renderProxyAddressForDebug")] 
		public CUInt64 RenderProxyAddressForDebug
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public worldInspectorNodeInstanceProperties()
		{
			SetupInfo = new();
			LastObserverDistanceToStreamingPoint = -1.000000F;
			LastObserverDistanceToSecondaryReferencePoint = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
