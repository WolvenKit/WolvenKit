using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioEventPrefetchNode : questIAudioNodeType
	{
		private CArray<questAudioEventPrefetchStruct> _prefetchEvents;

		[Ordinal(0)] 
		[RED("prefetchEvents")] 
		public CArray<questAudioEventPrefetchStruct> PrefetchEvents
		{
			get => GetProperty(ref _prefetchEvents);
			set => SetProperty(ref _prefetchEvents, value);
		}
	}
}
