using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioGenericNameEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioGenericNameEventItem> Entries
		{
			get => GetPropertyValue<CArray<audioGenericNameEventItem>>();
			set => SetPropertyValue<CArray<audioGenericNameEventItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioGenericNameEventItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioGenericNameEventItem>>();
			set => SetPropertyValue<CHandle<audioGenericNameEventItem>>(value);
		}

		public audioGenericNameEventDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
