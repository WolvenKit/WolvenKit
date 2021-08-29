using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalRequestContext : RedBaseClass
	{
		private gameJournalRequestStateFilter _stateFilter;
		private gameJournalRequestClassFilter _classFilter;

		[Ordinal(0)] 
		[RED("stateFilter")] 
		public gameJournalRequestStateFilter StateFilter
		{
			get => GetProperty(ref _stateFilter);
			set => SetProperty(ref _stateFilter, value);
		}

		[Ordinal(1)] 
		[RED("classFilter")] 
		public gameJournalRequestClassFilter ClassFilter
		{
			get => GetProperty(ref _classFilter);
			set => SetProperty(ref _classFilter, value);
		}
	}
}
