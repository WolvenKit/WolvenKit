using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSceneRecordingNodeFilter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("streamInNodesWithStreamingDistanceMoreThan")] 
		public CFloat StreamInNodesWithStreamingDistanceMoreThan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan")] 
		public CFloat StreamOutPrefabProxyMeshesWithStreamingDistanceMoreThan
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("meshNodesOnly")] 
		public CBool MeshNodesOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("meshResourceFilter")] 
		public worldSceneRecordingNodeMeshResourceFilter MeshResourceFilter
		{
			get => GetPropertyValue<worldSceneRecordingNodeMeshResourceFilter>();
			set => SetPropertyValue<worldSceneRecordingNodeMeshResourceFilter>(value);
		}

		public worldSceneRecordingNodeFilter()
		{
			MeshNodesOnly = true;
			MeshResourceFilter = new() { ForceFilterIgnore = new(), ForceFilterMatch = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
