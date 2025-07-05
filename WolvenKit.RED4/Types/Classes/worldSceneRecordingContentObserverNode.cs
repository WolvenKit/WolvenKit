using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSceneRecordingContentObserverNode : worldNode
	{
		[Ordinal(4)] 
		[RED("filter")] 
		public worldSceneRecordingNodeFilter Filter
		{
			get => GetPropertyValue<worldSceneRecordingNodeFilter>();
			set => SetPropertyValue<worldSceneRecordingNodeFilter>(value);
		}

		public worldSceneRecordingContentObserverNode()
		{
			Filter = new worldSceneRecordingNodeFilter { MeshNodesOnly = true, MeshResourceFilter = new worldSceneRecordingNodeMeshResourceFilter { ForceFilterIgnore = new(), ForceFilterMatch = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
