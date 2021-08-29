using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSceneRecordingContentObserverNode : worldNode
	{
		private worldSceneRecordingNodeFilter _filter;

		[Ordinal(4)] 
		[RED("filter")] 
		public worldSceneRecordingNodeFilter Filter
		{
			get => GetProperty(ref _filter);
			set => SetProperty(ref _filter, value);
		}
	}
}
