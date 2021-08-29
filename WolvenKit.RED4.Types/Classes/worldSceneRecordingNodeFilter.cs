using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSceneRecordingNodeFilter : RedBaseClass
	{
		private CFloat _streamInNodesWithStreamingDistanceMoreThan;
		private CFloat _streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan;
		private CBool _meshNodesOnly;
		private worldSceneRecordingNodeMeshResourceFilter _meshResourceFilter;

		[Ordinal(0)] 
		[RED("streamInNodesWithStreamingDistanceMoreThan")] 
		public CFloat StreamInNodesWithStreamingDistanceMoreThan
		{
			get => GetProperty(ref _streamInNodesWithStreamingDistanceMoreThan);
			set => SetProperty(ref _streamInNodesWithStreamingDistanceMoreThan, value);
		}

		[Ordinal(1)] 
		[RED("streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan")] 
		public CFloat StreamOutPrefabProxyMeshesWithStreamingDistanceMoreThan
		{
			get => GetProperty(ref _streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan);
			set => SetProperty(ref _streamOutPrefabProxyMeshesWithStreamingDistanceMoreThan, value);
		}

		[Ordinal(2)] 
		[RED("meshNodesOnly")] 
		public CBool MeshNodesOnly
		{
			get => GetProperty(ref _meshNodesOnly);
			set => SetProperty(ref _meshNodesOnly, value);
		}

		[Ordinal(3)] 
		[RED("meshResourceFilter")] 
		public worldSceneRecordingNodeMeshResourceFilter MeshResourceFilter
		{
			get => GetProperty(ref _meshResourceFilter);
			set => SetProperty(ref _meshResourceFilter, value);
		}
	}
}
