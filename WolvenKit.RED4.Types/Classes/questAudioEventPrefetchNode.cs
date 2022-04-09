using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioEventPrefetchNode : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("prefetchEvents")] 
		public CArray<questAudioEventPrefetchStruct> PrefetchEvents
		{
			get => GetPropertyValue<CArray<questAudioEventPrefetchStruct>>();
			set => SetPropertyValue<CArray<questAudioEventPrefetchStruct>>(value);
		}

		public questAudioEventPrefetchNode()
		{
			PrefetchEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
