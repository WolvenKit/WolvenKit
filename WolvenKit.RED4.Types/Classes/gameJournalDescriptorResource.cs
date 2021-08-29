using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalDescriptorResource : gameJournalBaseResource
	{
		private CArray<CString> _entriesActivatedAtStart;

		[Ordinal(1)] 
		[RED("entriesActivatedAtStart")] 
		public CArray<CString> EntriesActivatedAtStart
		{
			get => GetProperty(ref _entriesActivatedAtStart);
			set => SetProperty(ref _entriesActivatedAtStart, value);
		}
	}
}
