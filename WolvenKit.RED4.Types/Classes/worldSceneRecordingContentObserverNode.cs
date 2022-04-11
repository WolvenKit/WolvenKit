using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Filter = new() { MeshNodesOnly = true, MeshResourceFilter = new() { ForceFilterIgnore = new(), ForceFilterMatch = new() } };
		}
	}
}
