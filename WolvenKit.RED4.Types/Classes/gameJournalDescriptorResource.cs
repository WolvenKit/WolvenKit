using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalDescriptorResource : gameJournalBaseResource
	{
		[Ordinal(1)] 
		[RED("entriesActivatedAtStart")] 
		public CArray<CString> EntriesActivatedAtStart
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public gameJournalDescriptorResource()
		{
			EntriesActivatedAtStart = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
