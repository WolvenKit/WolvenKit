using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSceneRecordingContentObserverNode : worldNode
	{
		[Ordinal(2)] 
		[RED("filter")] 
		public worldSceneRecordingNodeFilter Filter
		{
			get => GetPropertyValue<worldSceneRecordingNodeFilter>();
			set => SetPropertyValue<worldSceneRecordingNodeFilter>(value);
		}

		public worldSceneRecordingContentObserverNode()
		{
			Filter = new worldSceneRecordingNodeFilter();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
